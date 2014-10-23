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

namespace Snake
{
    public partial class MainForm : Form
    {
        Grid newGrid = new Grid();
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

            for (int x = 0; x < numberOfXRows; x++)
			{
                for (int y = 0; y < numberOfYRows; y++)
                {
                    newGrid.createBlock(x, y, "free");
                }
			}

            string[] takenRows = new string[inputRowList.Count()];

            for (int i = 1; i < inputRowList.Count(); i++)
            {
                takenRows[i] = inputRowList[i];

                string[] busyBlockData = takenRows[i].Split(',');

                int x = Int32.Parse(busyBlockData[0]);
                int y = Int32.Parse(busyBlockData[1]);

                 newGrid.updateBlock(x, y, "red");


              //  MessageBox.Show(takenRows[i]);
            }
          
        }
    }
}
