using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ThirdParty.Json.LitJson;

namespace Myprop
{
    public static class JsonHelper
    {
        public static string ToJson<T>(T o,string path)
        {
            StreamWriter streamWriter = new StreamWriter(path,false,Encoding.UTF8);
            string text = JsonMapper.ToJson(o);
            streamWriter.Write(text);
            streamWriter.Close();
            return text;
        }
        public static T ToObject<T>(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            string text = streamReader.ReadToEnd();
            T o = JsonMapper.ToObject<T>(text);
            streamReader.Close();
            return o;
        }
    }
}
