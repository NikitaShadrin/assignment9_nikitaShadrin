using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_9
{
    public partial class Form1 : Form
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dictionary.Clear();
                string text = textBox1.Text;

                foreach (char c in text)
                {
                    if (dictionary.ContainsKey(Char.ToLower(c)))
                    {
                        dictionary[Char.ToLower(c)]++;
                    }
                    else
                    {
                        dictionary.Add(Char.ToLower(c), 1);
                    }
                }
                var maxValueKey = dictionary.OrderByDescending(x => x.Value).First().Key;
                label1.Text = "Most frequent character is " + maxValueKey.ToString();
            }
            catch
            {
                label1.Text = "Input is wrong";
            }

        }
    }
}
