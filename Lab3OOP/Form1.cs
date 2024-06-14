using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PerformOperation("Add");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            PerformOperation("Subtract");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            PerformOperation("Multiply");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            PerformOperation("Divide");
        }

        private void PerformOperation(string operation)
        {
            Number num1 = null, num2 = null;

            if (numberTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a number type.");
                return;
            }

            string selectedType = numberTypeComboBox.SelectedItem.ToString();

            try
            {
                if (selectedType == "Integer")
                {
                    num1 = new Integer(int.Parse(textBox1.Text));
                    num2 = new Integer(int.Parse(textBox2.Text));
                }
                else if (selectedType == "Real")
                {
                    num1 = new Real(double.Parse(textBox1.Text));
                    num2 = new Real(double.Parse(textBox2.Text));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            Number result = null;

            switch (operation)
            {
                case "Add":
                    result = num1.Add(num2);
                    break;
                case "Subtract":
                    result = num1.Subtract(num2);
                    break;
                case "Multiply":
                    result = num1.Multiply(num2);
                    break;
                case "Divide":
                    result = num1.Divide(num2);
                    break;
            }

            resultLabel.Text = result.ToString();
        }
    }
}
