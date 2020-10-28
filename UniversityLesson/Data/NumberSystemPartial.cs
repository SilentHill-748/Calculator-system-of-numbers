using System;

namespace UniversityLesson.Data
{
    /// <summary>
    /// Представляет работу со системами счисления.
    /// </summary>
    public partial class NumberSystem
    {
        public static NumberSystem operator +(NumberSystem sys1, NumberSystem sys2)
        {
            decimal sum = sys1.CurrentNumber + sys2.CurrentNumber;
            decimal result = ConvertToTypeSystem(sys1.TypeSystem, sum.ToString());
            result = Math.Truncate(result);

            return new NumberSystem(sys1.TypeSystem, result.ToString());
        }

        public static NumberSystem operator -(NumberSystem sys1, NumberSystem sys2)
        {
            decimal difference = sys1.CurrentNumber - sys2.CurrentNumber;
            decimal result = ConvertToTypeSystem(sys1.TypeSystem, difference.ToString());
            result = Math.Truncate(result);

            return new NumberSystem(sys1.TypeSystem, result.ToString());
        }

        public static NumberSystem operator *(NumberSystem sys1, NumberSystem sys2)
        {
            decimal multiply = sys1.CurrentNumber * sys2.CurrentNumber;
            decimal result = ConvertToTypeSystem(sys1.TypeSystem, multiply.ToString());
            result = Math.Truncate(result);

            return new NumberSystem(sys1.TypeSystem, result.ToString());
        }

        public static NumberSystem operator /(NumberSystem sys1, NumberSystem sys2)
        {
            decimal temp;
            decimal result;

            try
            {
                temp = Math.Truncate(sys1.CurrentNumber / sys2.CurrentNumber);
                result = ConvertToTypeSystem(sys1.TypeSystem, temp.ToString());
                result = Math.Truncate(result);
            }
            catch (DivideByZeroException)
            {
                result = 0;
            }
            return new NumberSystem(sys1.TypeSystem, result.ToString());
        }

        public static string operator %(NumberSystem sys1, NumberSystem sys2)
        {
            decimal temp1;
            decimal temp2;
            decimal divisionResult;
            string remainderResult;
            try
            {
                temp1 = Math.Truncate(sys1.CurrentNumber / sys2.CurrentNumber);
                divisionResult = ConvertToTypeSystem(sys1.TypeSystem, temp1.ToString());

                temp2 = Math.Truncate(Convert.ToDecimal(sys1.CurrentNumber) / Convert.ToDecimal(sys2.CurrentNumber));
                remainderResult = RemainderOfTheDivision(sys1.TypeSystem, temp2.ToString());
            }
            catch (DivideByZeroException)
            {
                divisionResult = 0;
                remainderResult = "0";
            }
            return divisionResult + "." + remainderResult + $"({sys1.TypeSystem})";
        }

        public static bool operator >(NumberSystem sys1, NumberSystem sys2)
        {
            if (sys1.CurrentNumber > sys2.CurrentNumber)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <(NumberSystem sys1, NumberSystem sys2)
        {
            if (sys1.CurrentNumber < sys2.CurrentNumber)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator >=(NumberSystem sys1, NumberSystem sys2)
        {
            if (sys1.CurrentNumber >= sys2.CurrentNumber)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <=(NumberSystem sys1, NumberSystem sys2)
        {
            if (sys1.CurrentNumber <= sys2.CurrentNumber)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator ==(NumberSystem sys1, NumberSystem sys2)
        {
            if (sys1.CurrentNumber == sys2.CurrentNumber)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(NumberSystem sys1, NumberSystem sys2)
        {
            if (sys1.CurrentNumber != sys2.CurrentNumber)
            {
                return true;
            }
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
