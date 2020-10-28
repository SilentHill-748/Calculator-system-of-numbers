using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using UniversityLesson.Data;

namespace UniversityLesson
{
    public partial class Form1 : Form
    {
        // Логика.
        private const string author = "Никита Палин";
        private const string nicknameOfAuthor = "Silent Hill";

        private readonly string currentVersion = "1.0.0";

        private NumberSystem[] arrayToNumbers;

        private NumberSystem resultOfDegree;
        private NumberSystem firstNumber;
        private NumberSystem secondNumber;

        /// <summary>
        /// Производит математические и логические операции над двумя объектами NumberSystem.
        /// </summary>
        private void GetResultOfOperation()
        {
            string operation = ListOfOperations.Text;

            switch (operation)
            {
                case "+":  
                    GetStringResult((firstNumber + secondNumber).ToString(), operation); 
                    break;
                case "-":  
                    GetStringResult((firstNumber - secondNumber).ToString(), operation); 
                    break;
                case "*":  
                    GetStringResult((firstNumber * secondNumber).ToString(), operation); 
                    break;
                case "/":  
                    GetStringResult((firstNumber / secondNumber).ToString(), operation); 
                    break;
                case "%":  
                    GetStringResult((firstNumber % secondNumber).ToString(), operation); 
                    break;
                case ">":  
                    GetBoolResult(firstNumber > secondNumber, operation); 
                    break;
                case "<":  
                    GetBoolResult(firstNumber < secondNumber, operation); 
                    break;
                case ">=": 
                    GetBoolResult(firstNumber >= secondNumber, operation);
                    break;
                case "<=": 
                    GetBoolResult(firstNumber <= secondNumber, operation); 
                    break;
                case "==": 
                    GetBoolResult(firstNumber == secondNumber, operation); 
                    break;
                case "!=": 
                    GetBoolResult(firstNumber != secondNumber, operation); 
                    break;
            }
        }

        /// <summary>
        /// Выводит результат логических операций в свойство Text объекта ResultTextBox.
        /// </summary>
        private void GetBoolResult(bool boolResult, string operation)
        {
            ResultTextBox.Text = firstNumber + $" {operation} " +
                                    secondNumber + " = " + boolResult.ToString();
        }

        /// <summary>
        /// Выводит результат математической операции в свойство Text объекта ResultTextBox.
        /// </summary>
        private void GetStringResult(string result, string operation)
        {
            ResultTextBox.Text = firstNumber + $" {operation} " +
                                   secondNumber + " = " + result;
        }

        /// <summary>
        /// Инициализирует новый объект NumberSystem.
        /// </summary>
        /// <param name="textNumber">Число.</param>
        /// <param name="typeSystem">Система счисления, соответствующая числу.</param>
        /// <param name="number">Новый объект NumberSystem.</param>
        private void InitNumber(string textNumber, string typeSystem, out NumberSystem number)
        {
            int type = Convert.ToInt32(typeSystem);
            number = new NumberSystem(type, textNumber);
        }

        /// <summary>
        /// Проверяет число на корректность ввода.
        /// </summary>
        /// <param name="firstNumber">Число.</param>
        /// <param name="type">Система счисления введенного числа.</param>
        /// <returns>True, если соответствует или False, если нет.</returns>
        private bool CheckNumber(string firstNumber, int type)
        {
            string number = firstNumber;

            if (number == "") return false;

            for (int i = 0; i < number.Length; i++)
            {
                if (int.TryParse(number[i].ToString(), out int temp))
                {
                    if (temp >= type) return false;
                }
                else
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Проверяет число на корректность ввода в свойстве Text объекта SetArrayTextBox.
        /// </summary>
        /// <param name="number">Элемент строкового массива.</param>
        /// <returns>True, если введенная строка является числом или False, если нет.</returns>
        private bool CheckNumber(string number)
        {
            if (number == "") return false;

            if (number.Length == 1) return false;

            if (!int.TryParse(number[number.Length - 1].ToString(), out int type)) return false;

            number = number.Substring(0, number.Length - 1);

            for (int i = 0; i < number.Length; i++)
            {
                if (int.TryParse(number[i].ToString(), out int temp))
                {
                    if (temp >= type) return false;
                }
                else
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Проверяет число на корректность ввода и соответствие указанной системе счисления typeSystem.
        /// </summary>
        /// <param name="number">Проверяемое число.</param>
        /// <param name="typeSystem">Система счисления, которая указана в свойстве Text объекта ComboBox.</param>
        /// <param name="wrongLabel">Объект Label, в свойство Text которого заносится лог ошибки.</param>
        private void CheckNumberSystem(ComboBox number, ComboBox typeSystem, Label wrongLabel, TextBox result)
        {
            int type;

            if (typeSystem.Text == "")
            {
                Error(result, wrongLabel, "Не указана система счисления!");
                return;
            }
            else
            {
                type = Convert.ToInt32(typeSystem.Text);
            }

            if (!CheckNumber(number.Text, type))
            {
                if (number.Text == "")
                {
                    Error(result, wrongLabel, "Пустая строка с числом!");
                    return;
                }
                else
                {
                    Error(result, wrongLabel, "Неверно записано число!");
                    return;
                }
            }
            else
            {
                wrongLabel.Text = "";
                return;
            }
        }

        /// <summary>
        /// Проверяет систему счисления typeSystem числа number и заполняет свойства Text объекта wrongLabel.
        /// </summary>
        /// <param name="typeSystem">Проверяемая система счисления.</param>
        /// <param name="number">Число в проверяемой системе.</param>
        /// <param name="wrongLabel">Объект Label, который будет содержать лог ошибки в свойстве Text.</param>
        private void CheckTypeSystem(ComboBox number, ComboBox typeSystem, Label wrongLabel, TextBox reult)
        {
            int type = Convert.ToInt32(typeSystem.Text);
            if (!CheckNumber(number.Text, type))
            {
                Error(reult, wrongLabel, "Неверно записано число!");
                return;
            }
            else
            {
                wrongLabel.Text = "";
                return;
            }
        }

        /// <summary>
        /// Проверяет строковый массив на наличие некорректного ввода.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>True - если элементы массива корректно записаны -или- False - если есть ошибки ввода.</returns>
        private bool CheckArray(string[] array)
        {
            string strError;
            foreach (string item in array)
            {
                if (SetArrayTextBox.Text == "")
                {
                    Error(SortedArrayTextBox, WrongArrayLabel, "Массив пуст.");
                    return false;
                }
                else
                {
                    if (!CheckNumber(item))
                    {
                        if (item == "")
                        {
                            Error(SortedArrayTextBox, WrongArrayLabel, "Строка ввода массива пуста!");
                            return false;
                        }
                        else
                        {
                            if (item.Length == 1)
                            {
                                strError = "Число не может быть записано без идентификатора системы!";
                                Error(SortedArrayTextBox, WrongArrayLabel, strError);
                                return false;
                            }
                            else
                            {
                                strError = "Элемент массива записан неверно или число не подходит данной системе!";
                                Error(SortedArrayTextBox, WrongArrayLabel, strError);
                                return false;
                            }
                        }
                    }
                }
            }

            WrongArrayLabel.Text = "";
            return true;
        }

        /// <summary>
        /// Преобразует строковый массив в массив объектов NumberSystem.
        /// </summary>
        /// <param name="array">Массив объектов NumberSystem, в который будет преобразован исходный массив</param>
        /// <param name="originalArray">Исходный строковый массив</param>
        private void SetArrayNumberSystem(ref NumberSystem[] array, string[] originalArray)
        {
            int lehgthArray = originalArray.Length;
            array = new NumberSystem[lehgthArray];

            int type;
            string number;
            int lengthStr;

            for (int i = 0; i < lehgthArray; i++)
            {
                lengthStr = originalArray[i].Length;
                type = Convert.ToInt32(originalArray[i].Substring(lengthStr - 1, 1));
                number = originalArray[i].Substring(0, lengthStr - 1);

                array[i] = new NumberSystem(type, number);
            }
        }

        /// <summary>
        /// Удаляет пробелы в элементах строкого массива.
        /// </summary>
        /// <param name="numbers">Исходный массив с пробелами в начале или конце элементов</param>
        /// <returns>Новый строковый массив без пробелов в начале и конце каждого элемента.</returns>
        private string[] RemoveSpaces(string[] numbers)
        {
            string[] newNumbers = new string[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = numbers[i].Trim();
            }
            
            return newNumbers;
        }

        /// <summary>
        /// Выводит в свойство Text объекта SortedArrayTextBox массив объектов NumberSystem.
        /// </summary>
        /// <param name="array"></param>
        private void GetResultArray(NumberSystem[] array)
        {
            SortedArrayTextBox.Text = "";
            foreach (NumberSystem item in array)
            {
                SortedArrayTextBox.Text += $"{item} ";
            }
        }

        /// <summary>
        /// Задает и возвращает объект NumberSystem, свойства CurrentNumber и ConvertedNumber возведенное в указанную степень degreeNumber.
        /// </summary>
        /// <param name="typeSystem">Система счисления числа</param>
        /// <param name="strNumber">Сконвертированное значение, которое пользователь вписывает исходя из указанной системы</param>
        /// <param name="degreeNumber">Степень</param>
        /// <param name="number">Объект NumberSystem, который будет инициализирован с возведенными значениями</param>
        private void GetDegreeNumber(string typeSystem, string strNumber, string degreeNumber, out NumberSystem number)
        {
            decimal temp;
            int type = Convert.ToInt32(typeSystem);
            int degree = Convert.ToInt32(degreeNumber);

            decimal newCurrentNumber = NumberSystem.ConvertToNational(type, strNumber);
            temp = newCurrentNumber;
            for (int i = 1; i != degree; i++)
            {
                newCurrentNumber *= temp;
            }

            decimal newConvertedNumber = NumberSystem.ConvertToTypeSystem(type, newCurrentNumber.ToString());

            number = new NumberSystem(type, newConvertedNumber.ToString());
        }

        /// <summary>
        /// Присваевает всем объектам TextBox значение по умолчанию.
        /// </summary>
        private void RemoveTextBoxes()
        {
            SortedArrayTextBox.Text = "Нет данных.";
            ResultDegreeNumberTextBox.Text = "Нет данных.";
            ResultTextBox.Text = "Нет данных.";
            SetArrayTextBox.Text = "";
        }

        /// <summary>
        /// Присваевает всем объектам ComboBox значение по умолчанию.
        /// </summary>
        private void RemoveComboBoxes()
        {
            TypeSystemFirstNumber.SelectedIndex = -1;
            TypeSystemSecondNumber.SelectedIndex = -1;
            ListOfOperations.SelectedIndex = -1;
            TypeSystemDegreeNumber.SelectedIndex = -1;

            NumberForDegree.Text = "";
            DegreeNumber.Text = "";
            FirstNumber.Text = "";
            SecondNumber.Text = "";
        }

        /// <summary>
        /// Присваевает всем объектам Label значение по умолчанию.
        /// </summary>
        private void RemoveLabels()
        {
            WrongLabel1.Text = "";
            WrongLabel2.Text = "";
            WrongOperationLabel.Text = "";
            WrongChoiceLabel.Text = "";
            WrongArrayLabel.Text = "";
            ResultDegreeNumberLabel.Text = "Результат возведения:";
            ResultLabel.Text = "Результат:";
        }

        /// <summary>
        /// В TextBox заносит значение по умолчанию и заносит указанный textError в объект wrongLabel.
        /// </summary>
        private void Error(TextBox textResult, Label wrongLabel, string textError)
        {
            textResult.Text = "Нет данных.";
            wrongLabel.Text = textError;
        }
    }
}
