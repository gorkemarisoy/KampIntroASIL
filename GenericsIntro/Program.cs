﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();  //string türünde bir mylist oluşturdum.
            isimler.Add("Görkem");
        }
    }
}