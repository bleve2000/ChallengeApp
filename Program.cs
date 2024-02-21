// zadanie domowe dzień 4

// zmienne
var name = "Ewa";
var age = 25;
bool woman = true;

// warunki
if (woman == true && age < 30)
{ 
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (woman == true && name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (woman == false && name != "Ewa" && age < 18)
{
    Console.WriteLine("Niepełnoletni męzczyzna");
}