using System.Windows.Forms;
namespace WindowsApplication1
{
    partial class Edit
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
            this.Submit = new System.Windows.Forms.Button();
            this.depreciation = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ACost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Life = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.database1DataSet = new WindowsApplication1.Database1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Submit.Location = new System.Drawing.Point(273, 396);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 32;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // depreciation
            // 
            this.depreciation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.depreciation.Location = new System.Drawing.Point(3, 218);
            this.depreciation.Name = "depreciation";
            this.depreciation.Size = new System.Drawing.Size(75, 23);
            this.depreciation.TabIndex = 37;
            this.depreciation.Text = "Depreciation";
            this.depreciation.UseVisualStyleBackColor = false;
            this.depreciation.Click += new System.EventHandler(this.depreciation_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(53, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Track History:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(301, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Asset Aquisition Cost:";
            // 
            // ACost
            // 
            this.ACost.Location = new System.Drawing.Point(449, 34);
            this.ACost.Name = "ACost";
            this.ACost.Size = new System.Drawing.Size(100, 20);
            this.ACost.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Asset Useful Life:";
            // 
            // Life
            // 
            this.Life.Location = new System.Drawing.Point(159, 37);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(100, 20);
            this.Life.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Asset ID/Code:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(159, 10);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 26;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(301, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Asset Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(449, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 28;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 46);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fixed Assets Management System";
            // 
            // searchB
            // 
            this.searchB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchB.Location = new System.Drawing.Point(3, 160);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(75, 23);
            this.searchB.TabIndex = 32;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = false;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input.Location = new System.Drawing.Point(3, 131);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 35;
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
            this.History.TabIndex = 34;
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
            this.home.TabIndex = 31;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.stat);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ACost);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Life);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(84, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 462);
            this.panel1.TabIndex = 33;
            // 
            // stat
            // 
            this.stat.FormattingEnabled = true;
            this.stat.Items.AddRange(new object[] {
            "In Use",
            "For Repair",
            "Fully Depreciated",
            "Disposed"});
            this.stat.Location = new System.Drawing.Point(449, 60);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(100, 21);
            this.stat.TabIndex = 39;
            this.stat.Text = "Choose";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(301, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Asset Status:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 183);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.DataError +=new DataGridViewDataErrorEventHandler(dataGridView1_DataError);
            // 
            // historyBindingSource1
            // 
            this.historyBindingSource1.DataMember = "History";
            this.historyBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.depreciation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.input);
            this.Controls.Add(this.History);
            this.Controls.Add(this.home);
            this.Controls.Add(this.panel1);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Life;
        private System.Windows.Forms.TextBox ACost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button depreciation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox id;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel1;
        private ComboBox stat;
        private Label label12;
        private BindingSource historyBindingSource;
        private BindingSource historyBindingSource1;
    }
}