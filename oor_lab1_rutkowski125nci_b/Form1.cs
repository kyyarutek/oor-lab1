using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace oor_lab1_rutkowski125nci_b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
                }
        int number = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Thread thr = new Thread(doSomething);
            Thread thr2 = new Thread(doSomething);
            Thread thr3 = new Thread(doSomething);
            Thread thr4 = new Thread(doSomething);
            if (thr.ThreadState != System.Threading.ThreadState.Running)
            {
                thr.Start();
                number++;
            }
            else if (thr.ThreadState == System.Threading.ThreadState.Running)
            {
                thr2.Join();
                number++;

            }
            else if (thr2.ThreadState == System.Threading.ThreadState.Running && thr.ThreadState == System.Threading.ThreadState.Running)
            {
                thr3.Join();
                number++;

            }
            else if (thr4.ThreadState == System.Threading.ThreadState.Running && thr2.ThreadState == System.Threading.ThreadState.Running && thr.ThreadState == System.Threading.ThreadState.Running)
            {
                thr4.Join();
                number++;

            }
        }
        private void doSomething()
        {
            Int32 licz_do = Convert.ToInt32(textBox1.Text);
            if (number <= 1)
            {
                for (int i = 0; i <= licz_do; i++)
                    Console.WriteLine(" [1] " + i);
                number--;
            }
           

            else if (number == 2)
            {
                for (int i2 = 0; i2 <= licz_do; i2++)
                    Console.WriteLine(" [2] " + i2);
                number--;

            }
            else if (number == 3)
            {
                for (int i3 = 0; i3 <= licz_do; i3++)
                    Console.WriteLine(" [3] " + i3);
                number--;

            }
            else if (number == 4)
            {
                for (int i4 = 0; i4 <= licz_do; i4++)
                    Console.WriteLine(" [4] " + i4);
                number--;

            }
            else if (number > 4)
            {
            }


        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


    }


}
