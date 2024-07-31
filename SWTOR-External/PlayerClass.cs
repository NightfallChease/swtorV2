using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SWTOR_External
{
    public class PlayerClass
    {

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
        public struct LocalPlayer
        {
            [FieldOffset(0x68)]
            public readonly float playerX;
            [FieldOffset(0x6C)]
            public readonly float playerY;
            [FieldOffset(0x70)]
            public readonly float playerZ;
            [FieldOffset(0x7C)]
            public readonly double PlayerWidth;
            [FieldOffset(0x84)]
            public readonly float PlayerHeight;
            [FieldOffset(0x470)]
            public readonly IntPtr VelocityPtr;
        }

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
        public struct velocityClass
        {
            [FieldOffset(0x10)]
            public readonly float playerYVelocity;
        }
    }
}
