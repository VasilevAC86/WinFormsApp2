using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class NumberBox : TextBox
    {
        public NumberBox()
        {
            //InitializeComponent();
        }
        public double Value
        {
            get
            {
                return Convert.ToDouble(this.Text);
            }
            set
            {
                this.Text = Convert.ToString(value);
            }
        }
        new private void KeyUp(object sender, KeyEventArgs e)
            {
                if ((!(e.KeyValue >= 0 && e.KeyValue <=9)) || (e.KeyCode != Keys.Decimal))
                {
                    e.Handled = true;
                }
            }        
    }
}
