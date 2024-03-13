using administratieProgammaVoorHetEchtDezeKeer;
//Console.ForegroundColor = ConsoleColor.Green;

//initialise things
Functions f = new Functions();
bool running = true;
Console.WriteLine("Welcome to the menu to continue press the correct number corresponding to your preferred action, followed up by pressing enter!");


while ( running )
{
    
    Console.WriteLine(
        "\n \n 1. Add Customer" +
        "\n 2. View Customer info" +
        "\n 3. edit Customer" +
        "\n 4. Remove Customer" +
        "\n 5. Exit program\n"
        );


    //split command and its suffix
    string playerInput = Console.ReadLine();
    string[] suffix = playerInput.Split(' ');
    string customerName = "";
    for (int i = 1; i < suffix.Length; i++)
    {
        customerName += suffix[i]+ " ";
    }

    //handle commands
    string id = f.FindCustomer(customerName);
    switch (suffix[0])
    {
        case "1":
            //add customer
            f.AddCustomer();
            break;
        case "2":
            // view customers
            if (id.Contains('-'))
            {
                f.ViewCustomer(id);
            }
            else
            {
                f.ViewCustomer();
            }
            break;
        case "3":
            // edit customer
            if (id.Contains('-'))
            {
                f.EditCustomer(id);
            }
            else
            {
                Console.WriteLine(id);
            }
            break;
        case "4":
            //delete customer
            if (id.Contains('-'))
            {
                f.DeleteCustomer(id);
            }
            else
            {
                Console.WriteLine(id);
            }
            break;
        case "5":
            //exit program
            running = false;
            break;

        default:
            //handle exception
            Console.WriteLine($"'{suffix[0]}' is not recognized as a command!");
            break;
    }

} 





   








/*
//1. new person maken
Person aa = new Person("FRANK", "STEEN", 20);

//1.1. meten is weten
Console.WriteLine($"Name: \t\t{aa.GetName()}\n  lastName:\t{aa.GetLastName()}\n  age:\t\t{aa.GetAge()}");

//1.2. nog een person maken
Person bb = new Person("JAN", "EEND", 40);
Console.WriteLine($"Name: \t\t{bb.GetName()}\n  lastName:\t{bb.GetLastName()}\n  age:\t\t{bb.GetAge()}");

//1.3. een array aan personen aanmaken en alle personen toevoegen


//2. input vragen aan gebruiker



//3. instantieren van personen op basis van gebruiker input
*/