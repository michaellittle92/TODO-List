namespace TODO_List;

class Program
{
    private static void Main(string[] args)
    {
        Loading();
        while (true)
        {
            Menu();
        }
       
    }

    private static void Loading()
    {
        Console.WriteLine("Loading........");
        Database db = new Database();
        db.CheckDatabase();
    }

    private static void Menu()
    {
        Console.WriteLine("Todo list app!");
        Console.WriteLine("------------");
        Console.WriteLine("1 - View All Tasks");
        Console.WriteLine("2 - Add New Task");
        Console.WriteLine("3 - Edit Existing Task");
        Console.WriteLine("4 - Delete Existing Task");
        Console.WriteLine("5 - Exit Program");
            
        int userInput = GetValidMenuOption();

        switch (userInput)
        {
            case 1:
                Console.WriteLine("View All Tasks:");
                break;
            case 2:
                Console.WriteLine("Add new Task:");
                break;
            case 3:
                Console.WriteLine("Edit Existing Task:");
                break;
            case 4:
                Console.WriteLine("Delete Existing Task:");
                break;
            case 5:
                Console.WriteLine("Exiting Program");
                    System.Environment.Exit(0); 
                break;
        }
    }

    private static int GetValidMenuOption()
    {
        int userInput;
        while (true)
        {
            Console.WriteLine("Please enter a number between 1 and 5");
            string input = Console.ReadLine();
            if (int.TryParse(input, out userInput) && userInput >= 1 && userInput <= 5)
            {
                break;
            }

            Console.WriteLine("Invalid Input, Please, enter a number between 1 and 5");
        }
        return userInput;
    }
} 