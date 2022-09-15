namespace Ovningar20220901
{
    public class Funktioner
    {
        //Massa generiska funktioner
        public static void PrintSum(double one, double two, string mathCondition)
        {
            double mathResult;
            switch (mathCondition)
            {
                case "+":
                    mathResult = one + two;
                    break;
                case "-":
                    mathResult = one - two;
                    break;
                case "*":
                    mathResult = one * two;
                    break;
                case "/":
                    mathResult = one / two;
                    break;
                default:
                    mathResult = 0;
                    break;
            }

            Console.WriteLine($"{one} {mathCondition} {two} = {mathResult}");
        }

        public static string MakeUpper(string mystring)
        {
            return char.ToUpper(mystring[0]) + mystring[1..].ToLower();
        }

        public static string WhichLongest(string[] checkArray)
        {
            for (var i = 0; i < checkArray.Length; i++)
            {
                for (var k = 0; k < checkArray.Length - 1; k++)
                {
                    if (checkArray[k].Length > checkArray[i].Length)
                    {
                        var temp = checkArray[k];
                        checkArray[k] = checkArray[i];
                        checkArray[i] = temp;
                    }
                }
            }
            return checkArray[^1];
        }

        public static int[] IndexOfAll(string text, char c)
        {
            int[] indexes = new int[text.Length];
            var temp = text.ToLower();
            var amountIndexes = 0;
            for (var i = 0; i < temp.Length; i++)
            {
                if (temp[i] == c)
                {
                    indexes[amountIndexes] = i;
                    amountIndexes++;
                }
            }
            Array.Resize(ref indexes, amountIndexes);
            return indexes;
        }
    }
}
