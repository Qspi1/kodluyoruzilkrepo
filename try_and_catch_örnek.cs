using System;

namespace try_and_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //error example code
            try
            {  
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number that you entered: "+ num);
            }
            catch(Exception ex){
                Console.WriteLine("Error: "+ex.Message.ToString());
            }
            /*
            finally
            {
                Console.WriteLine("Process done.");
            }
            */
            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("test");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Fromat exception");
                Console.WriteLine(ex);
            }
        }
    }
}
