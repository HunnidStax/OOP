using System;
using System.Collections.Generic;
using System.Text;

namespace Les6_2
{
    public abstract class TwoSizeFigure : Figure
    {
        public TwoSizeFigure(int width, int height)
        {
            base.BoundsSize = new Size(width, height);
        }
        public int Width
        {
            get { return base.BoundsSize.Width; }
            set { base.BoundsSize = new Size(value, base.BoundsSize.Height); }
        }
        public int Height
        {
            get { return base.BoundsSize.Height; }
            set { base.BoundsSize = new Size(base.BoundsSize.Width, value); }
        }
    }

}
