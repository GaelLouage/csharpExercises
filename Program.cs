internal class Program
{
    /*6.1.4*/
    /*"We show an array of 10 indices. Each index has a starting value of 0. Then you get the question: 
     * 'In which index would you like to insert a decimal number?' Here you enter a number between 1 and 10.
     * Depending on your answer, a decimal number will automatically appear and the result will be printed. 
     * Continue this until all indices are filled. At the end the sentence 'All indices have been filled.' will appear.*/
    
    private static double[] indexPlacer = new double[10];
    private static void Main(string[] args)
    {
        PrintValues();
    }

    private static void PrintValues()
    {
        /*In wich index do you want to place a decimal value?

4,57 | 5,38 | 0,66 | 6,18 | 4,85 | 5,69 | 8,77 | 8,45 | 5,09 | 8,45
     */
        do
        {

            Console.WriteLine("In wich index do you want to place a decimal value?");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out int inputToNumericalValue))
            {
                Console.WriteLine("Input has to be a number!");

            }
            if (inputToNumericalValue > indexPlacer.Length)
            {
                Console.WriteLine($"Cannot be bigger than {indexPlacer.Length}.");
            }
            else
            {
                if (indexPlacer[inputToNumericalValue] == 0)
                {
                    var random = new Random();
                    var randomDecimal = Convert.ToDouble((random.NextDouble() * (10 - .01) + 0.1).ToString("n2"));
                    indexPlacer[inputToNumericalValue] = randomDecimal;

                }
            }

            Console.WriteLine(string.Join(" | ", indexPlacer));
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}