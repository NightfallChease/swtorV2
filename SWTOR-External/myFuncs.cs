using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace SWTOR_External
{
    public class myFuncs
    {
        #region vars
        public static string urlRunning = "https://github.com/NightfallChease/s/blob/main/isRunning.sw";
        public static string urlUpdate = "https://github.com/NightfallChease/s/blob/main/version7.3.sw";
        public static bool noclipPatched = false;
        public static bool cameraPatched = false;
        public static bool cameraZPatched = false;
        public static bool cameraYPatched = false;
        public static bool noclipCave = false;
        public static bool camCave = false;
        public static bool freeCamEnabled = false;
        public static bool attachToCamEnabled = false;
        public static bool nofallEnabled = false;
        public static bool nofallPatched = false;
        public static bool alwaysOnTop = false;
        public static bool devEspEnabled = false;
        public static bool devVelEnabled = false;
        public static string noclipAOB = "F3 44 0F 10 43 6C F3";
        public static string cameraAOB = "48 8B 01 48 8B 80 F0 01 00 00 FF 15 ?? ?? ?? ?? EB 07 48 8D 05 ?? ?? ?? ?? 0F";
        public static string cameraYAOB = "F2 0F 11 87 28 02 00 00";
        public static string cameraZAOB = "89 87 30 02 00 00 F3";
        public static string nofallAOB = "F3 44 0F 10 4F 10 44 0F 28 DF";
        public static string speedHackAOB = "F3 0F 10 BE F4 00 00 00 0F 28 F7";
        public static string devESPAob = "0F 84 ?? ?? ?? ?? B9 06 00 00 00 41 FF D4 48 BE";
        public static string velocityIndicatorAOB = "74 1F B9 ?? ?? ?? ?? 41 FF D6 4C 8D 45 D0 B9 ?? ?? ?? ?? 48 89 F2 FF D7 48 8B 4D D0 FF D0 41 FF D7";
        public static string glideAOB = "F3 44 0F 11 43 14 F3 0F";
        public static bool glideEnabled = false;
        public static VirtualKeyCode TPUpKey;
        public static VirtualKeyCode TPDownKey;
        public static VirtualKeyCode TPLeftKey;
        public static VirtualKeyCode TPRightKey;
        public static VirtualKeyCode TPForwardKey;
        public static VirtualKeyCode TPBackwardKey;
        public static VirtualKeyCode FreecamKey;
        public static VirtualKeyCode TPToCamKey;
        public static VirtualKeyCode NofallKey;
        public static VirtualKeyCode GlideKey;
        public static VirtualKeyCode SpeedKey;
        public static string PlayerBaseAddress = "";
        public static string CamBaseAddress = "";
        public static UIntPtr playerBaseUInt;
        public static UIntPtr camBaseUInt;
        public static UIntPtr EspUint;
        public static int baseAddr = 0;
        public static string noclipAddress = "";
        public static string glideAddrString;
        public static string cameraAddress = "";
        public static string cameraYAddress = "";
        public static string cameraZAddress = "";
        public static float xCoord = 0;
        public static float yCoord = 0;
        public static float zCoord = 0;
        public static float camSpeed = 0.1f;
        public static float speedBoostMultiplier = 2f;
        public static bool isSpeedBoostActive = false;
        public static string xAddrString = "";
        public static string yAddrString = "";
        public static string zAddrString = "";
        public static string devESPAddrString = "";
        public static string velocityIndAddrStr = "";
        public static string xCamAddrString = "";
        public static string yCamAddrString = "";
        public static string zCamAddrString = "";
        public static string nofallAddrString = "";
        public static string speedValueUIntString;
        public static string speedHackAddrString;
        public static string yawAddrString;
        public static string pitchAddrString;
        public static float savedX = 0;
        public static float savedY = 0;
        public static float savedZ = 0;
        public static UIntPtr xAddr;
        public static UIntPtr yAddr;
        public static UIntPtr zAddr;
        public static UIntPtr xCamAddr;
        public static UIntPtr yCamAddr;
        public static UIntPtr zCamAddr;
        public static UIntPtr nofallAddr;
        public static UIntPtr pitchAddr;
        public static UIntPtr yawAddr;
        public static UIntPtr cameraYUInt;
        public static UIntPtr cameraZUInt;
        public static UIntPtr yVelocityAddr;
        public static UIntPtr heightAddr;
        public static string heightAddrString;
        public static string yVelocityAddrString;
        public static bool tpflag = false;
        public static bool saveflag = false;
        public static bool speedHackCave;
        public static float playerHeight;
        public static string userName = Environment.UserName;
        public static UIntPtr speedValueUInt;
        public static byte[] speedPatchedBytes;
        public static bool speedPatched;
        public static UIntPtr pbasecaveAddr;
        public static bool isPVPEnabled = false;
        public static string PVPAOB = "50 00 56 00 45 00 00 00 ?? ?? ?? ?? ?? 7D 00 00 ?? ?? ?? ?? ??";
        public static bool isSpeedhackEnabled = false;
        public static byte[] noclipPatchedBytes = { };
        public static byte[] cameraPatchedBytes = { };
        public static byte[] cameraYPatchedBytes = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
        public static byte[] cameraZPatchedBytes = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
        public static byte[] noclipBytes = { 0xF3, 0x44, 0x0F, 0x10, 0x43, 0x6C, 0xF3 };
        public static byte[] cameraBytes = { 0x48, 0x8B, 0x01, 0x48, 0x8B, 0x80, 0xF0, 0x01, 0x00, 0x00 };
        public static byte[] speedBytes = { 0xF3, 0x0F, 0x10, 0xBE, 0xF4, 0x00, 0x00, 0x00, 0x0F, 0x28, 0xF7 };
        public static byte[] cameraYBytes = { 0xF2, 0x0F, 0x11, 0x87, 0x28, 0x02, 0x00, 0x00 };
        public static byte[] cameraZBytes = { 0x89, 0x87, 0x30, 0x02, 0x00, 0x00, 0xF3 };
        public static byte[] patchedBytes = { 0xC7, 0x47, 0x10, 0x33, 0x33, 0x33, 0xBF, 0xF3, 0x44, 0x0F, 0x10, 0x4F, 0x10 };
        public static byte[] originalBytes = { 0xF3, 0x44, 0x0F, 0x10, 0x4F, 0x10 };
        public static byte[] gotoCaveBytes = { };
        #endregion

        Random rnd = new Random();
        Mem m = new Mem();
        InputSimulator sim = new InputSimulator();

        //Functions
        public static void scanAOB()
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
                devESPAddrString = m.AoBScan(devESPAob).Result.Sum().ToString("X2");
                velocityIndAddrStr = m.AoBScan(velocityIndicatorAOB).Result.Sum().ToString("X2");
                glideAddrString = m.AoBScan(glideAOB).Result.Sum().ToString("X2");

                cameraYUInt = m.Get64BitCode(cameraYAddress);
                cameraZUInt = m.Get64BitCode(cameraZAddress);
            }
            catch
            {
                //log_console.Text = log_console.Text + $"\r\n\r\nAOB's not found. Please restart the game";
                MessageBox.Show("AOB's not found. Please restart the game");
            }
        }
        public static void Freecam()
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
                savedX = camx;
                savedY = camy;
                savedZ = camz;
                tpflag = true;
                //m.WriteMemory(xAddrString, "float", camx.ToString());
                //m.WriteMemory(yAddrString, "float", camy.ToString());
                //m.WriteMemory(zAddrString, "float", camz.ToString());
            }
        }
        public static void teleport()
        {
            //enable

            bool isArrived = false;

            if (!glideEnabled)
            {
                doglide();
            }

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
                doglide();
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
                isArrived = false;
                tpflag = false;
            }
        }
        public static void teleportNumpad()
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
                    m.WriteMemory(yAddrString, "float", (playerYCoord + 0.5f).ToString());
                }
                if (isTPDownPressed)
                {
                    m.WriteMemory(yAddrString, "float", (playerYCoord - 0.25f).ToString());
                }
                if (isTPXUpPressed)
                {
                    m.WriteMemory(xAddrString, "float", (playerXCoord + 0.25f).ToString());
                }
                if (isTPXDownPressed)
                {
                    m.WriteMemory(xAddrString, "float", (playerXCoord - 0.25f).ToString());
                }
                if (isTPZUpPressed)
                {
                    m.WriteMemory(zAddrString, "float", (playerZCoord + 0.25f).ToString());
                }
                if (isTPZDownPressed)
                {
                    m.WriteMemory(zAddrString, "float", (playerZCoord - 0.25f).ToString());
                }
                Thread.Sleep(200);
            }
        }
        public string convertUintToHexString(UIntPtr uintToConvert)
        {
            string placeholder1 = uintToConvert.ToString();
            long placeholder2 = long.Parse(placeholder1);
            string hexstring = placeholder2.ToString("X2");
            return hexstring;
        }
        public static UIntPtr ParseHexToUIntPtr(string hexValue)
        {
            // Parse the hexadecimal string into a UIntPtr
            ulong numericValue = ulong.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);

            return new UIntPtr(numericValue);
        }
        public static void nofallFunction()
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
        public static void onlineCheck(string url)
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
        public static void updateCheck(string url)
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
        public static void PreventProgramFromBeingDebuged()
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
        public static void startMainTimer()
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
        public static void startgetBaseTimer()
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
        public static void createCodeCave()
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
                    log_console.Invoke((MethodInvoker)delegate
                    {
                        log_console.Text = log_console.Text + "\r\n\r\nUnhooked";
                    });
                    noclipPatched = false;
                }
                else
                {
                    m.WriteBytes(noclipAddress, noclipPatchedBytes);
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
        public static void logToConsole(string textToLog)
        {
            log_console.Text = log_console.Text + $"\r\n\r\n{textToLog}";
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
        public static void doglide()
        {
            if (!glideEnabled)
            {
                glideEnabled = true;

                m.WriteMemory(glideAddrString, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                glideEnabled = false;

                m.WriteMemory(glideAddrString, "bytes", glideAOB);
            }
        }
        public static void speedhackFunction()
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
        public static void tpToCam()
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
        public static void hotkeysFunction()
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

        //Trackbars
        public static void trckbr_speed_Scroll(object sender, EventArgs e)
        {
            if (isSpeedhackEnabled)
            {
                m.WriteMemory(speedValueUIntString, "float", trckbr_speed.Value.ToString());
                //BottomScroll
                log_console.Focus();
                log_console.ScrollToCaret();
                log_console.SelectionLength = 0;
                //BottomScroll
            }
        }
        public static void trck_opcacity_Scroll(object sender, EventArgs e)
        {
            float newOpacity = (float)(trck_opcacity.Value) / 100;
            this.Opacity = newOpacity;
        }

        //InputFields
        public void box_playerHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (box_playerHeight.Text == "")
                {
                    return;
                }

                m.WriteMemory(heightAddrString, "float", $"{box_playerHeight.Text}");
            }
            catch
            {
                logToConsole("Invalid player height");
            }
        }

        //Buttons
        public void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Nightfall\nDiscord: nightfallct");
        }
        public void btn_clearConsole_Click(object sender, EventArgs e)
        {
            log_console.Text = "";
        }
        public void btn_saveLocation_Click(object sender, EventArgs e)
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
        public void btn_tpToCam_Click(object sender, EventArgs e)
        {
            tpToCam();
        }
        public void btn_teleport_Click(object sender, EventArgs e)
        {
            tpflag = true;
            box_nofall.Checked = true;
            //BottomScroll
            log_console.Focus();
            log_console.ScrollToCaret();
            log_console.SelectionLength = 0;
            //BottomScroll
        }
        public void btn_saveCustomCoords_Click(object sender, EventArgs e)
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
        public void btn_cancelTP_Click(object sender, EventArgs e)
        {
            tpflag = false;
            nofallFunction();
        }
        public void btn_example_Click(object sender, EventArgs e)
        {
            RunExampleScript();
        }
        public void btn_runScript_Click(object sender, EventArgs e)
        {
            string scriptCode = txtbox_script.Text;
            // Create a new thread and pass the method to execute
            Thread executeScriptThread = new Thread(() => ExecuteScript(scriptCode)) { IsBackground = true };
            executeScriptThread.Start(); // Start the thread
        }
        //Assign Hotkeys
        public void txtbox_TpUpHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            //TPUpKey == VirtualKeyCode
            TPUpKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPUpKey.Text = TPUpKey.ToString();
        }
        public void txtbox_TPDowNkey_KeyDown(object sender, KeyEventArgs e)
        {
            TPDownKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPDowNkey.Text = TPDownKey.ToString();
        }
        public void txtbox_TPLeftKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPLeftKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPLeftKey.Text = TPLeftKey.ToString();
        }
        public void txtbox_TPRightKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPRightKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPRightKey.Text = TPRightKey.ToString();
        }
        public void txtbox_TPForwardKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPForwardKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPForwardKey.Text = TPForwardKey.ToString();
        }
        public void txtbox_TPBackwardKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPBackwardKey = (VirtualKeyCode)e.KeyCode;
            txtbox_TPBackwardKey.Text = TPBackwardKey.ToString();
        }
        public void txtbox_freecamKey_KeyDown(object sender, KeyEventArgs e)
        {
            FreecamKey = (VirtualKeyCode)e.KeyCode;
            txtbox_freecamKey.Text = FreecamKey.ToString();
        }
        public void txtbox_tpToCamKey_KeyDown(object sender, KeyEventArgs e)
        {
            TPToCamKey = (VirtualKeyCode)e.KeyCode;
            txtbox_tpToCamKey.Text = TPToCamKey.ToString();
        }
        public void txtbox_nofallKey_KeyDown(object sender, KeyEventArgs e)
        {
            NofallKey = (VirtualKeyCode)e.KeyCode;
            txtbox_nofallKey.Text = NofallKey.ToString();
        }
        public void txtbox_glideKey_KeyDown(object sender, KeyEventArgs e)
        {
            GlideKey = (VirtualKeyCode)e.KeyCode;
            txtbox_glideKey.Text = GlideKey.ToString();
        }
        public void txtbox_speedKey_KeyDown(object sender, KeyEventArgs e)
        {
            SpeedKey = (VirtualKeyCode)e.KeyCode;
            txtbox_speedKey.Text = SpeedKey.ToString();
        }
    }
}
