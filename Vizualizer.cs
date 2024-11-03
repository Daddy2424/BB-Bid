using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace videoPlayer
{
    internal class Vizualizer
    {
        public static async void SmoothUpdateChartAsync(Form1 form, decimal bullKeyx, decimal bullKeyy, decimal bearkeyx, decimal bearkeyy)
        {
            Random random = new Random();
            string[] hours = { "1", "2", "3" };
            int count = 0;

            int prevDogsValue = random.Next(-100, 100);
            int prevCatsValue = random.Next(-100, 100);


            form.pb_Bull.Maximum = 30;
            form.pb_Bull.Minimum = 0;
            form.pb_Bear.Maximum = 30;
            form.pb_Bear.Minimum = 0;
            Form1.isRunning = true;
            int bullVol = 1;
            int bearVol = 1;
            while (Form1.isRunning)
            {
                int targetDogsValue = random.Next(-100, 100);
                int targetCatsValue = random.Next(-100, 100);
                double dogsValue = 0;
                double catsValue = 0;

                double steps = 1;
                for (int i = 1; i <= steps; i++)
                {

                    dogsValue = prevDogsValue + (targetDogsValue - prevDogsValue) * i / steps;
                    catsValue = prevCatsValue + (targetCatsValue - prevCatsValue) * i / steps;


                    form.chart1.Series["BULLISH"].Points.AddXY(hours[count], dogsValue);
                    form.chart1.Series["BEARISH"].Points.AddXY(hours[count], catsValue);


                    if (form.chart1.Series["BULLISH"].Points.Count > 8) form.chart1.Series["BULLISH"].Points.RemoveAt(0);
                    if (form.chart1.Series["BEARISH"].Points.Count > 8) form.chart1.Series["BEARISH"].Points.RemoveAt(0);


                    await Task.Delay(50);
                    if (!Form1.isRunning) break;
                }

                form.lbl_BullishLevelX.Text = hours[count];
                form.lbl_BullishLevelY.Text = dogsValue.ToString();

                form.lbl_BearishLevelX.Text = hours[count];
                form.lbl_BearishLevelY.Text = catsValue.ToString();

                int hour = int.Parse(hours[count]);
                double bullKeyY = Convert.ToDouble(bullKeyy);
                double bearKeyY = Convert.ToDouble(bearkeyy);

                if (hour == bullKeyx)
                {

                    for (int i = -100; i <= 90; i += 10) // Start from -100 to include negative ranges
                    {
                        if (dogsValue >= i && dogsValue < i + 10 && bullKeyY >= i && bullKeyY < i + 10)
                        {
                            if (bullVol == 30)
                            {
                                UI.ShowWin("Bull");
                                Controller.StopVisualizing(Form1.isRunning);
                                break;
                            }
                            form.lbl_BullVolume.Text = bullVol.ToString();
                            if (bullVol < 31)
                            {
                                form.pb_Bull.Value = bullVol;
                            }
                            bullVol++;
                            break;
                        }
                    }
                }

                if (hour == bearkeyx)
                {

                    for (int i = -100; i <= 90; i += 10)
                    {
                        if (catsValue >= i && catsValue < i + 10 && bearKeyY >= i && bearKeyY < i + 10)
                        {
                            if (bearVol == 30)
                            {
                                UI.ShowWin("Bearsih");
                                Controller.StopVisualizing(Form1.isRunning);
                                break;
                            }
                            form.lbl_BearVolume.Text = bearVol.ToString();
                            if (bearVol < 31)
                            {
                                form.pb_Bear.Value = bearVol;
                            }
                            bearVol++;
                            break;
                        }
                    }
                }


                prevDogsValue = targetDogsValue;
                prevCatsValue = targetCatsValue;


                count++;
                if (count == hours.Length) count = 0;
            }
        }
    }
}
