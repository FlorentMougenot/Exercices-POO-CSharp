public class Personne
{
    private string _nom;
    private string _prenom;
    private int _age;
    public string Nom { get; }
    public string Prenom { get; }
    public int Age { get; }

    public Personne(string nom, string prenom, int age)
    {
        _nom = nom;
        _prenom = prenom;
        _age = age;
    }

    public override string ToString() => $"{_nom} {_prenom}, {_age} ans";
}
