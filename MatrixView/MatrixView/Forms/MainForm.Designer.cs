
namespace MatrixView.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.plLeft = new System.Windows.Forms.Panel();
            this.lblHideFromStream = new System.Windows.Forms.Label();
            this.cbStreamproof = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.pbLevelProgress = new Siticone.UI.WinForms.SiticoneProgressBar();
            this.tbUsernameReadonly = new Siticone.UI.WinForms.SiticoneTextBox();
            this.pbPlayerIcon = new Siticone.UI.WinForms.SiticonePictureBox();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSkinBoost = new Siticone.UI.WinForms.SiticoneGradientTileButton();
            this.btnChangeProfileIcon = new Siticone.UI.WinForms.SiticoneGradientTileButton();
            this.btnPratice5v5 = new Siticone.UI.WinForms.SiticoneGradientTileButton();
            this.btnAutoAccept = new Siticone.UI.WinForms.SiticoneGradientTileButton();
            this.btnAppearChangeStatus = new Siticone.UI.WinForms.SiticoneGradientTileButton();
            this.btnAutoSkinBoost = new Siticone.UI.WinForms.SiticoneGradientTileButton();
            this.btnLobbyCrash = new Siticone.UI.WinForms.SiticoneGradientTileButton();
            this.btnCreateClashLobby = new Siticone.UI.WinForms.SiticoneGradientTileButton();
            this.btnFreeContent = new Siticone.UI.WinForms.SiticoneGradientTileButton();
            this.plFlowholder = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.plLeftBorder = new System.Windows.Forms.PictureBox();
            this.plTop = new System.Windows.Forms.Panel();
            this.btnMinimaze = new Siticone.UI.WinForms.SiticoneControlBox();
            this.btnClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.tbTitle = new Siticone.UI.WinForms.SiticoneTextBox();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.FadeShow = new System.Windows.Forms.Timer(this.components);
            this.FadeHide = new System.Windows.Forms.Timer(this.components);
            this.plLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerIcon)).BeginInit();
            this.flpItems.SuspendLayout();
            this.plFlowholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plLeftBorder)).BeginInit();
            this.plTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // plLeft
            // 
            this.plLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.plLeft.Controls.Add(this.lblHideFromStream);
            this.plLeft.Controls.Add(this.cbStreamproof);
            this.plLeft.Controls.Add(this.pbLevelProgress);
            this.plLeft.Controls.Add(this.tbUsernameReadonly);
            this.plLeft.Controls.Add(this.pbPlayerIcon);
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.plLeft.Location = new System.Drawing.Point(596, 0);
            this.plLeft.Name = "plLeft";
            this.plLeft.Size = new System.Drawing.Size(272, 432);
            this.plLeft.TabIndex = 7;
            // 
            // lblHideFromStream
            // 
            this.lblHideFromStream.AutoSize = true;
            this.lblHideFromStream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblHideFromStream.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHideFromStream.ForeColor = System.Drawing.Color.White;
            this.lblHideFromStream.Location = new System.Drawing.Point(76, 400);
            this.lblHideFromStream.Name = "lblHideFromStream";
            this.lblHideFromStream.Size = new System.Drawing.Size(145, 15);
            this.lblHideFromStream.TabIndex = 16;
            this.lblHideFromStream.Text = "Hide window from stream";
            // 
            // cbStreamproof
            // 
            this.cbStreamproof.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.cbStreamproof.CheckedState.BorderRadius = 2;
            this.cbStreamproof.CheckedState.BorderThickness = 1;
            this.cbStreamproof.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.cbStreamproof.CheckedState.Parent = this.cbStreamproof;
            this.cbStreamproof.Location = new System.Drawing.Point(53, 397);
            this.cbStreamproof.Name = "cbStreamproof";
            this.cbStreamproof.ShadowDecoration.Parent = this.cbStreamproof;
            this.cbStreamproof.Size = new System.Drawing.Size(20, 20);
            this.cbStreamproof.TabIndex = 15;
            this.cbStreamproof.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(134)))), ((int)(((byte)(50)))));
            this.cbStreamproof.UncheckedState.BorderRadius = 2;
            this.cbStreamproof.UncheckedState.BorderThickness = 1;
            this.cbStreamproof.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(134)))), ((int)(((byte)(50)))));
            this.cbStreamproof.UncheckedState.Parent = this.cbStreamproof;
            this.cbStreamproof.CheckedChanged += new System.EventHandler(this.cbStreamproof_CheckedChanged);
            // 
            // pbLevelProgress
            // 
            this.pbLevelProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(194)))), ((int)(((byte)(111)))));
            this.pbLevelProgress.BorderRadius = 13;
            this.pbLevelProgress.BorderThickness = 2;
            this.pbLevelProgress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pbLevelProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pbLevelProgress.Location = new System.Drawing.Point(8, 300);
            this.pbLevelProgress.Name = "pbLevelProgress";
            this.pbLevelProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.pbLevelProgress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(194)))), ((int)(((byte)(111)))));
            this.pbLevelProgress.ShadowDecoration.Parent = this.pbLevelProgress;
            this.pbLevelProgress.Size = new System.Drawing.Size(256, 30);
            this.pbLevelProgress.TabIndex = 14;
            this.pbLevelProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // tbUsernameReadonly
            // 
            this.tbUsernameReadonly.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbUsernameReadonly.BorderThickness = 0;
            this.tbUsernameReadonly.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsernameReadonly.DefaultText = "MATRIX_USER";
            this.tbUsernameReadonly.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbUsernameReadonly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbUsernameReadonly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tbUsernameReadonly.DisabledState.Parent = this.tbUsernameReadonly;
            this.tbUsernameReadonly.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tbUsernameReadonly.Enabled = false;
            this.tbUsernameReadonly.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbUsernameReadonly.FocusedState.Parent = this.tbUsernameReadonly;
            this.tbUsernameReadonly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tbUsernameReadonly.HoveredState.Parent = this.tbUsernameReadonly;
            this.tbUsernameReadonly.Location = new System.Drawing.Point(8, 264);
            this.tbUsernameReadonly.Name = "tbUsernameReadonly";
            this.tbUsernameReadonly.PasswordChar = '\0';
            this.tbUsernameReadonly.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tbUsernameReadonly.PlaceholderText = "";
            this.tbUsernameReadonly.ReadOnly = true;
            this.tbUsernameReadonly.SelectedText = "";
            this.tbUsernameReadonly.ShadowDecoration.Parent = this.tbUsernameReadonly;
            this.tbUsernameReadonly.Size = new System.Drawing.Size(256, 30);
            this.tbUsernameReadonly.TabIndex = 13;
            this.tbUsernameReadonly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbPlayerIcon
            // 
            this.pbPlayerIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pbPlayerIcon.Location = new System.Drawing.Point(8, 8);
            this.pbPlayerIcon.Name = "pbPlayerIcon";
            this.pbPlayerIcon.ShadowDecoration.Parent = this.pbPlayerIcon;
            this.pbPlayerIcon.Size = new System.Drawing.Size(256, 256);
            this.pbPlayerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerIcon.TabIndex = 11;
            this.pbPlayerIcon.TabStop = false;
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.Controls.Add(this.btnSkinBoost);
            this.flpItems.Controls.Add(this.btnChangeProfileIcon);
            this.flpItems.Controls.Add(this.btnPratice5v5);
            this.flpItems.Controls.Add(this.btnAutoAccept);
            this.flpItems.Controls.Add(this.btnAppearChangeStatus);
            this.flpItems.Controls.Add(this.btnAutoSkinBoost);
            this.flpItems.Controls.Add(this.btnLobbyCrash);
            this.flpItems.Controls.Add(this.btnCreateClashLobby);
            this.flpItems.Controls.Add(this.btnFreeContent);
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItems.Location = new System.Drawing.Point(0, 0);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(570, 381);
            this.flpItems.TabIndex = 10;
            // 
            // btnSkinBoost
            // 
            this.btnSkinBoost.BackColor = System.Drawing.Color.Transparent;
            this.btnSkinBoost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSkinBoost.BackgroundImage")));
            this.btnSkinBoost.CheckedState.Parent = this.btnSkinBoost;
            this.btnSkinBoost.CustomImages.Parent = this.btnSkinBoost;
            this.btnSkinBoost.FillColor = System.Drawing.Color.Transparent;
            this.btnSkinBoost.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSkinBoost.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSkinBoost.ForeColor = System.Drawing.Color.White;
            this.btnSkinBoost.HoveredState.Parent = this.btnSkinBoost;
            this.btnSkinBoost.Image = ((System.Drawing.Image)(resources.GetObject("btnSkinBoost.Image")));
            this.btnSkinBoost.ImageOffset = new System.Drawing.Point(0, 40);
            this.btnSkinBoost.ImageSize = new System.Drawing.Size(125, 125);
            this.btnSkinBoost.Location = new System.Drawing.Point(5, 5);
            this.btnSkinBoost.Margin = new System.Windows.Forms.Padding(5);
            this.btnSkinBoost.Name = "btnSkinBoost";
            this.btnSkinBoost.ShadowDecoration.Depth = 5;
            this.btnSkinBoost.ShadowDecoration.Enabled = true;
            this.btnSkinBoost.ShadowDecoration.Parent = this.btnSkinBoost;
            this.btnSkinBoost.Size = new System.Drawing.Size(180, 180);
            this.btnSkinBoost.TabIndex = 12;
            this.btnSkinBoost.Text = "Do Skin Boost";
            this.btnSkinBoost.TextOffset = new System.Drawing.Point(0, 25);
            this.btnSkinBoost.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnSkinBoost.UseTransparentBackground = true;
            this.btnSkinBoost.Click += new System.EventHandler(this.btnSkinBoost_Click);
            // 
            // btnChangeProfileIcon
            // 
            this.btnChangeProfileIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeProfileIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeProfileIcon.BackgroundImage")));
            this.btnChangeProfileIcon.CheckedState.Parent = this.btnChangeProfileIcon;
            this.btnChangeProfileIcon.CustomImages.Parent = this.btnChangeProfileIcon;
            this.btnChangeProfileIcon.FillColor = System.Drawing.Color.Transparent;
            this.btnChangeProfileIcon.FillColor2 = System.Drawing.Color.Transparent;
            this.btnChangeProfileIcon.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeProfileIcon.ForeColor = System.Drawing.Color.White;
            this.btnChangeProfileIcon.HoveredState.Parent = this.btnChangeProfileIcon;
            this.btnChangeProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeProfileIcon.Image")));
            this.btnChangeProfileIcon.ImageOffset = new System.Drawing.Point(0, 50);
            this.btnChangeProfileIcon.ImageSize = new System.Drawing.Size(170, 170);
            this.btnChangeProfileIcon.Location = new System.Drawing.Point(195, 5);
            this.btnChangeProfileIcon.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangeProfileIcon.Name = "btnChangeProfileIcon";
            this.btnChangeProfileIcon.ShadowDecoration.Depth = 5;
            this.btnChangeProfileIcon.ShadowDecoration.Enabled = true;
            this.btnChangeProfileIcon.ShadowDecoration.Parent = this.btnChangeProfileIcon;
            this.btnChangeProfileIcon.Size = new System.Drawing.Size(180, 180);
            this.btnChangeProfileIcon.TabIndex = 14;
            this.btnChangeProfileIcon.Text = "Change Profile Icon";
            this.btnChangeProfileIcon.TextOffset = new System.Drawing.Point(0, 10);
            this.btnChangeProfileIcon.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnChangeProfileIcon.UseTransparentBackground = true;
            this.btnChangeProfileIcon.Click += new System.EventHandler(this.btnChangeProfileIcon_Click);
            // 
            // btnPratice5v5
            // 
            this.btnPratice5v5.BackColor = System.Drawing.Color.Transparent;
            this.btnPratice5v5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPratice5v5.BackgroundImage")));
            this.btnPratice5v5.CheckedState.Parent = this.btnPratice5v5;
            this.btnPratice5v5.CustomImages.Parent = this.btnPratice5v5;
            this.btnPratice5v5.FillColor = System.Drawing.Color.Transparent;
            this.btnPratice5v5.FillColor2 = System.Drawing.Color.Transparent;
            this.btnPratice5v5.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPratice5v5.ForeColor = System.Drawing.Color.White;
            this.btnPratice5v5.HoveredState.Parent = this.btnPratice5v5;
            this.btnPratice5v5.Image = ((System.Drawing.Image)(resources.GetObject("btnPratice5v5.Image")));
            this.btnPratice5v5.ImageOffset = new System.Drawing.Point(0, 40);
            this.btnPratice5v5.ImageSize = new System.Drawing.Size(125, 125);
            this.btnPratice5v5.Location = new System.Drawing.Point(385, 5);
            this.btnPratice5v5.Margin = new System.Windows.Forms.Padding(5);
            this.btnPratice5v5.Name = "btnPratice5v5";
            this.btnPratice5v5.ShadowDecoration.Depth = 5;
            this.btnPratice5v5.ShadowDecoration.Enabled = true;
            this.btnPratice5v5.ShadowDecoration.Parent = this.btnPratice5v5;
            this.btnPratice5v5.Size = new System.Drawing.Size(180, 180);
            this.btnPratice5v5.TabIndex = 18;
            this.btnPratice5v5.Text = "5v5 Practice with Bots";
            this.btnPratice5v5.TextOffset = new System.Drawing.Point(0, 25);
            this.btnPratice5v5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnPratice5v5.UseTransparentBackground = true;
            this.btnPratice5v5.Click += new System.EventHandler(this.btnPratice5v5_Click);
            // 
            // btnAutoAccept
            // 
            this.btnAutoAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoAccept.BackgroundImage")));
            this.btnAutoAccept.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAutoAccept.CheckedState.Parent = this.btnAutoAccept;
            this.btnAutoAccept.CustomImages.Parent = this.btnAutoAccept;
            this.btnAutoAccept.FillColor = System.Drawing.Color.Transparent;
            this.btnAutoAccept.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAutoAccept.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAutoAccept.ForeColor = System.Drawing.Color.White;
            this.btnAutoAccept.HoveredState.Parent = this.btnAutoAccept;
            this.btnAutoAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoAccept.Image")));
            this.btnAutoAccept.ImageOffset = new System.Drawing.Point(0, 50);
            this.btnAutoAccept.ImageSize = new System.Drawing.Size(145, 145);
            this.btnAutoAccept.Location = new System.Drawing.Point(5, 195);
            this.btnAutoAccept.Margin = new System.Windows.Forms.Padding(5);
            this.btnAutoAccept.Name = "btnAutoAccept";
            this.btnAutoAccept.ShadowDecoration.Depth = 5;
            this.btnAutoAccept.ShadowDecoration.Enabled = true;
            this.btnAutoAccept.ShadowDecoration.Parent = this.btnAutoAccept;
            this.btnAutoAccept.Size = new System.Drawing.Size(180, 180);
            this.btnAutoAccept.TabIndex = 19;
            this.btnAutoAccept.Text = "Auto Accept";
            this.btnAutoAccept.TextOffset = new System.Drawing.Point(0, 20);
            this.btnAutoAccept.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAutoAccept.UseTransparentBackground = true;
            // 
            // btnAppearChangeStatus
            // 
            this.btnAppearChangeStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnAppearChangeStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppearChangeStatus.BackgroundImage")));
            this.btnAppearChangeStatus.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAppearChangeStatus.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAppearChangeStatus.CheckedState.Parent = this.btnAppearChangeStatus;
            this.btnAppearChangeStatus.CustomImages.Parent = this.btnAppearChangeStatus;
            this.btnAppearChangeStatus.FillColor = System.Drawing.Color.Transparent;
            this.btnAppearChangeStatus.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAppearChangeStatus.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAppearChangeStatus.ForeColor = System.Drawing.Color.White;
            this.btnAppearChangeStatus.HoveredState.Parent = this.btnAppearChangeStatus;
            this.btnAppearChangeStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnAppearChangeStatus.Image")));
            this.btnAppearChangeStatus.ImageOffset = new System.Drawing.Point(0, 40);
            this.btnAppearChangeStatus.ImageSize = new System.Drawing.Size(127, 127);
            this.btnAppearChangeStatus.Location = new System.Drawing.Point(195, 195);
            this.btnAppearChangeStatus.Margin = new System.Windows.Forms.Padding(5);
            this.btnAppearChangeStatus.Name = "btnAppearChangeStatus";
            this.btnAppearChangeStatus.ShadowDecoration.Depth = 5;
            this.btnAppearChangeStatus.ShadowDecoration.Enabled = true;
            this.btnAppearChangeStatus.ShadowDecoration.Parent = this.btnAppearChangeStatus;
            this.btnAppearChangeStatus.Size = new System.Drawing.Size(180, 180);
            this.btnAppearChangeStatus.TabIndex = 21;
            this.btnAppearChangeStatus.Text = "Appear as Offline";
            this.btnAppearChangeStatus.TextOffset = new System.Drawing.Point(0, 25);
            this.btnAppearChangeStatus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAppearChangeStatus.UseTransparentBackground = true;
            this.btnAppearChangeStatus.Click += new System.EventHandler(this.btnAppearChangeStatus_Click);
            // 
            // btnAutoSkinBoost
            // 
            this.btnAutoSkinBoost.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoSkinBoost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoSkinBoost.BackgroundImage")));
            this.btnAutoSkinBoost.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAutoSkinBoost.CheckedState.Parent = this.btnAutoSkinBoost;
            this.btnAutoSkinBoost.CustomImages.Parent = this.btnAutoSkinBoost;
            this.btnAutoSkinBoost.FillColor = System.Drawing.Color.Transparent;
            this.btnAutoSkinBoost.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAutoSkinBoost.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAutoSkinBoost.ForeColor = System.Drawing.Color.White;
            this.btnAutoSkinBoost.HoveredState.Parent = this.btnAutoSkinBoost;
            this.btnAutoSkinBoost.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoSkinBoost.Image")));
            this.btnAutoSkinBoost.ImageOffset = new System.Drawing.Point(0, 40);
            this.btnAutoSkinBoost.ImageSize = new System.Drawing.Size(125, 125);
            this.btnAutoSkinBoost.Location = new System.Drawing.Point(385, 195);
            this.btnAutoSkinBoost.Margin = new System.Windows.Forms.Padding(5);
            this.btnAutoSkinBoost.Name = "btnAutoSkinBoost";
            this.btnAutoSkinBoost.ShadowDecoration.Depth = 5;
            this.btnAutoSkinBoost.ShadowDecoration.Enabled = true;
            this.btnAutoSkinBoost.ShadowDecoration.Parent = this.btnAutoSkinBoost;
            this.btnAutoSkinBoost.Size = new System.Drawing.Size(180, 180);
            this.btnAutoSkinBoost.TabIndex = 20;
            this.btnAutoSkinBoost.Text = "Auto Skin Boost";
            this.btnAutoSkinBoost.TextOffset = new System.Drawing.Point(0, 25);
            this.btnAutoSkinBoost.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAutoSkinBoost.UseTransparentBackground = true;
            // 
            // btnLobbyCrash
            // 
            this.btnLobbyCrash.BackColor = System.Drawing.Color.Transparent;
            this.btnLobbyCrash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLobbyCrash.BackgroundImage")));
            this.btnLobbyCrash.CheckedState.Parent = this.btnLobbyCrash;
            this.btnLobbyCrash.CustomImages.Parent = this.btnLobbyCrash;
            this.btnLobbyCrash.Enabled = false;
            this.btnLobbyCrash.FillColor = System.Drawing.Color.Transparent;
            this.btnLobbyCrash.FillColor2 = System.Drawing.Color.Transparent;
            this.btnLobbyCrash.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLobbyCrash.ForeColor = System.Drawing.Color.White;
            this.btnLobbyCrash.HoveredState.Parent = this.btnLobbyCrash;
            this.btnLobbyCrash.Image = ((System.Drawing.Image)(resources.GetObject("btnLobbyCrash.Image")));
            this.btnLobbyCrash.ImageOffset = new System.Drawing.Point(0, 40);
            this.btnLobbyCrash.ImageSize = new System.Drawing.Size(125, 125);
            this.btnLobbyCrash.Location = new System.Drawing.Point(5, 385);
            this.btnLobbyCrash.Margin = new System.Windows.Forms.Padding(5);
            this.btnLobbyCrash.Name = "btnLobbyCrash";
            this.btnLobbyCrash.ShadowDecoration.Depth = 5;
            this.btnLobbyCrash.ShadowDecoration.Enabled = true;
            this.btnLobbyCrash.ShadowDecoration.Parent = this.btnLobbyCrash;
            this.btnLobbyCrash.Size = new System.Drawing.Size(180, 180);
            this.btnLobbyCrash.TabIndex = 22;
            this.btnLobbyCrash.Text = "Lobby Crash! (Semi-Auto)";
            this.btnLobbyCrash.TextOffset = new System.Drawing.Point(0, 25);
            this.btnLobbyCrash.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnLobbyCrash.UseTransparentBackground = true;
            this.btnLobbyCrash.Click += new System.EventHandler(this.btnLobbyCrash_Click);
            // 
            // btnCreateClashLobby
            // 
            this.btnCreateClashLobby.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateClashLobby.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateClashLobby.BackgroundImage")));
            this.btnCreateClashLobby.CheckedState.Parent = this.btnCreateClashLobby;
            this.btnCreateClashLobby.CustomImages.Parent = this.btnCreateClashLobby;
            this.btnCreateClashLobby.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateClashLobby.FillColor2 = System.Drawing.Color.Transparent;
            this.btnCreateClashLobby.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateClashLobby.ForeColor = System.Drawing.Color.White;
            this.btnCreateClashLobby.HoveredState.Parent = this.btnCreateClashLobby;
            this.btnCreateClashLobby.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateClashLobby.Image")));
            this.btnCreateClashLobby.ImageOffset = new System.Drawing.Point(0, 40);
            this.btnCreateClashLobby.ImageSize = new System.Drawing.Size(125, 125);
            this.btnCreateClashLobby.Location = new System.Drawing.Point(195, 385);
            this.btnCreateClashLobby.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateClashLobby.Name = "btnCreateClashLobby";
            this.btnCreateClashLobby.ShadowDecoration.Depth = 5;
            this.btnCreateClashLobby.ShadowDecoration.Enabled = true;
            this.btnCreateClashLobby.ShadowDecoration.Parent = this.btnCreateClashLobby;
            this.btnCreateClashLobby.Size = new System.Drawing.Size(180, 180);
            this.btnCreateClashLobby.TabIndex = 23;
            this.btnCreateClashLobby.Text = "Create Clash Lobby";
            this.btnCreateClashLobby.TextOffset = new System.Drawing.Point(0, 25);
            this.btnCreateClashLobby.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnCreateClashLobby.UseTransparentBackground = true;
            this.btnCreateClashLobby.Click += new System.EventHandler(this.btnCreateClashLobby_Click);
            // 
            // btnFreeContent
            // 
            this.btnFreeContent.BackColor = System.Drawing.Color.Transparent;
            this.btnFreeContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFreeContent.BackgroundImage")));
            this.btnFreeContent.CheckedState.Parent = this.btnFreeContent;
            this.btnFreeContent.CustomImages.Parent = this.btnFreeContent;
            this.btnFreeContent.FillColor = System.Drawing.Color.Transparent;
            this.btnFreeContent.FillColor2 = System.Drawing.Color.Transparent;
            this.btnFreeContent.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFreeContent.ForeColor = System.Drawing.Color.White;
            this.btnFreeContent.HoveredState.Parent = this.btnFreeContent;
            this.btnFreeContent.Image = ((System.Drawing.Image)(resources.GetObject("btnFreeContent.Image")));
            this.btnFreeContent.ImageOffset = new System.Drawing.Point(0, 40);
            this.btnFreeContent.ImageSize = new System.Drawing.Size(125, 125);
            this.btnFreeContent.Location = new System.Drawing.Point(385, 385);
            this.btnFreeContent.Margin = new System.Windows.Forms.Padding(5);
            this.btnFreeContent.Name = "btnFreeContent";
            this.btnFreeContent.ShadowDecoration.Depth = 5;
            this.btnFreeContent.ShadowDecoration.Enabled = true;
            this.btnFreeContent.ShadowDecoration.Parent = this.btnFreeContent;
            this.btnFreeContent.Size = new System.Drawing.Size(180, 180);
            this.btnFreeContent.TabIndex = 24;
            this.btnFreeContent.Text = "Free Tristiana-Riot Girl Tristana";
            this.btnFreeContent.TextOffset = new System.Drawing.Point(0, 25);
            this.btnFreeContent.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnFreeContent.UseTransparentBackground = true;
            this.btnFreeContent.Click += new System.EventHandler(this.btnFreeContent_Click);
            // 
            // plFlowholder
            // 
            this.plFlowholder.Controls.Add(this.flpItems);
            this.plFlowholder.Location = new System.Drawing.Point(12, 36);
            this.plFlowholder.Name = "plFlowholder";
            this.plFlowholder.ShadowDecoration.Parent = this.plFlowholder;
            this.plFlowholder.Size = new System.Drawing.Size(570, 381);
            this.plFlowholder.TabIndex = 11;
            // 
            // plLeftBorder
            // 
            this.plLeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.plLeftBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.plLeftBorder.Location = new System.Drawing.Point(595, 0);
            this.plLeftBorder.Name = "plLeftBorder";
            this.plLeftBorder.Size = new System.Drawing.Size(1, 432);
            this.plLeftBorder.TabIndex = 12;
            this.plLeftBorder.TabStop = false;
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.btnMinimaze);
            this.plTop.Controls.Add(this.btnClose);
            this.plTop.Controls.Add(this.tbTitle);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(595, 30);
            this.plTop.TabIndex = 13;
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnMinimaze.HoveredState.Parent = this.btnMinimaze;
            this.btnMinimaze.IconColor = System.Drawing.Color.White;
            this.btnMinimaze.Location = new System.Drawing.Point(505, 0);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.ShadowDecoration.Parent = this.btnMinimaze;
            this.btnMinimaze.Size = new System.Drawing.Size(45, 30);
            this.btnMinimaze.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnClose.HoveredState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(550, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 30);
            this.btnClose.TabIndex = 3;
            // 
            // tbTitle
            // 
            this.tbTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbTitle.BorderThickness = 0;
            this.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitle.DefaultText = "Matrix View";
            this.tbTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tbTitle.DisabledState.Parent = this.tbTitle;
            this.tbTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.Enabled = false;
            this.tbTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbTitle.FocusedState.Parent = this.tbTitle;
            this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tbTitle.HoveredState.Parent = this.tbTitle;
            this.tbTitle.Location = new System.Drawing.Point(0, 0);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PasswordChar = '\0';
            this.tbTitle.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tbTitle.PlaceholderText = "";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.SelectedText = "";
            this.tbTitle.ShadowDecoration.Parent = this.tbTitle;
            this.tbTitle.Size = new System.Drawing.Size(595, 30);
            this.tbTitle.TabIndex = 5;
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Update
            // 
            this.Update.Interval = 1500;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // FadeShow
            // 
            this.FadeShow.Interval = 15;
            this.FadeShow.Tick += new System.EventHandler(this.FadeShow_Tick);
            // 
            // FadeHide
            // 
            this.FadeHide.Interval = 15;
            this.FadeHide.Tick += new System.EventHandler(this.FadeHide_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(868, 432);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.plLeftBorder);
            this.Controls.Add(this.plFlowholder);
            this.Controls.Add(this.plLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.plLeft.ResumeLayout(false);
            this.plLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerIcon)).EndInit();
            this.flpItems.ResumeLayout(false);
            this.plFlowholder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plLeftBorder)).EndInit();
            this.plTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plLeft;
        private Siticone.UI.WinForms.SiticoneTextBox tbUsernameReadonly;
        private Siticone.UI.WinForms.SiticonePictureBox pbPlayerIcon;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private Siticone.UI.WinForms.SiticoneGradientPanel plFlowholder;
        private System.Windows.Forms.PictureBox plLeftBorder;
        private System.Windows.Forms.Panel plTop;
        private Siticone.UI.WinForms.SiticoneControlBox btnMinimaze;
        private Siticone.UI.WinForms.SiticoneControlBox btnClose;
        private Siticone.UI.WinForms.SiticoneTextBox tbTitle;
        private Siticone.UI.WinForms.SiticoneGradientTileButton btnSkinBoost;
        private Siticone.UI.WinForms.SiticoneGradientTileButton btnChangeProfileIcon;
        private Siticone.UI.WinForms.SiticoneGradientTileButton btnPratice5v5;
        private Siticone.UI.WinForms.SiticoneGradientTileButton btnAutoAccept;
        private Siticone.UI.WinForms.SiticoneGradientTileButton btnAutoSkinBoost;
        private Siticone.UI.WinForms.SiticoneGradientTileButton btnAppearChangeStatus;
        private Siticone.UI.WinForms.SiticoneProgressBar pbLevelProgress;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.Timer FadeShow;
        private System.Windows.Forms.Timer FadeHide;
        private Siticone.UI.WinForms.SiticoneGradientTileButton btnLobbyCrash;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox cbStreamproof;
        private System.Windows.Forms.Label lblHideFromStream;
        private Siticone.UI.WinForms.SiticoneGradientTileButton btnCreateClashLobby;
        private Siticone.UI.WinForms.SiticoneGradientTileButton btnFreeContent;
    }
}