using System;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Squirrel;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Arithmetic arithmetic = new Arithmetic();
        private string trigo;
        public Form1()
        {
            InitializeComponent();
            CheckforUpdates();
        }
        private async Task CheckforUpdates()
        {
            using (var manager = new UpdateManager(@"C: \Users\Acer\Source\Repos\Calculator\Releases"))
            {
                await manager.UpdateApp();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trigoOption.SelectedIndex = 0;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void one_Click(object sender, EventArgs e)
        {
            calculations('1');
        }
        private void two_Click(object sender, EventArgs e)
        {
            calculations('2');
        }
        private void three_Click(object sender, EventArgs e)
        {
            calculations('3');
        }
        private void four_Click(object sender, EventArgs e)
        {
            calculations('4');
        }
        private void five_Click(object sender, EventArgs e)
        {
            calculations('5');
        }
        private void six_Click(object sender, EventArgs e)
        {
            calculations('6');
        }
        private void seven_Click(object sender, EventArgs e)
        {
            calculations('7');
        }
        private void eight_Click(object sender, EventArgs e)
        {
            calculations('8');
        }

        private void nine_Click(object sender, EventArgs e)
        {
            calculations('9');
        }
        private void zero_Click(object sender, EventArgs e)
        {
            calculations('0');
        }
        private void dot_Click(object sender, EventArgs e)
        {
            calculations('.');
        }
        private void negative_value_Click(object sender, EventArgs e)
        {
            calculations('-');
        }
        private void clear_Click(object sender, EventArgs e)
        {
            arithmetic.Reset();
            label.Text = " ";
        }
        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                arithmetic.number.Remove(arithmetic.number.Length - 1, 1);
            }
            catch
            {
                MessageBox.Show("there's nth more to delete");
                arithmetic.Reset();
            }
            label.Text=label.Text.Remove(label.Text.Length - 1);
        }
        private void plus_Click(object sender, EventArgs e)
        {
            continousCalculation();//this is the fuckin bug
            arithmetic.pluswasclicked = arithmetic.enableOperation(arithmetic.pluswasclicked);
            if (arithmetic.pluswasclicked)
            {
                label.Text += "+";
            }
        }
        private void minus_Click(object sender, EventArgs e)
        {
            continousCalculation();
            arithmetic.minuswasclicked=arithmetic.enableOperation(arithmetic.minuswasclicked);
            if (arithmetic.minuswasclicked)
            {
                label.Text += "-";
            }
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            continousCalculation();
            arithmetic.multiplywasclicked=arithmetic.enableOperation(arithmetic.multiplywasclicked);
            if (arithmetic.multiplywasclicked)
            {
                label.Text += "*";
            }
        }
        private void divider_Click(object sender, EventArgs e)
        {
            continousCalculation();
            arithmetic.dividewasclicked=arithmetic.enableOperation(arithmetic.dividewasclicked);
            if (arithmetic.dividewasclicked)
            {
                label.Text += "/";
            }
        }
        private void equal_Click(object sender, EventArgs e)
        {
            arithmetic.PercentageStateChecker();
            arithmetic.CalcTrigoSqrt();
            string result=arithmetic.Options();
            label.Text = result;
            arithmetic.operationReset();
            
        }
        private void percentage_Click(object sender, EventArgs e)
        {
            arithmetic.percentagewasclicked = true;
            arithmetic.converter();
            arithmetic.percentageOperation();
            label.Text += "%";
        }
        private void square_root_Click(object sender, EventArgs e)
        {
            arithmetic.square_rootwasclicked = true;
            label.Text += "√";
        }
        private void Showthevalueonbutton(object sender, EventArgs e)
        {
            trigo= trigoOption.SelectedItem.ToString();
            Trigobutton.Text = trigo;
        }
        private void Trigobutton_Click(object sender, EventArgs e)
        {
            switch(trigo)
            {
                case "sin":
                    arithmetic.sinwasclicked = true;
                    label.Text+="sin";
                    break;
                case "cos":
                    arithmetic.coswasclicked = true;
                    label.Text += "cos";
                    break;
                case "tan":
                    arithmetic.tanwasclicked = true;
                    label.Text += "tan";
                    break;
                case "sin^-1":
                    arithmetic.sinhwasclicked = true;
                    label.Text += "sin^-1";
                    break;
                case "cos^-1":
                    arithmetic.coshwasclicked = true;
                    label.Text += "cos^-1";
                    break;
                case "tan^-1":
                    arithmetic.tanhwasclicked = true;
                    label.Text += "tan^-1";
                    break;
            }
        }
        private void calculations(char a)
        {
            label.Text += a;
            arithmetic.number.Append(a);
        }
        private void continousCalculation()
        {
            if (arithmetic.PercentageStateChecker())//to check whether percentage was clicked
            {
                arithmetic.percentagewasclicked = false;
            }
            arithmetic.CalcTrigoSqrt();
            if (arithmetic.operationStatechecker() && (arithmetic.first != 0) && (arithmetic.second != 0))//for continous calculation
            {
                string result = arithmetic.Options();
                label.Text = result;
                arithmetic.operationReset();
                arithmetic.number.Clear();
            }
            if(arithmetic.operationStatechecker() && (arithmetic.first!= 0) && (arithmetic.second == 0))
            {
                MessageBox.Show("wrong syntax, click (CE) to procedd");
                arithmetic.Reset();
            }
        }
    }
}


