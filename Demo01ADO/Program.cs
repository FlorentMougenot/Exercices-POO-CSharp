/*using (SqlConnection conn = new SqlConnection(connectionString))
{
    string request = "INSERT INTO personne (prenom, nom, email) VALUES (@prenom, @nom, @email)";
    SqlCommand command = new SqlCommand(request, conn);

    command.Parameters.AddWithValue("@prenom", "Lea");
    command.Parameters.AddWithValue("@nom", "Dupont");
    command.Parameters.AddWithValue("@email", "Lea.dupont@coincoin.com");

    try
    {
        conn.Open();
        int rowsAffected = command.ExecuteNonQuery();
        Console.WriteLine($"{rowsAffected} lignes affectées");
    } catch (Exception e) 
    {
        Console.WriteLine(e.Message);
    }
}*/
