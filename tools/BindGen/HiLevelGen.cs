using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

// ReSharper disable HeapView.BoxingAllocation

namespace BindGen
{
    public static class HiLevelGen
    {
        /// <summary>
        /// Generate high level API for all shared functions and the ones available in OB
        /// </summary>
        /// <param name="tOb"></param>
        /// <param name="tMk"></param>
        public static void GenForTypes(string apiName, Type tOb, Type tMk)
        {
            var obMethods = tOb.GetMethods(BindingFlags.Static | BindingFlags.Public)
                .ToDictionary(x => x.Name, x => x);

            var mkMethods = tMk.GetMethods(BindingFlags.Static | BindingFlags.Public)
                .ToDictionary(x => x.Name, x => x);

            var sharedMethods = obMethods.Join(mkMethods, x => x.Key, x => x.Key,
                    (x, y) => (x, y))
                .Select(t => (t.x.Key, t.x.Value, t.y.Value))
                .ToArray();

            Array.Sort(sharedMethods, new TupleComparer());

            var sb = new StringBuilder();

            foreach (var sharedMethod in sharedMethods)
            {
                GenMethod(apiName, sharedMethod, sb);
            }
            
            Directory.CreateDirectory(@"..\..\Generated\HiLevel");
            
            File.WriteAllText($@"..\..\Generated\HiLevel\{apiName}.cspart", sb.ToString());
        }

        private static void GenMethod(string apiName, (string methodName, MethodInfo ob, MethodInfo mk) m, StringBuilder sb)
        {
            var ps = GetMethodParams(m.ob, m.mk);

            var rt = m.ob.ReturnType.ToString();

            var methodBody = 
                rt.ToLower().Contains("void") 
                    ? GenVoidMethod(apiName, m.methodName, ps)
                    : GetReturningMethod(apiName, m.methodName, rt, ps);


            sb.Append(methodBody);
        }

        private static string GenVoidMethod(string apiName, string methodName, (string types, string signature, string args) ps)
        {
            var template = $@"
public static void {methodName}({ps.signature})
{{
    if (MKL.IsSupoprted)
    {{
        MKL.{apiName}.{methodName}({ps.args});
        return;
    }}
    OpenBLAS.{apiName}.{methodName}({ps.args});
}}
";

            return template;
        }

        private static string GetReturningMethod(string apiName, string methodName, string rt, (string types, string signature, string args) ps)
        {
            var template = $@"
public static {rt} {methodName}({ps.signature})
{{
    if (MKL.IsSupoprted)
        return MKL.{apiName}.{methodName}({ps.args});

    return OpenBLAS.{apiName}.{methodName}({ps.args});
}}
";

            return template;
        }

        private static (string types, string signature, string args) GetMethodParams(MethodInfo ob, MethodInfo mk)
        {
            var obPs = GetMethodParams(ob);
            var mkPs = GetMethodParams(mk);

            if (obPs.types != mkPs.types)
                throw new ArgumentException("Types do not match");

            return mkPs;
        }

        private static (string types, string signature, string args) GetMethodParams(MethodInfo mi)
        {
            var obPs = mi.GetParameters();

            var types = "";
            var signature = "";
            var args = "";

            if (obPs.Length > 0)
            {



                foreach (var pi in obPs)
                {
                    var t = pi.ParameterType.ToString();
                    t = t.Replace("+", ".");
                    var n = pi.Name;
                    if (char.IsUpper(n[0]))
                        n = char.ToLower(n[0]) + n.Substring(1);

                    if (n.Length == 4 && n.StartsWith("inc"))
                        n = n.Substring(0, 3) + char.ToUpper(n[3]);

                    if (n.Length == 3 && n.StartsWith("ld"))
                        n = n.Substring(0, 2) + char.ToUpper(n[2]);

                    if (n == "params")
                        n = "parameters";
                    
                    types += t + ", ";
                    signature += t + " " + n + ", ";
                    args += n + ", ";
                }

                types = types.Substring(0, types.Length - 2);
                signature = signature.Substring(0, signature.Length - 2);
                args = args.Substring(0, args.Length - 2);
            }

            return (types, signature, args);
        }

        private class TupleComparer : IComparer<(string, MethodInfo, MethodInfo)>
        {
            private MethodNameComparer _c = new MethodNameComparer();

            public int Compare((string, MethodInfo, MethodInfo) x, (string, MethodInfo, MethodInfo) y)
            {
                return _c.Compare(x.Item1, y.Item1);
            }
        }

        private class MethodNameComparer : IComparer<string>
        {
            private static char[] order = new[] {'s', 'd', 'c', 'z'};

            public int Compare(string x, string y)
            {
                x = x.ToLower();
                y = y.ToLower();
                var xF = x.Substring((1));
                var yF = y.Substring((1));
                var c = String.Compare(xF, yF, StringComparison.Ordinal);
                if (c != 0)
                    return c;

                var xI = Array.IndexOf(order, x[0]);
                var yI = Array.IndexOf(order, y[0]);
                return xI.CompareTo(yI);
            }
        }
    }
}