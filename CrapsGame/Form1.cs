/**
 * This program creates a basic Craps game using C#. In this game, 
 * a user using Windows will be able to make a bet, see the result 
 * of two rolls, and then see if they won. The game balance is tracked
 * and the user cannot place a bet is funds are insufficient. 
*/

/**
 * This section states all the packages used, similar to "import" in Java
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class Form1 : Form
    {
        /**
         * TasK: initializes the bankBalance to 100.
         */
        private decimal bankBalance = 100.00m; 
        /**
         * Task: creates enumerated class GameStatus that provides
         * 3 options: Win, Lose, or Point.
         */
        private enum GameStatus { Win, Lose, Point };

        public Form1()
        {
            InitializeComponent();
            UpdateBalanceLabel();
        }//end form1 initialization


        private void btnRoll_Click(object sender, EventArgs e)
        {
            /**
             * Task: allows user to enter a bet and then checks to make sure bet is legitimate. 
             * @return: Calculated Score 
             * @return: error message
             */
            if (decimal.TryParse(txtBet.Text, out decimal bet) && bet > 0 && bet <= bankBalance)
            {
                CalculateScore(bet); // Call the method to calculate the score
            }//end if
            else
            {
                MessageBox.Show("Invalid bet. Please enter a valid amount.");
            }//end else
        }//end btnRoll_Click

        /**
         * Task: creates a random number generators and then creates 
         * two random number for die1 and die2 respectively. Lastly, 
         * this section of code sums the dice
         */
        private void CalculateScore(decimal bet)
        {
            Random random = new Random(); 
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die1 + die2; 

            /**
             * Task: creates toString to display the result of the previous Random Number Generator
             */
            lblDie1.Text = die1.ToString();
            lblDie2.Text = die2.ToString();

            /**
             * Task: decides the winner of the game using a switch statement
             * Determine the outcome of the game using a switch statement
             *@return: results of Switch block 
             */
            GameStatus status;
            switch (sum)
            {
                case 7:
                case 11:
                    status = GameStatus.Win;
                    break;
                case 2:
                case 3:
                case 12:
                    status = GameStatus.Lose;
                    break;
                default:
                    status = GameStatus.Point;
                    lblResults.Text = $"Point is {sum}";
                    return; 
            }//end Swtich block

            /**
             * Task: tells player if they won or lost and then updates balance. 
             * @return: updated bank balance
             */
            switch (status)
            {
                case GameStatus.Win:
                    lblResults.Text = "You win!";
                    bankBalance += bet; 
                    break;
                case GameStatus.Lose:
                    lblResults.Text = "You lose!";
                    bankBalance -= bet;
                    break;
            }//end Switch block

            UpdateBalanceLabel();
        }//end CalculateScore

        private void UpdateBalanceLabel()
        {
            lblBalance.Text = $"Balance: ${bankBalance:F2}"; // Update balance display
        }//end UpdatedBalanceLabel

        private void label1_Click(object sender, EventArgs e)
        {

        }//end Label1_Click

        private void label1_Click_1(object sender, EventArgs e)
        {

        }//end Label1_Click_1

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }//end main
}//end class