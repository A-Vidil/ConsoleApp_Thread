using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp_Thread_Foray
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex batonDeParole = new Mutex();
            int compteur = 100;
                 for (int i = 0; i < compteur; i++)
            {
                Work work = new Work();
                work.InstanceNumber1 = i;
                work.baton = batonDeParole;
                Thread thread = new Thread(work.run);
                thread.Start();
            }
        }
    }
}
