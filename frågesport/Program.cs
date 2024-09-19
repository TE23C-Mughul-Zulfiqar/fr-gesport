 int points = 0;
Console.WriteLine("Det här är min frågesport!");
Console.WriteLine("Svara med a,b eller c");

Console.WriteLine("1: Hur många planeter finns det?");
Console.WriteLine("a) sju  b) åtta  c) sex");
string svar1 = Console.ReadLine();

while(svar1 != "a"&& svar1 != "b" && svar1 != "c")
{
    
    Console.Clear();
    Console.WriteLine("1: Hur många planeter finns det?");
    Console.WriteLine("a) sju  b) åtta  c) sex");
    svar1 = Console.ReadLine();
}

if (svar1 ==  "b")  
{
    points++;
    Console.WriteLine("Korrekt");
     Console.ReadLine();
}
else
{
    Console.WriteLine("Inkorrekt");
    Console.ReadLine();
}

Console.WriteLine("2: vilken är den största planeten?");
Console.WriteLine("a) mars b) saturnus c) jupiter?");
string svar2 = Console.ReadLine();
if (svar2 == "c")
{
    points++;
    Console.WriteLine("Korrekt");
     Console.ReadLine();
}
else
{
    Console.WriteLine("Inkorrekt");
    Console.ReadLine();
}

Console.WriteLine("3: Vilken är den sista planeten i solsystemet?");
Console.WriteLine("a) neptunus b) venus c) saturnus");
string svar3 = Console.ReadLine();
if (svar3 == "a")
{
    points++;
    Console.WriteLine("Korrekt");
     Console.ReadLine();
}
else
{
    Console.WriteLine("Inkorrekt");
    Console.ReadLine();
}

Console.WriteLine($"Du fick {points} poäng");
if (points == 0)
{
    Console.WriteLine("Du är sämst!");
}
else if (points < 3)
{
    Console.WriteLine("Okej du kan ju lite");
}
else
{
    Console.WriteLine("Du hade alla rätt! sjukt bra jobbat");
}

Console.WriteLine("Tryck på ENTER för att avsluta");
Console.ReadLine();
