/*using ExerciceHotel.Classes;

class Program
{
    static void Main()
    {
        *//*var ListingChambres = new Pile<string>();*//*
        var ListingReservations = new Reservation<string>();
        var ListingClients = new Reservation<Client>();

        bool continuer = true;
        while (continuer)
        {
            *//*Console.Clear();*//*
            AfficherMenu();

            string choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    Console.WriteLine("Entrez le nom de la personne : ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Entrez le prénom de la personne : ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Entrez le numéro de téléphone de la personne : ");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Client ajouté avec succès !");
                    Client(nouveauClient) = new Client(surname, firstname, phone);
                    ListingClients.AfficherReservations(nouveauClient);
                    break;
                case "2":
                    Console.WriteLine("--- Liste des Clients enregistrés ---");
                    for (int i = 0; i < ListingClients.Count; i++)
                    {
                        Console.WriteLine($"{i} - {ListingClients.AfficherReservations(i)}");
                    }
                    break;
                case "3":

                case "4":
                    string ajoutresa = Console.ReadLine();
                    ListingReservations.AjouterReservation(ajoutresa);
                    break;
                case "5":
                    try
                    {
                        Console.WriteLine($"Réservation supprimée : {ListingReservations.SupprimerReservation()}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "6":
                    Console.WriteLine("--- Liste des éléments empilés ---");
                    for (int i = 0; i < ListingReservations.Count; i++)
                    {
                        Console.WriteLine($"{i} - {ListingReservations.AfficherReservations(i)}");
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
        Console.WriteLine("1. Ajouter un client");
        Console.WriteLine("2. Afficher la liste des clients");
        Console.WriteLine("3. Afficher les réservations d'un client");
        Console.WriteLine("4. Ajouter une réservation");
        Console.WriteLine("5. Annuler une réservation");
        Console.WriteLine("6. Afficher la liste des réservations");
        Console.WriteLine("0. Quitter");
        Console.Write("Votre choix : ");
    }
}*/


using System;

class Program
{
    static void Main()
    {
        var ListingReservations = new Reservation<string>();
        var ListingClients = new Reservation<Client>();

        bool continuer = true;
        while (continuer)
        {
            AfficherMenu();

            string choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    Console.WriteLine("Entrez le nom de la personne : ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Entrez le prénom de la personne : ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Entrez le numéro de téléphone de la personne : ");
                    string phone = Console.ReadLine();
                    Client nouveauClient = new Client(surname, firstname, phone);
                    ListingClients.AjouterReservation(nouveauClient);
                    Console.WriteLine("Client ajouté avec succès !");
                    break;
                case "2":
                    Console.WriteLine("--- Liste des Clients enregistrés ---");
                    for (int i = 0; i < ListingClients.Count; i++)
                    {
                        Console.WriteLine($"{i} - {ListingClients.AfficherReservations(i)}");
                    }
                    break;
                case "3":
                    // Ajoutez votre logique pour afficher les réservations d'un client ici
                    break;
                case "4":
                    Console.WriteLine("Entrez le numéro de réservation : ");
                    string ajoutResa = Console.ReadLine();
                    ListingReservations.AjouterReservation(ajoutResa);
                    Console.WriteLine("Réservation ajoutée avec succès !");
                    break;
                case "5":
                    try
                    {
                        Console.WriteLine($"Réservation supprimée : {ListingReservations.SupprimerReservation()}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "6":
                    Console.WriteLine("--- Liste des réservations ---");
                    for (int i = 0; i < ListingReservations.Count; i++)
                    {
                        Console.WriteLine($"{i} - {ListingReservations.AfficherReservations(i)}");
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
        Console.WriteLine("1. Ajouter un client");
        Console.WriteLine("2. Afficher la liste des clients");
        Console.WriteLine("3. Afficher les réservations d'un client");
        Console.WriteLine("4. Ajouter une réservation");
        Console.WriteLine("5. Annuler une réservation");
        Console.WriteLine("6. Afficher la liste des réservations");
        Console.WriteLine("0. Quitter");
        Console.Write("Votre choix : ");
    }
}

class Client
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string NumeroTelephone { get; set; }

    public Client(string nom, string prenom, string numeroTelephone)
    {
        Nom = nom;
        Prenom = prenom;
        NumeroTelephone = numeroTelephone;
    }

    public override string ToString()
    {
        return $"{Nom} {Prenom} - Téléphone : {NumeroTelephone}";
    }
}

class Reservation<T>
{
    private readonly List<T> listeReservations = new List<T>();

    public int Count => listeReservations.Count;

    public void AjouterReservation(T reservation)
    {
        listeReservations.Add(reservation);
    }

    public string AfficherReservations(int index)
    {
        if (index >= 0 && index < listeReservations.Count)
        {
            return listeReservations[index].ToString();
        }
        return "Index hors limites.";
    }

    public string SupprimerReservation()
    {
        if (listeReservations.Count > 0)
        {
            T reservation = listeReservations[listeReservations.Count - 1];
            listeReservations.RemoveAt(listeReservations.Count - 1);
            return reservation.ToString();
        }
        throw new InvalidOperationException("Aucune réservation à annuler.");
    }
}