using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        BlockArray theNewBlockArrayObject = new BlockArray(1,2);

        List<Block> blockList = new List<Block>();
        string output = "";
        int i = 0;

        public Snake(object theBlockArrayObject)
        {
            this.theNewBlockArrayObject = (BlockArray)theBlockArrayObject;
            Go();
        }

        private void Go()
        {

            string dir = "down";
            GoGo((theNewBlockArrayObject.blockArray[0, 0]), dir);
               
        }

        private void GoGo(Block currentBlock, string dir)
        {
            if (dir == "down")
            {

                if (theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)] != null) // TRY
                {
                    if (currentBlock.Status != "red")
                    {
                        // i = i + 1;
                        // int nextX = currentBlock.X + 1;
                        currentBlock.Visited = true;
                        GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                        // GoGo(currentBlock);
                    }
                    else  // Den är röd
                    {
                        if (theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)].Status != "red") // Kolla till höger
                        {
                            dir = "right";
                            currentBlock.Visited = true;
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                        }

                        else if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)].Status != "red") // Kolla till vänster
                        {
                            dir = "left";
                            currentBlock.Visited = true;
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                        }
                    }

                }

                else  // finns inte
                {
                    if (theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)] != null) // Kolla till höger
                    {
                        dir = "right";
                        currentBlock.Visited = true;
                        GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                    }

                    else if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)] != null) // Kolla till vänster
                    {
                        dir = "left";
                        currentBlock.Visited = true;
                        GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                    }



                }
            }
        }

       

    }
}
