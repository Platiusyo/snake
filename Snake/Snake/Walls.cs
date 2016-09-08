﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            wallList.Add(new HorizontalLine(0, 78, 0, '+'));
            wallList.Add(new HorizontalLine(0, 78, 24, '+'));
            wallList.Add(new VerticalLine(0, 24, 0, '+'));
            wallList.Add(new VerticalLine(0, 24, 78, '+'));
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}