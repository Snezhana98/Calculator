using System;
using System.Collections.Generic;
using System.Text;


namespace Calculator
{
    public enum Znaki { none, plus, minus, mul, div };
    public class ClassCalc
    {
        public int FirstDigit;
        public int SecondDigit;
        public string ZnakString;
        public string k;
        public int proverka = 1;
        //public Znaki res() { 

        //    switch (ZnakString)
        //    {
        //        case "plus":
        //            return FirstDigit + SecondDigit;

        //        case "minus":
        //            return FirstDigit - SecondDigit;

        //        case "mul":
        //            return FirstDigit * SecondDigit;

        //        case "div":
        //            return FirstDigit / SecondDigit;
        //    }
        //}

    }
}
