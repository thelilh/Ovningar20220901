using System;
using System.Linq;
using System.Runtime.InteropServices;
string userInput;
/*
var namn = "";
var losenord = "hemligtlosenord";
var uLosen = "";
var ettTal = 0;
bool harSkrivitTal = false;
//1. Skriv ett program som frågar efter användarens namn och
//skriver ut en hälsning på konsolen. Om namnet är "David" ska det skriva ut "Hej David!"
//4. Uppdatera programmet i uppgift 1 så att det även frågar
//efter ett tal. Skriv hälsningen så många gånger som användaren anger.
Console.WriteLine("\nUppgift 1+4\n");
Console.WriteLine("Vad är ditt namn?");
namn = Console.ReadLine();
while(!harSkrivitTal) { 
    Console.WriteLine("Skriv ett tal: ");
    if(int.TryParse(Console.ReadLine(),out int result)) {
        if(result > 0) { 
            ettTal = result;
            harSkrivitTal = true;
        }
    }
    else
    {
        Console.WriteLine("Det är inte ett tal!");
    }
}
for(int i = 0; i < ettTal; i++) { 
    Console.WriteLine($"Hej {namn}!");
}

//Skriv ett program som frågar användaren efter ett lösenord.
//Hitta på ett hemligt lösenord och spara det i en variabel.
//När användaren har skrivit in ett lösenord ska programmet jämföra
//med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.
Console.WriteLine("\nUppgift 2\n");
Console.WriteLine("Skriv in lösenord: ");
uLosen = Console.ReadLine();
if(uLosen==losenord)
{
    Console.WriteLine("Rätt lösenord");
}
else
{
    Console.WriteLine("Fel lösenord");
}

//Skriv ett program som frågar användaren efter ett tal.
//Det ska skriva ut om talet är mindre än 100, lika med 100 eller större.
Console.WriteLine("\nUppgift 3\n");
harSkrivitTal = false;
while (!harSkrivitTal)
{
    Console.WriteLine("Skriv ett tal: ");
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        if (result < 100)
        {
            Console.WriteLine("Ditt tal är mindre än 100");
        }
        else if (result > 100)
        {
            Console.WriteLine("Ditt tal är större än 100");
        }
        else
        {
            Console.WriteLine("Ditt tal är lika med 100");
        }
        harSkrivitTal = true;
    }
    else
    {
        Console.WriteLine("Det är inte ett tal!");
    }
}

//Skriv ett program som upprepade gånger frågar användaren
//efter ett tal ända till man skriver något som inte är ett tal
//(t.ex bara trycker enter). Efter varje inmatning ska summan
//av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas.
//Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen.
//Hint: TryParse()
Console.WriteLine("\nUppgift 5\n");
harSkrivitTal = false;
int summa = 0;
int antalSkrivit = 0;
while (!harSkrivitTal)
{
    Console.WriteLine("Skriv ett tal: ");
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        summa += result;
        antalSkrivit++;
        Console.WriteLine(summa);
    }
    else
    {
        harSkrivitTal = true;
    }
}
Console.WriteLine($"Medelvärdet är: {summa/antalSkrivit}");

//Skriv ett program som först frågar efter ett tal, sedan
//frågar efter ett av följande tecken: +, -, * eller /.
//Därefter ska ytterligare ett tal efterfrågas. Programmet
//ska fungera som en simpel miniräknare. Om man t.ex matat
//in först 3, sedan *, och sist 5, så ska programmet skriva ut “3 * 5 = 15”.
Console.WriteLine("\nUppgift 6\n");
var tal1 = 0;
var tal2 = 0;
var utRakning = "";
harSkrivitTal = false;
while (!harSkrivitTal)
{
    Console.WriteLine("Skriv det första talet: ");
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        tal1 = result;
        harSkrivitTal = true;
    }
    else
    {
        Console.WriteLine("Det är inte ett tal!");
    }
}
harSkrivitTal = false;
while (!harSkrivitTal)
{
    Console.WriteLine("Vilken uträkning vill du göra? (+, -, * eller /): ");
    string temp = Console.ReadLine();
    if (temp == "+" || temp == "-" || temp == "*" || temp == "/")
    {
        utRakning = temp;
        harSkrivitTal = true;
    }
    else
    {
        Console.WriteLine("Det du skrev är inte en uträkning.");
    }
}
harSkrivitTal = false;
while (!harSkrivitTal)
{
    Console.WriteLine("Skriv det andra talet: ");
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        tal2 = result;
        harSkrivitTal = true;
    }
    else
    {
        Console.WriteLine("Det är inte ett tal!");
    }
}
switch(utRakning)
{
    case "+":
        Console.WriteLine($"{tal1} + {tal2} = {tal1+tal2}");
        break;
    case "-":
        Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
        break;
    case "*":
        Console.WriteLine($"{tal1} * {tal2} = {tal1*tal2}");
        break;
    case "/":
        if(tal2 != 0)
        {
            Console.WriteLine($"{tal1} / {tal2} = {tal1/tal2}");
        }
        else
        {
            Console.WriteLine("Det går inte att dela med noll.");
        }
        break;
}
//Skriv ett program som ber användaren skriva in en månad.
//Programmet ska göra om månaden till månadens siffervärde.
//T.ex. ska januari bli 1 och december 12. Använd switch.
//Alternativ: Prova även att lösa uppgiften med array och/eller enum.
//Extra utmaning: Be användaren om två månader och räkna sedan
//ut hur många månader som skiljer mellan dem.
//Tänk på att ett månaderna upprepas till nästa år.
//Skriver man mars och maj bör man få 2. Likaså om man skriver november och januari.

Console.WriteLine("\nUppgift 7\n");
string[] manader = new string[12] { "januari", "februari", "mars", "april", "maj", "juni", "juli", "augusti", "september", "oktober", "november", "december"};
bool harSkrivitInManad = false;
string manad1 = "januari", manad2 = "december";
while(!harSkrivitInManad)
{
    Console.WriteLine("Skriv en månad:");
    manad1 = Console.ReadLine() ?? "januari";
    if (manader.Contains(manad1.ToLower())) {
        harSkrivitInManad = true;
    }
    else
    {
        Console.WriteLine($"Vad du skrev är inte en månad! ({manad1})");
    }
}
harSkrivitInManad = false;
while (!harSkrivitInManad)
{
    Console.WriteLine("Skriv en annan månad:");
    manad2 = Console.ReadLine() ?? "december";
    if (manader.Contains(manad2.ToLower()))
    {
        harSkrivitInManad = true;
    }
    else
    {
        Console.WriteLine($"Vad du skrev är inte en månad! ({manad2})");
    }
}
//Om Månad1 är December och Månad 2 är Januari skiljer det sig enbart 1
int indexMonth1 = Array.IndexOf(manader, manad1);
int indexMonth2 = Array.IndexOf(manader, manad2);
int diffMonths = 0;
if (indexMonth1 > indexMonth2)
{
    diffMonths = manader.Length - indexMonth1;
    diffMonths += indexMonth2;
}
else
{
    diffMonths = indexMonth2 - indexMonth1;
}
Console.WriteLine($"Det skiljer sig {diffMonths} månader mellan {manad1} och {manad2}");


//Skapa ett program som skriver ut 1 på första raden,
//2 på nästa, sedan 4, o.s.v (dubbelt så hög siffra för varje rad).
//Fortsätt till du skrivit ut 16 rader.
Console.WriteLine("\nUppgift 8\n");
int initNumber = 1;
for (int i = 0; i < 16; i++)
{
    Console.WriteLine(initNumber);
    initNumber *= 2;
}

//Skriv ett program som frågar användaren efter ett tal mellan 1 och 100.
//Programmet ska ha ett hemligt tal lagrat i en variabel.
//Det ska fortsätta fråga användaren till dess att användaren
//gissar det hemliga talet. Om man gissade för högt eller för
//lågt så ska det skrivas ut, så att användaren har en rimlig
//chans att klara det. Exempel: programmet har det hemliga talet 27.
//Användaren gissar på 50. Programmet skriver ut att användaren
//gissade för högt. Användaren gissar på 20. Programmet
//skriver ut att det var för lågt. Användaren gissar på 27.
//Programmet skriver ut att det var rätt och avslutas.
Console.WriteLine("\nUppgift 9 del 1\n");
var number = 23;
bool gissaNummer = false;
while(!gissaNummer)
{
    Console.WriteLine("Gissa ett nummer: ");
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        if (result == number)
        {
            gissaNummer = true;
        }
        else
        {
            if (result > number)
            {
                Console.WriteLine("Du gissade för högt!");
            }
            else
            {
                Console.WriteLine("Du gissade för lågt!");
            }
        }
    }
    else
    {
        Console.WriteLine("För att gissa måste du skriv ett nummer.");
    }
}
Console.WriteLine($"Du gissade RÄTT! Talet var {number}");

//Extra utmaning: slumpa det hemliga talet med hjälp av Random
//(kolla upp på google hur det fungerar).
//Spara antalet gissningar i en variabel och skriv ut det när användaren gissat rätt.
Console.WriteLine("\nUppgift 9 del 2\n");
var rand = new Random().Next(0, 100);
var guesses = 0;
gissaNummer = false;
while (!gissaNummer)
{
    Console.WriteLine("Gissa ett nummer: ");
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        guesses++;
        if(result == rand) { 
            gissaNummer = true;
        }
        else
        {
            if(result > rand)
            {
                Console.WriteLine("Du gissade för högt!");
            }
            else
            {
                Console.WriteLine("Du gissade för lågt!");
            }
        }
    }
    else
    {
        Console.WriteLine("För att gissa måste du skriv ett nummer.");
    }
}
Console.WriteLine($"Du gissade RÄTT på {guesses} gissningar. Talet var {rand}");

//Extra utmaning 2: skriv ett sten-sax-påse spel.
//Användaren skriver in “sten”, “sax” eller “påse”.
//Dators val slumpas med Random. Skriv sedan ut vad datorn
//valde, och vem som vann omgången. Lägg det hela i en
//loop så spelet fortsätter tills man matar in en tom sträng
//(trycker enter utan att skriva något). Skriv även ut poäng.
Console.WriteLine("\nUppgift 9 del 3\n");
var playerIsPlay = true;
string[] SSP = new string[3] { "sten", "sax", "påse" };
int playerChoice = 0;
int playerPoint = 0;
int PCPoint = 0;
while (playerIsPlay)
{
    int pcChoice = new Random().Next(0, 2);
    var hasGottenPlayer = false;
    while(!hasGottenPlayer)
    {
        Console.WriteLine($"Du har {playerPoint} poäng. Datorn har {PCPoint} poäng");
        Console.WriteLine("Sten, sax eller påse?");
        var playerInput = Console.ReadLine() ?? "";
        playerInput = playerInput.ToLower();
        if (playerInput == "sten" || playerInput == "sax" || playerInput == "påse" || playerInput == string.Empty)
        {
            hasGottenPlayer = true;
            switch(playerInput)
            {
                case "sten":
                    playerChoice = 0;
                    break;
                case "sax":
                    playerChoice = 1;
                    break;
                case "påse":
                    playerChoice = 2;
                    break;
                case "":
                    playerIsPlay = false;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Skriv in sten, sax ELLER påse!");
        }
    }
    //Sten är 0. Sten slår sax. Om A är 0 och B är 1, vinner A
    //Sax är 1. Sax slår påse. Om A är 1 och B är 2, vinner A
    //Påse är 2. Påse slår sten. Om A är 2 och B är 0, vinner A
    if (playerIsPlay) { 
        string additionalInfo = "";
        switch(pcChoice)
        {
            case 0:
                if(playerChoice == 1)
                {
                    additionalInfo = "Datorn vann.";
                    PCPoint++;
                }
                else if(playerChoice == pcChoice)
                {
                    additionalInfo = "Ingen vann.";
                }
                else
                {
                    additionalInfo = "Du vann.";
                    playerPoint++;
                }
                break;
            case 1:
                if (playerChoice == 2)
                {
                    additionalInfo = "Datorn vann.";
                    PCPoint++;
                }
                else if (playerChoice == pcChoice)
                {
                    additionalInfo = "Ingen vann.";
                }
                else
                {
                    additionalInfo = "Du vann.";
                    playerPoint++;
                }
                break;
            case 2:
                if (playerChoice == 0)
                {
                    additionalInfo = "Datorn vann.";
                    PCPoint++;
                }
                else if (playerChoice == pcChoice)
                {
                    additionalInfo = "Ingen vann.";
                }
                else
                {
                    additionalInfo = "Du vann.";
                    playerPoint++;
                }
                break;
        }
        Console.WriteLine($"Du valde {SSP[playerChoice]}. Datorn valde {SSP[pcChoice]}. {additionalInfo}");
    }
}

//Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad. Ex: Hej => H e j
Console.WriteLine("\nUppgift 10\n");
Console.WriteLine("Skriv in något: ");
userInput = Console.ReadLine();
for(int i = 0;i < userInput.Length;i++)
{
    Console.Write($"{userInput[i]} ");
}


//Skapa ett program med en array som innehåller strängarna
//“noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
//Be sedan användaren att mata in en siffra.
//Använd arrayen för att skriva ut siffrans ord.
//Ex. Inmatning “3” => “tre”.
//Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror,
//om man skriver in t.ex 432 så svarar programmet: “fyra - tre - två”.
Console.WriteLine("\nUppgift 11\n");
string[] siffror = new string[10] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
var hasEnteredInput = false;
int result = 0;
while(!hasEnteredInput)
{
    Console.WriteLine("Skriv in en siffra");
    var input = Console.ReadLine();
    if(int.TryParse(input,out result))
    {
        hasEnteredInput = true;
    }
}
if(result > 9)
{
    //Gör om resulatet till en string, då kan vi gå igenom den en-och-en!
    var temp = result.ToString();
    for (int i = 0; i < temp.Length; i++) {
        int newOut = 0;
        //Vi vill enbart byta om det är en INT och inte en STRING!
        if (int.TryParse(temp[i].ToString(), out newOut))
        {
            temp = temp.Replace(temp[i].ToString(), siffror[newOut] + "-");
        }
    }
    //Systemet funkar, dock väldigt enkelt gjort... så vi måste se till att ta bort den sista!
    if (temp[temp.Length-1] == '-')
    {
        temp = temp.Remove(temp.Length - 1);
    }
    //Et voilà!
    Console.WriteLine(temp);
}
else
{
    //Det är mycket enklare när det kommer till ensiffriga tal...
    Console.WriteLine(siffror[result]);
}
//Fråga användaren hur många tal den vill mata in.
//Fråga sedan efter talen i tur och ordning
//(“Ange tal 1:” osv). När alla tal är
//inmatade skriv ut dem i omvänd ordning.
Console.WriteLine("\nUppgift 12\n");
bool hasGottenInput = false;
var amountOfNumbers = 0;
while(!hasGottenInput)
{
    Console.WriteLine("Hur många tal vill du mata in?");
    var input = Console.ReadLine();
    if(int.TryParse(input,out amountOfNumbers))
    {
        hasGottenInput = true;
    }
}
int[] numbArray = new int[amountOfNumbers];
for (int i = 0; i < amountOfNumbers; i++)
{
    hasGottenInput = false;
    while(!hasGottenInput)
    {
        Console.WriteLine($"Ange Tal {i+1}:");
        var input = Console.ReadLine();
        if (int.TryParse(input, out numbArray[i]))
        {
            hasGottenInput = true;
        }
    }
}
Console.WriteLine("Här kommer en recap!");
Array.Reverse(numbArray);
for (int i = 0; i < numbArray.Length;i++)
{
    Console.WriteLine(numbArray[i]);
}

//Be användaren mata in en text. Skriv sedan ut texten baklänges.
Console.WriteLine("\nUppgift 13\n");
Console.WriteLine("Skriv in något: ");
userInput = Console.ReadLine() ?? "";
Console.WriteLine(userInput.Reverse().ToArray());
*/

//Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *
//Extra utmaning: Skriv ut texten översatt till rövarspråket.
Console.WriteLine("\nUppgift 14\n");
Console.WriteLine("Skriv in något: ");
userInput = Console.ReadLine() ?? "";
char[] vokaler = new char[9] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
for(int i = 0; i < userInput.Length-1;i++)
{
    for(int k = 0; k < vokaler.Length;k++)
    {
        if(Char.ToLower(vokaler[k]) == Char.ToLower(userInput[i]))
        {
            userInput = userInput.Replace(userInput[i], '*');
        }
    }
}
Console.WriteLine(userInput);