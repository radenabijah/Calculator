namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtboxOutput.Text == "0") || (isOperationPerformed))
                txtboxOutput.Clear();

            isOperationPerformed = false;

            Button button = (Button)sender;
            try
            {
                if (button == btnPoint)
                {
                    if (!txtboxOutput.Text.Contains("."))
                    {
                        txtboxOutput.Text += ".";
                    }
                }
                else
                {
                    txtboxOutput.Text += button.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxOutput.Text = "";
            }
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEquals.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + "  " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txtboxOutput.Text);
                labelCurrentOperation.Text = resultValue + "  " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxOutput.Clear();
            resultValue = 0;
            operationPerformed = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtboxOutput.Text.Length > 0)
            {
                txtboxOutput.Text = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
            }
        }
        
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    switch (operationPerformed)
                    {
                        case "+":
                            txtboxOutput.Text = (resultValue + Double.Parse(txtboxOutput.Text)).ToString();
                            break;

                        case "-":
                            txtboxOutput.Text = (resultValue - Double.Parse(txtboxOutput.Text)).ToString();
                            break;

                        case "*":
                            txtboxOutput.Text = (resultValue * Double.Parse(txtboxOutput.Text)).ToString();
                            break;

                        case "/":
                            txtboxOutput.Text = (resultValue / Double.Parse(txtboxOutput.Text)).ToString();
                            break;

                        default:
                            break;

                    }
                    resultValue = Double.Parse(txtboxOutput.Text);
                    labelCurrentOperation.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtboxOutput.Text))
            {
                if (txtboxOutput.Text[0] == '-')
                {
                    txtboxOutput.Text = txtboxOutput.Text.Substring(1);
                }
                else
                {
                    if (txtboxOutput.Text == "0")
                    {
                        txtboxOutput.Text = "-";
                    }
                    else
                    {
                        txtboxOutput.Text = "-" + txtboxOutput.Text;
                    }
                }
            }
        }
    }

}