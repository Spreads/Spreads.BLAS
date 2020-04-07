using System;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Types;
using Type = CppSharp.AST.Type;

namespace BindGen
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ConsoleDriver.Run(new MklLibrary());
        }
    }

    public class MklLibrary : ILibrary
    {
        public void Preprocess(Driver driver, ASTContext ctx)
        {
            driver.Context.TypeMaps.TypeMaps.Add("MKL_Complex8", new ComplexFloat());
            driver.Context.TypeMaps.TypeMaps.Add("MKL_Complex16", new ComplexDouble());
            
            ctx.IgnoreFunctionWithPattern("^/(?!LAPACKE|mkl|cblas)([A-Za-z0-9_]+)$");
        }

        public void Postprocess(Driver driver, ASTContext ctx)
        {
        }

        public void Setup(Driver driver)
        {
            var options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;

            options.OutputDir = @"..\..\Generated\MKL";
            options.Verbose = true;
            options.GenerateSingleCSharpFile = false;
            options.GenerateFunctionTemplates = false;

            driver.Options.CheckSymbols = false;

            var module = options.AddModule("mkl_");

            module.IncludeDirs.Add(@"..\..\..\..\lib\MKL\include\");

            module.Headers.Add("mkl.h");
            module.Headers.Add("mkl_cblas.h");
            module.Headers.Add("mkl_lapacke.h");

            // module.Defines.Add("MKL_ILP64");
            
            module.OutputNamespace = "Spreads.BLAS.MKL";
            
        }

        public void SetupPasses(Driver driver)
        {
        }
    }

    
    public class OpenBlasLibrary : ILibrary
    {
        public void Preprocess(Driver driver, ASTContext ctx)
        {
            driver.Context.TypeMaps.TypeMaps.Add("openblas_complex_float", new ComplexFloat());
            driver.Context.TypeMaps.TypeMaps.Add("openblas_complex_double", new ComplexDouble());
            driver.Context.TypeMaps.TypeMaps.Add("lapack_complex_float", new ComplexFloat());
            driver.Context.TypeMaps.TypeMaps.Add("lapack_complex_double", new ComplexDouble());

            ctx.IgnoreFunctionWithPattern("^/(?!LAPACKE|openblas|cblas)([A-Za-z0-9_]+)$");
            ctx.IgnoreHeadersWithName("lapack.h");
            ctx.IgnoreHeadersWithName("lapacke_config.h");
        }

        public void Postprocess(Driver driver, ASTContext ctx)
        {
        }

        public void Setup(Driver driver)
        {
            var options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;

            options.OutputDir = @"..\..\Generated\OpenBLAS";
            options.Verbose = true;
            options.GenerateSingleCSharpFile = false;
            options.GenerateFunctionTemplates = false;

            driver.Options.CheckSymbols = false;

            var module = options.AddModule("libopenblas");

            module.IncludeDirs.Add(@"..\..\..\..\lib\OpenBLAS\include\");

            module.Headers.Add("cblas.h");
            module.Headers.Add("lapacke.h");

            module.Defines.Add("HAVE_LAPACK_CONFIG_H");
            module.Defines.Add("LAPACK_COMPLEX_STRUCTURE");
            module.Defines.Add("OPENBLAS_COMPLEX_STRUCT");

            module.OutputNamespace = "Spreads.BLAS.OpenBLAS";
            
        }

        public void SetupPasses(Driver driver)
        {
        }
    }

    public class OpenBlasLibraryTest : ILibrary
    {
        public void Preprocess(Driver driver, ASTContext ctx)
        {
            // driver.Context.TypeMaps.TypeMaps.Add( "openblas_complex_float", new OpenBlasSingle());
            driver.Context.TypeMaps.TypeMaps.Add("lapack_complex_float", new ComplexFloat());

            // ctx.IgnoreFunctionWithPattern("^_");
            ctx.IgnoreFunctionWithPattern("^/(?!LAPACKE|openblas|cblas)([a-z0-9_]+)$");
            // ConvertTypesToPortable(ctx, t => t.Declaration.Name == "Complex", PrimitiveType.UIntPtr);
            // ctx.SetClassAsValueType("OpenblasComplexFloat");
        }

        public void Postprocess(Driver driver, ASTContext ctx)
        {
            // IEnumerable<Class> classes = ctx.FindClass("OpenblasComplexFloat")
            //     .Concat(ctx.FindClass("OpenblasComplexDouble"))
            //     // .Concat(ctx.FindClass("MKLVersion"))
            //     // .Concat(ctx.FindClass("VSLBRngProperties")) //mkl_vs
            //     // .Concat(ctx.FindClass("SparseMatrix")).Concat(ctx.FindClass("MatrixDescr")).Concat(ctx.FindClass("SparseVector")).Concat(ctx.FindClass("ReplaceOperation"))
            //     ;
            //
            // foreach (Class c in classes)
            // {
            //     c.GenerationKind = GenerationKind.Internal;
            //     c.Type = ClassType.ValueType;
            //     c.IsOpaque = true;
            //     // ctx.SetClassAsValueType(c.Name);
            //
            // }

            // foreach (var ctxTranslationUnit in ctx.TranslationUnits)
            // {
            //     foreach (var function in ctxTranslationUnit.Functions)
            //     {
            //         function.CallingConvention = CallingConvention.C;
            //         function.GenerationKind = GenerationKind.Generate;
            //     }
            // }

            // ctx.FindFunction("asd").First().CallingConvention = CallingConvention.C;
            // ctx.FindFunction("asd").First().GenerationKind = GenerationKind.Internal;

            // ctx.SetClassAsValueType("Foo");
        }

        public void Setup(Driver driver)
        {
            DriverOptions options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;

            options.OutputDir = @"..\..\Generated";
            options.Verbose = true;
            options.GenerateSingleCSharpFile = false;
            options.MarshalCharAsManagedChar = false;
            options.GenerateFunctionTemplates = false;
            // options.CompileCode = false;

            // driver.ParserOptions.NoBuiltinIncludes = true;
            // driver.ParserOptions.NoStandardIncludes = true;
            // driver.ParserOptions.TargetTriple = "";
            // driver.ParserOptions.ForceClangToolchainLookup = true;
            // driver.ParserOptions.Defines.Add("");
            // Module.Defines.Add("MKL_CALL_CONV=__cdecl");
            // driver.ParserOptions.LanguageVersion = LanguageVersion.C99_GNU;
            // driver.ParserOptions.MicrosoftMode = false;
            // driver.ParserOptions.Verbose = true;

            driver.Options.CheckSymbols = false;
            driver.ParserOptions.SetupMSVC(VisualStudioVersion.VS2017);

            var module = options.AddModule("cblas");
            module.IncludeDirs.Add(@"..\..\..\..\lib\OpenBLAS\include\");
            // module.IncludeDirs.Add(@"..\..\..\..\lib\OpenBLAS\lib\");
            // module.IncludeDirs.Add(@"C:\Program Files\LLVM\lib\clang\10.0.0\include");
            // module.IncludeDirs.Add(@"C:\Program Files\LLVM\lib\clang\10.0.0\include");

            // module.Headers.Add("lapacke.h");
            module.Headers.Add("cblas.h");
            module.Headers.Add("lapacke.h");
            // module.Libraries.Add("openblas.lib");
            module.OutputNamespace = "OpenBLAS";
            //
            // var module1 = options.AddModule("lapacke");
            // module1.IncludeDirs.Add(@"..\..\..\..\lib\OpenBLAS\include\");
            // module1.Headers.Add("lapacke.h");
            // module1.OutputNamespace = "lapacke";

            // module1.Defines.Add("HAVE_LAPACK_CONFIG_H");
            // module1.Defines.Add("LAPACK_COMPLEX_STRUCTURE");
            // module1.Dependencies.Add(module);
            // module.
        }

        public void SetupPasses(Driver driver)
        {
            // driver.AddTranslationUnitPass(new TestPass());
        }

        /// <summary>
        ///     Convert size_t to UIntPtr (pointer sized uint)
        /// </summary>
        /// <param name="context"></param>
        public static void ConvertTypesToPortable(ASTContext context, Func<TypedefType, bool> matchFunc,
            PrimitiveType primitiveType)
        {
            foreach (TranslationUnit tu in context.TranslationUnits)
            {
                Console.WriteLine(tu.OriginalName);
                var sizeT = tu.FindTypedef("size_t", false);
                if (sizeT != null)
                {
                    ModifyPrimitiveTypeDef(sizeT.Type, matchFunc, primitiveType);
                }
            }

            foreach (TranslationUnit tu in context.TranslationUnits)
            {
                foreach (Function func in tu.Functions)
                {
                    foreach (Parameter param in func.Parameters)
                    {
                        ModifyPrimitiveTypeDef(param.Type, matchFunc, primitiveType);
                    }
                }

                foreach (Class @class in tu.Classes)
                {
                    foreach (Field field in @class.Fields)
                    {
                        ModifyPrimitiveTypeDef(field.Type, matchFunc, primitiveType);
                    }
                }
            }
        }

        private static void ModifyPrimitiveTypeDef(Type type, Func<TypedefType, bool> matchFunc,
            PrimitiveType primitiveType)
        {
            var typedefType = type as TypedefType;
            if (typedefType != null)
            {
                if (matchFunc(typedefType))
                {
                    if ((typedefType.Declaration.QualifiedType.Type is BuiltinType) &&
                        ((BuiltinType) typedefType.Declaration.QualifiedType.Type).Type == primitiveType)
                        return;

                    typedefType.Declaration.QualifiedType =
                        new QualifiedType(new BuiltinType(primitiveType),
                            typedefType.Declaration.QualifiedType.Qualifiers);
                }
            }
        }
    }

    // public class TestPass : TranslationUnitPass
    // {
    //     public override bool VisitDeclaration(Declaration decl)
    //     {
    //         if (this.AlreadyVisited(decl))
    //             return false;
    //
    //         if (decl.Name.ToLower().Contains("complex"))
    //         {
    //             Console.WriteLine(decl.Name);
    //         }
    //
    //         return base.VisitDeclaration(decl);
    //     }
    // }

    public class ComplexFloat : TypeMap
    {
        public override bool DoesMarshalling => true;

        public override bool IsIgnored => false;

        public override bool IsValueType => true;

        public override Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("Spreads.BLAS.ComplexFloat");
        }
    }

    public class ComplexDouble : TypeMap
    {
        public override bool DoesMarshalling => true;

        public override bool IsIgnored => false;

        public override bool IsValueType => true;

        public override Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("Spreads.BLAS.ComplexDouble");
        }
    }
}