using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TutoringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Any time we use StreamWriter or StreamReader, there are three steps
            //1. Open Stream
            //2. Read or Write
            //3. Close Stream
            StreamWriter funkyChicken = new StreamWriter("yodelingChicken.txt");
            using (funkyChicken)
            {
                funkyChicken.WriteLine("These are the lyrics to Funky Chicken.");
                for (int i = 0; i < 20; i++)
                {
                    funkyChicken.WriteLine("Let me see your Funky Chicken!");
                    funkyChicken.WriteLine("What's that you say?");
                }
                funkyChicken.WriteLine("And then it just repeats.");
            }
            //funkyChicken.Close();

            StreamReader tutoring = new StreamReader("yodelingChicken.txt");
            string hello = tutoring.ReadToEnd();
            
            using (tutoring)
            {
                
                Console.WriteLine(hello);
            }
        }
    }
}
