// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, All!");

int myAge = 120;
int newAge = myAge + 5;
Console.WriteLine(newAge);
//
//liczby całkowite
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
long myVar3 = long.MaxValue; 
ulong myVar4 = ulong.MaxValue;
//
//liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;
//
//stringi, zmienne tekstowe
string name = "Tomek";
string surname = "Gierasimiuk";
string result = name + surname + myAge;
Console.WriteLine(result);
//
//zmienne tekstowe char
char myVar5 = 't'; //tylko litera lub cyfra i inne średniki
//var result2 = name.Split;
var result3 = name.ToArray();
Console.WriteLine(result3);
//
//zmienne logiczne, prawda lub fałsz 
bool isActive = true;
isActive = false;
var isValid = 55 > 6;
Console.WriteLine(isValid);
//
//funkcja if i podstawy debugowania
var liczba1 = 10;
int liczba2 = 20;

if(liczba1 < liczba2)
{
    Console.WriteLine("liczba1 jest mniejsza od liczby2");
}
else
{
    Console.WriteLine("liczba1 nie jest mniejsza od liczby2");
}
//
//operatory relacyjne (<= == != =>) 
//operatory logiczne 
// i &&
// lub ||
// ! negacja

var name3 = "Tomek";
int age = 47;
if (name3 == "Tomek" && age >= 50)
{
    Console.WriteLine("jestem Tomkiem po 50.");
}
else if (age >= 40)
{
    Console.WriteLine("jestem po 40");
}
else 
{
    Console.WriteLine("jestem przed 40");
}
//zagniezdzony if lub else
//