string name = "Ewa";
int age = 15;
string sex = "M";

if (name == "Ewa" && age == 33 && sex == "K")
{
    Console.WriteLine(name + ", lat " + age);
}
else if (sex == "K" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex == "M" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna. (Czy " + name + " to imię męskie?)");
}
else if (sex != "M" && sex != "K")
{
    Console.WriteLine(name + ", proszę określ swoją płeć przez wpisanie do zmiennej płeć (ang. sex) M - dla mężczyzny i K - dla kobiety.");
}
else
// nie wiedziałem ze VS mi dopisze (true) jako wartość i tym sposobem (przypadkiem) zalatwiłem sobie ostatni ogólny warunek
{
    Console.WriteLine("Wymagana większa liczba warunków weryfikacji danych");
}