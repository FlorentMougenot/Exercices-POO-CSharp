using Exercice08LaPile.Classes;

class Program
{
    static void Main()
    {
        var pileDeStrings = new Pile<string>();
        var pileDeDecimals = new Pile<decimal>();
        var pileDePersonnes = new Pile<Personne>();
        
        bool continuer = true;
        while (continuer)
        {
            /*Console.Clear();*/
            AfficherMenu();

            string choix = Console.ReadLine();
            switch (choix)
            {
                case "1":

                    AfficherMenuChoix();
                    string choice1 = Console.ReadLine();
                    switch (choice1)
                    {
                        case "1":
                            Console.WriteLine("Entrez une valeur à empiler : ");
                            string valeur11 = Console.ReadLine();
                            pileDeStrings.Empiler(valeur11);
                            break;
                        case "2":
                            Console.WriteLine("Entrez une valeur à empiler : ");
                            decimal valeur12;
                            decimal.TryParse(Console.ReadLine(), out valeur12);
                            pileDeDecimals.Empiler(valeur12);
                            break;
                        case "3":
                            Console.WriteLine("Entrez le nom de la personne : ");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Entrez le prénom de la personne : ");
                            string firstname = Console.ReadLine();
                            Console.WriteLine("Entrez l'âge de la personne : ");
                            int ageuh;
                            int.TryParse(Console.ReadLine(), out ageuh);
                            Personne pX = new Personne(surname, firstname, ageuh);
                            pileDePersonnes.Empiler(pX);
                            break;
                        case "0":
                            continuer = false;
                            break;
                        default:
                            Console.WriteLine("Choix invalide.");
                            break;
                    }
                    break;
                case "2":
                    AfficherMenuChoix();
                    string choice2 = Console.ReadLine();
                    switch (choice2)
                    {
                        case "1":
                            try
                            {
                                Console.WriteLine($"Valeur dépilée : {pileDeStrings.Depiler()}");
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case "2":
                            try
                            {
                                Console.WriteLine($"Valeur dépilée : {pileDeDecimals.Depiler()}");
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case "3":
                            try
                            {
                                Console.WriteLine($"Valeur dépilée : {pileDePersonnes.Depiler()}");
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case "0":
                            continuer = false;
                            break;
                        default:
                            Console.WriteLine("Choix invalide.");
                            break;
                    }
                    break;
                case "3":
                    AfficherMenuChoix();
                    string choice3 = Console.ReadLine();
                    switch (choice3)
                    {
                        case "1":
                            Console.WriteLine("Entrez l'indice de l'élément à récupérer : ");
                            if (int.TryParse(Console.ReadLine(), out int index1))
                            {
                                try
                                {
                                    Console.WriteLine($"Valeur trouvée : {pileDeStrings.Recuperer(index1)}");
                                }
                                catch (ArgumentOutOfRangeException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Indice invalide !");
                            }
                            break;
                        case "2":
                            Console.WriteLine("Entrez l'indice de l'élément à récupérer : ");
                            if (int.TryParse(Console.ReadLine(), out int index2))
                            {
                                try
                                {
                                    Console.WriteLine($"Valeur trouvée : {pileDeDecimals.Recuperer(index2)}");
                                }
                                catch (ArgumentOutOfRangeException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Indice invalide !");
                            }
                            break;
                        case "3":
                            Console.WriteLine("Entrez l'indice de l'élément à récupérer : ");
                            if (int.TryParse(Console.ReadLine(), out int index3))
                            {
                                try
                                {
                                    Console.WriteLine($"Valeur trouvée : {pileDePersonnes.Recuperer(index3)}");
                                }
                                catch (ArgumentOutOfRangeException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Indice invalide !");
                            }
                            break;
                        case "0":
                            continuer = false;
                            break;
                        default:
                            Console.WriteLine("Choix invalide.");
                            break;
                    }
                    break;
                case "4":
                    AfficherMenuChoix();
                    string choice4 = Console.ReadLine();
                    switch (choice4)
                    {
                        case "1":
                            Console.WriteLine("--- Liste des éléments empilés ---");
                            for (int i = 0; i < pileDeStrings.Count; i++)
                            {
                                Console.WriteLine($"{i} - {pileDeStrings.Recuperer(i)}");
                            }
                            break;
                        case "2":
                            Console.WriteLine("--- Liste des éléments empilés ---");
                            for (int i = 0; i < pileDeDecimals.Count; i++)
                            {
                                Console.WriteLine($"{i} - {pileDeDecimals.Recuperer(i)}");
                            }
                            break;
                        case "3":
                            Console.WriteLine("--- Liste des éléments empilés ---");
                            for (int i = 0; i < pileDePersonnes.Count; i++)
                            {
                                Console.WriteLine($"{i} - {pileDePersonnes.Recuperer(i)}");
                            }
                            break;
                        case "0":
                            continuer = false;
                            break;
                        default:
                            Console.WriteLine("Choix invalide.");
                            break;
                    }
                    break;
                case "0":
                    continuer = false;
                    break;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }

            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }

    static void AfficherMenu()
    {
        Console.WriteLine("=== Menu Principal ===");
        Console.WriteLine("1. Empiler");
        Console.WriteLine("2. Dépiler");
        Console.WriteLine("3. Récupérer à x");
        Console.WriteLine("4. Liste des éléments empilés");
        Console.WriteLine("0. Quitter");
        Console.Write("Votre choix : ");
    }

    static void AfficherMenuChoix()
    {
        Console.WriteLine("=== Choix de la pile ===");
        Console.WriteLine("1. String");
        Console.WriteLine("2. Decimal");
        Console.WriteLine("3. Personne");
        Console.WriteLine("0. Quitter");
        Console.Write("Votre choix : ");
    }
}