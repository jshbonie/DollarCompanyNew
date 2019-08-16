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

/// <summary>
/// Student Name: Joshua Bonie
/// Student Number: 301009614
/// </summary>
/// <summary>
/// This is the start form that gives the user the option to select a new order or a old one
/// </summary>
namespace DollarCompany
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void SavedOrderButton_Click(object sender, EventArgs e)
        {
            //confgure the dile dialog
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file diolog
            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {

                try
                {
                    //open file stream to read
                    using (StreamReader inputStream = new StreamReader(File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read stuff from the file
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_type = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.displaytype = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.resolution = inputStream.ReadLine();
                        Program.product.CPU_Class = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.HDD_speed = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.optical_drive = inputStream.ReadLine();
                        Program.product.Audio_type = inputStream.ReadLine();
                        Program.product.LAN = inputStream.ReadLine();
                        Program.product.WIFI = inputStream.ReadLine();
                        Program.product.width = inputStream.ReadLine();
                        Program.product.height = inputStream.ReadLine();
                        Program.product.depth = inputStream.ReadLine();
                        Program.product.weight = inputStream.ReadLine();
                        Program.product.moust_type = inputStream.ReadLine();
                        Program.product.power = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();

                        //cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }

                    Program.productInfoForm.Show();
                    this.Hide();

                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR " + exception.Message);

                    MessageBox.Show("ERROR " + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
