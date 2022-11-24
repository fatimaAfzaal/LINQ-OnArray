using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_VP
{
    public partial class Form1 : Form
    {
        String[] stdnm = new String[13] { "Kamran", "Ali", "Umar", "Usama", "Asim", "Sameer", "Ali", "Azeem", "Salman", "Abdullah", "Farooqeazam", "Umar", "Ahad" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)                  //search names
        {
            try{
                String names = "";
                int count = 0;
                var search =
                    from std in stdnm
                    where (std.Equals(textBox1.Text))
                    select std;
                foreach (String name in search)
                {
                    names = name;
                    count++;
                }
                textBox2.Text = names + " found " + count + " times";
                textBox1.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input format");
            }

        }

        private void button2_Click(object sender, EventArgs e)              //name starts with
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter any character");
            }
            else
            {
                try
                {
                    String combineString = "";
                    var search =
                        from std in stdnm
                        where (std.StartsWith(textBox3.Text))
                        select std;
                    foreach (String name in search)
                    {
                        combineString = combineString + name + " ";
                    }
                    textBox2.Text = combineString;
                    textBox3.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Incorrect input format");
                }
            }
           

        }

        private void button3_Click(object sender, EventArgs e)                  //length of string
        {
            try
            {
                String combineString = "";
                var search =
                    from std in stdnm
                    where (std.Length == int.Parse(textBox4.Text))
                    select std;
                foreach (String name in search)
                {
                    combineString = combineString + " " + name;
                }
                textBox2.Text = combineString;
                textBox4.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input!!!!");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)              //contain alphabet
        {
            try
            {
                String combineString = "";
                var search =
                    from std in stdnm
                    where (std.Contains(char.Parse(textBox3.Text)))
                    select std;
                foreach (String name in search)
                {
                    combineString = combineString + " " + name;
                }
                textBox2.Text = combineString;
                textBox3.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input!!!!");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)              //sort array
        {
            String combineString = "";
            var search =
                from std in stdnm
                orderby std ascending
                select std;
            
            foreach (String name in search)
            {
                combineString = combineString + " " + name;
            }
            textBox2.Text = combineString;
        }

       
    }
}
