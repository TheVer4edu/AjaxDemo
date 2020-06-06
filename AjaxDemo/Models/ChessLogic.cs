using System;

namespace AjaxDemo.Models
{
    public class ChessLogic
    {
        public static bool Pawn(int x1, int y1, int x2, int y2) //Пешка
        {
            return x2 == x1 && (Math.Abs(y2 - y1) == 2 || Math.Abs(y2 - y1) == 1);
        }
        
        public static bool Bishop(int x1, int y1, int x2, int y2) //Слон
        {
            return Math.Abs(x2 - x1) == Math.Abs(y2 - y1) && x2 != x1;
        }
        
        public static bool King(int x1, int y1, int x2, int y2) //Король
        {
            return (Math.Abs(x2 - x1) <= 1 || Math.Abs(y2 - y1) <= 1) && Math.Abs(x2 - x1) + Math.Abs(y2 - y1) != 0;
        }
        
        public static bool Queen(int x1, int y1, int x2, int y2) //Королева
        {
            return Rook(x1, y1, x2, y2) || Bishop(x1, y1, x2, y2);
        }
        
        public static bool Knight(int x1, int y1, int x2, int y2) //Конь
        {
            return Math.Abs(x2 - x1) + Math.Abs(y2 - y1) == 3 && x2 != x1 && y2 != y1;
        }
        
        public static bool Rook(int x1, int y1, int x2, int y2) //Ладья
        {
            return x2 == x1 ^ y2 == y1;
        }
    }
}