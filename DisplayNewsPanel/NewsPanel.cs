using System;
using System.Drawing;
using System.Windows.Forms;
using DisplayNewsPanel.Properties;
using ShakikulFramework;
using ShakikulFramework.Toolbox;

namespace DisplayNewsPanel
{
    public partial class NewsPanel : Form
    {

        private ColorDialog _colorDialog;
        private FontDialog _fontDialog;

        public NewsPanel()
        {
            InitializeComponent();

            DirectionList(comboBoxNews1Direction);
            DirectionList(comboBoxNews2Direction);

            LoadSetting();

            this.TopMost = true;
        }

        private void LoadSetting()
        {
            #region Newsline 1

            textBoxNews1Text.Text = Settings.Default.NewsText1;
            comboBoxNews1Direction.Text = Settings.Default.Direction1;
            buttonNews1ForeColor.ForeColor = Settings.Default.ForeColor1;
            buttonNews1BackColor.ForeColor = Settings.Default.ForeColor1;
            buttonNews1ForeColor.BackColor = Settings.Default.BackColor1;
            buttonNews1BackColor.BackColor = Settings.Default.BackColor1;
            trackBarNews1Speed.Value = Settings.Default.Speed1;
            labelNews1Speed.Text = Settings.Default.Speed1.ToString();

            SetDirection(comboBoxNews1Direction, saScrollingLabelNews1);

            saScrollingLabelNews1.Text = Settings.Default.NewsText1;
            saScrollingLabelNews1.ForeColor = Settings.Default.ForeColor1;
            saScrollingLabelNews1.BackColor = Settings.Default.BackColor1;
            saScrollingLabelNews1.Font = Settings.Default.Font1;
            saScrollingLabelNews1.ScrollSpeed = Settings.Default.Speed1;

            checkBoxNews1BackColor.Checked = Settings.Default.TransparentBackColor1;
            buttonNews1BackColor.Enabled=Settings.Default.TransparentBackColor1;

            #endregion

            #region Newsline 2

            textBoxNews2Text.Text = Settings.Default.NewsText2;
            comboBoxNews2Direction.Text = Settings.Default.Direction2;
            buttonNews2ForeColor.ForeColor = Settings.Default.ForeColor2;
            buttonNews2BackColor.ForeColor = Settings.Default.ForeColor2;
            buttonNews2ForeColor.BackColor = Settings.Default.BackColor2;
            buttonNews2BackColor.BackColor = Settings.Default.BackColor2;
            trackBarNews2Speed.Value = Settings.Default.Speed2;
            labelNews2Speed.Text = Settings.Default.Speed2.ToString();

            SetDirection(comboBoxNews2Direction, saScrollingLabelNews2);

            saScrollingLabelNews2.Text = Settings.Default.NewsText2;
            saScrollingLabelNews2.ForeColor = Settings.Default.ForeColor2;
            saScrollingLabelNews2.BackColor = Settings.Default.BackColor2;
            saScrollingLabelNews2.Font = Settings.Default.Font2;
            saScrollingLabelNews2.ScrollSpeed = Settings.Default.Speed2;

            checkBoxNews2BackColor.Checked = Settings.Default.TransparentBackColor2;
            buttonNews2BackColor.Enabled=Settings.Default.TransparentBackColor2;

            #endregion

            SetNewsLineLocationY();
        }

        private void SetNewsLineLocationY()
        {
            saScrollingLabelNews1.Location = new Point(saScrollingLabelNews1.Location.X,
                this.Height - saScrollingLabelNews1.Height);
            saScrollingLabelNews2.Location = new Point(saScrollingLabelNews2.Location.X,
                this.Height - (saScrollingLabelNews1.Height + saScrollingLabelNews2.Height));

            //..Set PanelSettingButton location
            panelSettingButton.Location = new Point(this.Width - panelSettingButton.Width,
                this.Height - saScrollingLabelNews1.Height - saScrollingLabelNews2.Height -panelSettingButton.Height);
        }

        private void DirectionList(ComboBox comboBox)
        {
            comboBox.Items.Add("None");
            comboBox.Items.Add("Left To Right");
            comboBox.Items.Add("Right To Left");

            //if (saScrollingLabelText1.ScrollDirection == ScrollingTextEnum.None)
            //    comboBoxDirection.Text = "None";

            //if (saScrollingLabelText1.ScrollDirection == ScrollingTextEnum.LeftToRight)
            //    comboBoxDirection.Text = "Left To Right";

            //if (saScrollingLabelText1.ScrollDirection == ScrollingTextEnum.RightToLeft)
            //    comboBoxDirection.Text = "Right To Left";
        }

        private void SetDirection(ComboBox comboBox, SAScrollingLabel label)
        {
            if (comboBox.Text == "None")
                label.ScrollDirection = ScrollingTextEnum.None;

            if (comboBox.Text == "Left To Right")
                label.ScrollDirection = ScrollingTextEnum.LeftToRight;

            if (comboBox.Text == "Right To Left")
                label.ScrollDirection = ScrollingTextEnum.RightToLeft;
        }
        
        private int _count;
        private void timerSetting_Tick(object sender, EventArgs e)
        {
            _count += 1;
            if (_count>10)
            {
                _count = 0;
                panelSettingButton.Visible = false;

                timerSetting.Stop();
            }
        }

        private void textBoxNewsText_TextChanged(object sender, EventArgs e)
        {
            saScrollingLabelNews1.Text = textBoxNews1Text.Text;

            // Save Setting
            Settings.Default.NewsText1 = textBoxNews1Text.Text;
            Settings.Default.Save();
        }

        private void buttonForeColor_Click(object sender, EventArgs e)
        {
            _colorDialog=new ColorDialog{Color= saScrollingLabelNews1.ForeColor};
            _colorDialog.Color = saScrollingLabelNews1.ForeColor;
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonNews1ForeColor.ForeColor = _colorDialog.Color;
                buttonNews1BackColor.ForeColor = _colorDialog.Color;

                saScrollingLabelNews1.ForeColor = _colorDialog.Color;
                
                // Save Setting
                Settings.Default.ForeColor1 = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void buttonTextStyle_Click(object sender, EventArgs e)
        {
            _fontDialog=new FontDialog {Font = saScrollingLabelNews1.Font};
            
            if (_fontDialog.ShowDialog() == DialogResult.OK)
            {
                saScrollingLabelNews1.Font = _fontDialog.Font;

                SetNewsLineLocationY();

                // Save Setting
                Settings.Default.Font1 = _fontDialog.Font;
                Settings.Default.Save();
            }
        }
        
        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            _colorDialog = new ColorDialog {Color = saScrollingLabelNews1.BackColor};
            if (_colorDialog.ShowDialog()==DialogResult.OK)
            {
                buttonNews1ForeColor.BackColor = _colorDialog.Color;
                buttonNews1BackColor.BackColor = _colorDialog.Color;

                saScrollingLabelNews1.BackColor = _colorDialog.Color;

                // Save Setting
                Settings.Default.BackColor1 = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            labelNews1Speed.Text = trackBarNews1Speed.Value.ToString();
            saScrollingLabelNews1.ScrollSpeed = trackBarNews1Speed.Value;

            // Save Setting
            Settings.Default.Speed1 = trackBarNews1Speed.Value;
            Settings.Default.Save();
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save Setting
            Settings.Default.Direction1 = comboBoxNews1Direction.Text;
            Settings.Default.Save();

            SetDirection(comboBoxNews1Direction,saScrollingLabelNews1);
        }

        private void pictureBoxSettingPanelClose_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = false;
        }
        
        private void pictureBoxSetting_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = true;
        }
        
        private void textBoxNews2Text_TextChanged(object sender, EventArgs e)
        {
            saScrollingLabelNews2.Text = textBoxNews2Text.Text;

            // Save Setting
            Settings.Default.NewsText2 = textBoxNews2Text.Text;
            Settings.Default.Save();
        }

        private void comboBoxNews2Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save Setting
            Settings.Default.Direction2 = comboBoxNews2Direction.Text;
            Settings.Default.Save();

            SetDirection(comboBoxNews2Direction,saScrollingLabelNews2);
        }

        private void buttonNews2ForeColor_Click(object sender, EventArgs e)
        {
            _colorDialog = new ColorDialog { Color = saScrollingLabelNews2.ForeColor };
            _colorDialog.Color = saScrollingLabelNews2.ForeColor;
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonNews2ForeColor.ForeColor = _colorDialog.Color;
                buttonNews2BackColor.ForeColor = _colorDialog.Color;

                saScrollingLabelNews2.ForeColor = _colorDialog.Color;

                // Save Setting
                Settings.Default.ForeColor2 = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void buttonNews2BackColor_Click(object sender, EventArgs e)
        {
            _colorDialog = new ColorDialog { Color = saScrollingLabelNews2.BackColor };
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonNews2ForeColor.BackColor = _colorDialog.Color;
                buttonNews2BackColor.BackColor = _colorDialog.Color;

                saScrollingLabelNews2.BackColor = _colorDialog.Color;

                // Save Setting
                Settings.Default.BackColor2 = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void buttonNews2TextStyle_Click(object sender, EventArgs e)
        {
            _fontDialog = new FontDialog { Font = saScrollingLabelNews2.Font };

            if (_fontDialog.ShowDialog() == DialogResult.OK)
            {
                saScrollingLabelNews2.Font = _fontDialog.Font;

                SetNewsLineLocationY();

                // Save Setting
                Settings.Default.Font2 = _fontDialog.Font;
                Settings.Default.Save();
            }
        }

        private void trackBarNews2Speed_Scroll(object sender, EventArgs e)
        {
            labelNews2Speed.Text = trackBarNews2Speed.Value.ToString();
            saScrollingLabelNews2.ScrollSpeed = trackBarNews2Speed.Value;

            // Save Setting
            Settings.Default.Speed2 = trackBarNews2Speed.Value;
            Settings.Default.Save();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saScrollingLabelNews2_MouseHover(object sender, EventArgs e)
        {
            panelSettingButton.Visible = true;
            timerSetting.Start();
        }

        private void saScrollingLabelNews1_MouseHover(object sender, EventArgs e)
        {
            panelSettingButton.Visible = true;
            timerSetting.Start();
        }

        private void checkBoxNews2BackColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNews2BackColor.Checked)
            {
                saScrollingLabelNews2.BackColor = Settings.Default.BackColor2;
                buttonNews2BackColor.Enabled = true;
                Settings.Default.TransparentBackColor2 = true;
                Settings.Default.Save();
            }
            else
            {
                saScrollingLabelNews2.BackColor = SystemColors.Control;
                buttonNews2BackColor.Enabled = false;
                Settings.Default.TransparentBackColor2 = false;
                Settings.Default.Save();
            }
                
        }

        private void checkBoxNews1BackColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNews1BackColor.Checked)
            {
                saScrollingLabelNews1.BackColor = Settings.Default.BackColor1;
                buttonNews1BackColor.Enabled = true;
                Settings.Default.TransparentBackColor1 = true;
                Settings.Default.Save();
            }
            else
            {
                saScrollingLabelNews1.BackColor = SystemColors.Control;
                buttonNews1BackColor.Enabled = false;
                Settings.Default.TransparentBackColor1 = false;
                Settings.Default.Save();
            }
        }




    }
}
