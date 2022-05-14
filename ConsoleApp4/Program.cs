using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> listeDeMots = new List<string>();
            listeDeMots.Add("jaune");
            listeDeMots.Add("liste");
            listeDeMots.Add("mots");
            listeDeMots.Add("banane");

            foreach(string mot in listeDeMots)
            {
                Console.WriteLine(mot);
            }

            foreach(char chara in listeDeMots[0])
            {
                Console.WriteLine(chara);
                if(chara.Equals('j'))
                {
                    Console.WriteLine("Bravo tu es le meilleur");
                }
                else if (chara.Equals('a'))
                {
                    Console.WriteLine("Bravo tu es le meilleur deux fois");
                }
                else
                {
                    Console.WriteLine("Tu es un looser");
                }
            }

            string maChaineDeChara = null;
            Console.WriteLine("Ecrivez votre phrase : ");
            maChaineDeChara = Console.ReadLine();
            Console.WriteLine(maChaineDeChara);
        }
    }
}
