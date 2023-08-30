
using System.Security.Cryptography;

class Board
{
    
/*//data field 
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
    

} */ 

//method
// fOR REVIEW LATER!!!!!!!!

//Place drawRow and drawColumn in the game class
    public static void SOSBoardArray(out int[] SosBoard)
    {
        SosBoard = new int[] {1,2,3,4,5,6,7,8,9};
    }
        public static void ConnectFourBoardArray(out int[] ConnectFourBoard)
    {
        ConnectFourBoard = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28};
    }

}