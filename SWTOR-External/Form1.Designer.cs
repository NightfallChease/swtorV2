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
            this.tab_List = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_version = new System.Windows.Forms.Label();
            this.box_speedhack = new System.Windows.Forms.CheckBox();
            this.box_glide = new System.Windows.Forms.CheckBox();
            this.lbl_CusCoord = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_speedKey = new System.Windows.Forms.Label();
            this.lbl_customHks = new System.Windows.Forms.Label();
            this.txtbox_speedKey = new System.Windows.Forms.TextBox();
            this.lbl_glideKey = new System.Windows.Forms.Label();
            this.txtbox_glideKey = new System.Windows.Forms.TextBox();
            this.lbl_TpToCamKey = new System.Windows.Forms.Label();
            this.txtbox_tpToCamKey = new System.Windows.Forms.TextBox();
            this.lbl_nofallKey = new System.Windows.Forms.Label();
            this.txtbox_nofallKey = new System.Windows.Forms.TextBox();
            this.lbl_freecamKey = new System.Windows.Forms.Label();
            this.txtbox_freecamKey = new System.Windows.Forms.TextBox();
            this.lbl_tpBackw = new System.Windows.Forms.Label();
            this.txtbox_TPBackwardKey = new System.Windows.Forms.TextBox();
            this.lbl_tpForward = new System.Windows.Forms.Label();
            this.txtbox_TPForwardKey = new System.Windows.Forms.TextBox();
            this.lbl_tpRight = new System.Windows.Forms.Label();
            this.txtbox_TPRightKey = new System.Windows.Forms.TextBox();
            this.lbl_tpLeft = new System.Windows.Forms.Label();
            this.txtbox_TPLeftKey = new System.Windows.Forms.TextBox();
            this.lbl_tpDown = new System.Windows.Forms.Label();
            this.txtbox_TPDowNkey = new System.Windows.Forms.TextBox();
            this.lbl_tpUp = new System.Windows.Forms.Label();
            this.txtbox_TPUpKey = new System.Windows.Forms.TextBox();
            this.trck_opcacity = new System.Windows.Forms.TrackBar();
            this.lbl_opacity = new System.Windows.Forms.Label();
            this.box_playerHeight = new System.Windows.Forms.TextBox();
            this.lbl_HeightNormal = new System.Windows.Forms.Label();
            this.box_dotEsp = new System.Windows.Forms.CheckBox();
            this.box_esp = new System.Windows.Forms.CheckBox();
            this.lbl_tab2Title = new System.Windows.Forms.Label();
            this.tab_Scripts = new System.Windows.Forms.TabPage();
            this.btn_loadScript = new System.Windows.Forms.Button();
            this.btn_saveScript = new System.Windows.Forms.Button();
            this.btn_showVars = new System.Windows.Forms.Button();
            this.btn_example = new System.Windows.Forms.Button();
            this.btn_runScript = new System.Windows.Forms.Button();
            this.txtbox_script = new System.Windows.Forms.TextBox();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer_getBase = new System.Windows.Forms.Timer(this.components);
            this.box_darkmode = new System.Windows.Forms.CheckBox();
            this.tab_List.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbr_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trck_opcacity)).BeginInit();
            this.tab_Scripts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_about
            // 
            this.btn_about.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // tab_List
            // 
            this.tab_List.Controls.Add(this.tabPage1);
            this.tab_List.Controls.Add(this.tabPage2);
            this.tab_List.Controls.Add(this.tab_Scripts);
            this.tab_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_List.ImageList = this.imageListMain;
            this.tab_List.Location = new System.Drawing.Point(3, 24);
            this.tab_List.Name = "tab_List";
            this.tab_List.SelectedIndex = 0;
            this.tab_List.Size = new System.Drawing.Size(376, 411);
            this.tab_List.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.box_darkmode);
            this.tabPage1.Controls.Add(this.lbl_version);
            this.tabPage1.Controls.Add(this.box_speedhack);
            this.tabPage1.Controls.Add(this.box_glide);
            this.tabPage1.Controls.Add(this.lbl_CusCoord);
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
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(337, 369);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(28, 13);
            this.lbl_version.TabIndex = 28;
            this.lbl_version.Text = "v7.3";
            // 
            // box_speedhack
            // 
            this.box_speedhack.AutoSize = true;
            this.box_speedhack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_speedhack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_speedhack.Location = new System.Drawing.Point(119, 321);
            this.box_speedhack.Name = "box_speedhack";
            this.box_speedhack.Size = new System.Drawing.Size(40, 17);
            this.box_speedhack.TabIndex = 27;
            this.box_speedhack.Text = "Off";
            this.box_speedhack.UseVisualStyleBackColor = true;
            this.box_speedhack.CheckedChanged += new System.EventHandler(this.box_speedhack_CheckedChanged);
            // 
            // box_glide
            // 
            this.box_glide.AutoSize = true;
            this.box_glide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_glide.Location = new System.Drawing.Point(9, 143);
            this.box_glide.Name = "box_glide";
            this.box_glide.Size = new System.Drawing.Size(65, 17);
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
            this.btn_cancelTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btn_saveCustomCoords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveCustomCoords.Location = new System.Drawing.Point(22, 270);
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
            this.box_alwaysInFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_alwaysInFront.Location = new System.Drawing.Point(7, 365);
            this.box_alwaysInFront.Name = "box_alwaysInFront";
            this.box_alwaysInFront.Size = new System.Drawing.Size(56, 17);
            this.box_alwaysInFront.TabIndex = 14;
            this.box_alwaysInFront.Text = "OnTop";
            this.box_alwaysInFront.UseVisualStyleBackColor = true;
            this.box_alwaysInFront.CheckedChanged += new System.EventHandler(this.box_alwaysInFront_CheckedChanged);
            // 
            // box_camAttach
            // 
            this.box_camAttach.AutoSize = true;
            this.box_camAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_camAttach.Location = new System.Drawing.Point(9, 98);
            this.box_camAttach.Name = "box_camAttach";
            this.box_camAttach.Size = new System.Drawing.Size(88, 17);
            this.box_camAttach.TabIndex = 13;
            this.box_camAttach.Text = "AttachToCam";
            this.box_camAttach.UseVisualStyleBackColor = true;
            this.box_camAttach.CheckedChanged += new System.EventHandler(this.box_camAttach_CheckedChanged);
            // 
            // box_nofall
            // 
            this.box_nofall.AutoSize = true;
            this.box_nofall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_nofall.Location = new System.Drawing.Point(9, 121);
            this.box_nofall.Name = "box_nofall";
            this.box_nofall.Size = new System.Drawing.Size(94, 17);
            this.box_nofall.TabIndex = 12;
            this.box_nofall.Text = "No Falldamage";
            this.box_nofall.UseVisualStyleBackColor = true;
            this.box_nofall.CheckedChanged += new System.EventHandler(this.box_nofall_CheckedChanged);
            // 
            // btn_tpToCam
            // 
            this.btn_tpToCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tpToCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.box_Freecam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_Freecam.Location = new System.Drawing.Point(9, 78);
            this.box_Freecam.Name = "box_Freecam";
            this.box_Freecam.Size = new System.Drawing.Size(64, 17);
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
            this.btn_clearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btn_teleport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btn_saveLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.cbox_noclip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_noclip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_noclip.ForeColor = System.Drawing.Color.Red;
            this.cbox_noclip.Location = new System.Drawing.Point(9, 50);
            this.cbox_noclip.Name = "cbox_noclip";
            this.cbox_noclip.Size = new System.Drawing.Size(103, 17);
            this.cbox_noclip.TabIndex = 2;
            this.cbox_noclip.Text = "Master-Switch";
            this.cbox_noclip.UseVisualStyleBackColor = true;
            this.cbox_noclip.CheckedChanged += new System.EventHandler(this.cbox_noclip_CheckedChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_speedKey);
            this.panel1.Controls.Add(this.lbl_customHks);
            this.panel1.Controls.Add(this.txtbox_speedKey);
            this.panel1.Controls.Add(this.lbl_glideKey);
            this.panel1.Controls.Add(this.txtbox_glideKey);
            this.panel1.Controls.Add(this.lbl_TpToCamKey);
            this.panel1.Controls.Add(this.txtbox_tpToCamKey);
            this.panel1.Controls.Add(this.lbl_nofallKey);
            this.panel1.Controls.Add(this.txtbox_nofallKey);
            this.panel1.Controls.Add(this.lbl_freecamKey);
            this.panel1.Controls.Add(this.txtbox_freecamKey);
            this.panel1.Controls.Add(this.lbl_tpBackw);
            this.panel1.Controls.Add(this.txtbox_TPBackwardKey);
            this.panel1.Controls.Add(this.lbl_tpForward);
            this.panel1.Controls.Add(this.txtbox_TPForwardKey);
            this.panel1.Controls.Add(this.lbl_tpRight);
            this.panel1.Controls.Add(this.txtbox_TPRightKey);
            this.panel1.Controls.Add(this.lbl_tpLeft);
            this.panel1.Controls.Add(this.txtbox_TPLeftKey);
            this.panel1.Controls.Add(this.lbl_tpDown);
            this.panel1.Controls.Add(this.txtbox_TPDowNkey);
            this.panel1.Controls.Add(this.lbl_tpUp);
            this.panel1.Controls.Add(this.txtbox_TPUpKey);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(105, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 197);
            this.panel1.TabIndex = 53;
            // 
            // lbl_speedKey
            // 
            this.lbl_speedKey.AutoSize = true;
            this.lbl_speedKey.Location = new System.Drawing.Point(145, 138);
            this.lbl_speedKey.Name = "lbl_speedKey";
            this.lbl_speedKey.Size = new System.Drawing.Size(41, 13);
            this.lbl_speedKey.TabIndex = 51;
            this.lbl_speedKey.Text = "Speed:";
            // 
            // lbl_customHks
            // 
            this.lbl_customHks.AutoSize = true;
            this.lbl_customHks.Location = new System.Drawing.Point(3, 9);
            this.lbl_customHks.Name = "lbl_customHks";
            this.lbl_customHks.Size = new System.Drawing.Size(87, 13);
            this.lbl_customHks.TabIndex = 52;
            this.lbl_customHks.Text = "Custom Hotkeys:";
            // 
            // txtbox_speedKey
            // 
            this.txtbox_speedKey.Location = new System.Drawing.Point(202, 135);
            this.txtbox_speedKey.Name = "txtbox_speedKey";
            this.txtbox_speedKey.ReadOnly = true;
            this.txtbox_speedKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_speedKey.TabIndex = 50;
            this.txtbox_speedKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_speedKey_KeyDown);
            // 
            // lbl_glideKey
            // 
            this.lbl_glideKey.AutoSize = true;
            this.lbl_glideKey.Location = new System.Drawing.Point(159, 116);
            this.lbl_glideKey.Name = "lbl_glideKey";
            this.lbl_glideKey.Size = new System.Drawing.Size(34, 13);
            this.lbl_glideKey.TabIndex = 49;
            this.lbl_glideKey.Text = "Glide:";
            // 
            // txtbox_glideKey
            // 
            this.txtbox_glideKey.Location = new System.Drawing.Point(202, 113);
            this.txtbox_glideKey.Name = "txtbox_glideKey";
            this.txtbox_glideKey.ReadOnly = true;
            this.txtbox_glideKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_glideKey.TabIndex = 48;
            this.txtbox_glideKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_glideKey_KeyDown);
            // 
            // lbl_TpToCamKey
            // 
            this.lbl_TpToCamKey.AutoSize = true;
            this.lbl_TpToCamKey.Location = new System.Drawing.Point(136, 64);
            this.lbl_TpToCamKey.Name = "lbl_TpToCamKey";
            this.lbl_TpToCamKey.Size = new System.Drawing.Size(60, 13);
            this.lbl_TpToCamKey.TabIndex = 47;
            this.lbl_TpToCamKey.Text = "TP to Cam:";
            // 
            // txtbox_tpToCamKey
            // 
            this.txtbox_tpToCamKey.Location = new System.Drawing.Point(202, 61);
            this.txtbox_tpToCamKey.Name = "txtbox_tpToCamKey";
            this.txtbox_tpToCamKey.ReadOnly = true;
            this.txtbox_tpToCamKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_tpToCamKey.TabIndex = 46;
            this.txtbox_tpToCamKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_tpToCamKey_KeyDown);
            // 
            // lbl_nofallKey
            // 
            this.lbl_nofallKey.AutoSize = true;
            this.lbl_nofallKey.Location = new System.Drawing.Point(159, 90);
            this.lbl_nofallKey.Name = "lbl_nofallKey";
            this.lbl_nofallKey.Size = new System.Drawing.Size(37, 13);
            this.lbl_nofallKey.TabIndex = 45;
            this.lbl_nofallKey.Text = "Nofall:";
            // 
            // txtbox_nofallKey
            // 
            this.txtbox_nofallKey.Location = new System.Drawing.Point(202, 87);
            this.txtbox_nofallKey.Name = "txtbox_nofallKey";
            this.txtbox_nofallKey.ReadOnly = true;
            this.txtbox_nofallKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_nofallKey.TabIndex = 44;
            this.txtbox_nofallKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_nofallKey_KeyDown);
            // 
            // lbl_freecamKey
            // 
            this.lbl_freecamKey.AutoSize = true;
            this.lbl_freecamKey.Location = new System.Drawing.Point(145, 38);
            this.lbl_freecamKey.Name = "lbl_freecamKey";
            this.lbl_freecamKey.Size = new System.Drawing.Size(51, 13);
            this.lbl_freecamKey.TabIndex = 43;
            this.lbl_freecamKey.Text = "Freecam:";
            // 
            // txtbox_freecamKey
            // 
            this.txtbox_freecamKey.Location = new System.Drawing.Point(202, 35);
            this.txtbox_freecamKey.Name = "txtbox_freecamKey";
            this.txtbox_freecamKey.ReadOnly = true;
            this.txtbox_freecamKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_freecamKey.TabIndex = 42;
            this.txtbox_freecamKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_freecamKey_KeyDown);
            // 
            // lbl_tpBackw
            // 
            this.lbl_tpBackw.AutoSize = true;
            this.lbl_tpBackw.Location = new System.Drawing.Point(3, 168);
            this.lbl_tpBackw.Name = "lbl_tpBackw";
            this.lbl_tpBackw.Size = new System.Drawing.Size(80, 13);
            this.lbl_tpBackw.TabIndex = 41;
            this.lbl_tpBackw.Text = "TP Backwards:";
            // 
            // txtbox_TPBackwardKey
            // 
            this.txtbox_TPBackwardKey.Location = new System.Drawing.Point(86, 165);
            this.txtbox_TPBackwardKey.Name = "txtbox_TPBackwardKey";
            this.txtbox_TPBackwardKey.ReadOnly = true;
            this.txtbox_TPBackwardKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_TPBackwardKey.TabIndex = 40;
            this.txtbox_TPBackwardKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_TPBackwardKey_KeyDown);
            // 
            // lbl_tpForward
            // 
            this.lbl_tpForward.AutoSize = true;
            this.lbl_tpForward.Location = new System.Drawing.Point(18, 142);
            this.lbl_tpForward.Name = "lbl_tpForward";
            this.lbl_tpForward.Size = new System.Drawing.Size(65, 13);
            this.lbl_tpForward.TabIndex = 39;
            this.lbl_tpForward.Text = "TP Forward:";
            // 
            // txtbox_TPForwardKey
            // 
            this.txtbox_TPForwardKey.Location = new System.Drawing.Point(86, 139);
            this.txtbox_TPForwardKey.Name = "txtbox_TPForwardKey";
            this.txtbox_TPForwardKey.ReadOnly = true;
            this.txtbox_TPForwardKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_TPForwardKey.TabIndex = 38;
            this.txtbox_TPForwardKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_TPForwardKey_KeyDown);
            // 
            // lbl_tpRight
            // 
            this.lbl_tpRight.AutoSize = true;
            this.lbl_tpRight.Location = new System.Drawing.Point(28, 116);
            this.lbl_tpRight.Name = "lbl_tpRight";
            this.lbl_tpRight.Size = new System.Drawing.Size(55, 13);
            this.lbl_tpRight.TabIndex = 37;
            this.lbl_tpRight.Text = "TP Right: ";
            // 
            // txtbox_TPRightKey
            // 
            this.txtbox_TPRightKey.Location = new System.Drawing.Point(86, 113);
            this.txtbox_TPRightKey.Name = "txtbox_TPRightKey";
            this.txtbox_TPRightKey.ReadOnly = true;
            this.txtbox_TPRightKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_TPRightKey.TabIndex = 36;
            this.txtbox_TPRightKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_TPRightKey_KeyDown);
            // 
            // lbl_tpLeft
            // 
            this.lbl_tpLeft.AutoSize = true;
            this.lbl_tpLeft.Location = new System.Drawing.Point(35, 90);
            this.lbl_tpLeft.Name = "lbl_tpLeft";
            this.lbl_tpLeft.Size = new System.Drawing.Size(45, 13);
            this.lbl_tpLeft.TabIndex = 35;
            this.lbl_tpLeft.Text = "TP Left:";
            // 
            // txtbox_TPLeftKey
            // 
            this.txtbox_TPLeftKey.Location = new System.Drawing.Point(86, 87);
            this.txtbox_TPLeftKey.Name = "txtbox_TPLeftKey";
            this.txtbox_TPLeftKey.ReadOnly = true;
            this.txtbox_TPLeftKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_TPLeftKey.TabIndex = 34;
            this.txtbox_TPLeftKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_TPLeftKey_KeyDown);
            // 
            // lbl_tpDown
            // 
            this.lbl_tpDown.AutoSize = true;
            this.lbl_tpDown.Location = new System.Drawing.Point(25, 64);
            this.lbl_tpDown.Name = "lbl_tpDown";
            this.lbl_tpDown.Size = new System.Drawing.Size(55, 13);
            this.lbl_tpDown.TabIndex = 33;
            this.lbl_tpDown.Text = "TP Down:";
            // 
            // txtbox_TPDowNkey
            // 
            this.txtbox_TPDowNkey.Location = new System.Drawing.Point(86, 61);
            this.txtbox_TPDowNkey.Name = "txtbox_TPDowNkey";
            this.txtbox_TPDowNkey.ReadOnly = true;
            this.txtbox_TPDowNkey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_TPDowNkey.TabIndex = 32;
            this.txtbox_TPDowNkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_TPDowNkey_KeyDown);
            // 
            // lbl_tpUp
            // 
            this.lbl_tpUp.AutoSize = true;
            this.lbl_tpUp.Location = new System.Drawing.Point(39, 38);
            this.lbl_tpUp.Name = "lbl_tpUp";
            this.lbl_tpUp.Size = new System.Drawing.Size(41, 13);
            this.lbl_tpUp.TabIndex = 31;
            this.lbl_tpUp.Text = "TP Up:";
            // 
            // txtbox_TPUpKey
            // 
            this.txtbox_TPUpKey.Location = new System.Drawing.Point(86, 35);
            this.txtbox_TPUpKey.Name = "txtbox_TPUpKey";
            this.txtbox_TPUpKey.ReadOnly = true;
            this.txtbox_TPUpKey.Size = new System.Drawing.Size(52, 20);
            this.txtbox_TPUpKey.TabIndex = 30;
            this.txtbox_TPUpKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_TpUpHotkey_KeyDown);
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
            this.box_dotEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_dotEsp.Location = new System.Drawing.Point(7, 61);
            this.box_dotEsp.Name = "box_dotEsp";
            this.box_dotEsp.Size = new System.Drawing.Size(104, 17);
            this.box_dotEsp.TabIndex = 25;
            this.box_dotEsp.Text = "Velocity Indicator";
            this.box_dotEsp.UseVisualStyleBackColor = true;
            this.box_dotEsp.CheckedChanged += new System.EventHandler(this.box_dotEsp_CheckedChanged);
            // 
            // box_esp
            // 
            this.box_esp.AutoSize = true;
            this.box_esp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_esp.Location = new System.Drawing.Point(7, 38);
            this.box_esp.Name = "box_esp";
            this.box_esp.Size = new System.Drawing.Size(78, 17);
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
            // tab_Scripts
            // 
            this.tab_Scripts.Controls.Add(this.btn_loadScript);
            this.tab_Scripts.Controls.Add(this.btn_saveScript);
            this.tab_Scripts.Controls.Add(this.btn_showVars);
            this.tab_Scripts.Controls.Add(this.btn_example);
            this.tab_Scripts.Controls.Add(this.btn_runScript);
            this.tab_Scripts.Controls.Add(this.txtbox_script);
            this.tab_Scripts.ImageIndex = 0;
            this.tab_Scripts.Location = new System.Drawing.Point(4, 23);
            this.tab_Scripts.Name = "tab_Scripts";
            this.tab_Scripts.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Scripts.Size = new System.Drawing.Size(368, 384);
            this.tab_Scripts.TabIndex = 3;
            this.tab_Scripts.Text = "Scripts";
            this.tab_Scripts.UseVisualStyleBackColor = true;
            // 
            // btn_loadScript
            // 
            this.btn_loadScript.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_loadScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadScript.Location = new System.Drawing.Point(313, 358);
            this.btn_loadScript.Name = "btn_loadScript";
            this.btn_loadScript.Size = new System.Drawing.Size(52, 23);
            this.btn_loadScript.TabIndex = 5;
            this.btn_loadScript.Text = "Load";
            this.btn_loadScript.UseVisualStyleBackColor = true;
            // 
            // btn_saveScript
            // 
            this.btn_saveScript.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_saveScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveScript.Location = new System.Drawing.Point(259, 358);
            this.btn_saveScript.Name = "btn_saveScript";
            this.btn_saveScript.Size = new System.Drawing.Size(52, 23);
            this.btn_saveScript.TabIndex = 4;
            this.btn_saveScript.Text = "Save";
            this.btn_saveScript.UseVisualStyleBackColor = true;
            // 
            // btn_showVars
            // 
            this.btn_showVars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showVars.Location = new System.Drawing.Point(100, 355);
            this.btn_showVars.Name = "btn_showVars";
            this.btn_showVars.Size = new System.Drawing.Size(38, 23);
            this.btn_showVars.TabIndex = 3;
            this.btn_showVars.Text = "Vars";
            this.btn_showVars.UseVisualStyleBackColor = true;
            this.btn_showVars.Click += new System.EventHandler(this.btn_showVars_Click);
            // 
            // btn_example
            // 
            this.btn_example.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_example.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_example.Location = new System.Drawing.Point(6, 355);
            this.btn_example.Name = "btn_example";
            this.btn_example.Size = new System.Drawing.Size(88, 23);
            this.btn_example.TabIndex = 2;
            this.btn_example.Text = "Example Code";
            this.btn_example.UseVisualStyleBackColor = true;
            this.btn_example.Click += new System.EventHandler(this.btn_example_Click);
            // 
            // btn_runScript
            // 
            this.btn_runScript.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_runScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_runScript.Location = new System.Drawing.Point(144, 338);
            this.btn_runScript.Name = "btn_runScript";
            this.btn_runScript.Size = new System.Drawing.Size(75, 23);
            this.btn_runScript.TabIndex = 1;
            this.btn_runScript.Text = "Execute";
            this.btn_runScript.UseVisualStyleBackColor = true;
            this.btn_runScript.Click += new System.EventHandler(this.btn_runScript_Click);
            // 
            // txtbox_script
            // 
            this.txtbox_script.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_script.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_script.Location = new System.Drawing.Point(6, 6);
            this.txtbox_script.Multiline = true;
            this.txtbox_script.Name = "txtbox_script";
            this.txtbox_script.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_script.Size = new System.Drawing.Size(356, 326);
            this.txtbox_script.TabIndex = 0;
            this.txtbox_script.Text = "MessageBox.Show(\"Hello World\");";
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
            // timer_getBase
            // 
            this.timer_getBase.Interval = 500;
            this.timer_getBase.Tick += new System.EventHandler(this.timer_getBase_Tick);
            // 
            // box_darkmode
            // 
            this.box_darkmode.AutoSize = true;
            this.box_darkmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_darkmode.Location = new System.Drawing.Point(7, 350);
            this.box_darkmode.Name = "box_darkmode";
            this.box_darkmode.Size = new System.Drawing.Size(72, 17);
            this.box_darkmode.TabIndex = 29;
            this.box_darkmode.Text = "Darkmode";
            this.box_darkmode.UseVisualStyleBackColor = true;
            this.box_darkmode.CheckedChanged += new System.EventHandler(this.box_darkMode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 438);
            this.Controls.Add(this.tab_List);
            this.Controls.Add(this.lbl_title);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.Text = "swtool";
            this.tab_List.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbr_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trck_opcacity)).EndInit();
            this.tab_Scripts.ResumeLayout(false);
            this.tab_Scripts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.TabControl tab_List;
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
        private System.Windows.Forms.Button btn_cancelTP;
        private System.Windows.Forms.TrackBar trckbr_speed;
        private System.Windows.Forms.Label lbl_Speed;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer_getBase;
        private System.Windows.Forms.CheckBox box_esp;
        private System.Windows.Forms.CheckBox box_dotEsp;
        private System.Windows.Forms.Label lbl_CusCoord;
        private System.Windows.Forms.Label lbl_HeightNormal;
        private System.Windows.Forms.TextBox box_playerHeight;
        private System.Windows.Forms.CheckBox box_glide;
        private System.Windows.Forms.Label lbl_opacity;
        private System.Windows.Forms.TrackBar trck_opcacity;
        private System.Windows.Forms.CheckBox box_speedhack;
        private System.Windows.Forms.TextBox txtbox_TPUpKey;
        private System.Windows.Forms.Label lbl_tpBackw;
        private System.Windows.Forms.TextBox txtbox_TPBackwardKey;
        private System.Windows.Forms.Label lbl_tpForward;
        private System.Windows.Forms.TextBox txtbox_TPForwardKey;
        private System.Windows.Forms.Label lbl_tpRight;
        private System.Windows.Forms.TextBox txtbox_TPRightKey;
        private System.Windows.Forms.Label lbl_tpLeft;
        private System.Windows.Forms.TextBox txtbox_TPLeftKey;
        private System.Windows.Forms.Label lbl_tpDown;
        private System.Windows.Forms.TextBox txtbox_TPDowNkey;
        private System.Windows.Forms.Label lbl_tpUp;
        private System.Windows.Forms.Label lbl_glideKey;
        private System.Windows.Forms.TextBox txtbox_glideKey;
        private System.Windows.Forms.Label lbl_TpToCamKey;
        private System.Windows.Forms.TextBox txtbox_tpToCamKey;
        private System.Windows.Forms.Label lbl_nofallKey;
        private System.Windows.Forms.TextBox txtbox_nofallKey;
        private System.Windows.Forms.Label lbl_freecamKey;
        private System.Windows.Forms.TextBox txtbox_freecamKey;
        private System.Windows.Forms.Label lbl_speedKey;
        private System.Windows.Forms.TextBox txtbox_speedKey;
        private System.Windows.Forms.Label lbl_customHks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tab_Scripts;
        private System.Windows.Forms.Button btn_runScript;
        private System.Windows.Forms.TextBox txtbox_script;
        private System.Windows.Forms.Button btn_example;
        private System.Windows.Forms.Button btn_showVars;
        private System.Windows.Forms.Button btn_loadScript;
        private System.Windows.Forms.Button btn_saveScript;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.CheckBox box_darkmode;
    }
}

