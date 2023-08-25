
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
// fOR REVIEW LATER!!!!!!!!
//Place drawRow and drawColumn in the game class
/*public static void draw(Board sos)
{
        
        
        for(int k=0;k<sos.rows;k++){
                Board.drawRow(sos);
        }

}
public static void drawRow(Board sos){
    
    for (int i=0;i<sos.Rows;i++)
        {
            Console.Write(sos.ColSymbols);
            
           for (int j=0;j<sos.Colums;j++)
           {
            
            Console.Write(sos.RowSymbols);
           }
        }
}*/
}