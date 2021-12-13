using System;
using System.Collections.Generic;
using System.Text;

namespace Les6_2
{
    public class Circle : SingleSizeFigure
    {
        public Circle(int centerX, int centerY, int radius)
            : base(radius * 2)
        {
            base.SetBoundsPosition(new Point(centerX - radius, centerY - radius));
        }
        public int Radius
        {
            get { return base.Size / 2; }
            set { base.Size = value * 2; }
        }
        public int CenterX
        {
            get { return base.GetBoundsPosition().X + this.Radius; }
            set { base.SetBoundsPosition(new Point(value - this.Radius, base.GetBoundsPosition().Y)); }
        }
    }
}
