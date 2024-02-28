Console.WriteLine("---Gestion des Contacts---");
Console.Write("Saisir le nombre de contact ? ");
int nombreDeContacts = int.Parse(Console.ReadLine()!);
string[] contacts = new string[nombreDeContacts];
int index = 0;

for (int i = 0; i < contacts.Length; i++)
{
    Console.Write($"Saisir le contact {i + 1} : ");
    contacts[i] = Console.ReadLine()!;
}

Console.WriteLine();
Console.WriteLine("---Ma Liste de Contacts---");
Console.WriteLine("1) Saisir un contact");
Console.WriteLine("2) Afficher mes contact");
Console.WriteLine("3) Quitter");

bool continuer = true;

while (continuer)
{
    Console.Write("Choississez (1, 2 ou 3) : ");
    string choix = Console.ReadLine()!;

    switch (choix)
    {
        case "1":
            Console.Write("Saisir le nouveau contact : ");
            string nouveauContact = Console.ReadLine()!;

            if (index < nombreDeContacts)
            {
                contacts[index] = nouveauContact;
                index++;
                Console.WriteLine("Contact ajouté !");
            }
            else
            {
                Console.WriteLine("La liste de contacts est pleine !");
            }
            break;

        case "2":
            Console.WriteLine("---Liste de Contacts---");
            foreach (string contact in contacts)
            {
                Console.WriteLine(contact);
            }
            break;

        case "3":
            Console.WriteLine("Bababye");
            continuer = false;
            break;

        default:
            Console.WriteLine("1 2 ou 3 !!");
            break;
    }
}
