//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HackerRank.Algorithms.Strings
//{
//    public class SeparateTheNumbers
//    {
//        public static void Cal()
//        {
//            int q = Convert.ToInt32(Console.ReadLine());
//            for (int a0 = 0; a0 < q; a0++)
//            {
//                string s = Console.ReadLine();


//            }
//        }
//        public string chcekSequenceString(string nm)
//        {
//            var str = num.toString();
//            var numLen = str.length;
//            var firstNum = 0;
//            var incre = 0;
//            var testStr = string.Empty;


//            if (numLen <= 1)
//            {
//                return 'NO';
//            }

//            for (var i = 1; i <= numLen / 2; i++)
//            {
//                firstNum = parseInt(str.substr(0, i));
//                testStr = firstNum.toString();
//                incre = firstNum;

//                while (testStr.length < numLen && str != testStr)
//                {
//                    // this part needs help in javaScript because it only works up to 53bits
//                    incre++;
//                    testStr += incre.toString();
//                }

//                if (testStr == str)
//                {
//                    break;
//                }
//            }

//            return testStr == str ? 'YES ' + firstNum : 'NO';
//        }
//    }
//}
