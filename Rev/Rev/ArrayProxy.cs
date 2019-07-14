using System;
using System.Collections.Generic;
using System.Text;

namespace Rev
{
    public class ArrayProxy : ArrayRole , MirroredArrayRole
    {
        private ArrayRole innerArray;
        private ArrayFactoryRole arrayFactory;

    public void mirrorInterval(IntervalRole interval)
        {
            innerArray = arrayFactory.build(innerArray, interval);

        }

    public int getValueAt(int index)
        {
            return innerArray.getValueAt(index);
        }
    }
}
