
class Board
{
//data field 
private string boardName;
private int rows;
private int colums;
private string rowsymbols;
private string colsymbols;

//propoties
public int Rows 
{
    get;set;
}
public int Colums 
{
    get;set;
    
}
public string RowSymbols 
{
    get;set;
}
public string ColSymbols 
{
    get;set;
}
public string BoardName
{
    get;set;
}
// constructure
public Board(){}
public Board(string boardName,int rows,int colums, string rowsymbols,string colsymbols)
{
    boardName = BoardName;
    rows = Rows;
    colums = Colums;
    rowsymbols = RowSymbols;
    colsymbols = ColSymbols;

} 
//method
public static void draw()
{
        Board sos = new Board{BoardName="SOS",Rows=3,Colums=3,RowSymbols="-",ColSymbols="|"};
        Board connectfour = new Board{BoardName="ConnectFour",Rows=7,Colums=4,RowSymbols="-",ColSymbols="|"};
        for (int i=0;i<sos.Rows;i++)
        {
            Console.WriteLine(sos.rowsymbols);
            Console.WriteLine(sos.ColSymbols);
        }
}
}