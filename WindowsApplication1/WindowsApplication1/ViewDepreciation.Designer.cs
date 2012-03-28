using System.Windows.Forms;
namespace WindowsApplication1
{
    partial class ViewDepreciation
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

        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.historyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsApplication1.Database1DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depreciation = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.searchB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // historyBindingSource1
            // 
            this.historyBindingSource1.DataMember = "History";
            this.historyBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 46);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fixed Assets Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(638, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // depreciation
            // 
            this.depreciation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.depreciation.Location = new System.Drawing.Point(3, 218);
            this.depreciation.Name = "depreciation";
            this.depreciation.Size = new System.Drawing.Size(75, 23);
            this.depreciation.TabIndex = 44;
            this.depreciation.Text = "Depreciation";
            this.depreciation.UseVisualStyleBackColor = false;
            this.depreciation.Click += new System.EventHandler(this.depreciation_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Print.Location = new System.Drawing.Point(271, 422);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 32;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // searchB
            // 
            this.searchB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchB.Location = new System.Drawing.Point(3, 160);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(75, 23);
            this.searchB.TabIndex = 39;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = false;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Filters:";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input.Location = new System.Drawing.Point(3, 131);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 42;
            this.input.Text = "Input";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.History.Location = new System.Drawing.Point(3, 189);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(75, 23);
            this.History.TabIndex = 41;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.home.Location = new System.Drawing.Point(3, 102);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 38;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(84, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 462);
            this.panel1.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(437, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "End Date:";
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(528, 35);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(100, 20);
            this.end.TabIndex = 44;
            this.end.TextChanged += new System.EventHandler(this.end_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(229, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Start Date:";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(316, 35);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 20);
            this.start.TabIndex = 42;
            this.start.TextChanged += new System.EventHandler(this.start_TextChanged);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "All",
            "Office Equipment",
            "Machinery",
            "Transportation Equipment",
            "Office Furniture",
            "Leasehold Improvement",
            "Tools",
            "Computer Hardware",
            "Computer Software"});
            this.category.Location = new System.Drawing.Point(102, 38);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 40;
            this.category.Text = "All";
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Asset Category:";
            // 
            // ViewDepreciation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depreciation);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.input);
            this.Controls.Add(this.History);
            this.Controls.Add(this.home);
            this.Controls.Add(this.panel1);
            this.Name = "ViewDepreciation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDepreciation";
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource historyBindingSource1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button depreciation;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource historyBindingSource;
        public System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox start;

    }
}