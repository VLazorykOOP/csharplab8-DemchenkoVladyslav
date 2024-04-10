using System.Text.RegularExpressions;

namespace Lab8CSharp
{
    class Program
    {
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



            Console.WriteLine("Task 4 ");
            int n = 0;
            int[] nums;

            string[] ns = Console.ReadLine().Split();
            n = ns.Length;
            nums = new int[n];
            int i = 0;
            foreach (string s in ns)
            {
                nums[i] = int.Parse(s);
                i++;
            }
            using (FileStream fs = new FileStream("task4Write.bin", FileMode.OpenOrCreate))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    foreach (int num in nums)
                    {
                      bw.Write(num + " ");
                    }
                }
            }
        }
    }
}