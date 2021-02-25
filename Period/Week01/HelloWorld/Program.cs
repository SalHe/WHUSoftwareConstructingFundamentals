using System;
using System.Xml;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 我把个人相关信息单独放到一个文件里了
            // 然后就不需要将此文件上传至Git仓库了
            XmlDocument doc = new XmlDocument();
            doc.Load("MyInfo.xml");
            string name = doc["MyInfo"]["Name"].InnerText;

            Console.WriteLine($"Hello {name}!");
        }
    }
}
