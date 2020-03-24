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
            if (String.IsNullOrEmpty(cmbCarSelection.Text))
            {

            }
            else
            {
                DateTime pDate = dtPickUp.Value;
                DateTime dDate = dtDropOff.Value;
                TimeSpan day = dDate - pDate;
                int aralik = Convert.ToInt32(day.TotalDays) + 1;

                if (cmbCarSelection.SelectedIndex == 0)
                {
                    int a180 = 250;
                    metroLabel11.Text = (a180 * aralik).ToString() + "TL";
                }
                else if (cmbCarSelection.SelectedIndex == 1)
                {
                    int i10 = 135;
                    metroLabel11.Text = (i10 * aralik).ToString() + "TL";
                }
                else if (cmbCarSelection.SelectedIndex == 2)
                {
                    int vwPolo = 175;
                    metroLabel11.Text = (vwPolo * aralik).ToString() + "TL";
                }
                else if (cmbCarSelection.SelectedIndex == 3)
                {
                    int astra = 175;
                    metroLabel11.Text = (astra * aralik).ToString() + "TL";
                }
                else if (cmbCarSelection.SelectedIndex == 4)
                {
                    int a6 = 175;
                    metroLabel11.Text = (a6 * aralik).ToString() + "TL";
                }
                else if (cmbCarSelection.SelectedIndex == 5)
                {
                    int kadjar = 175;
                    metroLabel11.Text = (kadjar * aralik).ToString() + "TL";
                }
            }

            int valx = cmbCarSelection.SelectedIndex;
            switch (valx)
            {
                case 0:
                    pbCarImage.Image = Properties.Resources.m;
                    break;
                case 1:
                    pbCarImage.Image = Properties.Resources.h;
                    break;
                case 2:
                    pbCarImage.Image = Properties.Resources.v;
                    break;
                case 3:
                    pbCarImage.Image = Properties.Resources.o;
                    break;
                case 4:
                    pbCarImage.Image = Properties.Resources.a;
                    break;
                case 5:
                    pbCarImage.Image = Properties.Resources.r;
                    break;
                default:
                    break;
            }
            metroLabel10.Visible = true;
            metroLabel10.Text = cmbCarSelection.Text;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            metroLabel7.Visible = true;
            metroLabel7.Text = dtPickUp.Text;

            metroLabel9.Visible = true;
            metroLabel9.Text = dtDropOff.Text;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            DateTime pDate = dtPickUp.Value;
            DateTime dDate = dtDropOff.Value;
            TimeSpan day = dDate - pDate;
            int aralik = Convert.ToInt32(day.TotalDays) + 1;

            if (cmbCarSelection.SelectedIndex == 0)
            {
                int a180 = 250;
                lblTotalCost.Text = (a180 * aralik).ToString() + "TL";
                lblTotalDays.Text = aralik.ToString() + "GÜN";
            }
            else if (cmbCarSelection.SelectedIndex == 1)
            {
                int i10 = 135;
                lblTotalCost.Text = (i10 * aralik).ToString() + "TL";
                lblTotalDays.Text = aralik.ToString() + "GÜN";
            }
            else if (cmbCarSelection.SelectedIndex == 2)
            {
                int vwPolo = 175;
                lblTotalCost.Text = (vwPolo * aralik).ToString() + "TL";
                lblTotalDays.Text = aralik.ToString() + "GÜN";
            }
            else if (cmbCarSelection.SelectedIndex == 3)
            {
                int astra = 175;
                lblTotalCost.Text = (astra * aralik).ToString() + "TL";
                lblTotalDays.Text = aralik.ToString() + "GÜN";
            }
            else if (cmbCarSelection.SelectedIndex == 4)
            {
                int a6 = 175;
                lblTotalCost.Text = (a6 * aralik).ToString() + "TL";
                lblTotalDays.Text = aralik.ToString() + "GÜN";
            }
            else if (cmbCarSelection.SelectedIndex == 5)
            {
                int kadjar = 175;
                lblTotalCost.Text = (kadjar * aralik).ToString() + "TL";
                lblTotalDays.Text = aralik.ToString() + "GÜN";
            }
        }

        private void cmbPickUp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPickUp_SelectedValueChanged(object sender, EventArgs e)
        {
            metroLabel6.Visible = true;
            metroLabel6.Text = cmbPickUp.Text;

        }

        private void cmbDropOff_SelectedValueChanged(object sender, EventArgs e)
        {
            metroLabel8.Visible = true;
            metroLabel8.Text = cmbDropOff.Text;
        }

        private void dtPickUp_ValueChanged(object sender, EventArgs e)
        {
            metroLabel7.Text = dtPickUp.Text;
        }

        private void dtDropOff_ValueChanged(object sender, EventArgs e)
        {
            metroLabel9.Text = dtDropOff.Text;
        }
    }
}
