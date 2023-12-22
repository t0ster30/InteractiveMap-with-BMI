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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void path1button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "Красная площадь";
            drinksStand.Visible = true; drinkStandLabel.Visible = true;
            energyBarStand.Visible = true; energybarStandLabel.Visible = true;
            waterClosetStand.Visible = false; waterClosetLabel.Visible = false;
            infoStand.Visible = false; infoStandLabel.Visible = false;
            pharmacyStand.Visible = false; pharmacyStandLabel.Visible = false;
        }
        private void path2button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "Парк Зарядье";
            drinksStand.Visible = true; drinkStandLabel.Visible = true;
            energyBarStand.Visible = true; energybarStandLabel.Visible = true;
            waterClosetStand.Visible = true; waterClosetLabel.Visible = true;
            infoStand.Visible = true; infoStandLabel.Visible = true;
            pharmacyStand.Visible = true; pharmacyStandLabel.Visible = true;
        }
        private void path3button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "Авиапарк";
            drinksStand.Visible = true; drinkStandLabel.Visible = true;
            energyBarStand.Visible = true; energybarStandLabel.Visible = true;
            waterClosetStand.Visible = true; waterClosetLabel.Visible = true;
            infoStand.Visible = false; infoStandLabel.Visible = false;
            pharmacyStand.Visible = false; pharmacyStandLabel.Visible = false;
        }
        private void path4button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "ВДНХ";
            drinksStand.Visible = false; drinkStandLabel.Visible = false;
            energyBarStand.Visible = true; energybarStandLabel.Visible = true;
            waterClosetStand.Visible = true; waterClosetLabel.Visible = true;
            infoStand.Visible = false; infoStandLabel.Visible = false;
            pharmacyStand.Visible = false; pharmacyStandLabel.Visible = false;
        }
        private void path5button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "Парк Горького";
            drinksStand.Visible = false; drinkStandLabel.Visible = false;
            energyBarStand.Visible = false; energybarStandLabel.Visible = false;
            waterClosetStand.Visible = true; waterClosetLabel.Visible = true;
            infoStand.Visible = true; infoStandLabel.Visible = true;
            pharmacyStand.Visible = true; pharmacyStandLabel.Visible = true;
        }
        private void path6button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "Александровский парк";
            drinksStand.Visible = true; drinkStandLabel.Visible = true;
            energyBarStand.Visible = true; energybarStandLabel.Visible = true;
            waterClosetStand.Visible = true; waterClosetLabel.Visible = true;
            infoStand.Visible = true; infoStandLabel.Visible = true;
            pharmacyStand.Visible = true; pharmacyStandLabel.Visible = true;
        }
        private void path7button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "Патриаршие пруды";
            drinksStand.Visible = true; drinkStandLabel.Visible = true;
            energyBarStand.Visible = true; energybarStandLabel.Visible = true;
            waterClosetStand.Visible = true; waterClosetLabel.Visible = true;
            infoStand.Visible = true; infoStandLabel.Visible = true;
            pharmacyStand.Visible = true; pharmacyStandLabel.Visible = true;
        }
        private void path8button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "МФЮА (метро Калужская)";
            drinksStand.Visible = true; drinkStandLabel.Visible = true;
            energyBarStand.Visible = true; energybarStandLabel.Visible = true;
            waterClosetStand.Visible = true; waterClosetLabel.Visible = true;
            infoStand.Visible = true; infoStandLabel.Visible = true;
            pharmacyStand.Visible = true; pharmacyStandLabel.Visible = true;
        }

        private void toBMICalc_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.ShowDialog();
        }
        private void start1button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "Марафон на 70 километров";
            drinksStand.Visible = false; drinkStandLabel.Visible = false;
            energyBarStand.Visible = false; energybarStandLabel.Visible = false;
            infoStand.Visible = false; infoStandLabel.Visible = false;
            waterClosetStand.Visible = false; waterClosetLabel.Visible = false;
            pharmacyStand.Visible = false; pharmacyStandLabel.Visible = false;
        }
        private void start2button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "Марафон на 45 километров";
            drinksStand.Visible = false; drinkStandLabel.Visible = false;
            energyBarStand.Visible = false; energybarStandLabel.Visible = false;
            infoStand.Visible = false; infoStandLabel.Visible = false;
            waterClosetStand.Visible = false; waterClosetLabel.Visible = false;
            pharmacyStand.Visible = false; pharmacyStandLabel.Visible = false;
        }
        private void start3button_Click(object sender, EventArgs e)
        {
            placeOfRunpath.Text = "Марафон на 20 километров";
            drinksStand.Visible = false; drinkStandLabel.Visible = false;
            energyBarStand.Visible = false; energybarStandLabel.Visible = false;
            infoStand.Visible = false; infoStandLabel.Visible = false;
            waterClosetStand.Visible = false; waterClosetLabel.Visible = false;
            pharmacyStand.Visible = false; pharmacyStandLabel.Visible = false;
        }
    }
}
