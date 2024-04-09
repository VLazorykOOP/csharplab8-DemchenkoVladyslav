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


            Console.WriteLine("Task 3 ");

        }
    }
}