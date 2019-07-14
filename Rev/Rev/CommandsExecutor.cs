using System;
using System.Collections.Generic;
using System.Text;

namespace Rev
{
    public class CommandsExecutor
    {
        private InputRole input;
        private Map<Integer, HandlerRole> dispatcher;

        public void runCommands()
        {

            while (input.hasMoreData())
            {

                int commandCode = input.readInt();
                HandlerRole commandHandler = dispatcher.get(commandCode);

                commandHandler.handle();
            }

        }
    }
}
