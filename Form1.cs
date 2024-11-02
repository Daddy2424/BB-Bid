using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoPlayer
{
    public partial class Form1 : Form
    {

        // Member 1 - Deepu (Initializer)
        public Form1()
        {
            InitializeComponent();
            UI.ShowInstructions();
        }

        public static bool isRunning = true;
        private void btn_Help_Click(object sender, EventArgs e)
        {
            UI.ShowInstructions();
        }
        private void btn_Hourly_Click(object sender, EventArgs e)
        {
            Vizualizer.SmoothUpdateChartAsync(this, bullKeyx, bullKeyy, bearkeyx, bearkeyy);
        }

        private void btn_Monthly_Click(object sender, EventArgs e)
        {
           isRunning =  Controller.StopVisualizing(isRunning);
           
        }


        // Felipe (Inputs)
        decimal bullKeyx = 0;
        decimal bullKeyy = 0;
        decimal bearkeyx = 0;
        decimal bearkeyy = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            bullKeyx = inp_BullKeyX.Value;
            bullKeyy = inp_BullKeyY.Value;
            bearkeyx = inp_BearKeyX.Value;
            bearkeyy = inp_BearKeyY.Value;

        }


        // Member 3 - Mo (Vizualizer)



        // Member 4 - Yuvraj (Controller)



        // Meber 5 - Maria (UI / UX)




    }
}
