using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesmosApp
{
    public partial class Form1 : Form
    {

        private ButtonGrid buttonGrid;
        public Form1()
        {
            InitializeComponent();
            
        }

        public ButtonGrid InitButtonGrid()
        {
            int buttonSize = 10;
            int amountX = 36;
            int amountY = 20;
            ButtonGrid buttonGrid = new ButtonGrid(amountX, amountY, buttonSize);

            int gridStartX = 200;
            int gridStartY = 80;
            buttonGrid.Draw(this, gridStartX, gridStartY);

            return buttonGrid;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonGrid = InitButtonGrid();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            // getting and preparing input to be calculated
            string expStr = inputFunctionBox.Text;
            expStr = InputManager.RemoveWhiteSpaces(expStr);
            expStr = InputManager.HandleParameters(expStr);
            expStr = Expression.InfixToPrefix(expStr);

            string originalExpStr = expStr;
            for (int i = 0; i < buttonGrid.ButtonAmountRow; i++)
            {
                expStr = InputManager.ReplaceCharByString(originalExpStr, 'x', (i + 1).ToString());
                Expression exp = Expression.BuildTree(expStr);
                int answer = exp.Interpret(); // calculating input expression  
                Console.WriteLine(expStr);
                if (answer <= 26)
                {
                    buttonGrid.ColorButton(Color.Black, i, answer-1);
                }                
            }
            
        }
    }
}
