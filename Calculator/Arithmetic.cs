using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Arithmetic
    {
        public StringBuilder number = new StringBuilder();
        public decimal first = 0;
        public decimal second = 0;
        /// <summary>
        /// convert string to decimal
        /// </summary>
        public void converter()//convert stringbuilder -> string -> decimal
        {
            if (operationStatechecker())
            {
                decimal.TryParse(number.ToString(),out second);
                number.Clear();
            }
            else
            { 
                decimal.TryParse(number.ToString(),out first);
                number.Clear();
            }
        }
        /// <summary>
        /// perform the actual calculations
        /// </summary>
        /// <returns></returns>
        public string Options()//do the actual calculations
        {
            if (pluswasclicked == true)
            {
                first += second;
                number.Append(first.ToString());
                return first.ToString();
            }
            if (minuswasclicked == true)
            {
                first -= second;
                number.Append(first.ToString());
                return first.ToString();
            }
            if (multiplywasclicked == true)
            {
                first *= second;
                number.Append(first.ToString());
                return first.ToString();
            }
            if (dividewasclicked == true)
            {
                try
                {
                    first /= second;
                    number.Append(first.ToString());
                    return first.ToString();
                }
                catch 
                {
                    MessageBox.Show("Fun fact: u can't divide a number with 0");
                    Reset();
                }
            }
            return first.ToString();
        }
        /// <summary>
        /// perform the calculation for percentage
        /// </summary>
        public void percentageOperation()
        {
            if ((first != 0) && (second == 0) && !operationStatechecker())
            { 
                first /= 100;
            }
            if ((first != 0) && (second != 0) && operationStatechecker())
            {
                second /= 100;
            }
        }
        public double degrees(decimal number)
        {
            double first_double = Convert.ToDouble(number);
            first_double = Math.PI * first_double / 180.0;
            return first_double;
        }
        /// <summary>
        /// perform trigonomentry and square root operations
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal TrigoSqrtOption(decimal value)
        {
            decimal result = 0;
            if (square_rootwasclicked)//for square root operation
            {
                result = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(value)));
                square_rootwasclicked = false;
                return result;
            }
            if (sinwasclicked)
            {
                result = Convert.ToDecimal(Math.Sin(degrees(value)));
                sinwasclicked = false;
                return result;
            }
            if (coswasclicked)
            {
                result = Convert.ToDecimal(Math.Cos(degrees(value)));
                coswasclicked = false;
                return result;
            }
            if (tanwasclicked)
            {
                result = Convert.ToDecimal(Math.Tan(degrees(value)));
                tanwasclicked = false;
                return result;
            }
            if (sinhwasclicked)
            {
                try
                {
                    result = Convert.ToDecimal(Math.Asin(Convert.ToDouble(value)));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString() + "Click CE to proceed");
                }
                result = result * 180 / Convert.ToDecimal(Math.PI);
                sinhwasclicked = false;
                return result;
            }
            if (coshwasclicked)
            {
                try
                {
                    result = Convert.ToDecimal(Math.Acos(Convert.ToDouble(value)));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString() + "Click CE to proceed");
                }
                result = result * 180 / Convert.ToDecimal(Math.PI);
                coshwasclicked = false;
                return result;
            }
            if (tanhwasclicked)
            {
                try
                {
                    result = Convert.ToDecimal(Math.Atan(Convert.ToDouble(value)));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString() + "Click CE to proceed");
                }
                result = result * 180 / Convert.ToDecimal(Math.PI);
                tanhwasclicked = false;
                return result;
            }
            return result;
        }
    }
}
