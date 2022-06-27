/*
Aşağıdaki 3 soruyu ayrı ayrı console uygulamaları açarak yazınız. Koleksiyonlar-Soru-1, Koleksiyonlar-Soru-2, Koleksiyonlar-Soru-3 isimlerini kullanınız.

Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace ödev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru 1
            Console.WriteLine("***************Soru 1***************");
            Console.WriteLine("Enter 20 positive integers!");

            ArrayList asal = new ArrayList();
            ArrayList nasal = new ArrayList();
            ArrayList al = new ArrayList();

            int input;
            for(int i = 0;i < 20;i++){
                while(!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("That was invalid. Enter a positive integer.");
                }
                while(true){
                    if(input > 0)
                        break;
                    else{
                        Console.WriteLine("That was invalid. Enter a positive integer.");
                        input = int.Parse(Console.ReadLine());
                    }
                }
                al.Add(input);
                if(IsPrime(input))
                    asal.Add(input);
                else
                    nasal.Add(input);
                //Console.WriteLine("{0} number is {1}",i+1,input);
            }

            asal.Sort();
            nasal.Sort();
            al.Sort();
            asal.Reverse();
            nasal.Reverse();
            al.Reverse();

            Console.WriteLine("Sorted Prime Numbers: ");
            foreach (var item in asal)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sorted Not Prime Numbers: ");
            foreach (var item in nasal)
            {
                Console.WriteLine(item);
            }
            
            int asalsum = 0;
            int nasalsum = 0;

            foreach (int item in asal)
            {
                asalsum += item;
            }

            foreach (int item in nasal)
            {
                nasalsum += item;
            }

            Console.WriteLine("Asal Avg: {0} \nAsal Olmayan Sayılar Avg: {1}",asalsum,nasalsum);

            //Soru 2
            Console.WriteLine("***************Soru 2***************");
            Console.WriteLine("En büyük 3 eleman: ");
            Console.WriteLine("{0} {1} {2}",al[0],al[1],al[2]);

            Console.WriteLine("En küçük 3 eleman: ");
            Console.WriteLine("{0} {1} {2}",al[19],al[18],al[17]);

            Console.WriteLine("Sum of all averages: {0}",asalsum+nasalsum);

            Console.WriteLine("***************Soru 3***************");
            Console.WriteLine("Enter a sentence:");

            string str = Console.ReadLine();
            string s = "";

            foreach(char c in str){
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    s += c;
            }
            Console.WriteLine("All vowels in string: {0}",s);
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i+=2)
                if (number % i == 0)
                    return false;

            return true;        
        }
    }
}
