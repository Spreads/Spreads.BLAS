﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Runtime.InteropServices;
using System.Security;

namespace Spreads.Native
{
    public static unsafe partial class OpenBLAS
    {
        public static readonly bool IsSupoprted = Init();

        private static bool Init()
        {
            try
            {
                return OpenblasGetNumProcs() > 0;
            }
            catch
            {
            }

            return false;
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "openblas_set_num_threads")]
        public static extern void OpenblasSetNumThreads(int num_threads);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "goto_set_num_threads")]
        public static extern void GotoSetNumThreads(int num_threads);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "openblas_get_num_threads")]
        public static extern int OpenblasGetNumThreads();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "openblas_get_num_procs")]
        public static extern int OpenblasGetNumProcs();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "openblas_get_config")]
        public static extern sbyte* OpenblasGetConfig();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "openblas_get_corename")]
        public static extern sbyte* OpenblasGetCorename();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "openblas_get_parallel")]
        public static extern int OpenblasGetParallel();
    }
}