namespace EmployeeApplication
{
    partial class frmComputeSalary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtFIrstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtRPH = new System.Windows.Forms.TextBox();
            this.txtTHW = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.TextValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.dadadwa = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label12321 = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TextValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(250, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job Title:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rate Per Hour:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(250, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Hours Worked:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Basic Salary:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Black;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(216, 373);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 28);
            this.lblFirstName.TabIndex = 9;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Black;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(216, 423);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 28);
            this.lblLastName.TabIndex = 10;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Black;
            this.lblSalary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(216, 473);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(0, 28);
            this.lblSalary.TabIndex = 11;
            // 
            // txtFIrstName
            // 
            this.txtFIrstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFIrstName.BackColor = System.Drawing.Color.Black;
            this.txtFIrstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFIrstName.ForeColor = System.Drawing.Color.White;
            this.txtFIrstName.Location = new System.Drawing.Point(30, 56);
            this.txtFIrstName.Name = "txtFIrstName";
            this.txtFIrstName.Size = new System.Drawing.Size(170, 32);
            this.txtFIrstName.TabIndex = 12;
            this.txtFIrstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFIrstName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.BackColor = System.Drawing.Color.Black;
            this.txtLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(250, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(170, 32);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartment.BackColor = System.Drawing.Color.Black;
            this.txtDepartment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDepartment.ForeColor = System.Drawing.Color.White;
            this.txtDepartment.Location = new System.Drawing.Point(30, 146);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(170, 32);
            this.txtDepartment.TabIndex = 14;
            this.txtDepartment.Validating += new System.ComponentModel.CancelEventHandler(this.txtDepartment_Validating);
            // 
            // txtJob
            // 
            this.txtJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJob.BackColor = System.Drawing.Color.Black;
            this.txtJob.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJob.ForeColor = System.Drawing.Color.White;
            this.txtJob.Location = new System.Drawing.Point(250, 146);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(170, 32);
            this.txtJob.TabIndex = 15;
            this.txtJob.Validating += new System.ComponentModel.CancelEventHandler(this.txtJob_Validating);
            // 
            // txtRPH
            // 
            this.txtRPH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRPH.BackColor = System.Drawing.Color.Black;
            this.txtRPH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRPH.ForeColor = System.Drawing.Color.White;
            this.txtRPH.Location = new System.Drawing.Point(30, 256);
            this.txtRPH.Name = "txtRPH";
            this.txtRPH.Size = new System.Drawing.Size(170, 32);
            this.txtRPH.TabIndex = 16;
            this.txtRPH.Validating += new System.ComponentModel.CancelEventHandler(this.txtRPH_Validating);
            // 
            // txtTHW
            // 
            this.txtTHW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTHW.BackColor = System.Drawing.Color.Black;
            this.txtTHW.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTHW.ForeColor = System.Drawing.Color.White;
            this.txtTHW.Location = new System.Drawing.Point(250, 256);
            this.txtTHW.Name = "txtTHW";
            this.txtTHW.Size = new System.Drawing.Size(170, 32);
            this.txtTHW.TabIndex = 17;
            this.txtTHW.Validating += new System.ComponentModel.CancelEventHandler(this.txtTHW_Validating);
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompute.BackColor = System.Drawing.Color.Black;
            this.btnCompute.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(262, 309);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(130, 50);
            this.btnCompute.TabIndex = 18;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(83, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 50);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TextValidation
            // 
            this.TextValidation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.TextValidation.ContainerControl = this;
            // 
            // dadadwa
            // 
            this.dadadwa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dadadwa.AutoSize = true;
            this.dadadwa.BackColor = System.Drawing.Color.Black;
            this.dadadwa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dadadwa.ForeColor = System.Drawing.Color.White;
            this.dadadwa.Location = new System.Drawing.Point(41, 525);
            this.dadadwa.Name = "dadadwa";
            this.dadadwa.Size = new System.Drawing.Size(157, 28);
            this.dadadwa.TabIndex = 20;
            this.dadadwa.Text = "Department:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Black;
            this.lblDepartment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(216, 525);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 28);
            this.lblDepartment.TabIndex = 21;
            // 
            // label12321
            // 
            this.label12321.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12321.AutoSize = true;
            this.label12321.BackColor = System.Drawing.Color.Black;
            this.label12321.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12321.ForeColor = System.Drawing.Color.White;
            this.label12321.Location = new System.Drawing.Point(41, 574);
            this.label12321.Name = "label12321";
            this.label12321.Size = new System.Drawing.Size(120, 28);
            this.label12321.TabIndex = 22;
            this.label12321.Text = "Job Title:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.BackColor = System.Drawing.Color.Black;
            this.lblJobTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJobTitle.ForeColor = System.Drawing.Color.White;
            this.lblJobTitle.Location = new System.Drawing.Point(216, 574);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(0, 28);
            this.lblJobTitle.TabIndex = 23;
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(524, 621);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.label12321);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.dadadwa);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtTHW);
            this.Controls.Add(this.txtRPH);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFIrstName);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(540, 660);
            this.Name = "frmComputeSalary";
            this.Text = "Employee Salary Calculator ";
            this.Load += new System.EventHandler(this.frmComputeSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblSalary;
        private TextBox txtFIrstName;
        private TextBox txtLastName;
        private TextBox txtDepartment;
        private TextBox txtJob;
        private TextBox txtRPH;
        private TextBox txtTHW;
        private Button btnCompute;
        private Button btnClear;
        private ErrorProvider TextValidation;
        private Label lblJobTitle;
        private Label label12321;
        private Label lblDepartment;
        private Label dadadwa;
    }
}