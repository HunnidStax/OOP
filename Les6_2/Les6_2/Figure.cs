using System;
using System.Collections.Generic;
using System.Text;

namespace Les6_2
{
    public abstract class Figure
    {
        public Point BoundsPosition { get; set; }
        public Size BoundsSize { get; protected set; }
        public Point GetBoundsPosition()
        {
            return BoundsPosition;
        }

        public void SetBoundsPosition(Point value)
        {
            BoundsPosition = value;
        }
        public void Move(int deltaX, int deltaY)
        {
            this.SetBoundsPosition(new Point(this.GetBoundsPosition().X + deltaX, this.GetBoundsPosition().Y + deltaY));
        }
    }
}
