void Zbol()
{
    // Demande l'age a un habitant de zbol et lui redonne son age : 
    // Jusqu'à 40 zbol,  1 zbol = 5 ans
    // De 41 à 80 zbol, 1 zbol = 3 ans
    // Plus de 81 zbol, 1 zbol = 1 an

    Console.WriteLine("Quel est votre age en zbol ?");
    int zbol = SaisieZbol();
    Console.WriteLine($"L'age en Zbole : {zbol}");


}


int SaisieZbol()
{
    int age;
    while (true)
    {
        Console.Write("Entrez votre age en zbol : ");
        if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
        {
            return age;
        }
        else
        {
            throw new ArgumentOutOfRangeException("L'age doit être un nombre entier positif.");
        }
    }


}

// Main Program


Zbol();