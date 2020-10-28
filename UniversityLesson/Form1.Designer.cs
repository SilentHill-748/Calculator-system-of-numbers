namespace UniversityLesson
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.FirstNumber = new System.Windows.Forms.ComboBox();
            this.SecondNumber = new System.Windows.Forms.ComboBox();
            this.TypeSystemFirstNumber = new System.Windows.Forms.ComboBox();
            this.TypeSystemSecondNumber = new System.Windows.Forms.ComboBox();
            this.ListOfOperations = new System.Windows.Forms.ComboBox();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.SetNumbersForOperationsLabel = new System.Windows.Forms.Label();
            this.SetNumbersForArrayLabel = new System.Windows.Forms.Label();
            this.SortArray = new System.Windows.Forms.Button();
            this.SortedArrayTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.WrongLabel1 = new System.Windows.Forms.Label();
            this.WrongLabel2 = new System.Windows.Forms.Label();
            this.WrongOperationLabel = new System.Windows.Forms.Label();
            this.WrongArrayLabel = new System.Windows.Forms.Label();
            this.SetArrayTextBox = new System.Windows.Forms.TextBox();
            this.DegreeNumber = new System.Windows.Forms.ComboBox();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.WrongChoiceLabel = new System.Windows.Forms.Label();
            this.ResultDegreeNumberLabel = new System.Windows.Forms.Label();
            this.GetResultDegreeButton = new System.Windows.Forms.Button();
            this.ResultDegreeNumberTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.TypeSystemDegreeNumber = new System.Windows.Forms.ComboBox();
            this.NumberForDegree = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CleanToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CleanToolStripMenuItem
            // 
            this.CleanToolStripMenuItem.Name = "CleanToolStripMenuItem";
            this.CleanToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.CleanToolStripMenuItem.Text = "Clean form";
            this.CleanToolStripMenuItem.Click += new System.EventHandler(this.CleanToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(660, 498);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(77, 13);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Альфа Х.Х.ХХ";
            // 
            // FirstNumber
            // 
            this.FirstNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.FirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNumber.FormattingEnabled = true;
            this.FirstNumber.Location = new System.Drawing.Point(12, 61);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(121, 32);
            this.FirstNumber.TabIndex = 3;
            this.FirstNumber.TextChanged += new System.EventHandler(this.FirstNumber_TextChanged);
            // 
            // SecondNumber
            // 
            this.SecondNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.SecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNumber.FormattingEnabled = true;
            this.SecondNumber.Location = new System.Drawing.Point(12, 127);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(121, 32);
            this.SecondNumber.TabIndex = 4;
            this.SecondNumber.TextChanged += new System.EventHandler(this.SecondNumber_TextChanged);
            // 
            // TypeSystemFirstNumber
            // 
            this.TypeSystemFirstNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSystemFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeSystemFirstNumber.FormattingEnabled = true;
            this.TypeSystemFirstNumber.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.TypeSystemFirstNumber.Location = new System.Drawing.Point(139, 61);
            this.TypeSystemFirstNumber.Name = "TypeSystemFirstNumber";
            this.TypeSystemFirstNumber.Size = new System.Drawing.Size(52, 32);
            this.TypeSystemFirstNumber.TabIndex = 5;
            this.TypeSystemFirstNumber.DropDownClosed += new System.EventHandler(this.TypeSystemFirstNumber_DropDownClosed);
            // 
            // TypeSystemSecondNumber
            // 
            this.TypeSystemSecondNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSystemSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeSystemSecondNumber.FormattingEnabled = true;
            this.TypeSystemSecondNumber.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.TypeSystemSecondNumber.Location = new System.Drawing.Point(139, 127);
            this.TypeSystemSecondNumber.Name = "TypeSystemSecondNumber";
            this.TypeSystemSecondNumber.Size = new System.Drawing.Size(52, 32);
            this.TypeSystemSecondNumber.TabIndex = 6;
            this.TypeSystemSecondNumber.DropDownClosed += new System.EventHandler(this.TypeSystemSecondNumber_DropDownClosed);
            // 
            // ListOfOperations
            // 
            this.ListOfOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListOfOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfOperations.FormattingEnabled = true;
            this.ListOfOperations.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%",
            ">",
            "<",
            ">=",
            "<=",
            "==",
            "!="});
            this.ListOfOperations.Location = new System.Drawing.Point(139, 205);
            this.ListOfOperations.Name = "ListOfOperations";
            this.ListOfOperations.Size = new System.Drawing.Size(52, 32);
            this.ListOfOperations.TabIndex = 7;
            this.ListOfOperations.DropDownClosed += new System.EventHandler(this.ListOfOperations_DropDownClosed);
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationLabel.Location = new System.Drawing.Point(8, 208);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(110, 24);
            this.OperationLabel.TabIndex = 8;
            this.OperationLabel.Text = "Операция: ";
            // 
            // SetNumbersForOperationsLabel
            // 
            this.SetNumbersForOperationsLabel.AutoSize = true;
            this.SetNumbersForOperationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetNumbersForOperationsLabel.Location = new System.Drawing.Point(8, 34);
            this.SetNumbersForOperationsLabel.Name = "SetNumbersForOperationsLabel";
            this.SetNumbersForOperationsLabel.Size = new System.Drawing.Size(281, 24);
            this.SetNumbersForOperationsLabel.TabIndex = 9;
            this.SetNumbersForOperationsLabel.Text = "Введите число и его систему.";
            // 
            // SetNumbersForArrayLabel
            // 
            this.SetNumbersForArrayLabel.AutoSize = true;
            this.SetNumbersForArrayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetNumbersForArrayLabel.Location = new System.Drawing.Point(8, 393);
            this.SetNumbersForArrayLabel.Name = "SetNumbersForArrayLabel";
            this.SetNumbersForArrayLabel.Size = new System.Drawing.Size(390, 24);
            this.SetNumbersForArrayLabel.TabIndex = 11;
            this.SetNumbersForArrayLabel.Text = "Задайте массив, разделяя числа запятой.";
            // 
            // SortArray
            // 
            this.SortArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortArray.Location = new System.Drawing.Point(597, 418);
            this.SortArray.Name = "SortArray";
            this.SortArray.Size = new System.Drawing.Size(131, 34);
            this.SortArray.TabIndex = 12;
            this.SortArray.Text = "Сортировка";
            this.SortArray.UseVisualStyleBackColor = true;
            this.SortArray.Click += new System.EventHandler(this.SortArray_Click);
            // 
            // SortedArrayTextBox
            // 
            this.SortedArrayTextBox.Enabled = false;
            this.SortedArrayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortedArrayTextBox.Location = new System.Drawing.Point(12, 455);
            this.SortedArrayTextBox.Name = "SortedArrayTextBox";
            this.SortedArrayTextBox.Size = new System.Drawing.Size(579, 29);
            this.SortedArrayTextBox.TabIndex = 13;
            this.SortedArrayTextBox.Text = "Нет данных.";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(8, 289);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(113, 24);
            this.ResultLabel.TabIndex = 14;
            this.ResultLabel.Text = "Результат: ";
            // 
            // WrongLabel1
            // 
            this.WrongLabel1.AutoSize = true;
            this.WrongLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongLabel1.Location = new System.Drawing.Point(8, 96);
            this.WrongLabel1.Name = "WrongLabel1";
            this.WrongLabel1.Size = new System.Drawing.Size(80, 24);
            this.WrongLabel1.TabIndex = 15;
            this.WrongLabel1.Text = "Ошибка";
            // 
            // WrongLabel2
            // 
            this.WrongLabel2.AutoSize = true;
            this.WrongLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongLabel2.Location = new System.Drawing.Point(8, 162);
            this.WrongLabel2.Name = "WrongLabel2";
            this.WrongLabel2.Size = new System.Drawing.Size(80, 24);
            this.WrongLabel2.TabIndex = 16;
            this.WrongLabel2.Text = "Ошибка";
            // 
            // WrongOperationLabel
            // 
            this.WrongOperationLabel.AutoSize = true;
            this.WrongOperationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongOperationLabel.Location = new System.Drawing.Point(8, 241);
            this.WrongOperationLabel.Name = "WrongOperationLabel";
            this.WrongOperationLabel.Size = new System.Drawing.Size(80, 24);
            this.WrongOperationLabel.TabIndex = 17;
            this.WrongOperationLabel.Text = "Ошибка";
            // 
            // WrongArrayLabel
            // 
            this.WrongArrayLabel.AutoSize = true;
            this.WrongArrayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongArrayLabel.Location = new System.Drawing.Point(8, 487);
            this.WrongArrayLabel.Name = "WrongArrayLabel";
            this.WrongArrayLabel.Size = new System.Drawing.Size(80, 24);
            this.WrongArrayLabel.TabIndex = 18;
            this.WrongArrayLabel.Text = "Ошибка";
            // 
            // SetArrayTextBox
            // 
            this.SetArrayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetArrayTextBox.Location = new System.Drawing.Point(12, 420);
            this.SetArrayTextBox.Name = "SetArrayTextBox";
            this.SetArrayTextBox.Size = new System.Drawing.Size(579, 29);
            this.SetArrayTextBox.TabIndex = 19;
            // 
            // DegreeNumber
            // 
            this.DegreeNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.DegreeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DegreeNumber.FormattingEnabled = true;
            this.DegreeNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.DegreeNumber.Location = new System.Drawing.Point(547, 109);
            this.DegreeNumber.Name = "DegreeNumber";
            this.DegreeNumber.Size = new System.Drawing.Size(52, 32);
            this.DegreeNumber.TabIndex = 23;
            this.DegreeNumber.TextChanged += new System.EventHandler(this.DegreeNumber_TextChanged);
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DegreeLabel.Location = new System.Drawing.Point(351, 112);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(190, 24);
            this.DegreeLabel.TabIndex = 24;
            this.DegreeLabel.Text = "Выберите степень: ";
            // 
            // WrongChoiceLabel
            // 
            this.WrongChoiceLabel.AutoSize = true;
            this.WrongChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongChoiceLabel.Location = new System.Drawing.Point(351, 152);
            this.WrongChoiceLabel.Name = "WrongChoiceLabel";
            this.WrongChoiceLabel.Size = new System.Drawing.Size(80, 24);
            this.WrongChoiceLabel.TabIndex = 25;
            this.WrongChoiceLabel.Text = "Ошибка";
            // 
            // ResultDegreeNumberLabel
            // 
            this.ResultDegreeNumberLabel.AutoSize = true;
            this.ResultDegreeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultDegreeNumberLabel.Location = new System.Drawing.Point(351, 190);
            this.ResultDegreeNumberLabel.Name = "ResultDegreeNumberLabel";
            this.ResultDegreeNumberLabel.Size = new System.Drawing.Size(227, 24);
            this.ResultDegreeNumberLabel.TabIndex = 26;
            this.ResultDegreeNumberLabel.Text = "Результат возведения: ";
            // 
            // GetResultDegreeButton
            // 
            this.GetResultDegreeButton.BackColor = System.Drawing.SystemColors.Control;
            this.GetResultDegreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetResultDegreeButton.Location = new System.Drawing.Point(596, 65);
            this.GetResultDegreeButton.Name = "GetResultDegreeButton";
            this.GetResultDegreeButton.Size = new System.Drawing.Size(132, 31);
            this.GetResultDegreeButton.TabIndex = 27;
            this.GetResultDegreeButton.Text = "Рассчитать";
            this.GetResultDegreeButton.UseVisualStyleBackColor = false;
            this.GetResultDegreeButton.Click += new System.EventHandler(this.GetResultDegreeButton_Click);
            // 
            // ResultDegreeNumberTextBox
            // 
            this.ResultDegreeNumberTextBox.Enabled = false;
            this.ResultDegreeNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultDegreeNumberTextBox.Location = new System.Drawing.Point(355, 217);
            this.ResultDegreeNumberTextBox.Name = "ResultDegreeNumberTextBox";
            this.ResultDegreeNumberTextBox.Size = new System.Drawing.Size(373, 29);
            this.ResultDegreeNumberTextBox.TabIndex = 28;
            this.ResultDegreeNumberTextBox.Text = "Нет данных.";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(12, 316);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(716, 29);
            this.ResultTextBox.TabIndex = 29;
            this.ResultTextBox.Text = "Нет данных.";
            // 
            // TypeSystemDegreeNumber
            // 
            this.TypeSystemDegreeNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSystemDegreeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeSystemDegreeNumber.FormattingEnabled = true;
            this.TypeSystemDegreeNumber.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.TypeSystemDegreeNumber.Location = new System.Drawing.Point(524, 65);
            this.TypeSystemDegreeNumber.Name = "TypeSystemDegreeNumber";
            this.TypeSystemDegreeNumber.Size = new System.Drawing.Size(52, 32);
            this.TypeSystemDegreeNumber.TabIndex = 31;
            this.TypeSystemDegreeNumber.DropDownClosed += new System.EventHandler(this.TypeSystemDegreeNumber_DropDownClosed);
            // 
            // NumberForDegree
            // 
            this.NumberForDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NumberForDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberForDegree.FormattingEnabled = true;
            this.NumberForDegree.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.NumberForDegree.Location = new System.Drawing.Point(355, 65);
            this.NumberForDegree.Name = "NumberForDegree";
            this.NumberForDegree.Size = new System.Drawing.Size(163, 32);
            this.NumberForDegree.TabIndex = 32;
            this.NumberForDegree.TextChanged += new System.EventHandler(this.NumberForDegree_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(743, 519);
            this.ControlBox = false;
            this.Controls.Add(this.NumberForDegree);
            this.Controls.Add(this.TypeSystemDegreeNumber);
            this.Controls.Add(this.SetArrayTextBox);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.SetNumbersForArrayLabel);
            this.Controls.Add(this.DegreeLabel);
            this.Controls.Add(this.SortArray);
            this.Controls.Add(this.FirstNumber);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SortedArrayTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TypeSystemFirstNumber);
            this.Controls.Add(this.WrongArrayLabel);
            this.Controls.Add(this.TypeSystemSecondNumber);
            this.Controls.Add(this.ListOfOperations);
            this.Controls.Add(this.ResultDegreeNumberTextBox);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.SetNumbersForOperationsLabel);
            this.Controls.Add(this.DegreeNumber);
            this.Controls.Add(this.WrongLabel1);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.WrongLabel2);
            this.Controls.Add(this.WrongOperationLabel);
            this.Controls.Add(this.GetResultDegreeButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.WrongChoiceLabel);
            this.Controls.Add(this.ResultDegreeNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор систем счисления";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CleanToolStripMenuItem;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.ComboBox FirstNumber;
        private System.Windows.Forms.ComboBox SecondNumber;
        private System.Windows.Forms.ComboBox TypeSystemFirstNumber;
        private System.Windows.Forms.ComboBox TypeSystemSecondNumber;
        private System.Windows.Forms.ComboBox ListOfOperations;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.Label SetNumbersForOperationsLabel;
        private System.Windows.Forms.Label SetNumbersForArrayLabel;
        private System.Windows.Forms.Button SortArray;
        private System.Windows.Forms.TextBox SortedArrayTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label WrongLabel1;
        private System.Windows.Forms.Label WrongLabel2;
        private System.Windows.Forms.Label WrongOperationLabel;
        private System.Windows.Forms.Label WrongArrayLabel;
        private System.Windows.Forms.TextBox SetArrayTextBox;
        private System.Windows.Forms.ComboBox DegreeNumber;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.Label WrongChoiceLabel;
        private System.Windows.Forms.Label ResultDegreeNumberLabel;
        private System.Windows.Forms.Button GetResultDegreeButton;
        private System.Windows.Forms.TextBox ResultDegreeNumberTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.ComboBox TypeSystemDegreeNumber;
        private System.Windows.Forms.ComboBox NumberForDegree;
    }
}

