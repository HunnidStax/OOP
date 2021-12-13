using System;
using System.Collections.Generic;
using System.Text;

namespace Les6_2
{
    public class Rectangle : TwoSizeFigure
    {
        public Rectangle(int left, int top, int width, int height)
            : base(width, height)
        {
            base.SetBoundsPosition(new Point(left, top));
        }

        //public GetArea()
        //{

        //}
    }
}
