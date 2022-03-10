using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!
            //peab arvestama ka suurt tähte 'H'
            //char a = 'a'
            //luua kolm counterit ja pikad if ja else 
            //counteri ette kirjuta täht, millist soovid, siis kergem aru saada

            string HelloWo = "Hello World!".ToLower();

            // 'H'
            int hCounter = 0;

            for (int i = 0; i < HelloWo.Length; i++)
            {
                if (HelloWo[i] == 'h')
                {
                    hCounter++;
                }
            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses: Hello World! On 'h' tähti {hCounter} tükki.");
            }
            else
            {
                Console.WriteLine($"Lauses: Hello World! On 'h' tähti {hCounter} tükk.");
            }

            // 'O'
            int oCounter = 0;

            for (int i = 0; i < HelloWo.Length; i++)
            {
                if (HelloWo[i] == 'o')
                {
                    oCounter++;
                }
            }

            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses: Hello World! On 'o' tähti {oCounter} tükki.");
            }
            else
            {
                Console.WriteLine($"Lauses: Hello World! On 'o' tähti {oCounter} tükk.");
            }


            // 'L'
            int lCounter = 0;

            for (int i = 0; i < HelloWo.Length; i++)
            {
                if (HelloWo[i] == 'l')
                {
                    lCounter++;
                }
            }

            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses: Hello World! On 'l' tähti {lCounter} tükki.");
            }
            else
            {
                Console.WriteLine($"Lauses: Hello World! On 'l' tähti {lCounter} tükk.");
            }
        }
    }
}
