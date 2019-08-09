using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarCompany
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoFormBackButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
                
                    
                productIdDataLabel.Text = Program.product.productID.ToString();
                costDataLabel.Text = Program.product.cost.ToString();
                ManufacturerDataLabel.Text = Program.product.manufacturer;
                ModelDataLabel.Text = Program.product.model;
                RamTypeDataLAbel.Text = Program.product.RAM_type;
                ramSizeDataLabel.Text = Program.product.RAM_size;
                DisplayDataLabel.Text = Program.product.displaytype;
                ScreenSizeDataLabel.Text = Program.product.screensize;
                ResolutionDataLabel.Text = Program.product.resolution;
                CPU_ClassDataLabel.Text = Program.product.CPU_Class;
                CPUBrandDataLAbel.Text = Program.product.CPU_brand;
                CPU_TypeDataLabel.Text = Program.product.CPU_type;
                CPUSpeedDataLabel.Text = Program.product.CPU_speed;
                CPU_NumberDataLabel.Text = Program.product.CPU_number;
                conditionDataLabel.Text = Program.product.condition;
                OSDataLabel.Text = Program.product.OS;
                PlatformDataLabel.Text = Program.product.platform;
                HDDSizeDataLabel.Text = Program.product.HDD_size;
                HDDSpeedDataLabel.Text = Program.product.HDD_speed;
                GPUTypeDataLabel.Text = Program.product.GPU_Type;
                OpticalDriveDataLabel.Text = Program.product.optical_drive;
                AudioTypeDataLabel.Text = Program.product.Audio_type;
                LANDataLabel.Text = Program.product.LAN;
                WifiDataLabel.Text = Program.product.WIFI;
                WidthDataLabel.Text = Program.product.width;
                HeightDataLabel.Text = Program.product.height;
                DepthDataLabel.Text = Program.product.depth;
                WeightDataLabel.Text = Program.product.weight;
                MoustDataLabel.Text = Program.product.moust_type;
                PowerDataLabel.Text = Program.product.power;
                WEBCAMEDataLabel.Text = Program.product.webcam;

            
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }
    }
}
