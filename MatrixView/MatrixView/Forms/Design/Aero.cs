﻿using MatrixView.Classes;
using MatrixView.Classes.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MatrixView.Forms.Design
{
    class Aero
    {
        public static void ChangeAccent(IntPtr HWnd, Structs.AccentPolicy accent, bool hasFrame = true)
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                if (hasFrame)
                    accent.AccentFlags = 0x20 | 0x40 | 0x80 | 0x100;

                int accentStructSize = Marshal.SizeOf(accent);

                IntPtr accentPtr = Marshal.AllocHGlobal(accentStructSize);
                Marshal.StructureToPtr(accent, accentPtr, false);

                Structs.WindowCompositionAttributeData data = new Structs.WindowCompositionAttributeData();
                data.Attribute = Enums.WindowCompositionAttribute.WCA_ACCENT_POLICY;
                data.SizeOfData = accentStructSize;
                data.Data = accentPtr;

                WinAPI.SetWindowCompositionAttribute(HWnd, ref data);

                Marshal.FreeHGlobal(accentPtr);
            }
        }
    }
}
