using System;
using System.Collections.Generic;
using System.Text;

namespace Rev
{
    public class DisplayHandler : HandlerRole
    {
        private InputRole input;
        private ArrayRole array;
        private OutputRole output;


    public void handle()
        {

            int index = input.readInt();
            int value = array.getValueAt(index);
            output.print(value);
        }
    }
}
