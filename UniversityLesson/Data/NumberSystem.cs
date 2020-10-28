using System;
using System.Windows.Forms;

namespace UniversityLesson.Data
{
    public partial class NumberSystem
    {
        public static int Count = 0;

        public int TypeSystem { get; private set; }
        public decimal CurrentNumber { get; private set; }
        public string ConvertedNumber { get; private set; }

        public NumberSystem (int typeSystem, string numberOfTypeSystem)
        {
            Count++;
            TypeSystem = typeSystem;
            ConvertedNumber = numberOfTypeSystem;
            CurrentNumber = ConvertToNational(typeSystem, numberOfTypeSystem);
        }

        public static bool CheckNumber(int typeSystem, string number)
        {
            if (number == "0") return false;

            if (!CheckType(typeSystem)) return false;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[0].ToString() == "-")
                {
                    return false;
                }
                if (Convert.ToInt32(number[i].ToString()) >= typeSystem)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckType(int type)
        {
            if (type >= 2 && type <= 9)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{ConvertedNumber}.{0}({TypeSystem})";
        }

        public static decimal ConvertToNational(int typeSystem, string numberOfTypeSystem)
        {
            if (!CheckNumber(typeSystem, numberOfTypeSystem)) return 0;

            decimal result = 0;

            for (int i = 0; i < numberOfTypeSystem.Length; i++)
            {
                if (numberOfTypeSystem[0].ToString() == "-")
                {
                    result = 0;
                    break;
                }
                result = result * typeSystem + int.Parse(numberOfTypeSystem[i].ToString());
            }

            return Math.Truncate(result);
        }

        public static decimal ConvertToTypeSystem(int type, string number)
        {
            if (number == "0") return 0;

            if (number[0].ToString() == "-") return 0;

            string strResult = "";
            decimal num = Convert.ToDecimal(number);

            while (num != 0)
            {
                strResult = (num % type).ToString() + strResult;
                num = Math.Truncate(num/type);
            }

            if (!CheckNumber(type, strResult)) return -1;
            decimal result = Convert.ToDecimal(strResult);

            return Math.Truncate(result);
        }

        private static string RemainderOfTheDivision(int type, string number)
        {
            string result = "";
            int counter = 0;
            double num = Convert.ToDouble(number);
            double processing = num - Math.Truncate(num);

            while (counter != 10)
            {
                processing *= type;

                if (processing >= 1)
                {
                    processing -= 1;
                    result += "1";
                }
                else if (processing == 0)
                {
                    break;
                }
                else
                    result += "0";
                    
            }

            if (result == "") return "0";

            return result;
        }

        public static void Sort(ref NumberSystem[] numbers)
        {
            NumberSystem temp;

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j].CurrentNumber > numbers[j + 1].CurrentNumber)
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
    }
}
