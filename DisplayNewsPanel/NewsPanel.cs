using System;
using System.Windows.Forms;
using DisplayNewsPanel.Properties;
using ShakikulFramework;

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

            SetDirection(comboBoxNews1Direction, saScrollingLabelTextNews1);

            saScrollingLabelTextNews1.Text = Settings.Default.NewsText1;
            saScrollingLabelTextNews1.ForeColor = Settings.Default.ForeColor1;
            saScrollingLabelTextNews1.BackColor = Settings.Default.BackColor1;
            saScrollingLabelTextNews1.Font = Settings.Default.Font1;
            saScrollingLabelTextNews1.ScrollSpeed = Settings.Default.Speed1;

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

            SetDirection(comboBoxNews2Direction, saScrollingLabelTextNews2);

            saScrollingLabelTextNews2.Text = Settings.Default.NewsText2;
            saScrollingLabelTextNews2.ForeColor = Settings.Default.ForeColor2;
            saScrollingLabelTextNews2.BackColor = Settings.Default.BackColor2;
            saScrollingLabelTextNews2.Font = Settings.Default.Font2;
            saScrollingLabelTextNews2.ScrollSpeed = Settings.Default.Speed2;

            #endregion


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

        private void SetDirection(ComboBox comboBox, SAScrollingLabelText label)
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
                pictureBoxSetting.Visible = false;

                timerSetting.Stop();
            }
        }

        private void textBoxNewsText_TextChanged(object sender, EventArgs e)
        {
            saScrollingLabelTextNews1.Text = textBoxNews1Text.Text;

            // Save Setting
            Settings.Default.NewsText1 = textBoxNews1Text.Text;
            Settings.Default.Save();
        }

        private void buttonForeColor_Click(object sender, EventArgs e)
        {
            _colorDialog=new ColorDialog{Color= saScrollingLabelTextNews1.ForeColor};
            _colorDialog.Color = saScrollingLabelTextNews1.ForeColor;
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonNews1ForeColor.ForeColor = _colorDialog.Color;
                buttonNews1BackColor.ForeColor = _colorDialog.Color;

                saScrollingLabelTextNews1.ForeColor = _colorDialog.Color;
                
                // Save Setting
                Settings.Default.ForeColor1 = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void buttonTextStyle_Click(object sender, EventArgs e)
        {
            _fontDialog=new FontDialog {Font = saScrollingLabelTextNews1.Font};

            if (_fontDialog.ShowDialog() == DialogResult.OK)
            {
                saScrollingLabelTextNews1.Font = _fontDialog.Font;

                // Save Setting
                Settings.Default.Font1 = _fontDialog.Font;
                Settings.Default.Save();
            }
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            _colorDialog = new ColorDialog {Color = saScrollingLabelTextNews1.BackColor};
            if (_colorDialog.ShowDialog()==DialogResult.OK)
            {
                buttonNews1ForeColor.BackColor = _colorDialog.Color;
                buttonNews1BackColor.BackColor = _colorDialog.Color;

                saScrollingLabelTextNews1.BackColor = _colorDialog.Color;

                // Save Setting
                Settings.Default.BackColor1 = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            labelNews1Speed.Text = trackBarNews1Speed.Value.ToString();
            saScrollingLabelTextNews1.ScrollSpeed = trackBarNews1Speed.Value;

            // Save Setting
            Settings.Default.Speed1 = trackBarNews1Speed.Value;
            Settings.Default.Save();
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save Setting
            Settings.Default.Direction1 = comboBoxNews1Direction.Text;
            Settings.Default.Save();

            SetDirection(comboBoxNews1Direction,saScrollingLabelTextNews1);
        }

        private void pictureBoxSettingPanelClose_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = false;
        }

        private void tableLayoutPanelMain_MouseHover_1(object sender, EventArgs e)
        {
            pictureBoxSetting.Visible = true;
            timerSetting.Start();
        }
        
        private void pictureBoxSetting_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = true;
        }

        private void pictureBoxNewsImage_MouseHover(object sender, EventArgs e)
        {
            pictureBoxSetting.Visible = true;
            timerSetting.Start();
        }

        private void textBoxNews2Text_TextChanged(object sender, EventArgs e)
        {
            saScrollingLabelTextNews2.Text = textBoxNews2Text.Text;

            // Save Setting
            Settings.Default.NewsText2 = textBoxNews2Text.Text;
            Settings.Default.Save();
        }

        private void comboBoxNews2Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save Setting
            Settings.Default.Direction2 = comboBoxNews2Direction.Text;
            Settings.Default.Save();

            SetDirection(comboBoxNews2Direction,saScrollingLabelTextNews2);
        }

        private void buttonNews2ForeColor_Click(object sender, EventArgs e)
        {
            _colorDialog = new ColorDialog { Color = saScrollingLabelTextNews2.ForeColor };
            _colorDialog.Color = saScrollingLabelTextNews2.ForeColor;
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonNews2ForeColor.ForeColor = _colorDialog.Color;
                buttonNews2BackColor.ForeColor = _colorDialog.Color;

                saScrollingLabelTextNews2.ForeColor = _colorDialog.Color;

                // Save Setting
                Settings.Default.ForeColor2 = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void buttonNews2BackColor_Click(object sender, EventArgs e)
        {
            _colorDialog = new ColorDialog { Color = saScrollingLabelTextNews2.BackColor };
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonNews2ForeColor.BackColor = _colorDialog.Color;
                buttonNews2BackColor.BackColor = _colorDialog.Color;

                saScrollingLabelTextNews2.BackColor = _colorDialog.Color;

                // Save Setting
                Settings.Default.BackColor2 = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void buttonNews2TextStyle_Click(object sender, EventArgs e)
        {
            _fontDialog = new FontDialog { Font = saScrollingLabelTextNews2.Font };

            if (_fontDialog.ShowDialog() == DialogResult.OK)
            {
                saScrollingLabelTextNews2.Font = _fontDialog.Font;

                // Save Setting
                Settings.Default.Font2 = _fontDialog.Font;
                Settings.Default.Save();
            }
        }

        private void trackBarNews2Speed_Scroll(object sender, EventArgs e)
        {
            labelNews2Speed.Text = trackBarNews2Speed.Value.ToString();
            saScrollingLabelTextNews2.ScrollSpeed = trackBarNews2Speed.Value;

            // Save Setting
            Settings.Default.Speed2 = trackBarNews2Speed.Value;
            Settings.Default.Save();
        }




    }
}
