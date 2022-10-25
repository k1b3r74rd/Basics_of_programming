using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color = " "; char pos;
            int posN, colorN; Console.WriteLine("1. Пешка"); do
            {
                Console.Write("Выберите цвет: 1 - белый, 2 - черный\n"); colorN = int.Parse(Console.ReadLine());
                if (colorN == 1)
                {
                    color = "Белый";
                }
                else if (colorN == 2)
                {
                    color = "Черный";
                }
            }
            while (colorN != 1 && colorN != 2); do
            {
                Console.Write("Выберите букву клетки: A - H\n"); pos = char.Parse(Console.ReadLine());
            }
            while (pos == ' '); do
            {
                Console.Write("Выберите номер клетки (1-8):"); posN = int.Parse(Console.ReadLine());
            }
            while (posN == 0);
            ChessPawn Peshka = new ChessPawn("Пешка", color, pos, posN);
            Console.WriteLine("2. Король"); do
            {
                Console.Write("Выберите цвет: 1 - белый, 2 - черный\n"); colorN = int.Parse(Console.ReadLine());
                if (colorN == 1)
                {
                    color = "Белый";
                }
                else if (colorN == 2)
                {
                    color = "Черный";
                }
            }
            while (colorN != 1 && colorN != 2); do
            {
                Console.Write("Выберите букву клетки: A - H\n"); pos = char.Parse(Console.ReadLine());
            }
            while (pos == ' '); do
            {
                Console.Write("Выберите номер клетки (1-8):"); posN = int.Parse(Console.ReadLine());
            }
            while (posN == 0);
            ChessKing Korol = new ChessKing("Король", color, pos, posN);
            Console.WriteLine("3. Слон"); do
            {
                Console.Write("Выберите цвет: 1 - белый, 2 - черный\n"); colorN = int.Parse(Console.ReadLine());
                if (colorN == 1)
                {
                    color = "Белый";
                }
                else if (colorN == 2)
                {
                    color = "Черный";
                }
            }
            while (colorN != 1 && colorN != 2); do
            {
                Console.Write("Выберите букву клетки: A - H\n"); pos = char.Parse(Console.ReadLine());
            }
            while (pos == ' '); do
            {
                Console.Write("Выберите номер клетки (1-8):"); posN = int.Parse(Console.ReadLine());
            }
            while (posN == 0);
            ChessBishop Slon = new ChessBishop("Слон", color, pos, posN);
            Console.WriteLine("4. Ладья"); do
            {
                Console.Write("Выберите цвет: 1 - белый, 2 - черный\n"); colorN = int.Parse(Console.ReadLine());
                if (colorN == 1)
                {
                    color = "Белый";
                }
                else if (colorN == 2)
                {
                    color = "Черный";
                }
            }
            while (colorN != 1 && colorN != 2); do
            {
                Console.Write("Выберите букву клетки: A - H\n"); pos = char.Parse(Console.ReadLine());
            }
            while (pos == ' '); do
            {
                Console.Write("Выберите номер клетки (1-8):"); posN = int.Parse(Console.ReadLine());
            }
            while (posN == 0);
            ChessRook Ladya = new ChessRook("Ладья", color, pos, posN); ChessMan[] chessFigure = new ChessMan[4] { Peshka, Korol, Slon, Ladya }; foreach (ChessMan piece in chessFigure)
            {
                Console.WriteLine(piece);
            }
            Korol.Castling(Peshka, Ladya, Slon);
        }
    }
    abstract class ChessMan
    {
        public ChessMan()
        {
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public char Position { get; set; }
        public int PositionNumb { get; set; }
        public string PossibleMoves { get; set; }
        public override string ToString()
        {
            return $"Имя фигуры: {Name}; Цвет: {Color}; Позиция: {Position} - {PositionNumb}; Возможные ходы: {PossibleMoves}";
        }
    }
    abstract class MinorPiece : ChessMan
    {
        public MinorPiece() { }
        public string Type { get; private set; } = "Легкая фигура"; public override string ToString()
        {
            return $"Имя фигуры: {Name}; Тип: {Type}; Цвет: {Color}; Позиция: {Position} - {PositionNumb}; Возможные ходы: {PossibleMoves}";
        }
    }
    abstract class HeavyPiece : ChessMan
    {
        public HeavyPiece() { }
        public string Type { get; private set; } = "Тяжелая фигура"; public override string ToString()
        {
            return $"Имя фигуры: {Name}; Тип: {Type}; Цвет: {Color}; Позиция: {Position} - {PositionNumb}; Возможные ходы: {PossibleMoves}";
        }
    }
    class ChessPawn : ChessMan
    {
        public ChessPawn(string name, string color, char position, int pos)
        {
            Name = name; Color = color; Position = position; PositionNumb = pos; if (pos == 2)
                PossibleMoves = $"{position}-3, {position}-4";
            else
            {
                PossibleMoves = $"{position}-{pos + 1};";
            }
        }
    }
    class ChessKing : ChessMan
    {
        public ChessKing(string name, string color, char position, int pos)
        {
            Name = name; Color = color; Position = position; PositionNumb = pos;
            if (pos > 1 && pos < 8)
                PossibleMoves = $"В любую клетку на 1 шаг";
            else
            {
                PossibleMoves = $"В любую клетку на 1 шаг, кроме края";
            }
        }
        public void Castling(ChessMan Korol, ChessMan Ladya, ChessMan Slon)
        {
            ChessMan[] CheckCastling = new ChessMan[2] { Korol, Slon }; bool checkPos = true;
            if (Position == 'E' && (PositionNumb == 8) && Color == "Черный")
            {
                if (Ladya.Position == 'A' && Ladya.PositionNumb == 8 && Ladya.Color == "Черный")
                {
                    foreach (var a in CheckCastling)
                    {
                        if (a.PositionNumb == 8 && (a.Position == 'B' || a.Position == 'C' || a.Position == 'D'))
                        {
                            checkPos = false;
                        }
                    }
                }
                else if (Ladya.Position == 'H' && Ladya.PositionNumb == 8 && Ladya.Color == "Черный")
                {
                    foreach (var a in CheckCastling)
                    {
                        if (a.PositionNumb == 8 && (a.Position == 'F' || a.Position == 'G'))
                        {
                            checkPos = false;
                        }
                    }
                }
            }
            else if (Position == 'E' && (PositionNumb == 1) && Color == "Белый")
            {
                if (Ladya.Position == 'A' && Ladya.PositionNumb == 1 && Ladya.Color == "Белый")
                {
                    foreach (var a in CheckCastling)
                    {
                        if (a.PositionNumb == 1 && (a.Position == 'B' || a.Position == 'C' || a.Position == 'D'))
                        {
                            checkPos = false;
                        }
                    }
                }
                else if (Ladya.Position == 'H' && Ladya.PositionNumb == 1 && Ladya.Color == "Белый")
                {
                    foreach (var a in CheckCastling)
                    {
                        if (a.PositionNumb == 1 && (a.Position == 'F' || a.Position == 'G'))
                        {
                            checkPos = false;
                        }
                    }
                }
                else Console.WriteLine("Рокировка невозможна!");
            }
            if (checkPos)
            {
                Console.WriteLine("Рокировка возможна!");
            }
            else Console.WriteLine("Рокировка невозможна!");
        }
    }
    class ChessBishop : MinorPiece
    {
        public ChessBishop(string name, string color, char position, int pos)
        {
            Name = name; Color = color; Position = position; PositionNumb = pos;
            PossibleMoves = $"По диагонали в любую сторону";
        }
    }
    class ChessRook : HeavyPiece
    {
        public ChessRook(string name, string color, char position, int pos)
        {
            Name = name; Color = color; Position = position; PositionNumb = pos;
            PossibleMoves = $"По вертикали и горизонтали в любую сторону";
        }

    }
}
