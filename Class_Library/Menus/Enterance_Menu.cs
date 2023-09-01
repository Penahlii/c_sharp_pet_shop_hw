namespace Class_Library.Menus;

public class Enterance_Menu
{
    public static void start(string[] menu_choices, Pet_Shop pet_shop)
    {
        int select_choice = 0;
        bool menu_check = true;

        while (menu_check)
        {
            Console.Clear();
            print_menu(menu_choices, select_choice);

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    select_choice = (select_choice - 1 + menu_choices.Length) % menu_choices.Length;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    select_choice = (select_choice + 1) % menu_choices.Length;
                    break;
                case ConsoleKey.Enter:
                    start_operation(menu_choices[select_choice]);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    menu_check = false;
                    break;
            }
        }

        static void print_menu(string[] menu_choices, int select_choice)
        {
            Console.Clear();
            Console.WriteLine();

            for (int i = 0; i < menu_choices.Length; i++)
            {
                if (i == select_choice)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(">> ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("   ");
                }

                Console.WriteLine(menu_choices[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress Enter to select operation or Esc to exit.");
        }

        void start_operation(string select_choice)
        {
            switch (select_choice)
            {
                case "Dog":
                    Console.Clear();
                    Console.Write("Enter Dog's ID to start curing: ");
                    string? ID = Console.ReadLine();
                    foreach(var dog in pet_shop.Dogs)
                    {

                    }
                    break;
                //case "Divide":
                //    if (num2 != 0)
                //    {
                //        result = divide(num1, num2);
                //        Console.WriteLine($"{num1} / {num2} = {result}");
                //    }
                //    else
                //        Console.WriteLine("Cannot divide by zero.");
                //    break;
                //case "Multiply":
                //    result = multiply(num1, num2);
                //    Console.WriteLine($"{num1} * {num2} = {result}");
                //    break;
                //case "Subtract":
                //    result = substract(num1, num2);
                //    Console.WriteLine($"{num1} - {num2} = {result}");
                //    break;
                //case "Plus":
                //    result = plus(num1, num2);
                //    Console.WriteLine($"{num1} + {num2} = {result}");
                //    break;
            }
        }
    }
}
