using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// The player is a snake.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The length (number of segments of the snake)
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// The head of the snake
        /// </summary>
        public Point Position { get; private set; } = new Point(5,5);

        public Direction Direction { get; set; }


        public void Move()
        {
            if (Direction == Direction.Up)
            {
                Position = new Point(Position.X, Position.Y - 1);
            }
            if (Direction == Direction.Down)
            {
                Position = new Point(Position.X, Position.Y + 1);
            }
            if (Direction == Direction.Right)
            {
                Position = new Point(Position.X + 1, Position.Y);
            }
            if (Direction == Direction.Left)
            {
                Position = new Point(Position.X - 1, Position.Y);
            }
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

}
