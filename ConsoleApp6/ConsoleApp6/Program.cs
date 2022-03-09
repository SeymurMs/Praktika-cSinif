using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(sum(21, 31));
            //Console.WriteLine(FindCharindex("nar"));
            //int[] arr = { -1, 2, -3, 4 };
            //foreach (var item in array(ref arr))
            //{
            //    Console.WriteLine(item);
            //}
            // Ededin kok almasi 
        }
        static int sum(int a, int b, int c=0)
        {
         
            
            return a+ b +c ;
        }
        static dynamic FindCharindex(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')

                {

                    return i;
                }
            
                   

            }
            return -1;
        }

       
        
        
        
        
        static int[] array ( ref int [] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
              if (arr1[i]<0)
                {
                    arr1[i] *= -1;

                    
                }
                   
               
            }
            return arr1;
           
            
        }
    }
}
