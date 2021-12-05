using System;
using System.Collections.Generic;
using System.Text;

namespace CS155LabWeek11
{
    class Email :  Document
    {
        private String sender;
        private String recipient;
        private String titleofmessage;

        public Email()
        {
            sender = "";
            recipient = "";
            titleofmessage = "";
        }

        public Email(String txt, String s, String r, String t)
        {
            base.setText(txt);
            sender = s;
            recipient = r;
            titleofmessage = t;
        }

        public String Sender { get => sender; set => sender = value; }
        public String Recipient { get => recipient; set => recipient = value; }
        public String Title { get => titleofmessage; set => titleofmessage = value; }

        public override String ToString()
        {
            String s;
            s = "Sender: " + sender + "\n";
            s = s + "Recipient: " + recipient + "\n";
            s = s + "Title: " + titleofmessage + "\n";
            return s + base.ToString();

        }
    }
}
