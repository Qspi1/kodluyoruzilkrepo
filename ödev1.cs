using System;

namespace ödev1_patikadev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objective 1
            Console.WriteLine("Enter a positive number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter {0} numbers: ",n);
            for(int i = 0;i < n;i++){
                Console.Write("Enter {0}. number: ",i+1);
                arr[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("Positive numbers: ");
            foreach(var num in arr){
                if(num % 2 == 0)
                    Console.WriteLine(num);
            }

            //Objective 2
            Console.WriteLine("Enter two positive numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[a];

            Console.WriteLine("Enter {0} numbers: ",a);
            for(int i = 0;i < a;i++){
                Console.Write("Enter {0}. number: ",i+1);
                ar[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("Values that equal to {0} or divisible by it: ",b);
            foreach(var num in ar){
                if(num % b == 0)
                    Console.WriteLine(num);
            }

            //Objective 3
            Console.WriteLine("Enter a positive number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            string[] sarr = new string[x];

            Console.WriteLine("Enter {0} numbers: ",x);
            for(int i = 0;i < x;i++){
                Console.WriteLine("Enter {0} sentence: ",i+1);
                sarr[i] = Console.ReadLine();
            }
            Array.Reverse(sarr);

            Console.WriteLine("Reversed array: ");
            foreach(var s in sarr)
                Console.WriteLine(s);
            
            //Objective 4
            Console.WriteLine("Enter a sentence: ");
            string str = Console.ReadLine();
            int words = str.Split(' ').Length;
            int char_count = str.Length;

            Console.WriteLine("Number of words: {0}",words);
            Console.WriteLine("Number of characters: {0}",char_count);
        }
    }
}
