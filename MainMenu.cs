using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void cmbCarSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            int valx = cmbCarSelection.SelectedIndex;
            switch (valx)
            {
                case 0:
                    pbCarImage.Image = Image.FromFile("Images//m.jpg");
                    break;
                case 1:
                    pbCarImage.Image = imgCars.Images[2];
                    break;
                case 2:
                    pbCarImage.Image = imgCars.Images[5];
                    break;
                case 3:
                    pbCarImage.Image = imgCars.Images[4];
                    break;
                case 4:
                    pbCarImage.Image = imgCars.Images[0];
                    break;
                case 5:
                    pbCarImage.Image = imgCars.Images[1];
                    break;
                default:
                    break;
            }
        }



        private void cmbPickUp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cmbDropOff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dtPickUp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtDropOff_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cmbCarSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbCarImage_Click(object sender, EventArgs e)
        {

        }
    }
}
