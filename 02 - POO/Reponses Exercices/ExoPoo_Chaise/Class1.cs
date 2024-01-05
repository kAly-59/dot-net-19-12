using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExoPoo_Chaise
{
    private int _nbPieds;
    private string _couleur;
    private string _materieux;

    private int NbPieds { get => _nbPieds; set => _nbPieds = value; }
    private string Couleur { get => _couleur; set => _couleur = value; }
    private string Materieux { get => _materieux; set => _materieux = value; }

    public ExoPoo_Chaise(int nbPieds, string couleur, string materieux)
    {
        NbPieds = nbPieds;
        Couleur = couleur;
        Materieux = materieux;
    }

    public override string ToString()
    {
        return $"La chaise a {NbPieds} pieds, sa couleur est {Couleur} et son matériau est {Materieux}.";
    }
}
