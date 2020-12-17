using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "aa aba abba abbba abca abea";

            Regex regex = new Regex("ab{1,}a");//ищем слово начинающееся и заканчивающееся на а с одним и юолее символами б
            // добавляем результаты в коллекцию
            MatchCollection matches = regex.Matches(str);

            if (matches.Count > 0)
            {
                // заполняем листбокс результатами
                for (int i = 0; i < matches.Count; i++)
                {
                    listBox1.Items.Add(matches[i]);
                }
            }
        }
    }
}
