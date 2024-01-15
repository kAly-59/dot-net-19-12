// Classe représentant une personne avec nom, prénom et âge
public class Personne
{
    public string _nom { get; set; }
    public string _prenom { get; set; }
    public int _age { get; set; }

    // Constructeur
    public Personne(string nom, string prenom, int age)
    {
        _nom = nom;
        _prenom = prenom;
        _age = age;
    }

    // Méthode pour afficher les informations d'une personne
    public override string ToString()
    {
        return $"{_prenom} {_nom}, {_age} ans";
    }
}
