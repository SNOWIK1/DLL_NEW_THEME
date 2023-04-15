namespace myMath
{
    public class easy
    {

        public static void SumMult(string str)
        {

            bool isPassed = true;
            bool isFinished = false;

                double sum = 0;
                double mult = 1;

                string[] arr = str.Split(' ');
                double[] numbers = new double[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {

                    try
                    {
                        numbers[i] = double.Parse(arr[i]);

                        sum += numbers[i];
                        mult *= numbers[i];
                        
                        isPassed = true;
                        
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect input, try again...");
                        isPassed = false;
                        break;
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Incorrect input, try again...");
                        isPassed = false;
                        break;

                    }
                }
                if (isPassed)
                {
                    isFinished = true;
                    Console.WriteLine($"Sum: {sum}\nMult: {mult}");
                }

        }
    }
}
