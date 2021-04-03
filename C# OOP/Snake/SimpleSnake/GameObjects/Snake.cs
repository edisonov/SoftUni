using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSnake.GameObjects.Foods;
using System.Drawing;
namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private const int SnakeStartLength = 6;
        private const char SnakeSymbol = '\u25CF';
        private const char EmptySpaceSymbol = ' ';

        private readonly Food[] foods;

        private readonly Queue<Point> snakeElements;
        private readonly Wall wall;
        private int NextLeftX;
        private int NextTopY;
        private int foodIndex;

        public Snake(Wall wall)
        {
            this.wall = wall;
            this.snakeElements = new Queue<Point>();
            this.foods = new Food[3];
            this.foodIndex = RandomFoodNumber;

            this.GetFoods();
            this.CreateSnake();
        }

        private int RandomFoodNumber => new Random().Next(0, this.foods.Length);

        public bool IsPointOfWall(Point snake)
        {
            return snake.TopY == 0 || snake.LeftX == 0 || snake.LeftX == this.NextLeftX || snake.TopY == this.NextTopY;
        }

        public bool IsMoving(Point direction)
        {
            Point currentSnakeHead = this.snakeElements.Last();

            GetNextPoint(direction, currentSnakeHead);

            bool isPointOfSnake = this.snakeElements.Any(e => e.LeftX == this.NextLeftX &&
                                                              e.TopY == this.NextTopY);

            if (isPointOfSnake)
            {
                return false;
            }


            Point newSnakeHead = new Point(this.NextLeftX, NextTopY);

            if (this.wall.IsPointOfWall(newSnakeHead))
            {
                return false;
            }

            this.snakeElements.Enqueue(newSnakeHead);
            newSnakeHead.Drow(SnakeSymbol);

            if (this.foods[this.foodIndex].IsFoodPoint(newSnakeHead))
            {
                this.Eat(direction, currentSnakeHead);
            }

            Point snakeTail = this.snakeElements.Dequeue();

            snakeTail.Drow(EmptySpaceSymbol);

            return true;
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int length = this.foods[foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                this.snakeElements.Enqueue(new Point(this.NextLeftX, this.NextTopY));
                GetNextPoint(direction, currentSnakeHead);
            }

            this.foodIndex = RandomFoodNumber;
            this.foods[foodIndex].SetRandomPosition(this.snakeElements);
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.NextLeftX = direction.LeftX + snakeHead.LeftX;
            this.NextTopY = direction.TopY + snakeHead.TopY;
        }

        private void CreateSnake()
        {
            for (int topY = 1; topY <= SnakeStartLength; topY++)
            {
                this.snakeElements.Enqueue(new Point(2, topY));
            }
        }

        private void GetFoods()
        {
            this.foods[0] = new FoodHash(this.wall);
            this.foods[1] = new FoodDollar(this.wall);
            this.foods[2] = new FoodAsterisk(this.wall);
        }

        //public bool IsMoving(System.Drawing.Point direction)
        //{
        //    return true;
        //}
       
    }
}