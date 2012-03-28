namespace WindowsApplication1
{
    partial class View
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
            this.goid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.depreciation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.TextBox();
            this.searchB = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.ViewB = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goid
            // 
            this.goid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.goid.Location = new System.Drawing.Point(479, 86);
            this.goid.Name = "goid";
            this.goid.Size = new System.Drawing.Size(75, 23);
            this.goid.TabIndex = 25;
            this.goid.Text = "Go";
            this.goid.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(53, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "View by Category:";
            // 
            // depreciation
            // 
            this.depreciation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.depreciation.Location = new System.Drawing.Point(3, 218);
            this.depreciation.Name = "depreciation";
            this.depreciation.Size = new System.Drawing.Size(75, 23);
            this.depreciation.TabIndex = 30;
            this.depreciation.Text = "Depreciation";
            this.depreciation.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "View by Date:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.goid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.start);
            this.panel1.Location = new System.Drawing.Point(84, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 462);
            this.panel1.TabIndex = 26;
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
            this.category.Location = new System.Drawing.Point(169, 225);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 38;
            this.category.Text = "Choose";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(53, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Asset Category:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(261, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "End Date:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(479, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(53, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Start Date:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 253);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(261, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "End Date:";
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(352, 88);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(100, 20);
            this.end.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(53, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Start Date:";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(140, 88);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 20);
            this.start.TabIndex = 26;
            // 
            // searchB
            // 
            this.searchB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchB.Location = new System.Drawing.Point(3, 160);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(75, 23);
            this.searchB.TabIndex = 25;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = false;
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input.Location = new System.Drawing.Point(3, 131);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 28;
            this.input.Text = "Input";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // ViewB
            // 
            this.ViewB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewB.Location = new System.Drawing.Point(3, 189);
            this.ViewB.Name = "ViewB";
            this.ViewB.Size = new System.Drawing.Size(75, 23);
            this.ViewB.TabIndex = 27;
            this.ViewB.Text = "View";
            this.ViewB.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.home.Location = new System.Drawing.Point(3, 102);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 24;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 46);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fixed Assets Management System";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.depreciation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.input);
            this.Controls.Add(this.ViewB);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label2);
            this.Name = "View";
            this.Text = "View";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button depreciation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button ViewB;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label9;
    }
}