using System;

namespace p44_property
{
    class Triangle1
    {
        private int width;
        private int height;
        private int area;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Area
        {
            get { return width * height / 2; }//읽기전용 set생략
        }
    }
    class Triangle2//단순한 설정 또는 단순한 반환은 명시를 하지않아도 된다.
    {
        public int Width
        {
            get;
            set;
        }
        public int Height
        {
            get;
            set;

        }
        public int Area
        {
            get { return Width * Height / 2; }
        }
    }
    public class Test
    {
        static void Main()
        {
            Triangle1 t1 = new Triangle1();
            t1.Width = 6;
            t1.Height = 6;

            Console.WriteLine($"밑변은 {t1.Width}");
            Console.WriteLine($"높이은 {t1.Height}");
            Console.WriteLine($"면적은 {t1.Area}");
            
            Triangle2 t2 = new Triangle2();
            t2.Width = 8;
            t2.Height = 8;
            Console.WriteLine($"밑변은 {t2.Width}");
            Console.WriteLine($"높이은 {t2.Height}");
            Console.WriteLine($"면적은 {t2.Area}");
        }
    }
}
