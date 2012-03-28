namespace WindowsApplication1
{
    partial class Search
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
            this.depreciation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goname = new System.Windows.Forms.Button();
            this.goid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depreciation
            // 
            this.depreciation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.depreciation.Location = new System.Drawing.Point(3, 218);
            this.depreciation.Name = "depreciation";
            this.depreciation.Size = new System.Drawing.Size(75, 23);
            this.depreciation.TabIndex = 23;
            this.depreciation.Text = "Depreciation";
            this.depreciation.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 46);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fixed Assets Management System";
            // 
            // searchB
            // 
            this.searchB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchB.Location = new System.Drawing.Point(3, 160);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(75, 23);
            this.searchB.TabIndex = 18;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = false;
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input.Location = new System.Drawing.Point(3, 131);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 21;
            this.input.Text = "Input";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.view.Location = new System.Drawing.Point(3, 189);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 20;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.home.Location = new System.Drawing.Point(3, 102);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 17;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.goname);
            this.panel1.Controls.Add(this.goid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(84, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 462);
            this.panel1.TabIndex = 19;
            // 
            // goname
            // 
            this.goname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.goname.Location = new System.Drawing.Point(366, 226);
            this.goname.Name = "goname";
            this.goname.Size = new System.Drawing.Size(75, 23);
            this.goname.TabIndex = 24;
            this.goname.Text = "Go";
            this.goname.UseVisualStyleBackColor = false;
            // 
            // goid
            // 
            this.goid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.goid.Location = new System.Drawing.Point(366, 95);
            this.goid.Name = "goid";
            this.goid.Size = new System.Drawing.Size(75, 23);
            this.goid.TabIndex = 25;
            this.goid.Text = "Go";
            this.goid.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(77, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Find by Asset Name:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Find by Asset ID:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(214, 229);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(77, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Asset ID/Code:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(214, 97);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(77, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Asset Name:";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.depreciation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.input);
            this.Controls.Add(this.view);
            this.Controls.Add(this.home);
            this.Controls.Add(this.panel1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depreciation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goname;
        private System.Windows.Forms.Button goid;
        private System.Windows.Forms.Label label3;
    }
}