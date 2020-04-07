using System;
using System.Reflection;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Passes;
using CppSharp.Types;
using Type = CppSharp.AST.Type;

namespace BindGen
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HiLevelGen();
            // ConsoleDriver.Run(new OpenBlasLibrary());
            // ConsoleDriver.Run(new MklLibrary());
        }

        private static void HiLevelGen()
        {
            var obt = typeof(Spreads.Native.OpenBLAS);
            var methods = obt.GetMethods(BindingFlags.Static);
        }
    }

    
    public class MklLibrary : ILibrary
    {
        public void Preprocess(Driver driver, ASTContext ctx)
        {
            driver.Context.TypeMaps.TypeMaps.Add("MKL_Complex8", new ComplexFloat());
            driver.Context.TypeMaps.TypeMaps.Add("MKL_Complex16", new ComplexDouble());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_LAYOUT", new CBLAS_LAYOUT());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_TRANSPOSE", new CBLAS_TRANSPOSE());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_UPLO", new CBLAS_UPLO());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_DIAG", new CBLAS_DIAG());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_SIDE", new CBLAS_SIDE());

            driver.Context.TypeMaps.TypeMaps.Add("MKL_LAYOUT", new CBLAS_LAYOUT());
            driver.Context.TypeMaps.TypeMaps.Add("MKL_TRANSPOSE", new CBLAS_TRANSPOSE());
            driver.Context.TypeMaps.TypeMaps.Add("MKL_UPLO", new CBLAS_UPLO());
            driver.Context.TypeMaps.TypeMaps.Add("MKL_DIAG", new CBLAS_DIAG());
            driver.Context.TypeMaps.TypeMaps.Add("MKL_SIDE", new CBLAS_SIDE());

            ctx.IgnoreFunctionWithPattern("^/(?!LAPACKE|mkl|cblas)([A-Za-z0-9_]+)$");
            ctx.IgnoreFunctionWithPattern("_batch$");
            ctx.IgnoreFunctionWithPattern("_pack$");
            ctx.IgnoreFunctionWithPattern("_compute$");
            ctx.IgnoreFunctionWithPattern("_alloc$");
            ctx.IgnoreFunctionWithPattern("_free$");
            ctx.IgnoreFunctionWithPattern("_pack_get_size$");
            ctx.IgnoreFunctionWithPattern("_pack_get_size$");
            ctx.IgnoreFunctionWithPattern("_jit_");
            ctx.IgnoreFunctionWithPattern("s16s16s32");
            ctx.IgnoreFunctionWithPattern("s8u8s32");

            ctx.IgnoreEnumWithMatchingItem("CBLAS_STORAGE");
            ctx.IgnoreEnumWithMatchingItem("CBLAS_IDENTIFIER");
            ctx.IgnoreEnumWithMatchingItem("CBLAS_OFFSET");
            ctx.IgnoreEnumWithMatchingItem("MklJitStatusT");
            ctx.IgnoreEnumWithMatchingItem("MKL_COMPACT_PACK");
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

            var module = options.AddModule("mkl_rt");

            module.IncludeDirs.Add(@"..\..\..\..\lib\MKL\include\");

            // module.Headers.Add("mkl.h");
            module.Headers.Add("mkl_cblas.h");
            module.Headers.Add("mkl_lapacke.h");

            // module.Defines.Add("MKL_ILP64");

            module.OutputNamespace = "Spreads.Native.MKL";
        }

        public void SetupPasses(Driver driver)
        {
            driver.AddTranslationUnitPass(new RemoveFunctionPrefixPass());
        }
    }

    public class OpenBlasLibrary : ILibrary
    {
        public void Preprocess(Driver driver, ASTContext ctx)
        {
            driver.Context.TypeMaps.TypeMaps.Add("openblas_complex_float", new ComplexFloat());
            driver.Context.TypeMaps.TypeMaps.Add("openblas_complex_double", new ComplexDouble());
            // driver.Context.TypeMaps.TypeMaps.Add("lapack_complex_float", new ComplexFloat());
            // driver.Context.TypeMaps.TypeMaps.Add("lapack_complex_double", new ComplexDouble());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_ORDER", new CBLAS_LAYOUT());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_TRANSPOSE", new CBLAS_TRANSPOSE());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_UPLO", new CBLAS_UPLO());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_DIAG", new CBLAS_DIAG());
            driver.Context.TypeMaps.TypeMaps.Add("CBLAS_SIDE", new CBLAS_SIDE());

            ctx.IgnoreFunctionWithPattern("^/(?!LAPACKE|openblas|cblas)([A-Za-z0-9_]+)$");
            ctx.IgnoreHeadersWithName("lapack.h");
            // ctx.IgnoreHeadersWithName("lapacke_config.h");
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

            module.OutputNamespace = "Spreads.Native.OpenBLAS";
        }

        public void SetupPasses(Driver driver)
        {
            driver.AddTranslationUnitPass(new RemoveFunctionPrefixPass());
        }
    }

    public class ComplexFloat : TypeMap
    {
        public override bool DoesMarshalling => true;

        public override bool IsIgnored => false;

        public override bool IsValueType => true;

        public override Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("Spreads.ComplexFloat");
        }
    }

    public class ComplexDouble : TypeMap
    {
        public override bool DoesMarshalling => true;

        public override bool IsIgnored => false;

        public override bool IsValueType => true;

        public override Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("Spreads.ComplexDouble");
        }
    }

    public class CBLAS_LAYOUT : TypeMap
    {
        public override bool DoesMarshalling => true;

        public override bool IsIgnored => false;

        public override bool IsValueType => true;

        public override Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("Spreads.BLAS.LAYOUT");
        }
    }

    public class CBLAS_TRANSPOSE : TypeMap
    {
        public override bool DoesMarshalling => true;

        public override bool IsIgnored => false;

        public override bool IsValueType => true;

        public override Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("Spreads.BLAS.TRANSPOSE");
        }
    }

    public class CBLAS_UPLO : TypeMap
    {
        public override bool DoesMarshalling => true;

        public override bool IsIgnored => false;

        public override bool IsValueType => true;

        public override Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("Spreads.BLAS.UPLO");
        }
    }

    public class CBLAS_DIAG : TypeMap
    {
        public override bool DoesMarshalling => true;

        public override bool IsIgnored => false;

        public override bool IsValueType => true;

        public override Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("Spreads.BLAS.DIAG");
        }
    }

    public class CBLAS_SIDE : TypeMap
    {
        public override bool DoesMarshalling => true;

        public override bool IsIgnored => false;

        public override bool IsValueType => true;

        public override Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("Spreads.BLAS.SIDE");
        }
    }

    public class RemoveFunctionPrefixPass : TranslationUnitPass
    {
        public override bool VisitFunctionDecl(Function function)
        {
            if (function.Name.StartsWith("cblas_"))
            {
                function.Name = function.Name.Replace("cblas_", string.Empty);
                return false;
            }

            if (function.Name.StartsWith("LAPACKE_"))
            {
                function.Name = function.Name.Replace("LAPACKE_", string.Empty);
                return false;
            }

            return true;
        }
    }
}