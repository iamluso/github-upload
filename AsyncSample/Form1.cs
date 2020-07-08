using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AsyncSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click_Async(object sender, EventArgs e)
        {
            // Runs a background task without frozing the UI -- added by luisgs -- new added
            var result = await Task.Run(() => SlowTask());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.llblTime.Text = System.DateTime.Now.ToString();
        }

        private bool SlowTask()
        {
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    // Other change (luisgs)
                    System.Diagnostics.Debug.WriteLine("Iteration " + System.Convert.ToString(i));
                }
            }
            return true;   
        }
    }
}
