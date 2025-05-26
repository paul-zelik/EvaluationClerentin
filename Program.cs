void Zbol()
{
    // Demande l'age a un habitant de zbol et lui redonne son age : 
    // Jusqu'à 40 zbol,  1 zbol = 5 ans
    // De 41 à 80 zbol, 1 zbol = 3 ans
    // Plus de 81 zbol, 1 zbol = 1 an

    Console.WriteLine("Quel est votre age en zbol ?");
    int zbol = SaisieZbol();
    int ageTerrestre = ZbolVersAge(zbol);
    Console.WriteLine($"Votre age terrestre convertit depusi votre age Zbol : {ageTerrestre}");


}


int ZbolVersAge(int zbol)
{

    // Fonction servant à convertir l'age en zbol en age terrestre.
    if (zbol <= 40)
    {
        return zbol * 5;
    }
    else if (zbol <= 80)
    {
        return 40 * 5 + (zbol - 40) * 3;
    }
    else
    {
        return CalculeZbol(zbol);
    }
}

int CalculeZbol(int zbol)
{
    // Fonction servant à calculer l'age terrestre à partir de l'age zbol pour les zbols supérieurs à 80.
    return 40 * 5 + 40 * 3 + (zbol - 80);
}

int SaisieZbol()
{
    // Fonction servant à saisir l'age en zbol, avec gestion des erreurs de saisie.
    int age;

    Console.Write("Entrez votre age en zbol : ");
    try
    {
        if (int.TryParse(Console.ReadLine(), out age) && age >= 0) // Saisie de l'age
        {
            return age; // Renvoie de l'age
        }
        else
        {
            throw new ArgumentOutOfRangeException("L'age doit être un nombre entier positif."); // Erreur si nombre négatif
        }

    }
    catch (ArgumentException e)
    {
        //Si l'utilisateur fai une rreur de saisie  on affiche un message, et on saisie le nombre à 0.
        Console.WriteLine($"Erreur de saisie : {e.Message}. Votre age est donc définit à 0.");
        return 0; // Renvoie Automatique de l'age  = 0
    }
}

// Main Program
Console.WriteLine("Bienvenue dans le convertisseur d'age Zbol !");

Zbol();