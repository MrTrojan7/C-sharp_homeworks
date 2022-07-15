using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace DirectoryInfoExample
{
    class Program
    {
        static SortedList mass = new SortedList();
        static int countFiles = 0;
        static int countExtentions = 0;
        static int[] values;
        static string[] keys;
        static Dictionary<string, long> dict = new Dictionary<string, long>();

        public static void FileSearchingFunction(string Dir)
        {
            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo(Dir);
            System.IO.DirectoryInfo[] SubDir;
            try
            {
                SubDir = DI.GetDirectories();
            }
            catch 
            {
                return;
            }
            for (int i = 0; i < SubDir.Length; i++)
            {
                FileSearchingFunction(SubDir[i].FullName);
            }
            System.IO.FileInfo[] FI = DI.GetFiles();

            foreach (var f in FI)
            {
                FileSecurity fs = new FileSecurity();
                f.SetAccessControl(fs);

                //Console.WriteLine(f.Name + " " + f.Length + "B");
                int indexPoint = f.Name.LastIndexOf('.');
                if (indexPoint == -1)
                {
                    if (mass[" "] == null)
                    {
                        mass[" "] = 1;
                        countExtentions++;
                    }
                    else
                    {
                        int a = (int)mass[" "];
                        a++;
                        mass[" "] = a;
                    }
                }
                else
                {
                    string path = f.Name.Substring(f.Name.LastIndexOf('.') + 1);
                    path = path.ToLower();
                    if (mass[path] == null)
                    {
                        //dict.Add(f.Extension, f.Length);
                        mass[path] = 1;
                        countExtentions++;
                    }
                    else
                    {
                        //dict[f.Extension] += f.Length;
                        int a = (int)mass[path];
                        a++;
                        mass[path] = a;
                    }
                    if (!dict.ContainsKey(f.Extension))
                    {
                        dict.Add(f.Extension, f.Length);
                    }
                    else
                    {
                        dict[f.Extension] += f.Length;
                    }
                }
                
                countFiles++;
            }
        }
        static void Main(string[] args)
        {
            string bigPath = @"C:\";
            FileSearchingFunction(bigPath);

            values = new int[countExtentions];
            mass.GetValueList().CopyTo(values, 0);
            keys = new string[countExtentions];
            mass.GetKeyList().CopyTo(keys, 0);
            Array.Sort(values, keys);
            Array.Reverse(values);
            Array.Reverse(keys);
            if (countExtentions > 50)
            {
                Console.WriteLine(countExtentions);
                countExtentions = 50;
            }

            Console.WriteLine(" total files: " + countFiles + "\n");
            for (int i = 0; i < countExtentions; i++)
            {
                Console.WriteLine(keys[i] + "\t" + values[i] + "\t" + dict.ElementAt(i).Value);
            }

            //Path 2:
            //Console.OutputEncoding = System.Text.Encoding.Default; // Ukrainian language
            //FileStream file = new FileStream
            //    (@"E:\Step\.NET\C#\FileStream\kateryna.txt", FileMode.OpenOrCreate);
            //StreamReader stream = new StreamReader(file);
            //string text = stream.ReadToEnd();
            //text = text.Replace(",\n\\", " ");
            ////text = text.Replace(",", " ");
            ////text = text.Replace("\n", " ");
            ////text = text.Replace("\\", " ");
            //string[] words = text.Split(' ');
            //char[] charsToTrim = { ',', '.', '!', '-', '?', '\n', ':', ';' };
            //for (int i = 0; i < words.Length; i++)
            //{
            //    words[i].TrimEnd(charsToTrim).ToLower();
            //}

            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //foreach (var item in words)
            //{
            //    if(!dict.Keys.Contains(item))
            //    {
            //        if (item.Length > 2)
            //        {
            //            dict.Add(item, 1);
            //        }
            //    }
            //    else
            //    {
            //        dict[item] += 1;
            //    }
            //}

            //dict = dict.OrderByDescending(pair => pair.Value).
            //    ToDictionary(pair => pair.Key, pair => pair.Value);
            //int count = 0;
            //foreach (var pair in dict)
            //{
            //    Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            //    count++;
            //    if (count == 50)
            //    {
            //        break;
            //    }
            //}

            ////for (int i = 0; i <= 50; i++) // test with for
            ////{
            ////    Console.Write(dict.ElementAt(i).Key);
            ////    Console.WriteLine(" - " + dict.ElementAt(i).Value);
            ////}



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
