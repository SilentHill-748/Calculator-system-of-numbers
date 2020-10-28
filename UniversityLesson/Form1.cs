using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityLesson.Data;

namespace UniversityLesson
{
    public partial class Form1 : Form
    {
        // Тут обработка событий.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemoveLabels();
            VersionLabel.Text = "Release: " + currentVersion;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = $"Автор: {author} ({nicknameOfAuthor})\n" +
                $"\nВерсия: {currentVersion}";
            MessageBox.Show(message);
        }

        private void CleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTextBoxes();
            RemoveComboBoxes();
            RemoveLabels();
        }

        private void FirstNumber_TextChanged(object sender, EventArgs e)
        {
            CheckNumberSystem(FirstNumber, TypeSystemFirstNumber, WrongLabel1, ResultTextBox);
        }

        private void TypeSystemFirstNumber_DropDownClosed(object sender, EventArgs e)
        {
            if (TypeSystemFirstNumber.Text == "") return;
            
            CheckTypeSystem(FirstNumber, TypeSystemFirstNumber, WrongLabel1, ResultTextBox);
        }

        private void SecondNumber_TextChanged(object sender, EventArgs e)
        {
            CheckNumberSystem(SecondNumber, TypeSystemSecondNumber, WrongLabel2, ResultTextBox);
        }

        private void TypeSystemSecondNumber_DropDownClosed(object sender, EventArgs e)
        {
            if (TypeSystemSecondNumber.Text == "") return;
            
            CheckTypeSystem(SecondNumber, TypeSystemSecondNumber, WrongLabel2, ResultTextBox);
        }

        private void ListOfOperations_DropDownClosed(object sender, EventArgs e)
        {
            if (WrongLabel1.Text != "") return;

            if (WrongLabel2.Text != "") return;

            if (ListOfOperations.Text == "")
            {
                WrongOperationLabel.Text = "Не указана операция!";
                return;
            }
            else
            {
                InitNumber(FirstNumber.Text, TypeSystemFirstNumber.Text, out firstNumber);
                InitNumber(SecondNumber.Text, TypeSystemSecondNumber.Text, out secondNumber);
                GetResultOfOperation();
            }
        }
        
        private void SortArray_Click(object sender, EventArgs e)
        {
            string[] numbers = SetArrayTextBox.Text.Split(',');

            numbers = RemoveSpaces(numbers);

            if (CheckArray(numbers))
            {
                SetArrayNumberSystem(ref arrayToNumbers, numbers);
                NumberSystem.Sort(ref arrayToNumbers);
                GetResultArray(arrayToNumbers);
            }
        }

        private void NumberForDegree_TextChanged(object sender, EventArgs e)
        {
            CheckNumberSystem(NumberForDegree, TypeSystemDegreeNumber, WrongChoiceLabel, ResultDegreeNumberTextBox);

            if (WrongChoiceLabel.Text != "") ResultDegreeNumberTextBox.Text = "Нет данных.";
        }

        private void TypeSystemDegreeNumber_DropDownClosed(object sender, EventArgs e)
        {
            if (TypeSystemDegreeNumber.Text == "") return;

            CheckTypeSystem(NumberForDegree, TypeSystemDegreeNumber, WrongChoiceLabel, ResultDegreeNumberTextBox);

            if (WrongChoiceLabel.Text != "") ResultDegreeNumberTextBox.Text = "Нет данных.";
            
        }

        private void GetResultDegreeButton_Click(object sender, EventArgs e)
        {
            if (NumberForDegree.Text == "") return;

            if (TypeSystemDegreeNumber.Text == "") return;

            int type = Convert.ToInt32(TypeSystemDegreeNumber.Text);

            if (CheckNumber(NumberForDegree.Text, type))
            {
                if (DegreeNumber.Text != "")
                {
                    InitNumber(NumberForDegree.Text, TypeSystemDegreeNumber.Text, out resultOfDegree);
                    GetDegreeNumber(TypeSystemDegreeNumber.Text, NumberForDegree.Text, DegreeNumber.Text, out resultOfDegree);
                    ResultDegreeNumberTextBox.Text = resultOfDegree.ToString();
                }
                else
                    Error(ResultDegreeNumberTextBox, WrongChoiceLabel, "Не указана степень!");
            }
        }

        private void DegreeNumber_TextChanged(object sender, EventArgs e)
        {
            if (NumberForDegree.Text != "" && TypeSystemDegreeNumber.Text != "")
            {
                if (DegreeNumber.Text == "")
                {
                    Error(ResultDegreeNumberTextBox, WrongChoiceLabel, "Введите показатель степени!");
                    return;
                }
                else
                {
                    WrongChoiceLabel.Text = "";
                    return;
                }
            }
            else
            {
                Error(ResultDegreeNumberTextBox, WrongChoiceLabel, "Укажите число или его систему!");
                return;
            }    
        }
    }
}
