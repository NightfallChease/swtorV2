using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Memory;
using WindowsInput;
using WindowsInput.Native;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Globalization;

namespace SWTOR_External
{
    public partial class Form1 : MaterialForm
    {
        Random rnd = new Random();
        Mem m = new Mem();
        InputSimulator sim = new InputSimulator();

        #region vars
        private bool darkmodeEnabled = false;
        private string urlRunning = "https://github.com/NightfallChease/s/blob/main/isRunning.sw";
        private string urlUpdate = "https://github.com/NightfallChease/s/blob/main/version7.6.1.sw";
        private string currentVersion = "v7.6.1";
        private bool noclipPatched = false;
        private bool cameraPatched = false;
        private bool cameraZPatched = false;
        private bool cameraYPatched = false;
        private bool noCollisionEnabled = false;
        private bool noclipCave = false;
        private bool camCave = false;
        private bool freeCamEnabled = false;
        private bool attachToCamEnabled = false;
        private bool nofallEnabled = false;
        private bool nofallPatched = false;
        private bool alwaysOnTop = false;
        private bool devEspEnabled = false;
        private bool devVelEnabled = false;
        private string noclipAOB = "EA 00 00 00 48 8B 01 48 8B 40 58";
        private string cameraAOB = "48 8B 01 48 8B 80 F0 01 00 00 FF 15 ?? ?? ?? ?? EB 07 48 8D 05 ?? ?? ?? ?? 0F";
        private string cameraYAOB = "F2 0F 11 87 28 02 00 00";
        private string cameraZAOB = "89 87 30 02 00 00 F3";
        private string nofallAOB = "F3 44 0F 10 4F 10 44 0F 28 DF";
        private string speedHackAOB = "F3 0F 10 BE F4 00 00 00 0F 28 F7";
        private string devESPAob = "0F 84 ?? ?? ?? ?? B9 06 00 00 00 41 FF D4 48 BE";
        private string velocityIndicatorAOB = "74 1F B9 ?? ?? ?? ?? 41 FF D6 4C 8D 45 D0 B9 ?? ?? ?? ?? 48 89 F2 FF D7 48 8B 4D D0 FF D0 41 FF D7";
        private string glideAOB = "F3 44 0F 11 43 14 F3 0F";
        private string wallhackAOB = "74 0D 83 4B 68 01";
        private string infReachAOB = "56 FD FF 8B 06 89 07 41 80 0F 0C";
        private bool infReachEnabled = false;
        private bool infReachPatched = false;
        private string infReachAddressStr;
        private UIntPtr infReachAddress;
        private byte[] infReachPatchedBytes = { 0x83, 0xBC, 0x24, 0xA8, 0x00, 0x00, 0x00, 0x29, 0x0F, 0x85, 0x05, 0x00, 0x00, 0x00, 0xB8, 0x00, 0x00, 0x00, 0x00, 0x89, 0x07, 0x41, 0x80, 0x0F, 0x0C };
        private string wallhackAddress;
        private bool wallhackPatched;
        private bool glideEnabled = false;
        private VirtualKeyCode TPUpKey;
        private VirtualKeyCode TPDownKey;
        private VirtualKeyCode TPLeftKey;
        private VirtualKeyCode TPRightKey;
        private VirtualKeyCode TPForwardKey;
        private VirtualKeyCode TPBackwardKey;
        private VirtualKeyCode FreecamKey;
        private VirtualKeyCode TPToCamKey;
        private VirtualKeyCode NofallKey;
        private VirtualKeyCode GlideKey;
        private VirtualKeyCode SpeedKey;
        public string PlayerBaseAddress = "";
        public string CamBaseAddress = "";
        public UIntPtr playerBaseUInt;
        public UIntPtr camBaseUInt;
        public UIntPtr EspUint;
        public int baseAddr = 0;
        public UIntPtr noclipAddress;
        public string noclipAddressStr = "";
        public string glideAddrString;
        public string cameraAddress = "";
        public string cameraYAddress = "";
        public string cameraZAddress = "";
        public float xCoord = 0;
        public float yCoord = 0;
        public float zCoord = 0;
        public float camSpeed = 0.1f;
        public float speedBoostMultiplier = 2f;
        public bool isSpeedBoostActive = false;
        public string xAddrString = "";
        public string yAddrString = "";
        public string zAddrString = "";
        public string devESPAddrString = "";
        public string velocityIndAddrStr = "";
        public string xCamAddrString = "";
        public string yCamAddrString = "";
        public string zCamAddrString = "";
        public string nofallAddrString = "";
        public string speedValueUIntString;
        public string speedHackAddrString;
        public string yawAddrString;
        public string pitchAddrString;
        public float savedX = 0;
        public float savedY = 0;
        public float savedZ = 0;
        public UIntPtr xAddr;
        public UIntPtr yAddr;
        public UIntPtr zAddr;
        public UIntPtr xCamAddr;
        public UIntPtr yCamAddr;
        public UIntPtr zCamAddr;
        public UIntPtr nofallAddr;
        public UIntPtr pitchAddr;
        public UIntPtr yawAddr;
        public UIntPtr cameraYUInt;
        public UIntPtr cameraZUInt;
        public UIntPtr yVelocityAddr;
        public UIntPtr heightAddr;
        public UIntPtr movementModeAddr;
        public string movementModeAddrStr;
        public float playerYVelocity;
        public string heightAddrString;
        public string yVelocityAddrString;
        public bool tpflag = false;
        public bool saveflag = false;
        public bool speedHackCave;
        public float playerHeight;
        private string userName = Environment.UserName;
        private UIntPtr speedValueUInt;
        private byte[] speedPatchedBytes;
        private bool speedPatched;
        private UIntPtr pbasecaveAddr;
        private bool isPVPEnabled = false;
        private string PVPAOB = "50 00 56 00 45 00 00 00 ?? ?? ?? ?? ?? 7D 00 00 ?? ?? ?? ?? ??";
        private bool isSpeedhackEnabled = false;
        public byte[] noclipPatchedBytes = { };
        public byte[] cameraPatchedBytes = { };
        public byte[] cameraYPatchedBytes = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
        public byte[] cameraZPatchedBytes = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
        public byte[] noclipBytes = { 0x48, 0x8B, 0x01, 0x48, 0x8B, 0x40, 0x58 };
        public byte[] cameraBytes = { 0x48, 0x8B, 0x01, 0x48, 0x8B, 0x80, 0xF0, 0x01, 0x00, 0x00 };
        public byte[] speedBytes = { 0xF3, 0x0F, 0x10, 0xBE, 0xF4, 0x00, 0x00, 0x00, 0x0F, 0x28, 0xF7 };
        public byte[] cameraYBytes = { 0xF2, 0x0F, 0x11, 0x87, 0x28, 0x02, 0x00, 0x00 };
        public byte[] cameraZBytes = { 0x89, 0x87, 0x30, 0x02, 0x00, 0x00, 0xF3 };
        public byte[] patchedBytes = { 0xC7, 0x47, 0x10, 0x33, 0x33, 0x33, 0xBF, 0xF3, 0x44, 0x0F, 0x10, 0x4F, 0x10 };
        public byte[] originalBytes = { 0xF3, 0x44, 0x0F, 0x10, 0x4F, 0x10 };
        public byte[] gotoCaveBytes = { };
        public byte[] infReachAlreadyPatchedBytes = { };
        public byte[] infReachOriginalBytes = { 0x89, 0x07, 0x41, 0x80, 0x0F, 0x0C };
        string allVars = @"
string PlayerBaseAddress 
string CamBaseAddress 
UIntPtr playerBaseUInt
UIntPtr camBaseUInt
UIntPtr EspUint
int baseAddr 
string noclipAddress 
string glideAddrString
string cameraAddress 
string cameraYAddress 
string cameraZAddress 
float xCoord 
float yCoord 
float zCoord 
float camSpeed 
float speedBoostMultiplier 
bool isSpeedBoostActive 
string xAddrString 
string yAddrString 
string zAddrString 
string devESPAddrString 
string velocityIndAddrStr 
string xCamAddrString 
string yCamAddrString 
string zCamAddrString 
string nofallAddrString 
string speedValueUIntString
string speedHackAddrString
string yawAddrString
string pitchAddrString
float savedX 
float savedY 
float savedZ 
UIntPtr xAddr
UIntPtr yAddr
UIntPtr zAddr
UIntPtr xCamAddr
UIntPtr yCamAddr
UIntPtr zCamAddr
UIntPtr nofallAddr
UIntPtr pitchAddr
UIntPtr yawAddr
UIntPtr cameraYUInt
UIntPtr cameraZUInt
UIntPtr yVelocityAddr
UIntPtr heightAddr
string heightAddrString
string yVelocityAddrString
bool tpflag 
bool saveflag 
bool speedHackCave
float playerHeight
"; //fürs scripting
        #endregion

        //Form Init
        public Form1()
        {
            InitializeComponent();

            Thread aobThread = new Thread(scanAOB) { IsBackground = true};
            Thread NumpadTeleportThread = new Thread(teleportNumpad) { IsBackground = true };
            Thread HotkeyThread = new Thread(hotkeysFunction) { IsBackground = true };
            //Thread pvpThread = new Thread(checkForPvP) { IsBackground = true , Priority = ThreadPriority.Lowest};

            //Design stuff 
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green900, Accent.Green700, TextShade.WHITE);
            //Design stuff 

            onlineCheck(urlRunning);

            updateCheck(urlUpdate);

            log_console.Text = log_console.Text + $"Welcome {userName}!\r\n"; ;

            startMainTimer();
            startgetBaseTimer();

            int title = rnd.Next(999999, 9999999);
            //this.Text = title.ToString("X2");

            int PID = m.GetProcIdFromName("swtor");

            //Connect To Process
            if(PID != 0)
            {
                m.OpenProcess(PID);
                log_console.Text = log_console.Text + "\r\nConnected to PID: " + PID + "\r\n";
            }
            else
            {
                MessageBox.Show("Process not found...");
                Environment.Exit(0);
            }

            lbl_version.Text = currentVersion;

            aobThread.Start();
            NumpadTeleportThread.Start();
            HotkeyThread.Start();

            this.Text = materialTabControl1.SelectedTab.Text;
            box_darkmode.Checked = true;

            //log_console.Text = log_console.Text + "\r\nPBase MemLoc: " + noclipAddress + "\r\n\r\n" + "Camera MemLoc: " + cameraAddress + "\r\n\r\n" + "CameraY MemLoc: " + cameraYAddress + "\r\n\r\n" + "Camera ZMemLoc: " + cameraZAddress;
        }
        //ICard for scripting
        public interface ICard
        {
            string GetCardInfo();
        }

        #region Timer
        private void mainTimer_Tick_1(object sender, EventArgs e)
        {
            //AntiDebug
            //PreventProgramFromBeingDebuged();

            xAddr = playerBaseUInt + 0x68;
            xAddrString = convertUintToHexString(xAddr);
            
            movementModeAddr = playerBaseUInt + 0x3d0;
            movementModeAddrStr = convertUintToHexString(movementModeAddr);

            yAddr = playerBaseUInt + 0x6C;
            yAddrString = convertUintToHexString(yAddr);

            zAddr = playerBaseUInt + 0x70;
            zAddrString = convertUintToHexString(zAddr);

            yVelocityAddr = playerBaseUInt + 0x668;
            yVelocityAddrString = convertUintToHexString(yVelocityAddr);

            zCamAddr = camBaseUInt + 0x230;
            zCamAddrString = convertUintToHexString(zCamAddr);

            yCamAddr = camBaseUInt + 0x22C;
            yCamAddrString = convertUintToHexString(yCamAddr);

            xCamAddr = camBaseUInt + 0x228;
            xCamAddrString = convertUintToHexString(xCamAddr);

            pitchAddr = camBaseUInt + 0x234;
            pitchAddrString = convertUintToHexString(pitchAddr);

            yawAddr = camBaseUInt + 0x238;
            yawAddrString = convertUintToHexString(yawAddr);

            heightAddr = playerBaseUInt + 0x84;
            heightAddrString = convertUintToHexString(heightAddr);

            xCoord = m.ReadFloat(xAddrString);
            yCoord = m.ReadFloat(yAddrString);
            zCoord = m.ReadFloat(zAddrString);

            playerHeight = m.ReadFloat(heightAddrString);

            lbl_coords.Text = $"X: {xCoord}\nY: {yCoord}\nZ: {zCoord}";

            if(tpflag == true)
            {
                teleport();
            }

            if(freeCamEnabled)
            {
                Freecam();
            }
        }
        private void timer_getBase_Tick(object sender, EventArgs e)
        {
            try
            {
                //SpeedhackManagement
                if (isSpeedhackEnabled)
                {
                    m.WriteMemory(speedValueUIntString, "float", trckbr_speed.Value.ToString(CultureInfo.InvariantCulture));
                }
                //check if speedhack is disabled
                if (!isSpeedhackEnabled)
                {
                    m.WriteMemory(speedValueUIntString, "float", "0");
                }

                ////PBASE
                string caveAddrString = convertUintToHexString(pbasecaveAddr);
                //log_console.Text = log_console.Text + "\r\n\r\nCaveAddr = " + caveAddrString;

                //Add offset 0x12 to the cwave addr (that's where the ptr for pbase is stored)
                playerBaseUInt = (UIntPtr)UIntPtr.Add(pbasecaveAddr, 0x20); //caveAddr == UIntPtr

                //log caveAddr + offset
                string PbaseUintString = convertUintToHexString(playerBaseUInt);
                //log_console.Text = log_console.Text + "\r\n\r\nAddress of the PTR = " + PbaseUintString;

                //readValue & convert to hex string
                long playerBaselong = m.ReadLong(PbaseUintString);
                PlayerBaseAddress = playerBaselong.ToString("X2");
                playerBaseUInt = ParseHexToUIntPtr(PlayerBaseAddress);

                //constWriteMovementMode

            }
            catch{}
        }
        #endregion

        #region Checkboxes
        private void box_infReach_CheckedChanged(object sender, EventArgs e)
        {
            infReachFunction();
        }
        private void box_noCollision_CheckedChanged(object sender, EventArgs e)
        {
            if (!noCollisionEnabled)
            {
                m.WriteMemory($"{movementModeAddrStr}", "int", "6");
                noCollisionEnabled = true;
            }
            else
            {
                m.WriteMemory($"{movementModeAddrStr}", "int", "1");
                noCollisionEnabled = false;
            }
        }
        private void box_darkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (!darkmodeEnabled)
            {
                Color fColor = Color.FromArgb(220, 220, 220);
                Color bColor = Color.FromArgb(50, 50, 50);
                MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green900, Accent.Green700, TextShade.BLACK);
                MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.DARK;
                this.BackColor = bColor;
                this.ForeColor = fColor;
                tabPage1.BackColor = bColor;
                tabPage1.ForeColor = fColor;
                tabPage2.BackColor = bColor;
                tabPage2.ForeColor = fColor;
                tabPage3.BackColor = bColor;
                tabPage3.ForeColor = fColor;
                trckbr_speed.BackColor = bColor;

                SetControlColors(this.Controls, bColor, fColor);

                darkmodeEnabled = true;
            }
            else
            {
                MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green900, Accent.Green700, TextShade.WHITE);
                MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
                this.BackColor = Color.FromArgb(240, 240, 250);
                this.ForeColor = Color.FromArgb(0, 0, 0);
                tabPage1.BackColor = Color.FromArgb(250, 250, 250);
                tabPage1.ForeColor = Color.FromArgb(0, 0, 0);
                tabPage2.BackColor = Color.FromArgb(250, 250, 250);
                tabPage2.ForeColor = Color.FromArgb(0, 0, 0);
                tabPage3.BackColor = Color.FromArgb(250, 250, 250);
                tabPage3.ForeColor = Color.FromArgb(0, 0, 0);
                trckbr_speed.BackColor = Color.FromArgb(250, 250, 250);
                trckbr_speed.BackColor = Color.FromArgb(0, 0, 0);

                SetControlColors(this.Controls, Color.FromArgb(250, 250, 250), Color.FromArgb(0, 0, 0));

                darkmodeEnabled = false;
            }
        }
        private void cbox_noclip_CheckedChanged_1(object sender, EventArgs e)
        {
            Thread codeCaveThread = new Thread(createCodeCave);

            if (cbox_noclip.ForeColor != Color.Green)
            {
                Cursor.Current = Cursors.WaitCursor;
                cbox_noclip.ForeColor = Color.Green;
            }
            else
            {
                cbox_noclip.ForeColor = Color.Red;
            }
            //MessageBox.Show("Try to not disable this function or it may cause errors");
            
            codeCaveThread.Start();
        }
        private void box_Freecam_CheckedChanged(object sender, EventArgs e)
        {
            toggle_freecam();
        }
        private void box_nofall_CheckedChanged(object sender, EventArgs e)
        {
            nofallFunction();
        }
        private void box_camAttach_CheckedChanged(object sender, EventArgs e)
        {
            if(!attachToCamEnabled)
            {
                attachToCamEnabled = true;
            }
            else
            {
                attachToCamEnabled = false;
            }
        }
        private void box_alwaysInFront_CheckedChanged(object sender, EventArgs e)
        {
            if(!alwaysOnTop)
            {
                this.TopMost = true;
                alwaysOnTop = true;
            }
            else
            {
                this.TopMost = false;
                alwaysOnTop = false;
            }
        }
        private void box_esp_CheckedChanged(object sender, EventArgs e)
        {
            if (!devEspEnabled)
            {
                m.WriteMemory($"{devESPAddrString}", "bytes", "0F 85");
                devEspEnabled = true;
            }
            else
            {
                m.WriteMemory($"{devESPAddrString}", "bytes", "0F 84");
                devEspEnabled = false;
            }
        }
        private void box_dotEsp_CheckedChanged(object sender, EventArgs e)
        {
            if (!devVelEnabled)
            {
                m.WriteMemory($"{velocityIndAddrStr}", "bytes", "75 1F B9");
                devVelEnabled = true;
            }
            else
            {
                string espAddr = convertUintToHexString(EspUint);
                m.WriteMemory($"{velocityIndAddrStr}", "bytes", "74 1F B9");
                devVelEnabled = false;
            }
        }
        private void box_wallhack_CheckedChanged(object sender, EventArgs e)
        {
            if (!wallhackPatched)
            {
                m.WriteMemory($"{wallhackAddress}", "bytes", "90 90");
                wallhackPatched = true;
            }
            else
            {
                m.WriteMemory($"{wallhackAddress}", "bytes", "74 0D");
                wallhackPatched = false;
            }
        }
        private void box_glide_CheckedChanged(object sender, EventArgs e)
        {
            doglide();
        }
        private void box_speedhack_CheckedChanged(object sender, EventArgs e)
        {
            speedhackFunction();
        }
        #endregion

        #region Functions
        private void SetControlColors(Control.ControlCollection controls, Color backColor, Color foreColor)
        {
            foreach (Control control in controls)
            {
                if (control is Button || control is TextBox || control is TrackBar)
                {
                    control.BackColor = backColor;
                    control.ForeColor = foreColor;
                }
                else if (control.HasChildren)
                {
                    SetControlColors(control.Controls, backColor, foreColor);
                }
            }
        }
        private void toggle_freecam()
        {
            if (!cameraYPatched)
            {
                m.WriteBytes(cameraYUInt, cameraYPatchedBytes);
                //log_console.Text = log_console.Text + "\r\n\r\nCamYBytes Restored";
                cameraYPatched = true;
            }
            else
            {
                m.WriteBytes(cameraYUInt, cameraYBytes);
                //log_console.Text = log_console.Text + "\r\n\r\nCamYBytes Patched";
                cameraYPatched = false;
            }

            if (!cameraZPatched)
            {
                m.WriteBytes(cameraZUInt, cameraZPatchedBytes);
                //log_console.Text = log_console.Text + "\r\n\r\nCamXBytes Restored";
                cameraZPatched = true;
            }
            else
            {
                m.WriteBytes(cameraZUInt, cameraZBytes);
                //log_console.Text = log_console.Text + "\r\n\r\nCamXBytes Patched";
                cameraZPatched = false;
            }
            //Dont touch code above, important for freecam

            if (!freeCamEnabled)
            {
                freeCamEnabled = true;
            }
            else
            {
                freeCamEnabled = false;
            }
        }
        private void scanAOB()
        {
            try
            {
                //AOB Scans
                noclipAddressStr = m.AoBScan(noclipAOB).Result.Sum().ToString("X2");
                cameraAddress = m.AoBScan(cameraAOB).Result.Sum().ToString("X2");
                cameraZAddress = m.AoBScan(cameraZAOB).Result.Sum().ToString("X2");
                cameraYAddress = m.AoBScan(cameraYAOB).Result.Sum().ToString("X2");
                nofallAddrString = m.AoBScan(nofallAOB).Result.Sum().ToString("X2");
                speedHackAddrString = m.AoBScan(speedHackAOB).Result.Sum().ToString("X2");
                devESPAddrString = m.AoBScan(devESPAob).Result.Sum().ToString("X2");
                velocityIndAddrStr = m.AoBScan(velocityIndicatorAOB).Result.Sum().ToString("X2");
                glideAddrString = m.AoBScan(glideAOB).Result.Sum().ToString("X2");
                wallhackAddress = m.AoBScan(wallhackAOB).Result.Sum().ToString("X2");
                infReachAddressStr = m.AoBScan(infReachAOB).Result.Sum().ToString("X2");

                cameraYUInt = m.Get64BitCode(cameraYAddress);
                cameraZUInt = m.Get64BitCode(cameraZAddress);

                //fixInfReachAddr to +5 bytes
                infReachAddress = m.Get64BitCode(infReachAddressStr);
                infReachAddress = (infReachAddress + 0x5);
                infReachAddressStr = convertUintToHexString(infReachAddress);

                //fixPbaseAddr to +4 bytes
                noclipAddress = m.Get64BitCode(noclipAddressStr);
                noclipAddress = (noclipAddress + 0x4);
                noclipAddressStr = convertUintToHexString(noclipAddress);

                log_console.Invoke((MethodInvoker)delegate
                {
                    log_console.Text = log_console.Text + $"\r\n\r\nEvery AOB was found";
                });

                //MessageBox.Show("AOB scan success");
            }
            catch(Exception ex)
            {
                //log_console.Text = log_console.Text + $"\r\n\r\nAOB's not found. Please restart the game";
                MessageBox.Show($"AOB's not found. Please restart the game.\nError: {ex.Message}");
            }
        }
        private void Freecam()
        {
            float pitch = m.ReadFloat(pitchAddrString);
            float yaw = m.ReadFloat(yawAddrString);

            float siny = (float)Math.Sin(yaw);
            float cosy = (float)Math.Cos(yaw);
            float sinp = (float)Math.Sin(pitch);
            float cosp = (float)Math.Cos(pitch);

            float camx = m.ReadFloat(xCamAddrString);
            float camy = m.ReadFloat(yCamAddrString);
            float camz = m.ReadFloat(zCamAddrString);

            float speedX = 0;
            float speedY = 0;
            float speedZ = 0;

            float speed = camSpeed;
            if (isSpeedBoostActive)
            {
                speed *= speedBoostMultiplier;
            }

            bool isArrowUpPressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.UP);
            bool isArrowDownPressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.DOWN);

            if (isArrowUpPressed)
            {
                speedX = -speed * cosp * siny;
                speedZ = -speed * cosp * cosy;
                speedY = speed * sinp;
            }
            else if (isArrowDownPressed)
            {
                speedX = speed * cosp * siny;
                speedZ = speed * cosp * cosy;
                speedY = -speed * sinp;
            }

            if (sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.RIGHT))
            {
                isSpeedBoostActive = true;
            }
            else
            {
                isSpeedBoostActive = false;
            }

            if (sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT))
            {
                speedY += speed * 0.2f;
            }
            else if (sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.CONTROL))
            {
                speedY -= speed * 0.2f;
            }

            camx += speedX;
            camy += speedY;
            camz += speedZ;

            // Ensure the float values are converted to strings using the invariant culture
            string camxString = camx.ToString(CultureInfo.InvariantCulture);
            string camyString = camy.ToString(CultureInfo.InvariantCulture);
            string camzString = camz.ToString(CultureInfo.InvariantCulture);

            // Write the memory
            m.WriteMemory(xCamAddrString, "float", camxString);
            m.WriteMemory(yCamAddrString, "float", camyString);
            m.WriteMemory(zCamAddrString, "float", camzString);

            if (attachToCamEnabled)
            {
                savedX = camx;
                savedY = camy;
                savedZ = camz;
                tpflag = true;
            }
        }
        private void teleport()
        {
            //enable

            bool isArrived = false;
            float xAddrF = m.ReadFloat(xAddrString);
            float yAddrF = m.ReadFloat(yAddrString);
            float zAddrF = m.ReadFloat(zAddrString);

            if (!glideEnabled)
            {
                doglide();
                m.WriteMemory(movementModeAddrStr, "int", "6");
            }

            if (savedX == 0 || savedY == 0 || savedZ == 0)
            {
                log_console.Text = log_console.Text + "\n\r\n\rInvalid Value!";
                return;
            }

            float distance = (float)Math.Sqrt(Math.Pow(xCoord - savedX, 2) + Math.Pow(yCoord - savedY, 2) + Math.Pow(zCoord - savedZ, 2));

            if (distance <= 1.0f && distance > 0)
            {
                //if player is already close to the destination tp directly
                m.WriteMemory(xAddrString, "float", (savedX).ToString(CultureInfo.InvariantCulture));
                m.WriteMemory(yAddrString, "float", (savedY).ToString(CultureInfo.InvariantCulture));
                m.WriteMemory(zAddrString, "float", (savedZ).ToString(CultureInfo.InvariantCulture));
                m.WriteMemory(movementModeAddrStr, "int", "1");
                isArrived = true;
                doglide();
            }
            else if (distance > 1.0f)
            {
                //calculate the normalized movement increments
                float moveX = (savedX - xCoord) / distance;
                float moveY = (savedY - yCoord) / distance;
                float moveZ = (savedZ - zCoord) / distance;

                //move towards the saved coordinates using normalized values
                m.WriteMemory(xAddrString, "float", (xCoord + moveX).ToString());
                m.WriteMemory(yAddrString, "float", (yCoord + moveY).ToString());
                m.WriteMemory(zAddrString, "float", (zCoord + moveZ).ToString());

                Thread.Sleep(100);

                //check if the player has arrived
                isArrived = (distance <= 1.0f);
            }

            if (isArrived)
            {
                isArrived = false;
                tpflag = false;
            }
        }
        private void teleportNumpad()
        {
            while (true)
            {
                float playerXCoord = m.ReadFloat(xAddrString);
                float playerYCoord = m.ReadFloat(yAddrString);
                float playerZCoord = m.ReadFloat(zAddrString);

                bool isTPUpPressed = sim.InputDeviceState.IsHardwareKeyDown(TPUpKey);
                bool isTPDownPressed = sim.InputDeviceState.IsHardwareKeyDown(TPDownKey);
                bool isTPXUpPressed = sim.InputDeviceState.IsHardwareKeyDown(TPLeftKey);
                bool isTPXDownPressed = sim.InputDeviceState.IsHardwareKeyDown(TPRightKey);
                bool isTPZUpPressed = sim.InputDeviceState.IsHardwareKeyDown(TPForwardKey);
                bool isTPZDownPressed = sim.InputDeviceState.IsHardwareKeyDown(TPBackwardKey);

                if (isTPUpPressed)
                {
                    m.WriteMemory(yAddrString, "float", (playerYCoord + 0.5f).ToString(CultureInfo.InvariantCulture));
                }
                if (isTPDownPressed)
                {
                    m.WriteMemory(yAddrString, "float", (playerYCoord - 0.25f).ToString());
                }
                if (isTPXUpPressed)
                {
                    m.WriteMemory(xAddrString, "float", (playerXCoord + 0.25f).ToString(CultureInfo.InvariantCulture));
                }
                if (isTPXDownPressed)
                {
                    m.WriteMemory(xAddrString, "float", (playerXCoord - 0.25f).ToString(CultureInfo.InvariantCulture));
                }
                if (isTPZUpPressed)
                {
                    m.WriteMemory(zAddrString, "float", (playerZCoord + 0.25f).ToString(CultureInfo.InvariantCulture));
                }
                if (isTPZDownPressed)
                {
                    m.WriteMemory(zAddrString, "float", (playerZCoord - 0.25f).ToString(CultureInfo.InvariantCulture));
                }
                Thread.Sleep(200);
            }
        }
        private string convertUintToHexString(UIntPtr uintToConvert)
        {
            string placeholder1 = uintToConvert.ToString();
            long placeholder2 = long.Parse(placeholder1);
            string hexstring = placeholder2.ToString("X2");
            return hexstring;
        }
        private static UIntPtr ParseHexToUIntPtr(string hexValue)
        {
            // Parse the hexadecimal string into a UIntPtr
            ulong numericValue = ulong.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);

            return new UIntPtr(numericValue);
        }
        private void nofallFunction()
        {
            if (!nofallEnabled)
            {
                if (!nofallPatched)
                {
                    m.CreateCodeCave(nofallAddrString, patchedBytes, 6, 300);

                    gotoCaveBytes = m.ReadBytes(nofallAddrString, 6);

                    nofallEnabled = true;
                    nofallPatched = true;
                }
                else
                {
                    m.WriteBytes(nofallAddr, gotoCaveBytes);
                    nofallEnabled = true;
                }
            }
            else
            {
                nofallAddr = ParseHexToUIntPtr(nofallAddrString);
                m.WriteBytes(nofallAddr, originalBytes);
                nofallEnabled = false;
            }
        }
        private void infReachFunction()
        {
            if(!infReachEnabled)
            {
                if (!infReachPatched)
                {
                    m.CreateCodeCave(infReachAddressStr, infReachPatchedBytes, 6, 300);

                    infReachAlreadyPatchedBytes = m.ReadBytes(infReachAddressStr, 6);

                    infReachEnabled = true;
                    infReachPatched = true;
                }
                else
                {
                    m.WriteBytes(infReachAddressStr, infReachAlreadyPatchedBytes);
                    infReachEnabled= true;
                }
            }
            else
            {
                m.WriteBytes(infReachAddressStr, infReachOriginalBytes);
                infReachEnabled = false;
            }
        }
        private async void onlineCheck(string url)
        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;


                if (!response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Tool is offline...");
                    Environment.Exit(1);
                }
                else
                {
                    log_console.Text = log_console.Text + "Tool is Online";
                }
            }
        }
        private async void updateCheck(string url)
        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;


                if (!response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Your tool is outdated. Please download a new version from the discord");
                    Environment.Exit(1);
                }
                else
                {
                    log_console.Text = log_console.Text + "\r\n\r\nYou are running the latest version\r\n\r\n";
                }

            }
        }
        //private void PreventProgramFromBeingDebuged()
        //{

        //    var a = DateTime.Now;
        //    Thread.Sleep(10);
        //    var b = DateTime.Now;

        //    // if difference in time is greater than 1 second it means the program has stopped executing

        //    if ((b - a).TotalSeconds > 2)
        //    {
        //        Application.ExitThread();
        //        Environment.Exit(0);
        //        this.Close();
        //    }
    
        //}
        private void startMainTimer()
        {
            try
            {
                mainTimer.Start();
            }
            catch (Exception ex)
            {
                log_console.Text = log_console.Text + ($"\r\nException in Main Thread: {ex.Message}");
            }
        }
        private void startgetBaseTimer()
        {
            try
            {
                timer_getBase.Start();
            }
            catch (Exception ex)
            {
                log_console.Text = log_console.Text + ($"\r\nException in getBase Thread: {ex.Message}");
            }
        }
        private void createCodeCave()
        {
            if (!noclipCave)
            {
                try
                {
                    byte[] patched_bytes = { 0x83, 0xB9, 0x24, 0x03, 0x00, 0x00, 0x02, 0x0F, 0x85, 0x07, 0x00, 0x00, 0x00, 0x48, 0x89, 0x0D, 0x0C, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x01, 0x48, 0x8B, 0x40, 0x58 };

                    //Create Codecave
                    pbasecaveAddr = m.CreateCodeCave(noclipAddressStr, patched_bytes, 7, 300);

                    log_console.Invoke((MethodInvoker)delegate
                    {
                        log_console.Text = log_console.Text + "\r\n\r\nHooked";
                    });

                    //rest of code
                    noclipPatchedBytes = m.ReadBytes(noclipAddressStr, 7);
                    noclipPatched = true;
                    noclipCave = true;
                    //log_console.Text = log_console.Text + "\r\n\r\nCave Created";;
                }
                catch(Exception ex)
                {
                    log_console.Invoke((MethodInvoker)delegate
                    {
                        log_console.Text = log_console.Text + $"\r\n\r\nHook failed\r\nError: {ex.Message}";
                    });
                    return;
                }

            }
            else
            {
                if (noclipPatched)
                {
                    m.WriteBytes(noclipAddressStr, noclipBytes);
                    log_console.Invoke((MethodInvoker)delegate
                    {
                        log_console.Text = log_console.Text + "\r\n\r\nUnhooked";
                    });
                    noclipPatched = false;
                }
                else
                {
                    m.WriteBytes(noclipAddressStr, noclipPatchedBytes);
                    log_console.Invoke((MethodInvoker)delegate
                    {
                        log_console.Text = log_console.Text + "\r\n\r\nRe-Hooked";
                    });
                    noclipPatched = true;
                }

            }

            //camera

            if (!camCave)
            {
                byte[] patched_bytes = { 0x48, 0x89, 0x0D, 0x0F, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x01, 0x48, 0x8B, 0x80, 0xF0, 0x01, 0x00, 0x00 }; // patched bytes from the asm above

                //Create Codecave
                UIntPtr caveAddr = m.CreateCodeCave(cameraAddress, patched_bytes, 10, 300);

                //logCaveAddr
                string caveAddrString = convertUintToHexString(caveAddr);
                //log_console.Text = log_console.Text + "\r\n\r\nCaveAddr = " + caveAddrString;

                //Add offset 0x12 to the cave addr (that's where the ptr for pbase is stored)
                camBaseUInt = (UIntPtr)UIntPtr.Add(caveAddr, 0x16); //caveAddr == UIntPtr
                //log caveAddr + offset
                string CambaseUIntString = convertUintToHexString(camBaseUInt);
                //log_console.Text = log_console.Text + "\r\n\r\nAddress of the Cam PTR = " + CambaseUIntString;

                Thread.Sleep(100);

                //readValue & convert to hex string
                long camBaselong = m.ReadLong(CambaseUIntString);
                CamBaseAddress = camBaselong.ToString("X2");
                camBaseUInt = ParseHexToUIntPtr(CamBaseAddress);

                //log to console
                //log_console.Text = log_console.Text + "\r\n\r\nCamBaseAddress = " + CamBaseAddress;


                //rest of code
                cameraPatchedBytes = m.ReadBytes(cameraAddress, 10);
                cameraPatched = true;
                camCave = true;
                //log_console.Text = log_console.Text + "\r\n\r\nCave Created";
            }
            else
            {
                if (cameraPatched)
                {
                    m.WriteBytes(cameraAddress, cameraBytes);
                    //log_console.Text = log_console.Text + "\r\n\r\nBytes Restored";
                    cameraPatched = false;
                }
                else
                {
                    m.WriteBytes(cameraAddress, cameraPatchedBytes);
                    //log_console.Text = log_console.Text + "\r\n\r\nBytes Patched";
                    cameraPatched = true;
                }
            }

            if (!speedHackCave)
            {
                byte[] patched_bytes = { 0x83, 0x3D, 0x23, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x84, 0x10, 0x00, 0x00, 0x00, 0x53, 0x48, 0x8B, 0x1D, 0x15, 0x00, 0x00, 0x00, 0x48, 0x89, 0x9E, 0xF4, 0x00, 0x00, 0x00, 0x5B, 0xF3, 0x0F, 0x10, 0xBE, 0xF4, 0x00, 0x00, 0x00 }; // patched bytes from the asm above

                //Create Codecave
                UIntPtr caveAddr = m.CreateCodeCave(speedHackAddrString, patched_bytes, 8, 300);

                //logCaveAddr
                string caveAddrString = convertUintToHexString(caveAddr);
                //log_console.Text = log_console.Text + "\r\n\r\nCaveAddr = " + caveAddrString;

                //Add offset 0x12 to the cave addr (that's where the ptr for pbase is stored)
                speedValueUInt = (UIntPtr)UIntPtr.Add(caveAddr, 0x2A); //caveAddr == UIntPtr
                //log caveAddr + offset
                speedValueUIntString = convertUintToHexString(speedValueUInt);
                //log_console.Text = log_console.Text + "\r\n\r\nAddress of the Speed PTR = " + speedValueUIntString;

                Thread.Sleep(100);


                //rest of code
                speedPatchedBytes = m.ReadBytes(speedHackAddrString, 8);
                speedPatched = true;
                speedHackCave = true;
                //log_console.Text = log_console.Text + "\r\n\r\nCave Created";
            }
            else
            {
                if (speedPatched)
                {
                    m.WriteBytes(speedHackAddrString, speedBytes);
                    //log_console.Text = log_console.Text + "\r\n\r\nBytes Restored";
                    speedPatched = false;
                }
                else
                {
                    m.WriteBytes(speedHackAddrString, speedPatchedBytes);
                    //log_console.Text = log_console.Text + "\r\n\r\nBytes Patched";
                    speedPatched = true;
                }
            }

            Cursor.Current = Cursors.Default;

        }
        private void logToConsole(string textToLog)
        {
            log_console.Text = log_console.Text + $"\r\n{textToLog}";
        }
        /*
        private void checkForPvP()
        {
            ////Takes up to much performance
            
            //while (!isPVPEnabled)
            //{
            //    Thread.Sleep(10000);

            //    string aobScanResult = m.AoBScan(PVPAOB, true, false).Result.Sum().ToString("X2");

            //    if (aobScanResult == "00")
            //    {
            //        isPVPEnabled = true;
            //        MessageBox.Show("No PvP allowed ;)");
            //        Environment.Exit(0);
            //    }
            //}
        }
        */
        private void doglide()
        {
            if (!glideEnabled)
            {
                glideEnabled = true;

                m.WriteMemory(glideAddrString, "bytes", "90 90 90 90 90 90");
                m.WriteMemory(movementModeAddrStr, "int", "6");
            }
            else
            {
                glideEnabled = false;

                m.WriteMemory(glideAddrString, "bytes", glideAOB);
                m.WriteMemory(movementModeAddrStr, "int", "1");
            }
        }
        private void speedhackFunction()
        {
            if (!isSpeedhackEnabled)
            {
                box_speedhack.Invoke((MethodInvoker)delegate
                {
                    box_speedhack.Text = "On";
                    box_speedhack.Checked = true;
                });
                isSpeedhackEnabled = true;
            }
            else
            {
                box_speedhack.Invoke((MethodInvoker)delegate
                {
                    box_speedhack.Text = "Off";
                    box_speedhack.Checked = false;
                });
                isSpeedhackEnabled = false;
            }
        }
        private void tpToCam()
        {
            savedX = m.ReadFloat(xCamAddrString);
            savedY = m.ReadFloat(yCamAddrString);
            savedZ = m.ReadFloat(zCamAddrString);


            log_console.Text = log_console.Text + $"\r\n\r\nTeleported to camera";
            //BottomScroll
            log_console.Focus();
            log_console.ScrollToCaret();
            log_console.SelectionLength = 0;
            //BottomScroll

            saveflag = true;

            tpflag = true;
            box_nofall.Checked = true;
        }
        private void hotkeysFunction()
        {
            while (true)
            {
                bool isFreecamKeyPressed = sim.InputDeviceState.IsHardwareKeyDown(FreecamKey);
                bool isTPToCamKeyPressed = sim.InputDeviceState.IsHardwareKeyDown(TPToCamKey);
                bool isNofallKeyPressed = sim.InputDeviceState.IsHardwareKeyDown(NofallKey);
                bool isGlideKeyPressed = sim.InputDeviceState.IsHardwareKeyDown(GlideKey);
                bool isSpeedKeyPressed = sim.InputDeviceState.IsHardwareKeyDown(SpeedKey);

                try
                {
                    if (isFreecamKeyPressed)
                    {
                        ///////////FreecamCompabilityFix
                        if (!cameraYPatched)
                        {
                            m.WriteBytes(cameraYUInt, cameraYPatchedBytes);
                            //log_console.Text = log_console.Text + "\r\n\r\nCamYBytes Restored";
                            cameraYPatched = true;
                        }
                        else
                        {
                            m.WriteBytes(cameraYUInt, cameraYBytes);
                            //log_console.Text = log_console.Text + "\r\n\r\nCamYBytes Patched";
                            cameraYPatched = false;
                        }

                        if (!cameraZPatched)
                        {
                            m.WriteBytes(cameraZUInt, cameraZPatchedBytes);
                            //log_console.Text = log_console.Text + "\r\n\r\nCamXBytes Restored";
                            cameraZPatched = true;
                        }
                        else
                        {
                            m.WriteBytes(cameraZUInt, cameraZBytes);
                            //log_console.Text = log_console.Text + "\r\n\r\nCamXBytes Patched";
                            cameraZPatched = false;
                        }
                        //Dont touch code above, important for freecam

                        if (!freeCamEnabled)
                        {
                            freeCamEnabled = true;
                        }
                        else
                        {
                            freeCamEnabled = false;
                        }
                        ///////////FreecamCompabilityFix
                        if (box_Freecam.CheckState == CheckState.Unchecked)
                        {
                            box_Freecam.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            box_Freecam.CheckState = CheckState.Unchecked;
                        }
                        Thread.Sleep(200);
                    }
                    if (isTPToCamKeyPressed)
                    {
                        btn_tpToCam.PerformClick();
                        Thread.Sleep(200);
                    }
                    if (isNofallKeyPressed)
                    {
                        nofallFunction();
                        if (box_nofall.CheckState == CheckState.Unchecked)
                        {
                            box_nofall.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            box_nofall.CheckState = CheckState.Unchecked;
                        }
                        Thread.Sleep(200);
                    }
                    if (isGlideKeyPressed)
                    {
                        doglide();
                        if (box_glide.CheckState == CheckState.Unchecked)
                        {
                            box_glide.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            box_glide.CheckState = CheckState.Unchecked;
                        }
                        Thread.Sleep(200);
                    }
                    if (isSpeedKeyPressed)
                    {
                        speedhackFunction();
                        Thread.Sleep(200);
                    }
                }
                catch
                {

                }


            }
        }
        private void RunExampleScript()
        {
            string scriptCode = @"//Use the term [tool] to access the variables of the tool and use the term [mem] as a reference to the memory.dll component (https://github.com/erfg12/memory.dll/wiki/)

MessageBox.Show($""xCoord: {tool.xCoord}, yCoord: {tool.yCoord}, zCoord: {tool.zCoord}"");";

            txtbox_script.Text = scriptCode;
        }
        #endregion

        #region Trackbars
        private void trckbr_speed_Scroll(object sender, EventArgs e)
        {
            if(isSpeedhackEnabled)
            {
                m.WriteMemory(speedValueUIntString, "float", trckbr_speed.Value.ToString(CultureInfo.InvariantCulture));
                //BottomScroll
                log_console.Focus();
                log_console.ScrollToCaret();
                log_console.SelectionLength = 0;
                //BottomScroll
            }
        }
        private void trck_opcacity_Scroll(object sender, EventArgs e)
        {
            float newOpacity = (float)(trck_opcacity.Value) / 100;
            this.Opacity = newOpacity;
        }
        #endregion

        #region InputFields
        private void box_playerHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //human error prevention
                if (box_playerHeight.Text == "")
                    return;
                else if (box_playerHeight.Text.Contains(","))
                {
                    box_playerHeight.Text = box_playerHeight.Text.Replace(",", ".");
                }
                m.WriteMemory(heightAddrString, "float", $"{box_playerHeight.Text}");
            }
            catch
            {
                logToConsole("Invalid player height");
            }
        }
        #endregion

        #region Buttons
        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Nightfall\nDiscord: nightfallct\n\nAlso credits to Klerik for the noclip & research");
        }
        private void btn_clearConsole_Click(object sender, EventArgs e)
        {
            log_console.Text = "";
        }
        private void btn_saveLocation_Click(object sender, EventArgs e)
        {
            savedX = xCoord;
            savedY = yCoord;
            savedZ = zCoord;

            log_console.Text = log_console.Text + $"\r\n\r\nPosition saved at\r\nX: {savedX}\r\nY: {savedY}\r\nZ: {savedZ}\r\n";
            //BottomScroll
            log_console.Focus();
            log_console.ScrollToCaret();
            log_console.SelectionLength = 0;
            //BottomScroll

            saveflag = true;

        }
        private void btn_tpToCam_Click(object sender, EventArgs e)
        {
            tpToCam();
        }
        private void btn_teleport_Click(object sender, EventArgs e)
        {
            tpflag = true;
            box_nofall.Checked = true;
            //BottomScroll
            log_console.Focus();
            log_console.ScrollToCaret();
            log_console.SelectionLength = 0;
            //BottomScroll
        }
        private void btn_saveCustomCoords_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_XBox.Text.Contains(",") || txt_YBox.Text.Contains(",") || txt_ZBox.Text.Contains(","))
                {
                    txt_XBox.Text.Replace(",", ".");
                    txt_YBox.Text.Replace(",", ".");
                    txt_ZBox.Text.Replace(",", ".");
                }

                savedX = float.Parse(txt_XBox.Text);
                savedY = float.Parse(txt_YBox.Text);
                savedZ = float.Parse(txt_ZBox.Text);

                log_console.Text = log_console.Text + $"\r\n\r\nPosition saved at\r\nX: {savedX}\r\nY: {savedY}\r\nZ: {savedZ}\r\n";

            }
            catch
            {
                log_console.Text = log_console.Text + $"\r\n\r\nPosition failed saving!\r\nMaybe the wrong formatting? (123.34)";
            }
            //BottomScroll
            log_console.Focus();
            log_console.ScrollToCaret();
            log_console.SelectionLength = 0;
            //BottomScroll

        }
        private void btn_cancelTP_Click(object sender, EventArgs e)
        {
            tpflag = false;
            nofallFunction();
        }
        private void btn_example_Click(object sender, EventArgs e)
        {
            RunExampleScript();
        }
        private void btn_runScript_Click(object sender, EventArgs e)
        {
            string scriptCode = txtbox_script.Text;
            // Create a new thread and pass the method to execute
            Thread executeScriptThread = new Thread(() => ExecuteScript(scriptCode)) { IsBackground = true };
            executeScriptThread.Start(); // Start the thread
        }
        private void btn_showVars_Click(object sender, EventArgs e)
        {
            txtbox_script.Text = txtbox_script.Text + "\r\n" + allVars;
        }
        #endregion

        #region AssignedHotkeys
        private void txtbox_TpUpHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            //TPUpKey == VirtualKeyCode
            TPUpKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPUpKey.Text = TPUpKey.ToString();
        }
        private void txtbox_TPDowNkey_KeyDown(object sender, KeyEventArgs e)
        {
            TPDownKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPDowNkey.Text = TPDownKey.ToString();
        }
        private void txtbox_TPLeftKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPLeftKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPLeftKey.Text = TPLeftKey.ToString();
        }
        private void txtbox_TPRightKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPRightKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPRightKey.Text = TPRightKey.ToString();
        }
        private void txtbox_TPForwardKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPForwardKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPForwardKey.Text = TPForwardKey.ToString();
        }
        private void txtbox_TPBackwardKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPBackwardKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPBackwardKey.Text = TPBackwardKey.ToString();
        }
        private void txtbox_freecamKey_KeyDown(object sender, KeyEventArgs e)
        {
            FreecamKey = (VirtualKeyCode)e.KeyCode;
            txtbox_freecamKey.Text = FreecamKey.ToString();
        }
        private void txtbox_tpToCamKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPToCamKey = (VirtualKeyCode)e.KeyCode;
            txtbox_tpToCamKey.Text = TPToCamKey.ToString();
        }
        private void txtbox_nofallKey_KeyDown(object sender, KeyEventArgs e)
        {
            NofallKey = (VirtualKeyCode)e.KeyCode;
            txtbox_nofallKey.Text = NofallKey.ToString();
        }
        private void txtbox_glideKey_KeyDown(object sender, KeyEventArgs e)
        {
            GlideKey = (VirtualKeyCode)e.KeyCode;
            txtbox_glideKey.Text = GlideKey.ToString();
        }
        private void txtbox_speedKey_KeyDown(object sender, KeyEventArgs e)
        {
            SpeedKey = (VirtualKeyCode)e.KeyCode;
            txtbox_speedKey.Text = SpeedKey.ToString();
        }
        private void btn_clearHotkeys_Click(object sender, EventArgs e)
        {
            // Clear the text in each textbox
            txtbox_TPUpKey.Text = "";
            txtbox_TPDowNkey.Text = "";
            txtbox_TPLeftKey.Text = "";
            txtbox_TPRightKey.Text = "";
            txtbox_TPForwardKey.Text = "";
            txtbox_TPBackwardKey.Text = "";
            txtbox_freecamKey.Text = "";
            txtbox_tpToCamKey.Text = "";
            txtbox_nofallKey.Text = "";
            txtbox_glideKey.Text = "";
            txtbox_speedKey.Text = "";

            // Reset the associated hotkey variables to a default value
            TPUpKey = VirtualKeyCode.NONAME;
            TPDownKey = VirtualKeyCode.NONAME;
            TPLeftKey = VirtualKeyCode.NONAME;
            TPRightKey = VirtualKeyCode.NONAME;
            TPForwardKey = VirtualKeyCode.NONAME;
            TPBackwardKey = VirtualKeyCode.NONAME;
            FreecamKey = VirtualKeyCode.NONAME;
            TPToCamKey = VirtualKeyCode.NONAME;
            NofallKey = VirtualKeyCode.NONAME;
            GlideKey = VirtualKeyCode.NONAME;
            SpeedKey = VirtualKeyCode.NONAME;
        }
        #endregion

        #region Scripting
        private void ExecuteScript(string code)
        {
            var materialSkinAssemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MaterialSkin.dll"); // Load MaterialSkin.dll from local folder
            if (!File.Exists(materialSkinAssemblyPath))
            {
                MessageBox.Show("MaterialSkin assembly not found.");
                return;
            }

            var memoryAssemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "memory.dll"); // Load memory.dll from local folder
            if (!File.Exists(memoryAssemblyPath))
            {
                MessageBox.Show("Memory assembly not found.");
                return;
            }

            var scriptOptions = ScriptOptions.Default
                .AddReferences(typeof(Form1).Assembly.Location, materialSkinAssemblyPath, memoryAssemblyPath)
                .AddImports("System", "System.Windows.Forms", "MaterialSkin", "MaterialSkin.Controls");

            var globals = new ScriptGlobals
            {
                tool = this,
                mem = new Mem()
            //Hier könnten auch weitere Variablen eingefügt werden
            };

            try
            {
                var script = CSharpScript.Create(code, scriptOptions, typeof(ScriptGlobals));
                var scriptState = script.RunAsync(globals).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Script execution failed: {ex.Message}");
            }
        }
        public class ScriptGlobals
        {
            public Form1 tool { get; set; }
            public Mem mem { get; set; } //Initialize the 'm' object here
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = materialTabControl1.SelectedTab.Text;
        }

        private void lbl_Speed_Click(object sender, EventArgs e)
        {

        }

        private void txt_ZBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_YBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_XBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_TPUpKey_TextChanged(object sender, EventArgs e)
        {

        }









        #endregion

        /*
        Todo:
        Fly [Backspace highjump]
        MouseTP (only if stable)
         */
    }
}
