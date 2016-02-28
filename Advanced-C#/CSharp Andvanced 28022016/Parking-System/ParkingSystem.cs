using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Parking_System
{
    class ParkingSystem
    {
        static void Main()
        {
            const int startingPositionColIndex = 0;

            string[] parkingDimensions = Console.ReadLine().Split(' ');
            List<string[]> commands=new List<string[]>();
            string currentLine=Console.ReadLine();

            while (currentLine!="stop")
            {
                commands.Add(currentLine.Split(' '));
                currentLine = Console.ReadLine();
            }

            int[,] parkingMatrix = new int[int.Parse(parkingDimensions[0]), int.Parse(parkingDimensions[1])];

            for (int i = 0; i < parkingMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < int.Parse(parkingDimensions[1]); j++)
                {
                    parkingMatrix[i, j] = 0;
                }
            }

            for (int i = 0; i < commands.Count; i++)
            {
                string[] currentCommand = commands[i];
                int startingRow = int.Parse(currentCommand[0]);
                int startingCow = startingPositionColIndex;
                int currentDesinationRow = int.Parse(currentCommand[1]);
                int currentDestinatonCow = int.Parse(currentCommand[2]);

                string[] currentParkingRow = new string[parkingMatrix.GetLength(0)];

                for (int j = 0; j < currentParkingRow.Length; j++)
                {
                    currentParkingRow[j] = parkingMatrix[currentDesinationRow, j].ToString();
                }
                

               
                bool isParked = false;
                int distance = 1;

                do
                {

                    var pathLength = 0;
                    if (parkingMatrix[currentDesinationRow,currentDestinatonCow]==0)
                    {
                        parkingMatrix[currentDesinationRow, currentDestinatonCow] = 1;
                        pathLength = (currentDesinationRow - startingRow+1) + (currentDestinatonCow - startingCow);
                        isParked = true;
                        Console.WriteLine(pathLength);
                        break;
                    }
                    else if (parkingMatrix[currentDesinationRow, currentDestinatonCow - distance] == 0)
                    {
                        currentDestinatonCow = currentDestinatonCow - distance;
                        parkingMatrix[currentDesinationRow, currentDestinatonCow] = 1;
                        pathLength = (currentDesinationRow - startingRow + 1) + (currentDestinatonCow - startingCow);
                        isParked = true;
                        Console.WriteLine(pathLength);
                        break;
                    }
                    else if (parkingMatrix[currentDesinationRow, currentDestinatonCow + distance] == 0)
                    {
                        currentDestinatonCow = currentDestinatonCow + distance;
                        parkingMatrix[currentDesinationRow, currentDestinatonCow] = 1;
                        pathLength = (currentDesinationRow - startingRow + 1) + (currentDestinatonCow - startingCow);
                        isParked = true;
                        Console.WriteLine(pathLength);
                        break;
                    }

                    if (!(currentDestinatonCow+distance < currentParkingRow.Length && currentDestinatonCow-distance > 0))
                    {
                        break;
                    }

                    distance++;

                    if (!(currentDestinatonCow + distance < currentParkingRow.Length && currentDestinatonCow - distance > 0))
                    {
                        break;
                    }

                } while (true);

                if (!isParked)
                {
                    Console.WriteLine("Row {0} full", currentDesinationRow);
                }
            }
        }
    }
}
