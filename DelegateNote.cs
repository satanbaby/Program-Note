using System;

namespace ConsoleApp1
{
    // 宣告委派回傳型別，以及傳入參數的方法簽名
    delegate bool compareDel(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            // 我們來寫個委派吧!!
            var strList = new int[] { 21, 20, 39, 14, 25, 66, 27 };
            var changeTime = 0;

            Console.WriteLine(string.Join(", ",strList));
            // 調用靜態方法 Sort() 並傳入陣列及 Lambda 陳述式
            // 其中 Lambda 方法簽名符合 compareDel 所定義的委派方法簽名
            Sort(strList, (int cur, int las)=> {
                if (cur<=las)
                {
                    return true;
                }
                // 匿名函式可調用外部參數
                changeTime++;
                return false;
            });

            Console.WriteLine("執行結果");
            Console.WriteLine(string.Join(", ", strList));            
            Console.WriteLine($"交換{changeTime}次");
        }

        private static void Sort(int[] strList, compareDel compare)
        {
            for (int i = 0; i < strList.Length; i++)
            {
                for (int j = i+1; j < strList.Length; j++)
                {
                    if (compare(strList[i], strList[j]))
                    {
                        //將內部設為空目的為增加撰寫時可讀性
                        //讓 17行 可以將if (cur<las) 設為 true
                        //爾後可以直覺寫主程式，不用了解委派
                    }
                    else
                    {
                        var temp = strList[i];
                        strList[i] = strList[j];
                        strList[j] = temp;
                        Console.WriteLine($"{string.Join(", ", strList)}，交換了{strList[i]}");
                    }
                }
            }
        }
    }
}
