namespace Lab_2Novembre__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int nombre = ObtenirEntierUtilisateur("Entrez un nombre entier (10 caractères maximum) : ");
                if (EstPair(nombre))
                {
                    Console.WriteLine($"Le nombre {nombre} est pair");
                }
                else
                {
                    Console.WriteLine($"Le nombre {nombre} n'est pas pair");
                }
            }
        }

        public static int ObtenirEntierUtilisateur(string message)
        {
            bool conversionReussie = false;
            int nombre = 0;
            while(conversionReussie != true)
            {
                string entreeUtilisateur = ObtenirStringUtilisateur(message);
                conversionReussie = int.TryParse(entreeUtilisateur, out nombre);
            }
            return nombre;
        }

        public static string ObtenirStringUtilisateur(string message)
        {
            Console.WriteLine("");
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static bool EstPair(int nombre)
        {
            return nombre % 2 == 0;
        }
    }
}