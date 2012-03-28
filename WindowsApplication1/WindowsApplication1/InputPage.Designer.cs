using System.Windows.Forms;
namespace WindowsApplication1
{
    partial class InputPage
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
            this.home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Qty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.refNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.stat = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.remarks = new System.Windows.Forms.RichTextBox();
            this.details = new System.Windows.Forms.RichTextBox();
            this.life = new System.Windows.Forms.TextBox();
            this.AcquiDate = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.depreciation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.home.Location = new System.Drawing.Point(3, 102);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Qty);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.refNum);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.stat);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.remarks);
            this.panel1.Controls.Add(this.details);
            this.panel1.Controls.Add(this.life);
            this.panel1.Controls.Add(this.AcquiDate);
            this.panel1.Controls.Add(this.cost);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(84, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 462);
            this.panel1.TabIndex = 6;
            // 
            // Qty
            // 
            this.Qty.Location = new System.Drawing.Point(206, 154);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(100, 20);
            this.Qty.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(68, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Quantity:";
            // 
            // refNum
            // 
            this.refNum.Location = new System.Drawing.Point(206, 130);
            this.refNum.Name = "refNum";
            this.refNum.Size = new System.Drawing.Size(100, 20);
            this.refNum.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(68, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Reference Number:";
            // 
            // stat
            // 
            this.stat.FormattingEnabled = true;
            this.stat.Items.AddRange(new object[] {
            "In Use",
            "For Repair",
            "Fully Depreciated",
            "Disposed"});
            this.stat.Location = new System.Drawing.Point(206, 79);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(100, 21);
            this.stat.TabIndex = 34;
            this.stat.Text = "Choose";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(150, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 114);
            this.dataGridView1.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Particulars";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type of Transaction";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cost";
            this.Column4.Name = "Column4";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(68, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Track History:";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Office Equipment",
            "Machinery",
            "Transportation Equipment",
            "Office Furniture",
            "Leasehold Improvement",
            "Tools",
            "Computer Hardware",
            "Computer Software"});
            this.category.Location = new System.Drawing.Point(206, 106);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(100, 21);
            this.category.TabIndex = 28;
            this.category.Text = "Choose";
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(68, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Asset Status:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.submit.Location = new System.Drawing.Point(562, 420);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 25;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reset.Location = new System.Drawing.Point(481, 420);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 24;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // remarks
            // 
            this.remarks.BackColor = System.Drawing.SystemColors.Window;
            this.remarks.Location = new System.Drawing.Point(220, 360);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(313, 52);
            this.remarks.TabIndex = 23;
            this.remarks.Text = "";
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(283, 182);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(313, 52);
            this.details.TabIndex = 22;
            this.details.Text = "";
            // 
            // life
            // 
            this.life.Location = new System.Drawing.Point(503, 80);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(100, 20);
            this.life.TabIndex = 13;
            // 
            // AcquiDate
            // 
            this.AcquiDate.Location = new System.Drawing.Point(504, 130);
            this.AcquiDate.Name = "AcquiDate";
            this.AcquiDate.Size = new System.Drawing.Size(100, 20);
            this.AcquiDate.TabIndex = 12;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(503, 106);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(100, 20);
            this.cost.TabIndex = 11;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(206, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 10;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(503, 54);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(68, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Special Remarks:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(68, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Asset Purchase Details:(Can be left blank)";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(68, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Asset Category:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(366, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Asset Useful Life:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(366, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Asset Acquisition Date:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(366, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Asset Acquisition Cost:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(68, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Asset Name:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(366, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Asset ID/Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Write in all information: (Red Box indicates an \r\nInput Error)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Fixed Assets System";
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.History.Location = new System.Drawing.Point(3, 189);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(75, 23);
            this.History.TabIndex = 3;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input.Location = new System.Drawing.Point(3, 131);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 4;
            this.input.Text = "Input";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.search.Location = new System.Drawing.Point(3, 160);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fixed Assets Management System";
            // 
            // depreciation
            // 
            this.depreciation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.depreciation.Location = new System.Drawing.Point(3, 218);
            this.depreciation.Name = "depreciation";
            this.depreciation.Size = new System.Drawing.Size(75, 23);
            this.depreciation.TabIndex = 16;
            this.depreciation.Text = "Depreciation";
            this.depreciation.UseVisualStyleBackColor = false;
            this.depreciation.Click += new System.EventHandler(this.depreciation_Click);
            // 
            // InputPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.depreciation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.input);
            this.Controls.Add(this.History);
            this.Controls.Add(this.home);
            this.Controls.Add(this.panel1);
            this.Name = "InputPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox life;
        private System.Windows.Forms.TextBox AcquiDate;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.RichTextBox remarks;
        private System.Windows.Forms.RichTextBox details;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button depreciation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox stat;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox refNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.Label label15;
    }
}

