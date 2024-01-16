using System.Data;
using System.Data.SqlClient;

string connectionString = "Server=localhost;Database=contactDB;User Id=SA;Password=Kanard777;";

/*using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    if (connection.State == ConnectionState.Open)
    {
        Console.WriteLine("La connexion est ouverte!");
    }
    else
    {
        Console.WriteLine("La connexion n'est pas ouverte :(");
    }

    //Créer un étudiant dans la bdd
    Console.Write("Veuillez entrer le prénom : ");
    string prenom = Console.ReadLine() ?? "";
    Console.Write("Veuillez entrer le nom : ");
    string nom = Console.ReadLine() ?? "";
    Console.Write("Veuillez entrer la classe : ");
    string classe = Console.ReadLine() ?? "";
    Console.Write("Veuillez entrer le dernier diplome : ");
    string diplome = Console.ReadLine() ?? "";
    string req = $"INSERT INTO etudiant (prenom, nom, classe, diplome) VALUES ('{prenom}', '{nom}', '{classe}', '{diplome}')";
    SqlCommand command = new SqlCommand(req, connection);
    int rowsAffected = command.ExecuteNonQuery();
    Console.WriteLine(rowsAffected);
    command.Dispose();
    connection.Close();
}*/


//Lire des enregistrements
using (SqlConnection conn = new SqlConnection(connectionString))
{
    conn.Open();
    string reg = "SELECT * FROM etudiant;";
    SqlCommand newcommand = new SqlCommand(reg, conn);
    try
    {
        SqlDataReader reader = newcommand.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"id: {reader.GetInt32(0)}, prenom: {reader.GetString(1)}, nom: {reader.GetString(2)}, classe: {reader.GetString(3)}, diplome: {reader.GetString(4)}");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}


using (SqlConnection conn = new SqlConnection(connectionString))
{
    Console.Write("Veuillez entrer la classe à interroger : ");
    string classe = Console.ReadLine() ?? "";
    string reg = "SELECT * FROM etudiant WHERE classe=@classe;";
    SqlCommand newcommand = new SqlCommand(reg, conn);
    newcommand.Parameters.AddWithValue("@classe", classe);
    try
    {
        conn.Open();
        SqlDataReader reader = newcommand.ExecuteReader();
        if (reader.Read())
        {
            Console.WriteLine($"id: {reader.GetInt32(0)}, prenom: {reader.GetString(1)}, nom: {reader.GetString(2)}, classe: {reader.GetString(3)}, diplome: {reader.GetString(4)}");
        }
        else
        {
            Console.WriteLine($"Aucune personne trouvée avec la classe {classe}");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}


using (SqlConnection conn = new SqlConnection(connectionString))
{
    Console.WriteLine("Entrez l'ID de l'étudiant à supprimer : ");
    int id;
    while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
        Console.WriteLine("Saisie invalide ! Rééssayez :");
    string reg = "DELETE FROM etudiant WHERE id=@id;";
    SqlCommand newcommand = new SqlCommand(reg, conn);
    newcommand.Parameters.AddWithValue("@id", id);
    try
    {
        conn.Open();
        SqlDataReader reader = newcommand.ExecuteReader();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}


using (SqlConnection conn = new SqlConnection(connectionString))
{
    Console.WriteLine("Entrez l'ID de l'étudiant à mettre à jour : ");
    int id;
    while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
        Console.WriteLine("Saisie invalide ! Rééssayez :");
    Console.Write("Veuillez entrer le prénom : ");
    string prenom = Console.ReadLine() ?? "";
    Console.Write("Veuillez entrer le nom : ");
    string nom = Console.ReadLine() ?? "";
    Console.Write("Veuillez entrer la classe : ");
    string classe = Console.ReadLine() ?? "";
    Console.Write("Veuillez entrer le dernier diplome : ");
    string diplome = Console.ReadLine() ?? "";
    string req = $"UPDATE etudiant SET prenom = {prenom}, nom = {nom}, classe = {classe}, diplome = {diplome} WHERE id=@id;";
    SqlCommand newcommand = new SqlCommand(req, conn);
    newcommand.Parameters.AddWithValue("@id", id);
    try
    {
        conn.Open();
        SqlDataReader reader = newcommand.ExecuteReader();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}