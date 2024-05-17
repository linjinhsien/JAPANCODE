// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!");

string html = "<html><head></head><body>"
    + "<div style=\"width:100%;height:80px;background-color:#f08080;color:#ffffff;\">mediumvioletred</div>"
    + "<div style=\"width:100%;height:80px;background-color:#ff0000\"></div>"
    + "<div style=\"width:100%;height:80px;background-color:#ff8800\"></div>"
    + "<div style=\"width:100%;height:80px;background-color:#ffff00\"></div>"
    + "<div style=\"width:100%;height:80px;background-color:#22dd00\"></div>"
    + "<div style=\"width:100%;height:80px;background-color:#0000cc\"></div>"
    + "<div style=\"width:100%;height:80px;background-color:#cc00cc\"></div>"
    + "<div style=\"width:100%;height:80px;background-color:#ff00aa\"></div>"
    + "</body></html>";

File.WriteAllText("C:\\Data\\MyHomepage.html", html, Encoding.UTF8);

Console.WriteLine("HTML檔案已經建立！");

CreateTextFile();

static void CreateTextFile()
{
    File.WriteAllText("C:\\Data\\MyFavoriteFoods.txt", "瑪麗喜歡的食物。法式吐司、漢堡、烤肉。", Encoding.UTF8);
}