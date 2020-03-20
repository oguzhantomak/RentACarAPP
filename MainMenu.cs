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
                    pbCarImage.Image = imgCars.Images[3];
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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            DateTime pDate = dtPickUp.Value;
            DateTime dDate = dtDropOff.Value;
            TimeSpan day = dDate - pDate;
            int aralik = Convert.ToInt32(day.TotalDays)+1;

            if (cmbCarSelection.SelectedIndex==0)
            {
                int a180 = 250;
                lblTotalCost.Text =(a180 * aralik).ToString()+"TL";
                lblTotalDays.Text = aralik.ToString() + "GÜN";
            }
            else if (cmbCarSelection.SelectedIndex==1)
            {
                int i10 = 135;
                lblTotalCost.Text = (i10 * aralik).ToString() + "TL";
                lblTotalDays.Text = aralik.ToString() + "GÜN";
            }
            else if (cmbCarSelection.SelectedIndex==2)
            {
                int vwPolo = 175;
                lblTotalCost.Text = (vwPolo * aralik).ToString() + "TL";
                lblTotalDays.Text = aralik.ToString() + "GÜN";
            }
            else if (true)
            {

            }
        }
    }
}
