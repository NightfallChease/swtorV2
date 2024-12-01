using System;
using WindowsInput.Native;

namespace SWTOR_External
{
    [Serializable]
    public class HotkeySettings
    {
        public VirtualKeyCode infJumpKey {  get; set; }
        public VirtualKeyCode TPUpKey { get; set; }
        public VirtualKeyCode TPDownKey { get; set; }
        public VirtualKeyCode TPLeftKey { get; set; }
        public VirtualKeyCode TPRightKey { get; set; }
        public VirtualKeyCode TPForwardKey { get; set; }
        public VirtualKeyCode TPBackwardKey { get; set; }
        public VirtualKeyCode FreecamKey { get; set; }
        public VirtualKeyCode TPToCamKey { get; set; }
        public VirtualKeyCode NofallKey { get; set; }
        public VirtualKeyCode GlideKey { get; set; }
        public VirtualKeyCode SpeedKey { get; set; }
        public VirtualKeyCode flyforwardsKey { get; set; }
        public VirtualKeyCode flybackwardsKey { get; set; }
    }
}
