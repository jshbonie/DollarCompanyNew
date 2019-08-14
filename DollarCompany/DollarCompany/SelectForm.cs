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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            

        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for the exitToolStripMenuItem click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void studentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // local scope aliases
            var rowIndex = productDataGridView.CurrentCell.RowIndex;
            var rows = productDataGridView.Rows;
            var columnCount = productDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            rows[rowIndex].Selected = true;

            string outputString = string.Empty;
            for (int index = 1; index < 4; index++)
            {
                outputString += cells[index].Value.ToString() + " ";
            }

            SelectionLabel.Text = outputString;

            Program.product.productID = short.Parse(cells[(int)ComputerField.PRODUCTID].Value.ToString());
            //Program.product.cost = int.Parse(cells[(int)ComputerField.COST].Value.ToString());
            Program.product.manufacturer = cells[(int)ComputerField.MANUFACTURER].Value.ToString();
            Program.product.model = cells[(int)ComputerField.MODEL].Value.ToString();
            Program.product.RAM_type = cells[(int)ComputerField.RAM_TYPE].Value.ToString();
            Program.product.RAM_size = cells[(int)ComputerField.RAM_SIZE].Value.ToString();
            Program.product.displaytype = cells[(int)ComputerField.DISPLAYTYPE].Value.ToString();
            Program.product.screensize = cells[(int)ComputerField.SCREENSIZE].Value.ToString();
            Program.product.resolution = cells[(int)ComputerField.RESOLUTION].Value.ToString();
            Program.product.CPU_Class = cells[(int)ComputerField.CPU_CLASS].Value.ToString();
            Program.product.CPU_brand = cells[(int)ComputerField.CPU_BRAND].Value.ToString();
            Program.product.CPU_type = cells[(int)ComputerField.CPU_TYPE].Value.ToString();
            Program.product.CPU_speed = cells[(int)ComputerField.CPU_SPEED].Value.ToString();
            Program.product.CPU_number = cells[(int)ComputerField.CPU_NUMBER].Value.ToString();
            Program.product.condition = cells[(int)ComputerField.CONDITION].Value.ToString();
            Program.product.OS = cells[(int)ComputerField.OS].Value.ToString();
            Program.product.platform = cells[(int)ComputerField.PLATFORM].Value.ToString();
            Program.product.HDD_size = cells[(int)ComputerField.HDD_SIZE].Value.ToString();
            Program.product.HDD_speed = cells[(int)ComputerField.HDD_SPEED].Value.ToString();
            Program.product.GPU_Type = cells[(int)ComputerField.GPU_TYPE].Value.ToString();
            Program.product.optical_drive = cells[(int)ComputerField.OPTICAL_DRIVE].Value.ToString();
            Program.product.Audio_type = cells[(int)ComputerField.AUDIO_TYPE].Value.ToString();
            Program.product.LAN = cells[(int)ComputerField.LAN].Value.ToString();
            Program.product.WIFI = cells[(int)ComputerField.WIFI].Value.ToString();
            Program.product.width = cells[(int)ComputerField.WIDTH].Value.ToString();
            Program.product.height = cells[(int)ComputerField.HEIGHT].Value.ToString();
            Program.product.depth = cells[(int)ComputerField.DEPTH].Value.ToString();
            Program.product.weight = cells[(int)ComputerField.WEIGHT].Value.ToString();
            Program.product.moust_type = cells[(int)ComputerField.MOUST_TYPE].Value.ToString();
            Program.product.power = cells[(int)ComputerField.POWER].Value.ToString();
            Program.product.webcam = cells[(int)ComputerField.WEBCAM].Value.ToString();


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //confgure the dile dialog
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file diolog
            var result = ProductSaveFileDialog.ShowDialog();
            if(result != DialogResult.Cancel)
            {
                // open a stream to write
                using (StreamWriter outputString = new StreamWriter(File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {

                    // write stuff to the file
                    outputString.WriteLine(Program.product.productID.ToString());
                    outputString.WriteLine(Program.product.cost.ToString());
                    outputString.WriteLine(Program.product.manufacturer);
                    outputString.WriteLine(Program.product.model);
                    outputString.WriteLine(Program.product.RAM_type);
                    outputString.WriteLine(Program.product.RAM_size);
                    outputString.WriteLine(Program.product.displaytype);
                    outputString.WriteLine(Program.product.screensize);
                    outputString.WriteLine(Program.product.resolution);
                    outputString.WriteLine(Program.product.CPU_Class);
                    outputString.WriteLine(Program.product.CPU_brand);
                    outputString.WriteLine(Program.product.CPU_type);
                    outputString.WriteLine(Program.product.CPU_speed);
                    outputString.WriteLine(Program.product.CPU_number);
                    outputString.WriteLine(Program.product.condition);
                    outputString.WriteLine(Program.product.OS);
                    outputString.WriteLine(Program.product.platform);
                    outputString.WriteLine(Program.product.HDD_size);
                    outputString.WriteLine(Program.product.HDD_speed);
                    outputString.WriteLine(Program.product.GPU_Type);
                    outputString.WriteLine(Program.product.optical_drive);
                    outputString.WriteLine(Program.product.Audio_type);
                    outputString.WriteLine(Program.product.LAN);
                    outputString.WriteLine(Program.product.WIFI);
                    outputString.WriteLine(Program.product.width);
                    outputString.WriteLine(Program.product.height);
                    outputString.WriteLine(Program.product.depth);
                    outputString.WriteLine(Program.product.weight);
                    outputString.WriteLine(Program.product.moust_type);
                    outputString.WriteLine(Program.product.power);
                    outputString.WriteLine(Program.product.webcam);

                    // close file
                    outputString.Close();
                    outputString.Dispose();

                    //message alerting user the file has been saved
                    MessageBox.Show("File Saved...", "Saving file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            //confgure the dile dialog
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file diolog
            var result = ProductOpenFileDialog.ShowDialog();
            if(result != DialogResult.Cancel){

                try
                {
                    //open file stream to read
                    using (StreamReader inputStream = new StreamReader(File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read stuff from the file
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost = int.Parse(inputStream.ReadLine());
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

                    SelectFormNextButton_Click(sender, e);

                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR " + exception.Message);

                    MessageBox.Show("ERROR " + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void openBinaryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //confgure the dile dialog
            ProductOpenFileDialog.FileName = "Product.dat";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Binary Files (*.dat)|*.dat| All Files (*.*)|*.*";

            //open the file diolog
            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {

                try
                {
                    //open file stream to read
                    using (BinaryReader inputStream = new BinaryReader(File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read stuff from the file
                        Program.product.productID = short.Parse(inputStream.ReadString());
                        Program.product.cost = int.Parse(inputStream.ReadString());
                        Program.product.manufacturer = inputStream.ReadString();
                        Program.product.model = inputStream.ReadString();
                        Program.product.RAM_type = inputStream.ReadString();
                        Program.product.RAM_size = inputStream.ReadString();
                        Program.product.displaytype = inputStream.ReadString();
                        Program.product.screensize = inputStream.ReadString();
                        Program.product.resolution = inputStream.ReadString();
                        Program.product.CPU_Class = inputStream.ReadString();
                        Program.product.CPU_brand = inputStream.ReadString();
                        Program.product.CPU_type = inputStream.ReadString();
                        Program.product.CPU_speed = inputStream.ReadString();
                        Program.product.CPU_number = inputStream.ReadString();
                        Program.product.condition = inputStream.ReadString();
                        Program.product.OS = inputStream.ReadString();
                        Program.product.platform = inputStream.ReadString();
                        Program.product.HDD_size = inputStream.ReadString();
                        Program.product.HDD_speed = inputStream.ReadString();
                        Program.product.GPU_Type = inputStream.ReadString();
                        Program.product.optical_drive = inputStream.ReadString();
                        Program.product.Audio_type = inputStream.ReadString();
                        Program.product.LAN = inputStream.ReadString();
                        Program.product.WIFI = inputStream.ReadString();
                        Program.product.width = inputStream.ReadString();
                        Program.product.height = inputStream.ReadString();
                        Program.product.depth = inputStream.ReadString();
                        Program.product.weight = inputStream.ReadString();
                        Program.product.moust_type = inputStream.ReadString();
                        Program.product.power = inputStream.ReadString();
                        Program.product.webcam = inputStream.ReadString();

                        //cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }

                    SelectFormNextButton_Click(sender, e);

                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR " + exception.Message);

                    MessageBox.Show("ERROR " + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    Debug.WriteLine("ERROR " + exception.Message);

                    MessageBox.Show("ERROR " + exception.Message + "\n\n Please select the appropriate file type", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveBinaryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //confgure the dile dialog
            ProductSaveFileDialog.FileName = "Product.dat";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Binary Files (*.dat)|*.dat| All Files (*.*)|*.*";

            //open the file diolog
            var result = ProductSaveFileDialog.ShowDialog();
            if(result != DialogResult.Cancel)
            {
                // open a stream to write
                using (BinaryWriter outputString = new BinaryWriter(File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {

                    // write stuff to the file
                    outputString.Write(Program.product.productID.ToString());
                    outputString.Write(Program.product.cost.ToString());
                    outputString.Write(Program.product.manufacturer);
                    outputString.Write(Program.product.model);
                    outputString.Write(Program.product.RAM_type);
                    outputString.Write(Program.product.RAM_size);
                    outputString.Write(Program.product.displaytype);
                    outputString.Write(Program.product.screensize);
                    outputString.Write(Program.product.resolution);
                    outputString.Write(Program.product.CPU_Class);
                    outputString.Write(Program.product.CPU_brand);
                    outputString.Write(Program.product.CPU_type);
                    outputString.Write(Program.product.CPU_speed);
                    outputString.Write(Program.product.CPU_number);
                    outputString.Write(Program.product.condition);
                    outputString.Write(Program.product.OS);
                    outputString.Write(Program.product.platform);
                    outputString.Write(Program.product.HDD_size);
                    outputString.Write(Program.product.HDD_speed);
                    outputString.Write(Program.product.GPU_Type);
                    outputString.Write(Program.product.optical_drive);
                    outputString.Write(Program.product.Audio_type);
                    outputString.Write(Program.product.LAN);
                    outputString.Write(Program.product.WIFI);
                    outputString.Write(Program.product.width);
                    outputString.Write(Program.product.height);
                    outputString.Write(Program.product.depth);
                    outputString.Write(Program.product.weight);
                    outputString.Write(Program.product.moust_type);
                    outputString.Write(Program.product.power);
                    outputString.Write(Program.product.webcam);

                    // close file
                    outputString.Flush();
                    outputString.Close();
                    outputString.Dispose();

                    //message alerting user the file has been saved
                    MessageBox.Show("Binary File Saved...", "Saving Binary file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
