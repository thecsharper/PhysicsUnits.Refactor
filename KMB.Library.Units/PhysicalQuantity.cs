﻿using System;

namespace KMB.Library.Units
{
    public readonly partial struct PhysicalQuantity: IPhysicalQuantity
    {
        public double Value { get; init; }
        public Dimensions Dimensions { get; init; }

        public PhysicalQuantity(double v, Dimensions d)
        {
            Value = v;
            Dimensions = d;
        }

        public PhysicalQuantity(IPhysicalQuantity q)
        {
            Value = q.Value;
            Dimensions = q.Dimensions;
        }

        public override string ToString()
        {
            return UnitsSystem.ToString(this);
        }

        public static int Compare(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            if (v1.Dimensions != v2.Dimensions)
                throw new Exception($"Dimension mismatch: {v1.Dimensions} {v2.Dimensions}");
            double d1 = v1.Value;
            double d2 = v2.Value;
            if (d1 < d2)
                return -1;
            else if (d1 > d2)
                return 1;
            else
                return 0;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is IPhysicalQuantity)
            {
                IPhysicalQuantity pq = obj as IPhysicalQuantity;
                return Compare(this, pq) == 0;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)Value;
        }

        public static bool operator ==(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            return Compare(v1, v2) == 0;
        }

        public static bool operator !=(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            return Compare(v1, v2) != 0;
        }

        public static bool operator >(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            return Compare(v1, v2) > 0;
        }

        public static bool operator >=(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            return Compare(v1, v2) >= 0;
        }

        public static bool operator <=(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            return Compare(v1, v2) <= 0;
        }

        public static bool operator <(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            return Compare(v1, v2) < 0;
        }

        public static PhysicalQuantity operator +(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            if (v1.Dimensions != null && v1.Dimensions != v2.Dimensions)
                throw new Exception($"Dimension mismatch: {v1.Dimensions} {v2.Dimensions}");
            return new PhysicalQuantity(v1.Value + v2.Value, v2.Dimensions);
        }

        public static PhysicalQuantity operator -(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            if (v1.Dimensions != v2.Dimensions)
                throw new Exception($"Dimension mismatch: {v1.Dimensions} {v2.Dimensions}");
            return new PhysicalQuantity(v1.Value - v2.Value, v1.Dimensions);
        }

        public static PhysicalQuantity operator *(PhysicalQuantity v1, double v2)
        {
            return new PhysicalQuantity(v1.Value * v2, v1.Dimensions);
        }

        public static PhysicalQuantity operator *(double v1, PhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1 * v2.Value, v2.Dimensions);
        }

        public static PhysicalQuantity operator *(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value * v2.Value, v1.Dimensions * v2.Dimensions);
        }

        public static PhysicalQuantity operator /(PhysicalQuantity v1, double v2)
        {
            return new PhysicalQuantity(v1.Value / v2, v1.Dimensions);
        }

        public static PhysicalQuantity operator /(PhysicalQuantity v1, IPhysicalQuantity v2)
        {
            return new PhysicalQuantity(v1.Value / v2.Value, v1.Dimensions / v2.Dimensions);
        }

        public static PhysicalQuantity operator ^(PhysicalQuantity v, short p)
        {
            return new PhysicalQuantity(Math.Pow(v.Value, p), v.Dimensions ^ p);
        }
    }
}
