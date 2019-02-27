using System;

namespace yanghuisanjiao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World C# 输出杨辉三角!");
            int length = 0;
            Console.Write("输入杨辉三角的长度？");
            length = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[length][];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new int[i+1]; //构建杨辉三角的增量二维数组数据结构
            }
            for (int i = 0; i < a.Length; i++)
            {
                a[i][0] = 1; //把所有第一列的数据元素赋值1
                a[i][i] = 1; //把所有每行最后一列数据元素也赋值1
                for (int j = 1; j < a[i].Length-1; j++){
                    a[i][j] = a[i-1][j-1] + a[i-1][j];//其余位置袁术的值由杨辉三角公式计算
                }
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                //遍历输出杨辉三角
                for (int k = 0; k < length -1; k++)
                {
                    Console.Write(" ");
                }

                for (int j =0; j < a[i].Length; j++)
                {
                    Console.Write("{0}", a[i][j]);    
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
