
namespace SpiralArray
{
    public class SpiralArray
    {
        public int [,] GetSpiral(int lenght)
        {
            int[,] spiralArray = new int[lenght, lenght];
            string direction = "left-right";
            int count = 1;
            int rounds = 0;

            while (count <= lenght * lenght)
            { 
                if (direction.Equals("left-right"))  {
                    for (int y = 0 + rounds; y < lenght - rounds; y++)
                    {
                        spiralArray[0 + rounds, y] = count++;
                    }
                    direction = "up-down";
                } 
                if (direction.Equals("up-down"))  {
                    for (int x = 1 + rounds; x < lenght - rounds; x++)
                    {
                        spiralArray[x, lenght - 1 - rounds] = count++;                        
                    }
                    direction = "right-left";
                }
                if (direction.Equals("right-left"))  {
                    for (int y = lenght - rounds - 2; y >= 0 + rounds; y--)
                    {
                        spiralArray[lenght - 1 - rounds, y] = count++;
                    }
                    direction = "down-up";
                }
                if (direction.Equals("down-up")) {
                    for (int x = lenght - rounds - 2; x >= 1 + rounds; x--)
                    {
                        spiralArray[x, 0 + rounds] = count++;
                    }
                    direction = "left-right";
                    rounds++;
                }
            }

            return spiralArray;
        }
    }
}
