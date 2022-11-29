using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesmosApp
{
    public class ButtonGrid
    {
        private Button[,] grid;
        private readonly int buttonAmountRow;
        private readonly int buttonAmountCol;
        private readonly int buttonSize;

        public int ButtonAmountRow
        {
            get
            {
                return buttonAmountRow;
            }
        }

        public int ButtonAmountCol
        {
            get
            {
                return buttonAmountCol;
            }
        }

        public ButtonGrid(int buttonAmountRow, int buttonAmountCol, int buttonSize)
        {
            this.buttonAmountRow = buttonAmountRow;
            this.buttonAmountCol = buttonAmountCol;
            this.buttonSize = buttonSize;
            grid = new Button[buttonAmountRow, buttonAmountCol];
        }

        public Button this [int row, int col]
        {
            get
            {
                return grid[row, col];
            }
            set
            {
                grid[row, col] = value;
            }
        }

        public void Draw(Form form, int startX, int startY)
        {
            for (int i = 0; i < 36; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button newButton = new Button();
                    grid[i, j] = newButton;
                    form.Controls.Add(newButton); // adding button to the current form
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.BackgroundImage = Properties.Resources.whiteImg;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.Size = new Size(buttonSize, buttonSize);
                    newButton.Location = new Point(startX + i * buttonSize, startY + j * buttonSize);
                }
            }
        }


        // Summary:
        //   gets a row, column and a color and changes the button background color (image)
        //   in the specific location 
        public void ColorButton(Color color, int row, int col)
        {
            Button button = grid[row, col];
            if (color == Color.White)
            {
                button.BackgroundImage = Properties.Resources.whiteImg;
            }
            else if (color == Color.Black)
            {
                button.BackgroundImage = Properties.Resources.blackImg;
            }
            else
            {
                throw new Exception("Not Supporting Color - " + color.ToString()); // create a custom exception
            }
        }


    }
}
