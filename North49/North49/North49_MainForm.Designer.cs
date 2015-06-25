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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.introLabel = new System.Windows.Forms.Label();
            this.alterTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(972, 270);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Visible = false;
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
            this.alterTextBox.Size = new System.Drawing.Size(588, 89);
            this.alterTextBox.TabIndex = 6;
            this.alterTextBox.TextChanged += new System.EventHandler(this.alterTextBox_TextChanged);
            this.alterTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.alterTextBox_MouseDown);
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
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Image = global::North49.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(773, 372);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 50);
            this.addButton.TabIndex = 7;
            this.addButton.TabStop = false;
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
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.alterTextBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "North49_MainForm";
            this.Text = "North49 - Thanh Lai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.PictureBox browseButton;
        private System.Windows.Forms.PictureBox helpButton;
        private System.Windows.Forms.TextBox alterTextBox;
        private System.Windows.Forms.PictureBox addButton;
        private System.Windows.Forms.PictureBox removeButton;
    }
}

