using System;
using System.Threading;

namespace NewUdemy_StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dongu = true;
            while (dongu)
            {
                Console.WriteLine("Başlamak için 'e' tuşana basınız çıkmak için farklı bir tuşa basınız   ");
                string answer = Console.ReadLine().ToLower();
                TimeSpan interval = new TimeSpan(0, 0, 0);
                if (answer == "e")
                {
                    var sw = new StopWatch();
                    var Start = sw.start();
                    for (int i = 0; i < 1500; i++)
                    {
                        Console.WriteLine(TimeSpan.FromSeconds(i + 1));
                        Thread.Sleep(1000);
                        devam:
                        if (Console.KeyAvailable)
                        {
                            interval += sw.stop();
                            Console.WriteLine(interval);

                            Console.ReadKey();
                            Console.WriteLine("Devam Etmek istermisniz Evet=e  tekrar başlamak için farklı bir tuşa basınız ");
                            string answer2 = Console.ReadLine();
                            if (answer2 == "e")
                            {
                                Start = sw.start();
                                goto devam;
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                }
                else
                { dongu = false; }
                   
            }
        }
    }
}
