public class UserInterface
{
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello there! welcome to our game.");
        Console.WriteLine("This game framework has two game: Connect Four Game, SOS Game");
        

    }
    public static void DecideGameToPlay()
    {
        Console.WriteLine("Enter 1 for SOS Game. Enter 2 for Connect Four Game.");

    }

    public static void DecideGameMode()
    {
<<<<<<< HEAD
        Console.WriteLine(" Enter 1 for Computer VS Human. Enter 2 for Human Vs Human.");
=======
        Console.WriteLine("Enter 1 for Human . Enter 2 for Computer .");
>>>>>>> 3542fd2228cc8cda39ffb62e258fb54593b70b64

    }
    public static void SOSUserGuild()
    {
        Console.WriteLine("****************************");
        Console.WriteLine("SOS is the 3x3 board game. ");
        Console.WriteLine(" 'R' is redo, 'U' is Undo ");
        Console.WriteLine("enter the number as 1 3 which means raw 1 and colume 3");
        Console.WriteLine("****************************");

    }
    public static void ConnectFourUserGuild()
    {
        Console.WriteLine("****************************");
        Console.WriteLine("ConnectFour is the 7x4 game.");
        Console.WriteLine("'R' is redo, 'U' is undo");
        Console.WriteLine("enter the number as 1 3 which means raw 1 and colume 3");
        Console.WriteLine("****************************");
    }
    public static void Displayplayer1()
    {
        Console.WriteLine("enter first player type:");
        
    }
}