namespace DisplayNewsPanel
{
    partial class NewsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsPanel));
            this.panelSetting = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxSettingPanelClose = new System.Windows.Forms.PictureBox();
            this.tabControlSetting = new System.Windows.Forms.TabControl();
            this.tabPageNewsPicture = new System.Windows.Forms.TabPage();
            this.tabPageNews1 = new System.Windows.Forms.TabPage();
            this.textBoxNews1Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNews1BackColor = new System.Windows.Forms.Button();
            this.labelNews1Speed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNews1TextStyle = new System.Windows.Forms.Button();
            this.buttonNews1ForeColor = new System.Windows.Forms.Button();
            this.trackBarNews1Speed = new System.Windows.Forms.TrackBar();
            this.comboBoxNews1Direction = new System.Windows.Forms.ComboBox();
            this.tabPageNews2 = new System.Windows.Forms.TabPage();
            this.textBoxNews2Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNews2BackColor = new System.Windows.Forms.Button();
            this.labelNews2Speed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonNews2TextStyle = new System.Windows.Forms.Button();
            this.buttonNews2ForeColor = new System.Windows.Forms.Button();
            this.trackBarNews2Speed = new System.Windows.Forms.TrackBar();
            this.comboBoxNews2Direction = new System.Windows.Forms.ComboBox();
            this.saDragControlSettingPanel = new ShakikulFramework.Toolbox.SADragControl();
            this.timerSetting = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelNews = new System.Windows.Forms.TableLayoutPanel();
            this.saScrollingLabelTextNews1 = new ShakikulFramework.SAScrollingLabelText();
            this.saScrollingLabelTextNews2 = new ShakikulFramework.SAScrollingLabelText();
            this.pictureBoxNewsImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxSetting = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingPanelClose)).BeginInit();
            this.tabControlSetting.SuspendLayout();
            this.tabPageNews1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNews1Speed)).BeginInit();
            this.tabPageNews2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNews2Speed)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSetting.Controls.Add(this.labelTitle);
            this.panelSetting.Controls.Add(this.pictureBoxSettingPanelClose);
            this.panelSetting.Controls.Add(this.tabControlSetting);
            this.panelSetting.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSetting.Location = new System.Drawing.Point(75, 23);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(674, 254);
            this.panelSetting.TabIndex = 2;
            this.panelSetting.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(3, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(75, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Setting";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxSettingPanelClose
            // 
            this.pictureBoxSettingPanelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSettingPanelClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSettingPanelClose.Image = global::DisplayNewsPanel.Properties.Resources.Close;
            this.pictureBoxSettingPanelClose.Location = new System.Drawing.Point(638, 0);
            this.pictureBoxSettingPanelClose.Name = "pictureBoxSettingPanelClose";
            this.pictureBoxSettingPanelClose.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxSettingPanelClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSettingPanelClose.TabIndex = 4;
            this.pictureBoxSettingPanelClose.TabStop = false;
            this.pictureBoxSettingPanelClose.Click += new System.EventHandler(this.pictureBoxSettingPanelClose_Click);
            // 
            // tabControlSetting
            // 
            this.tabControlSetting.Controls.Add(this.tabPageNewsPicture);
            this.tabControlSetting.Controls.Add(this.tabPageNews1);
            this.tabControlSetting.Controls.Add(this.tabPageNews2);
            this.tabControlSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlSetting.Location = new System.Drawing.Point(0, 36);
            this.tabControlSetting.Name = "tabControlSetting";
            this.tabControlSetting.SelectedIndex = 0;
            this.tabControlSetting.Size = new System.Drawing.Size(674, 218);
            this.tabControlSetting.TabIndex = 15;
            // 
            // tabPageNewsPicture
            // 
            this.tabPageNewsPicture.Location = new System.Drawing.Point(4, 27);
            this.tabPageNewsPicture.Name = "tabPageNewsPicture";
            this.tabPageNewsPicture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewsPicture.Size = new System.Drawing.Size(666, 187);
            this.tabPageNewsPicture.TabIndex = 0;
            this.tabPageNewsPicture.Text = "Picture";
            this.tabPageNewsPicture.UseVisualStyleBackColor = true;
            // 
            // tabPageNews1
            // 
            this.tabPageNews1.Controls.Add(this.textBoxNews1Text);
            this.tabPageNews1.Controls.Add(this.label2);
            this.tabPageNews1.Controls.Add(this.buttonNews1BackColor);
            this.tabPageNews1.Controls.Add(this.labelNews1Speed);
            this.tabPageNews1.Controls.Add(this.label4);
            this.tabPageNews1.Controls.Add(this.label3);
            this.tabPageNews1.Controls.Add(this.buttonNews1TextStyle);
            this.tabPageNews1.Controls.Add(this.buttonNews1ForeColor);
            this.tabPageNews1.Controls.Add(this.trackBarNews1Speed);
            this.tabPageNews1.Controls.Add(this.comboBoxNews1Direction);
            this.tabPageNews1.Location = new System.Drawing.Point(4, 27);
            this.tabPageNews1.Name = "tabPageNews1";
            this.tabPageNews1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNews1.Size = new System.Drawing.Size(666, 187);
            this.tabPageNews1.TabIndex = 1;
            this.tabPageNews1.Text = "News 1";
            this.tabPageNews1.UseVisualStyleBackColor = true;
            // 
            // textBoxNews1Text
            // 
            this.textBoxNews1Text.Location = new System.Drawing.Point(109, 43);
            this.textBoxNews1Text.Name = "textBoxNews1Text";
            this.textBoxNews1Text.Size = new System.Drawing.Size(530, 26);
            this.textBoxNews1Text.TabIndex = 2;
            this.textBoxNews1Text.TextChanged += new System.EventHandler(this.textBoxNewsText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "News";
            // 
            // buttonNews1BackColor
            // 
            this.buttonNews1BackColor.AutoSize = true;
            this.buttonNews1BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNews1BackColor.Location = new System.Drawing.Point(399, 75);
            this.buttonNews1BackColor.Name = "buttonNews1BackColor";
            this.buttonNews1BackColor.Size = new System.Drawing.Size(102, 30);
            this.buttonNews1BackColor.TabIndex = 5;
            this.buttonNews1BackColor.Text = "Back Color";
            this.buttonNews1BackColor.UseVisualStyleBackColor = true;
            this.buttonNews1BackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // labelNews1Speed
            // 
            this.labelNews1Speed.AutoSize = true;
            this.labelNews1Speed.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews1Speed.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelNews1Speed.Location = new System.Drawing.Point(600, 112);
            this.labelNews1Speed.Name = "labelNews1Speed";
            this.labelNews1Speed.Size = new System.Drawing.Size(26, 29);
            this.labelNews1Speed.TabIndex = 8;
            this.labelNews1Speed.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Direction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed";
            // 
            // buttonNews1TextStyle
            // 
            this.buttonNews1TextStyle.AutoSize = true;
            this.buttonNews1TextStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNews1TextStyle.Location = new System.Drawing.Point(507, 75);
            this.buttonNews1TextStyle.Name = "buttonNews1TextStyle";
            this.buttonNews1TextStyle.Size = new System.Drawing.Size(132, 30);
            this.buttonNews1TextStyle.TabIndex = 4;
            this.buttonNews1TextStyle.Text = "Font, Style, Size";
            this.buttonNews1TextStyle.UseVisualStyleBackColor = true;
            this.buttonNews1TextStyle.Click += new System.EventHandler(this.buttonTextStyle_Click);
            // 
            // buttonNews1ForeColor
            // 
            this.buttonNews1ForeColor.AutoSize = true;
            this.buttonNews1ForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNews1ForeColor.Location = new System.Drawing.Point(298, 75);
            this.buttonNews1ForeColor.Name = "buttonNews1ForeColor";
            this.buttonNews1ForeColor.Size = new System.Drawing.Size(95, 30);
            this.buttonNews1ForeColor.TabIndex = 3;
            this.buttonNews1ForeColor.Text = "Fore Color";
            this.buttonNews1ForeColor.UseVisualStyleBackColor = true;
            this.buttonNews1ForeColor.Click += new System.EventHandler(this.buttonForeColor_Click);
            // 
            // trackBarNews1Speed
            // 
            this.trackBarNews1Speed.AutoSize = false;
            this.trackBarNews1Speed.BackColor = System.Drawing.Color.DarkGreen;
            this.trackBarNews1Speed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarNews1Speed.LargeChange = 1;
            this.trackBarNews1Speed.Location = new System.Drawing.Point(109, 111);
            this.trackBarNews1Speed.Maximum = 50;
            this.trackBarNews1Speed.Minimum = 1;
            this.trackBarNews1Speed.Name = "trackBarNews1Speed";
            this.trackBarNews1Speed.Size = new System.Drawing.Size(485, 33);
            this.trackBarNews1Speed.TabIndex = 6;
            this.trackBarNews1Speed.Value = 5;
            this.trackBarNews1Speed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // comboBoxNews1Direction
            // 
            this.comboBoxNews1Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNews1Direction.FormattingEnabled = true;
            this.comboBoxNews1Direction.Location = new System.Drawing.Point(109, 75);
            this.comboBoxNews1Direction.Name = "comboBoxNews1Direction";
            this.comboBoxNews1Direction.Size = new System.Drawing.Size(183, 26);
            this.comboBoxNews1Direction.TabIndex = 12;
            this.comboBoxNews1Direction.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirection_SelectedIndexChanged);
            // 
            // tabPageNews2
            // 
            this.tabPageNews2.Controls.Add(this.textBoxNews2Text);
            this.tabPageNews2.Controls.Add(this.label1);
            this.tabPageNews2.Controls.Add(this.buttonNews2BackColor);
            this.tabPageNews2.Controls.Add(this.labelNews2Speed);
            this.tabPageNews2.Controls.Add(this.label6);
            this.tabPageNews2.Controls.Add(this.label7);
            this.tabPageNews2.Controls.Add(this.buttonNews2TextStyle);
            this.tabPageNews2.Controls.Add(this.buttonNews2ForeColor);
            this.tabPageNews2.Controls.Add(this.trackBarNews2Speed);
            this.tabPageNews2.Controls.Add(this.comboBoxNews2Direction);
            this.tabPageNews2.Location = new System.Drawing.Point(4, 27);
            this.tabPageNews2.Name = "tabPageNews2";
            this.tabPageNews2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNews2.Size = new System.Drawing.Size(666, 187);
            this.tabPageNews2.TabIndex = 2;
            this.tabPageNews2.Text = "News 2";
            this.tabPageNews2.UseVisualStyleBackColor = true;
            // 
            // textBoxNews2Text
            // 
            this.textBoxNews2Text.Location = new System.Drawing.Point(109, 43);
            this.textBoxNews2Text.Name = "textBoxNews2Text";
            this.textBoxNews2Text.Size = new System.Drawing.Size(530, 26);
            this.textBoxNews2Text.TabIndex = 15;
            this.textBoxNews2Text.TextChanged += new System.EventHandler(this.textBoxNews2Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "News";
            // 
            // buttonNews2BackColor
            // 
            this.buttonNews2BackColor.AutoSize = true;
            this.buttonNews2BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNews2BackColor.Location = new System.Drawing.Point(399, 75);
            this.buttonNews2BackColor.Name = "buttonNews2BackColor";
            this.buttonNews2BackColor.Size = new System.Drawing.Size(102, 30);
            this.buttonNews2BackColor.TabIndex = 18;
            this.buttonNews2BackColor.Text = "Back Color";
            this.buttonNews2BackColor.UseVisualStyleBackColor = true;
            this.buttonNews2BackColor.Click += new System.EventHandler(this.buttonNews2BackColor_Click);
            // 
            // labelNews2Speed
            // 
            this.labelNews2Speed.AutoSize = true;
            this.labelNews2Speed.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews2Speed.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelNews2Speed.Location = new System.Drawing.Point(600, 112);
            this.labelNews2Speed.Name = "labelNews2Speed";
            this.labelNews2Speed.Size = new System.Drawing.Size(26, 29);
            this.labelNews2Speed.TabIndex = 21;
            this.labelNews2Speed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Direction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Speed";
            // 
            // buttonNews2TextStyle
            // 
            this.buttonNews2TextStyle.AutoSize = true;
            this.buttonNews2TextStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNews2TextStyle.Location = new System.Drawing.Point(507, 75);
            this.buttonNews2TextStyle.Name = "buttonNews2TextStyle";
            this.buttonNews2TextStyle.Size = new System.Drawing.Size(132, 30);
            this.buttonNews2TextStyle.TabIndex = 17;
            this.buttonNews2TextStyle.Text = "Font, Style, Size";
            this.buttonNews2TextStyle.UseVisualStyleBackColor = true;
            this.buttonNews2TextStyle.Click += new System.EventHandler(this.buttonNews2TextStyle_Click);
            // 
            // buttonNews2ForeColor
            // 
            this.buttonNews2ForeColor.AutoSize = true;
            this.buttonNews2ForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNews2ForeColor.Location = new System.Drawing.Point(298, 75);
            this.buttonNews2ForeColor.Name = "buttonNews2ForeColor";
            this.buttonNews2ForeColor.Size = new System.Drawing.Size(95, 30);
            this.buttonNews2ForeColor.TabIndex = 16;
            this.buttonNews2ForeColor.Text = "Fore Color";
            this.buttonNews2ForeColor.UseVisualStyleBackColor = true;
            this.buttonNews2ForeColor.Click += new System.EventHandler(this.buttonNews2ForeColor_Click);
            // 
            // trackBarNews2Speed
            // 
            this.trackBarNews2Speed.AutoSize = false;
            this.trackBarNews2Speed.BackColor = System.Drawing.Color.DarkGreen;
            this.trackBarNews2Speed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarNews2Speed.LargeChange = 1;
            this.trackBarNews2Speed.Location = new System.Drawing.Point(109, 111);
            this.trackBarNews2Speed.Maximum = 50;
            this.trackBarNews2Speed.Minimum = 1;
            this.trackBarNews2Speed.Name = "trackBarNews2Speed";
            this.trackBarNews2Speed.Size = new System.Drawing.Size(485, 33);
            this.trackBarNews2Speed.TabIndex = 19;
            this.trackBarNews2Speed.Value = 5;
            this.trackBarNews2Speed.Scroll += new System.EventHandler(this.trackBarNews2Speed_Scroll);
            // 
            // comboBoxNews2Direction
            // 
            this.comboBoxNews2Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNews2Direction.FormattingEnabled = true;
            this.comboBoxNews2Direction.Location = new System.Drawing.Point(109, 75);
            this.comboBoxNews2Direction.Name = "comboBoxNews2Direction";
            this.comboBoxNews2Direction.Size = new System.Drawing.Size(183, 26);
            this.comboBoxNews2Direction.TabIndex = 22;
            this.comboBoxNews2Direction.SelectedIndexChanged += new System.EventHandler(this.comboBoxNews2Direction_SelectedIndexChanged);
            // 
            // saDragControlSettingPanel
            // 
            this.saDragControlSettingPanel.SelectControl = this.panelSetting;
            this.saDragControlSettingPanel.SelectHandle = ShakikulFramework.SelectHandle.Selected;
            // 
            // timerSetting
            // 
            this.timerSetting.Interval = 1000;
            this.timerSetting.Tick += new System.EventHandler(this.timerSetting_Tick);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 712F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelNews, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxNewsImage, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 350);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(812, 70);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // tableLayoutPanelNews
            // 
            this.tableLayoutPanelNews.ColumnCount = 1;
            this.tableLayoutPanelNews.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelNews.Controls.Add(this.saScrollingLabelTextNews1, 0, 1);
            this.tableLayoutPanelNews.Controls.Add(this.saScrollingLabelTextNews2, 0, 0);
            this.tableLayoutPanelNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNews.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutPanelNews.Name = "tableLayoutPanelNews";
            this.tableLayoutPanelNews.RowCount = 2;
            this.tableLayoutPanelNews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelNews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelNews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNews.Size = new System.Drawing.Size(706, 64);
            this.tableLayoutPanelNews.TabIndex = 8;
            // 
            // saScrollingLabelTextNews1
            // 
            this.saScrollingLabelTextNews1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saScrollingLabelTextNews1.Location = new System.Drawing.Point(3, 32);
            this.saScrollingLabelTextNews1.Name = "saScrollingLabelTextNews1";
            this.saScrollingLabelTextNews1.ScrollDirection = ShakikulFramework.ScrollingTextEnum.LeftToRight;
            this.saScrollingLabelTextNews1.Size = new System.Drawing.Size(700, 32);
            this.saScrollingLabelTextNews1.TabIndex = 6;
            this.saScrollingLabelTextNews1.Text = "saScrollingLabelText1";
            this.saScrollingLabelTextNews1.UseCompatibleTextRendering = true;
            this.saScrollingLabelTextNews1.MouseHover += new System.EventHandler(this.pictureBoxNewsImage_MouseHover);
            // 
            // saScrollingLabelTextNews2
            // 
            this.saScrollingLabelTextNews2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saScrollingLabelTextNews2.Image = global::DisplayNewsPanel.Properties.Resources.Close;
            this.saScrollingLabelTextNews2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saScrollingLabelTextNews2.Location = new System.Drawing.Point(3, 0);
            this.saScrollingLabelTextNews2.Name = "saScrollingLabelTextNews2";
            this.saScrollingLabelTextNews2.ScrollDirection = ShakikulFramework.ScrollingTextEnum.RightToLeft;
            this.saScrollingLabelTextNews2.ScrollSpeed = 1;
            this.saScrollingLabelTextNews2.Size = new System.Drawing.Size(700, 32);
            this.saScrollingLabelTextNews2.TabIndex = 7;
            this.saScrollingLabelTextNews2.Text = resources.GetString("saScrollingLabelTextNews2.Text");
            this.saScrollingLabelTextNews2.UseCompatibleTextRendering = true;
            this.saScrollingLabelTextNews2.MouseHover += new System.EventHandler(this.pictureBoxNewsImage_MouseHover);
            // 
            // pictureBoxNewsImage
            // 
            this.pictureBoxNewsImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNewsImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxNewsImage.Name = "pictureBoxNewsImage";
            this.pictureBoxNewsImage.Size = new System.Drawing.Size(94, 64);
            this.pictureBoxNewsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNewsImage.TabIndex = 5;
            this.pictureBoxNewsImage.TabStop = false;
            this.pictureBoxNewsImage.MouseHover += new System.EventHandler(this.pictureBoxNewsImage_MouseHover);
            // 
            // pictureBoxSetting
            // 
            this.pictureBoxSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSetting.BackColor = System.Drawing.Color.White;
            this.pictureBoxSetting.Image = global::DisplayNewsPanel.Properties.Resources.Setting;
            this.pictureBoxSetting.Location = new System.Drawing.Point(732, 317);
            this.pictureBoxSetting.Name = "pictureBoxSetting";
            this.pictureBoxSetting.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSetting.TabIndex = 7;
            this.pictureBoxSetting.TabStop = false;
            this.pictureBoxSetting.Visible = false;
            this.pictureBoxSetting.Click += new System.EventHandler(this.pictureBoxSetting_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.BackColor = System.Drawing.Color.White;
            this.pictureBoxClose.Image = global::DisplayNewsPanel.Properties.Resources.Close;
            this.pictureBoxClose.Location = new System.Drawing.Point(768, 317);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 8;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Visible = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // NewsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 420);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBoxSetting);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsPanel";
            this.Text = "News Panel";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingPanelClose)).EndInit();
            this.tabControlSetting.ResumeLayout(false);
            this.tabPageNews1.ResumeLayout(false);
            this.tabPageNews1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNews1Speed)).EndInit();
            this.tabPageNews2.ResumeLayout(false);
            this.tabPageNews2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNews2Speed)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelNews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSetting;
        private ShakikulFramework.Toolbox.SADragControl saDragControlSettingPanel;
        private System.Windows.Forms.Timer timerSetting;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxNews1Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNews1ForeColor;
        private System.Windows.Forms.Button buttonNews1TextStyle;
        private System.Windows.Forms.Button buttonNews1BackColor;
        private System.Windows.Forms.TrackBar trackBarNews1Speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNews1Speed;
        private System.Windows.Forms.ComboBox comboBoxNews1Direction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxSettingPanelClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBoxNewsImage;
        private ShakikulFramework.SAScrollingLabelText saScrollingLabelTextNews1;
        private System.Windows.Forms.PictureBox pictureBoxSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNews;
        private System.Windows.Forms.TabControl tabControlSetting;
        private System.Windows.Forms.TabPage tabPageNewsPicture;
        private System.Windows.Forms.TabPage tabPageNews1;
        private System.Windows.Forms.TabPage tabPageNews2;
        private System.Windows.Forms.TextBox textBoxNews2Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNews2BackColor;
        private System.Windows.Forms.Label labelNews2Speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonNews2TextStyle;
        private System.Windows.Forms.Button buttonNews2ForeColor;
        private System.Windows.Forms.TrackBar trackBarNews2Speed;
        private System.Windows.Forms.ComboBox comboBoxNews2Direction;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private ShakikulFramework.SAScrollingLabelText saScrollingLabelTextNews2;
    }
}

