namespace Ovningar20220901.SubFunctions;

public class Person
{
    private string _firstName = null!;
    private string _lastName = null!;
    public override string ToString()
    {
        return $"Förnamn: {_firstName}.\nEfternamn: {_lastName}.\nAdress: {Street}.\nLän: {County}.\nTelefonnummer: {PhoneNumber}";
    }

    public string Name()
    {
        return $"{FirstName} {LastName}";
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            _lastName = value;
        }
    }

    public string PhoneNumber { get; set; }
    public string County { get; set; }
    public string Street { get; set; }

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            _firstName = value;
        }
    }

    public Person()
    {
        FirstName = "N/A";
        LastName = "N/A";
        PhoneNumber = "N/A";
        County = "N/A";
        Street = "N/A";
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = "N/A";
        County = "N/A";
        Street = "N/A";
    }

    public Person(string firstName, string lastName, string phoneNumber, string county, string street)
    {
        _firstName = firstName;
        _lastName = lastName;
        PhoneNumber = phoneNumber;
        County = county;
        Street = street;
    }

    public static Dictionary<string, Person> TemplatesPersons()
    {

        var personer = new Dictionary<string, Person>();
        personer.Add("195410204324",
            new Person("Karl-Bertil", "Johansson", "0720000000",
                "Västra Götaland", "Uppgörelsegatan 58B"));
        personer.Add("200009294324",
            new Person("Karl", "Bertilsson", "0750000000",
                "Småland", "Göteborgsgatan 3"));
        personer.Add("193510203333",
            new Person("Maj-Britt", "Johannasdotter", "0790000000",
                "Norrbotten", "Sapmivägen 19"));
        personer.Add("199403243333",
            new Person("Linnéa", "Brott", "0700000000",
                "Östergötland", "Polisvägen 19"));
        personer.Add("194906081984",
            new Person("George", "Orwell", "0760000000",
                "Skåne", "Diktaturstigen 3"));
        return personer;
    }

    public static void SearchPerson(ref Dictionary<string, Person> personer)
    {
        Console.WriteLine("Skriv in personnumret på personen du letar efter:");
        var userInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(userInput))
        {
            foreach (var person in personer)
            {
                if (userInput == person.Key)
                {
                    Console.WriteLine($"\n{person.Value}\n");
                }
            }
        }
    }

    public static void AddPerson(ref Dictionary<string, Person> personer)
    {
        var person = new Person();
        var personNummer = string.Empty;
        while (true)
        {
            Console.WriteLine("Skriv in personnummer på personen. 12 siffror:");
            personNummer = Console.ReadLine();
            if (string.IsNullOrEmpty(personNummer))
            {
                Console.WriteLine("Ett fel uppstod, försök igen!");
            }
            else if (personNummer.Length <= 10)
            {
                Console.WriteLine("Tolv siffror, om det sista fyra är okända - skriv 0000");
            }
            if (!string.IsNullOrEmpty(personNummer))
            {
                if (personNummer.Length == 12 && personNummer[..2] is "19" or "20")
                {
                    break;
                }
                else if (personNummer[..2] is not "19" or "20")
                {
                    Console.WriteLine("Personnummret måste börja på 19 eller 20");
                }
            }
        }

        Console.WriteLine("Skriv in förnamnet på personen:");
        person.FirstName = Console.ReadLine() ?? string.Empty;
        if (person.FirstName.Contains(' '))
        {
            Console.WriteLine("Förnamnet innehåller ett mellanslag, är detta med mening? (Y/N)");
            var userInput = Console.ReadLine();
            if (userInput != null && userInput.ToLower()[0] == 'n')
            {
                var personSplit = person.FirstName.Split(" ");
                person.FirstName = personSplit[0];
                person.LastName = personSplit[1];
            }
        }
        if (person.LastName == "N/A")
        {
            Console.WriteLine("Skriv in efternamnet på personen:");
            person.LastName = Console.ReadLine() ?? "N/A";
        }
        Console.WriteLine("Skriv in personens telefonnummer:\nOm personen inte har telefon, lämna blankt.");
        person.PhoneNumber = Console.ReadLine() ?? "N/A";
        if (string.IsNullOrEmpty(person.PhoneNumber))
        {
            person.PhoneNumber = "N/A";
        }
        else
        {
            person.PhoneNumber = person.PhoneNumber.Replace(" ", string.Empty);
            person.PhoneNumber = person.PhoneNumber.Replace("-", string.Empty);
        }
        Console.WriteLine("Skriv in personens adress:");
        person.Street = Console.ReadLine() ?? "N/A";
        if (person.Street.Contains(','))
        {
            Console.WriteLine("Adressen innehåller ett kommatecken, är detta med mening? (Y/N)");
            var userInput = Console.ReadLine();
            if (userInput != null && userInput.ToLower()[0] == 'n')
            {
                var personSplit = person.Street.Split(",");
                person.Street = personSplit[0];
                person.County = personSplit[1];
            }
        }
        if (person.County == "N/A")
        {
            Console.WriteLine("Skriv vilket län som personen bor i:");
            person.County = Console.ReadLine() ?? "N/A";
        }
        personer.Add(personNummer, person);
    }
}