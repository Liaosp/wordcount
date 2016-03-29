using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Diagnostics;
namespace wc
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"e:\C#\wc\wc\Program.cs";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sdr = new StreamReader(fs);
            int i = 0, n = 0, m = 0, t = 0, p = 0, w = 0;

            int count = 0;
            string s = sdr.ReadLine();
            while (s != null)
            {
                i++;
                //Console.WriteLine(""+s);
                string[] str = s.Split(' ', '.', ',', ':', '?', '[', ']', '(', ')', '=', '!', '{', '}', '/', '"', '+', ';');
                //Console.WriteLine("{0}", s.Length);
                foreach (string str1 in str)
                {
                    if (!str1.Equals(""))
                    {
                        count++;
                    }
                }
                // Console.WriteLine("{0}", count);
                if (s.Length == 0)
                {
                    p++;
                }
                else
                {
                    t = 0;
                    foreach (string str1 in str)
                    {
                        if (!str1.Equals(""))
                        {
                            t++;
                        }
                    }
                    if (t == 0)
                    {
                        p++;
                    }
                }
                for (int jj = 0; jj < s.Length; jj++)
                {
                    if (s[jj] == '/' && s[jj + 1] == '/')
                    {
                        w++;
                    }
                }
                n = n + s.Length;
                s = sdr.ReadLine();
            }
            Console.WriteLine("总行数：{0}", i);
            Console.WriteLine("字符数：{0}", n);
            Console.WriteLine("单词数：{0}", count);
            Console.WriteLine("空行数：{0}", p);
            Console.WriteLine("注释行数：{0}", w);
            Console.WriteLine("代码行数：{0}", i - w - p);
            sdr.Close();
            System.Diagnostics.Debugger.Break();
        }
    }
}
