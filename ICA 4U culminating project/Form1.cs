using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ICA_4U_culminating_project
{
    public partial class Game : Form
    {
        int[] buttons = { 1, 1, 2, 2, 3, 3,};
        int points = 0;
        
        int guess = 0;



        public Game()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //shuffle array
            Random rnd = new Random();
            lblTry.Text = Convert.ToString(Convert.ToInt16(18/5.0));

            for (int i = 0; i < 3; i++)
            {
                int swap = rnd.Next(6);
                int temp = buttons[i];
                buttons[i] = buttons[swap];
                buttons[swap] = temp;

            }


            //for (int i = 0; i < 16; i++)
            //{
            //    lblTest.Text += buttons[i];
            //}

            //reset everything
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            

            btnOne.Text = "";
            btnTwo.Text = "";
            btnThree.Text = "";
            btnFour.Text = "";
            btnFive.Text = "";
            btnSix.Text = "";
            

            lblTest.Text = "";
            lblGuess.Text = " ";
            guess = 0;
            points = 0;

        }
        Boolean button_one_click = false; //keeps track of what is clicked
        Boolean button_two_click = false;
        Boolean button_three_click = false;
        Boolean button_four_click = false;
        Boolean button_five_click = false;
        Boolean button_six_click = false;
       
        private void btnOne_Click(object sender, EventArgs e)
        {
            button_one_click = true;
            btnOne.Text = Convert.ToString(buttons[0]); //display text
            bool answer;
            int correct;
            Check1(out answer, out correct); //goes into method to check if other buttons have been clicked

            if (answer == false) //another button is not clicked
            {
                button_one_click = true;
            }
            else if (answer == true)
            {

                if (correct == 0)
                {
                    // there was a match
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                    points = points + 1;
                    lblTest.Text = "the score is:" + points;
                    

                }
                else if (correct == 1)
                {
                    // there was no match
                    lblTest.Text += "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 2)
                {
                    //case where only one button was clicked
                }
            }

            if (btnOne.Enabled == false & btnTwo.Enabled == false & btnThree.Enabled == false & btnFour.Enabled == false & btnFive.Enabled == false & btnSix.Enabled == false)
            {
                MessageBox.Show("Congratulations you won the game :) press play again!");
                
            }

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            button_two_click = true;
            btnTwo.Text = Convert.ToString(buttons[1]); //display text
            bool answer;
            int correct;
            Check1(out answer, out correct); //goes into method to check if other buttons have been clicked

            if (answer == false) //another button is not clicked
            {
                button_two_click = true;
            }
            else if (answer == true)
            {
                if (correct == 0)
                {
                    points = points + 1;
                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);

                }
                else if (correct == 1)
                {

                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 2)
                {
                    // case where only one button has been clicked
                }
            }
            if (btnOne.Enabled == false & btnTwo.Enabled == false & btnThree.Enabled == false & btnFour.Enabled == false & btnFive.Enabled == false & btnSix.Enabled == false)
            {
                MessageBox.Show("Congratulations you won the game :) press play again!");
            }
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            button_three_click = true;
            btnThree.Text = Convert.ToString(buttons[2]); //display text
            bool answer;
            int correct;
            Check1(out answer, out correct); //goes into method to check if other buttons have been clicked

            if (answer == false) //another button is not clicked
            {
                button_three_click = true;

            }
            else if (answer == true)
            {
                if (correct == 0)
                {
                    points = points + 1;
                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 1)
                {

                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 2)
                {
                    // case where only one button has been clicked
                }

            }
            if (btnOne.Enabled == false & btnTwo.Enabled == false & btnThree.Enabled == false & btnFour.Enabled == false & btnFive.Enabled == false & btnSix.Enabled == false)
            {
                MessageBox.Show("Congratulations you won the game :) press play again!");

            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {

            button_four_click = true;
            btnFour.Text = Convert.ToString(buttons[3]); //display text
            bool answer;
            int correct;
            Check1(out answer, out correct); //goes into method to check if other buttons have been clicked

            if (answer == false) //another button is not clicked
            {
                button_four_click = true;

            }
            else if (answer == true)
            {
                if (correct == 0)
                {
                    points = points + 1;
                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 1)
                {

                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 2)
                {
                    // case where only one button has been clicked
                }

            }
            if (btnOne.Enabled == false & btnTwo.Enabled == false & btnThree.Enabled == false & btnFour.Enabled == false & btnFive.Enabled == false & btnSix.Enabled == false)
            {
                MessageBox.Show("Congratulations you won the game :) press play again!");
            }
        }
    

        private void btnFive_Click(object sender, EventArgs e)
        {
            button_five_click = true;
            btnFive.Text = Convert.ToString(buttons[4]); //display text
            bool answer;
            int correct;
            Check1(out answer, out correct); //goes into method to check if other buttons have been clicked

            if (answer == false) //another button is not clicked
            {
                button_five_click = true;

            }
            else if (answer == true)
            {
                if (correct == 0)
                {
                    points = points + 1;
                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 1)
                {

                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 2)
                {
                    // case where only one button has been clicked
                }

            }
            if (btnOne.Enabled == false & btnTwo.Enabled == false & btnThree.Enabled == false & btnFour.Enabled == false & btnFive.Enabled == false & btnSix.Enabled == false)
            {
                MessageBox.Show("Congratulations you won the game :) press play again!");
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            button_six_click = true;
            btnSix.Text = Convert.ToString(buttons[5]); //display text
            bool answer;
            int correct;
            Check1(out answer, out correct); //goes into method to check if other buttons have been clicked

            if (answer == false) //another button is not clicked
            {
                button_six_click = true;

            }
            else if (answer == true)
            {
                if (correct == 0)
                {
                    points = points + 1;
                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 1)
                {

                    lblTest.Text = "the score is:" + points;
                    guess = guess + 1;
                    lblGuess.Text = Convert.ToString(guess);
                }
                else if (correct == 2)
                {
                    // case where only one button has been clicked
                }

            }
            if (btnOne.Enabled == false & btnTwo.Enabled == false & btnThree.Enabled == false & btnFour.Enabled == false & btnFive.Enabled == false & btnSix.Enabled == false)
            {
                MessageBox.Show("Congratulations you won the game :) press play again!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnEight_Click(object sender, EventArgs e)
        {

        }

        private void btnNine_Click(object sender, EventArgs e)
        {

        }

        private void btnTen_Click(object sender, EventArgs e)
        {
        }

        private void btnElelven_Click(object sender, EventArgs e)
        {

        }

        private void btnTwelve_Click(object sender, EventArgs e)
        {

        }

        private void buttonThirteen_Click(object sender, EventArgs e)
        {

        }

        private void btnFourteen_Click(object sender, EventArgs e)
        {

        }

        private void btnFifteen_Click(object sender, EventArgs e)
        {

        }

        private void btnSixteen_Click(object sender, EventArgs e)
        {

        }

        //methods to check if another button has been clicked
        private void Check1(out bool answer, out int correct)
        {
            if (button_one_click == true & button_two_click == true)
            {
                answer = true;
                correct = Match(buttons[0], buttons[1]);
                if (correct == 0)
                {
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    btnOne.Enabled = false;
                    btnTwo.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    MessageBox.Show("you do not have a match");
                    button_one_click = false; //un clicks them because they dont match
                    button_two_click = false;
                    btnOne.Text = " "; //display text
                    btnTwo.Text = ""; //display text

                }
            }
            else if (button_three_click == true & button_two_click == true)
            {
                answer = true;
                correct = Match(buttons[1], buttons[2]);
                if (correct == 0)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    btnThree.Enabled = false;
                    btnTwo.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    MessageBox.Show("you do not have a match");
                    button_three_click = false; //un clicks them because they dont match
                    button_two_click = false;
                    btnThree.Text = " "; //display text
                    btnTwo.Text = ""; //display text

                }
            }
            else if (button_three_click == true & button_one_click == true)
            {
                answer = true;
                correct = Match(buttons[0], buttons[2]);
                if (correct == 0)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    btnThree.Enabled = false;
                    btnOne.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    MessageBox.Show("you do not have a match");
                    button_one_click = false; //un clicks them because they dont match
                    button_three_click = false;
                    btnThree.Text = " "; //display text
                    btnOne.Text = ""; //display text

                }
            }
            else if (button_one_click == true & button_four_click == true)
            {
                answer = true;
                correct = Match(buttons[0], buttons[3]);
                if (correct == 0)
                {
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    btnOne.Enabled = false;
                    btnFour.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    MessageBox.Show("you do not have a match");
                    button_one_click = false; //un clicks them because they dont match
                    button_four_click = false;
                    btnOne.Text = " "; //display text
                    btnFour.Text = ""; //display text

                }
            }
            else if (button_four_click == true & button_two_click == true)
            {
                answer = true;
                correct = Match(buttons[1], buttons[3]);
                if (correct == 0)
                {
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    btnFour.Enabled = false;
                    btnTwo.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    MessageBox.Show("you do not have a match");
                    button_four_click = false; //un clicks them because they dont match
                    button_two_click = false;
                    btnFour.Text = " "; //display text
                    btnTwo.Text = ""; //display text

                }
            }
            else if (button_three_click == true & button_four_click == true)
            {
                answer = true;
                correct = Match(buttons[3], buttons[2]);
                if (correct == 0)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    btnThree.Enabled = false;
                    btnFour.Enabled = false;
                }
                else if (correct == 1)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    MessageBox.Show("you do not have a match");
                    button_three_click = false; //un clicks them because they dont match
                    button_four_click = false;
                    btnThree.Text = " "; //display text
                    btnFour.Text = ""; //display text
                }
            }
            else if (button_one_click == true & button_five_click == true)
            {
                answer = true;
                correct = Match(buttons[0], buttons[4]);
                if (correct == 0)
                {
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    btnOne.Enabled = false;
                    btnFive.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    MessageBox.Show("you do not have a match");
                    button_one_click = false; //un clicks them because they dont match
                    button_five_click = false;
                    btnOne.Text = " "; //display text
                    btnFive.Text = ""; //display text

                }
            }
            else if (button_two_click == true & button_five_click == true)
            {
                answer = true;
                correct = Match(buttons[1], buttons[4]);
                if (correct == 0)
                {
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    btnTwo.Enabled = false;
                    btnFive.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    MessageBox.Show("you do not have a match");
                    button_two_click = false; //un clicks them because they dont match
                    button_five_click = false;
                    btnTwo.Text = " "; //display text
                    btnFive.Text = ""; //display text

                }
            }
            else if (button_three_click == true & button_five_click == true)
            {
                answer = true;
                correct = Match(buttons[2], buttons[4]);
                if (correct == 0)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    btnThree.Enabled = false;
                    btnFive.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    MessageBox.Show("you do not have a match");
                    button_three_click = false; //un clicks them because they dont match
                    button_five_click = false;
                    btnThree.Text = " "; //display text
                    btnFive.Text = ""; //display text

                }
            }
            else if (button_four_click == true & button_five_click == true)
            {
                answer = true;
                correct = Match(buttons[3], buttons[4]);
                if (correct == 0)
                {
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    btnFour.Enabled = false;
                    btnFive.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    MessageBox.Show("you do not have a match");
                    button_four_click = false; //un clicks them because they dont match
                    button_five_click = false;
                    btnFour.Text = " "; //display text
                    btnFive.Text = ""; //display text
                }
            }
            else if (button_one_click == true & button_six_click == true)
            {
                answer = true;
                correct = Match(buttons[0], buttons[5]);
                if (correct == 0)
                {
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    btnOne.Enabled = false;
                    btnSix.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnOne.Text = Convert.ToString(buttons[0]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    MessageBox.Show("you do not have a match");
                    button_one_click = false; //un clicks them because they dont match
                    button_six_click = false;
                    btnOne.Text = " "; //display text
                    btnSix.Text = ""; //display text

                }
            }
            else if (button_two_click == true & button_six_click == true)
            {
                answer = true;
                correct = Match(buttons[1], buttons[5]);
                if (correct == 0)
                {
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    btnTwo.Enabled = false;
                    btnSix.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnTwo.Text = Convert.ToString(buttons[1]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    MessageBox.Show("you do not have a match");
                    button_two_click = false; //un clicks them because they dont match
                    button_six_click = false;
                    btnTwo.Text = " "; //display text
                    btnSix.Text = ""; //display text

                }
            }
            else if (button_three_click == true & button_six_click == true)
            {
                answer = true;
                correct = Match(buttons[2], buttons[5]);
                if (correct == 0)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    btnThree.Enabled = false;
                    btnSix.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnThree.Text = Convert.ToString(buttons[2]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    MessageBox.Show("you do not have a match");
                    button_three_click = false; //un clicks them because they dont match
                    button_six_click = false;
                    btnThree.Text = " "; //display text
                    btnSix.Text = ""; //display text

                }
            }
            else if (button_four_click == true & button_six_click == true)
            {
                answer = true;
                correct = Match(buttons[3], buttons[5]);
                if (correct == 0)
                {
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    btnFour.Enabled = false;
                    btnSix.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnFour.Text = Convert.ToString(buttons[3]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    MessageBox.Show("you do not have a match");
                    button_four_click = false; //un clicks them because they dont match
                    button_six_click = false;
                    btnFour.Text = " "; //display text
                    btnSix.Text = ""; //display text
                }
            }
            else if (button_five_click == true & button_six_click == true)
            {
                answer = true;
                correct = Match(buttons[4], buttons[5]);
                if (correct == 0)
                {
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    btnFive.Enabled = false;
                    btnSix.Enabled = false;

                }
                else if (correct == 1)
                {
                    btnFive.Text = Convert.ToString(buttons[4]); //display text
                    btnSix.Text = Convert.ToString(buttons[5]); //display text
                    MessageBox.Show("you do not have a match");
                    button_five_click = false; //un clicks them because they dont match
                    button_six_click = false;
                    btnFive.Text = " "; //display text
                    btnSix.Text = ""; //display text
                }
            }

            else
            {
                correct = 2; //correct 2 is one clice correct 1 is no match correct 0 is match
                answer = false;
            }
        }

        private int Match(int a, int b)
        {
            if (a == b)
            {
                MessageBox.Show("you have a match!");
                button_one_click = false; //keeps track of what is clicked
                button_two_click = false;
                button_three_click = false;
                button_four_click = false;
                button_five_click = false;
                button_six_click = false;
                
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void lblGuess_Click(object sender, EventArgs e)
        {

        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {

        }
    }
}
