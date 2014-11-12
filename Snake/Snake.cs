using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        List<Block> blockList = new List<Block>();
        string output = "";
        int i = 0;
         
        public Snake(List<Block> blockList)
        {           
            this.blockList = blockList;
            Go();
        }

        private void Go()
        {
               
                GoGo((blockList[0]));
               
        }

        private void GoGo(Block currentBlock)
        {
           
            if (currentBlock != null)
            {
                if (currentBlock.Status != "red")
                {
                    i = i + 1;
                    int nextX = currentBlock.X + 1;
                    currentBlock.X = nextX;
                    output = output + i;
                    GoGo(currentBlock);
                }

            }
        }

       

    }
}
