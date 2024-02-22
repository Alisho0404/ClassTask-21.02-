var actor1 = new Actor("Jason Statham", 48, "Male");

Console.WriteLine("Actor's Name: " + actor1.GetName());
Console.WriteLine("Age: " + actor1.GetAge());
Console.WriteLine("Gender: " + actor1.GetGender());
Console.WriteLine($"Movies Played by: {actor1.GetName()}");

actor1.AddMovie("Mechanik");
actor1.AddMovie("Pchelovod");
actor1.AddMovie("Perevozchik");

for (int i = 1; i <= actor1.GetMoviesPlayed().Count; i++)
{
    Console.WriteLine($"{i}. {actor1.GetMoviesPlayed()[i-1]}");
}