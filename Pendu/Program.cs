using Exercicedecours04.Classes;


Pendu lePendu = new();
while (lePendu.TestWin()==0)
{
    Console.WriteLine($"Lettres testées : [{string.Join(", ", lePendu.LettresTestees)}]");
    Console.WriteLine($"Tentatives : ({lePendu.NbTentatives}/{lePendu.NbVies})");
    Console.WriteLine($"Mot à trouver: {lePendu.Masque}");
    Console.WriteLine("\nVeuillez entrer une lettre : ");
    char lettre = Console.ReadLine()[0];
    lePendu.TestChar(lettre);
}
if (lePendu.TestWin() == 1) Console.WriteLine("Bravo, vous avez trouvé le mot !");
else Console.WriteLine("Dommage, le mot à trouver était " + lePendu.MotATrouver);











/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenue dans le jeu du Pendu!");

        string motSecret = ChoisirMotSecret();
        char[] motActuel = InitialiserMotActuel(motSecret);

        int essaisRestants = 6;

        while (essaisRestants > 0 && !MotDecouvert(motActuel))
        {
            AfficherMotActuel(motActuel);
            Console.WriteLine($"Essais restants : {essaisRestants}");

            char lettre = DemanderLettre();

            if (LettreDejaUtilisee(lettre, motActuel))
            {
                Console.WriteLine("Vous avez déjà utilisé cette lettre. Veuillez choisir une autre lettre.");
                continue;
            }

            if (LettrePresente(lettre, motSecret))
            {
                MiseAJourMotActuel(lettre, motSecret, motActuel);
                Console.WriteLine("Bonne devinette!");
            }
            else
            {
                essaisRestants--;
                Console.WriteLine("Mauvaise devinette! Perdu un essai.");
            }
        }

        if (MotDecouvert(motActuel))
        {
            Console.WriteLine("Félicitations! Vous avez deviné le mot : " + motSecret);
        }
        else
        {
            Console.WriteLine("Dommage! Le mot secret était : " + motSecret);
        }
    }

    static string ChoisirMotSecret()
    {
        string[] mots = { "programmation", "informatique", "pendu", "developpement", "csharp", "algorithme" };
        Random random = new Random();
        return mots[random.Next(0, mots.Length)];
    }

    static char[] InitialiserMotActuel(string motSecret)
    {
        return new char[motSecret.Length];
    }

    static void AfficherMotActuel(char[] motActuel)
    {
        Console.WriteLine("Mot actuel : " + new string(motActuel));
    }

    static bool MotDecouvert(char[] motActuel)
    {
        return !new string(motActuel).Contains('_');
    }

    static char DemanderLettre()
    {
        Console.Write("Devinez une lettre : ");
        return Console.ReadLine().ToLower()[0];
    }

    static bool LettreDejaUtilisee(char lettre, char[] motActuel)
    {
        return new string(motActuel).Contains(lettre);
    }

    static bool LettrePresente(char lettre, string motSecret)
    {
        return motSecret.Contains(lettre);
    }

    static void MiseAJourMotActuel(char lettre, string motSecret, char[] motActuel)
    {
        for (int i = 0; i < motSecret.Length; i++)
        {
            if (motSecret[i] == lettre)
            {
                motActuel[i] = lettre;
            }
        }
    }
}*/