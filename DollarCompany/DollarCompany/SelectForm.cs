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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sectionCDatabaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.sectionCDatabaseDataSet.StudentTable);

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
            // open a stream to write
            using (StreamWriter outputString = new StreamWriter(File.Open("Computer.txt", FileMode.Create)))
            {

                // write stuff to the file
                outputString.WriteLine(Program.computer.productID);
                outputString.WriteLine(Program.computer.cost);
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
            }
        }

        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
    }
}
