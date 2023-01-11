using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string para = $"ffmpeg -i screen.mp4 screen.avi";
            RunProcess(para);
            Console.WriteLine("完成！");
            Console.ReadKey();
            //    Student[] students = new Student[5];
            //    Student student = new Student();
            //    Student stu1 = new Student("2021", "ss", 0, 0, 99, 88, 77, 66, 55, 44);
            //    Student stu2 = new Student("2022", "aa", 0, 0, 99, 88, 77, 88, 77, 99);
            //    Student stu3 = new Student("2023", "qq", 0, 0, 99, 88, 77, 66, 88, 44);
            //    Student stu4 = new Student("2024", "ww", 0, 0, 99, 88, 77, 66, 55, 88);
            //    Student stu5 = new Student("2025", "ee", 0, 0, 99, 99, 99, 99, 99, 99);
            //    students[0] = stu1;
            //    students[1] = stu2;
            //    students[2] = stu3;
            //    students[3] = stu4;
            //    students[4] = stu5;

            //    Student[] stu = new Student[1];
            //    for (int i = 0; i < students.Length - 1; i++)
            //    {
            //        for (int j = 0; j < students.Length - 1; j++)
            //        {
            //            if (students[j].Sum < students[j + 1].Sum)
            //            {
            //                stu[0] = students[j + 1];
            //                students[j + 1] = students[j];
            //                students[j] = stu[0];

            //            }
            //        }


            //    }
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("学号：{0}，姓名：{1}，总分：{2}，平均分：{3}，" +
            //        "英语：{4}，数学：{5}，语文：{6}，物理：{7}，化学：{8}，" +
            //        "生物：{9}", students[i].Code, students[i].Name, students[i].Sum,
            //        students[i].Avg, students[i].English, students[i].Math,
            //        students[i].Chinese, students[i].Physics, students[i].Chemistry, students[i].Biology);
            //    }
            //    Console.WriteLine(JsonNewtonsoft.ToJSON(stu1));
            byte[] bytes = File.ReadAllBytes("C:\\Users\\gyd\\Pictures\\Screenshots\\test.jpg");

            //二进制转字符串
            string base64String = Convert.ToBase64String(bytes);

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(base64String);

            Console.WriteLine(json);

            string deserializeBase64String = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(json);

            if (base64String == deserializeBase64String)
            {
                Console.WriteLine("转换json成功！");
                //字符串转二进制
                byte[] newBytes = Convert.FromBase64String(deserializeBase64String);
                FileStream fileStream = null;
                try
                {
                    string path = "C:\\Users\\gyd\\Pictures\\Screenshots\\test.jpg";
                    fileStream = File.Create(path);
                    //FileStream.Write Method:Writes a block of bytes to the file stream.
                    fileStream.Write(newBytes, 0, newBytes.Length);
                    //FileStream.Flush 方法:清除该流的所有缓冲区，使得所有缓冲的数据都被写入到基础设备。
                    fileStream.Flush();
                    //FileStream.Close Method:Closes the file and releases any resources associated with the current file stream.
                    fileStream.Close();

                    Console.WriteLine("json转换二进制并保存为图片成功!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("转换json成功！");
            }
            Console.Read();
        }
        static void RunProcess(string Parameters)
        {
            var p = new Process();
            p = Process.Start("powershell.exe");
            //p.StartInfo.FileName = "CMD";
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.RedirectStandardError = true;
            //p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.Arguments = Parameters;
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(Parameters);
            Console.WriteLine("\n开始转码...\n");
            //p.WaitForExit();
            // p.Close();
        }
    }
}
