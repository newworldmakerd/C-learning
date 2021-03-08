using LitJson;
using System;
using System.IO;

namespace json练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToObject();
            ToJson();
        }
        static void ToObject()
        {
            //1.选择文件路径
            string path = @"D:\C#项目\json练习\资料\Skill.Json";
            //2.构建文件流
            StreamReader streamReader = new StreamReader(path);
            string text = streamReader.ReadToEnd();
            //3.利用litjson将json转化为skill类
            Skill skill = JsonMapper.ToObject<Skill>(text);
            Console.WriteLine(skill.Id +"\n"  + skill.Name +"\n" + skill.damage);
            streamReader.Close();
        }
        static void ToJson()
        {
            //1.创建skill类对象
            Skill skill1 = new Skill();
            skill1.Id = 1002;
            skill1.Name = "乾坤大挪移";
            skill1.damage = 20000;
            //2.选择文件路径
            string path = @"D:\C#项目\json练习\资料\Skill2.Json";
            //3调用api将skill转化为字符串
            string text = JsonMapper.ToJson(skill1);
            //4写入json文件
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(text);
            streamWriter.Close();
            Console.WriteLine("写入成功");

        }
    }
}
