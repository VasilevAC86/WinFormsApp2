using System.Globalization;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(numberBox1.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US"); // Культура америка-британия
            double number;
            string s = textBox1.Text.Replace(",", "."); // Заменяем запятые на точки
            Double.TryParse(s, culture, out number);
            numberBox1.Value = number;
        }
    }
}
