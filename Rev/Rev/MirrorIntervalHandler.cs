using System;
using System.Collections.Generic;
using System.Text;

namespace Rev
{
    public class MirrorIntervalNumber: HandlerRole
    {
        private InputRole input;
        private MirroredArrayRole array;
        private IntervalFactoryRole intervalFactory;


    public void handle()
        {
            int startIndex = input.readInt();
            int endIndex = input.readInt();
            IntervalRole interval = intervalFactory.build(startIndex, endIndex);

            array.mirrorInterval(interval);

        }
    }
}
