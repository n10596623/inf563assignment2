using System.Data;

namespace ifn563_object;
class program
{
        static void Main(string[] args)
    {
        Board sos = new Board{BoardName="SOS",Rows=3,Colums=3,RowSymbols="-----",ColSymbols="|"};

        game.CreateNewGame();
        // review how we draw the board
        //Board.draw(sos);
        
    }
    public static void DeletePlayer()
    {
    
    }
    public static void CreateNewPlayer()
    {
    
    }
    
}