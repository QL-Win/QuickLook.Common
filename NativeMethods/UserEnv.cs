using System.Runtime.InteropServices;

namespace QuickLook.Common.NativeMethods;

public static class UserEnv
{
    [DllImport("userenv.dll", SetLastError = true)]
    public static extern bool IsProcessInAppContainer(nint hProcess, out bool isAppContainer);
}
