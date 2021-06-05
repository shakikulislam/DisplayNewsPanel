using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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

            labelSpeed.Text = trackBarSpeed.Value.ToString();
            saScrollingLabelText1.ScrollSpeed = trackBarSpeed.Value;

            DirectionList();
            LoadSetting();
            

        }

        private void LoadSetting()
        {
            textBoxNewsText.Text = Settings.Default.NewsText;
            comboBoxDirection.Text = Settings.Default.Direction;
            buttonForeColor.ForeColor = Settings.Default.ForeColor;
            buttonBackColor.ForeColor = Settings.Default.ForeColor;
            buttonForeColor.BackColor = Settings.Default.BackColor;
            buttonBackColor.BackColor = Settings.Default.BackColor;
            trackBarSpeed.Value = Settings.Default.Speed;
            labelSpeed.Text = Settings.Default.Speed.ToString();

            SetDirection();
            saScrollingLabelText1.Text = Settings.Default.NewsText;
            saScrollingLabelText1.ForeColor = Settings.Default.ForeColor;
            saScrollingLabelText1.BackColor = Settings.Default.BackColor;
            saScrollingLabelText1.Font = Settings.Default.Font;
            saScrollingLabelText1.ScrollSpeed = Settings.Default.Speed;

        }

        private void DirectionList()
        {
            comboBoxDirection.Items.Add("None");
            comboBoxDirection.Items.Add("Left To Right");
            comboBoxDirection.Items.Add("Right To Left");

            //if (saScrollingLabelText1.ScrollDirection == ScrollingTextEnum.None)
            //    comboBoxDirection.Text = "None";

            //if (saScrollingLabelText1.ScrollDirection == ScrollingTextEnum.LeftToRight)
            //    comboBoxDirection.Text = "Left To Right";

            //if (saScrollingLabelText1.ScrollDirection == ScrollingTextEnum.RightToLeft)
            //    comboBoxDirection.Text = "Right To Left";
        }

        private void SetDirection()
        {
            if (comboBoxDirection.Text == "None")
                saScrollingLabelText1.ScrollDirection = ScrollingTextEnum.None;

            if (comboBoxDirection.Text == "Left To Right")
                saScrollingLabelText1.ScrollDirection = ScrollingTextEnum.LeftToRight;

            if (comboBoxDirection.Text == "Right To Left")
                saScrollingLabelText1.ScrollDirection = ScrollingTextEnum.RightToLeft;
        }
        
        private void buttonSetting_Click(object sender, EventArgs e)
        {
            
            panelSetting.Visible = true;
        }
        
        private int _count;
        private void timerSetting_Tick(object sender, EventArgs e)
        {
            _count += 1;
            if (_count>10)
            {
                _count = 0;
                buttonSetting.Visible = false;

                timerSetting.Stop();
            }
        }

        private void textBoxNewsText_TextChanged(object sender, EventArgs e)
        {
            saScrollingLabelText1.Text = textBoxNewsText.Text;

            // Save Setting
            Settings.Default.NewsText = textBoxNewsText.Text;
            Settings.Default.Save();
        }

        private void buttonForeColor_Click(object sender, EventArgs e)
        {
            _colorDialog=new ColorDialog{Color= saScrollingLabelText1.ForeColor};
            _colorDialog.Color = saScrollingLabelText1.ForeColor;
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonForeColor.ForeColor = _colorDialog.Color;
                buttonBackColor.ForeColor = _colorDialog.Color;

                saScrollingLabelText1.ForeColor = _colorDialog.Color;
                
                // Save Setting
                Settings.Default.ForeColor = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void buttonTextStyle_Click(object sender, EventArgs e)
        {
            _fontDialog=new FontDialog {Font = saScrollingLabelText1.Font};

            if (_fontDialog.ShowDialog() == DialogResult.OK)
            {
                saScrollingLabelText1.Font = _fontDialog.Font;

                // Save Setting
                Settings.Default.Font = _fontDialog.Font;
                Settings.Default.Save();
            }
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            _colorDialog = new ColorDialog {Color = saScrollingLabelText1.BackColor};
            if (_colorDialog.ShowDialog()==DialogResult.OK)
            {
                buttonForeColor.BackColor = _colorDialog.Color;
                buttonBackColor.BackColor = _colorDialog.Color;

                saScrollingLabelText1.BackColor = _colorDialog.Color;

                // Save Setting
                Settings.Default.BackColor = _colorDialog.Color;
                Settings.Default.Save();
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            labelSpeed.Text = trackBarSpeed.Value.ToString();
            saScrollingLabelText1.ScrollSpeed = trackBarSpeed.Value;

            // Save Setting
            Settings.Default.Speed = trackBarSpeed.Value;
            Settings.Default.Save();
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save Setting
            Settings.Default.Direction = comboBoxDirection.Text;
            Settings.Default.Save();

            SetDirection();
        }

        private void pictureBoxSettingPanelClose_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = false;
        }

        private void tableLayoutPanelMain_MouseHover_1(object sender, EventArgs e)
        {
            buttonSetting.Visible = true;
            timerSetting.Start();
        }




    }
}
