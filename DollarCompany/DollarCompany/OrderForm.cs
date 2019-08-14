using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarCompany
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            CostDataLabel.Text = Program.product.cost.ToString();
            PlatformDataLabel.Text = Program.product.platform;
            OSDataLabel.Text = Program.product.OS;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            ModelDataLabel.Text = Program.product.model;
            RamTypeDataLabel.Text = Program.product.RAM_type;
            RamSizeDataLabel.Text = Program.product.RAM_size;
            DisplayDataLabel.Text = Program.product.displaytype;
            ScreenSizeDataLabel.Text = Program.product.screensize;
            ResolutionDataLabel.Text = Program.product.resolution;
            CpuClassDataLabel.Text = Program.product.CPU_Class;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUSPeedDataLabel.Text = Program.product.CPU_speed;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            ConditionDataLabel.Text = Program.product.condition;
            OSDataLabel.Text = Program.product.OS;
            PlatformDataLabel.Text = Program.product.platform;
            HDDSizeDataLabel.Text = Program.product.HDD_size;
            HDDSpeedDataLabel.Text = Program.product.HDD_speed;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            OpticalDriveDataLabel.Text = Program.product.optical_drive;
            AudioTypeDataLabel.Text = Program.product.Audio_type;
            LANDataLabel.Text = Program.product.LAN;
            WIFIDataLabel.Text = Program.product.LAN;
            WidthDataLabel.Text = Program.product.width;
            HeightDataLabel.Text = Program.product.height;
            WeightDataLabel.Text = Program.product.weight;
            MoustDataLabel.Text = Program.product.moust_type;
            WebcamDataLabel.Text = Program.product.webcam;
            condDataLabel.Text = Program.product.condition;
        }
    }
}
