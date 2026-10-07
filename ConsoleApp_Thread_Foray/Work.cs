using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Thread_Foray
{

    public class Work
    {
        public Mutex baton;
        private int InstanceNumber;

        public int InstanceNumber1 { get => InstanceNumber; set => InstanceNumber = value; }

        public void run()
        {
            Random alea = new Random();
            int a = alea.Next() % 16;
            int i = 0;

            while ((i == a) && (i >= 16))
            {
                i = alea.Next() % 16;
            }
            int compteur = 1000;
            for (int z = 0; i < compteur; z++)
            {
                baton.WaitOne();
                Console.BackgroundColor =(ConsoleColor) (a);
                Console.ForegroundColor =(ConsoleColor) (i);
                Console.WriteLine("Objet: " + InstanceNumber1 + " | Compteur: " + z);
                baton.ReleaseMutex();
            }
        }
    }

}
