namespace Inset_Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.TopBar = new System.Windows.Forms.Panel();
            this.TopBarIcon = new System.Windows.Forms.PictureBox();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Border_Top_Tab = new System.Windows.Forms.Panel();
            this.Border_Left_Tab = new System.Windows.Forms.Panel();
            this.Border_Right_Tab = new System.Windows.Forms.Panel();
            this.Home_Button = new System.Windows.Forms.Button();
            this.WindowTitle_Label = new System.Windows.Forms.Label();
            this.List_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.TopBarDrag = new ns1.BunifuDragControl(this.components);
            this.Inject_Button = new System.Windows.Forms.Button();
            this.OpenFile_Button = new System.Windows.Forms.Button();
            this.Execute_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.WindowTitleDrag = new ns1.BunifuDragControl(this.components);
            this.BTools_Button = new System.Windows.Forms.Button();
            this.FireBalls_Button = new System.Windows.Forms.Button();
            this.AimBot_Button = new System.Windows.Forms.Button();
            this.Menu_Button = new System.Windows.Forms.Button();
            this.RTX_Button = new System.Windows.Forms.Button();
            this.Sky_Button = new System.Windows.Forms.Button();
            this.Border_Bottom_Left = new System.Windows.Forms.Panel();
            this.Border_Bottom_Right = new System.Windows.Forms.Panel();
            this.InsetAPI_RadioButton = new System.Windows.Forms.RadioButton();
            this.Settings_Label = new System.Windows.Forms.Label();
            this.TopApp_RadioButton = new System.Windows.Forms.RadioButton();
            this.TopBarIconDrag = new ns1.BunifuDragControl(this.components);
            this.CustomAPI_RadioButton = new System.Windows.Forms.RadioButton();
            this.CustomAPIURL = new System.Windows.Forms.RichTextBox();
            this.ScriptBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.DexExplorer_Button = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopBarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TopBar.Controls.Add(this.TopBarIcon);
            this.TopBar.Controls.Add(this.Minimize_Button);
            this.TopBar.Controls.Add(this.button1);
            this.TopBar.Controls.Add(this.Border_Top_Tab);
            this.TopBar.Controls.Add(this.Border_Left_Tab);
            this.TopBar.Controls.Add(this.Border_Right_Tab);
            this.TopBar.Controls.Add(this.Home_Button);
            this.TopBar.Controls.Add(this.WindowTitle_Label);
            this.TopBar.Controls.Add(this.List_Button);
            this.TopBar.Controls.Add(this.Close_Button);
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(675, 50);
            this.TopBar.TabIndex = 0;
            // 
            // TopBarIcon
            // 
            this.TopBarIcon.Image = global::Inset_Client.Properties.Resources.Logo_Square;
            this.TopBarIcon.Location = new System.Drawing.Point(10, 10);
            this.TopBarIcon.Name = "TopBarIcon";
            this.TopBarIcon.Size = new System.Drawing.Size(30, 30);
            this.TopBarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TopBarIcon.TabIndex = 8;
            this.TopBarIcon.TabStop = false;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(155)))));
            this.Minimize_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Minimize_Button.ForeColor = System.Drawing.Color.Blue;
            this.Minimize_Button.Location = new System.Drawing.Point(607, 12);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(25, 25);
            this.Minimize_Button.TabIndex = 7;
            this.Minimize_Button.Text = "-";
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(364, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Client";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Client_Button_Click);
            // 
            // Border_Top_Tab
            // 
            this.Border_Top_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Border_Top_Tab.Cursor = System.Windows.Forms.Cursors.Default;
            this.Border_Top_Tab.Location = new System.Drawing.Point(239, 24);
            this.Border_Top_Tab.Name = "Border_Top_Tab";
            this.Border_Top_Tab.Size = new System.Drawing.Size(63, 1);
            this.Border_Top_Tab.TabIndex = 5;
            // 
            // Border_Left_Tab
            // 
            this.Border_Left_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Border_Left_Tab.Cursor = System.Windows.Forms.Cursors.Default;
            this.Border_Left_Tab.Location = new System.Drawing.Point(239, 25);
            this.Border_Left_Tab.Name = "Border_Left_Tab";
            this.Border_Left_Tab.Size = new System.Drawing.Size(1, 25);
            this.Border_Left_Tab.TabIndex = 5;
            // 
            // Border_Right_Tab
            // 
            this.Border_Right_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Border_Right_Tab.Cursor = System.Windows.Forms.Cursors.Default;
            this.Border_Right_Tab.Location = new System.Drawing.Point(301, 25);
            this.Border_Right_Tab.Name = "Border_Right_Tab";
            this.Border_Right_Tab.Size = new System.Drawing.Size(1, 25);
            this.Border_Right_Tab.TabIndex = 4;
            // 
            // Home_Button
            // 
            this.Home_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_Button.FlatAppearance.BorderSize = 0;
            this.Home_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Home_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Home_Button.Location = new System.Drawing.Point(240, 25);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(60, 25);
            this.Home_Button.TabIndex = 3;
            this.Home_Button.Text = "Home";
            this.Home_Button.UseVisualStyleBackColor = true;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // WindowTitle_Label
            // 
            this.WindowTitle_Label.AutoSize = true;
            this.WindowTitle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WindowTitle_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
            this.WindowTitle_Label.Location = new System.Drawing.Point(45, 12);
            this.WindowTitle_Label.Name = "WindowTitle_Label";
            this.WindowTitle_Label.Size = new System.Drawing.Size(190, 25);
            this.WindowTitle_Label.TabIndex = 2;
            this.WindowTitle_Label.Text = "Inset Client (V 1.1.5)";
            this.WindowTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // List_Button
            // 
            this.List_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.List_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.List_Button.FlatAppearance.BorderSize = 0;
            this.List_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.List_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.List_Button.ForeColor = System.Drawing.Color.White;
            this.List_Button.Location = new System.Drawing.Point(302, 25);
            this.List_Button.Name = "List_Button";
            this.List_Button.Size = new System.Drawing.Size(60, 25);
            this.List_Button.TabIndex = 1;
            this.List_Button.Text = "List";
            this.List_Button.UseVisualStyleBackColor = false;
            this.List_Button.Click += new System.EventHandler(this.List_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Close_Button.ForeColor = System.Drawing.Color.Red;
            this.Close_Button.Location = new System.Drawing.Point(638, 12);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(25, 25);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.Text = "X";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // TopBarDrag
            // 
            this.TopBarDrag.Fixed = true;
            this.TopBarDrag.Horizontal = true;
            this.TopBarDrag.TargetControl = this.TopBar;
            this.TopBarDrag.Vertical = true;
            // 
            // Inject_Button
            // 
            this.Inject_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Inject_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inject_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Inject_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Inject_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Inject_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inject_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Inject_Button.ForeColor = System.Drawing.Color.White;
            this.Inject_Button.Location = new System.Drawing.Point(10, 360);
            this.Inject_Button.Name = "Inject_Button";
            this.Inject_Button.Size = new System.Drawing.Size(154, 42);
            this.Inject_Button.TabIndex = 3;
            this.Inject_Button.Text = "Inject";
            this.Inject_Button.UseVisualStyleBackColor = false;
            this.Inject_Button.Click += new System.EventHandler(this.Inject_Button_Click);
            // 
            // OpenFile_Button
            // 
            this.OpenFile_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OpenFile_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFile_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.OpenFile_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.OpenFile_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OpenFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OpenFile_Button.ForeColor = System.Drawing.Color.White;
            this.OpenFile_Button.Location = new System.Drawing.Point(177, 360);
            this.OpenFile_Button.Name = "OpenFile_Button";
            this.OpenFile_Button.Size = new System.Drawing.Size(154, 42);
            this.OpenFile_Button.TabIndex = 4;
            this.OpenFile_Button.Text = "Open File";
            this.OpenFile_Button.UseVisualStyleBackColor = false;
            this.OpenFile_Button.Click += new System.EventHandler(this.OpenFile_Button_Click);
            // 
            // Execute_Button
            // 
            this.Execute_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Execute_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Execute_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Execute_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Execute_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Execute_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Execute_Button.ForeColor = System.Drawing.Color.White;
            this.Execute_Button.Location = new System.Drawing.Point(344, 360);
            this.Execute_Button.Name = "Execute_Button";
            this.Execute_Button.Size = new System.Drawing.Size(154, 42);
            this.Execute_Button.TabIndex = 5;
            this.Execute_Button.Text = "Execute";
            this.Execute_Button.UseVisualStyleBackColor = false;
            this.Execute_Button.Click += new System.EventHandler(this.Execute_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Clear_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Clear_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Clear_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Clear_Button.ForeColor = System.Drawing.Color.White;
            this.Clear_Button.Location = new System.Drawing.Point(511, 360);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(154, 42);
            this.Clear_Button.TabIndex = 6;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // WindowTitleDrag
            // 
            this.WindowTitleDrag.Fixed = true;
            this.WindowTitleDrag.Horizontal = true;
            this.WindowTitleDrag.TargetControl = this.WindowTitle_Label;
            this.WindowTitleDrag.Vertical = true;
            // 
            // BTools_Button
            // 
            this.BTools_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BTools_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTools_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.BTools_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.BTools_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTools_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTools_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BTools_Button.ForeColor = System.Drawing.Color.White;
            this.BTools_Button.Location = new System.Drawing.Point(513, 60);
            this.BTools_Button.Name = "BTools_Button";
            this.BTools_Button.Size = new System.Drawing.Size(150, 42);
            this.BTools_Button.TabIndex = 10;
            this.BTools_Button.Text = "BTools";
            this.BTools_Button.UseVisualStyleBackColor = false;
            this.BTools_Button.Visible = false;
            this.BTools_Button.Click += new System.EventHandler(this.BTools_Button_Click);
            // 
            // FireBalls_Button
            // 
            this.FireBalls_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FireBalls_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FireBalls_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.FireBalls_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.FireBalls_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FireBalls_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FireBalls_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FireBalls_Button.ForeColor = System.Drawing.Color.White;
            this.FireBalls_Button.Location = new System.Drawing.Point(345, 60);
            this.FireBalls_Button.Name = "FireBalls_Button";
            this.FireBalls_Button.Size = new System.Drawing.Size(150, 42);
            this.FireBalls_Button.TabIndex = 9;
            this.FireBalls_Button.Text = "Fire Balls";
            this.FireBalls_Button.UseVisualStyleBackColor = false;
            this.FireBalls_Button.Visible = false;
            this.FireBalls_Button.Click += new System.EventHandler(this.FireBalls_Button_Click);
            // 
            // AimBot_Button
            // 
            this.AimBot_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AimBot_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AimBot_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.AimBot_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.AimBot_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AimBot_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AimBot_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AimBot_Button.ForeColor = System.Drawing.Color.White;
            this.AimBot_Button.Location = new System.Drawing.Point(179, 60);
            this.AimBot_Button.Name = "AimBot_Button";
            this.AimBot_Button.Size = new System.Drawing.Size(150, 42);
            this.AimBot_Button.TabIndex = 8;
            this.AimBot_Button.Text = "Aim Bot";
            this.AimBot_Button.UseVisualStyleBackColor = false;
            this.AimBot_Button.Visible = false;
            this.AimBot_Button.Click += new System.EventHandler(this.AimBot_Button_Click);
            // 
            // Menu_Button
            // 
            this.Menu_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Menu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Menu_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Menu_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Menu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Menu_Button.ForeColor = System.Drawing.Color.White;
            this.Menu_Button.Location = new System.Drawing.Point(10, 60);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(150, 42);
            this.Menu_Button.TabIndex = 7;
            this.Menu_Button.Text = "Menu";
            this.Menu_Button.UseVisualStyleBackColor = false;
            this.Menu_Button.Visible = false;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // RTX_Button
            // 
            this.RTX_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RTX_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RTX_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.RTX_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.RTX_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RTX_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RTX_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RTX_Button.ForeColor = System.Drawing.Color.White;
            this.RTX_Button.Location = new System.Drawing.Point(10, 108);
            this.RTX_Button.Name = "RTX_Button";
            this.RTX_Button.Size = new System.Drawing.Size(150, 42);
            this.RTX_Button.TabIndex = 11;
            this.RTX_Button.Text = "Cheep RTX";
            this.RTX_Button.UseVisualStyleBackColor = false;
            this.RTX_Button.Visible = false;
            this.RTX_Button.Click += new System.EventHandler(this.RTX_Button_Click);
            // 
            // Sky_Button
            // 
            this.Sky_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Sky_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sky_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Sky_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Sky_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Sky_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sky_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Sky_Button.ForeColor = System.Drawing.Color.White;
            this.Sky_Button.Location = new System.Drawing.Point(179, 108);
            this.Sky_Button.Name = "Sky_Button";
            this.Sky_Button.Size = new System.Drawing.Size(150, 42);
            this.Sky_Button.TabIndex = 12;
            this.Sky_Button.Text = "Custom Sky";
            this.Sky_Button.UseVisualStyleBackColor = false;
            this.Sky_Button.Visible = false;
            this.Sky_Button.Click += new System.EventHandler(this.Sky_Button_Click);
            // 
            // Border_Bottom_Left
            // 
            this.Border_Bottom_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Border_Bottom_Left.Cursor = System.Windows.Forms.Cursors.Default;
            this.Border_Bottom_Left.Location = new System.Drawing.Point(0, 50);
            this.Border_Bottom_Left.Name = "Border_Bottom_Left";
            this.Border_Bottom_Left.Size = new System.Drawing.Size(240, 1);
            this.Border_Bottom_Left.TabIndex = 6;
            // 
            // Border_Bottom_Right
            // 
            this.Border_Bottom_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.Border_Bottom_Right.Cursor = System.Windows.Forms.Cursors.Default;
            this.Border_Bottom_Right.Location = new System.Drawing.Point(301, 50);
            this.Border_Bottom_Right.Name = "Border_Bottom_Right";
            this.Border_Bottom_Right.Size = new System.Drawing.Size(374, 1);
            this.Border_Bottom_Right.TabIndex = 7;
            // 
            // InsetAPI_RadioButton
            // 
            this.InsetAPI_RadioButton.AutoCheck = false;
            this.InsetAPI_RadioButton.AutoSize = true;
            this.InsetAPI_RadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.InsetAPI_RadioButton.Checked = true;
            this.InsetAPI_RadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsetAPI_RadioButton.FlatAppearance.BorderSize = 0;
            this.InsetAPI_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InsetAPI_RadioButton.ForeColor = System.Drawing.Color.White;
            this.InsetAPI_RadioButton.Location = new System.Drawing.Point(25, 120);
            this.InsetAPI_RadioButton.Name = "InsetAPI_RadioButton";
            this.InsetAPI_RadioButton.Size = new System.Drawing.Size(81, 21);
            this.InsetAPI_RadioButton.TabIndex = 13;
            this.InsetAPI_RadioButton.TabStop = true;
            this.InsetAPI_RadioButton.Text = "Inset API";
            this.InsetAPI_RadioButton.UseVisualStyleBackColor = false;
            this.InsetAPI_RadioButton.Visible = false;
            this.InsetAPI_RadioButton.Click += new System.EventHandler(this.InsetAPI_RadioButton_Click);
            // 
            // Settings_Label
            // 
            this.Settings_Label.AutoSize = true;
            this.Settings_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
            this.Settings_Label.Location = new System.Drawing.Point(260, 70);
            this.Settings_Label.Name = "Settings_Label";
            this.Settings_Label.Size = new System.Drawing.Size(151, 25);
            this.Settings_Label.TabIndex = 7;
            this.Settings_Label.Text = "Client Settings";
            this.Settings_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Settings_Label.Visible = false;
            // 
            // TopApp_RadioButton
            // 
            this.TopApp_RadioButton.AutoCheck = false;
            this.TopApp_RadioButton.AutoSize = true;
            this.TopApp_RadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TopApp_RadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopApp_RadioButton.FlatAppearance.BorderSize = 0;
            this.TopApp_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TopApp_RadioButton.ForeColor = System.Drawing.Color.White;
            this.TopApp_RadioButton.Location = new System.Drawing.Point(25, 150);
            this.TopApp_RadioButton.Name = "TopApp_RadioButton";
            this.TopApp_RadioButton.Size = new System.Drawing.Size(80, 21);
            this.TopApp_RadioButton.TabIndex = 15;
            this.TopApp_RadioButton.TabStop = true;
            this.TopApp_RadioButton.Text = "Top App";
            this.TopApp_RadioButton.UseVisualStyleBackColor = false;
            this.TopApp_RadioButton.Visible = false;
            this.TopApp_RadioButton.Click += new System.EventHandler(this.TopApp_RadioButton_Click);
            // 
            // TopBarIconDrag
            // 
            this.TopBarIconDrag.Fixed = true;
            this.TopBarIconDrag.Horizontal = true;
            this.TopBarIconDrag.TargetControl = this.TopBarIcon;
            this.TopBarIconDrag.Vertical = true;
            // 
            // CustomAPI_RadioButton
            // 
            this.CustomAPI_RadioButton.AutoCheck = false;
            this.CustomAPI_RadioButton.AutoSize = true;
            this.CustomAPI_RadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CustomAPI_RadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomAPI_RadioButton.FlatAppearance.BorderSize = 0;
            this.CustomAPI_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CustomAPI_RadioButton.ForeColor = System.Drawing.Color.White;
            this.CustomAPI_RadioButton.Location = new System.Drawing.Point(25, 180);
            this.CustomAPI_RadioButton.Name = "CustomAPI_RadioButton";
            this.CustomAPI_RadioButton.Size = new System.Drawing.Size(128, 21);
            this.CustomAPI_RadioButton.TabIndex = 16;
            this.CustomAPI_RadioButton.TabStop = true;
            this.CustomAPI_RadioButton.Text = "Custom API Link";
            this.CustomAPI_RadioButton.UseVisualStyleBackColor = false;
            this.CustomAPI_RadioButton.Visible = false;
            this.CustomAPI_RadioButton.Click += new System.EventHandler(this.CustomAPI_RadioButton_Click);
            // 
            // CustomAPIURL
            // 
            this.CustomAPIURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CustomAPIURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomAPIURL.DetectUrls = false;
            this.CustomAPIURL.Font = new System.Drawing.Font("Consolas", 12F);
            this.CustomAPIURL.ForeColor = System.Drawing.Color.White;
            this.CustomAPIURL.Location = new System.Drawing.Point(174, 180);
            this.CustomAPIURL.Multiline = false;
            this.CustomAPIURL.Name = "CustomAPIURL";
            this.CustomAPIURL.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CustomAPIURL.Size = new System.Drawing.Size(195, 21);
            this.CustomAPIURL.TabIndex = 17;
            this.CustomAPIURL.Text = "";
            this.CustomAPIURL.Visible = false;
            this.CustomAPIURL.WordWrap = false;
            // 
            // ScriptBox
            // 
            this.ScriptBox.AllowMacroRecording = false;
            this.ScriptBox.AutoCompleteBrackets = true;
            this.ScriptBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ScriptBox.AutoIndent = false;
            this.ScriptBox.AutoIndentChars = false;
            this.ScriptBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.ScriptBox.AutoScrollMinSize = new System.Drawing.Size(443, 90);
            this.ScriptBox.BackBrush = null;
            this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ScriptBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ScriptBox.CaretBlinking = false;
            this.ScriptBox.CaretColor = System.Drawing.Color.White;
            this.ScriptBox.CharHeight = 18;
            this.ScriptBox.CharWidth = 9;
            this.ScriptBox.CommentPrefix = "--";
            this.ScriptBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScriptBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptBox.FindEndOfFoldingBlockStrategy = FastColoredTextBoxNS.FindEndOfFoldingBlockStrategy.Strategy2;
            this.ScriptBox.FoldingIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.ScriptBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.ScriptBox.ForeColor = System.Drawing.Color.White;
            this.ScriptBox.HighlightFoldingIndicator = false;
            this.ScriptBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ScriptBox.IsReplaceMode = false;
            this.ScriptBox.Language = FastColoredTextBoxNS.Language.Lua;
            this.ScriptBox.LeftBracket = '(';
            this.ScriptBox.LeftBracket2 = '{';
            this.ScriptBox.LineNumberColor = System.Drawing.Color.White;
            this.ScriptBox.Location = new System.Drawing.Point(10, 60);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptBox.RightBracket = ')';
            this.ScriptBox.RightBracket2 = '}';
            this.ScriptBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.ScriptBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptBox.ServiceColors")));
            this.ScriptBox.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.ScriptBox.ShowScrollBars = false;
            this.ScriptBox.Size = new System.Drawing.Size(655, 290);
            this.ScriptBox.TabIndex = 18;
            this.ScriptBox.Text = "--[[\r\n    Made by Inset [-]\r\n    Scripts:\r\n    https://github.com/ENDLESS-HACKER0" +
    "/Scripts\r\n]]--";
            this.ScriptBox.Zoom = 100;
            // 
            // DexExplorer_Button
            // 
            this.DexExplorer_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DexExplorer_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DexExplorer_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.DexExplorer_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.DexExplorer_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DexExplorer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DexExplorer_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DexExplorer_Button.ForeColor = System.Drawing.Color.White;
            this.DexExplorer_Button.Location = new System.Drawing.Point(345, 108);
            this.DexExplorer_Button.Name = "DexExplorer_Button";
            this.DexExplorer_Button.Size = new System.Drawing.Size(150, 42);
            this.DexExplorer_Button.TabIndex = 19;
            this.DexExplorer_Button.Text = "Dex Explorer";
            this.DexExplorer_Button.UseVisualStyleBackColor = false;
            this.DexExplorer_Button.Visible = false;
            this.DexExplorer_Button.Click += new System.EventHandler(this.DexExplorer_Button_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(675, 410);
            this.ControlBox = false;
            this.Controls.Add(this.DexExplorer_Button);
            this.Controls.Add(this.CustomAPIURL);
            this.Controls.Add(this.CustomAPI_RadioButton);
            this.Controls.Add(this.TopApp_RadioButton);
            this.Controls.Add(this.Settings_Label);
            this.Controls.Add(this.InsetAPI_RadioButton);
            this.Controls.Add(this.Border_Bottom_Right);
            this.Controls.Add(this.Border_Bottom_Left);
            this.Controls.Add(this.Sky_Button);
            this.Controls.Add(this.RTX_Button);
            this.Controls.Add(this.BTools_Button);
            this.Controls.Add(this.FireBalls_Button);
            this.Controls.Add(this.AimBot_Button);
            this.Controls.Add(this.Menu_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Execute_Button);
            this.Controls.Add(this.OpenFile_Button);
            this.Controls.Add(this.Inject_Button);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.ScriptBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inset Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_Closing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopBarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button List_Button;
        private ns1.BunifuDragControl TopBarDrag;
        private System.Windows.Forms.Label WindowTitle_Label;
        private System.Windows.Forms.Button Inject_Button;
        private System.Windows.Forms.Button OpenFile_Button;
        private System.Windows.Forms.Button Execute_Button;
        private System.Windows.Forms.Button Clear_Button;
        private ns1.BunifuDragControl WindowTitleDrag;
        private System.Windows.Forms.Button BTools_Button;
        private System.Windows.Forms.Button FireBalls_Button;
        private System.Windows.Forms.Button AimBot_Button;
        private System.Windows.Forms.Button Menu_Button;
        private System.Windows.Forms.Button RTX_Button;
        private System.Windows.Forms.Button Sky_Button;
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Panel Border_Top_Tab;
        private System.Windows.Forms.Panel Border_Left_Tab;
        private System.Windows.Forms.Panel Border_Right_Tab;
        private System.Windows.Forms.Panel Border_Bottom_Left;
        private System.Windows.Forms.Panel Border_Bottom_Right;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton InsetAPI_RadioButton;
        private System.Windows.Forms.Label Settings_Label;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.RadioButton TopApp_RadioButton;
        private System.Windows.Forms.PictureBox TopBarIcon;
        private ns1.BunifuDragControl TopBarIconDrag;
        private System.Windows.Forms.RadioButton CustomAPI_RadioButton;
        private System.Windows.Forms.RichTextBox CustomAPIURL;
        private FastColoredTextBoxNS.FastColoredTextBox ScriptBox;
        private System.Windows.Forms.Button DexExplorer_Button;
    }
}

