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
        List<Block> VisitedBlocks = new List<Block>();

        int finalResult;

        public Snake(object theBlockArrayObject)
        {
            this.theNewBlockArrayObject = (BlockArray)theBlockArrayObject;
           int result = Go();
           finalResult = result;
        }

        public int getResult()
        {
            return finalResult;
        }

        public List<Block> getVisitedBlockList()
        {
            return VisitedBlocks;
        }

        private int Go()
        {

          string dir = "down";
          int result = GoGo((theNewBlockArrayObject.blockArray[0, 0]), dir);

          if (result == 1)
          {
              return 1;
          }
          else
          {
              return 0;
          }
        }

        private int GoGo(Block currentBlock, string dir)
        {

            currentBlock.Visited = true;
            VisitedBlocks.Add(currentBlock);


             if (dir == "down")
                {
                    if (currentBlock.Y + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                    {
                      if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Visited == false)
                        {
                            //currentBlock.Visited = true;
                            //VisitedBlocks.Add(currentBlock);
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                        }
                        else  // Nästa är röd & eller upptagen
                        {
                            if (currentBlock.X + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                            {
                                if (theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Visited == false)
                                {
                                    dir = "right";
                                    //currentBlock.Visited = true;
                                    //VisitedBlocks.Add(currentBlock);
                                    GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                                }
                            }

                            else if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)].Status != "red") // Kolla till vänster
                            {
                                dir = "left";
                                //currentBlock.Visited = true;
                                //VisitedBlocks.Add(currentBlock);
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                            }
                        }

                    }

                    else // Out of bounds
                    {
                        if (currentBlock.X + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                        {
                            if (theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)].Status != "red") // Kolla till höger
                            {
                                dir = "right";
                                //currentBlock.Visited = true;
                                //VisitedBlocks.Add(currentBlock);
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                            }
                        }

                        else if(currentBlock.X - 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                        {
                         if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)].Status != "red") // Kolla till vänster
                            {
                                dir = "left";
                                //currentBlock.Visited = true;
                                //VisitedBlocks.Add(currentBlock);
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                            }
                        }
                    }
                }

                else if (dir == "right")
                {
                    if (currentBlock.X + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                    {
                        if (theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Visited == false)
                        {
                            //currentBlock.Visited = true;
                            //VisitedBlocks.Add(currentBlock);
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                        }
                        else  // Nästa är röd & eller upptagen
                        {
                            if (currentBlock.Y + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                            {
                                if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Visited == false)
                                {
                                    dir = "down";
                                    //currentBlock.Visited = true;
                                    //VisitedBlocks.Add(currentBlock);
                                    GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                                }
                            }

                            else if (theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)].Status != "red") // Kolla till vänster
                            {
                                dir = "up";
                                //currentBlock.Visited = true;
                                //VisitedBlocks.Add(currentBlock);
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)], dir);
                            }
                        }

                    }

                    else // Out of bounds
                    {
                        if (currentBlock.Y + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                        {
                            if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Visited == false)
                            {
                                dir = "down";
                                //currentBlock.Visited = true;
                                //VisitedBlocks.Add(currentBlock);
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                            }
                        }

                        else if (theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)].Status != "red") // Kolla till vänster
                        {
                            dir = "up";
                            //currentBlock.Visited = true;
                            //VisitedBlocks.Add(currentBlock);
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)], dir);
                        }
                    }
                }

                else if (dir == "up")
                {
                    if (currentBlock.Y - 1 >= 0)
                    {
                      if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y - 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y - 1].Visited == false)
                        {
                            //currentBlock.Visited = true;
                            //VisitedBlocks.Add(currentBlock);
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)], dir);
                        }
                        else  // Nästa är röd & eller upptagen
                        {
                            if (currentBlock.X + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                            {
                                if (theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Visited == false)
                                {
                                    dir = "right";
                                    //currentBlock.Visited = true;
                                    //VisitedBlocks.Add(currentBlock);
                                    GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                                }
                            }

                            else if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)].Status != "red") // Kolla till vänster
                            {
                                dir = "left";
                                //currentBlock.Visited = true;
                                //VisitedBlocks.Add(currentBlock);
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                            }
                        }

                    }

                    else // Out of bounds
                    {
                        if (currentBlock.X + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                        {
                            if (theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)].Status != "red") // Kolla till höger
                            {
                                dir = "right";
                                //currentBlock.Visited = true;
                                //VisitedBlocks.Add(currentBlock);
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                            }
                        }

                        else if(currentBlock.X - 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                        {
                         if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)].Status != "red") // Kolla till vänster
                            {
                                dir = "left";
                                //currentBlock.Visited = true;
                                //VisitedBlocks.Add(currentBlock);
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                            }
                        }
                    }
                }



             else if (dir == "left")
             {
                 if (currentBlock.X - 1 >= 0)
                 {
                     if (theNewBlockArrayObject.blockArray[currentBlock.X - 1, currentBlock.Y].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X - 1, currentBlock.Y].Visited == false)
                     {
                         //currentBlock.Visited = true;
                         //VisitedBlocks.Add(currentBlock);
                         GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                     }
                     else  // Nästa är röd & eller upptagen
                     {
                         if (currentBlock.Y + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                         {
                             if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Visited == false)
                             {
                                 dir = "down";
                                 //currentBlock.Visited = true;
                                 //VisitedBlocks.Add(currentBlock);
                                 GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                             }
                         }

                         else if (theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)].Status != "red") // Kolla till vänster
                         {
                             dir = "up";
                             //currentBlock.Visited = true;
                             //VisitedBlocks.Add(currentBlock);
                             GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)], dir);
                         }
                     }

                 }

                 else // Out of bounds
                 {
                     if (currentBlock.Y + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                     {
                         if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Visited == false)
                         {
                             dir = "down";
                             //currentBlock.Visited = true;
                             //VisitedBlocks.Add(currentBlock);
                             GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                         }
                     }

                     else if (theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)].Status != "red") // Kolla till vänster
                     {
                         dir = "up";
                         //currentBlock.Visited = true;
                         //VisitedBlocks.Add(currentBlock);
                         GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)], dir);
                     }
                 }
             }


                else  // Används ej
                {

                    return 0;


                }

                return 1;
            }

        
        }

       

    }


