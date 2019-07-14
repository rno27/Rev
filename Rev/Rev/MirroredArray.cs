using System;
using System.Collections.Generic;
using System.Text;

namespace Rev
{
    public class MirroredArray : ArrayRole
    {
        private ArrayRole innerArray;
        private IntervalRole interval;

 
    public int getValueAt(int index)
        {

            if (interval.isInInterval(index))
            {
                int mirroredIndex = interval.computeMirroredIndex(index);
                return innerArray.getValueAt(mirroredIndex);
            }
            else
            {
                return innerArray.getValueAt(index);
            }

        }
    }
}
