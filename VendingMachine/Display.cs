using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class Display
    {
        // represents the text to show on the display
        public string Text { get; set; }

        // indicates that there are more messages to be displayed after this one
        public bool MoreMessages { get; set; }
    }
}
