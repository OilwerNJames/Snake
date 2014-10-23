using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
