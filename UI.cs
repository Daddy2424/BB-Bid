using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoPlayer
{
    internal class UI
    {
        public static void ShowInstructions()
        {

            Form instructionPopUp = new Form
            {
                Width = 550,
                Height = 350,
                Text = "Welcome to BB Bid - Instructions",
                StartPosition = FormStartPosition.CenterScreen
            };


            Label instructionLabel = new Label
            {
                Left = 10,
                Top = 10,
                Width = 520,
                Height = 300,
                Text = "Welcome to BB Bid!\n\n" +
                       "BB Bid is a bidding platform where you can place orders on either the bullish or bearish side " +
                       "and earn profits based on the volume you accumulate.\n\n" +
                       "Here's how to get started:\n" +
                       "1. Press the 'Start Visualizing' button to begin.\n" +
                       "2. Observe the graph where the x-axis values represent 1, 2, 3, etc.\n" +
                       "3. The y-axis values range from -100 to 100.\n" +
                       "4. Choose your side (bullish or bearish) and input your desired x and y values.\n" +
                       "5. Press the 'Order' button to place your bid.\n\n" +
                       "Good luck, and may your strategy lead to great profits!\n\n" +
                       "YOU CAN CLICK HELP AND SEE THE INSTRUCTIONS ANY TIME",
                AutoSize = true,
                BackColor = Color.LightYellow,
                TextAlign = ContentAlignment.TopLeft,
                Padding = new Padding(10),
                Font = new Font("Arial", 10, FontStyle.Regular)
            };
            instructionPopUp.Controls.Add(instructionLabel);


            Button btnClose = new Button
            {
                Text = "Close",
                Left = 225,
                Top = 280,
                Width = 100,
                Height = 30,
                DialogResult = DialogResult.OK,
                BackColor = Color.LightSteelBlue,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            instructionPopUp.Controls.Add(btnClose);

            btnClose.Click += (sender, e) => instructionPopUp.Close();


            instructionPopUp.ShowDialog();
        }

        public static void ShowWin(string side)
        {

            Form instructionPopUp = new Form
            {
                Width = 550,
                Height = 170,
                Text = "Congratz",
                StartPosition = FormStartPosition.CenterScreen
            };


            Label instructionLabel = new Label
            {
                Left = 10,
                Top = 10,
                Width = 520,
                Height = 160,
                Text = $"{side} side has won with 30 volumes!",
                AutoSize = false,
                BackColor = Color.LightYellow,
                TextAlign = ContentAlignment.TopLeft,
                Padding = new Padding(10),
                Font = new Font("Arial", 10, FontStyle.Regular)
            };
            instructionPopUp.Controls.Add(instructionLabel);


            Button btnClose = new Button
            {
                Text = "Close",
                Left = 225,
                Top = 280,
                Width = 100,
                Height = 30,
                DialogResult = DialogResult.OK,
                BackColor = Color.LightSteelBlue,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            instructionPopUp.Controls.Add(btnClose);

            btnClose.Click += (sender, e) => instructionPopUp.Close();


            instructionPopUp.ShowDialog();
        }
    }
}
