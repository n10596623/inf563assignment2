
class Board
{
//data field 
private string boardName;
private int rows;
private int colums;
private string symbols;

//propoties
public int Rows 
{
    get;set;
}
public int Colums 
{
    get;set;
    
}
public string Symbols 
{
    get;set;
}
public string BoardName
{
    get;set;
}
// constructure
public Board(){}
public Board(string boardName,int rows,int colums, string symbols)
{
    boardName = BoardName;
    rows = Rows;
    colums = Colums;
    symbols = Symbols;

} 
//method
public static void draw()
{
        Board sos = new Board{BoardName="SOS",Rows=3,Colums=3,Symbols="-"};
        Board connectfour = new Board{BoardName="ConnectFour",Rows=7,Colums=4,Symbols="-"};
        for (int i=0;i<sos.Rows;i++)
        {
            Console.WriteLine(sos.Symbols);
        }
}
}