using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1EmilySierra
{
    internal class File : Document
    {
        private String path;

        public File()
        {
            text = "";
            path = "?/?";
        }
        public File(String text, String path)
        {
            this.text = text;
            this.path = path;
        }

        public string Path { get => path; set => path = value; }

        public String getPath()
        {
            return path;
        }

        public void setPath(String path)
        {
            this.path = path;
        }

        public void ToString()
        {
            Console.WriteLine("Text: " + getText() + ", path: " + path);
        }
    }
}
