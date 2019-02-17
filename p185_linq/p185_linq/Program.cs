﻿using System;
using System.Linq;
using System.Collections.Generic;
namespace from
{
    class Onj
    {
        static bool A(int i)
        {
            return i % 2 == 1;
        }
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*
            var onjQuery1 = from n in num //in 오른쪽에 소스
                            where n % 2 == 1
                            orderby n
                            select n;
                            */
            //쿼리식 기반 링크표현식

            var onjQuery1 = num.Where(new Func<int, bool>(A));
            //메소드 기반 링크표현식
            //var onjQuery1 = num.Where(i => i%2 == 1); 람다사용

            foreach (int i in onjQuery1)
                Console.WriteLine("홀수 : {0}", i);
            // Query Expression.
            IEnumerable<int> onjQuery2 = //query variable
            from n in num //데이터소스 및 범위변수(필수)
 where n > 3 // 생략가능
 orderby n descending // 내림차순정렬(생략가능)
 select n; //select or group으로 끝나야 한다.
            foreach (int i in onjQuery2)
            {
                Console.WriteLine(i);
            }
        }
    }
}