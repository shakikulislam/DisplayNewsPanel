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
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.buttonTextStyle = new System.Windows.Forms.Button();
            this.buttonForeColor = new System.Windows.Forms.Button();
            this.textBoxNewsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saDragControl1 = new ShakikulFramework.Toolbox.SADragControl();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.timerSetting = new System.Windows.Forms.Timer(this.components);
            this.saDragControl2 = new ShakikulFramework.Toolbox.SADragControl();
            this.pictureBoxSettingPanelClose = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saScrollingLabelText1 = new ShakikulFramework.SAScrollingLabelText();
            this.panelSetting.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingPanelClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSetting.Controls.Add(this.panelTitle);
            this.panelSetting.Controls.Add(this.label4);
            this.panelSetting.Controls.Add(this.comboBoxDirection);
            this.panelSetting.Controls.Add(this.labelSpeed);
            this.panelSetting.Controls.Add(this.label3);
            this.panelSetting.Controls.Add(this.trackBarSpeed);
            this.panelSetting.Controls.Add(this.buttonBackColor);
            this.panelSetting.Controls.Add(this.buttonTextStyle);
            this.panelSetting.Controls.Add(this.buttonForeColor);
            this.panelSetting.Controls.Add(this.textBoxNewsText);
            this.panelSetting.Controls.Add(this.label2);
            this.panelSetting.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSetting.Location = new System.Drawing.Point(75, 23);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(674, 253);
            this.panelSetting.TabIndex = 2;
            this.panelSetting.Visible = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Controls.Add(this.pictureBoxSettingPanelClose);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(674, 36);
            this.panelTitle.TabIndex = 14;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(75, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Setting";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Direction";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(98, 88);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(183, 26);
            this.comboBoxDirection.TabIndex = 12;
            this.comboBoxDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirection_SelectedIndexChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSpeed.Location = new System.Drawing.Point(622, 128);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(26, 29);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.AutoSize = false;
            this.trackBarSpeed.BackColor = System.Drawing.Color.DarkGreen;
            this.trackBarSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSpeed.LargeChange = 1;
            this.trackBarSpeed.Location = new System.Drawing.Point(98, 124);
            this.trackBarSpeed.Maximum = 50;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(518, 33);
            this.trackBarSpeed.TabIndex = 6;
            this.trackBarSpeed.Value = 5;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.AutoSize = true;
            this.buttonBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackColor.Location = new System.Drawing.Point(420, 88);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(102, 30);
            this.buttonBackColor.TabIndex = 5;
            this.buttonBackColor.Text = "Back Color";
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // buttonTextStyle
            // 
            this.buttonTextStyle.AutoSize = true;
            this.buttonTextStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextStyle.Location = new System.Drawing.Point(528, 88);
            this.buttonTextStyle.Name = "buttonTextStyle";
            this.buttonTextStyle.Size = new System.Drawing.Size(132, 30);
            this.buttonTextStyle.TabIndex = 4;
            this.buttonTextStyle.Text = "Font, Style, Size";
            this.buttonTextStyle.UseVisualStyleBackColor = true;
            this.buttonTextStyle.Click += new System.EventHandler(this.buttonTextStyle_Click);
            // 
            // buttonForeColor
            // 
            this.buttonForeColor.AutoSize = true;
            this.buttonForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForeColor.Location = new System.Drawing.Point(319, 88);
            this.buttonForeColor.Name = "buttonForeColor";
            this.buttonForeColor.Size = new System.Drawing.Size(95, 30);
            this.buttonForeColor.TabIndex = 3;
            this.buttonForeColor.Text = "Fore Color";
            this.buttonForeColor.UseVisualStyleBackColor = true;
            this.buttonForeColor.Click += new System.EventHandler(this.buttonForeColor_Click);
            // 
            // textBoxNewsText
            // 
            this.textBoxNewsText.Location = new System.Drawing.Point(98, 56);
            this.textBoxNewsText.Name = "textBoxNewsText";
            this.textBoxNewsText.Size = new System.Drawing.Size(562, 26);
            this.textBoxNewsText.TabIndex = 2;
            this.textBoxNewsText.TextChanged += new System.EventHandler(this.textBoxNewsText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "News";
            // 
            // saDragControl1
            // 
            this.saDragControl1.SelectControl = this.panelSetting;
            this.saDragControl1.SelectHandle = ShakikulFramework.SelectHandle.Selected;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetting.BackColor = System.Drawing.Color.Red;
            this.buttonSetting.Location = new System.Drawing.Point(751, 302);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(49, 45);
            this.buttonSetting.TabIndex = 3;
            this.buttonSetting.Text = "S";
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Visible = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // timerSetting
            // 
            this.timerSetting.Interval = 1000;
            this.timerSetting.Tick += new System.EventHandler(this.timerSetting_Tick);
            // 
            // saDragControl2
            // 
            this.saDragControl2.SelectControl = this.panelTitle;
            this.saDragControl2.SelectHandle = ShakikulFramework.SelectHandle.Selected;
            // 
            // pictureBoxSettingPanelClose
            // 
            this.pictureBoxSettingPanelClose.BackColor = System.Drawing.Color.Black;
            this.pictureBoxSettingPanelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxSettingPanelClose.Location = new System.Drawing.Point(638, 0);
            this.pictureBoxSettingPanelClose.Name = "pictureBoxSettingPanelClose";
            this.pictureBoxSettingPanelClose.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxSettingPanelClose.TabIndex = 4;
            this.pictureBoxSettingPanelClose.TabStop = false;
            this.pictureBoxSettingPanelClose.Click += new System.EventHandler(this.pictureBoxSettingPanelClose_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 350);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(812, 70);
            this.tableLayoutPanelMain.TabIndex = 4;
            this.tableLayoutPanelMain.MouseHover += new System.EventHandler(this.tableLayoutPanelMain_MouseHover_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // saScrollingLabelText1
            // 
            this.saScrollingLabelText1.AutoSize = true;
            this.saScrollingLabelText1.Location = new System.Drawing.Point(184, 302);
            this.saScrollingLabelText1.Name = "saScrollingLabelText1";
            this.saScrollingLabelText1.Size = new System.Drawing.Size(116, 17);
            this.saScrollingLabelText1.TabIndex = 6;
            this.saScrollingLabelText1.Text = "saScrollingLabelText1";
            this.saScrollingLabelText1.UseCompatibleTextRendering = true;
            // 
            // NewsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 420);
            this.Controls.Add(this.saScrollingLabelText1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.panelSetting);
            this.Name = "NewsPanel";
            this.Text = "News Panel";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingPanelClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSetting;
        private ShakikulFramework.Toolbox.SADragControl saDragControl1;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Timer timerSetting;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxNewsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonForeColor;
        private System.Windows.Forms.Button buttonTextStyle;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.Label label4;
        private ShakikulFramework.Toolbox.SADragControl saDragControl2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBoxSettingPanelClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ShakikulFramework.SAScrollingLabelText saScrollingLabelText1;
    }
}

