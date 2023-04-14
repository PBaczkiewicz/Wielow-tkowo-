using System;
using System.Threading;
using System.Windows.Forms;

namespace Wielowątkowość
{
    public partial class Form1 : Form
    {
        string printValue;
        int numbers;
        int values=1;
        int startValues = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {


            startValues = 1;
            numbers = (int)numericUpDown.Value;
            for (int i = 0; i < numbers; i++)
            {
                startValues *= 10;
            }
            values = startValues;
            //MessageBox.Show(values.ToString());
            timer1.Interval = 100;
            progressBar.Maximum = values;
            
            
            timer1.Start();
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            printValue = values.ToString();
            for (int j = 1; j < numbers + 1; j++)
            {
                richTextBox1.AppendText(printValue[j].ToString());
            }
            progressBar.Value = (values - startValues)+1;
            labelProgress.Text = "Permutacja : " + ((values - startValues)+1).ToString() +"/"+startValues.ToString();
            richTextBox1.AppendText("\n");
            values++;
            if (values > startValues * 2-1)
            {
                timer1.Stop();
            }

        }
    }
}
