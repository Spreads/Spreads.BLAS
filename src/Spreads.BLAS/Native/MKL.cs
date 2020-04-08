// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Runtime.InteropServices;
using System.Security;

// ReSharper disable InconsistentNaming
namespace Spreads.Native
{
    public static unsafe partial class MKL
    {
        public static readonly bool IsSupoprted = Init();

        private static bool Init()
        {
            try
            {
                return BLASSettings.UseMKLIfAvailable && MKL_GetMaxThreads() > 0;
            }
            catch
            {
                // ignored
            }

            return false;
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Get_Version")]
        public static extern void MKL_GetVersion(global::System.IntPtr ver);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Get_Version_String")]
        public static extern void MKL_GetVersionString(sbyte* buffer, int len);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Free_Buffers")]
        public static extern void MKL_FreeBuffers();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Thread_Free_Buffers")]
        public static extern void MKL_ThreadFreeBuffers();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Mem_Stat")]
        public static extern long MKL_MemStat(int* nbuffers);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Peak_Mem_Usage")]
        public static extern long MKL_PeakMemUsage(int reset);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Get_Cpu_Clocks")]
        public static extern void MKL_GetCpuClocks(ulong* _0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Get_Cpu_Frequency")]
        public static extern double MKL_GetCpuFrequency();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Get_Max_Cpu_Frequency")]
        public static extern double MKL_GetMaxCpuFrequency();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Get_Clocks_Frequency")]
        public static extern double MKL_GetClocksFrequency();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Set_Num_Threads_Local")]
        public static extern int MKL_SetNumThreadsLocal(int nth);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Set_Num_Threads")]
        public static extern void MKL_SetNumThreads(int nth);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Get_Max_Threads")]
        public static extern int MKL_GetMaxThreads();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Set_Num_Stripes")]
        public static extern void MKL_SetNumStripes(int nstripes);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Get_Num_Stripes")]
        public static extern int MKL_GetNumStripes();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Domain_Set_Num_Threads")]
        public static extern int MKL_DomainSetNumThreads(int nth, int MKL_DOMAIN);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Domain_Get_Max_Threads")]
        public static extern int MKL_DomainGetMaxThreads(int MKL_DOMAIN);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Set_Dynamic")]
        public static extern void MKL_SetDynamic(int bool_MKL_DYNAMIC);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Get_Dynamic")]
        public static extern int MKL_GetDynamic();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Enable_Instructions")]
        public static extern int MKL_EnableInstructions(int _0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Set_Interface_Layer")]
        public static extern int MKL_SetInterfaceLayer(int code);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Set_Threading_Layer")]
        public static extern int MKL_SetThreadingLayer(int code);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "mkl_set_xerbla")]
        public static extern global::System.IntPtr MklSetXerbla(global::System.IntPtr xerbla);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "mkl_set_progress")]
        public static extern global::System.IntPtr MklSetProgress(global::System.IntPtr progress);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_CBWR_Get")]
        public static extern int MKL_CBWR_Get(int _0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_CBWR_Set")]
        public static extern int MKL_CBWR_Set(int _0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_CBWR_Get_Auto_Branch")]
        public static extern int MKL_CBWR_GetAutoBranch();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Set_Env_Mode")]
        public static extern int MKL_SetEnvMode(int _0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Verbose")]
        public static extern int MKL_Verbose(int _0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Verbose_Output_File")]
        public static extern int MKL_VerboseOutputFile(sbyte* _0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Set_Exit_Handler")]
        public static extern void MKL_SetExitHandler(global::System.IntPtr h);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Set_Memory_Limit")]
        public static extern int MKL_SetMemoryLimit(int mem_type, ulong limit);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "MKL_Finalize")]
        public static extern void MKL_Finalize();
    }
}