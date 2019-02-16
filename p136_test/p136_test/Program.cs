using System;
public class Animation
{
    private int total; //총 애니메이션 편수
    private string[] title; //각 볼륨당 제목
    private string distributor; //유통사
    private string date; //제작날짜
    private int price; //가격
    public Animation(int total, string distributor, string date, int price)
    {
        this.total = total; this.title = new string[total];
        this.distributor = distributor;
        this.date = date; this.price = price;
    }
    //볼륨의 제목 설정
    public void setTitle(int number, string title) { this.title[number] = title; }
    //볼륨의 제목을 얻어오는메소드
    public string getTitle(int number) { return title[number]; }
    //제작사 정보를 읽어옴
    public string getDistributor() { return distributor; }
    //가격 정보를 읽어옴
    public int getPrice() { return price; }
    //총애니메이션의 수를 알아내는 메소드
    public int getTotal() { return total; }
}
class AniTest
{
    static void Main()
    {
        Animation ani = new Animation(5, "한국애니", "10-27-2004", 35000);
        ani.setTitle(0, "인어공주"); ani.setTitle(1, "신데렐라");
        ani.setTitle(2, "백설공주"); ani.setTitle(3, "바보온달");
        ani.setTitle(4, "라이온킹");
        Console.WriteLine("배급사: {0}", ani.getDistributor());
        Console.WriteLine("가격: {0}", ani.getPrice());
        Console.WriteLine("----------------------------");
        for (int i = 0; i < ani.getTotal(); i++)
        {
            Console.WriteLine("Volume{0} : {1}", i, ani.getTitle(i));
        }
    }
}