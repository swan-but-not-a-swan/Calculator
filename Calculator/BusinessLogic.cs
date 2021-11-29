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
        public bool pluswasclicked { get; set; } = false;
        public bool minuswasclicked { get; set; } = false;
        public bool multiplywasclicked { get; set; } = false;
        public bool dividewasclicked { get; set; } = false;
        public bool percentagewasclicked { get; set; } = false;
        public bool square_rootwasclicked { get; set; } = false;
        public bool sinwasclicked { get; set; } = false;
        public bool coswasclicked { get; set; } = false;
        public bool tanwasclicked { get; set; } = false;
        public bool sinhwasclicked { get; set; } = false;
        public bool coshwasclicked { get; set; } = false;
        public bool tanhwasclicked { get; set; } = false;
        
        /// <summary>
        /// check the current state of all the operations
        /// </summary>
        /// <returns></returns>
        public bool operationStatechecker()
        {
            if (pluswasclicked == true || minuswasclicked == true || multiplywasclicked == true || dividewasclicked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// check the current state of sqrt and trigo
        /// </summary>
        /// <returns></returns>
        public bool TrigoSqrtStatechecker()
        {
            if (square_rootwasclicked == true || sinwasclicked == true || coswasclicked == true || tanwasclicked == true || 
                sinhwasclicked == true || coshwasclicked == true || tanhwasclicked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// reset some of the operations
        /// </summary>
        public void operationReset()
        {
            pluswasclicked = false;
            minuswasclicked = false;
            multiplywasclicked = false;
            dividewasclicked = false;
            second = 0;
        }
        /// <summary>
        /// reset all of the operations
        /// </summary>
        public void Reset()
        {
            operationReset();
            percentagewasclicked = false;
            first = 0;
            number.Clear();
        }
        public bool enableOperation(bool operation)
        {
            if ((first != 0) && (operation == false) && (second == 0))
            {
                return true;
            }
            else
            {
                first = 0;
                second = 0;
                MessageBox.Show("Please input a proper syntax, click (CE) to procedd");
                Reset();
                return false;
            }
        }
        /// <summary>
        /// check the state of the percentagewasclicked and convert or not convert based on the state
        /// </summary>
        /// <returns></returns>
        public bool PercentageStateChecker()//i hav no idea how to name
        {
            if (!percentagewasclicked)
            {
                converter();
            }
            return true;
        }
        
        public bool CalcTrigoSqrt()
        {
            if(TrigoSqrtStatechecker())
            {
                if ((first != 0) && (second == 0))
                {
                    first = TrigoSqrtOption(first);
                    return true;
                }
                if ((first != 0) && (second != 0))
                {
                    second = TrigoSqrtOption(second);
                    return false;
                }
            }
            return false;
        }
    }
}
