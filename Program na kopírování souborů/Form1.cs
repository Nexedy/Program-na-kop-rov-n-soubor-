using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Program_na_kopírování_souborů
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oknoOtevřenísouboru = new OpenFileDialog();
            oknoOtevřenísouboru.Filter = " txt files (*.txt) | *.txt|All files (*.*)|*.*";
            oknoOtevřenísouboru.Title = "Výběr souboru ";
            if (oknoOtevřenísouboru.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = oknoOtevřenísouboru.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog oknoOtevřenísouboru = new OpenFileDialog();
            oknoOtevřenísouboru.Filter = " txt files (*.txt) | *.txt|All files (*.*)|*.*";
            oknoOtevřenísouboru.Title = "Výběr souboru ";
            if (oknoOtevřenísouboru.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = oknoOtevřenísouboru.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string cesta = textBox1.Text;
                string cesta2 = textBox2.Text;
                using (StreamReader sr = new StreamReader(cesta))
                {
                    using (StreamWriter sw = new StreamWriter(cesta2))
                    {
                        int znak;
                        while ((znak = sr.Read()) != -1)
                        {
                            Console.WriteLine("{0}....{1}", znak, (char)znak);
                        }
                    }
                }
            }

            if (radioButton2.Checked)
            {
                string cesta = textBox1.Text;
                string cesta2 = textBox2.Text;
                using (StreamReader sr = new StreamReader(cesta))
                {
                    using (StreamWriter sw = new StreamWriter(cesta2))
                    {
                        string input;
                        while ((input = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(input);
                        }
                        Console.WriteLine("Konce streamu bylo dosaženo!");
                    }
                }
            }

            if (radioButton3.Checked)
            {
                string cesta = textBox1.Text;
                string cesta2 = textBox2.Text;
                using (StreamReader sr = new StreamReader(cesta))
                {
                    using (StreamWriter sw = new StreamWriter(cesta2))
                    {
                        string input = sr.ReadLine();
                        string input2 = sr.ReadToEnd();
                        string input3 = sr.ReadToEnd();

                        Console.WriteLine("input: |{0}| ", input);
                        Console.WriteLine("input2: |{0}| ", input2);
                        Console.WriteLine("input3: |{0}| ", input3);
                    }
                }
            }
        }

    }
}
