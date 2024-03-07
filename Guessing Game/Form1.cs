using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        int secretNumber;
        int count;
        int range;
        public Form1()
        {
            InitializeComponent();

            secretNumber = randGen.Next(1, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            //this is formy guessing
            int guess;
            guess = Convert.ToInt32(numberInput.Text);

            //Math.abds = always positive
            range = Math.Abs(secretNumber - guess);

            if (guess == secretNumber)
            {
                count++;
                outputLabel.Text = $"You Got It In {count} Guesses!";
            }
            else if (guess < secretNumber)
            {
                count++;
                outputLabel.Text = "Too Low!";
            }
            else if (guess  > secretNumber)
            {
                count++;
                outputLabel.Text = "Too High!";
            }


            //this is my range
            if (range == 0)
            {
            }

            else if (range <= 4)
            {
                outputLabel.Text += "\nBoiling";
            }

            else if (range <= 5)
            {
                outputLabel.Text += "\nHot";
            }

            else if (range <= 10)
            {
                outputLabel.Text += "\nWarm";
            }

            else if (range <= 15)
            {
                outputLabel.Text += "\nCool";
            }

            else if (range <= 25)
            {
                outputLabel.Text += "\nCold";
            }

            else
            {
                outputLabel.Text += "\nFreezing";
            }


        }
    }
}
