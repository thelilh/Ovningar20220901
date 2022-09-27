using Ovningar20220901;
//Switch-meny funktion
var showMenu = true;
const int lastSelection = 41;
while (showMenu)
{
    Console.WriteLine("Välj ett program:");
    for (var i = 1; i < lastSelection; i++)
    {
        Console.WriteLine($"Uppgift {i})");
    }
    var temp = Console.ReadLine();
    if (int.TryParse(temp, out var selection))
    {
        Console.Clear();
        switch (selection)
        {
            case 1:
                Exercises.One();
                break;
            case 2:
                Exercises.Two();
                break;
            case 3:
                Exercises.Three();
                break;
            case 4:
                Exercises.One();
                break;
            case 5:
                Exercises.Five();
                break;
            case 6:
                Exercises.Six();
                break;
            case 7:
                Exercises.Seven();
                break;
            case 8:
                Exercises.Eight();
                break;
            case 9:
                Exercises.Nine();
                break;
            case 10:
                Exercises.Ten();
                break;
            case 11:
                Exercises.Eleven();
                break;
            case 12:
                Exercises.Twelve();
                break;
            case 13:
                Exercises.Thirteen();
                break;
            case 14:
                Exercises.Fourteen();
                break;
            case 15:
                Exercises.Fifteen();
                break;
            case 16:
                Exercises.Sixteen();
                break;
            case 17:
                Exercises.Seventeen();
                break;
            case 18:
                Exercises.Eighteen();
                break;
            case 19:
                Exercises.Nineteen();
                break;
            case 20:
                Exercises.Twenty(false);
                break;
            case 21:
                Exercises.Twenty(true);
                break;
            case 22:
                Exercises.TwentyTwo();
                break;
            case 23:
                Exercises.TwentyThree();
                break;
            case 24:
                Exercises.TwentyFour();
                break;
            case 25:
                Exercises.TwentyFive();
                break;
            case 26:
                Exercises.TwentySix();
                break;
            case 27:
                Exercises.TwentySeven();
                break;
            case 28:
                Exercises.TwentyEight();
                break;
            case 29:
                Exercises.TwentyNine();
                break;
            case 30:
                Exercises.Thirty();
                break;
            case 31:
                Exercises.ThirtyOne();
                break;
            case 32:
                Exercises.ThirtyTwo();
                break;
            case 33:
                Exercises.ThirtyThree();
                break;
            case 34:
                Exercises.ThirtyFour();
                break;
            case 35:
                Exercises.ThirtyFive();
                break;
            case 36:
                Exercises.ThirtySix();
                break;
            case 37:
                Exercises.ThirtySeven();
                break;
            case 38:
                Exercises.ThirtyEight();
                break;
            case 39:
                Exercises.ThirtyNine();
                break;
            case 40:
                Exercises.Fourty();
                break;
            default:
                showMenu = false;
                break;
        }
    }
    else
    {
        break;
    }
}


