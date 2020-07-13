using System;
using QueenAttack.Models;

namespace QueenAttack {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Input the X coordinate of queen: ");
      int xCoordinate = int.Parse(Console.ReadLine());
      Console.WriteLine("Input the Y coordinate of queen: ");
      int yCoordinate = int.Parse(Console.ReadLine());
      Console.WriteLine("Input the X coordinate of attacking chess piece: ");
      int xChessPiece = int.Parse(Console.ReadLine());
      Console.WriteLine("Input the Y coordinate of attacking chess piece: ");
      int yChessPiece = int.Parse(Console.ReadLine());
      Queen queen = new Queen(xCoordinate, yCoordinate);
      if(queen.IsAttacking(xChessPiece, yChessPiece)) 
      {
        Console.WriteLine("Yes, you can attack this chess piece");
      }
      else
      {
        Console.WriteLine("No, you can't attack this chess piece");
      }
    }
  }
}