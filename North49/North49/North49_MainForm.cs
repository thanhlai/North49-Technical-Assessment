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
/*
 * @author: Thanh Lai
 * @project: North49 Technical Assessment
 * @company: North49 Business Solutions 
 * @supervisor: Michael VanKuipers
 * @date: 24/06/2015
 * @version: 1.0.0
 */
namespace North49
{
    public partial class North49_MainForm : Form
    {
        public North49_MainForm()
        {
            InitializeComponent();
            SetUp();
        }

        // 1. Loads CSV and display into the grid view
        private void LoadCSVToDataGridView(string filePath)
        {
            DataSet ds = new DataSet();
            string tableName = "sampleTable";

            StreamReader sr = new StreamReader(filePath);
            //string csv = File.ReadAllText(filePath);
            // Defines a new table to hold the data set
            ds.Tables.Add(tableName);   //table's name
            
           

            string[] rows = sr.ReadToEnd().Split("\n".ToCharArray());
            int firstRow = 0; // just a flag so that it knows the first row's data will be the columns' attributes
            foreach(string row in rows)
            {
                string[] records = row.Split(",".ToCharArray());
                // Table's attributes: ID,Name,Address,City,State,Zip,Country / or first rows values as columns's attribute
                if (firstRow == 0)
                {
                    for (int i = 0; i < records.Length; i++)
                    {
                        ds.Tables[tableName].Columns.Add(records[i]);
                    }
                }
                else
                {
                    ds.Tables[tableName].Rows.Add(records);
                }
                firstRow++;
            }
            dataGridView.DataSource = ds.Tables[tableName].DefaultView;
        }

        private void SetUp()
        {
            // Intro and How-to texts
            introLabel.Text = "Hello from Thanh, here is my little program which allows users to populate data from CSV files to the Data Grid View as well as to modify or alter the records.";
            introLabel.Text += "\nGET STARTED BY: ";
            introLabel.Text += "\n1. Clicking onto the envelope icon below to browse and select your CSV file";
            introLabel.Text += "\n2. The program will automatically display the data in that CSV file to the Data Grid View";
            introLabel.Text += "\n3. Hint: clicking on the help icon in the bottom left of the program for more helps or to see credits.";
            addButton.Hide();
            removeButton.Hide();
            alterTextBox.Text = "Enter keyword here";
            alterTextBox.Hide();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // csv error handling
                if (ofd.FileName.EndsWith(".csv"))
                {
                    LoadCSVToDataGridView(ofd.FileName);
                    introLabel.Hide();
                    addButton.Show();
                    removeButton.Show();
                    alterTextBox.Show();
                    dataGridView.Show();
                }
                else
                {
                    MessageBox.Show("The file you are trying to open is not supported by this program.", "Unsupported Extension", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void alterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void alterTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            alterTextBox.Text = "";
        }

        // 2. Modifies records
        // ------------------- ADD a new record
        private void AddARecord()
        {

        }
        // ------------------- REMOVE a record
        private void RemoveARecord()
        {

        }
    }
}
