using System.Windows.Forms;
namespace WindowsApplication1
{
    partial class SubmitEdit
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
            this.depreciation = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchAgain = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depreciation
            // 
            this.depreciation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.depreciation.Location = new System.Drawing.Point(3, 218);
            this.depreciation.Name = "depreciation";
            this.depreciation.Size = new System.Drawing.Size(75, 23);
            this.depreciation.TabIndex = 22;
            this.depreciation.Text = "Depreciation";
            this.depreciation.UseVisualStyleBackColor = false;
            this.depreciation.Click += new System.EventHandler(this.depreciation_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.home.Location = new System.Drawing.Point(3, 102);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 16;
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
            this.label2.TabIndex = 20;
            this.label2.Text = "Fixed Assets Management System";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.search.Location = new System.Drawing.Point(3, 160);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 17;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input.Location = new System.Drawing.Point(3, 131);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 19;
            this.input.Text = "Input";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Edit is complete.Search in the search page again to view, edit, or print your ass" +
                "et.";
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.History.Location = new System.Drawing.Point(3, 189);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(75, 23);
            this.History.TabIndex = 18;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchAgain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.done);
            this.panel1.Location = new System.Drawing.Point(84, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 462);
            this.panel1.TabIndex = 21;
            // 
            // SearchAgain
            // 
            this.SearchAgain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SearchAgain.Location = new System.Drawing.Point(178, 123);
            this.SearchAgain.Name = "SearchAgain";
            this.SearchAgain.Size = new System.Drawing.Size(100, 23);
            this.SearchAgain.TabIndex = 27;
            this.SearchAgain.Text = "Search Again";
            this.SearchAgain.UseVisualStyleBackColor = false;
            this.SearchAgain.Click += new System.EventHandler(this.SearchAgain_Click);
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.done.Location = new System.Drawing.Point(353, 123);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 25;
            this.done.Text = "Home";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // SubmitEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.depreciation);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.input);
            this.Controls.Add(this.History);
            this.Controls.Add(this.panel1);
            this.Name = "SubmitEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubmitEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depreciation;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button SearchAgain;
    }
}