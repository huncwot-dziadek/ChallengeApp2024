var name = "Zenek";
var sex = 'M';
var age = 17;

if (age < 30)
{
    if (sex == 'F')
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}
else if (age == 30 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 30");
}



