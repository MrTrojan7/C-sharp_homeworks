using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default; // Ukrainian language
            FileStream file = new FileStream
                (@"E:\Step\.NET\C#\FileStream\kateryna.txt", FileMode.OpenOrCreate);
            StreamReader stream = new StreamReader(file);
            string text = stream.ReadToEnd();
            text = text.Replace(",\n\\", " ");
            //text = text.Replace(",", " ");
            //text = text.Replace("\n", " ");
            //text = text.Replace("\\", " ");
            string[] words = text.Split(' ');
            char[] charsToTrim = { ',', '.', '!', '-', '?', '\n', ':', ';' };
            for (int i = 0; i < words.Length; i++)
            {
                words[i].TrimEnd(charsToTrim).ToLower();
            }

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if(!dict.Keys.Contains(item))
                {
                    if (item.Length > 2)
                    {
                        dict.Add(item, 1);
                    }
                }
                else
                {
                    dict[item] += 1;
                }
            }

            dict = dict.OrderByDescending(pair => pair.Value).
                ToDictionary(pair => pair.Key, pair => pair.Value);
            int count = 0;
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
                count++;
                if (count == 50)
                {
                    break;
                }
            }

            //for (int i = 0; i <= 50; i++) // test with for
            //{
            //    Console.Write(dict.ElementAt(i).Key);
            //    Console.WriteLine(" - " + dict.ElementAt(i).Value);
            //}

            //Part 1:
            //string path = @"E:\Now";
            //DirectoryInfo root = new DirectoryInfo(path);
            //FileInfo[] files = root.GetFiles();
            //foreach (FileInfo f in files)
            //{
            //    FileStream fs = new FileStream(path + @"\" + f.Name, FileMode.Open, FileAccess.Read);
            //    StreamReader sr = new StreamReader(fs);
            //    if (f.Name.Substring(f.Name.LastIndexOf('.')) == ".txt")
            //    {
            //        string file_text = sr.ReadToEnd();
            //        if (file_text.Contains("sharp"))
            //        {
            //            Console.WriteLine(f);
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}
