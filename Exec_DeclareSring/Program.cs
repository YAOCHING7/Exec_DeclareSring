using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareSring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "C:\\temp\\a.jpg";
            Console.WriteLine(sentence);
            string senterce1 = "我是一個\"好學生\"" + ".";
            Console.WriteLine(senterce1);
            string senterce2 = "我是第三行文字\n我是第四行文字";
            Console.WriteLine(senterce2);
        }
    }
}
