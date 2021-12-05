using System;
using System.Collections.Generic;
using System.Text;

namespace CS155LabWeek11
{
    class File : Document
    {
        private String pathname;

        public File()
        {
            pathname = "";
        }

        public File(String s, String p)
        {
            base.setText(s);
            pathname = p;
        }

        public String Pathname { get => pathname; set => pathname = value; }

        public override String ToString()
        {
            String s;
            s = "Pathname: " + pathname + "\n";
            return s + base.ToString();

        }
    }
}

