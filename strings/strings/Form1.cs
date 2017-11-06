using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Hello class| this is awesome. .";
            // string[] splits = text.Split();  // splits by space
            string[] splits = text.Split('|');  // splits by pipe sign


            //for (int i = 0; i < splits.Length; i++)
            //{
            //    //Console.WriteLine(splits[i]);
            //    Console.WriteLine(splits[i].Trim('.'));

            //}
            //Console.WriteLine(splits[0]);

            //Console.WriteLine(text[1]);
            //int indexOf = text.IndexOf('h');
            //Console.WriteLine(indexOf.ToString());

            string numbers = "5,6,3|8,6,3|7,9,5|4,3,9";
            // split by pipe
            string[] splitByPipe = numbers.Split('|');
            //for(int i = 0; i < splitByPipe.Length; i++)
            //{
            //    Console.WriteLine(splitByPipe[i]);
            //}

            // foreach splitByPipe, split again by comma
            string[] splitByComma0 = splitByPipe[0].Split(',');
            string[] splitByComma1 = splitByPipe[1].Split(',');
            // and so on

            int[,] matrix = new int[4, 3];
            // convert string to int
            matrix[0, 0] = int.Parse(splitByComma0[0]);
            matrix[0, 1] = int.Parse(splitByComma0[1]);
            matrix[0, 2] = int.Parse(splitByComma0[2]);

            matrix[1, 0] = int.Parse(splitByComma1[0]);
            matrix[1, 1] = int.Parse(splitByComma1[1]);
            matrix[1, 2] = int.Parse(splitByComma1[2]);


            // assign numbers to specific position in the 2-d array
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string temp = "";
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    temp += matrix[row, col] + " ";
                }
                Console.WriteLine(temp);
            }
        }
    }
}
