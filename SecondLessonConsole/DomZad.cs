namespace SecondLessonConsole;

public class DomZad
{
    public static void DomZadPrint()
    {
        string stop = "";

        while (stop != "stop")
        {
            Console.WriteLine("Choose a subject: math or chemistry (type 'stop' to exit)");
            string subject = Console.ReadLine();

            if (subject == "stop")
            {
                stop = "stop";
                break;
            }

            switch (subject)
            {
                case "math":
                    Console.WriteLine("3 + 4 = ?");
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a == 7)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    break;

                case "chemistry":
                    Console.WriteLine("H2O is the chemical formula for what?");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "water")
                    {
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown subject.");
                    break;
            }
        }
    }
}