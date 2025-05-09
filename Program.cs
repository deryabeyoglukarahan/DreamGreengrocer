Console.WriteLine("Rüya Manavı'na Hoşgeldiniz!");
Console.WriteLine("Elma: 2 TL");
Console.WriteLine("Armut: 3 TL");
Console.WriteLine("Çilek: 2 TL");
Console.WriteLine("Muz: 3 TL");
Console.WriteLine("Diğer bütün meyveler: 4 TL");
Console.WriteLine("--------------------------");
Console.Write("Hangi meyveyi satın almak istiyorsunuz? :");
string meyve = Console.ReadLine().ToLower(); // Küçük harfe çevirerek karşılaştırmayı kolaylaştırdık.
int fiyat;

/*if (meyve == "elma")
{
    fiyat = 2;
}
else if (meyve == "armut")
{
    fiyat = 3;
}
else if (meyve == "çilek")
{
    fiyat = 2;
}
else if (meyve == "muz")
{
    fiyat = 3;
}
else
{
    fiyat = 4;
}*/

switch (meyve)
{
    case "elma":
        fiyat = 2;
        break;
    case "armut":
        fiyat = 3;
        break;
    case "çilek":
        fiyat = 2;
        break;
    case "muz":
        fiyat = 3;
        break;
    default:
        fiyat = 4;
        break;
}

Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {fiyat} TL");

// Farklı seçeneklerin sabit değerlerle karşılaştırılması söz konusu olduğuy için switch-case bu tür durumlarda daha okunabilir ve düzenli bir yapı sunar.
// Bu tür bir problemi çözmek için switch-case yapısı tercih edilebilir.