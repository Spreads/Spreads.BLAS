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
        private const string LibName = "mkl_rt";

        // TODO Rename IsAvailable
        public static bool IsSupoprted = MklWorks();

        private static bool MklWorks()
        {
            try
            {
                return GetMaxThreads() > 0;
            }
            catch
            {
                // ignored
            }

            return false;
        }

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Get_Version")]
        public static extern void GetVersion(System.IntPtr ver);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Get_Version_String")]
        public static extern void GetVersionString(sbyte* buffer, int len);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Free_Buffers")]
        public static extern void FreeBuffers();

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Thread_Free_Buffers")]
        public static extern void ThreadFreeBuffers();

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Mem_Stat")]
        public static extern long MemStat(int* nbuffers);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Peak_Mem_Usage")]
        public static extern long PeakMemUsage(int reset);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Get_Cpu_Clocks")]
        public static extern void GetCpuClocks(ulong* _0);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Get_Cpu_Frequency")]
        public static extern double GetCpuFrequency();

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Get_Max_Cpu_Frequency")]
        public static extern double GetMaxCpuFrequency();

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Get_Clocks_Frequency")]
        public static extern double GetClocksFrequency();

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Set_Num_Threads_Local")]
        public static extern int SetNumThreadsLocal(int nth);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Set_Num_Threads")]
        public static extern void SetNumThreads(int nth);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Get_Max_Threads")]
        public static extern int GetMaxThreads();

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Set_Num_Stripes")]
        public static extern void SetNumStripes(int nstripes);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Get_Num_Stripes")]
        public static extern int GetNumStripes();

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Domain_Set_Num_Threads")]
        public static extern int DomainSetNumThreads(int nth, int MKL_DOMAIN);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Domain_Get_Max_Threads")]
        public static extern int DomainGetMaxThreads(int MKL_DOMAIN);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Set_Dynamic")]
        public static extern void SetDynamic(int bool_MKL_DYNAMIC);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Get_Dynamic")]
        public static extern int GetDynamic();

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Enable_Instructions")]
        public static extern int EnableInstructions(int _0);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Set_Interface_Layer")]
        public static extern int SetInterfaceLayer(int code);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Set_Threading_Layer")]
        public static extern int SetThreadingLayer(int code);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mkl_set_xerbla")]
        public static extern System.IntPtr SetXerbla(System.IntPtr xerbla);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mkl_set_progress")]
        public static extern System.IntPtr SetProgress(System.IntPtr progress);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_CBWR_Get")]
        public static extern int CBWRGet(int _0);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_CBWR_Set")]
        public static extern int CBWRSet(int _0);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_CBWR_Get_Auto_Branch")]
        public static extern int CBWRGetAutoBranch();

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Set_Env_Mode")]
        public static extern int SetEnvMode(int _0);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Verbose")]
        public static extern int Verbose(int _0);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Verbose_Output_File")]
        public static extern int VerboseOutputFile(sbyte* _0);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Set_Exit_Handler")]
        public static extern void SetExitHandler(System.IntPtr h);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Set_Memory_Limit")]
        public static extern int SetMemoryLimit(int mem_type, ulong limit);

        [SuppressUnmanagedCodeSecurity, DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MKL_Finalize")]
        public static extern void Finalize();
    }
}