using System;
using System.Collections.Generic;

namespace homework1_class
{
    public  class StringAverage
    {
        public static string AverageString(string str)
        {
            Dictionary<int, string> myDic = new Dictionary<int, string>();
            myDic.Add(0, "zero");
            myDic.Add(1, "one");
            myDic.Add(2, "two");
            myDic.Add(3, "three");
            myDic.Add(4, "four");
            myDic.Add(5, "five");
            myDic.Add(6, "six");
            myDic.Add(7, "seven");
            myDic.Add(8, "eight");
            myDic.Add(9, "nine");

            if (!String.IsNullOrEmpty(str))
            {
                string[] num = str.Split(' ');
                int numResult = 0;
                foreach (string strNum in num)
                {
                    foreach(KeyValuePair<int,string> kvr in myDic)
                        if (strNum == kvr.Value)
                    {
                            numResult += kvr.Key;
                    }
                }

                numResult = numResult / num.Length;

                if (numResult > 9 || numResult < 0)
                {
                    str = "n/a";
                }
                else
                {
                    foreach (KeyValuePair<int, string> kvr in myDic)
                        if (numResult == kvr.Key)
                        {
                            str = kvr.Value;
                        }
                }
            }
            else
            {
                str = "n/a";
            }
            return str;
        }
    }
}
