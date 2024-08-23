// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Runtime.InteropServices;
using System.Security;

namespace Spreads.Native
{
    public static unsafe partial class OpenBLAS
    {
        private const string LibName = "openblas";
        
        public static bool IsSupoprted = Init();

        private static bool Init()
        {
            try
            {
                return GetNumProcs() > 0;
            }
            catch
            {
                ;
            }

            return false;
        }

        [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_set_num_threads")]
        public static extern void SetNumThreads(int numThreads);
        
        [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_get_num_threads")]
        public static extern int GetNumThreads();

        [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_get_num_procs")]
        public static extern int GetNumProcs();

        [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_get_config")]
        public static extern sbyte* GetConfig();

        [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_get_corename")]
        public static extern sbyte* GetCorename();

        [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_get_parallel")]
        public static extern int GetParallel();
    }
}