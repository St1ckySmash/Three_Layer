namespace ThreeLayer.PL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DepartmentList = new ListBox();
            DeleteDepartmentButton = new Button();
            AddDepartmentTextBox = new TextBox();
            DepartmentName = new Label();
            FirstNameTextBox = new TextBox();
            DeleteEmployeeButton = new Button();
            EmployeeList = new ListBox();
            DepartmentSearch = new ListBox();
            EmployeesSearch = new ListBox();
            EmployeeFieldSearchTextBox = new TextBox();
            SearchButton = new Button();
            SaveButton = new Button();
            AddDepartmentButton = new Button();
            AddEmployeeButton = new Button();
            EmployeeFirstName = new Label();
            EmployeePosition = new Label();
            EmployeeLastName = new Label();
            LastNameTextBox = new TextBox();
            PositionTextBox = new TextBox();
            SearchParameters = new Button();
            SuspendLayout();
            // 
            // DepartmentList
            // 
            DepartmentList.BackColor = Color.Gainsboro;
            DepartmentList.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DepartmentList.FormattingEnabled = true;
            DepartmentList.ItemHeight = 16;
            DepartmentList.Location = new Point(13, 12);
            DepartmentList.Margin = new Padding(4, 3, 4, 3);
            DepartmentList.Name = "DepartmentList";
            DepartmentList.Size = new Size(227, 196);
            DepartmentList.TabIndex = 0;
            DepartmentList.SelectedIndexChanged += Department_SelectedIndexChanged;
            // 
            // DeleteDepartmentButton
            // 
            DeleteDepartmentButton.BackColor = Color.FromArgb(108, 60, 51);
            DeleteDepartmentButton.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteDepartmentButton.Location = new Point(288, 158);
            DeleteDepartmentButton.Margin = new Padding(4, 3, 4, 3);
            DeleteDepartmentButton.Name = "DeleteDepartmentButton";
            DeleteDepartmentButton.Size = new Size(146, 51);
            DeleteDepartmentButton.TabIndex = 1;
            DeleteDepartmentButton.Text = "Удалить отдел";
            DeleteDepartmentButton.UseVisualStyleBackColor = false;
            DeleteDepartmentButton.Click += DeleteDepartmentButton_Click;
            // 
            // AddDepartmentTextBox
            // 
            AddDepartmentTextBox.BackColor = Color.Gainsboro;
            AddDepartmentTextBox.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddDepartmentTextBox.Location = new Point(288, 55);
            AddDepartmentTextBox.Margin = new Padding(4, 3, 4, 3);
            AddDepartmentTextBox.Name = "AddDepartmentTextBox";
            AddDepartmentTextBox.Size = new Size(146, 22);
            AddDepartmentTextBox.TabIndex = 2;
            AddDepartmentTextBox.KeyDown += AddDepartmentTextBox_KeyDown;
            // 
            // DepartmentName
            // 
            DepartmentName.AutoSize = true;
            DepartmentName.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DepartmentName.Location = new Point(305, 12);
            DepartmentName.Margin = new Padding(4, 0, 4, 0);
            DepartmentName.Name = "DepartmentName";
            DepartmentName.Size = new Size(111, 16);
            DepartmentName.TabIndex = 4;
            DepartmentName.Text = "Название отдела";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.BackColor = Color.Gainsboro;
            FirstNameTextBox.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTextBox.Location = new Point(324, 283);
            FirstNameTextBox.Margin = new Padding(4, 3, 4, 3);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(129, 22);
            FirstNameTextBox.TabIndex = 7;
            FirstNameTextBox.KeyDown += FirstNameTextBox_KeyDown;
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.BackColor = Color.FromArgb(108, 60, 51);
            DeleteEmployeeButton.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteEmployeeButton.Location = new Point(288, 442);
            DeleteEmployeeButton.Margin = new Padding(4, 3, 4, 3);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new Size(146, 51);
            DeleteEmployeeButton.TabIndex = 6;
            DeleteEmployeeButton.Text = "Удалить работника";
            DeleteEmployeeButton.UseVisualStyleBackColor = false;
            DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
            // 
            // EmployeeList
            // 
            EmployeeList.BackColor = Color.Gainsboro;
            EmployeeList.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeList.FormattingEnabled = true;
            EmployeeList.ItemHeight = 16;
            EmployeeList.Location = new Point(12, 233);
            EmployeeList.Margin = new Padding(4, 3, 4, 3);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.Size = new Size(228, 260);
            EmployeeList.TabIndex = 5;
            EmployeeList.SelectedIndexChanged += EmployeeList_SelectedIndexChanged;
            // 
            // DepartmentSearch
            // 
            DepartmentSearch.BackColor = Color.Gainsboro;
            DepartmentSearch.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DepartmentSearch.FormattingEnabled = true;
            DepartmentSearch.ItemHeight = 16;
            DepartmentSearch.Location = new Point(477, 12);
            DepartmentSearch.Margin = new Padding(4, 3, 4, 3);
            DepartmentSearch.Name = "DepartmentSearch";
            DepartmentSearch.Size = new Size(192, 196);
            DepartmentSearch.TabIndex = 10;
            DepartmentSearch.SelectedIndexChanged += DepartmentSearch_SelectedIndexChanged;
            // 
            // EmployeesSearch
            // 
            EmployeesSearch.BackColor = Color.Gainsboro;
            EmployeesSearch.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeesSearch.FormattingEnabled = true;
            EmployeesSearch.ItemHeight = 16;
            EmployeesSearch.Location = new Point(477, 233);
            EmployeesSearch.Margin = new Padding(4, 3, 4, 3);
            EmployeesSearch.Name = "EmployeesSearch";
            EmployeesSearch.Size = new Size(192, 260);
            EmployeesSearch.TabIndex = 11;
            // 
            // EmployeeFieldSearchTextBox
            // 
            EmployeeFieldSearchTextBox.BackColor = Color.Gainsboro;
            EmployeeFieldSearchTextBox.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeFieldSearchTextBox.Location = new Point(694, 115);
            EmployeeFieldSearchTextBox.Margin = new Padding(4, 3, 4, 3);
            EmployeeFieldSearchTextBox.Name = "EmployeeFieldSearchTextBox";
            EmployeeFieldSearchTextBox.Size = new Size(145, 22);
            EmployeeFieldSearchTextBox.TabIndex = 13;
            EmployeeFieldSearchTextBox.KeyDown += EmployeeFieldSearchTextBox_KeyDown;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(108, 60, 51);
            SearchButton.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.Location = new Point(693, 158);
            SearchButton.Margin = new Padding(4, 3, 4, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(146, 51);
            SearchButton.TabIndex = 14;
            SearchButton.Text = "Найти";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(108, 60, 51);
            SaveButton.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(694, 442);
            SaveButton.Margin = new Padding(4, 3, 4, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(145, 51);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddDepartmentButton
            // 
            AddDepartmentButton.BackColor = Color.FromArgb(108, 60, 51);
            AddDepartmentButton.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddDepartmentButton.Location = new Point(288, 101);
            AddDepartmentButton.Margin = new Padding(4, 3, 4, 3);
            AddDepartmentButton.Name = "AddDepartmentButton";
            AddDepartmentButton.Size = new Size(146, 51);
            AddDepartmentButton.TabIndex = 16;
            AddDepartmentButton.Text = "Добавить отдел";
            AddDepartmentButton.UseVisualStyleBackColor = false;
            AddDepartmentButton.Click += AddDepartmentButton_Click;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.BackColor = Color.FromArgb(108, 60, 51);
            AddEmployeeButton.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddEmployeeButton.Location = new Point(288, 385);
            AddEmployeeButton.Margin = new Padding(4, 3, 4, 3);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(146, 51);
            AddEmployeeButton.TabIndex = 17;
            AddEmployeeButton.Text = "Добавить работника";
            AddEmployeeButton.UseVisualStyleBackColor = false;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // EmployeeFirstName
            // 
            EmployeeFirstName.AutoSize = true;
            EmployeeFirstName.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeFirstName.ForeColor = Color.FromArgb(224, 224, 224);
            EmployeeFirstName.Location = new Point(247, 283);
            EmployeeFirstName.Name = "EmployeeFirstName";
            EmployeeFirstName.Size = new Size(33, 16);
            EmployeeFirstName.TabIndex = 22;
            EmployeeFirstName.Text = "Имя";
            // 
            // EmployeePosition
            // 
            EmployeePosition.AutoSize = true;
            EmployeePosition.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeePosition.Location = new Point(247, 339);
            EmployeePosition.Name = "EmployeePosition";
            EmployeePosition.Size = new Size(72, 16);
            EmployeePosition.TabIndex = 23;
            EmployeePosition.Text = "Должность";
            // 
            // EmployeeLastName
            // 
            EmployeeLastName.AutoSize = true;
            EmployeeLastName.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeLastName.Location = new Point(247, 311);
            EmployeeLastName.Name = "EmployeeLastName";
            EmployeeLastName.Size = new Size(62, 16);
            EmployeeLastName.TabIndex = 24;
            EmployeeLastName.Text = "Фамилия";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.BackColor = Color.Gainsboro;
            LastNameTextBox.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTextBox.Location = new Point(324, 311);
            LastNameTextBox.Margin = new Padding(4, 3, 4, 3);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(129, 22);
            LastNameTextBox.TabIndex = 25;
            LastNameTextBox.KeyDown += LastNameTextBox_KeyDown;
            // 
            // PositionTextBox
            // 
            PositionTextBox.BackColor = Color.Gainsboro;
            PositionTextBox.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PositionTextBox.Location = new Point(324, 339);
            PositionTextBox.Margin = new Padding(4, 3, 4, 3);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(129, 22);
            PositionTextBox.TabIndex = 26;
            PositionTextBox.KeyDown += PositionTextBox_KeyDown;
            // 
            // SearchParameters
            // 
            SearchParameters.BackColor = Color.FromArgb(108, 60, 51);
            SearchParameters.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchParameters.Location = new Point(694, 16);
            SearchParameters.Name = "SearchParameters";
            SearchParameters.Size = new Size(145, 51);
            SearchParameters.TabIndex = 27;
            SearchParameters.Text = "Параметры поиска";
            SearchParameters.UseVisualStyleBackColor = false;
            SearchParameters.Click += SearchParameters_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 107, 92);
            ClientSize = new Size(857, 509);
            Controls.Add(SearchParameters);
            Controls.Add(PositionTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(EmployeeLastName);
            Controls.Add(EmployeePosition);
            Controls.Add(EmployeeFirstName);
            Controls.Add(DepartmentName);
            Controls.Add(AddEmployeeButton);
            Controls.Add(AddDepartmentButton);
            Controls.Add(SaveButton);
            Controls.Add(SearchButton);
            Controls.Add(EmployeeFieldSearchTextBox);
            Controls.Add(EmployeesSearch);
            Controls.Add(DepartmentSearch);
            Controls.Add(FirstNameTextBox);
            Controls.Add(DeleteEmployeeButton);
            Controls.Add(EmployeeList);
            Controls.Add(AddDepartmentTextBox);
            Controls.Add(DeleteDepartmentButton);
            Controls.Add(DepartmentList);
            ForeColor = Color.FromArgb(224, 224, 224);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "DataBase";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DepartmentList;
        private Button DeleteDepartmentButton;
        private TextBox AddDepartmentTextBox;
        private Label DepartmentName;
        private TextBox FirstNameTextBox;
        private Button DeleteEmployeeButton;
        private ListBox EmployeeList;
        private ListBox DepartmentSearch;
        private ListBox EmployeesSearch;
        private TextBox EmployeeFieldSearchTextBox;
        private Button SearchButton;
        private Button SaveButton;
        private Button AddDepartmentButton;
        private Button AddEmployeeButton;
        private Label EmployeeFirstName;
        private Label EmployeePosition;
        private Label EmployeeLastName;
        private TextBox LastNameTextBox;
        private TextBox PositionTextBox;
        private Button SearchParameters;
    }
}

