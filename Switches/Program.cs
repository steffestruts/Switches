string option = "2";

switch (option.ToLower())
{
	case "1":
        Console.WriteLine("Alternativ 1 körs");
        break;
    case "2":
        Console.WriteLine("Alternativ 2 körs");
        break;
    case "3":
        Console.WriteLine("Alternativ 3 körs");
        break;
    default:
        Console.WriteLine("Standard körs");
        break;
}

Console.ReadKey();