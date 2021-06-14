using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace random_name
{
    public partial class Form1 : Form
    {
        string form1_name, label1_text, label2_text, button1_before, button1_ontick, button1_after,
            button2_befor, button2_ontick, button2_after;
        FileStream name_stream = new FileStream("./data/name.txt", FileMode.Open);
        FileStream poem_stream = new FileStream("./data/poem.txt", FileMode.Open);
        FileStream readme_stream = new FileStream("readme.txt", FileMode.Open);
        FileStream uiset_stream = new FileStream("./data/ui_setting.txt", FileMode.Open);
        List<string> name_list = new List<string>();
        List<string> poem_list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader name_read = new StreamReader(name_stream, UnicodeEncoding.GetEncoding("utf-8"));
            StreamReader poem_read = new StreamReader(poem_stream, UnicodeEncoding.GetEncoding("utf-8"));
            StreamReader uiset_read = new StreamReader(uiset_stream, UnicodeEncoding.GetEncoding("utf-8"));
            string name_sc,poem_sc,uiset_sc;
            int i = 0;
            
            while ((name_sc = name_read.ReadLine()) != null)
            {
                name_list.Add(name_sc);
            }
            while ((poem_sc = poem_read.ReadLine()) != null)
            {
                poem_list.Add(poem_sc);
            }
            while((uiset_sc = uiset_read.ReadLine()) != null)
            {
                i++;
                if (i == 1)
                    label1_text = uiset_sc;
                else if (i == 2)
                    label2_text = uiset_sc;
                else if (i == 3)
                    button1_before = uiset_sc;
                else if (i == 4)
                    button2_befor = uiset_sc;
                else if (i == 5)
                    button1_ontick = uiset_sc;
                else if (i == 6)
                    button2_ontick = uiset_sc;
                else if (i == 7)
                    button1_after = uiset_sc;
                else if (i == 8)
                    button2_after = uiset_sc;
            }
            label1.Text = label1_text;
            label2.Text = label2_text;
            button1.Text = button1_before;
            button2.Text = button2_befor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = name_list[new Random().Next(name_list.Count)];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = poem_list[new Random().Next(poem_list.Count)];
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled is false)
            {
                timer1.Start();
                button1.Text = button1_ontick;
            }
            else if (timer1.Enabled is true)
            {
                timer1.Stop();
                button1.Text = button1_after;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled is false)
            {
                timer2.Start();
                button2.Text = button2_ontick;
            }
            else if (timer2.Enabled is true)
            {
                timer2.Stop();
                button2.Text = button2_after;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader readme_read = new StreamReader(readme_stream, UnicodeEncoding.GetEncoding("utf-8"));
            MessageBox.Show(readme_read.ReadToEnd() + "\n\n制作by 高2019级2班@酥和侠   2021.5.31");
        }

    }
}
