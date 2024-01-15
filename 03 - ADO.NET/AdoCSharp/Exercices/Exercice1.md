# Exercice 1 - ADO.NET

- R�alisez une application C# qui demande � l'utilisateur de saisir:
    - Nom
    - Pr�nom
    - Num�ro de classe
    - Date de dipl�me

L'application ajoutera les donn�es dans une table �tudiant

- On souhaite modifier notre application pour ajouter des fonctionnalit�s :
    - Afficher la totalit� des �tudiants
    - Afficher les �tudiants d'une classe
    - Supprimer un �tudiant
    - (optionnel) Mettre � jour un �tudiant � partir d'un objet �tudiant 

- Une fois fini, modifier l'application en ajoutant ces m�thodes � la classe Etudiant 
    - `bool Save()`
    - `bool Delete()`
    - `static Etudiant GetById(int id)`
    - `static List<Etudiant>GetEtudiants(int? numeroClasse = null)`
    - (optionnel) `static EtudiantEditEtudiant(int id, Etudiant)`