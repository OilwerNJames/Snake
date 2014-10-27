using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Snake
{
    class Grid
    {

        List<Block> blockList = new List<Block>();

        public void createBlock(int x, int y, string status)
        {
            Block newBlock = new Block(x, y, status);
            blockList.Add(newBlock);

        }

        public void updateBlock(int x, int y, string status)
        {
              Block tempBlock = new Block(x, y, "free");

              int positionOfBlock = blockList.FindIndex(Block => Block.X == x && Block.Y == y);

           Block updatedBlock = blockList.Find(Block => Block.X == x && Block.Y == y);
            updatedBlock.Status = status;

            blockList[positionOfBlock] = updatedBlock;

        }

        public void createGrid(string input)
        {
            List<string> inputRowList = new List<string>(Regex.Split(input, Environment.NewLine));

            string[] inputdata = inputRowList[0].Split(',');

            int numberOfXRows = Int32.Parse(inputdata[0]);
            int numberOfYRows = Int32.Parse(inputdata[1]);

            for (int x = 0; x < numberOfXRows; x++)
            {
                for (int y = 0; y < numberOfYRows; y++)
                {
                    createBlock(x, y, "free");
                }
            }

            string[] takenRows = new string[inputRowList.Count()];

            for (int i = 1; i < inputRowList.Count(); i++)
            {
                takenRows[i] = inputRowList[i];

                string[] busyBlockData = takenRows[i].Split(',');

                int x = Int32.Parse(busyBlockData[0]);
                int y = Int32.Parse(busyBlockData[1]);

                updateBlock(x, y, "red");


                //  MessageBox.Show(takenRows[i]);
            }

        }

        public int Count()
        {
            return blockList.Count();
        }

        public void StartSnake()
        {
            Snake theSnake = new Snake(blockList);
        }


    }
}
