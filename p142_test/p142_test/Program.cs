using System;
[AttributeUsage(AttributeTargets.Class)]//사용처 명시, class에 사용
public class AdditionalInfoAttribute : Attribute
{
    string name; string update; string download;

    public AdditionalInfoAttribute(string name, string update)//생성자, 위치지정파라메타
        //postional parameter<->명명 parameter
    {
        this.name = name; this.update = update;
    }
    public string Name { get { return name; } }
    public string Update { get { return update; } }
    public string Download
    {
        set { download = value; }
        get { return download; }
    }
}

namespace AttributeTest
{
    [AdditionalInfoAttribute("홍길동", "2018/10/1", Download = "http://ojc.asia")]
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);
            foreach (Attribute attr in type.GetCustomAttributes(true))
            {
                AdditionalInfoAttribute info = attr as AdditionalInfoAttribute;
                //as-> 좌측을 우측으로 형변환
                if (info != null)
                    Console.WriteLine("Name={0},Update Date={1}," +
                    "Download ={2}",
                    info.Name, info.Update, info.Download);
            }
        }
    }
}