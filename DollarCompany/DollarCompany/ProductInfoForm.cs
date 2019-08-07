using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //open file stream to read
            using (StreamReader inputStream = new StreamReader(File.Open("Computer.txt", FileMode.Open)))
            {
                // write stuff to the file
                Program.computer.productID = int.Parse(inputStream.ReadLine());
                Program.computer.cost = int.Parse(inputStream.ReadLine());
                Program.computer.manufacturer = inputStream.ReadLine();
                Program.computer.model = inputStream.ReadLine();
                Program.computer.RAM_type = inputStream.ReadLine();
                Program.computer.RAM_size = inputStream.ReadLine();
                Program.computer.displaytype = inputStream.ReadLine();
                Program.computer.screensize = inputStream.ReadLine();
                Program.computer.resolution = inputStream.ReadLine();
                Program.computer.CPU_Class = inputStream.ReadLine();
                Program.computer.CPU_brand = inputStream.ReadLine();
                Program.computer.CPU_type = inputStream.ReadLine();
                Program.computer.CPU_speed = inputStream.ReadLine();
                Program.computer.CPU_number = inputStream.ReadLine();
                Program.computer.condition = inputStream.ReadLine();
                Program.computer.OS = inputStream.ReadLine();
                Program.computer.platform = inputStream.ReadLine();
                Program.computer.HDD_size = inputStream.ReadLine();
                Program.computer.HDD_speed = inputStream.ReadLine();
                Program.computer.GPU_type = inputStream.ReadLine();
                Program.computer.optical_drive = inputStream.ReadLine();
                Program.computer.Audio_type = inputStream.ReadLine();
                Program.computer.LAN = inputStream.ReadLine();
                Program.computer.WIFI = inputStream.ReadLine();
                Program.computer.width = inputStream.ReadLine();
                Program.computer.height = inputStream.ReadLine();
                Program.computer.depth = inputStream.ReadLine();
                Program.computer.weight = inputStream.ReadLine();
                Program.computer.moust_type = inputStream.ReadLine();
                Program.computer.power = inputStream.ReadLine();
                Program.computer.webcam = inputStream.ReadLine();

                //cleanup
                inputStream.Close();
                inputStream.Dispose();
                
                productIdDataLabel.Text = Program.computer.productID.ToString();
                costDataLabel.Text = Program.computer.cost.ToString();
                ManufacturerDataLabel.Text = Program.computer.manufacturer;
                ModelDataLabel.Text = Program.computer.model;
                RamTypeDataLAbel.Text = Program.computer.RAM_type;
                ramSizeDataLabel.Text = Program.computer.RAM_size;
                DisplayDataLabel.Text = Program.computer.displaytype;
                ScreenSizeDataLabel.Text = Program.computer.screensize;
                ResolutionDataLabel.Text = Program.computer.resolution;
                CPU_ClassDataLabel.Text = Program.computer.CPU_Class;
                CPUBrandDataLAbel.Text = Program.computer.CPU_brand;
                CPU_TypeDataLabel.Text = Program.computer.CPU_type;
                CPUSpeedDataLabel.Text = Program.computer.CPU_speed;
                CPU_NumberDataLabel.Text = Program.computer.CPU_number;
                conditionDataLabel.Text = Program.computer.condition;
                OSDataLabel.Text = Program.computer.OS;
                PlatformDataLabel.Text = Program.computer.platform;
                HDDSizeDataLabel.Text = Program.computer.HDD_size;
                HDDSpeedDataLabel.Text = Program.computer.HDD_speed;
                GPUTypeDataLabel.Text = Program.computer.GPU_type;
                OpticalDriveDataLabel.Text = Program.computer.optical_drive;
                AudioTypeDataLabel.Text = Program.computer.Audio_type;
                LANDataLabel.Text = Program.computer.LAN;
                WifiDataLabel.Text = Program.computer.WIFI;
                WidthDataLabel.Text = Program.computer.width;
                HeightDataLabel.Text = Program.computer.height;
                DepthDataLabel.Text = Program.computer.depth;
                WeightDataLabel.Text = Program.computer.weight;
                MoustDataLabel.Text = Program.computer.moust_type;
                PowerDataLabel.Text = Program.computer.power;
                WEBCAMEDataLabel.Text = Program.computer.webcam;

            }
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
