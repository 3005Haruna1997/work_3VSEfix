internal class Program
{
    private static void Main(string[] args)
    {
        // блок основных переменных
        string? enteredValue = "";
        // блок вспомогательных переменных
        int technicalIntValue_1 = 0;

        string techicalStringValue_1 = "-";

        bool technicalBoolValue_1 = false;
        bool technicalBoolValue_2 = false;

        string[] searchingIcons = { ".  ", ".. ", "...", };//для анимации

        techicalStringValue_1 = string.Join("-", Enumerable.Repeat(techicalStringValue_1, 35));//для пунктирной строчки 

        void demarcationLine()
        {
            // Разделяющая линия
            Console.WriteLine(techicalStringValue_1);
        }

        void AppExitAnimation()
        {
            for (int j = 3; j > -1; j--)
            {
                foreach (string icon in searchingIcons)
                {
                    Console.Write($"\rВыходим из приложения{icon}");
                    Thread.Sleep(350);
                }
                Console.Write($"\r{new string(' ', Console.BufferWidth)}");
            }
        }

        void notEnterANumder()
        {
            // 
            demarcationLine();
            Console.WriteLine("You didn't enter a number. " +
            "Please try again.");
            //techicalValue_2 = false;
        }

        void enteredValueToLower()
        {
            //Метод для определение введеных данных игнорирую регистр. И для устранения проблемы возможного нулевого референса.
            if (enteredValue != null)
            {
                enteredValue = enteredValue.ToLower();
            }
        }

        Console.WriteLine("Please, enter a number " +
                        "(or enter \"Back\" to return to the menu)");
        enteredValue = Console.ReadLine();

        enteredValueToLower();

        if (enteredValue != "")
        {
            if (int.TryParse(enteredValue, out technicalIntValue_1) == false
            && enteredValue != "back")
            {
                notEnterANumder();
            }

            else if (int.TryParse(enteredValue, out technicalIntValue_1) == false
            && enteredValue == "back")
            {
                demarcationLine();
                AppExitAnimation();
                technicalBoolValue_1 = true;
            }

            else if (int.TryParse(enteredValue, out technicalIntValue_1) == true)
            {
                demarcationLine();
                technicalIntValue_1 = int.Parse(enteredValue);
                Console.WriteLine($"You entered a number {technicalIntValue_1}");

                do
                {
                    if (technicalIntValue_1 == 0 || technicalIntValue_1 == 1)
                    {
                        Console.WriteLine("It is impossible to determine whether a given number is prime or not.");
                        break;
                    }
                    else
                    {

                        do
                        {
                            for (int i = 1; i < technicalIntValue_1 - 1; i++)
                            {
                                if (technicalIntValue_1 % (i + 1) == 0)
                                {
                                    technicalBoolValue_2 = true;
                                    break;
                                }
                            }
                            if (technicalBoolValue_2 == true || technicalIntValue_1 < 0)
                            {
                                Console.WriteLine($"{technicalIntValue_1} - not a simple number.");
                                technicalBoolValue_1 = true;
                            }
                            else if (technicalBoolValue_2 == false)
                            {
                                Console.WriteLine($"{technicalIntValue_1} - is a simple number");
                                technicalBoolValue_1 = true;
                            }
                        } while (technicalBoolValue_1 == false);
                    }
                } while (technicalBoolValue_1 == false);
            }
        }
        else
        {
            notEnterANumder();
        }
    }
}