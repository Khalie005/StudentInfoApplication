namespace StudentInfoApplication
{
    partial class FrmStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstStudentID = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstLastName = new System.Windows.Forms.ListBox();
            this.lstFirstName = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.txtStudentID, "txtStudentID");
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstStudentID
            // 
            this.lstStudentID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.lstStudentID, "lstStudentID");
            this.lstStudentID.FormattingEnabled = true;
            this.lstStudentID.Name = "lstStudentID";
            this.lstStudentID.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lstLastName);
            this.panel1.Controls.Add(this.lstFirstName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lstStudentID);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtStudentID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lstLastName
            // 
            this.lstLastName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.lstLastName, "lstLastName");
            this.lstLastName.FormattingEnabled = true;
            this.lstLastName.Name = "lstLastName";
            // 
            // lstFirstName
            // 
            this.lstFirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.lstFirstName, "lstFirstName");
            this.lstFirstName.FormattingEnabled = true;
            this.lstFirstName.Name = "lstFirstName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Name = "txtFirstName";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Name = "txtLastName";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Name = "label7";
            // 
            // FrmStudentInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::StudentInfoApplication.Properties.Resources.cute_back_school_background_students_260nw_451219402;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStudentInfo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstStudentID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstLastName;
        private System.Windows.Forms.ListBox lstFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
    }
}

