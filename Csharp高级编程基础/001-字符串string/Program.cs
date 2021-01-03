using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_字符串string
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "www.devsiki.com";//我们使用string类型去存储字符串类型 字符串需要使用双引号引起来
            //int length =  s.Length;//获取字符串s长度  s.Length
            //Console.WriteLine(length);

            //if(s == "www.devsiki.com")
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //{
            //    Console.WriteLine("不相同");
            //}

            //s = "http:" + s;//字符串连接
            //Console.WriteLine(s);

            //char c = s[3];//通过索引访问字符串的某个字符
            //Console.WriteLine(c);

            //遍历字符串
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }


            Console.ReadKey();


        }
    }
}
