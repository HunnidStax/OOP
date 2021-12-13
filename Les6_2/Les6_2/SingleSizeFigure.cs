using System;
using System.Collections.Generic;
using System.Text;

namespace Les6_2
{
    public abstract class SingleSizeFigure : Figure
    {
        public SingleSizeFigure(int size)
        {
            this.Size = size;
        }

        public int Size
        {
            get { return base.BoundsSize.Width; }
            set { base.BoundsSize = new Size(value, value); }
        }
    }
}
