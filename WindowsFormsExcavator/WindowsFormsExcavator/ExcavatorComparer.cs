using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExcavator
{
    class ExcavatorComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name.Equals(nameof(Excavator)) && y.GetType().Name.Equals(nameof(BucketExcavator)))
            {
                return 1;
            }
            else if (y.GetType().Name.Equals(nameof(Excavator)) && x.GetType().Name.Equals(nameof(BucketExcavator)))
            {
                return -1;
            }
            if (x.MaxSpeed <= y.MaxSpeed)
            {
                return 1;
            }
            else if (x.MaxSpeed > y.MaxSpeed)
            {
                return -1;
            }
            return 0;
        }

        private int ComparerExcavator(Excavator x, Excavator y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerBucketExcavator(BucketExcavator x, BucketExcavator y)
        {
            var res = ComparerExcavator(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.FrontBucket != y.FrontBucket)
            {
                return x.FrontBucket.CompareTo(y.FrontBucket);
            }
            if (x.BackBucket != y.BackBucket)
            {
                return x.BackBucket.CompareTo(y.BackBucket);
            }
            return 0;
        }
    }
}
