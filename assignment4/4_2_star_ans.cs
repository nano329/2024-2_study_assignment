using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);

            // ---------- TODO ----------
            int interval1 = size / 3, interval2 = interval1 - ((size % 3) == 0 ? 1 : 0);
            
            for(int j = 0; j < radius * 2 + 1 + interval1; j++){
                Console.Write(" ");
            }
            Console.Write("*");
            for(int j = 0; j < interval2; j++){
                Console.Write(" ");
            }
            Console.WriteLine("*");
            //Console.WriteLine(' ' * (radius * 2 + 1 + interval1) + '*' + ' ' * interval2 + '*');
            for(int i = 1; i < size; i++){
                if(i == 1 || i == size - 1){
                    Console.Write(" ");
                    for(int j = 0; j < radius * 2 - 1; j++){
                        Console.Write("*");
                    }
                    Console.Write(" ");
                }
                else{
                    Console.Write("*");
                    for(int j = 0; j < radius * 2; j++){
                        Console.Write(" ");
                    }
                }
                if(i == interval1 || i == interval1 + interval2 + 1){
                    for(int j = 0; j < size; j++){
                        Console.Write("*");
                    }
                }
                else{
                    for(int j = 0; j < interval1; j++){
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for(int j = 0; j < interval2; j++){
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for(int j = 0; j < size - interval1 - interval2 - 2; j++){
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


            // --------------------
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        // Checks if two values a and b are within a given distance.
        // |a - b| < distance
        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}


/* example output
Enter the radius: 
>> 5
                *   *   
  *********     *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
  *********     *   *   

*/

/* example output (CHALLANGE)
Enter the radius: 
>> 5
                *   *  
      *         *   *  
   *     *      *   *  
  *                    
           ************
               *   *   
 *             *   *   
               *   *   
           ************
  *                    
   *     *    *   *    
      *       *   *    

*/
