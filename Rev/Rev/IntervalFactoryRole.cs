﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rev
{
    public interface IntervalFactoryRole
    {
        IntervalRole build(int startIndex, int endIndex);
    }
}
