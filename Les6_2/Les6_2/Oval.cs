using System;
using System.Collections.Generic;
using System.Text;

namespace Les6_2
{
    public class Oval : TwoSizeFigure
    {
        public Oval(int centerX, int centerY, int radiusX, int radiusY)
            : base(radiusX * 2, radiusY * 2)
        {
            base.SetBoundsPosition(new Point(centerX - radiusX, centerY - radiusX));
        }

        // Cвойства CenterX, CenterY, RadiusX, RadiusY
    }
}
