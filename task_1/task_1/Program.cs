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

        string[] searchingIcons = { ".  ", ".. ", "...", };

        techicalStringValue_1 = string.Join("-", Enumerable.Repeat(techicalStringValue_1, 35));

        void demarcationLine()
        {
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

        void enteredValueToLower()
        {
            if (enteredValue != null)
            {
                enteredValue = enteredValue.ToLower();
            }
        }

        void tryParseEnteredValue()
        {
            int a = 0;
            if (int.TryParse(enteredValue, out a) == false || enteredValue == "")
            {
                enteredValueToLower();
                technicalBoolValue_2 = false;
            }
            else
            {
                technicalIntValue_1 = Convert.ToInt32(enteredValue);
                technicalBoolValue_2 = true;
            }
        }

        do
        {
            Console.WriteLine("Пожалуйста, введите число " +
            "(Или введите \"Выход\" для выхода из программы.)");
            enteredValue = Console.ReadLine();

            tryParseEnteredValue();

            switch (technicalBoolValue_2)
            {
                case true:

                    if (technicalIntValue_1 % 2 == 0)
                    {
                        Console.WriteLine($"число {technicalIntValue_1} - четное.");
                        demarcationLine();
                    }

                    else
                    {
                        Console.WriteLine($"Число {technicalIntValue_1} - не четное.");
                        demarcationLine();
                    }

                    break;

                case false:

                    if (enteredValue == "back")
                    {
                        technicalBoolValue_1 = true;
                        AppExitAnimation();
                    }

                    else
                    {
                        Console.WriteLine("Введеные вами данные не верны. Попробуйте еще раз.");
                    }

                    break;
            }
        } while (technicalBoolValue_1 == false);
    }
}