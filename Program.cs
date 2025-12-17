// Spør bruker om navn, inntil minst 3 bokstaver er skrevet inn
string name = string.Empty;
while(string.IsNullOrEmpty(name))
{
    Console.WriteLine("Skriv inn navet ditt");
    name = Console.ReadLine() ?? "";
    if(name.Length < 3)
    {
        name = "";
        Console.WriteLine("Your name is to short, get a new one!")
    }
}

// Spør bruker om fødselsdato
// Console.WriteLine("Skriv inn fødselsdato: YYYY-MM-DD");
// DateTime birthDate;
// string dateInput = string.Empty;
// while(string.IsNullOrEmpty(dateInput))
// {    
//     dateInput = Console.ReadLine()  ?? "";
//     bool success = DateTime.TryParse(dateInput,out birthDate);

//     //  Hvis fødselsdato ikke er formatert riktig, si ifra og spør på nytt
//     if(!success)
//     {
//         Console.WriteLine("Dato ble ikke skrevet inn riktig, bruk: YYYY-MM-DD");
//         dateInput = "";
//     }
// }

// Spør systemet om dagens dato og klokka
DateTime today = DateTime.Now;

// Få hilsen
string greetings = Greetings(today);

// Skriv ut melding med <hilsen> <navn>, det er <ukedag> og klokka er <hh:mm>.
Console.WriteLine($"{greetings} {name}, det er {(today.ToString("dddd"))}");

// Lag en dict med <ukedag,motiverende tekst>
Dictionary<DayOfWeek,string> motivation = new()
{
    [DayOfWeek.Monday] = "Kun fem dager igjen til helg.",
    [DayOfWeek.Tuesday] = "Kun fire dager igjen til helg.",
    [DayOfWeek.Wednesday] = "Kun tre dager igjen til helg.",
    [DayOfWeek.Thursday] = "Kun to dager igjen til helg.",
    [DayOfWeek.Friday] = "Bare idag igjen, så er det helg.",
    [DayOfWeek.Saturday] = "Nå er det helg.",
    [DayOfWeek.Sunday] = "Siste dag av helgen.",
};
// Skriv ut motiverende tekst.
Console.WriteLine(motivation[today.DayOfWeek]);

// Regn ut hvor mange dager brukeren har vært i live.
// Skriv ut en melding med antall dager.

// Lag hilsen basert på tidspunktet
static string Greetings(DateTime dateTime)
{
    int hour = dateTime.Hour;

    //  Hvis klokka er mellom 03-09 returner "God Morgen"
    if(hour >= 3  && hour < 9)
        return "God Morgen";

    //  Hvis klokka er mellom 09-12 returner "God formiddag"
    if(hour >= 9 && hour < 12)
        return "God formiddag";

    //  Hvis klokka er mellom 12-18 returner "God dag"
    if(hour >= 12 && hour < 18)
        return "God dag";

    //  Hvis klokka er mellom 18-23 returner "God kveld"
    if(hour >= 18 && hour < 23)
        return "God kveld";
    
    //  returner "God natt"
    return "God natt";
}

