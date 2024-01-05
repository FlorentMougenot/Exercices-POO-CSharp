using Watertank00;

List<Watertank> listeCiternes = new List<Watertank>()
{ new Watertank(2, 20, 10), new Watertank(5,40,10), new Watertank(15, 100, 20) };

for (int i = 0; i < listeCiternes.Count; i++)
{
    listeCiternes[i].AfficherPoidsRempli(i);
}
Watertank.AfficherCadre();
for (int j = 0; j < listeCiternes.Count; j++)
{
    listeCiternes[j].AfficherQuantiteEau(j);
}
Watertank.AfficherCadre();