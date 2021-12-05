using System;
using System.Collections.Generic;
using System.Text;

namespace CS155LabWeek11
{
    class Document
    {
        private String text;

        public Document()
        {
            text = "";
        }

        public Document(String s)
        {
            text = s;
        }

        public void setText(String s) 
        {
            text = s;
        }

        public override String ToString() 
        {
            return text;
        }
    }
}
