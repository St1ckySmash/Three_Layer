namespace ThreeLayer.PL
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            OrganizationParameter = new RadioButton();
            DepartmentParameter = new RadioButton();
            groupBox2 = new GroupBox();
            PositionParameter = new RadioButton();
            LastNameParameter = new RadioButton();
            FirstNameParameter = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrganizationParameter);
            groupBox1.Controls.Add(DepartmentParameter);
            groupBox1.Location = new Point(44, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(152, 95);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // OrganizationParameter
            // 
            OrganizationParameter.AutoSize = true;
            OrganizationParameter.Location = new Point(18, 47);
            OrganizationParameter.Name = "OrganizationParameter";
            OrganizationParameter.Size = new Size(115, 19);
            OrganizationParameter.TabIndex = 1;
            OrganizationParameter.TabStop = true;
            OrganizationParameter.Text = "По организации";
            OrganizationParameter.UseVisualStyleBackColor = true;
            OrganizationParameter.CheckedChanged += OrganizationParameter_CheckedChanged;
            // 
            // DepartmentParameter
            // 
            DepartmentParameter.AutoSize = true;
            DepartmentParameter.Location = new Point(18, 22);
            DepartmentParameter.Name = "DepartmentParameter";
            DepartmentParameter.Size = new Size(81, 19);
            DepartmentParameter.TabIndex = 0;
            DepartmentParameter.TabStop = true;
            DepartmentParameter.Text = "По отделу";
            DepartmentParameter.UseVisualStyleBackColor = true;
            DepartmentParameter.CheckedChanged += DepartmentParameter_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PositionParameter);
            groupBox2.Controls.Add(LastNameParameter);
            groupBox2.Controls.Add(FirstNameParameter);
            groupBox2.Location = new Point(44, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(152, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // PositionParameter
            // 
            PositionParameter.AutoSize = true;
            PositionParameter.Location = new Point(17, 72);
            PositionParameter.Name = "PositionParameter";
            PositionParameter.Size = new Size(105, 19);
            PositionParameter.TabIndex = 2;
            PositionParameter.TabStop = true;
            PositionParameter.Text = "По должности";
            PositionParameter.UseVisualStyleBackColor = true;
            PositionParameter.CheckedChanged += PositionParameter_CheckedChanged;
            // 
            // LastNameParameter
            // 
            LastNameParameter.AutoSize = true;
            LastNameParameter.Location = new Point(17, 47);
            LastNameParameter.Name = "LastNameParameter";
            LastNameParameter.Size = new Size(96, 19);
            LastNameParameter.TabIndex = 1;
            LastNameParameter.TabStop = true;
            LastNameParameter.Text = "По фамилии";
            LastNameParameter.UseVisualStyleBackColor = true;
            LastNameParameter.CheckedChanged += LastNameParameter_CheckedChanged;
            // 
            // FirstNameParameter
            // 
            FirstNameParameter.AutoSize = true;
            FirstNameParameter.Location = new Point(17, 22);
            FirstNameParameter.Name = "FirstNameParameter";
            FirstNameParameter.Size = new Size(80, 19);
            FirstNameParameter.TabIndex = 0;
            FirstNameParameter.TabStop = true;
            FirstNameParameter.Text = "По имени";
            FirstNameParameter.UseVisualStyleBackColor = true;
            FirstNameParameter.CheckedChanged += FirstNameParameter_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 280);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton OrganizationParameter;
        private RadioButton DepartmentParameter;
        private GroupBox groupBox2;
        private RadioButton PositionParameter;
        private RadioButton LastNameParameter;
        private RadioButton FirstNameParameter;
    }
}