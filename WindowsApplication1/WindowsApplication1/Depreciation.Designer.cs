namespace WindowsApplication1
{
    partial class Depreciation
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
            this.category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.searchB = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.ViewB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gocategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.category.Location = new System.Drawing.Point(157, 100);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 38;
            this.category.Text = "Choose";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(41, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Asset Category:";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.home.Location = new System.Drawing.Point(4, 102);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 31;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // searchB
            // 
            this.searchB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchB.Location = new System.Drawing.Point(4, 160);
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
            this.input.Location = new System.Drawing.Point(4, 131);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 35;
            this.input.Text = "Input";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // ViewB
            // 
            this.ViewB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewB.Location = new System.Drawing.Point(4, 189);
            this.ViewB.Name = "ViewB";
            this.ViewB.Size = new System.Drawing.Size(75, 23);
            this.ViewB.TabIndex = 34;
            this.ViewB.Text = "View";
            this.ViewB.UseVisualStyleBackColor = false;
            this.ViewB.Click += new System.EventHandler(this.ViewB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(87, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 46);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fixed Assets Management System";
            // 
            // gocategory
            // 
            this.gocategory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gocategory.Location = new System.Drawing.Point(301, 98);
            this.gocategory.Name = "gocategory";
            this.gocategory.Size = new System.Drawing.Size(75, 23);
            this.gocategory.TabIndex = 33;
            this.gocategory.Text = "Go";
            this.gocategory.UseVisualStyleBackColor = false;
            this.gocategory.Click += new System.EventHandler(this.gocategory_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.gocategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(85, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 462);
            this.panel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "View Depreciation by Category:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(4, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Depreciation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Depreciation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.home);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.input);
            this.Controls.Add(this.ViewB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Depreciation";
            this.Text = "Depreciation";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button ViewB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gocategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}