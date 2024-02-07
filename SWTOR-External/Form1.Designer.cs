namespace SWTOR_External
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_about = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.box_glide = new System.Windows.Forms.CheckBox();
            this.lbl_CusCoord = new System.Windows.Forms.Label();
            this.btn_hotkeys = new System.Windows.Forms.Button();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.trckbr_speed = new System.Windows.Forms.TrackBar();
            this.btn_cancelTP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_saveCustomCoords = new System.Windows.Forms.Button();
            this.lbl_saveCoords = new System.Windows.Forms.Label();
            this.txt_ZBox = new System.Windows.Forms.TextBox();
            this.txt_YBox = new System.Windows.Forms.TextBox();
            this.txt_XBox = new System.Windows.Forms.TextBox();
            this.box_alwaysInFront = new System.Windows.Forms.CheckBox();
            this.box_camAttach = new System.Windows.Forms.CheckBox();
            this.box_nofall = new System.Windows.Forms.CheckBox();
            this.btn_tpToCam = new System.Windows.Forms.Button();
            this.box_Freecam = new System.Windows.Forms.CheckBox();
            this.lbl_tabOneTitle = new System.Windows.Forms.Label();
            this.btn_clearConsole = new System.Windows.Forms.Button();
            this.btn_teleport = new System.Windows.Forms.Button();
            this.btn_saveLocation = new System.Windows.Forms.Button();
            this.lbl_coords = new System.Windows.Forms.Label();
            this.lbl_cons = new System.Windows.Forms.Label();
            this.log_console = new System.Windows.Forms.TextBox();
            this.cbox_noclip = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trck_opcacity = new System.Windows.Forms.TrackBar();
            this.lbl_opacity = new System.Windows.Forms.Label();
            this.box_playerHeight = new System.Windows.Forms.TextBox();
            this.lbl_HeightNormal = new System.Windows.Forms.Label();
            this.box_dotEsp = new System.Windows.Forms.CheckBox();
            this.box_esp = new System.Windows.Forms.CheckBox();
            this.lbl_tab2Title = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.timer_teleporting = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer_getBase = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbr_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trck_opcacity)).BeginInit();
            this.Notes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_about
            // 
            this.btn_about.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_about.Location = new System.Drawing.Point(144, 351);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(80, 27);
            this.btn_about.TabIndex = 0;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(188, 25);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "SWTOR External Beta";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 10;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Notes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageListMain;
            this.tabControl1.Location = new System.Drawing.Point(3, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.box_glide);
            this.tabPage1.Controls.Add(this.lbl_CusCoord);
            this.tabPage1.Controls.Add(this.btn_hotkeys);
            this.tabPage1.Controls.Add(this.lbl_Speed);
            this.tabPage1.Controls.Add(this.trckbr_speed);
            this.tabPage1.Controls.Add(this.btn_cancelTP);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btn_saveCustomCoords);
            this.tabPage1.Controls.Add(this.lbl_saveCoords);
            this.tabPage1.Controls.Add(this.txt_ZBox);
            this.tabPage1.Controls.Add(this.txt_YBox);
            this.tabPage1.Controls.Add(this.txt_XBox);
            this.tabPage1.Controls.Add(this.box_alwaysInFront);
            this.tabPage1.Controls.Add(this.box_camAttach);
            this.tabPage1.Controls.Add(this.box_nofall);
            this.tabPage1.Controls.Add(this.btn_tpToCam);
            this.tabPage1.Controls.Add(this.box_Freecam);
            this.tabPage1.Controls.Add(this.lbl_tabOneTitle);
            this.tabPage1.Controls.Add(this.btn_clearConsole);
            this.tabPage1.Controls.Add(this.btn_teleport);
            this.tabPage1.Controls.Add(this.btn_saveLocation);
            this.tabPage1.Controls.Add(this.lbl_coords);
            this.tabPage1.Controls.Add(this.lbl_cons);
            this.tabPage1.Controls.Add(this.log_console);
            this.tabPage1.Controls.Add(this.cbox_noclip);
            this.tabPage1.Controls.Add(this.btn_about);
            this.tabPage1.ImageKey = "home_house_3526.ico";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movement";
            // 
            // box_glide
            // 
            this.box_glide.AutoSize = true;
            this.box_glide.Location = new System.Drawing.Point(9, 143);
            this.box_glide.Name = "box_glide";
            this.box_glide.Size = new System.Drawing.Size(68, 17);
            this.box_glide.TabIndex = 26;
            this.box_glide.Text = "Freeze Y";
            this.box_glide.UseVisualStyleBackColor = true;
            this.box_glide.CheckedChanged += new System.EventHandler(this.box_glide_CheckedChanged);
            // 
            // lbl_CusCoord
            // 
            this.lbl_CusCoord.AutoSize = true;
            this.lbl_CusCoord.Location = new System.Drawing.Point(6, 176);
            this.lbl_CusCoord.Name = "lbl_CusCoord";
            this.lbl_CusCoord.Size = new System.Drawing.Size(81, 13);
            this.lbl_CusCoord.TabIndex = 25;
            this.lbl_CusCoord.Text = "Custom Coords:";
            // 
            // btn_hotkeys
            // 
            this.btn_hotkeys.Location = new System.Drawing.Point(144, 195);
            this.btn_hotkeys.Name = "btn_hotkeys";
            this.btn_hotkeys.Size = new System.Drawing.Size(55, 23);
            this.btn_hotkeys.TabIndex = 24;
            this.btn_hotkeys.Text = "Hotkeys";
            this.btn_hotkeys.UseVisualStyleBackColor = true;
            this.btn_hotkeys.Click += new System.EventHandler(this.btn_hotkeys_Click);
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.AutoSize = true;
            this.lbl_Speed.Location = new System.Drawing.Point(6, 305);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(111, 13);
            this.lbl_Speed.TabIndex = 23;
            this.lbl_Speed.Text = "Custom Speed (Risky)";
            // 
            // trckbr_speed
            // 
            this.trckbr_speed.AutoSize = false;
            this.trckbr_speed.BackColor = System.Drawing.Color.White;
            this.trckbr_speed.Location = new System.Drawing.Point(9, 321);
            this.trckbr_speed.Name = "trckbr_speed";
            this.trckbr_speed.Size = new System.Drawing.Size(104, 23);
            this.trckbr_speed.TabIndex = 22;
            this.trckbr_speed.Scroll += new System.EventHandler(this.trckbr_speed_Scroll);
            // 
            // btn_cancelTP
            // 
            this.btn_cancelTP.Location = new System.Drawing.Point(144, 166);
            this.btn_cancelTP.Name = "btn_cancelTP";
            this.btn_cancelTP.Size = new System.Drawing.Size(55, 23);
            this.btn_cancelTP.TabIndex = 21;
            this.btn_cancelTP.Text = "Cancel TP";
            this.btn_cancelTP.UseVisualStyleBackColor = true;
            this.btn_cancelTP.Click += new System.EventHandler(this.btn_cancelTP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_saveCustomCoords
            // 
            this.btn_saveCustomCoords.Location = new System.Drawing.Point(34, 270);
            this.btn_saveCustomCoords.Name = "btn_saveCustomCoords";
            this.btn_saveCustomCoords.Size = new System.Drawing.Size(55, 23);
            this.btn_saveCustomCoords.TabIndex = 19;
            this.btn_saveCustomCoords.Text = "Save";
            this.btn_saveCustomCoords.UseVisualStyleBackColor = true;
            this.btn_saveCustomCoords.Click += new System.EventHandler(this.btn_saveCustomCoords_Click);
            // 
            // lbl_saveCoords
            // 
            this.lbl_saveCoords.AutoSize = true;
            this.lbl_saveCoords.Location = new System.Drawing.Point(11, 195);
            this.lbl_saveCoords.Name = "lbl_saveCoords";
            this.lbl_saveCoords.Size = new System.Drawing.Size(17, 65);
            this.lbl_saveCoords.TabIndex = 18;
            this.lbl_saveCoords.Text = "X:\r\n\r\nY:\r\n\r\nZ:";
            // 
            // txt_ZBox
            // 
            this.txt_ZBox.Location = new System.Drawing.Point(34, 244);
            this.txt_ZBox.Name = "txt_ZBox";
            this.txt_ZBox.Size = new System.Drawing.Size(55, 20);
            this.txt_ZBox.TabIndex = 17;
            // 
            // txt_YBox
            // 
            this.txt_YBox.Location = new System.Drawing.Point(34, 218);
            this.txt_YBox.Name = "txt_YBox";
            this.txt_YBox.Size = new System.Drawing.Size(55, 20);
            this.txt_YBox.TabIndex = 16;
            // 
            // txt_XBox
            // 
            this.txt_XBox.Location = new System.Drawing.Point(34, 192);
            this.txt_XBox.Name = "txt_XBox";
            this.txt_XBox.Size = new System.Drawing.Size(55, 20);
            this.txt_XBox.TabIndex = 15;
            // 
            // box_alwaysInFront
            // 
            this.box_alwaysInFront.AutoSize = true;
            this.box_alwaysInFront.Location = new System.Drawing.Point(7, 365);
            this.box_alwaysInFront.Name = "box_alwaysInFront";
            this.box_alwaysInFront.Size = new System.Drawing.Size(59, 17);
            this.box_alwaysInFront.TabIndex = 14;
            this.box_alwaysInFront.Text = "OnTop";
            this.box_alwaysInFront.UseVisualStyleBackColor = true;
            this.box_alwaysInFront.CheckedChanged += new System.EventHandler(this.box_alwaysInFront_CheckedChanged);
            // 
            // box_camAttach
            // 
            this.box_camAttach.AutoSize = true;
            this.box_camAttach.Location = new System.Drawing.Point(9, 98);
            this.box_camAttach.Name = "box_camAttach";
            this.box_camAttach.Size = new System.Drawing.Size(91, 17);
            this.box_camAttach.TabIndex = 13;
            this.box_camAttach.Text = "AttachToCam";
            this.box_camAttach.UseVisualStyleBackColor = true;
            this.box_camAttach.CheckedChanged += new System.EventHandler(this.box_camAttach_CheckedChanged);
            // 
            // box_nofall
            // 
            this.box_nofall.AutoSize = true;
            this.box_nofall.Location = new System.Drawing.Point(9, 121);
            this.box_nofall.Name = "box_nofall";
            this.box_nofall.Size = new System.Drawing.Size(97, 17);
            this.box_nofall.TabIndex = 12;
            this.box_nofall.Text = "No Falldamage";
            this.box_nofall.UseVisualStyleBackColor = true;
            this.box_nofall.CheckedChanged += new System.EventHandler(this.box_nofall_CheckedChanged);
            // 
            // btn_tpToCam
            // 
            this.btn_tpToCam.Location = new System.Drawing.Point(71, 76);
            this.btn_tpToCam.Name = "btn_tpToCam";
            this.btn_tpToCam.Size = new System.Drawing.Size(31, 19);
            this.btn_tpToCam.TabIndex = 11;
            this.btn_tpToCam.Text = "TP";
            this.btn_tpToCam.UseVisualStyleBackColor = true;
            this.btn_tpToCam.Click += new System.EventHandler(this.btn_tpToCam_Click);
            // 
            // box_Freecam
            // 
            this.box_Freecam.AutoSize = true;
            this.box_Freecam.Location = new System.Drawing.Point(9, 78);
            this.box_Freecam.Name = "box_Freecam";
            this.box_Freecam.Size = new System.Drawing.Size(67, 17);
            this.box_Freecam.TabIndex = 9;
            this.box_Freecam.Text = "Freecam";
            this.box_Freecam.UseVisualStyleBackColor = true;
            this.box_Freecam.CheckedChanged += new System.EventHandler(this.box_Freecam_CheckedChanged);
            // 
            // lbl_tabOneTitle
            // 
            this.lbl_tabOneTitle.AutoSize = true;
            this.lbl_tabOneTitle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabOneTitle.Location = new System.Drawing.Point(3, 3);
            this.lbl_tabOneTitle.Name = "lbl_tabOneTitle";
            this.lbl_tabOneTitle.Size = new System.Drawing.Size(170, 23);
            this.lbl_tabOneTitle.TabIndex = 9;
            this.lbl_tabOneTitle.Text = "General Movement";
            // 
            // btn_clearConsole
            // 
            this.btn_clearConsole.Location = new System.Drawing.Point(258, 330);
            this.btn_clearConsole.Name = "btn_clearConsole";
            this.btn_clearConsole.Size = new System.Drawing.Size(45, 23);
            this.btn_clearConsole.TabIndex = 8;
            this.btn_clearConsole.Text = "Clear";
            this.btn_clearConsole.UseVisualStyleBackColor = true;
            this.btn_clearConsole.Click += new System.EventHandler(this.btn_clearConsole_Click);
            // 
            // btn_teleport
            // 
            this.btn_teleport.Location = new System.Drawing.Point(144, 137);
            this.btn_teleport.Name = "btn_teleport";
            this.btn_teleport.Size = new System.Drawing.Size(55, 23);
            this.btn_teleport.TabIndex = 7;
            this.btn_teleport.Text = "Teleport";
            this.btn_teleport.UseVisualStyleBackColor = true;
            this.btn_teleport.Click += new System.EventHandler(this.btn_teleport_Click);
            // 
            // btn_saveLocation
            // 
            this.btn_saveLocation.Location = new System.Drawing.Point(144, 108);
            this.btn_saveLocation.Name = "btn_saveLocation";
            this.btn_saveLocation.Size = new System.Drawing.Size(55, 23);
            this.btn_saveLocation.TabIndex = 6;
            this.btn_saveLocation.Text = "Save";
            this.btn_saveLocation.UseVisualStyleBackColor = true;
            this.btn_saveLocation.Click += new System.EventHandler(this.btn_saveLocation_Click);
            // 
            // lbl_coords
            // 
            this.lbl_coords.AutoSize = true;
            this.lbl_coords.Location = new System.Drawing.Point(141, 53);
            this.lbl_coords.Name = "lbl_coords";
            this.lbl_coords.Size = new System.Drawing.Size(17, 52);
            this.lbl_coords.TabIndex = 5;
            this.lbl_coords.Text = "X:\r\nY:\r\nZ:\r\nV:";
            // 
            // lbl_cons
            // 
            this.lbl_cons.AutoSize = true;
            this.lbl_cons.Location = new System.Drawing.Point(211, 44);
            this.lbl_cons.Name = "lbl_cons";
            this.lbl_cons.Size = new System.Drawing.Size(33, 13);
            this.lbl_cons.TabIndex = 4;
            this.lbl_cons.Text = "Logs:";
            // 
            // log_console
            // 
            this.log_console.Location = new System.Drawing.Point(211, 63);
            this.log_console.Multiline = true;
            this.log_console.Name = "log_console";
            this.log_console.ReadOnly = true;
            this.log_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_console.Size = new System.Drawing.Size(141, 265);
            this.log_console.TabIndex = 3;
            // 
            // cbox_noclip
            // 
            this.cbox_noclip.AutoSize = true;
            this.cbox_noclip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_noclip.ForeColor = System.Drawing.Color.Red;
            this.cbox_noclip.Location = new System.Drawing.Point(9, 50);
            this.cbox_noclip.Name = "cbox_noclip";
            this.cbox_noclip.Size = new System.Drawing.Size(106, 17);
            this.cbox_noclip.TabIndex = 2;
            this.cbox_noclip.Text = "Master-Switch";
            this.cbox_noclip.UseVisualStyleBackColor = true;
            this.cbox_noclip.CheckedChanged += new System.EventHandler(this.cbox_noclip_CheckedChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.trck_opcacity);
            this.tabPage2.Controls.Add(this.lbl_opacity);
            this.tabPage2.Controls.Add(this.box_playerHeight);
            this.tabPage2.Controls.Add(this.lbl_HeightNormal);
            this.tabPage2.Controls.Add(this.box_dotEsp);
            this.tabPage2.Controls.Add(this.box_esp);
            this.tabPage2.Controls.Add(this.lbl_tab2Title);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage2.ImageKey = "death_star_wars_icon_183176.ico";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trck_opcacity
            // 
            this.trck_opcacity.AutoSize = false;
            this.trck_opcacity.BackColor = System.Drawing.Color.White;
            this.trck_opcacity.Location = new System.Drawing.Point(7, 274);
            this.trck_opcacity.Maximum = 100;
            this.trck_opcacity.Minimum = 10;
            this.trck_opcacity.Name = "trck_opcacity";
            this.trck_opcacity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trck_opcacity.Size = new System.Drawing.Size(24, 104);
            this.trck_opcacity.TabIndex = 29;
            this.trck_opcacity.Value = 100;
            this.trck_opcacity.Scroll += new System.EventHandler(this.trck_opcacity_Scroll);
            // 
            // lbl_opacity
            // 
            this.lbl_opacity.AutoSize = true;
            this.lbl_opacity.Location = new System.Drawing.Point(6, 258);
            this.lbl_opacity.Name = "lbl_opacity";
            this.lbl_opacity.Size = new System.Drawing.Size(85, 13);
            this.lbl_opacity.TabIndex = 28;
            this.lbl_opacity.Text = "Window-Opacity";
            // 
            // box_playerHeight
            // 
            this.box_playerHeight.Location = new System.Drawing.Point(48, 87);
            this.box_playerHeight.Name = "box_playerHeight";
            this.box_playerHeight.Size = new System.Drawing.Size(40, 20);
            this.box_playerHeight.TabIndex = 27;
            this.box_playerHeight.Text = "1";
            this.box_playerHeight.TextChanged += new System.EventHandler(this.box_playerHeight_TextChanged);
            // 
            // lbl_HeightNormal
            // 
            this.lbl_HeightNormal.AutoSize = true;
            this.lbl_HeightNormal.Location = new System.Drawing.Point(4, 90);
            this.lbl_HeightNormal.Name = "lbl_HeightNormal";
            this.lbl_HeightNormal.Size = new System.Drawing.Size(152, 13);
            this.lbl_HeightNormal.TabIndex = 26;
            this.lbl_HeightNormal.Text = "Height:                  (1 = Normal)";
            // 
            // box_dotEsp
            // 
            this.box_dotEsp.AutoSize = true;
            this.box_dotEsp.Location = new System.Drawing.Point(7, 61);
            this.box_dotEsp.Name = "box_dotEsp";
            this.box_dotEsp.Size = new System.Drawing.Size(146, 17);
            this.box_dotEsp.TabIndex = 25;
            this.box_dotEsp.Text = "Velocity Indicator (Buggy)";
            this.box_dotEsp.UseVisualStyleBackColor = true;
            this.box_dotEsp.CheckedChanged += new System.EventHandler(this.box_dotEsp_CheckedChanged);
            // 
            // box_esp
            // 
            this.box_esp.AutoSize = true;
            this.box_esp.Location = new System.Drawing.Point(7, 38);
            this.box_esp.Name = "box_esp";
            this.box_esp.Size = new System.Drawing.Size(81, 17);
            this.box_esp.TabIndex = 24;
            this.box_esp.Text = "Target ESP";
            this.box_esp.UseVisualStyleBackColor = true;
            this.box_esp.CheckedChanged += new System.EventHandler(this.box_esp_CheckedChanged);
            // 
            // lbl_tab2Title
            // 
            this.lbl_tab2Title.AutoSize = true;
            this.lbl_tab2Title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tab2Title.Location = new System.Drawing.Point(3, 3);
            this.lbl_tab2Title.Name = "lbl_tab2Title";
            this.lbl_tab2Title.Size = new System.Drawing.Size(49, 23);
            this.lbl_tab2Title.TabIndex = 10;
            this.lbl_tab2Title.Text = "Misc";
            // 
            // Notes
            // 
            this.Notes.Controls.Add(this.textBox1);
            this.Notes.ImageKey = "feather_38326.ico";
            this.Notes.Location = new System.Drawing.Point(4, 23);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(368, 384);
            this.Notes.TabIndex = 2;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(356, 372);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "feather_38326.ico");
            this.imageListMain.Images.SetKeyName(1, "OIG.n.jpg");
            this.imageListMain.Images.SetKeyName(2, "death_star_wars_icon_183176.ico");
            this.imageListMain.Images.SetKeyName(3, "home_house_3526.ico");
            this.imageListMain.Images.SetKeyName(4, "");
            this.imageListMain.Images.SetKeyName(5, "");
            // 
            // timer_teleporting
            // 
            this.timer_teleporting.Tick += new System.EventHandler(this.timer_teleporting_Tick);
            // 
            // timer_getBase
            // 
            this.timer_getBase.Interval = 500;
            this.timer_getBase.Tick += new System.EventHandler(this.timer_getBase_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 438);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_title);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.Text = "swtool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbr_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trck_opcacity)).EndInit();
            this.Notes.ResumeLayout(false);
            this.Notes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbox_noclip;
        private System.Windows.Forms.TextBox log_console;
        private System.Windows.Forms.Label lbl_cons;
        private System.Windows.Forms.Label lbl_coords;
        private System.Windows.Forms.Button btn_clearConsole;
        private System.Windows.Forms.Button btn_teleport;
        private System.Windows.Forms.Button btn_saveLocation;
        private System.Windows.Forms.CheckBox box_Freecam;
        private System.Windows.Forms.Label lbl_tabOneTitle;
        private System.Windows.Forms.Label lbl_tab2Title;
        private System.Windows.Forms.Timer timer_teleporting;
        private System.Windows.Forms.Button btn_tpToCam;
        private System.Windows.Forms.CheckBox box_nofall;
        private System.Windows.Forms.CheckBox box_camAttach;
        private System.Windows.Forms.CheckBox box_alwaysInFront;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.Label lbl_saveCoords;
        private System.Windows.Forms.TextBox txt_ZBox;
        private System.Windows.Forms.TextBox txt_YBox;
        private System.Windows.Forms.TextBox txt_XBox;
        private System.Windows.Forms.Button btn_saveCustomCoords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_cancelTP;
        private System.Windows.Forms.TrackBar trckbr_speed;
        private System.Windows.Forms.Label lbl_Speed;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer_getBase;
        private System.Windows.Forms.CheckBox box_esp;
        private System.Windows.Forms.CheckBox box_dotEsp;
        private System.Windows.Forms.Label lbl_CusCoord;
        private System.Windows.Forms.Button btn_hotkeys;
        private System.Windows.Forms.Label lbl_HeightNormal;
        private System.Windows.Forms.TextBox box_playerHeight;
        private System.Windows.Forms.CheckBox box_glide;
        private System.Windows.Forms.Label lbl_opacity;
        private System.Windows.Forms.TrackBar trck_opcacity;
    }
}

