
class Board
{
//data field
//properties
public int NumberOfRows
{
    get;set;
}
public int NumberOfColmuns
{
    get;set;
}
//constructor
public Board(int aNumberOfRows, int aNumberOfColumns)
{
    NumberOfColmuns = aNumberOfColumns;
    NumberOfRows = aNumberOfRows;
}
//method
public virtual Board GetComposite(){return 0;}
public virtual Add(Board aboard);
public virtual Remove(Board aboard);
public virtual Draw(Board aboard);
}

class Columns : Board
{
//data fields
//properties
//constructor
//method
public virtual Board GetComposite(){return this;}
public virtual Add(Board aboard);
public virtual Remove(Board aboard);
public virtual Draw(Board aboard);
}

class Rows : Board
{
//data fields
//properties
//constructor
//method
public virtual Board GetComposite(){return this;}
public virtual Add(Board aboard);
public virtual Remove(Board aboard);
public virtual Draw(Board aboard);
}

class Cell : Rows
{
//data fields
//properties
//constructor
//method
public virtual Board GetComposite(){return this;}
public virtual Add(Board aboard);
public virtual Remove(Board aboard);
public virtual Draw(Board aboard);
}

class Piece : Cell
{
//data fields
protected char piece1, piece2;
//properties
public virtual char Piece1
{
    get;set;
}
public virtual char Piece2
{
    get;set;
}
//constructor
//method
public virtual Board GetComposite(){return this;}
public void Add(Board aboard)
{
   //check if piece is empty else 
}
public virtual Remove(Board aboard);
public virtual Draw(Board aboard);
}

class SosPiece : Piece
{
//data fields
protected char piece1 = 'X', piece2 = 'O';
//properties
public override char Piece1
{
    get{return piece1;}
}
public virtual char Piece2
{
    get{return piece1;}
}
//constructor
//method
public virtual Board GetComposite(){return this;}
public void Add(Board aboard);
public virtual Remove(Board aboard);
public virtual Draw(Board aboard);
}

class ConnectFourPiece : Piece
{
//data fields
protected char piece1 = 'O', piece2 = 'S';
//properties
public override char Piece1
{
    get{return piece1;}
}
public virtual char Piece2
{
    get{return piece1;}
}
//constructor
//method
public virtual Board GetComposite(){return this;}
public void Add(Board aboard);
public virtual Remove(Board aboard);
public virtual Draw(Board aboard);
}