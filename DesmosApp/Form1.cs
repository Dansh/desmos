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


        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }


        private void GoBtn_Click(object sender, EventArgs e)
        {
            graphImgBox.Image = Properties.Resources.white;
            UserInput input = new UserInput(inputFunctionBox.Text);

            string saveStr = input.Str;
            Bitmap bmp = graphImgBox.Image as Bitmap;
            Console.WriteLine(graphImgBox.Image.Width);
            for (int x = 1; x < graphImgBox.Image.Width; x++)
            {
                input.Str = saveStr;
                input.HandleParameters();
                input.ReplaceParameter('x', x.ToString());
                input.PrepareForCalc();
                Expression exp = Expression.BuildTree(input.Str);
                int y = exp.Interpret();
                if (y < graphImgBox.Image.Height)
                {
                    bmp.SetPixel(x, graphImgBox.Image.Height-y, Color.Black);
                }
            }
            graphImgBox.Refresh();

        }     
    }
}
