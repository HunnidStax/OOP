using System;
using System.Collections.Generic;
using System.Text;

namespace Les6_2
{
    public class Square : SingleSizeFigure
    {
        public Square(int left, int top, int size)
            : base(size)
        {
            base.SetBoundsPosition(new Point(left, top));
        }
        public int Left
        {
            get { return base.GetBoundsPosition().X; }
            set { base.SetBoundsPosition(new Point(base.GetBoundsPosition().X, value)); }
        }
    }
}
