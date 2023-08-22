

while (true)
{
    char str1;

    Console.Write("Enter the Alphabet : ");
    try
    {
        str1 = Console.ReadLine()[0];
    }
    catch
    {
        Console.WriteLine("Found empty input exiting");
        break;
    }


    if ((str1 == 'A' || str1 == 'a') || (str1 == 'E' || str1 == 'e') || (str1 == 'i' || str1 == 'I') ||
        (str1 == 'o' || str1 == 'O') || (str1 == 'u' || str1 == 'U'))
    {
        Console.WriteLine("You have entered a volwel");
    }
    else
    {
        Console.WriteLine("You have entered a consonent");
    }

    if (char.ToUpper(str1) == str1)
    {
        Console.WriteLine("The given letter to capital");
    }
    else
    {
        Console.WriteLine("The given letter to small");
    }
}