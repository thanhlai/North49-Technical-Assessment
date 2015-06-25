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
            dataGrid.DataSource = ds.Tables[tableName].DefaultView;

            //close the stream reader, ghuuuu
            sr.Close();

        }

        private void SetUp()
        {
            // Intro and How-to texts
            introLabel.Text = "Hello from Thanh, here is my little program which allows users to populate data from CSV files to the Data Grid View as well as to modify or alter the records.";
            introLabel.Text += "\nGET STARTED BY: ";
            introLabel.Text += "\n1. Clicking onto the envelope icon below to browse and select your CSV file";
            introLabel.Text += "\n2. The program will automatically display the data in that CSV file to the Data Grid View";
            introLabel.Text += "\n3. Hint: clicking on the help icon in the bottom left of the program for more helps or to see credits.";
            filterButton.Hide();
            addButton.Hide();
            removeButton.Hide();
            alterTextBox.Text = "Enter keyword here";
            alterTextBox.Hide();
            dataGrid.Hide();
            groupBoxAdd.Hide();
        }
        private static string filePath;
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
                    filePath = ofd.FileName; // assign filePath

                    LoadCSVToDataGridView(ofd.FileName);
                    introLabel.Hide();
                    filterButton.Show();
                    addButton.Show();
                    removeButton.Show();
                    alterTextBox.Show();
                    dataGrid.Show();
                    groupBoxAdd.Show();
                    //
                    idTextBox.Text = "ID";
                    nameTextBox.Text = "Name";
                    addressTextBox.Text = "Address";
                    cityTextBox.Text = "City";
                    stateTextBox.Text = "State";
                    zipTextBox.Text = "ZIP";
                    countryTextBox.Text = "Country";
                }
                else
                {
                    MessageBox.Show("The file you are trying to open is not supported by this program.", "Unsupported Extension", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void alterTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            alterTextBox.Text = "";
        }

        // 2. Modifies records
        private int rowIndex = -1; //default invalid row index
        // ------------------- ADD a new record
        private void AddARecord(string newRecord)
        {
            DataProcessing.AddARecord(filePath, newRecord + Environment.NewLine);
        }
        // ------------------- REMOVE a record
        private void RemoveARecord()
        {
            if (rowIndex != -1)
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to remove this record?", "Attempting to remove a record", MessageBoxButtons.YesNo);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        DataProcessing.RemoveARecord(filePath, rowIndex + 1);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // ------------------- FILTER records
        private void FilterRecords()
        {
            if (!string.IsNullOrEmpty(alterTextBox.Text))
            {
                DataSet ds = new DataSet();
                string filterTableName = "filterTable";

                // Defines a new table to hold the new data set
                ds.Tables.Add(filterTableName); 

                int firstRow = 0; // just a flag so that it knows the first row's data will be the columns' attributes
                foreach (string row in DataProcessing.FilterARecord(filePath, alterTextBox.Text))
                {
                    string[] records = row.Split(",".ToCharArray());
                    if (firstRow == 0)
                    {
                        for (int i = 0; i < records.Length; i++)
                        {
                            ds.Tables[filterTableName].Columns.Add(records[i]);
                        }
                    }
                    else
                    {
                        ds.Tables[filterTableName].Rows.Add(records);
                    }
                    firstRow++;
                }
                dataGrid.DataSource = ds.Tables[filterTableName].DefaultView;
            }
            else
            {
                // Reload the original grid view if no search keyword
                LoadCSVToDataGridView(filePath);
            }
        }
        // ------------------- UPDATE the Data Grid
        private void UpdateDataGrid()
        {
            LoadCSVToDataGridView(filePath);
        }

        private void dataGrid_Click(object sender, EventArgs e)
        {
            rowIndex = dataGrid.CurrentRowIndex;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveARecord();
            UpdateDataGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // revert to original grid view before adding
            LoadCSVToDataGridView(filePath);

            if (!string.IsNullOrEmpty(idTextBox.Text) && !string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(addressTextBox.Text) && !string.IsNullOrEmpty(cityTextBox.Text) && !string.IsNullOrEmpty(stateTextBox.Text) && !string.IsNullOrEmpty(zipTextBox.Text) && !string.IsNullOrEmpty(countryTextBox.Text))
            {
                AddARecord(idTextBox.Text + "," + nameTextBox.Text + "," + addressTextBox.Text + "," + cityTextBox.Text + "," + stateTextBox.Text + "," + zipTextBox.Text + ","+ countryTextBox.Text);
                UpdateDataGrid();
            }

            //reset those text box with placeholders
            idTextBox.Text = "ID";
            nameTextBox.Text = "Name";
            addressTextBox.Text = "Address";
            cityTextBox.Text = "City";
            stateTextBox.Text = "State";
            zipTextBox.Text = "ZIP";
            countryTextBox.Text = "Country";
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            FilterRecords();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a help button :)");
        }

        private void countryTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            countryTextBox.Text = "";
        }

        private void zipTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            zipTextBox.Text = "";
        }

        private void stateTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            stateTextBox.Text = "";
        }

        private void cityTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            cityTextBox.Text = "";
        }

        private void addressTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            addressTextBox.Text = "";
        }

        private void nameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            nameTextBox.Text = "";
        }

        private void idTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            idTextBox.Text = "";
        }
        

    }
}
