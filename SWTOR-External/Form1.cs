using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MaterialSkin;
using MaterialSkin.Controls;
using Memory;
using Microsoft.Win32;
using WindowsInput;

namespace SWTOR_External
{
    public partial class Form1 : MaterialForm
    {
        Random rnd = new Random();
        Mem m = new Mem();
        InputSimulator sim = new InputSimulator();

        private string urlRunning = "https://github.com/NightfallChease/s/blob/main/isRunning.sw";
        private string urlUpdate = "https://github.com/NightfallChease/s/blob/main/version5.sw";
        private string PlayerBaseAddress = "";
        private string CamBaseAddress = "";
        private UIntPtr playerBaseUInt;
        private UIntPtr camBaseUInt;
        private UIntPtr EspUint;
        private int baseAddr = 0;
        private bool noclipPatched = false;
        private bool cameraPatched = false;
        private bool cameraZPatched = false;
        private bool cameraYPatched = false;
        private bool noclipCave = false;
        private bool camCave = false;
        private bool freeCamEnabled = false;
        private bool attachToCamEnabled = false;
        private bool nofallEnabled = false;
        private bool nofallPatched = false;
        private bool alwaysOnTop = false;
        private bool devEspEnabled = false;
        private bool devVelEnabled = false;
        private string noclipAddress = "";
        private byte[] noclipPatchedBytes = { };
        private byte[] cameraPatchedBytes = { };
        private byte[] cameraYPatchedBytes = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
        private byte[] cameraZPatchedBytes = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
        private string noclipAOB = "F3 44 0F 10 43 6C F3";
        private byte[] noclipBytes = { 0xF3, 0x44, 0x0F, 0x10, 0x43, 0x6C, 0xF3 };
        private byte[] cameraBytes = { 0x48, 0x8B, 0x01, 0x48, 0x8B, 0x80, 0xF0, 0x01, 0x00, 0x00 };
        private byte[] speedBytes = { 0xF3, 0x0F, 0x10, 0xBE, 0xF4, 0x00, 0x00, 0x00, 0x0F, 0x28, 0xF7 };
        private byte[] cameraYBytes = { 0xF2, 0x0F, 0x11, 0x87, 0x28, 0x02, 0x00, 0x00 };
        private byte[] cameraZBytes = { 0x89, 0x87, 0x30, 0x02, 0x00, 0x00, 0xF3 };
        private byte[] patchedBytes = { 0xC7, 0x47, 0x10, 0x33, 0x33, 0x33, 0xBF, 0xF3, 0x44, 0x0F, 0x10, 0x4F, 0x10 };
        private byte[] originalBytes = { 0xF3, 0x44, 0x0F, 0x10, 0x4F, 0x10 };
        private byte[] gotoCaveBytes = { };
        private string cameraAOB = "48 8B 01 48 8B 80 F0 01 00 00 FF 15 ?? ?? ?? ?? EB 07 48 8D 05 ?? ?? ?? ?? 0F";
        private string cameraYAOB = "F2 0F 11 87 28 02 00 00";
        private string cameraZAOB = "89 87 30 02 00 00 F3";
        private string nofallAOB = "F3 44 0F 10 4F 10 44 0F 28 DF";
        private string speedHackAOB = "F3 0F 10 BE F4 00 00 00 0F 28 F7";
        private string cameraAddress = "";
        private string cameraYAddress = "";
        private string cameraZAddress = "";
        private float xCoord = 0;
        private float yCoord = 0;
        private float zCoord = 0;
        private float camSpeed = 0.1f;
        private float speedBoostMultiplier = 2f;
        private bool isSpeedBoostActive = false;
        private string xAddrString = "";
        private string yAddrString = "";
        private string zAddrString = "";
        private string xCamAddrString = "";
        private string yCamAddrString = "";
        private string zCamAddrString = "";
        private string nofallAddrString = "";
        private string speedValueUIntString;
        private string speedHackAddrString;
        private string yawAddrString;
        private string pitchAddrString;
        private float savedX = 0;
        private float savedY = 0;
        private float savedZ = 0;
        private UIntPtr xAddr;
        private UIntPtr yAddr;
        private UIntPtr zAddr;
        private UIntPtr xCamAddr;
        private UIntPtr yCamAddr;
        private UIntPtr zCamAddr;
        private UIntPtr nofallAddr;
        private UIntPtr pitchAddr;
        private UIntPtr yawAddr;
        private UIntPtr cameraYUInt;
        private UIntPtr cameraZUInt;
        private UIntPtr yVelocityAddr;
        private string yVelocityAddrString;
        private bool tpflag = false;
        private bool saveflag = false;
        private string userName = Environment.UserName;
        private bool speedHackCave;
        private UIntPtr speedValueUInt;
        private byte[] speedPatchedBytes;
        private bool speedPatched;
        private float yVelocity;
        private UIntPtr pbasecaveAddr;
        string mainModule = "";


        /*
        Todo:
        Glide / Nop Y
        Fly [Backspace highjump]
        SpeedTrackbar
        SpeedGlide
        MouseTP (only if stable)
         */

        //Form Init
        public Form1()
        {
            InitializeComponent();

            Thread aobThread = new Thread(scanAOB);

            //Design stuff 
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green900, Primary.Green800, Accent.Green700, TextShade.WHITE);
            //Design stuff 

            onlineCheck(urlRunning);

            updateCheck(urlUpdate);

            log_console.Text = log_console.Text + $"Welcome {userName}!\r\n"; ;

            startMainTimer();
            startgetBaseTimer();

            int title = rnd.Next(999999, 9999999);
            this.Text = title.ToString("X2");

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

            aobThread.Start();

            //log_console.Text = log_console.Text + "\r\nPBase MemLoc: " + noclipAddress + "\r\n\r\n" + "Camera MemLoc: " + cameraAddress + "\r\n\r\n" + "CameraY MemLoc: " + cameraYAddress + "\r\n\r\n" + "Camera ZMemLoc: " + cameraZAddress;
        }

        //Timer
        private void mainTimer_Tick_1(object sender, EventArgs e)
        {
            //AntiDebug
            PreventProgramFromBeingDebuged();

            xAddr = playerBaseUInt + 0x68;
            xAddrString = convertUintToHexString(xAddr);

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

            EspUint = m.Get64BitCode("swtor.exe+0x01B6E270,0xB8,0x298,0x18,0x90,0xC");

            xCoord = m.ReadFloat(xAddrString);
            yCoord = m.ReadFloat(yAddrString);
            zCoord = m.ReadFloat(zAddrString);

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
        private void timer_teleporting_Tick(object sender, EventArgs e)
        {
            teleportNumpad();

            bool isNumpad1Pressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD1);
            bool isNumpad2Pressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD2);
            bool isNumpad3Pressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD3);

            if (isNumpad1Pressed)
            {
                if(box_Freecam.CheckState == CheckState.Unchecked)
                {
                    box_Freecam.CheckState = CheckState.Checked;
                }
                else
                {
                    box_Freecam.CheckState = CheckState.Unchecked;
                }
            }
            if (isNumpad2Pressed)
            {
                btn_tpToCam.PerformClick();
            }
            if (isNumpad3Pressed)
            {
                if (box_nofall.CheckState == CheckState.Unchecked)
                {
                    box_nofall.CheckState = CheckState.Checked;
                }
                else
                {
                    box_nofall.CheckState = CheckState.Unchecked;
                }
            }

        }
        private void timer_getBase_Tick(object sender, EventArgs e)
        {
            try
            {
                ////PBASE
                string caveAddrString = convertUintToHexString(pbasecaveAddr);
                //log_console.Text = log_console.Text + "\r\n\r\nCaveAddr = " + caveAddrString;

                //Add offset 0x12 to the cave addr (that's where the ptr for pbase is stored)
                playerBaseUInt = (UIntPtr)UIntPtr.Add(pbasecaveAddr, 0x12); //caveAddr == UIntPtr

                //log caveAddr + offset
                string PbaseUintString = convertUintToHexString(playerBaseUInt);
                //log_console.Text = log_console.Text + "\r\n\r\nAddress of the PTR = " + PbaseUintString;

                //readValue & convert to hex string
                long playerBaselong = m.ReadLong(PbaseUintString);
                PlayerBaseAddress = playerBaselong.ToString("X2");
                playerBaseUInt = ParseHexToUIntPtr(PlayerBaseAddress);
            }
            catch
            {

            }
            
        }

        //CheckBoxes
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

            timer_teleporting.Start();
        }
        private void box_Freecam_CheckedChanged(object sender, EventArgs e)
        {
            if(!cameraYPatched)
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

            if(!cameraZPatched)
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
                m.WriteMemory("swtor.exe+0x01B6E270,0xB8,0x298,0x18,0x90,0xC", "int", "1");
                devEspEnabled = true;
            }
            else
            {
                m.WriteMemory("swtor.exe+0x01B6E270,0xB8,0x298,0x18,0x90,0xC", "int", "0");
                devEspEnabled = false;
            }
        }
        private void box_dotEsp_CheckedChanged(object sender, EventArgs e)
        {
            if (!devVelEnabled)
            {
                string espAddr = convertUintToHexString(EspUint);
                m.WriteMemory($"{espAddr}+0x68EC334", "int", "1");
                devVelEnabled = true;
            }
            else
            {
                string espAddr = convertUintToHexString(EspUint);
                m.WriteMemory($"{espAddr}+0x68EC334", "int", "0");
                devVelEnabled = false;
            }
        }

        //Functions
        private void scanAOB()
        {
            try
            {
                //AOB Scans
                noclipAddress = m.AoBScan(noclipAOB).Result.Sum().ToString("X2");
                cameraAddress = m.AoBScan(cameraAOB).Result.Sum().ToString("X2");
                cameraZAddress = m.AoBScan(cameraZAOB).Result.Sum().ToString("X2");
                cameraYAddress = m.AoBScan(cameraYAOB).Result.Sum().ToString("X2");
                nofallAddrString = m.AoBScan(nofallAOB).Result.Sum().ToString("X2");
                speedHackAddrString = m.AoBScan(speedHackAOB).Result.Sum().ToString("X2");

                cameraYUInt = m.Get64BitCode(cameraYAddress);
                cameraZUInt = m.Get64BitCode(cameraZAddress);
            }
            catch
            {
                //log_console.Text = log_console.Text + $"\r\n\r\nAOB's not found. Please restart the game";
                MessageBox.Show("AOB's not found. Please restart the game");
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

            m.WriteMemory(xCamAddrString, "float", camx.ToString());
            m.WriteMemory(yCamAddrString, "float", camy.ToString());
            m.WriteMemory(zCamAddrString, "float", camz.ToString());

            if (attachToCamEnabled)
            {
                m.WriteMemory(xAddrString, "float", camx.ToString());
                m.WriteMemory(yAddrString, "float", camy.ToString());
                m.WriteMemory(zAddrString, "float", camz.ToString());
            }
        }
        private void teleport()
        {
            //enable

            bool isArrived = false;

            if (savedX == 0 || savedY == 0 || savedZ == 0)
            {
                log_console.Text = log_console.Text + "\n\r\n\rInvalid Value!";
                return;
            }

            float distance = (float)Math.Sqrt(Math.Pow(xCoord - savedX, 2) + Math.Pow(yCoord - savedY, 2) + Math.Pow(zCoord - savedZ, 2));

            if (distance <= 1.0f && distance > 0)
            {
                // Player is already close to the destination
                m.WriteMemory(xAddrString, "float", (savedX).ToString());
                m.WriteMemory(yAddrString, "float", (savedY).ToString());
                m.WriteMemory(zAddrString, "float", (savedZ).ToString());
                isArrived = true;
            }
            else if (distance > 1.0f)
            {
                // Calculate the normalized movement increments
                float moveX = (savedX - xCoord) / distance;
                float moveY = (savedY - yCoord) / distance;
                float moveZ = (savedZ - zCoord) / distance;

                // Move towards the saved coordinates using normalized values
                m.WriteMemory(xAddrString, "float", (xCoord + moveX).ToString());
                m.WriteMemory(yAddrString, "float", (yCoord + moveY).ToString());
                m.WriteMemory(zAddrString, "float", (zCoord + moveZ).ToString());

                Thread.Sleep(100);

                // Check if the player has arrived
                isArrived = (distance <= 1.0f);
            }

            // Optionally: You can use the isArrived flag for further actions or checks.
            if (isArrived)
            {
                nofallFunction(); //disable
                isArrived = false;
                tpflag = false;

            }
        }
        private void teleportNumpad()
        {
            float playerXCoord = m.ReadFloat(xAddrString);
            float playerYCoord = m.ReadFloat(yAddrString);
            float playerZCoord = m.ReadFloat(zAddrString);

            bool isNumpadUpPressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD7);
            bool isNumpadDownPressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD4);
            bool isNumpadXUpPressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD8);
            bool isNumpadXDownPressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD5);
            bool isNumpadZUpPressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD9);
            bool isNumpadZDownPressed = sim.InputDeviceState.IsHardwareKeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD6);

            if (isNumpadUpPressed)
            {
                m.WriteMemory(yAddrString, "float", (playerYCoord + 0.5f).ToString());
            }
            if (isNumpadDownPressed)
            {
                m.WriteMemory(yAddrString, "float", (playerYCoord - 0.25f).ToString());
            }
            if (isNumpadXUpPressed)
            {
                m.WriteMemory(xAddrString, "float", (playerXCoord + 0.25f).ToString());
            }
            if (isNumpadXDownPressed)
            {
                m.WriteMemory(xAddrString, "float", (playerXCoord - 0.25f).ToString());
            }
            if (isNumpadZUpPressed)
            {
                m.WriteMemory(zAddrString, "float", (playerZCoord + 0.25f).ToString());
            }
            if (isNumpadZDownPressed)
            {
                m.WriteMemory(zAddrString, "float", (playerZCoord - 0.25f).ToString());
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
                    m.CreateCodeCave(nofallAddrString, patchedBytes, 6, 1000);

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
        private void onlineCheck(string url)
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
        private void updateCheck(string url)
        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;


                if (!response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Your tool is outdated please dm nightfallct on discord");
                    Environment.Exit(1);
                }
                else
                {
                    log_console.Text = log_console.Text + "\r\n\r\nYou are running the latest version\r\n\r\n";
                }

            }
        }
        private void PreventProgramFromBeingDebuged()
        {

            var a = DateTime.Now;
            Thread.Sleep(10);
            var b = DateTime.Now;

            // if difference in time is greater than 1 second it means the program has stopped executing

            if ((b - a).TotalSeconds > 2)
            {
                Application.ExitThread();
                Environment.Exit(0);
                this.Close();
            }
    
        }
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
                    byte[] patched_bytes = { 0x48, 0x89, 0x1D, 0x0B, 0x00, 0x00, 0x00, 0xF3, 0x44, 0x0F, 0x10, 0x43, 0x6C }; // patched bytes from the asm above

                    //Create Codecave
                    pbasecaveAddr = m.CreateCodeCave(noclipAddress, patched_bytes, 6, 300);

                    log_console.Invoke((MethodInvoker)delegate
                    {
                        log_console.Text = log_console.Text + "\r\n\r\nHooked";
                    });

                        //rest of code
                        noclipPatchedBytes = m.ReadBytes(noclipAddress, 6);
                    noclipPatched = true;
                    noclipCave = true;
                    //log_console.Text = log_console.Text + "\r\n\r\nCave Created";;
                }
                catch
                {
                    log_console.Invoke((MethodInvoker)delegate
                    {
                        log_console.Text = log_console.Text + "\r\n\r\nHook failed!";
                    });
                    return;
                }

            }
            else
            {
                if (noclipPatched)
                {
                    m.WriteBytes(noclipAddress, noclipBytes);
                    ////log_console.Text = log_console.Text + "\r\n\r\nUnhooked";
                    noclipPatched = false;
                }
                else
                {
                    m.WriteBytes(noclipAddress, noclipPatchedBytes);
                    ////log_console.Text = log_console.Text + "\r\n\r\nRe-hooked";
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

        //Trackbars
        private void trckbr_speed_Scroll(object sender, EventArgs e)
        {
            m.WriteMemory(speedValueUIntString, "float", trckbr_speed.Value.ToString());
            //BottomScroll
            log_console.Focus();
            log_console.ScrollToCaret();
            log_console.SelectionLength = 0;
            //BottomScroll
        }

        //Buttons
        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Nightfall\nDiscord: nightfallct");
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
            nofallFunction();

        }
        private void btn_teleport_Click(object sender, EventArgs e)
        {
            tpflag = true;
            nofallFunction();
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
    }
}
