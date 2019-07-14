using System;
using System.Collections.Generic;
using System.Text;

namespace Rev
{
    public class MirroredInterval : IntervalRole
    {
        private int startIndex;
        private int endIndex;

        public bool isInInterval(int index)
        {

            return startIndex <= index && index <= endIndex;
        }

        public int computeMirroredIndex(int index)
        {

            return endIndex - index + startIndex;
        }
    }
}
