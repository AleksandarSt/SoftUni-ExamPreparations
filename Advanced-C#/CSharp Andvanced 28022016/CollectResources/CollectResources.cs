using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectResources
{
    class CollectResources
    {
        static void Main()
        {
            string[] validRecources =  {"stone", "gold", "wood", "food"};

            string[] resourceField = Console.ReadLine().Split(' ');

            int collectionPaths = int.Parse(Console.ReadLine());

            int[] startingPositions = new int[collectionPaths];
            int[] steps = new int[collectionPaths];

            for (int i = 0; i < collectionPaths; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                startingPositions[i] = int.Parse(line[0]);
                steps[i] = int.Parse(line[1]);
            }

            int maxResult = 0;

            for (int i = 0; i < collectionPaths; i++)
            {
                List<int> visitedPositions=new List<int>();
                int positionOnTheField = startingPositions[i];
                int step = steps[i];
                string currentString = resourceField[positionOnTheField];
                string[] currentElement=new string[2];
                int currentResult = 0;

                if (currentString.Split('_').Length==1)
                {
                    currentElement[0] = currentString;
                    currentElement[1] = "1";
                }
                else
                {
                    currentElement=currentString.Split('_');
                }

                do
                {
                    if (visitedPositions.Contains(positionOnTheField))
                    {
                        break;
                    }
                    visitedPositions.Add(positionOnTheField);

                    currentString = resourceField[positionOnTheField];

                    if (currentString.Split('_').Length == 1)
                    {
                        currentElement[0] = currentString;
                        currentElement[1] = "1";
                    }
                    else
                    {
                        currentElement = currentString.Split('_');
                    }

                    if (validRecources.Contains(currentElement[0]))
                    {
                        currentResult = currentResult + int.Parse(currentElement[1]);
                    }

                    if (positionOnTheField+step>=resourceField.Length)
                    {

                        if (step > resourceField.Length &&
                            positionOnTheField + step%resourceField.Length < resourceField.Length)
                        {
                            positionOnTheField = positionOnTheField + step % resourceField.Length;
                        }
                        else if (positionOnTheField == resourceField.Length-1)
                        {
                            positionOnTheField = step;
                        }
                        else
                        {
                            positionOnTheField = step / resourceField.Length;
                        }
                        
                    }
                    else
                    {
                        positionOnTheField = positionOnTheField + step;
                    }

                } while (true);

                if (maxResult<currentResult)
                {
                    maxResult = currentResult;
                }
            }

            Console.WriteLine(maxResult);
        }
    }
}
