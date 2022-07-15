using System;
using System.IO;
using System.Text;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Now";
            DirectoryInfo root = new DirectoryInfo(path);
            FileInfo[] files = root.GetFiles();
            foreach (FileInfo f in files)
            {
                FileStream fs = new FileStream(path + @"\" + f.Name, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                if (f.Name.Substring(f.Name.LastIndexOf('.')) == ".txt")
                {
                    string file_text = sr.ReadToEnd();
                    if (file_text.Contains("sharp"))
                    {
                        Console.WriteLine(f);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
