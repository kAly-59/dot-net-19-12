// Classe générique représentant une pile
internal class Pile<T>
{
    private T[] elements; // Tableau pour stocker les éléments de la pile

    // Constructeur
    public Pile()
    {
        elements = new T[0]; // Initialise le tableau à une taille de 0
    }

    // Méthode pour empiler un nouvel élément
    public void Empiler(T input)
    {
        // Redimensionne le tableau et ajoute le nouvel élément au sommet de la pile
        Array.Resize(ref elements, elements.Length + 1);
        elements[elements.Length - 1] = input;
    }

    // Méthode pour dépiler le dernier élément
    public T Depiler()
    {
        if (elements.Length == 0)
        {
            throw new InvalidOperationException("La pile est vide.");
        }

        T dernierElement = elements[elements.Length - 1]; // Récupère le dernier élément
        Array.Resize(ref elements, elements.Length - 1); // Redimensionne le tableau pour retirer le dernier élément
        return dernierElement;
    }

    // Méthode pour récupérer un élément par son index et le retirer de la pile
    public T RecupererParIndex(int index)
    {
        if (index < 0 || index >= elements.Length)
        {
            throw new IndexOutOfRangeException("Index invalide.");
        }

        T element = elements[index]; // Récupère l'élément à l'index spécifié

        // Redimensionne le tableau pour retirer l'élément à l'index spécifié
        T[] nouvellePile = new T[elements.Length - 1];
        Array.Copy(elements, nouvellePile, index);
        Array.Copy(elements, index + 1, nouvellePile, index, elements.Length - index - 1);
        elements = nouvellePile;

        return element;
    }
}
