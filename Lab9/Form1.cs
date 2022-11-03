using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Lab9
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        string[] fio = { "Истанов А.В.", "Расманов Е.И.", "Сушенко П.М.", "Ирпатова И.И", "Куренай А.П.", "Остапова Л.П.", "Лимонадов Л.П.", "Ломанова Л.Л.", "Стариков И.М.", "Вилкин И.П." };
        string[] gr = { "4Б181", "8ОИ11", "687ЛМ", "4Б181", "СТ081", "МЛТ01", "НР099", "687ЛМ", "НР099", "8ОИ11" };
        Random rand = new Random();

        string[] str = new string[10];
        double[] sr = new double[10];

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i <= 9; i++)
            {
                str[i] = $"{fio[rand.Next(1, 10)]} {gr[rand.Next(1, 10)]}";
            }
            for (int i = 0; i <= 9; i++)
            {
                richTextBox1.AppendText($"{str[i]} \n");
            }
            using (var sw1 = new StreamWriter("Список.txt"))
            {
                for (int i = 0; i <= 9; i++)
                {
                    sw1.WriteLine(str[i]);
                }
            }
        }

        int[] c = new int[10];

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            const int n = 10, m = 5;
            int[,] u = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < m; j++)
                {
                    u[i, j] = rand.Next(2, 5);
                    sr[i] = sr[i] + u[i, j];
                    if ((u[i, j] == 4 ^ u[i, j] == 5) && s == 0)
                    {
                        richTextBox2.AppendText($"{str[i]} \n");
                        s++;
                        c[i] = 1;
                    }

                }
                sr[i] = sr[i] / 5;
                if (s == 0)
                    sr[i] = 0;
                richTextBox1.Clear();
                string[] arrays = File.ReadAllLines("Список.txt");
                for (int y = 0; y <= 9; y++)
                {
                    richTextBox1.AppendText($"{arrays[y]}\n");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double maxV;
            richTextBox2.Clear();
            for (int i = 0; i < 10; i++)
            {
                maxV = sr.Max();
                for (int j = 0; j < 10; j++)
                {
                    if (maxV == 0)
                    {
                        break;
                    }
                    if (maxV == sr[j])
                    {
                        richTextBox2.AppendText($"{str[j]} {sr[j]} \n");
                        sr[j] = 0;
                    }
                }
                richTextBox1.Clear();
                string[] arrays = File.ReadAllLines("Список.txt");
                for (int y = 0; y <= 9; y++)
                {
                    richTextBox1.AppendText($"{arrays[y]}\n");
                }
            }
        }
    }
}

