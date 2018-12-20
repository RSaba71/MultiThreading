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

namespace MultiThreading2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TimeConsumingJob_Click(object sender, EventArgs e)
        {
            //TimeConsumingJob.Enabled = false;
            //PrintNumbers.Enabled = false;

            // This thread is a light weight which executes the time consuming task. The main thread is for the application
            // this thread is for subtasks so that the main thread can keep running.
            Thread threadWork = new Thread(TimeConsumingTask);
            threadWork.Start();
          //  TimeConsumingTask();   // IF ONLY THIS AND NO THREAD . THE NUMBERS WILL NOT BE PRINTED UNTIL AFTER 8 SECS WHEN BTN CLICKED

            //TimeConsumingJob.Enabled = true;
            //PrintNumbers.Enabled = true;

        }
        private void TimeConsumingTask()
        {
            Thread.Sleep(8000);
        }
        private void PrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i=1; i <10; i++)
            {

                listBox1.Items.Add(i);
            }
        }

        
    }
}
