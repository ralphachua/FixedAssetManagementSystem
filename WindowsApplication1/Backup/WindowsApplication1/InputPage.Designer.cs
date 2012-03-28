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
            this.history = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.stat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.remarks = new System.Windows.Forms.RichTextBox();
            this.details = new System.Windows.Forms.RichTextBox();
            this.life = new System.Windows.Forms.TextBox();
            this.years = new System.Windows.Forms.TextBox();
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
            this.view = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.depreciation = new System.Windows.Forms.Button();
            this.database1DataSet = new WindowsApplication1.Database1DataSet();
            this.historyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particularsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource1)).BeginInit();
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
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.stat);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.remarks);
            this.panel1.Controls.Add(this.details);
            this.panel1.Controls.Add(this.life);
            this.panel1.Controls.Add(this.years);
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // history
            // 
            this.history.AllowUserToDeleteRows = false;
            this.history.AutoGenerateColumns = false;
            this.history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.particularsDataGridViewTextBoxColumn,
            this.typeOfTransactionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.history.DataSource = this.historyBindingSource1;
            this.history.Location = new System.Drawing.Point(71, 241);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(550, 91);
            this.history.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(68, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Track History:";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(220, 106);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 20);
            this.type.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(68, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Asset Type:";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Office Equipment and Machinery",
            "Transportation Equipment",
            "Furniture",
            "Office Supplies",
            "Leasehold Equipment",
            "Tools",
            "Computer Hardware",
            "Computer Software"});
            this.category.Location = new System.Drawing.Point(220, 133);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 28;
            this.category.Text = "Choose";
            // 
            // stat
            // 
            this.stat.Location = new System.Drawing.Point(220, 80);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(100, 20);
            this.stat.TabIndex = 27;
            this.stat.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(68, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Asset Status:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
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
            // 
            // remarks
            // 
            this.remarks.Location = new System.Drawing.Point(220, 341);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(313, 52);
            this.remarks.TabIndex = 23;
            this.remarks.Text = "";
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(220, 163);
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
            // years
            // 
            this.years.Location = new System.Drawing.Point(504, 132);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(100, 20);
            this.years.TabIndex = 12;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(503, 106);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(100, 20);
            this.cost.TabIndex = 11;
            this.cost.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(220, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 10;
            this.name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(503, 54);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 9;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(68, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Special Remarks:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(68, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Asset Purchase Details:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(68, 140);
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
            this.label7.Location = new System.Drawing.Point(366, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Asset Depreciation Years:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(366, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Asset Acquisition Cost:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(68, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Asset Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(366, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Asset ID/Code:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Write in all information";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
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
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.view.Location = new System.Drawing.Point(3, 189);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 3;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = false;
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
            this.input.Click += new System.EventHandler(this.button3_Click);
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
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyBindingSource1
            // 
            this.historyBindingSource1.DataMember = "History";
            this.historyBindingSource1.DataSource = this.database1DataSet;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // particularsDataGridViewTextBoxColumn
            // 
            this.particularsDataGridViewTextBoxColumn.DataPropertyName = "Particulars";
            this.particularsDataGridViewTextBoxColumn.HeaderText = "Particulars";
            this.particularsDataGridViewTextBoxColumn.Name = "particularsDataGridViewTextBoxColumn";
            // 
            // typeOfTransactionDataGridViewTextBoxColumn
            // 
            this.typeOfTransactionDataGridViewTextBoxColumn.DataPropertyName = "Type of Transaction";
            this.typeOfTransactionDataGridViewTextBoxColumn.HeaderText = "Type of Transaction";
            this.typeOfTransactionDataGridViewTextBoxColumn.Name = "typeOfTransactionDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
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
            this.Controls.Add(this.view);
            this.Controls.Add(this.home);
            this.Controls.Add(this.panel1);
            this.Name = "InputPage";
            this.Text = "Input";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox life;
        private System.Windows.Forms.TextBox years;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.RichTextBox remarks;
        private System.Windows.Forms.RichTextBox details;
        private System.Windows.Forms.TextBox stat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView history;
        private System.Windows.Forms.Button depreciation;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn particularsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historyBindingSource1;
    }
}

