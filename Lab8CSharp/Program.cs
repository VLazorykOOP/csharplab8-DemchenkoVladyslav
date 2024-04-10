using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Lab8CSharp
{
    class Program
    {
        private static void DelDir(DirectoryInfo di)
        {
            foreach (var f in di.GetFiles())
            {
                f.Delete();
            }
            foreach (var d in di.GetDirectories())
            {
                DelDir(d);
            }
            di.Delete();
        }
        public static void Main(string[] Args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("Lab#8 ");
            //Console.WriteLine("Task 1 ");
            //Regex r = new Regex("[0-1]{1,8}(.[0-1]{1,8}){3}");
            //MatchCollection mc;
            //using (FileStream fs = new FileStream("task1Read.txt", FileMode.Open))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        string s = sr.ReadToEnd();
            //        mc = r.Matches(s);
            //    }
            //}
            //using (FileStream fs = new FileStream("task1Write.txt", FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        foreach (Match m in mc)
            //            sw.WriteLine(m.Value);
            //    }
            //}

            //Console.WriteLine("Task 2 ");
            //string result = "";
            //string input = "";
            //using (FileStream fs = new FileStream("task2Read.txt", FileMode.Open))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        input = sr.ReadToEnd();
            //    }
            //}
            //result = Regex.Replace(input, @"[\p{P}\d]", "");
            //Console.WriteLine("Оригінальний рядок: " + input);
            //Console.WriteLine("Результат: " + result);
            //using (FileStream fs = new FileStream("task2Write.txt", FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {                   
            //            sw.WriteLine(result);
            //    }
            //}


            //Console.WriteLine("Task 3 ");
            //string str1 = "", str2 = "";
            //string[] words1, words2;
            //using (FileStream fs = new FileStream("task3Read1.txt", FileMode.Open))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        str1 = sr.ReadToEnd();
            //    }
            //}
            //using (FileStream fs = new FileStream("task3Read2.txt", FileMode.Open))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        str2 = sr.ReadToEnd();
            //    }
            //}
            //words1 = Regex.Split(str2, @"[\p{P}\s\t]");
            //foreach (string word in words1)
            //{
            //    str1 = Regex.Replace(str1, @"[\p{P}\s\t]{1}" + word + @"[\p{P}\s\t]{1}", " ");
            //}
            //using (FileStream fs = new FileStream("task3Write.txt", FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        sw.Write(str1);
            //    }
            //}



            //Console.WriteLine("Task 4 ");
            //int n = 0;
            //int[] nums;

            //string[] ns = Console.ReadLine().Split();
            //n = ns.Length;
            //nums = new int[n];
            //int i = 0;
            //foreach (string s in ns)
            //{
            //    nums[i] = int.Parse(s);
            //    i++;
            //}
            //using (FileStream fs = new FileStream("task4Write.bin", FileMode.OpenOrCreate))
            //{
            //    using (BinaryWriter bw = new BinaryWriter(fs))
            //    {
            //        foreach (int num in nums)
            //        {
            //          bw.Write(num + " ");
            //        }
            //    }
            //}
            Console.WriteLine("Task 5 ");
            DirectoryInfo di = new(@"D:\temp");
            try
            {
                di = new(@"D:\temp");
            }
            catch (DirectoryNotFoundException e)
            {
                Directory.CreateDirectory(@"D:\temp");
            }
            finally
            {
                di = new(@"D:\temp");
            }
            string subdir1 = "Demchenko1";
            string subdir2 = "Demchenko2";
            di.CreateSubdirectory(subdir1);
            di.CreateSubdirectory(subdir2);
            FileInfo fi1 = new(di.FullName + "\\" + subdir1 + "\\t1.txt");
            using (StreamWriter sr = fi1.CreateText())
            {
                sr.WriteLine("Шевченко Степан Іванович, 2001 року народження, місце проживання - м. Суми");
            }

            FileInfo fi2 = new(di.FullName + "\\" + subdir1 + "\\t2.txt");
            using (StreamWriter sr = fi2.CreateText())
            {
                sr.WriteLine("Комар Сергій Федорович, 2000 року народження, місце проживання - м. Київ");
            }
            FileInfo fi3 = new(di.FullName + "\\Demchenko2\\t3.txt");
            using (StreamWriter sw = fi3.CreateText())
            {
                using (StreamReader sr = fi1.OpenText())
                {
                    sw.WriteLine(sr.ReadToEnd());
                }
                using (StreamReader sr = fi2.OpenText())
                {
                    sw.WriteLine(sr.ReadToEnd());
                }
            }
            Console.WriteLine(fi1.Attributes);
            Console.WriteLine(fi1.CreationTime);
            Console.WriteLine(fi1.Exists);
            Console.WriteLine(fi1.Extension);
            Console.WriteLine(fi1.FullName);
            Console.WriteLine(fi1.LastAccessTime);
            Console.WriteLine(fi1.LastWriteTime);
            Console.WriteLine(fi1.Name);

            Console.WriteLine(fi2.Attributes);
            Console.WriteLine(fi2.CreationTime);
            Console.WriteLine(fi2.Exists);
            Console.WriteLine(fi2.Extension);
            Console.WriteLine(fi2.FullName);
            Console.WriteLine(fi2.LastAccessTime);
            Console.WriteLine(fi2.LastWriteTime);
            Console.WriteLine(fi2.Name);

            Console.WriteLine(fi3.Attributes);
            Console.WriteLine(fi3.CreationTime);
            Console.WriteLine(fi3.Exists);
            Console.WriteLine(fi3.Extension);
            Console.WriteLine(fi3.FullName);
            Console.WriteLine(fi3.LastAccessTime);
            Console.WriteLine(fi3.LastWriteTime);
            Console.WriteLine(fi3.Name);

            try
            {
                fi2.MoveTo(di.FullName + "\\" + subdir2 + "\\" + fi2.Name);
            }
            catch (Exception e)
            {

            }
            try
            {
                fi1.CopyTo(di.FullName + "\\" + subdir2 + "\\" + fi1.Name);
            }
            catch (Exception e)
            {

            }
            DirectoryInfo di1 = new DirectoryInfo(di.FullName + "\\" + subdir1);
            DelDir(di1);
            DirectoryInfo di2 = new DirectoryInfo(di.FullName + "\\" + subdir2);
            try
            {
                di2.MoveTo(di2.Parent + "\\ALL");
            }
            catch (Exception e)
            {

            }
            Console.WriteLine(di2.Attributes);
            Console.WriteLine(di2.CreationTime);
            Console.WriteLine(di2.Exists);
            Console.WriteLine(di2.Extension);
            Console.WriteLine(di2.FullName);
            Console.WriteLine(di2.LastAccessTime);
            Console.WriteLine(di2.LastWriteTime);
            Console.WriteLine(di2.Name);
        }
    }
}