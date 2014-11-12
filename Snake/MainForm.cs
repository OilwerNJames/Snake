using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            newGrid.createGrid(input);  // Skapar grid beroende på inputen
          
        }

        private void buttonCountBlocks_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newGrid.Count().ToString());
        }

        private void buttonStartSnake_Click(object sender, EventArgs e)
        {
            newGrid.StartSnake();  // Startar Snake
        }



    
    }
}
