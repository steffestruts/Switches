int option = 20;

switch (option)
{
	case 10:
        Console.WriteLine("Alternativ 1 körs");
        break;
    case <= 50:
        Console.WriteLine("Alternativ 2 körs");
        break;
    default:
        Console.WriteLine("Standard körs");
        break;
}

Console.ReadKey();