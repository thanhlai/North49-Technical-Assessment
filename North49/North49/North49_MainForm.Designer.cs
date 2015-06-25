namespace North49
{
    partial class North49_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(North49_MainForm));
            this.introLabel = new System.Windows.Forms.Label();
            this.alterTextBox = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.PictureBox();
            this.removeButton = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(29, 45);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(0, 16);
            this.introLabel.TabIndex = 2;
            // 
            // alterTextBox
            // 
            this.alterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterTextBox.Location = new System.Drawing.Point(164, 351);
            this.alterTextBox.Multiline = true;
            this.alterTextBox.Name = "alterTextBox";
            this.alterTextBox.Size = new System.Drawing.Size(510, 89);
            this.alterTextBox.TabIndex = 6;
            this.alterTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.alterTextBox_MouseDown);
            // 
            // dataGrid
            // 
            this.dataGrid.DataMember = "";
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(12, 20);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.PreferredColumnWidth = 100;
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(757, 294);
            this.dataGrid.TabIndex = 31;
            this.dataGrid.Click += new System.EventHandler(this.dataGrid_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.countryTextBox);
            this.groupBoxAdd.Controls.Add(this.zipTextBox);
            this.groupBoxAdd.Controls.Add(this.stateTextBox);
            this.groupBoxAdd.Controls.Add(this.cityTextBox);
            this.groupBoxAdd.Controls.Add(this.addressTextBox);
            this.groupBoxAdd.Controls.Add(this.nameTextBox);
            this.groupBoxAdd.Controls.Add(this.idTextBox);
            this.groupBoxAdd.Location = new System.Drawing.Point(770, 20);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(214, 294);
            this.groupBoxAdd.TabIndex = 33;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add A New Record";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(7, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(201, 20);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.idTextBox_MouseDown);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(7, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameTextBox_MouseDown);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(7, 72);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(201, 20);
            this.addressTextBox.TabIndex = 2;
            this.addressTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addressTextBox_MouseDown);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(7, 98);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(201, 20);
            this.cityTextBox.TabIndex = 3;
            this.cityTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cityTextBox_MouseDown);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(7, 176);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(201, 20);
            this.countryTextBox.TabIndex = 6;
            this.countryTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.countryTextBox_MouseDown);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(7, 150);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(201, 20);
            this.zipTextBox.TabIndex = 5;
            this.zipTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zipTextBox_MouseDown);
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(7, 124);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(201, 20);
            this.stateTextBox.TabIndex = 4;
            this.stateTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stateTextBox_MouseDown);
            // 
            // filterButton
            // 
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.Image = global::North49.Properties.Resources.filter;
            this.filterButton.Location = new System.Drawing.Point(693, 374);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(50, 50);
            this.filterButton.TabIndex = 32;
            this.filterButton.TabStop = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Image = global::North49.Properties.Resources.remove;
            this.removeButton.Location = new System.Drawing.Point(845, 371);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(48, 50);
            this.removeButton.TabIndex = 8;
            this.removeButton.TabStop = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Image = global::North49.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(770, 372);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 50);
            this.addButton.TabIndex = 7;
            this.addButton.TabStop = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.helpButton.Image = global::North49.Properties.Resources.help;
            this.helpButton.Location = new System.Drawing.Point(922, 366);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(62, 59);
            this.helpButton.TabIndex = 4;
            this.helpButton.TabStop = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton.Image = global::North49.Properties.Resources.envelope;
            this.browseButton.Location = new System.Drawing.Point(12, 351);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(126, 89);
            this.browseButton.TabIndex = 3;
            this.browseButton.TabStop = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // North49_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 452);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.alterTextBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.introLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "North49_MainForm";
            this.Text = "North49 - Thanh Lai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.PictureBox browseButton;
        private System.Windows.Forms.PictureBox helpButton;
        private System.Windows.Forms.TextBox alterTextBox;
        private System.Windows.Forms.PictureBox addButton;
        private System.Windows.Forms.PictureBox removeButton;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.PictureBox filterButton;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}

