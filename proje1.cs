using System;
using System.Collections.Generic;

// Project from --> https://app.patika.dev/courses/csharp-101/19-proje-1

namespace proje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //phonebook
            Dictionary<string,int> pb = new Dictionary<string, int>();
            //5 default variable will be added to dictionary
            pb.Add("John Smith",123456789);
            pb.Add("Dane Walls",987654321);
            pb.Add("Moses Koch",159732684);
            pb.Add("Victoria Morrison",357918426);
            pb.Add("Indiana Bourne",284619375);

            //Application happens below
            while(true){
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(0) Uygulamayı Kapatmak");
                int c = Convert.ToInt32(Console.ReadLine());

                if(c == 1){
                    Console.WriteLine("Lütfen isim giriniz: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Lütfen soyisim giriniz: ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Lütfen telefon numarası giriniz :");
                    int number = Convert.ToInt32(Console.ReadLine());
                    string fn = name+" "+surname; // name and surname will be stored at dictionary as single string
                    pb.Add(fn,number);
                }
                else if(c == 2){
                    Boolean flag = false;
                    while(true){
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        string str = Console.ReadLine();
                        foreach (var item in pb.Keys)
                        {
                            if(item.Contains(str)){
                                flag = true;
                                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",item);
                                string yn = Console.ReadLine();
                                if(yn == "y")
                                    pb.Remove(str);
                                break;
                            }
                        }
                        if(!flag){
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için      : (2)");
                            int cho = Convert.ToInt32(Console.ReadLine());
                            if(cho == 1)
                                break;
                            else
                                continue;
                        }
                    }
                }
                else if(c == 3){
                    Boolean flag = false;
                    while(true){
                        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                        string str = Console.ReadLine();
                        foreach (var item in pb.Keys)
                        {
                            if(item.Contains(str)){
                                flag = true;
                                Console.WriteLine("Yeni numarayı giriniz: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("{0} isimli kişinin numarası güncellenmek üzere, onaylıyor musunuz ?(y/n)",item);
                                string yn = Console.ReadLine();
                                if(yn == "y"){
                                    pb[item] = num;
                                }
                                break;
                            }
                        }
                        if(!flag){
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için      : (2)");
                            int cho = Convert.ToInt32(Console.ReadLine());
                            if(cho == 1)
                                break;
                            else
                                continue;
                        }
                    }
                }
                else if(c == 4){
                    Console.WriteLine("Telefon Rehberi");
                    Console.WriteLine("**********************************************");
                    foreach (var item in pb)
                    {
                        string[] words = item.Key.Split(' ');
                        string names = " ";
                        for(int i = 0;i < words.Length-1;i++){
                            names += words[i] + " "; //may have more than 1 name
                        }
                        Console.WriteLine("İsim: {0}",names);
                        Console.WriteLine("Soyisim: {0}",words[-1]);
                        Console.WriteLine("Telefon Numarası: {0}",item.Value);
                        Console.WriteLine("-");
                    }
                }
                else if(c == 5){
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine();
                    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                    Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                    int cho = Convert.ToInt32(Console.ReadLine());
                    if(cho == 1){
                        Console.WriteLine("Aradığınız kişinin ismini veya soyismini giriniz: ");
                        string str = Console.ReadLine();
                        foreach (var item in pb.Keys)
                        {
                            if(item.Contains(str)){
                                string[] words = item.Split(' ');
                                string names = " ";
                                for(int i = 0;i < words.Length-1;i++){
                                    names += words[i] + " "; //may have more than 1 name
                                }
                                Console.WriteLine("İsim: {0}",names);
                                Console.WriteLine("Soyisim: {0}",words[-1]);
                                Console.WriteLine("Telefon Numarası: {0}",pb[item]);
                                Console.WriteLine("-");
                            }
                        }
                    }
                    if(cho == 2){
                        Console.WriteLine("Aradığınız kişinin numarasını giriniz: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in pb.Keys)
                        {
                            if(pb[item] == num){
                                string[] words = item.Split(' ');
                                string names = " ";
                                for(int i = 0;i < words.Length-1;i++){
                                    names += words[i] + " "; //may have more than 1 name
                                }
                                Console.WriteLine("İsim: {0}",names);
                                Console.WriteLine("Soyisim: {0}",words[-1]);
                                Console.WriteLine("Telefon Numarası: {0}",pb[item]);
                                Console.WriteLine("-");
                            }
                        }
                    }
                }
                else if(c == 0){
                    Console.WriteLine("Exiting the application!");
                    break;
                }
                else{
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }

            }
        }
    }
}
