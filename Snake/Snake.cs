using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        //Skapa en ny BlockArray och list av blocks.
        BlockArray theNewBlockArrayObject = new BlockArray(1,2);
        List<Block> VisitedBlocks = new List<Block>();

        int finalResult;

        /// <summary>
        /// Konstruktör som byger det nya blockarray och kör go.
        /// </summary>
        /// <param name="theBlockArrayObject"></param>
        public Snake(object theBlockArrayObject)
        {
            this.theNewBlockArrayObject = (BlockArray)theBlockArrayObject;
           int result = Go();
           finalResult = result;
        }

        /// <summary>
        /// Returnera resultaten av snaken så andra klasser kan använder
        /// </summary>
        /// <returns></returns>
        public int getResult()
        {
            return finalResult;
        }

        /// <summary>
        /// Returnera lista av besökta blocks
        /// </summary>
        /// <returns></returns>
        public List<Block> getVisitedBlockList()
        {
            return VisitedBlocks;
        }

        /// <summary>
        /// Metod go som gör GoGo med start punkt 0,0 och returnera om resultaten vad 1 eller 0, lyckades eller inte. 
        /// </summary>
        /// <returns></returns>
        private int Go()
        {
          //Börja med direction down som default. Riktingen som snake går
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

        /// <summary>
        /// Metoden som styr snake, innehåller 4 main if satser som är beroende på riktning Upp, neråt, vänster eller höger. Metoden är rekrusiv så man har
        /// parameter av currentblock som är blocken snaken befinner sig i. Dir är riktning och är ochså i parametern. 
        /// </summary>
        /// <param name="currentBlock"></param>
        /// <param name="dir"></param>
        /// <returns></returns>
        private int GoGo(Block currentBlock, string dir)
        {

            currentBlock.Visited = true;
            VisitedBlocks.Add(currentBlock);

            //Om down
             if (dir == "down")
                {   //Om current block + 1 har inte en högre värdet en arrayns länged så det blir ingen fel med OutOfBounds
                    if (currentBlock.Y + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                    {  //Så länge nästa block är inte röd eller visited.
                      if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Visited == false)
                        {
                            //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                        }
                        else  // Nästa är röd & eller upptagen
                        {
                            if (currentBlock.X + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                            {  //Börja med att kolla till höger
                                if (theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Visited == false)
                                {
                                    dir = "right";
                                  
                                    //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                    GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                                }
                            }

                            else if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)].Status != "red") // Kolla till vänster
                            { //Sen koller till vänster
                                dir = "left";
                                //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                            }
                        }

                    }

                    else // Out of bounds
                    {  //Om current block + 1 har inte en högre värdet en arrayns länged så det blir ingen fel med OutOfBounds
                        if (currentBlock.X + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                        {
                            if (theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)].Status != "red") // Kolla till höger
                            {
                                dir = "right";
                                //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                            }
                        }

                        else if(currentBlock.X - 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                        {
                         if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)].Status != "red") // Kolla till vänster
                            {
                                dir = "left";
                                //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                            }
                        }
                    }
                }
                 //Om höger
                else if (dir == "right")
             { //Om current block + 1 har inte en högre värdet en arrayns länged så det blir ingen fel med OutOfBounds
                    if (currentBlock.X + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                    {
                        if (theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Visited == false)
                        {
                            //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                        }
                        else  // Nästa är röd & eller upptagen
                        {
                            if (currentBlock.Y + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                            {
                                if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Visited == false)
                                {
                                    dir = "down";
                                    //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                    GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                                }
                            }

                            else if (theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)].Status != "red") // Kolla till vänster
                            {
                                dir = "up";
                                //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
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
                                //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                            }
                        }

                        else if (theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)].Status != "red") // Kolla till vänster
                        {
                            dir = "up";
                            //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)], dir);
                        }
                    }
                }
                 //Om up
                else if (dir == "up")
                {   //Om current blocks y värdet är inte mindre en 0
                    if (currentBlock.Y - 1 >= 0)
                    {
                      if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y - 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y - 1].Visited == false)
                        {
                            //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                            GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)], dir);
                        }
                        else  // Nästa är röd & eller upptagen
                        {
                            if (currentBlock.X + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                            {
                                if (theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X + 1, currentBlock.Y].Visited == false)
                                {
                                    dir = "right";
                                    //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                    GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                                }
                            }

                            else if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)].Status != "red") // Kolla till vänster
                            {
                                dir = "left";
                                //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
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
                                //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X + 1), (currentBlock.Y)], dir);
                            }
                        }

                        else if(currentBlock.X - 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                        {
                         if (theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)].Status != "red") // Kolla till vänster
                            {
                                dir = "left";
                                //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                            }
                        }
                    }
                }


             //Om vänster 
             else if (dir == "left")
             { //Om current blocks x värdet är inte mindre en 0
                 if (currentBlock.X - 1 >= 0)
                 {
                     if (theNewBlockArrayObject.blockArray[currentBlock.X - 1, currentBlock.Y].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X - 1, currentBlock.Y].Visited == false)
                     {
                         //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                         GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X - 1), (currentBlock.Y)], dir);
                     }
                     else  // Nästa är röd & eller upptagen
                     {
                         if (currentBlock.Y + 1 < theNewBlockArrayObject.blockArray.GetLength(1))
                         {
                             if (theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Status != "red" && theNewBlockArrayObject.blockArray[currentBlock.X, currentBlock.Y + 1].Visited == false)
                             {
                                 dir = "down";
                                 //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                                 GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                             }
                         }

                         else if (theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)].Status != "red") // Kolla till vänster
                         {
                             dir = "up";
                             //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
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
                             //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
                             GoGo(theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y + 1)], dir);
                         }
                     }

                     else if (theNewBlockArrayObject.blockArray[(currentBlock.X), (currentBlock.Y - 1)].Status != "red") // Kolla till vänster
                     {
                         dir = "up";
                         //Kallar samma metod med en ny current block värdet, görs genom + 1 och skicka med en Direction
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


