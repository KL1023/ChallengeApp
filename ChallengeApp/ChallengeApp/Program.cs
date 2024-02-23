int[] grades = new int[365];

List <string> daysOfWeek = new List<string>();
daysOfWeek.Add("Poniedziałek");
daysOfWeek.Add("Wtorek");
daysOfWeek.Add("Środa");
daysOfWeek.Add("Czwartek");
daysOfWeek.Add("Piątek");
daysOfWeek.Add("Sobota");
daysOfWeek.Add("Niedziela");
//Console.WriteLine(daysOfWeek[2]);

//string[] daysOfWeek2 = { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
//Console.WriteLine(daysOfWeek2[0]);

for(int i = 0; i<daysOfWeek.Count; i++)
{
    Console.WriteLine(daysOfWeek[i]);
}

foreach (var day in daysOfWeek)
{
    Console.WriteLine(day);
}
