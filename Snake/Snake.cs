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
         
        public Snake(List<Block> blockList)
        {           
            this.blockList = blockList;
            Go();
        }

        private void Go()
        {
            for (int i = 0; i < blockList.Count(); i++)
            {
                GoGo((blockList[i+1]));
                output = output + "i ";
            }
        }

        private void GoGo(Block currentBlock)
        {
            if (currentBlock != null)
            {
                if (currentBlock.Status != "red")
                {
                   
                }
            }
        }

       

    }
}
