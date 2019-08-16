using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Student Name: Joshua Bonie
/// Student Number: 301009614
/// </summary>
namespace DollarCompany
{
    public partial class OrderForm : Form
    {
        public double tax;
        public double total;
        public double cost;
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

        

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }


        private void OrderForm_Activated(object sender, EventArgs e)
        {
            //Calculations for tax and total 
            tax = Math.Round((double)Program.product.cost, 2);
            tax = Math.Round(tax * 0.13, 2);
            cost = Math.Round((double)Program.product.cost, 2);
            total = Math.Round(tax + cost, 2);
            //

            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            TotalDataLabel.Text = total.ToString();
            PriceDataLabel.Text = cost.ToString();
            CostDataLabel.Text = cost.ToString();
            SalesTaxDataLabel.Text = tax.ToString();
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

        private void backButtonOrderForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you very much for your purchase! " + "\n\nYour order will arrive in 7-10 business days. ", " Order Complete", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void FinishButtonOrderForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your pruchase!" + "\n\nThe order will arrive in 7-10 business days.","Order Complete", MessageBoxButtons.OK);
        }

        private void BackButtonOrderForm_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
    }
}
