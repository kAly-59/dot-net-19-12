Console.Write("Veuillez saisir votre nom : ");
string nameInput = Console.ReadLine();

Console.Write("Veuillez saisir votre prénom : ");
string prenomInput = Console.ReadLine();

Console.Write("Veuillez saisir votre âge : ");
int ageInput = int.Parse(Console.ReadLine());

Console.WriteLine("Bonjour " + nameInput + " " + prenomInput + ", vous avez " + ageInput + " ans.");