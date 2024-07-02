internal class Program
{
    private static void Main(string[] args)
    {
        // блок основных переменных
        string? enteredValue = "";

        // блок вспомогательных переменных
        int technicalIntValue_1 = 0;
        int technicaIntlValue_2 = 0;
        int technicalIntValue_3 = 0;

        string techicalStringValue_1 = "-";

        bool technicalBoolValue_1 = false;
        bool technicalBoolValue_2 = false;
        bool technicalBoolValue_3 = false;
        bool technicalBoolValue_4 = false;

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


        Console.WriteLine("Please enter the length of the sequence," +
                        " or enter \"Back\" to return to the menu");
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
            else
            {
                technicalIntValue_3 = int.Parse(enteredValue);
                int[] sequenceLength = new int[technicalIntValue_1];

                for (int i = 0; i < technicalIntValue_3; i++)
                {
                    Console.WriteLine($"Enter number № {i + 1}");
                    enteredValue = Console.ReadLine();
                    do
                    {
                        if (enteredValue != "" && int.TryParse(enteredValue, out technicalIntValue_1) == true)
                        {
                            sequenceLength[i] = int.Parse(enteredValue);
                            technicalBoolValue_2 = true;
                        }
                        else
                        {
                            while (enteredValue == "" || int.TryParse(enteredValue, out technicalIntValue_1) == false)
                            {
                                notEnterANumder();
                                Console.WriteLine($"Enter number № {i + 1}");
                                enteredValue = Console.ReadLine();
                            }
                            sequenceLength[i] = int.Parse(enteredValue);
                            technicalBoolValue_2 = true;
                        }
                    } while (technicalBoolValue_2 == false);
                }

                Array.Sort(sequenceLength);
                Console.Write("The sorted sequence: ");

                foreach (int sequence in sequenceLength)
                {
                    Console.Write(sequence + ", ");
                }

                Console.WriteLine($"\nMinimum value in the sequence: {sequenceLength[0]}");
                demarcationLine();
            }
        }
        else
        {
            notEnterANumder();
        }
    }
}