namespace Ovningar20220901
{
    public class Exercises
    {

        public static void One()
        {
            //1. Skriv ett program som frågar efter användarens namn och
            //skriver ut en hälsning på konsolen. Om namnet är "David" ska det skriva ut "Hej David!"
            //4. Uppdatera programmet i Exercise 1 så att det även frågar
            //efter ett tal. Skriv hälsningen så många gånger som användaren anger.
            Console.WriteLine("\nExercise 1+4\n");
            Console.WriteLine("Vad är ditt namn?");
            var namn = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Skriv ett tal: ");
                if (int.TryParse(Console.ReadLine(), out var result))
                {
                    if (result > 0)
                    {
                        for (var i = 0; i < result; i++)
                        {
                            Console.WriteLine($"Hej {namn}!");
                        }

                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Det är inte ett tal!");
                }
            }

        }
        public static void Two()
        {
            //Skriv ett program som frågar användaren efter ett lösenord.
            //Hitta på ett hemligt lösenord och spara det i en variabel.
            //När användaren har skrivit in ett lösenord ska programmet jämföra
            //med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.
            Console.WriteLine("\nExercise 2\n");
            Console.WriteLine("Skriv in lösenord: ");
            var uLosen = Console.ReadLine();
            var losenord = "hemligtlosenord";
            if (uLosen == losenord)
            {
                Console.WriteLine("Rätt lösenord");
            }
            else
            {
                Console.WriteLine("Fel lösenord");
            }
        }
        public static void Three()
        {
            //Skriv ett program som frågar användaren efter ett tal.
            //Det ska skriva ut om talet är mindre än 100, lika med 100 eller större.
            Console.WriteLine("\nExercise 3\n");
            while (true)
            {
                Console.WriteLine("Skriv ett tal: ");
                if (int.TryParse(Console.ReadLine(), out var result))
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

                    break;
                }
                else
                {
                    Console.WriteLine("Det är inte ett tal!");
                }
            }
        }
        public static void Five()
        {
            //Skriv ett program som upprepade gånger frågar användaren
            //efter ett tal ända till man skriver något som inte är ett tal
            //(t.ex bara trycker enter). Efter varje inmatning ska summan
            //av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas.
            //Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen.
            //Hint: TryParse()
            Console.WriteLine("\nExercise 5\n");
            var summa = 0;
            var antalSkrivit = 0;
            var diff = 0;
            while (true)
            {
                Console.WriteLine("Skriv ett tal: ");
                if (int.TryParse(Console.ReadLine(), out var result))
                {
                    summa += result;
                    antalSkrivit++;
                    diff = summa / antalSkrivit;
                    Console.WriteLine(summa);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Medelvärdet är: {diff}");
        }
        public static void Six()
        {
            //Skriv ett program som först frågar efter ett tal, sedan
            //frågar efter ett av följande tecken: +, -, * eller /.
            //Därefter ska ytterligare ett tal efterfrågas. Programmet
            //ska fungera som en simpel miniräknare. Om man t.ex matat
            //in först 3, sedan *, och sist 5, så ska programmet skriva ut “3 * 5 = 15”.
            Console.WriteLine("\nExercise 6\n");
            double tal1, tal2;
            string? utRakning;
            while (true)
            {
                Console.WriteLine("Skriv det första talet: ");
                if (double.TryParse(Console.ReadLine(), out tal1))
                {
                    break;
                }

                Console.WriteLine("Det är inte ett tal!");
            }
            while (true)
            {
                Console.WriteLine("Vilken uträkning vill du göra? (+, -, * eller /): ");
                utRakning = Console.ReadLine();
                if (utRakning == "+" || utRakning == "-" || utRakning == "*" || utRakning == "/")
                {
                    break;
                }

                Console.WriteLine("Det du skrev är inte en uträkning.");
            }
            while (true)
            {
                Console.WriteLine("Skriv det andra talet: ");
                if (double.TryParse(Console.ReadLine(), out tal2))
                {
                    if (tal2 != 0 && utRakning == "/")
                    {
                        break;
                    }
                }

                Console.WriteLine("Det är inte ett tal!");
            }

            Funktioner.PrintSum(tal1, tal2, utRakning);
        }
        public static void Seven()
        {
            //Skriv ett program som ber användaren skriva in en månad.
            //Programmet ska göra om månaden till månadens siffervärde.
            //T.ex. ska januari bli 1 och december 12. Använd switch.
            //Alternativ: Prova även att lösa Exerciseen med array och/eller enum.
            //Extra utmaning: Be användaren om två månader och räkna sedan
            //ut hur många månader som skiljer mellan dem.
            //Tänk på att ett månaderna upprepas till nästa år.
            //Skriver man mars och maj bör man få 2. Likaså om man skriver november och januari.

            Console.WriteLine("\nExercise 7\n");
            string[] manader = { "januari", "februari", "mars", "april", "maj", "juni", "juli", "augusti", "september", "oktober", "november", "december" };
            string manad1, manad2;
            while (true)
            {
                Console.WriteLine("Skriv en månad:");
                manad1 = Console.ReadLine() ?? "januari";
                if (manader.Contains(manad1.ToLower()))
                {
                    break;
                }

                Console.WriteLine($"Vad du skrev är inte en månad! ({manad1})");
            }
            while (true)
            {
                Console.WriteLine("Skriv en annan månad:");
                manad2 = Console.ReadLine() ?? "december";
                if (manader.Contains(manad2.ToLower()))
                {
                    break;
                }
                Console.WriteLine($"Vad du skrev är inte en månad! ({manad2})");
            }
            //Om Månad1 är December och Månad 2 är Januari skiljer det sig enbart 1
            var indexMonth1 = Array.IndexOf(manader, manad1);
            var indexMonth2 = Array.IndexOf(manader, manad2);
            int diffMonths;
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
        }
        public static void Eight()
        {
            //Skapa ett program som skriver ut 1 på första raden,
            //2 på nästa, sedan 4, o.s.v (dubbelt så hög siffra för varje rad).
            //Fortsätt till du skrivit ut 16 rader.
            Console.WriteLine("\nExercise 8\n");
            var initNumber = 1;
            for (var i = 0; i < 16; i++)
            {
                Console.WriteLine(initNumber);
                initNumber *= 2;
            }
        }
        public static void Nine()
        {
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
            Console.WriteLine("\nExercise 9 del 1\n");
            var number = 23;
            while (true)
            {
                Console.WriteLine("Gissa ett nummer: ");
                if (int.TryParse(Console.ReadLine(), out var result))
                {
                    if (result == number)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(result > number ? "Du gissade för högt!" : "Du gissade för lågt!");
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
            Console.WriteLine("\nExercise 9 del 2\n");
            var rand = new Random().Next(0, 100);
            var guesses = 0;
            while (true)
            {
                Console.WriteLine("Gissa ett nummer: ");
                if (int.TryParse(Console.ReadLine(), out var result))
                {
                    guesses++;
                    if (result == rand)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(result > rand ? "Du gissade för högt!" : "Du gissade för lågt!");
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
            Console.WriteLine("\nExercise 9 del 3\n");
            var playerIsPlay = true;
            string[] choices = { "sten", "sax", "påse" };
            var playerChoice = 0;
            var playerPoint = 0;
            var pcPoint = 0;
            while (playerIsPlay)
            {
                var pcChoice = new Random().Next(0, 2);
                while (true)
                {
                    Console.WriteLine($"Du har {playerPoint} poäng. Datorn har {pcPoint} poäng");
                    Console.WriteLine("Sten, sax eller påse?");
                    var playerInput = Console.ReadLine() ?? "";
                    playerInput = playerInput.ToLower();
                    if (playerInput == "sten" || playerInput == "sax" || playerInput == "påse" || playerInput == string.Empty)
                    {
                        switch (playerInput)
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
                        break;
                    }
                    Console.WriteLine("Skriv in sten, sax ELLER påse!");
                }
                //Sten är 0. Sten slår sax. Om A är 0 och B är 1, vinner A
                //Sax är 1. Sax slår påse. Om A är 1 och B är 2, vinner A
                //Påse är 2. Påse slår sten. Om A är 2 och B är 0, vinner A
                if (playerIsPlay)
                {
                    string additionalInfo;
                    switch (pcChoice)
                    {
                        case 0:
                            if (playerChoice == 1)
                            {
                                additionalInfo = "Datorn vann.";
                                pcPoint++;
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
                        case 1:
                            if (playerChoice == 2)
                            {
                                additionalInfo = "Datorn vann.";
                                pcPoint++;
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
                                pcPoint++;
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
                        default:
                            additionalInfo = "Något gick fel.";
                            break;
                    }
                    Console.WriteLine($"Du valde {choices[playerChoice]}. Datorn valde {choices[pcChoice]}. {additionalInfo}");
                }
            }
        }
        public static void Ten()
        {
            //Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad. Ex: Hej => H e j
            Console.WriteLine("\nExercise 10\n");
            Console.WriteLine("Skriv in något: ");
            var userInput = Console.ReadLine() ?? "";
            foreach (var t in userInput)
            {
                Console.WriteLine($"{t}");
            }
        }
        public static void Eleven()
        {
            //Skapa ett program med en array som innehåller strängarna
            //“noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
            //Be sedan användaren att mata in en siffra.
            //Använd arrayen för att skriva ut siffrans ord.
            //Ex. Inmatning “3” => “tre”.
            //Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror,
            //om man skriver in t.ex 432 så svarar programmet: “fyra - tre - två”.
            Console.WriteLine("\nExercise 11\n");
            string[] siffror = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
            int result;
            string? input;
            while (true)
            {
                Console.WriteLine("Skriv in en siffra");
                input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    break;
                }
            }
            if (result > 9)
            {
                //Gör om resulatet till en string, då kan vi gå igenom den en-och-en!
                var temp = result.ToString();
                for (var i = 0; i < temp.Length; i++)
                {
                    //Vi vill enbart byta om det är en INT och inte en STRING!
                    if (int.TryParse(temp[i].ToString(), out var newOut))
                    {
                        temp = temp.Replace(temp[i].ToString(), siffror[newOut] + "-");
                    }
                }
                //Systemet funkar, dock väldigt enkelt gjort... så vi måste se till att ta bort den sista!
                if (temp[^1] == '-')
                {
                    temp = temp.Remove(temp.Length - 1);
                }
                Console.WriteLine(temp);
            }
            else
            {
                //Det är mycket enklare när det kommer till ensiffriga tal...
                Console.WriteLine(siffror[result]);
            }
        }
        public static void Twelve()
        {
            //Fråga användaren hur många tal den vill mata in.
            //Fråga sedan efter talen i tur och ordning
            //(“Ange tal 1:” osv). När alla tal är
            //inmatade skriv ut dem i omvänd ordning.
            Console.WriteLine("\nExercise 12\n");
            int amountOfNumbers;
            string? input;
            while (true)
            {
                Console.WriteLine("Hur många tal vill du mata in?");
                input = Console.ReadLine();
                if (int.TryParse(input, out amountOfNumbers))
                {
                    break;
                }
            }
            var numbArray = new int[amountOfNumbers];
            for (var i = 0; i < amountOfNumbers; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Ange Tal {i + 1}:");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out numbArray[i]))
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Här kommer en recap!");
            Array.Reverse(numbArray);
            foreach (var t in numbArray)
            {
                Console.WriteLine(t);
            }
        }
        public static void Thirteen()
        {
            //Be användaren mata in en text. Skriv sedan ut texten baklänges.
            Console.WriteLine("\nExercise 13\n");
            Console.WriteLine("Skriv in något: ");
            var userInput = Console.ReadLine() ?? "";
            var reverseUserInput = "";
            if (userInput == string.Empty)
            {
                userInput = "test";
            }
            for (var i = userInput.Length; i > 0; i--)
            {
                reverseUserInput += userInput[i - 1];
            }
            Console.WriteLine(reverseUserInput);
        }
        public static void Fourteen()
        {
            //Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *
            //Extra utmaning: Skriv ut texten översatt till rövarspråket.
            Console.WriteLine("\nExercise 14\n");
            Console.WriteLine("Skriv in något: ");
            var userInput = Console.ReadLine() ?? "";
            var output1 = userInput;
            char[] vokaler = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
            for (var i = 0; i < userInput.Length - 1; i++)
            {
                if (vokaler.Contains(char.ToLower(output1[i])))
                {
                    output1 = output1.Replace(output1[i], '*');
                }
            }
            Console.WriteLine(output1);
            var output2 = userInput;
            var unknownChars = new char[userInput.Length];
            var actualInput = 0;
            foreach (var t in userInput)
            {
                if (!unknownChars.Contains((t)) && char.IsLetter(t))
                {
                    unknownChars[actualInput] = t;
                    actualInput++;
                }
            }
            Array.Resize(ref unknownChars, actualInput);
            foreach (var t in unknownChars)
            {
                var x = char.ToLower(t);
                if (!vokaler.Contains(x))
                {
                    output2 = output2.Replace($"{x}", $"{x}o{x}");
                }
            }
            Console.WriteLine(output2);
            output2 = unknownChars.Where(x => !vokaler.Contains(x)).Aggregate(output2, (current, x) => current.Replace($"{x}o{x}", $"{x}"));
            Console.WriteLine(output2);
        }
        public static void Fifteen()
        {
            //Ett palindrom är ett ord som blir
            //samma framlänges som baklänges.
            //Be användaren skriva in ett
            //ord och ange sedan om det är ett palindrom eller inte.
            Console.WriteLine("\nExercise 15\n");
            Console.WriteLine("Skriv in något: ");
            var userInput = Console.ReadLine() ?? "test";
            var reverseUserInput = string.Empty;
            if (userInput == string.Empty)
            {
                userInput = "Anna";
            }
            for (var i = userInput.Length; i > 0; i--)
            {
                reverseUserInput += userInput[i - 1];
            }
            reverseUserInput = Funktioner.MakeUpper(reverseUserInput);
            userInput = Funktioner.MakeUpper(userInput);
            if (reverseUserInput == userInput)
            {
                Console.WriteLine($"{reverseUserInput} är samma som {userInput}");
            }
            else
            {
                Console.WriteLine($"{reverseUserInput} är INTE samma som {userInput}");

            }
        }
        public static void Sixteen()
        {
            //Gör om Exercise 6 så man kan mata in allt på en rad
            //(första talet, operator, andra talet).
            //Ignorera inmatade mellanslag i strängen.
            //Om man t.ex. matar in strängen “34 - 14”,
            //så ska programmet skriva ut “= 20”.
            Console.WriteLine("Exercise 16");
            while (true)
            {
                Console.WriteLine("Skriv en uträkning:");
                var userInput = Console.ReadLine() ?? "";
                userInput = userInput.Replace(" ", string.Empty);
                if (userInput is "" or null)
                {
                    break;
                }
                if (userInput.Length >= 3)
                {
                    var mathChar = '0';
                    if (userInput.Contains('+') && userInput.IndexOf('+') > 0)
                    {
                        mathChar = '+';
                    }
                    else if (userInput.Contains('-') && userInput.IndexOf('-') > 0)
                    {
                        mathChar = '-';
                    }
                    else if (userInput.Contains('/') && userInput.IndexOf('/') > 0)
                    {
                        mathChar = '/';
                    }
                    else if (userInput.Contains('*') && userInput.IndexOf('*') > 0)
                    {
                        mathChar = '*';
                    }
                    var mathCharIndex = userInput.IndexOf(mathChar);
                    if (double.TryParse(userInput[..mathCharIndex], out var tResultOne))
                    {
                        mathCharIndex++;
                        if (double.TryParse(userInput[mathCharIndex..], out var tResultTwo))
                        {
                            if (!(tResultTwo == 0 && mathChar == '/'))
                            {
                                Funktioner.PrintSum(tResultOne, tResultTwo, mathChar.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Kan inte dividera med 0.");
                            }
                        }
                    }
                }
            }
        }

        public static void Seventeen()
        {
            //Gör ett program som ber användaren mata in en text.
            //Be sedan användaren mata in en sträng som är en
            //del av den första texten. Skriv ut hela texten
            //med den del man angav markerad i en annan färg.
            //Ex. Användare matar in “abcdefghijklmnopqrstuvxyz”,
            //och sedan “defg”. Programmet ska då skriva ut: abcdefghijklmnopqrstuvxyz
            Console.ResetColor();
            string text, bold;
            while (true)
            {
                Console.WriteLine("Skriv en sträng");
                text = Console.ReadLine() ?? "";
                Console.WriteLine("Vad vill du färglägga?");
                bold = Console.ReadLine() ?? "";
                if (text.Contains(bold))
                {
                    break;
                }

                Console.WriteLine($"{bold} finns inte i {text}");
            }
            text = text.Replace('|', '?');
            var boldReplace = "";
            for (var i = 0; i < bold.Length; i++)
            {
                boldReplace += "|";
            }
            var temp = text.Replace(bold, boldReplace);
            var firstPos = temp.IndexOf('|');
            var lastPos = temp.LastIndexOf('|');
            for (var i = 0; i < text.Length; i++)
            {
                if (i >= firstPos && i <= lastPos)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.Write(text[i]);
            }
            Console.ResetColor();
        }

        public static void Eighteen()
        {
            //Be användaren mata in en mening.
            //Skriv ut det genomsnittliga antalet bokstäver i orden
            Console.WriteLine("Skriv en mening:");
            var text = Console.ReadLine() ?? "";
            if (text is "" or null)
            {
                text = "Detta är en mening";
            }
            var textArray = text.Split(' ');
            var diffText = textArray.Sum(t => t.Length) / textArray.Length;
            Console.WriteLine($"Genomsnitt av \"{text}\" är {diffText} bokstäver");
        }

        public static void Nineteen()
        {
            int numOne, numTwo;
            while (true)
            {
                Console.WriteLine("Vilken höjd vill du ha?");
                if (int.TryParse(Console.ReadLine(), out numOne))
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Vilken bredd vill du ha?");
                if (int.TryParse(Console.ReadLine(), out numTwo))
                {
                    break;
                }
            }
            Snake snake = new Snake()
            {
                _height = numOne,
                _width = numTwo,
                _randomShapes = 0,
                PlayerPos = new int[1, 2] { { 0, 0 } },
                ShowPlayer = false,
                drawArray = new string[numOne, 1],
                shouldPlay = false
            };

            snake.PrintArray(snake.DrawBox());
        }

        public static void Twenty(bool shouldShowRandom)
        {
            Snake snake = new Snake();
            while (true)
            {
                Console.WriteLine("Vilken höjd vill du ha?");
                if (int.TryParse(Console.ReadLine(), out snake._height))
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Vilken bredd vill du ha?");
                if (int.TryParse(Console.ReadLine(), out snake._width))
                {
                    break;
                }
            }
            if (shouldShowRandom)
            {
                while (true)
                {
                    Console.WriteLine("Hur många slumpmässiga '#' vill du ha?");
                    if (int.TryParse(Console.ReadLine(), out snake._randomShapes))
                    {
                        break;
                    }
                }
            }
            else
            {
                snake._randomShapes = 0;
            }

            snake.drawArray = new string[snake._height, 1];
            var sX = snake._width / 2;
            var sY = snake._height / 2;
            snake.PlayerPos = new int[3, 2] { { sX, sY }, { sX, sY - 1 }, { sX, sY - 2 } }; //X, Y
            snake.shouldPlay = true;
            snake.ShowPlayer = true;
            var sWalk = snake.Walk;
            int[] lastDir = { 0, 0 };
            while (snake.shouldPlay)
            {
                Console.Clear();
                snake.drawArray = snake.DrawBox();
                snake.PrintArray(snake.drawArray);
                var a = Console.ReadKey(true);
                switch (a.Key)
                {
                    case ConsoleKey.LeftArrow:
                        lastDir[0] = -1;
                        lastDir[1] = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        lastDir[0] = 1;
                        lastDir[1] = 0;
                        break;
                    case ConsoleKey.UpArrow:
                        lastDir[0] = 0;
                        lastDir[1] = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        lastDir[0] = 0;
                        lastDir[1] = 1;
                        break;
                    default:
                        snake.shouldPlay = false;
                        break;
                }
                sWalk(lastDir[0], lastDir[1]);
                Thread.Sleep(50);
            }
        }

        public static void TwentyTwo()
        {
            //Skriv en funktion som kan ta ett godtyckligt
            //antal strängar som parametrar och som returnerar den längsta av dem.
            Console.WriteLine("Skriv in ett antal strängar:");
            var input = Console.ReadLine() ?? " ";
            var inputArray = input.Split(" ");
            Console.WriteLine(Funktioner.WhichLongest(inputArray));
        }

        public static void TwentyThree()
        {
            //Skapa en metoden int[] IndexOfAll(string text, char c)
            //som söker igenom strängen text och returnerar
            //en int[] med index till alla förekomster av c i text.
            Console.WriteLine("Skriv en sträng");
            var input = Console.ReadLine() ?? " ";
            foreach (var i in Funktioner.IndexOfAll(input, 'c'))
            {
                Console.WriteLine($"{i} = {input[i]}");
            }
        }

        public static void TwentyFour()
        {
            var rektanglar = new[,]
            {
                { "a.\n#-------", "-#------", "--#-----", "---#----" },
                { "\nb.\n#---#---", "-#---#--", "--#---#-", "---#---#" },
                { "\nc.\n##------","--##----","----##--","------##" },
                { "\nd.\n--#--#--","--#--#--","########","--#--#--" },
                { "\ne.\n#---#---","-#-#----","--#-----","-#-#----" },
                { "\nf.\n#-#-","-#-#","#-#-","-#-#"},
                { "\ng.\n###---","###---","###---","------"},
                { "\nh.\n--#--##","---#-##","----#--","-----#-"},
                { "\ni.\n--#--","-----","--#--","--#--" },
                { "\nj.\n#---#","-#-#-","--o--","-#-#-\n#---#" },
                { "\nk.\n##--##--##--##--","##--##--##--##--","wwwwww~~~~~~~~~~","################"}
            };

            foreach (var rekt in rektanglar)
            {
                Console.WriteLine(rekt);
            }
            Thread.Sleep(500);
        }
        public static void TwentyFive()
        {
            //För att välja dessa olika konstruktörer måste det väljas när en skriver, det kommer upp en meny
            var bil = new Car();
            bil.Make = "BMW";
            bil.Colour = "Svart";
            bil.Price = 100000;
            var bil2 = new Car("Volvo", 500000, "Röd");
            bil2.Price = 200000;
        }
        public static void TwentySix()
        {
            var counter = new StepCounter();
            for (var i = 0; i < 1000; i++)
            {
                counter.Step();
            }

            Console.WriteLine(counter.ToString());
            counter.Reset();
        }
        public static void TwentySeven()
        {
            var color = new ColorReturner();
            color.Blue = 8.5;
            Console.WriteLine(color.ToString());
            color.Red = 30.5;
            Console.WriteLine(color.ToString());
        }
        public static void TwentyEight()
        {
            Person p = new Person("Anna", "Berg");
            Console.WriteLine(p.Name());
            p.FirstName = "Per";
            p.LastName = "Lind";
            Console.WriteLine(p.Name());
        }
        public static void TwentyNine()
        {
            Car c = new Car("Volvo", 10000);
            Console.WriteLine(c.ToString());
        }
        public static void Thirty()
        {

        }
    }
}
