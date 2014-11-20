using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Snake
{
    public partial class MainForm : Form
    {
        Grid newGrid = new Grid();  // Skapar ny grid

        public MainForm()
        {
            InitializeComponent();
        }

       

        private void buttonCreateGrid_Click(object sender, EventArgs e)
        {
            string input = textBoxGridInstructions.Text;


            List<string> inputRowList = new List<string>(Regex.Split(input, Environment.NewLine));

            string[] inputdata = inputRowList[0].Split(',');

            int numberOfXRows = Int32.Parse(inputdata[0]);
            int numberOfYRows = Int32.Parse(inputdata[1]);

            newGrid.createGrid(input, numberOfXRows, numberOfYRows, inputRowList);  // Skapar grid beroende på inputen

          
        }

        private void buttonCountBlocks_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newGrid.Count().ToString());
        }

        private void buttonStartSnake_Click(object sender, EventArgs e)
        {
            newGrid.StartSnake();  // Startar Snake
        }

        private void buttonCheckResult_Click(object sender, EventArgs e)
        {

            if (newGrid.getResult() == 1)
            {
                string temp = "";
                for (int i = 0; i < newGrid.getVisitedBlockList().Count(); i++)
			{
                temp += newGrid.getVisitedBlockList()[i].X;
                temp += newGrid.getVisitedBlockList()[i].Y;
                temp += ",  ";
			}

                MessageBox.Show("Succsess! besökta block: " + temp);
            }
            else
            {
                MessageBox.Show("Nope!");
            }
        }



    
    }
}
