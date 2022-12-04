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

        private GraphGrid graphGrid;

        public Form1()
        {
            InitializeComponent();            
        }
                

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.graphGrid = new GraphGrid(graphImgBox);
            graphGrid.DrawGrid();
        }


        private void GoBtn_Click(object sender, EventArgs e)
        {

            graphGrid.Clean();
            graphGrid.DrawGrid();


            UserInput input = new UserInput(inputFunctionBox.Text);
            string saveStr = input.Str;
            
            // calculating for each x the y value and drawing the graph
            for (int x = 0-graphGrid.ZeroX; x < graphGrid.ZeroX; x++)
            {
                
                input.Str = saveStr;
                input.HandleParameters();
                input.ReplaceParameter('x', x.ToString());
                input.PrepareForCalc();

                Expression exp = Expression.BuildTree(input.Str);
                double y = exp.Interpret();
                
                graphGrid.DrawPixel(x, (int)y, Color.FromArgb(48, 168, 255)); // draws the pixel on the grid                
            }

            
            graphImgBox.Refresh();
            
        }


    }
}
