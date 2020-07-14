using System;

namespace QueenAttack.Models {

  public class Queen
  {
    public int CoordinateX {get; set;}
    public int CoordinateY {get; set;}

    public Queen(int x, int y)
    {
      CoordinateX = x;
      CoordinateY = y;
    }

    public bool IsAttacking(int xChessPiece, int yChessPiece) 
    {
      if(xChessPiece == this.CoordinateX || yChessPiece == this.CoordinateY) 
      {
        return true;
      } 
      else if (Math.Abs(this.CoordinateX - xChessPiece) == Math.Abs(this.CoordinateY - yChessPiece))
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  }
}