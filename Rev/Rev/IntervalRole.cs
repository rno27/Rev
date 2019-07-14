using System;
using System.Collections.Generic;
using System.Text;

namespace Rev
{
    public interface IntervalRole
    {
        bool isInInterval(int index);

        int computeMirroredIndex(int index);
    }
}
