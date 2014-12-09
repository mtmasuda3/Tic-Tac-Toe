using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Square[] squareArray = new Square[9];
        Player[] playerArray = new Player[2];
        public bool gameOver;
        public bool computerMode = false;
        public int computerResponse;
        public Form1()
        {
            InitializeComponent();
            gameOver = false;
            squareArray[0] = new Square()
            {
                marked = false
            };
            squareArray[1] = new Square()
            {
                marked = false
            };
            squareArray[2] = new Square()
            {
                marked = false
            };
            squareArray[3] = new Square()
            {
                marked = false
            };
            squareArray[4] = new Square()
            {
                marked = false
            };
            squareArray[5] = new Square()
            {
                marked = false
            };
            squareArray[6] = new Square()
            {
                marked = false
            };
            squareArray[7] = new Square()
            {
                marked = false
            };
            squareArray[8] = new Square()
            {
                marked = false
            };
            playerArray[0] = new Player()
            {
                name = "Player 1",
                myTurn = true,
                myScore = 0,
            };
            playerArray[1] = new Player()
            {
                name = "Player 2",
                myTurn = false,
                myScore = 0,
            };
            
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            if (!computerMode)
            {
                if (!squareArray[0].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label1.Text = "X";
                        squareArray[0].squareValue = label1.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                    }
                    else if (playerArray[1].myTurn)
                    {
                        label1.Text = "O";
                        squareArray[0].squareValue = label1.Text;
                        playerArray[1].myTurn = false;
                        playerArray[0].myTurn = true;
                    }
                    squareArray[0].marked = true;
                }
                else
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
            else
            {
                if (!squareArray[0].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label1.Text = "X";
                        squareArray[0].squareValue = label1.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                        //checkWinner();
                        
                        //restart();
                    }
                    if(!gameOver)
                        squareArray[0].marked = true;
                                    
                    executeComputerMove();
                                                     
                }
                else if (squareArray[0].marked)
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();

               

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!computerMode)
            {
                if (!squareArray[1].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label2.Text = "X";
                        squareArray[1].squareValue = label2.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                    }
                    else if (playerArray[1].myTurn)
                    {
                        label2.Text = "O";
                        squareArray[1].squareValue = label2.Text;
                        playerArray[1].myTurn = false;
                        playerArray[0].myTurn = true;
                    }
                    squareArray[1].marked = true;
                }
                else
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
            else
            {
                if (!squareArray[1].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label2.Text = "X";
                        squareArray[1].squareValue = label2.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                        //checkWinner();
                        
                       // restart();
                    }
                    if (!gameOver)
                        squareArray[1].marked = true;
                                                       
                    executeComputerMove();                   
                }
                else if (squareArray[1].marked)
                    MessageBox.Show("This square has already been checked!");
                checkWinner();
                updateScore();
                restart();
            }
                   

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!computerMode)
            {
                if (!squareArray[2].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label3.Text = "X";
                        squareArray[2].squareValue = label3.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                    }
                    else if (playerArray[1].myTurn)
                    {
                        label3.Text = "O";
                        squareArray[2].squareValue = label3.Text;
                        playerArray[1].myTurn = false;
                        playerArray[0].myTurn = true;
                    }
                    squareArray[2].marked = true;
                }
                else
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
            else
            {
                if (!squareArray[2].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label3.Text = "X";
                        squareArray[2].squareValue = label3.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                       // checkWinner();
                        
                      //  restart();
                    }
                    if (!gameOver)
                        squareArray[2].marked = true;
                                                           
                    executeComputerMove();

                    
                }
                else if (squareArray[2].marked)
                    MessageBox.Show("This square has already been checked!");
                checkWinner();
                updateScore();
                restart();

            }
                       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!computerMode)
            {
                if (!squareArray[3].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label4.Text = "X";
                        squareArray[3].squareValue = label4.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                    }
                    else if (playerArray[1].myTurn)
                    {
                        label4.Text = "O";
                        squareArray[3].squareValue = label4.Text;
                        playerArray[1].myTurn = false;
                        playerArray[0].myTurn = true;
                    }
                    squareArray[3].marked = true;
                }
                else
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
            else
            {
                if (!squareArray[3].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label4.Text = "X";
                        squareArray[3].squareValue = label4.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                      //  checkWinner();
                        
                       // restart();
                    }
                    if (!gameOver)
                        squareArray[3].marked = true;
                                                         
                    executeComputerMove();
                                       
                }
                else if (squareArray[3].marked)
                    MessageBox.Show("This square has already been checked!");
                checkWinner();
                updateScore();
                restart();
            }
                    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!computerMode)
            {

                if (!squareArray[4].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label5.Text = "X";
                        squareArray[4].squareValue = label5.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                    }
                    else if (playerArray[1].myTurn)
                    {
                        label5.Text = "O";
                        squareArray[4].squareValue = label5.Text;
                        playerArray[1].myTurn = false;
                        playerArray[0].myTurn = true;
                    }
                    squareArray[4].marked = true;
                }
                else
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
            else
            {
                if (!squareArray[4].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label5.Text = "X";
                        squareArray[4].squareValue = label5.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                      //  checkWinner();
                        
                      //  restart();
                    }
                    if (!gameOver)
                        squareArray[4].marked = true;
                                  
                    executeComputerMove();
                                      
                }
                else if (squareArray[4].marked)
                    MessageBox.Show("This square has already been checked!");
                checkWinner();
                updateScore();
                restart();
            }
                 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!computerMode)
            {
                if (!squareArray[5].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label6.Text = "X";
                        squareArray[5].squareValue = label6.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                    }
                    else if (playerArray[1].myTurn)
                    {
                        label6.Text = "O";
                        squareArray[5].squareValue = label6.Text;
                        playerArray[1].myTurn = false;
                        playerArray[0].myTurn = true;
                    }
                    squareArray[5].marked = true;
                }
                else
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
            else
            {
                if (!squareArray[5].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label6.Text = "X";
                        squareArray[5].squareValue = label6.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                      //  checkWinner();
                        
                      //  restart();
                    }
                    if (!gameOver)
                        squareArray[5].marked = true;
                                     
                    executeComputerMove();
                    
                   
                }
                else if (squareArray[5].marked)
                    MessageBox.Show("This square has already been checked!");
                checkWinner();
                updateScore();
                restart(); 
            }
                    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!computerMode)
            {
                if (!squareArray[6].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label7.Text = "X";
                        squareArray[6].squareValue = label7.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                    }
                    else if (playerArray[1].myTurn)
                    {
                        label7.Text = "O";
                        squareArray[6].squareValue = label7.Text;
                        playerArray[1].myTurn = false;
                        playerArray[0].myTurn = true;
                    }
                    squareArray[6].marked = true;
                }
                else
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
            else
            {
                if (!squareArray[6].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label7.Text = "X";
                        squareArray[6].squareValue = label7.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                       // checkWinner();
                        
                       // restart();
                    }

                    if (!gameOver)
                        squareArray[6].marked = true;                     
                    executeComputerMove();
                    
                }
                else if (squareArray[6].marked)
                    MessageBox.Show("This square has already been checked!");
                checkWinner();
                updateScore();
                restart();
            }
      
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!computerMode)
            {
                if (!squareArray[7].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label8.Text = "X";
                        squareArray[7].squareValue = label8.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                    }
                    else if (playerArray[1].myTurn)
                    {
                        label8.Text = "O";
                        squareArray[7].squareValue = label8.Text;
                        playerArray[1].myTurn = false;
                        playerArray[0].myTurn = true;
                    }
                    squareArray[7].marked = true;
                }
                else
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
            else
            {
                if (!squareArray[7].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label8.Text = "X";
                        squareArray[7].squareValue = label8.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                       // checkWinner();
                       
                       // restart();
                    }

                    if (!gameOver)
                        squareArray[7].marked = true;
                                     
                    executeComputerMove();
                    
                }
                else if (squareArray[7].marked)
                    MessageBox.Show("This square has already been checked!");
                checkWinner();
                updateScore();
                restart();
              
            }
                   
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!computerMode)
            {
                if (!squareArray[8].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label9.Text = "X";
                        squareArray[8].squareValue = label9.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                    }
                    else if (playerArray[1].myTurn)
                    {
                        label9.Text = "O";
                        squareArray[8].squareValue = label9.Text;
                        playerArray[1].myTurn = false;
                        playerArray[0].myTurn = true;
                    }
                    squareArray[8].marked = true;
                }
                else
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
            else
            {
                if (!squareArray[8].marked)
                {
                    if (playerArray[0].myTurn)
                    {
                        label9.Text = "X";
                        squareArray[8].squareValue = label9.Text;
                        playerArray[0].myTurn = false;
                        playerArray[1].myTurn = true;
                       // checkWinner();
                       
                       // restart();
                    }
                    if (!gameOver)
                        squareArray[8].marked = true;
                                                      
                    executeComputerMove();
                    
                }
                else if(squareArray[8].marked)
                    MessageBox.Show("This square has already been checked!");

                checkWinner();
                updateScore();
                restart();
            }
          
        }


        public void checkWinner()
        {
            //top row
            if ((squareArray[0].squareValue == squareArray[1].squareValue) && (squareArray[1].squareValue == squareArray[2].squareValue))
            {
               
                if (squareArray[0].squareValue != null)
                {
                    //MessageBox.Show("Top Row Victory");
                    if (squareArray[0].squareValue == "X")
                    {
                        MessageBox.Show("Player 1 is the winner!");
                        playerArray[0].myScore++;
                    }
                    else if (squareArray[0].squareValue == "O")
                    {
                        if (computerMode)
                            MessageBox.Show("Computer is the winner!");
                        else
                            MessageBox.Show("Player 2 is the winner!");
                        playerArray[1].myScore++;
                    }
                    gameOver = true;
                }
            }
            //mid row
            else if ((squareArray[3].squareValue == squareArray[4].squareValue) && (squareArray[4].squareValue == squareArray[5].squareValue))
            {
              

                if (squareArray[3].squareValue != null)
                {
                    //MessageBox.Show("Mid Row Victory");
                    if (squareArray[3].squareValue == "X")
                    {
                        MessageBox.Show("Player 1 is the winner!");
                        playerArray[0].myScore++;
                    }
                    else if (squareArray[3].squareValue == "O")
                    {
                        if (computerMode)
                            MessageBox.Show("Computer is the winner!");
                        else
                            MessageBox.Show("Player 2 is the winner!");
                        playerArray[1].myScore++;
                    }
                    gameOver = true;
                }
            }
            //bottom row
            else if ((squareArray[6].squareValue == squareArray[7].squareValue) && (squareArray[7].squareValue == squareArray[8].squareValue))
            {
               
                if (squareArray[6].squareValue != null)
                {
                    //MessageBox.Show("Bottom Row Victory");
                    if (squareArray[6].squareValue == "X")
                    {
                        MessageBox.Show("Player 1 is the winner!");
                        playerArray[0].myScore++;
                    }
                    else if (squareArray[6].squareValue == "O")
                    {
                        if (computerMode)
                            MessageBox.Show("Computer is the winner!");
                        else
                            MessageBox.Show("Player 2 is the winner!");
                        playerArray[1].myScore++;
                    }
                    gameOver = true;
                }

            }
            //left column
            else if ((squareArray[0].squareValue == squareArray[3].squareValue) && (squareArray[3].squareValue == squareArray[6].squareValue))
            {
               
                if (squareArray[0].squareValue != null)
                {
                    //MessageBox.Show("Left Column Victory");
                    if (squareArray[0].squareValue == "X")
                    {
                        MessageBox.Show("Player 1 is the winner!");
                        playerArray[0].myScore++;
                    }
                    else if (squareArray[0].squareValue == "O")
                    {
                        if (computerMode)
                            MessageBox.Show("Computer is the winner!");
                        else
                            MessageBox.Show("Player 2 is the winner!");
                        playerArray[1].myScore++;
                    }
                    gameOver = true;
                }
            }
            //middle column
            else if ((squareArray[1].squareValue == squareArray[4].squareValue) && (squareArray[4].squareValue == squareArray[7].squareValue))
            {
                
                if (squareArray[1].squareValue != null)
                {
                    //MessageBox.Show("Mid Column Victory");
                    if (squareArray[1].squareValue == "X")
                    {
                        MessageBox.Show("Player 1 is the winner!");
                        playerArray[0].myScore++;
                    }
                    else if (squareArray[1].squareValue == "O")
                    {
                        if (computerMode)
                            MessageBox.Show("Computer is the winner!");
                        else
                            MessageBox.Show("Player 2 is the winner!");
                        playerArray[1].myScore++;
                    }
                    gameOver = true;
                }
            }
            //right column
            else if ((squareArray[2].squareValue == squareArray[5].squareValue) && (squareArray[5].squareValue == squareArray[8].squareValue))
            {
                
                if (squareArray[2].squareValue != null)
                {
                   // MessageBox.Show("Right Column Victory");
                    if (squareArray[2].squareValue == "X")
                    {
                        MessageBox.Show("Player 1 is the winner!");
                        playerArray[0].myScore++;
                    }
                    else if (squareArray[2].squareValue == "O")
                    {
                        if (computerMode)
                            MessageBox.Show("Computer is the winner!");
                        else
                            MessageBox.Show("Player 2 is the winner!");
                        playerArray[1].myScore++;
                    }
                    gameOver = true;
                }
            }
            //diagonal left to right
            else if ((squareArray[0].squareValue == squareArray[4].squareValue) && (squareArray[4].squareValue == squareArray[8].squareValue))
            {
                
                if (squareArray[0].squareValue != null)
                {
                   // MessageBox.Show("Diagonal L to R Victory");
                    if (squareArray[0].squareValue == "X")
                    {
                        MessageBox.Show("Player 1 is the winner!");
                        playerArray[0].myScore++;
                    }
                    else if (squareArray[0].squareValue == "O")
                    {
                        if (computerMode)
                            MessageBox.Show("Computer is the winner!");
                        else
                            MessageBox.Show("Player 2 is the winner!");
                        playerArray[1].myScore++;
                    }
                    gameOver = true;
                }
            }
            //diagonal right to left
            else if ((squareArray[2].squareValue == squareArray[4].squareValue) && (squareArray[4].squareValue == squareArray[6].squareValue))
            {
                
                if (squareArray[2].squareValue != null)
                {
                    //MessageBox.Show("Diagonal R to L Victory");
                    if (squareArray[2].squareValue == "X")
                    {
                        MessageBox.Show("Player 1 is the winner!");
                        playerArray[0].myScore++;
                    }
                    else if (squareArray[2].squareValue == "O")
                    {
                        if (computerMode)
                            MessageBox.Show("Computer is the winner!");
                        else
                            MessageBox.Show("Player 2 is the winner!");
                        playerArray[1].myScore++;
                    }
                    gameOver = true;
                }
            }
        }

        

        public void updateScore()
        {
            label13.Text = playerArray[0].myScore.ToString();
            label14.Text = playerArray[1].myScore.ToString();
        }
        //need works
        public void restart()
        {
            if (!gameOver) 
            {
                int trueCounter = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (squareArray[i].marked == true)
                        trueCounter++;
                }
                if (trueCounter == 9)
                {
                
                    MessageBox.Show("This game is a draw");
                    foreach (Square s in squareArray)
                    {
                        s.marked = false;
                        s.squareValue = null;
                    }
                    label1.Text = null;
                    label2.Text = null;
                    label3.Text = null;
                    label4.Text = null;
                    label5.Text = null;
                    label6.Text = null;
                    label7.Text = null;
                    label8.Text = null;
                    label9.Text = null;
                    playerArray[0].myTurn = true;
                    playerArray[1].myTurn = false;
                    gameOver = false;
                    
                }
            }
            else if (gameOver)
            {
                foreach (Square s in squareArray)
                {
                    s.marked = false;
                    s.squareValue = null;
                }
                label1.Text = null;
                label2.Text = null;
                label3.Text = null;
                label4.Text = null;
                label5.Text = null;
                label6.Text = null;
                label7.Text = null;
                label8.Text = null;
                label9.Text = null;
                playerArray[0].myTurn = true;
                playerArray[1].myTurn = false;
                gameOver = false;
            }   
           
        }
        //vs computer mode
        private void vsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label12.Text = "Computer: Os";
            computerMode = true;
            playerArray[0].myScore = 0;
            playerArray[1].myScore = 0;
            updateScore();
            gameOver = true;
            restart();
            
        }
        /*
         * win ?
         * block ?
         * check for corners
         * check for center
         * check for open
         */ 
        public int makeComputerMove()
        {
            if (squareArray[0].marked == false)
                return 0;
            else if (squareArray[2].marked == false)
                return 2;
            else if (squareArray[6].marked == false)
                return 6;
            else if (squareArray[8].marked == false)
                return 8;
            else if (squareArray[4].marked == false)
                return 4;
            else if (squareArray[1].marked == false)
                return 1;
            else if (squareArray[3].marked == false)
                return 3;
            else if (squareArray[5].marked == false)
                return 5;
            else if (squareArray[7].marked == false)
                return 7;

            else
                return -1;     
        }
        public void executeComputerMove()
        {
           
            if ((playerArray[1].myTurn)&&(!gameOver))
            {
                computerResponse = makeComputerMove();
                if (computerResponse == 0)
                {
                    label1.Text = "O";
                    squareArray[0].squareValue = label1.Text;
                    squareArray[0].marked = true;
                }
                else if (computerResponse == 1)
                {
                    label2.Text = "O";
                    squareArray[1].squareValue = label2.Text;
                    squareArray[1].marked = true;
                }
                else if (computerResponse == 2)
                {
                    label3.Text = "O";
                    squareArray[2].squareValue = label3.Text;
                    squareArray[2].marked = true;
                }
                else if (computerResponse == 3)
                {
                    label4.Text = "O";
                    squareArray[3].squareValue = label4.Text;
                    squareArray[3].marked = true;
                }
                else if (computerResponse == 4)
                {
                    label5.Text = "O";
                    squareArray[4].squareValue = label5.Text;
                    squareArray[4].marked = true;
                }
                else if (computerResponse == 5)
                {
                    label6.Text = "O";
                    squareArray[5].squareValue = label6.Text;
                    squareArray[5].marked = true;
                }
                else if (computerResponse == 6)
                {
                    label7.Text = "O";
                    squareArray[6].squareValue = label7.Text;
                    squareArray[6].marked = true;
                }
                else if (computerResponse == 7)
                {
                    label8.Text = "O";
                    squareArray[7].squareValue = label8.Text;
                    squareArray[7].marked = true;
                }
                else if (computerResponse == 8)
                {
                    label9.Text = "O";
                    squareArray[8].squareValue = label9.Text;
                    squareArray[8].marked = true;
                }
                else
                {
                }

                playerArray[1].myTurn = false;
                playerArray[0].myTurn = true;
                    


            }

        }
        //2 player mode
        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            computerMode = false;
            label12.Text = "Player 2: Os";
            playerArray[0].myScore = 0;
            playerArray[1].myScore = 0;
            updateScore();
            gameOver = true;
            restart();
        }
        

       

        
    }
}
