internal class Program
{
    private static void Main(string[] args)
    {
        // блок основных переменных
        string? enteredValue = "";
        // блок вспомогательных переменных

        string techicalStringValue_1 = "-";

        bool technicalBoolValue_1 = false;
        bool technicalBoolValue_2 = false;
        bool technicalBoolValue_3 = false;

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

        void enteredValueToLower()
        {
            //Метод для определение введеных данных игнорирую регистр. И для устранения проблемы возможного нулевого референса.
            if (enteredValue != null)
            {
                enteredValue = enteredValue.ToLower();
            }
        }

        void enteredValueToUpper()
        {
            if (enteredValue != null)
            {
                enteredValue = enteredValue.ToUpper();
            }
        }



        do
        {
            Console.WriteLine
            ("Подсчет суммы карт в 21 " +
             "\nВведи \"Yes\" или \"No\".");
            //enteredValue = Console.ReadLine();

            enteredValue = Console.ReadLine();

            enteredValueToLower();

            switch (enteredValue)
            {
                case "yes":
                    Console.WriteLine("Добро пожаловать в казинакич." +
                    "\nВведи значения карты.");
                    demarcationLine();
                    int sumOfCards = 0;
                    int cardValue = -1;
                    string[] acceptableValuesOfPlayingCards = { "6", "7", "8", "9", "10", "J", "Q", "K", "T" };
                    int[] CostOfCardsInPoints = { 6, 7, 8, 9, 10, 2, 3, 4, 10 };
                    do
                    {
                        enteredValue = Console.ReadLine();
                        enteredValueToUpper();
                        do
                        {
                            cardValue = -1;//с -1 для верной работы
                            technicalBoolValue_3 = false;
                            foreach (string valueOfCard in acceptableValuesOfPlayingCards)
                            {
                                cardValue += 1;
                                if (enteredValue == valueOfCard)
                                {
                                    technicalBoolValue_3 = true;
                                    sumOfCards += CostOfCardsInPoints[cardValue];
                                    break;
                                }
                            }
                            if (technicalBoolValue_3 == false)
                            {
                                Console.WriteLine("Что-то тут не сходиться..." +
                                "\nПопробуй еще раз.");
                                demarcationLine();
                                enteredValue = Console.ReadLine();
                                enteredValueToUpper();
                            }
                        } while (technicalBoolValue_3 == false);
                        Console.WriteLine("Карта принята." +
                        $"\nСтоимость карты в очках :{CostOfCardsInPoints[cardValue]}" +
                        $"\nСумма карт на руках :{sumOfCards}");
                        demarcationLine();
                        if (sumOfCards == 21)
                        {
                            Console.WriteLine("Поздравляю, с победой.");
                            demarcationLine();
                            technicalBoolValue_2 = true;
                        }
                        else if (sumOfCards > 21)
                        {
                            Console.WriteLine("Не повезло..");
                            demarcationLine();
                            technicalBoolValue_2 = true;
                        }
                    } while (technicalBoolValue_2 == false);
                    break;

                case "no":
                    Console.WriteLine("Ну и зря.");
                    AppExitAnimation();
                    technicalBoolValue_1 = true;
                    break;

                default:
                    Console.WriteLine("Не понял...");
                    enteredValue = Console.ReadLine();
                    demarcationLine();
                    break;
            }
        } while (technicalBoolValue_1 == false);
    }
}