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
            // TODO: This line of code loads data into the 'sectionCDatabaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            //this.studentTableTableAdapter.Fill(this.sectionCDatabaseDataSet.StudentTable);

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
            var rowIndex = studentDataGridView.CurrentCell.RowIndex;
            var rows = studentDataGridView.Rows;
            var columnCount = studentDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            rows[rowIndex].Selected = true;

            string outputString = string.Empty;
            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value.ToString() + " ";
            }

            SelectionLabel.Text = outputString;

            Program.computer.productID = int.Parse(cells[(int)ComputerField.PRODUCTID].Value.ToString());
            Program.computer.cost = int.Parse(cells[(int)ComputerField.COST].Value.ToString());
            Program.computer.manufacturer = cells[(int)ComputerField.MANUFACTURER].Value.ToString();
            Program.computer.model = cells[(int)ComputerField.MODEL].Value.ToString();
            Program.computer.RAM_type = cells[(int)ComputerField.RAM_TYPE].Value.ToString();
            Program.computer.RAM_size = cells[(int)ComputerField.RAM_SIZE].Value.ToString();
            Program.computer.displaytype = cells[(int)ComputerField.DISPLAYTYPE].Value.ToString();
            Program.computer.screensize = cells[(int)ComputerField.SCREENSIZE].Value.ToString();
            Program.computer.resolution = cells[(int)ComputerField.RESOLUTION].Value.ToString();
            Program.computer.CPU_Class = cells[(int)ComputerField.CPU_CLASS].Value.ToString();
            Program.computer.CPU_brand = cells[(int)ComputerField.CPU_BRAND].Value.ToString();
            Program.computer.CPU_type = cells[(int)ComputerField.CPU_TYPE].Value.ToString();
            Program.computer.CPU_speed = cells[(int)ComputerField.CPU_SPEED].Value.ToString();
            Program.computer.CPU_number = cells[(int)ComputerField.CPU_NUMBER].Value.ToString();
            Program.computer.condition = cells[(int)ComputerField.CONDITION].Value.ToString();
            Program.computer.OS = cells[(int)ComputerField.OS].Value.ToString();
            Program.computer.platform = cells[(int)ComputerField.PLATFORM].Value.ToString();
            Program.computer.HDD_size = cells[(int)ComputerField.HDD_SIZE].Value.ToString();
            Program.computer.HDD_speed = cells[(int)ComputerField.HDD_SPEED].Value.ToString();
            Program.computer.GPU_type = cells[(int)ComputerField.GPU_TYPE].Value.ToString();
            Program.computer.optical_drive = cells[(int)ComputerField.OPTICAL_DRIVE].Value.ToString();
            Program.computer.Audio_type = cells[(int)ComputerField.AUDIO_TYPE].Value.ToString();
            Program.computer.LAN = cells[(int)ComputerField.LAN].Value.ToString();
            Program.computer.WIFI = cells[(int)ComputerField.WIFI].Value.ToString();
            Program.computer.width = cells[(int)ComputerField.WIDTH].Value.ToString();
            Program.computer.height = cells[(int)ComputerField.HEIGHT].Value.ToString();
            Program.computer.depth = cells[(int)ComputerField.DEPTH].Value.ToString();
            Program.computer.weight = cells[(int)ComputerField.WEIGHT].Value.ToString();
            Program.computer.moust_type = cells[(int)ComputerField.MOUST_TYPE].Value.ToString();
            Program.computer.power = cells[(int)ComputerField.POWER].Value.ToString();
            Program.computer.webcam = cells[(int)ComputerField.WEBCAM].Value.ToString();


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
                    outputString.WriteLine(Program.computer.productID.ToString());
                    outputString.WriteLine(Program.computer.cost.ToString());
                    outputString.WriteLine(Program.computer.manufacturer);
                    outputString.WriteLine(Program.computer.model);
                    outputString.WriteLine(Program.computer.RAM_type);
                    outputString.WriteLine(Program.computer.RAM_size);
                    outputString.WriteLine(Program.computer.displaytype);
                    outputString.WriteLine(Program.computer.screensize);
                    outputString.WriteLine(Program.computer.resolution);
                    outputString.WriteLine(Program.computer.CPU_Class);
                    outputString.WriteLine(Program.computer.CPU_brand);
                    outputString.WriteLine(Program.computer.CPU_type);
                    outputString.WriteLine(Program.computer.CPU_speed);
                    outputString.WriteLine(Program.computer.CPU_number);
                    outputString.WriteLine(Program.computer.condition);
                    outputString.WriteLine(Program.computer.OS);
                    outputString.WriteLine(Program.computer.platform);
                    outputString.WriteLine(Program.computer.HDD_size);
                    outputString.WriteLine(Program.computer.HDD_speed);
                    outputString.WriteLine(Program.computer.GPU_type);
                    outputString.WriteLine(Program.computer.optical_drive);
                    outputString.WriteLine(Program.computer.Audio_type);
                    outputString.WriteLine(Program.computer.LAN);
                    outputString.WriteLine(Program.computer.WIFI);
                    outputString.WriteLine(Program.computer.width);
                    outputString.WriteLine(Program.computer.height);
                    outputString.WriteLine(Program.computer.depth);
                    outputString.WriteLine(Program.computer.weight);
                    outputString.WriteLine(Program.computer.moust_type);
                    outputString.WriteLine(Program.computer.power);
                    outputString.WriteLine(Program.computer.webcam);

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
                        Program.computer.productID = int.Parse(inputStream.ReadString());
                        Program.computer.cost = int.Parse(inputStream.ReadString());
                        Program.computer.manufacturer = inputStream.ReadString();
                        Program.computer.model = inputStream.ReadString();
                        Program.computer.RAM_type = inputStream.ReadString();
                        Program.computer.RAM_size = inputStream.ReadString();
                        Program.computer.displaytype = inputStream.ReadString();
                        Program.computer.screensize = inputStream.ReadString();
                        Program.computer.resolution = inputStream.ReadString();
                        Program.computer.CPU_Class = inputStream.ReadString();
                        Program.computer.CPU_brand = inputStream.ReadString();
                        Program.computer.CPU_type = inputStream.ReadString();
                        Program.computer.CPU_speed = inputStream.ReadString();
                        Program.computer.CPU_number = inputStream.ReadString();
                        Program.computer.condition = inputStream.ReadString();
                        Program.computer.OS = inputStream.ReadString();
                        Program.computer.platform = inputStream.ReadString();
                        Program.computer.HDD_size = inputStream.ReadString();
                        Program.computer.HDD_speed = inputStream.ReadString();
                        Program.computer.GPU_type = inputStream.ReadString();
                        Program.computer.optical_drive = inputStream.ReadString();
                        Program.computer.Audio_type = inputStream.ReadString();
                        Program.computer.LAN = inputStream.ReadString();
                        Program.computer.WIFI = inputStream.ReadString();
                        Program.computer.width = inputStream.ReadString();
                        Program.computer.height = inputStream.ReadString();
                        Program.computer.depth = inputStream.ReadString();
                        Program.computer.weight = inputStream.ReadString();
                        Program.computer.moust_type = inputStream.ReadString();
                        Program.computer.power = inputStream.ReadString();
                        Program.computer.webcam = inputStream.ReadString();

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
                    outputString.Write(Program.computer.productID.ToString());
                    outputString.Write(Program.computer.cost.ToString());
                    outputString.Write(Program.computer.manufacturer);
                    outputString.Write(Program.computer.model);
                    outputString.Write(Program.computer.RAM_type);
                    outputString.Write(Program.computer.RAM_size);
                    outputString.Write(Program.computer.displaytype);
                    outputString.Write(Program.computer.screensize);
                    outputString.Write(Program.computer.resolution);
                    outputString.Write(Program.computer.CPU_Class);
                    outputString.Write(Program.computer.CPU_brand);
                    outputString.Write(Program.computer.CPU_type);
                    outputString.Write(Program.computer.CPU_speed);
                    outputString.Write(Program.computer.CPU_number);
                    outputString.Write(Program.computer.condition);
                    outputString.Write(Program.computer.OS);
                    outputString.Write(Program.computer.platform);
                    outputString.Write(Program.computer.HDD_size);
                    outputString.Write(Program.computer.HDD_speed);
                    outputString.Write(Program.computer.GPU_type);
                    outputString.Write(Program.computer.optical_drive);
                    outputString.Write(Program.computer.Audio_type);
                    outputString.Write(Program.computer.LAN);
                    outputString.Write(Program.computer.WIFI);
                    outputString.Write(Program.computer.width);
                    outputString.Write(Program.computer.height);
                    outputString.Write(Program.computer.depth);
                    outputString.Write(Program.computer.weight);
                    outputString.Write(Program.computer.moust_type);
                    outputString.Write(Program.computer.power);
                    outputString.Write(Program.computer.webcam);

                    // close file
                    outputString.Flush();
                    outputString.Close();
                    outputString.Dispose();

                    //message alerting user the file has been saved
                    MessageBox.Show("Binary File Saved...", "Saving Binary file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
