using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Bubble sort
        interface ISortAlgorithm<T>
        {
            void Sort(T[] words);
        }
        class BubbleSort : ISortAlgorithm<int>
        {
            public void Sort(int[] words)
            {
                int temp;
                for (int j = 1; j <= words.Length - 2; j++)
                {
                    for (int i = 0; i <= words.Length - 2; i++)
                    {
                        if (words[i] > words[i + 1])
                        {
                            temp = words[i + 1];
                            words[i + 1] = words[i];
                            words[i] = temp;
                        }
                    }
                }
                Console.WriteLine("BubbleSort");
                foreach (int word in words)
                    Console.Write(word + " ");
                Console.Read();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            BubbleSort p = new BubbleSort();
            //BubbleSort.Sort(words);
            //listBox1.Text = p.ToString();

            //string[] separators = { ",", " ", "-"};
            //string value = textBox1.Text;
            //string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //foreach (var word in words)
            //{
            //    listBox1.Items.Add(word);
            //}           
        }
    }
}
