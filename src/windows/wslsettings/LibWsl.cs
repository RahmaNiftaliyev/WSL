// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp with tweaks.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using WslSettings;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required

namespace LibWsl
{
    public enum WslConfigEntry
    {
        NoEntry = 0,
        ProcessorCount = 1,
        MemorySizeBytes = 2,
        SwapSizeBytes = 3,
        SwapFilePath = 4,
        VhdSizeBytes = 5,
        NetworkingMode = 6,
        FirewallEnabled = 7,
        IgnoredPorts = 8,
        LocalhostForwardingEnabled = 9,
        HostAddressLoopbackEnabled = 10,
        AutoProxyEnabled = 11,
        InitialAutoProxyTimeout = 12,
        DNSProxyEnabled = 13,
        DNSTunnelingEnabled = 14,
        BestEffortDNSParsingEnabled = 15,
        AutoMemoryReclaim = 16,
        GUIApplicationsEnabled = 17,
        NestedVirtualizationEnabled = 18,
        SafeModeEnabled = 19,
        SparseVHDEnabled = 20,
        VMIdleTimeout = 21,
        DebugConsoleEnabled = 22,
        HardwarePerformanceCountersEnabled = 23,
        KernelPath = 24,
        SystemDistroPath = 25,
        KernelModulesPath = 26
    }

    public enum NetworkingConfiguration
    {
        None = 0,
        Nat = 1,
        Bridged = 2,
        Mirrored = 3,
        VirtioProxy = 4
    }

    public enum MemoryReclaimMode
    {
        Disabled = 0,
        Gradual = 1,
        DropCache = 2
    }

    public unsafe partial class WslConfig
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibWsl.WslConfig> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibWsl.WslConfig>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibWsl.WslConfig managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibWsl.WslConfig managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static WslConfig __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new WslConfig(native.ToPointer(), skipVTables);
        }

        internal static WslConfig __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (WslConfig)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static WslConfig __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new WslConfig(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private WslConfig(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected WslConfig(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    public unsafe partial class WslConfigSetting : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::LibWsl.WslConfigEntry ConfigEntry;

            [FieldOffset(8)]
            internal __IntPtr StringValue;

            [FieldOffset(8)]
            internal ulong UInt64Value;

            [FieldOffset(8)]
            internal int Int32Value;

            [FieldOffset(8)]
            internal byte BoolValue;

            [FieldOffset(8)]
            internal global::LibWsl.NetworkingConfiguration NetworkingConfigurationValue;

            [FieldOffset(8)]
            internal global::LibWsl.MemoryReclaimMode MemoryReclaimModeValue;
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibWsl.WslConfigSetting> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibWsl.WslConfigSetting>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibWsl.WslConfigSetting managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibWsl.WslConfigSetting managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;
        protected bool __ownsNativeStringValueInstance;

        internal static WslConfigSetting __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new WslConfigSetting(native.ToPointer(), skipVTables);
        }

        internal static WslConfigSetting __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (WslConfigSetting)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static WslConfigSetting __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new WslConfigSetting(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private WslConfigSetting(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            __ownsNativeStringValueInstance = false;
        }

        protected WslConfigSetting(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            if (__ownsNativeStringValueInstance && ((__Internal*)__Instance)->StringValue != __IntPtr.Zero)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->StringValue);
            __Instance = IntPtr.Zero;
        }

        public global::LibWsl.WslConfigEntry ConfigEntry
        {
            get
            {
                return ((__Internal*)__Instance)->ConfigEntry;
            }

            set
            {
                ((__Internal*)__Instance)->ConfigEntry = value;
            }
        }

        public string StringValue
        {
            get
            {
                return Marshal.PtrToStringAuto((IntPtr)((__Internal*)__Instance)->StringValue);
            }
            set
            {
                if (__ownsNativeStringValueInstance && ((__Internal*)__Instance)->StringValue != __IntPtr.Zero)
                    Marshal.FreeHGlobal(((__Internal*)__Instance)->StringValue);
                ((__Internal*)__Instance)->StringValue = Marshal.StringToHGlobalAuto(value);
                __ownsNativeStringValueInstance = true;
            }
        }

        public ulong UInt64Value
        {
            get
            {
                return ((__Internal*)__Instance)->UInt64Value;
            }

            set
            {
                ((__Internal*)__Instance)->UInt64Value = value;
            }
        }

        public int Int32Value
        {
            get
            {
                return ((__Internal*)__Instance)->Int32Value;
            }

            set
            {
                ((__Internal*)__Instance)->Int32Value = value;
            }
        }

        public bool BoolValue
        {
            get
            {
                return ((__Internal*)__Instance)->BoolValue != 0;
            }

            set
            {
                ((__Internal*)__Instance)->BoolValue = (byte) (value ? 1 : 0);
            }
        }

        public global::LibWsl.NetworkingConfiguration NetworkingConfigurationValue
        {
            get
            {
                return ((__Internal*)__Instance)->NetworkingConfigurationValue;
            }

            set
            {
                ((__Internal*)__Instance)->NetworkingConfigurationValue = value;
            }
        }

        public global::LibWsl.MemoryReclaimMode MemoryReclaimModeValue
        {
            get
            {
                return ((__Internal*)__Instance)->MemoryReclaimModeValue;
            }

            set
            {
                ((__Internal*)__Instance)->MemoryReclaimModeValue = value;
            }
        }
    }

    public unsafe partial class WslCoreConfigInterface
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport(@"..\libwsl.dll", EntryPoint = "GetWslConfigFilePath", CallingConvention = __CallingConvention.StdCall)]
            internal static extern char* GetWslConfigFilePath();

            [SuppressUnmanagedCodeSecurity, DllImport(@"..\libwsl.dll", EntryPoint = "CreateWslConfig", CallingConvention = __CallingConvention.StdCall)]
            internal static extern __IntPtr CreateWslConfig(char* wslConfigFilePath);

            [SuppressUnmanagedCodeSecurity, DllImport(@"..\libwsl.dll", EntryPoint = "FreeWslConfig", CallingConvention = __CallingConvention.StdCall)]
            internal static extern void FreeWslConfig(__IntPtr wslConfig);

            [SuppressUnmanagedCodeSecurity, DllImport(@"..\libwsl.dll", EntryPoint = "GetWslConfigSetting", CallingConvention = __CallingConvention.StdCall)]
            internal static extern global::LibWsl.WslConfigSetting.__Internal GetWslConfigSetting(__IntPtr wslConfig, global::LibWsl.WslConfigEntry ConfigEntry);

            [SuppressUnmanagedCodeSecurity, DllImport(@"..\libwsl.dll", EntryPoint = "SetWslConfigSetting", CallingConvention = __CallingConvention.StdCall)]
            internal static extern uint SetWslConfigSetting(__IntPtr wslConfig, global::LibWsl.WslConfigSetting.__Internal setting);
        }

        public static string GetWslConfigFilePath()
        {
            var ___ret = __Internal.GetWslConfigFilePath();
            return Marshal.PtrToStringAuto((IntPtr)___ret);
        }

        public static global::LibWsl.WslConfig CreateWslConfig(string wslConfigFilePath)
        {
            var __arg0 = (char*)Marshal.StringToHGlobalAuto(wslConfigFilePath);
            var ___ret = __Internal.CreateWslConfig(__arg0);
            var __result0 = global::LibWsl.WslConfig.__GetOrCreateInstance(___ret, false);
            Marshal.FreeHGlobal((IntPtr)__arg0);
            return __result0;
        }

        public static void FreeWslConfig(global::LibWsl.WslConfig wslConfig)
        {
            var __arg0 = wslConfig is null ? __IntPtr.Zero : wslConfig.__Instance;
            __Internal.FreeWslConfig(__arg0);
        }

        public static global::LibWsl.WslConfigSetting GetWslConfigSetting(global::LibWsl.WslConfig wslConfig, global::LibWsl.WslConfigEntry ConfigEntry)
        {
            var __arg0 = wslConfig is null ? __IntPtr.Zero : wslConfig.__Instance;
            var ___ret = __Internal.GetWslConfigSetting(__arg0, ConfigEntry);
            return global::LibWsl.WslConfigSetting.__CreateInstance(___ret);
        }

        public static uint SetWslConfigSetting(global::LibWsl.WslConfig wslConfig, global::LibWsl.WslConfigSetting setting)
        {
            var __arg0 = wslConfig is null ? __IntPtr.Zero : wslConfig.__Instance;
            if (ReferenceEquals(setting, null))
                throw new global::System.ArgumentNullException("setting", "Cannot be null because it is passed by value.");
            var __arg1 = setting.__Instance;
            var ___ret = __Internal.SetWslConfigSetting(__arg0, *(global::LibWsl.WslConfigSetting.__Internal*) __arg1);
            return ___ret;
        }
    }
}
