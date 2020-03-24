namespace RentACar
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.cmbPickUp = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbDropOff = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtPickUp = new MetroFramework.Controls.MetroDateTime();
            this.dtDropOff = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbCarSelection = new MetroFramework.Controls.MetroComboBox();
            this.imgCars = new System.Windows.Forms.ImageList(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalCost = new MetroFramework.Controls.MetroLabel();
            this.btnRent = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalDays = new MetroFramework.Controls.MetroLabel();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPickUp
            // 
            this.cmbPickUp.FormattingEnabled = true;
            this.cmbPickUp.ItemHeight = 23;
            this.cmbPickUp.Items.AddRange(new object[] {
            "İstanbul Havalimanı",
            "Maslak",
            "Beşiktaş"});
            this.cmbPickUp.Location = new System.Drawing.Point(24, 106);
            this.cmbPickUp.Name = "cmbPickUp";
            this.cmbPickUp.Size = new System.Drawing.Size(176, 29);
            this.cmbPickUp.TabIndex = 0;
            this.cmbPickUp.UseSelectable = true;
            this.cmbPickUp.SelectedIndexChanged += new System.EventHandler(this.cmbPickUp_SelectedIndexChanged);
            this.cmbPickUp.SelectedValueChanged += new System.EventHandler(this.cmbPickUp_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Pick up Location";
            // 
            // cmbDropOff
            // 
            this.cmbDropOff.FormattingEnabled = true;
            this.cmbDropOff.ItemHeight = 23;
            this.cmbDropOff.Items.AddRange(new object[] {
            "İstanbul Havalimanı",
            "Maslak",
            "Beşiktaş"});
            this.cmbDropOff.Location = new System.Drawing.Point(223, 106);
            this.cmbDropOff.Name = "cmbDropOff";
            this.cmbDropOff.Size = new System.Drawing.Size(176, 29);
            this.cmbDropOff.TabIndex = 0;
            this.cmbDropOff.UseSelectable = true;
            this.cmbDropOff.SelectedValueChanged += new System.EventHandler(this.cmbDropOff_SelectedValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(223, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Drop Off Location";
            // 
            // dtPickUp
            // 
            this.dtPickUp.Location = new System.Drawing.Point(24, 142);
            this.dtPickUp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtPickUp.Name = "dtPickUp";
            this.dtPickUp.Size = new System.Drawing.Size(176, 29);
            this.dtPickUp.TabIndex = 2;
            this.dtPickUp.ValueChanged += new System.EventHandler(this.dtPickUp_ValueChanged);
            // 
            // dtDropOff
            // 
            this.dtDropOff.Location = new System.Drawing.Point(223, 142);
            this.dtDropOff.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDropOff.Name = "dtDropOff";
            this.dtDropOff.Size = new System.Drawing.Size(176, 29);
            this.dtDropOff.TabIndex = 2;
            this.dtDropOff.ValueChanged += new System.EventHandler(this.dtDropOff_ValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Car Selection";
            // 
            // cmbCarSelection
            // 
            this.cmbCarSelection.FormattingEnabled = true;
            this.cmbCarSelection.ItemHeight = 23;
            this.cmbCarSelection.Items.AddRange(new object[] {
            "A - Mercedes - A180 - Dizel - Otomatik",
            "A - Hyundai - i10 - Benzin - Otomatik",
            "B - VolksWagen - Polo  - Benzin - Otomatik",
            "C - Opel - Astra - Dizel - Otomatik",
            "D - Audi - A6 - Dizel - Otomatik",
            "SUV - Renault - Kadjar - Dizel - Otomatik"});
            this.cmbCarSelection.Location = new System.Drawing.Point(24, 228);
            this.cmbCarSelection.Name = "cmbCarSelection";
            this.cmbCarSelection.Size = new System.Drawing.Size(375, 29);
            this.cmbCarSelection.TabIndex = 4;
            this.cmbCarSelection.UseSelectable = true;
            this.cmbCarSelection.SelectedValueChanged += new System.EventHandler(this.cmbCarSelection_SelectedValueChanged);
            // 
            // imgCars
            // 
            this.imgCars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCars.ImageStream")));
            this.imgCars.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCars.Images.SetKeyName(0, "2018-2019-Audi-A6.png");
            this.imgCars.Images.SetKeyName(1, "2019renaultkadjar1.jpg");
            this.imgCars.Images.SetKeyName(2, "i30.png");
            this.imgCars.Images.SetKeyName(3, "merco.jpg");
            this.imgCars.Images.SetKeyName(4, "Opel-Astra-K-Sports-Tourer-facelift-2019.jpg");
            this.imgCars.Images.SetKeyName(5, "polo.jpg");
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(406, 84);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Total Cost:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(580, 84);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(186, 19);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "Please complete all the fields !";
            // 
            // btnRent
            // 
            this.btnRent.ActiveControl = null;
            this.btnRent.Location = new System.Drawing.Point(24, 294);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(375, 105);
            this.btnRent.TabIndex = 8;
            this.btnRent.Text = "Rent";
            this.btnRent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRent.UseSelectable = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(406, 65);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Total Days:";
            // 
            // lblTotalDays
            // 
            this.lblTotalDays.AutoSize = true;
            this.lblTotalDays.Location = new System.Drawing.Point(580, 65);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(186, 19);
            this.lblTotalDays.TabIndex = 7;
            this.lblTotalDays.Text = "Please complete all the fields !";
            // 
            // pbCarImage
            // 
            this.pbCarImage.Location = new System.Drawing.Point(406, 107);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(313, 292);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 9;
            this.pbCarImage.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Orange;
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(725, 107);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(257, 292);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.ForeColor = System.Drawing.Color.Blue;
            this.metroLabel13.Location = new System.Drawing.Point(4, 81);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(159, 19);
            this.metroLabel13.TabIndex = 9;
            this.metroLabel13.Text = "Drop off Informations:";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            this.metroLabel13.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.ForeColor = System.Drawing.Color.Blue;
            this.metroLabel12.Location = new System.Drawing.Point(4, 4);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(151, 19);
            this.metroLabel12.TabIndex = 8;
            this.metroLabel12.Text = "Pick up Informations:";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.Location = new System.Drawing.Point(4, 187);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(90, 19);
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "metroLabel10";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            this.metroLabel10.UseStyleColors = true;
            this.metroLabel10.Visible = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.Location = new System.Drawing.Point(171, 111);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(83, 19);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "metroLabel9";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            this.metroLabel9.UseStyleColors = true;
            this.metroLabel9.Visible = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Location = new System.Drawing.Point(4, 111);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(83, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "metroLabel8";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            this.metroLabel8.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.Location = new System.Drawing.Point(172, 35);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "metroLabel7";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            this.metroLabel7.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(4, 35);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "metroLabel6";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            this.metroLabel6.Visible = false;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.ForeColor = System.Drawing.Color.Blue;
            this.metroLabel14.Location = new System.Drawing.Point(4, 158);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(125, 19);
            this.metroLabel14.TabIndex = 10;
            this.metroLabel14.Text = "Car Informations:";
            this.metroLabel14.UseCustomBackColor = true;
            this.metroLabel14.UseCustomForeColor = true;
            this.metroLabel14.UseStyleColors = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.ForeColor = System.Drawing.Color.Blue;
            this.metroLabel15.Location = new System.Drawing.Point(4, 223);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(131, 19);
            this.metroLabel15.TabIndex = 10;
            this.metroLabel15.Text = "Cost Informations:";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            this.metroLabel15.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.Location = new System.Drawing.Point(3, 254);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(133, 19);
            this.metroLabel11.TabIndex = 7;
            this.metroLabel11.Text = "Lütfen seçim yapınız !";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            this.metroLabel11.UseStyleColors = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 422);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.lblTotalDays);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbCarSelection);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtDropOff);
            this.Controls.Add(this.dtPickUp);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbDropOff);
            this.Controls.Add(this.cmbPickUp);
            this.Name = "MainMenu";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbPickUp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbDropOff;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtPickUp;
        private MetroFramework.Controls.MetroDateTime dtDropOff;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbCarSelection;
        private System.Windows.Forms.ImageList imgCars;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblTotalCost;
        private MetroFramework.Controls.MetroTile btnRent;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblTotalDays;
        private System.Windows.Forms.PictureBox pbCarImage;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}