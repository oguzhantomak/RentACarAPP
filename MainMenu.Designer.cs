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
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPickUp
            // 
            this.cmbPickUp.FormattingEnabled = true;
            this.cmbPickUp.ItemHeight = 23;
            this.cmbPickUp.Location = new System.Drawing.Point(24, 106);
            this.cmbPickUp.Name = "cmbPickUp";
            this.cmbPickUp.Size = new System.Drawing.Size(176, 29);
            this.cmbPickUp.TabIndex = 0;
            this.cmbPickUp.UseSelectable = true;
            this.cmbPickUp.SelectedIndexChanged += new System.EventHandler(this.cmbPickUp_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Pick up Location";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // cmbDropOff
            // 
            this.cmbDropOff.FormattingEnabled = true;
            this.cmbDropOff.ItemHeight = 23;
            this.cmbDropOff.Location = new System.Drawing.Point(223, 106);
            this.cmbDropOff.Name = "cmbDropOff";
            this.cmbDropOff.Size = new System.Drawing.Size(176, 29);
            this.cmbDropOff.TabIndex = 0;
            this.cmbDropOff.UseSelectable = true;
            this.cmbDropOff.SelectedIndexChanged += new System.EventHandler(this.cmbDropOff_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(223, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Drop Off Location";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
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
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
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
            this.cmbCarSelection.SelectedIndexChanged += new System.EventHandler(this.cmbCarSelection_SelectedIndexChanged);
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
            // pbCarImage
            // 
            this.pbCarImage.Location = new System.Drawing.Point(406, 106);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(360, 293);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCarImage.TabIndex = 5;
            this.pbCarImage.TabStop = false;
            this.pbCarImage.Click += new System.EventHandler(this.pbCarImage_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 422);
            this.Controls.Add(this.pbCarImage);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
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
        private System.Windows.Forms.PictureBox pbCarImage;
    }
}