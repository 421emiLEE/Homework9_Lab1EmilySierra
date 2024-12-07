using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1EmilySierra
{
    internal class Document
    {
        protected String text;


        public Document()
        {
            text = "";
        }
        //public Document(String text)
        //{
        //    this.text = text;
        //}

        public string Text { get => text; set => text = value; }

        public String getText()
        {
            return text;
        }

        public void setText(String text)
        {
            this.text = text;
        }


        public void toString()
        {
            Console.WriteLine(text);
        }
    }
}
