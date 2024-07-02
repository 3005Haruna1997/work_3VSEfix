internal class Program
{
    private static void Main(string[] args)
    {
        // блок основных переменных
        string? enteredValue = "";
        string? menuSelection = "";
        int points = 100;
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
        void backToMenu()
        {
            // Метод для плавного возвращения в меню через анимацию
            for (int j = 3; j > -1; j--)
            {
                foreach (string icon in searchingIcons)
                {
                    Console.Write($"\rBack to menu{icon}");
                    Thread.Sleep(350);
                }
                Console.Write($"\r{new string(' ', Console.BufferWidth)}");
            }
            //techicalValue_2 = true;
        }
        void notEoughPoints()
        {
            // Метод сообщающий о недостатке очков для продолжения игры
            Console.WriteLine($"You have {points} points " +
                              "\nIt's not enough for the game." +
                              "\n(Press \"Enter\" to contine)");
            Console.ReadKey();
            //techicalValue_2 = true;
        }
        void IncorrectData()
        {
            demarcationLine();
            Console.WriteLine("Incorrect Data. Please try again.");
            //enteredValue = Console.ReadLine();
            //enteredValueToLower();
        }

        void enteredValueToLower()
        {
            //Метод для определение введеных данных игнорирую регистр. И для устранения проблемы возможного нулевого референса.
            if (enteredValue != null)
            {
                enteredValue = enteredValue.ToLower();
            }
        }

        void ZeroingValueS()
        {
            //Метод для возврата используемых значений в исходное состояние. 
            //Нужен для корректной работы приложения при многократном воспроизведении в рамках одного рабочего цикла.
            technicalIntValue_1 = 0;
            technicalIntValue_3 = 0;
            technicaIntlValue_2 = 0;
            technicalBoolValue_1 = false;
            technicalBoolValue_2 = false;
            technicalBoolValue_3 = false;
            enteredValue = "";
        }
        void tryParseEnteredValue()
        {
            int a = 0;
            if (int.TryParse(enteredValue, out a) == false || enteredValue == "")
            {
                enteredValueToLower();
                technicalBoolValue_4 = false;
            }
            else
            {
                technicaIntlValue_2 = Convert.ToInt32(enteredValue);
                technicalBoolValue_4 = true;
            }
        }

        Console.WriteLine("Welcome to the \"Guess the number\" game." +
                    $"\nYou have {points} points");
        demarcationLine();
        Console.WriteLine("We have three variants to play the game" +
                         "\n\t 1. (1/3) Three numbers, one try - Cost 15 points with 60 prize points." +
                         "\n\t 2. (2/5) Fife numbers, two  try's - Cost 25 points with 50 prize points." +
                         "\n\t 3. (100/100) One hundred numbers with one hundred try's - Cost 80 points" +
                         "\n\t The prize points ranges from 200 to 10 depending on the number of your attempts.");
        demarcationLine();
        Console.WriteLine("Choose your play option, or enter \"Back\" to return to the menu");

        menuSelection = Console.ReadLine();
        if (menuSelection != null)
        {
            menuSelection = menuSelection.ToLower();
        }
        //enteredValueToLower();

        Console.WriteLine($"You selected game option {menuSelection}.");

        do
        {
            switch (menuSelection)
            {

                case "1":

                    ZeroingValueS();

                    if (points < 16)
                    {
                        notEoughPoints();
                        technicalBoolValue_2 = true;
                    }

                    else
                    {
                        Console.WriteLine("Guess the number from \"1\" to \"3\"" +
                        "or enter \"Back\" to return to the game menu");
                        demarcationLine();
                        points -= 15;
                        Random dice_1 = new Random();
                        int roll_1 = dice_1.Next(1, 4);
                        enteredValue = Console.ReadLine();

                        enteredValueToLower();

                        do
                        {
                            if (int.TryParse(enteredValue, out technicalIntValue_1) == true)
                            {
                                technicalIntValue_1 = Convert.ToInt32(enteredValue);
                                if (roll_1 == technicalIntValue_1)
                                {
                                    points += 60;
                                    Console.WriteLine(">>>You win !<<<" +
                                    $"\nCurrent point's: {points}" +
                                    "\n(Press \"Enter\" to contine)");
                                    Console.ReadKey();
                                    technicalBoolValue_2 = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(">>>You Lose !<<<" +
                                    $"\nCurrent point's: {points}" +
                                    "\n(Press \"Enter\" to contine)");
                                    Console.ReadKey();
                                    technicalBoolValue_2 = true;
                                    break;
                                }
                            }

                            else if (enteredValue == "back")
                            {
                                technicalBoolValue_2 = true;
                                points += 15;
                            }

                            else
                            {
                                IncorrectData();
                                enteredValue = Console.ReadLine();
                            }
                        } while (technicalBoolValue_2 == false);
                    }
                    break;

                case "2":

                    ZeroingValueS();

                    if (points < 26)
                    {
                        notEoughPoints();
                        technicalBoolValue_2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Guess the number from \"1\" to \"5\"" +
                        "or enter \"Back\" to return to the game menu");
                        demarcationLine();
                        points -= 25;
                        Random dice_2 = new Random();
                        int roll_2 = dice_2.Next(1, 6);
                        technicalIntValue_3 = 2;

                        do
                        {
                            enteredValue = Console.ReadLine();
                            tryParseEnteredValue();

                            switch (technicalBoolValue_4)
                            {
                                case true:
                                    if (technicaIntlValue_2 == roll_2)
                                    {
                                        points += 50;
                                        Console.WriteLine(">>>You win !<<<" +
                                        $"\nCurrent point's: {points}" +
                                        "\n(Press \"Enter\" to contine)");
                                        Console.ReadKey();
                                        technicalBoolValue_2 = true;
                                    }
                                    else
                                    {

                                        if (technicalIntValue_1 < 1)
                                            for (int i = 0; i < 1; i++)
                                            {
                                                Console.WriteLine("Wrong answer, you have one more try.");
                                                technicalIntValue_1 += 1;
                                            }
                                        else
                                        {
                                            Console.WriteLine(">>>You Lose !<<<" +
                                            $"\nCurrent point's: {points}" +
                                            "\n(Press \"Enter\" to contine)");
                                            Console.ReadKey();
                                            technicalBoolValue_2 = true;
                                        }
                                    }
                                    break;

                                case false:
                                    if (enteredValue == "back")
                                    {
                                        points += 25;
                                        technicalBoolValue_2 = true;
                                        backToMenu();
                                    }
                                    else
                                    {
                                        IncorrectData();
                                    }
                                    break;
                            }

                        } while (technicalBoolValue_2 == false);
                    }


                    break;

                case "3":

                    ZeroingValueS();

                    if (points < 36)
                    {
                        notEoughPoints();
                        technicalBoolValue_2 = true;
                    }

                    else
                    {
                        Console.WriteLine("Guess the number from \"1\" to \"100\"");
                        demarcationLine();
                        technicalIntValue_3 = 1;
                        int prizePoints = 210;
                        points -= 80;
                        Random dice_3 = new Random();
                        int roll_3 = dice_3.Next(1, 101);

                        do
                        {
                            enteredValue = Console.ReadLine();
                            tryParseEnteredValue();

                            switch (technicalBoolValue_4)
                            {
                                case true:
                                    if (technicaIntlValue_2 == roll_3)
                                    {
                                        prizePoints -= 10;
                                        Console.WriteLine(">>>You win !<<<" +
                                        $"\nCurrent point's: {points + prizePoints}" +
                                        "\n(Press \"Enter\" to contine)");
                                        points += prizePoints;
                                        Console.ReadKey();
                                        technicalBoolValue_2 = true;
                                    }
                                    else
                                    {

                                        while (technicalIntValue_1 < 101)
                                        {
                                            Console.WriteLine("Wrong answer, you have one more try.");
                                            technicalIntValue_1 += 1;
                                            break;
                                        }
                                        switch (technicalIntValue_3)
                                        {
                                            case 1:
                                                prizePoints -= 5;
                                                break;
                                            case 2:
                                                prizePoints -= 1;
                                                break;
                                        }
                                        if (technicalIntValue_1 > 1)
                                        {
                                            technicalIntValue_3 = 1;
                                            if (technicalIntValue_1 > 25)
                                            {
                                                technicalIntValue_3 = 2;
                                            }
                                        }
                                    }
                                    break;
                                case false:
                                    if (enteredValue == "back")
                                    {
                                        points += 80;
                                        technicalBoolValue_2 = true;
                                        backToMenu();
                                    }
                                    else
                                    {
                                        IncorrectData();
                                    }
                                    break;
                            }
                        } while (technicalBoolValue_2 == false);
                    }
                    break;

                case "back":
                    backToMenu();
                    technicalBoolValue_1 = true;
                    technicalBoolValue_2 = true;
                    break;


                default:
                    Console.WriteLine("Not entered numder ! Please try again.");
                    demarcationLine();
                    menuSelection = Console.ReadLine();
                    break;
            }
        } while (technicalBoolValue_2 == false);
    }
}