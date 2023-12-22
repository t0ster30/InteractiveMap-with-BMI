using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalc03PRd4310Styopkin
{
    public partial class Form1 : Form
    {
        int BMIIndex;
        bool sex;
        public Form1()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            humanHeight.Clear();
            humanWeight.Clear();
        }

        private void man_Click(object sender, EventArgs e)
        {
            currentSex.Image = Properties.Resources.male_icon;
            sex = true;
        }

        private void woman_Click(object sender, EventArgs e)
        {
            currentSex.Image = Properties.Resources.female_icon;
            sex = false;
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            double userWeight = Convert.ToDouble(humanWeight.Text);
            double userHeight = Convert.ToDouble(humanHeight.Text) / 100;

            BMIIndex = Convert.ToInt32(Math.Round(userWeight / (userHeight * userHeight),2));
            curBMI.Text = Convert.ToString(BMIIndex);
            
            if (BMIIndex < 10)
            {
                bmiStatus.Text = "Недостаточный";
                bmiTrack.Value = 10;
            }

            if (BMIIndex < 18.5)
            {
                bmiStatus.Text = "Недостаточный";
                bmiTrack.Value = BMIIndex;
            }
            if ((BMIIndex >= 18.5) && (BMIIndex <=24.9))
            {
                bmiStatus.Text = "Здоровый";
                bmiTrack.Value = BMIIndex;
            }
            if ((BMIIndex >= 25) && (BMIIndex < 29.9))
            {
                bmiStatus.Text = "Избыточный";
                bmiTrack.Value = BMIIndex;
            }
            if ((BMIIndex > 30) && (BMIIndex <= 40))
            {
                bmiStatus.Text = "Ожирение";
                bmiTrack.Value = BMIIndex;
            }
            if (BMIIndex > 40)
            {
                bmiStatus.Text = "Ожирение";
                bmiTrack.Value = 40;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toMap_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
