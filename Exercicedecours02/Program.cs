using Exercicedecours02;

List<Salarie> listeSalaries = new List<Salarie>()
{ new Salarie("00001", "directrice marketing", 3, "Chloé", 24000), new Salarie("00002", "drh", 2, "Emma", 30000), new Salarie( "00003", "directeur technique", 2, "Georges", 26000), new Salarie() };

foreach (Salarie SalaireNom in listeSalaries)
{
    SalaireNom.AfficherSalaire();
}
Salarie.AffichernbSalaries();
Salarie.AfficherTotalSalaires();
listeSalaries[0].ChangementSalaires(listeSalaries[0].Nom, 500000);
Salarie.AfficherTotalSalaires();