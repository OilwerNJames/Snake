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

       
        /// <summary>
        /// Skapa en grid genom att tar informationen från text boxen och dela up det in i parameter för metod fråd grid klassen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateGrid_Click(object sender, EventArgs e)
        {
            string input = textBoxGridInstructions.Text;


            List<string> inputRowList = new List<string>(Regex.Split(input, Environment.NewLine));

            //Dela upp strängen
            string[] inputdata = inputRowList[0].Split(',');

            int numberOfXRows = Int32.Parse(inputdata[0]);
            int numberOfYRows = Int32.Parse(inputdata[1]);

            newGrid.createGrid(input, numberOfXRows, numberOfYRows, inputRowList);  // Skapar grid beroende på inputen

          
        }

        /// <summary>
        /// Metod att visa hur många blocks var skapad. Visa det i en message box. Kalla metod från grid klassen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountBlocks_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newGrid.Count().ToString());
        }

        /// <summary>
        /// Metod som startar snake som går igenom grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartSnake_Click(object sender, EventArgs e)
        {
            newGrid.StartSnake(); 
        }

        /// <summary>
        /// Metod som visa om det lyckades med att köra snaken. Om resultaten från snake är 1 så lyuckades det annars gick det inte. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckResult_Click(object sender, EventArgs e)
        {

            if (newGrid.getResult() == 1)
            {
                //For loop at går igenom besökta block och tar deras x och y värde och sätter ihop dom sen en , att seperara nästa kordinater som snake gick till
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
