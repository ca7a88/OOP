using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorOOP_ClasaAbstractPoint
{
    public class Point : AbstractPoint
    {
        private double radius, angle;

        public Point(PointRepresentation pr, double n1, double n2)
        {
            if (pr == PointRepresentation.Polar)
            {
                radius = n1; angle = n2;
            }
            else if (pr == PointRepresentation.Rectangular)
            {
                radius = RadiusGivenXy(n1, n2);
                angle = AngleGivenXy(n1, n2);
            }
            else
            {
                throw new Exception("Should not happen");
            }
        }

        public override double X
        {
            get
            {
                return XGivenRadiusAngle(radius, angle);
            }
            set
            {
                double yBefore = YGivenRadiusAngle(radius, angle);
                angle = AngleGivenXy(value, yBefore);
                radius = RadiusGivenXy(value, yBefore);
            }
        }
        public override double Y
        {
            get
            {
                return YGivenRadiusAngle(radius, angle);
            }
            set
            {
                double xBefore = XGivenRadiusAngle(radius, angle);
                angle = AngleGivenXy(xBefore, value);
                radius = RadiusGivenXy(xBefore, value);
            }
        }
        public override double R
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public override double A
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
            }
        }
    }
}
