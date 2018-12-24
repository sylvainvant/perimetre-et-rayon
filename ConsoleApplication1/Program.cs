using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration de variables
            string saissie;   //EnvironmentVariableTarget recevant la saissie de utilisateur
            double rayon;
            double perimetre;
            char reponse='O';
           

            while (Char.ToUpper(reponse) == 'O')
                {
                    // etape 1: lecture du rayon
                    Console.WriteLine("entrez la valeur du rayon:");
                    saissie = Console.ReadLine();
                    // etape 2: calcul et affichage du perimetre
                    rayon = Convert.ToDouble(saissie);
                    perimetre = 2 * Math.PI * rayon;
                    Console.WriteLine("Le cercle de rayon:" + rayon);
                    Console.WriteLine("a pour périmetre:" + perimetre);
                    //etape 3: demande de retour au debut 
                    Console.WriteLine("voulait vous faire un autre calcul O/N");
                    reponse = Convert.ToChar(Console.ReadLine());
                }
             
// permet de conserver affichage consol
//Console.ReadLine();
        }
    }
}
