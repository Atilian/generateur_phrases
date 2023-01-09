


namespace generateur_phrases
{


    class Program
    {


        static void Main(string[] args)
        {
            AfficherPhrase();
        }

        static string ObtenirElementAleatoire(string[] tableau)
        {
            var random = new Random();

            return tableau[random.Next(tableau.Length)];
        }

        static string ObtenirPhrase()
        {
            var sujets = new string[] {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fee",
                "Un magicien",
                "Une tortue",
            };

            var verbes = new string[] {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "avale",
                "néttoie",
                "se bat avec",
                "s'accroche à",
            };

            var complements = new string[] {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud",
            };

            return ((ObtenirElementAleatoire(sujets) + " " + ObtenirElementAleatoire(verbes) + " " + ObtenirElementAleatoire(complements)));
        }

        static void AfficherPhrase()
        {
            const int NB_PHRASES = 100;

            List<string> list_phrases = new List<string>();
            var doublon = 0;

            while (list_phrases.Count < NB_PHRASES)
            {
                var phrase = ObtenirPhrase();

                if(!list_phrases.Contains(phrase))
                {
                    list_phrases.Add(phrase);
                    Console.WriteLine(ObtenirPhrase());
                }
                else
                {
                    doublon++;
                }
            }

            Console.WriteLine(doublon);
        }

    }
}