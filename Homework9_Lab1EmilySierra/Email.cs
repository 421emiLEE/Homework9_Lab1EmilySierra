using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework9_Lab1EmilySierra
{
    internal class Email : Document
    {

        private String sender;
        private String recipient;
        private String titleEmail;


        public Email()
        {
            text = "";
            sender = "no sender";
            recipient = "no recipient";
            titleEmail = "no title";
        }
        public Email(String text, String sender, String recipient, String titleEmail)
        {
            this.text = text;
            this.sender = sender;
            this.recipient = recipient;
            this.titleEmail = titleEmail;
        }
        //getters and setters
        public String getSender()
        {
            return sender;
        }
        public void setSender(String sender)
        {
            this.sender = sender;
        }

        public String getRecipient()
        {
            return recipient;
        }
        public void setRecipient(String recipient)
        {
            this.recipient = recipient;
        }


        public String getTitleEmail()
        {
            return titleEmail;
        }

        public void setTitleEmail(String titleEmail)
        {
            this.titleEmail = titleEmail;
        }


        public void ToString()
        {
            Console.WriteLine("Sender: " + sender + ", Recipient: " + recipient + ", Title: " + titleEmail + ", text: " + getText());
        }


    }
}
