﻿using System;
using System.Drawing;

namespace Shapes
{
    public class Circle
    {
        double radius;
        /*
        public Circle() //생성자 
        {
            radius = 0;
        }*/
        public Circle(double radius = 0)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * (radius * radius);
        }
        public void Draw()
        {
            Pen p = new Pen(Color.Red);
        }
    }
}
