﻿// Copyright © 2022 Paddy Xu
//
// This file is part of QuickLook program.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Runtime.InteropServices;

namespace QuickLook.Common.NativeMethods;

public static class Dwmapi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Margins
    {
        public int cxLeftWidth;
        public int cxRightWidth;
        public int cyTopHeight;
        public int cyBottomHeight;

        public Margins(int cxLeftWidth, int cxRightWidth, int cyTopHeight, int cyBottomHeight)
        {
            this.cxLeftWidth = cxLeftWidth;
            this.cxRightWidth = cxRightWidth;
            this.cyTopHeight = cyTopHeight;
            this.cyBottomHeight = cyBottomHeight;
        }
    }

    public enum WindowAttribute
    {
        UseImmersiveDarkMode = 20,
        SystembackdropType = 38,
        MicaEffect = 1029
    }

    public enum SystembackdropType
    {
        Auto = 0,
        None = 1,
        MainWindow = 2,
        TransientWindow = 3,
        TabbedWindow = 4
    }

    [DllImport("DwmApi.dll")]
    public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref Margins pMarInset);

    [DllImport("dwmapi.dll")]
    public static extern int DwmSetWindowAttribute(IntPtr hwnd, uint dwAttribute, ref int pvAttribute, int cbAttribute);
}
