using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MasterMind
{
    public partial class GameScreen : UserControl
    {
        //key presses
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        // listes used to hold the entered order of pegs and the real order of pegs
        public List<string> realOrder = new List<string>();
        public List<string> enteredOrder = new List<string>();

        SolidBrush boardBrush = new SolidBrush(Color.Brown);

        public int colourNumber;

        string realCode;
        

        public GameScreen()
        {
            InitializeComponent();
            
            realSequence();

        
            
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        //method to create the code that the player has to determine
        public void realSequence()
        {
            Random randGen = new Random();

            for (int i = 0; i < 4; i++)
            {
                colourNumber = randGen.Next(1, 9);

                switch (colourNumber)
                {
                    case 1:
                        realCode = "Red";
                        break;
                    case 2:
                        realCode = "Blue";
                        break;
                    case 3:
                        realCode = "Yellow";
                        break;
                    case 4:
                        realCode = "Green";
                        break;
                    case 5:
                        realCode = "Orange";
                        break;
                    case 6:
                        realCode = "Purple";
                        break;
                    case 7:
                        realCode = "Black";
                        break;
                    case 8:
                        realCode = "White";
                        break;
                }
                realOrder.Add(realCode);
            }
        }

        private void GameScreen_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(boardBrush, 100, 100, 100, 100);

            for (int i = 0; i < realOrder.Count(); i++)
            {
                label1.Text += "\n" + i + ": " + realOrder[i];
            }
            for (int i = 0; i < enteredOrder.Count(); i++)
            {
                label2.Text += "\n" + i + ": " + enteredOrder[i];
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }



        private void redButton_Click(object sender, EventArgs e)
            {
                enteredOrder.Add("Red");
            }

        private void blueButton_Click(object sender, EventArgs e)
            {
                enteredOrder.Add("Blue");
            }

            private void yellowButton_Click(object sender, EventArgs e)
            {
                enteredOrder.Add("Yellow");
            }

            private void greenButton_Click(object sender, EventArgs e)
            {
                enteredOrder.Add("Green");
            }

            private void orangeButton_Click(object sender, EventArgs e)
            {
                enteredOrder.Add("Orange");
            }

            private void purpleButton_Click(object sender, EventArgs e)
            {
                enteredOrder.Add("Purple");
            }

            private void blackButton_Click(object sender, EventArgs e)
            {
                enteredOrder.Add("Black");
            }

            private void whiteButton_Click(object sender, EventArgs e)
            {
                enteredOrder.Add("White");
            }
    }
}