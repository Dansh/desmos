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
        public Form1()
        {
            InitializeComponent();
            
        }

        public void InitButtonsGrid()
        {
            int gridStartX = 200;
            int gridStartY = 80;
            int buttonSize = 10;
            for (int i = 0; i < 36; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button newButton = new Button();
                    this.Controls.Add(newButton); // adding button to the current form
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.BackgroundImage = Properties.Resources.whiteImg;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.Size = new Size(buttonSize, buttonSize);
                    newButton.Location = new Point(gridStartX + i*buttonSize, gridStartY + j*buttonSize);
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitButtonsGrid();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            // getting and preparing input to be calculated
            string expStr = inputFunctionBox.Text;
            expStr = InputManager.RemoveWhiteSpaces(expStr);
            expStr = Expression.InfixToPrefix(expStr);
            Expression exp = Expression.BuildTree(expStr);

            Console.WriteLine(exp.Interpret()); // calculating input expression
        }
    }
}
