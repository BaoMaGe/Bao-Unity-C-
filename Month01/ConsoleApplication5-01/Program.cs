using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5_01
{
    class Program
    {
        static void Main()
        {
            GameCore game = new GameCore();
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "w":
                        game.Move(MoveDirection.w);
                        break;
                    case "s":
                        game.Move(MoveDirection.s);
                        break;
                    case "a":
                        game.Move(MoveDirection.a);
                        break;
                    case "d":
                        game.Move(MoveDirection.d);
                        break;
                }
            }
            Console.ReadLine();
        }

        //    private  int[,] map;
        //    private  int[] RemoveZero(int[] array)    //移动0到末尾！！！！！！！！！！！！
        //    {
        //        int t = 0;//记录已经填过的索引
        //        for (int i = 0; i < array.Length; i++)
        //        {      //拿一个数
        //            if (array[i] == 0) continue;
        //            else
        //            {
        //                if (t == i) array[t] = array[i];                //移和填是同一位
        //                else if (t != i)                //不是同一位
        //                {
        //                    array[t] = array[i];
        //                    array[i] = 0;
        //                }
        //                t++;
        //            }
        //        }
        //        return array;
        //    }
        //    private  int[] RemoveZeroBack(int[] array)    //移动0到开头！！！！！！！！！！！！
        //    {
        //        int t = array.Length - 1;//记录已经填过的索引
        //        for (int i = array.Length - 1; i >= 0; i--)
        //        {      //拿一个数
        //            if (array[i] == 0) continue;
        //            else
        //            {
        //                if (t == i) array[t] = array[i];                //移和填是同一位
        //                else if (t != i)                //不是同一位
        //                {
        //                    array[t] = array[i];
        //                    array[i] = 0;
        //                }
        //                t--;
        //            }
        //        }
        //        return array;
        //    }
        //    private  int[] Sum(int[] array)     //相邻相同的相加
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            if (array[i] != 0 && array[i] == array[i + 1])
        //            {
        //                array[i] += array[i + 1];
        //                array[i + 1] = 0;
        //            }
        //        }
        //        return array;
        //    }
        //    private  int[] UpLoad(int[,] array, int Lie)//上移
        //    {
        //        int[] arrayCache = new int[array.GetLength(0)];
        //        for (int i = 0; i < array.GetLength(0); i++)//获取数组行数
        //        {
        //            arrayCache[i] = array[i, Lie];
        //        }
        //        return arrayCache;
        //    }
        //    private  int[] DownLoad(int[,] array, int Lie)//下移
        //    {
        //        int[] arrayCache = new int[array.GetLength(0)];
        //        for (int i = array.GetLength(0) - 1; i >= 0; i--)//获取数组行数
        //        {
        //            arrayCache[i] = array[i, Lie];
        //        }
        //        return arrayCache;
        //    }
        //    private  int[] LeftLoad(int[,] array, int Hang)//左移
        //    {
        //        int[] arrayCache = new int[array.GetLength(1)];
        //        for (int i = 0; i < array.GetLength(1); i++)//获取数组列数
        //        {
        //            arrayCache[i] = array[Hang, i];
        //        }
        //        return arrayCache;
        //    }
        //    private  int[] RightLoad(int[,] array, int Hang)//右移
        //    {
        //        int[] arrayCache = new int[array.GetLength(1)];
        //        for (int i = array.GetLength(1) - 1; i >= 0; i--)//获取数组列数
        //        {
        //            arrayCache[i] = array[Hang, i];
        //        }
        //        return arrayCache;
        //    }
        //    private  int[,] ReUpLoad(int[,] array, int[] array2, int Lie)//还原上移
        //    {
        //        for (int i = 0; i < array2.Length; i++)//获取数组行数
        //        {
        //            array[i, Lie] = array2[i];
        //        }
        //        return array;
        //    }
        //    private  int[,] ReDownLoad(int[,] array, int[] array2, int Lie)//还原下移
        //    {
        //        array2 = RemoveZeroBack(array2);
        //        for (int i = 0; i < array2.Length; i++)//获取数组行数
        //        {
        //            array[i, Lie] = array2[i];
        //        }
        //        return array;
        //    }
        //    private  int[,] ReLeftLoad(int[,] array, int[] array2, int Hang)//还原左移
        //    {
        //        for (int i = 0; i < array2.Length; i++)//获取数组列数
        //        {
        //            array[Hang, i] = array2[i];
        //        }
        //        return array;
        //    }
        //    private  int[,] ReRightLoad(int[,] array, int[] array2, int Hang)//还原右移
        //    {
        //        array2 = RemoveZeroBack(array2);
        //        for (int i = 0; i < array2.Length; i++)//获取数组列数
        //        {
        //            array[Hang, i] = array2[i];
        //        }
        //        return array;
        //    }
        //    public   void Move(MoveDirection direction)
        //    {
        //        switch (direction)
        //        {
        //            case MoveDirection.Up:
        //                MoveUp(map);
        //                break;
        //            case MoveDirection.Down:
        //                MoveDown(map);
        //                break;
        //            case MoveDirection.Left:
        //                MoveLeft(map);
        //                break;
        //            case MoveDirection.Right:
        //                MoveRight(map);
        //                break;
        //        }
        //    }


        //    private  void MoveUp(int[,] array)
        //    {
        //        for (int i = 0; i < array.GetLength(1); i++)//读取数组列数
        //        {
        //            int[] Coche = UpLoad(array, i);         //获取每一列的数组
        //            Coche = RemoveZero(Coche);              //去0   
        //            Coche = Sum(Coche);                     //加
        //            Coche = RemoveZero(Coche);              //去0
        //            array = ReUpLoad(array, Coche, i);      //复原
        //        }
        //    }
        //    private  void MoveDown(int[,] array)
        //    {
        //        for (int i = 0; i < array.GetLength(1); i++)//读取数组列数
        //        {
        //            int[] Coche = DownLoad(array, i);         //获取每一列的数组
        //            Coche = RemoveZero(Coche);              //去0   
        //            Coche = Sum(Coche);                     //加
        //            Coche = RemoveZero(Coche);              //去0
        //            array = ReDownLoad(array, Coche, i);      //复原
        //        }
        //    }
        //    private  void MoveLeft(int[,] array)
        //    {
        //        for (int i = 0; i < array.GetLength(0); i++)//读取数组行数
        //        {
        //            int[] Coche = LeftLoad(array, i);         //获取每一行的数组
        //            Coche = RemoveZero(Coche);              //去0   
        //            Coche = Sum(Coche);                     //加
        //            Coche = RemoveZero(Coche);              //去0
        //            array = ReLeftLoad(array, Coche, i);      //复原
        //        }
        //    }
        //    private  void MoveRight(int[,] array)
        //    {
        //        for (int i = 0; i < array.GetLength(0); i++)//读取数组行数
        //        {
        //            int[] Coche = RightLoad(array, i);         //获取每一行的数组
        //            Coche = RemoveZero(Coche);              //去0   
        //            Coche = Sum(Coche);                     //加
        //            Coche = RemoveZero(Coche);              //去0
        //            array = ReRightLoad(array, Coche, i);      //复原
        //        }
        //    }
        //    private  void PrintMap(int[,] map)
        //    {
        //        for (int r = 0; r < map.GetLength(0); r++)
        //        {
        //            for (int c = 0; c < map.GetLength(1); c++)
        //            {
        //                Console.Write(map[r, c] + "\t");
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //    /*static void Main2(string[] args)
        //    {
        //        int[] a = new int[4];
        //        for (int i = 0; i < 4; i++)
        //        {
        //            Console.WriteLine("请输入4位数组的第{0}位：", i + 1);
        //            a[i] = int.Parse(Console.ReadLine());
        //        }
        //        foreach (var item in a)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        RemoveZero(a);
        //        foreach (var item in a)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        Console.ReadLine();
        //     * 
        //     * 
        //     * 
        //     * 
        //     * static void Main5(string[] args)
        //    {
        //        int[] a = new int[4];
        //        for (int i = 0; i < 4; i++)
        //        {
        //            Console.WriteLine("请输入4位数组的第{0}位：", i + 1);
        //            a[i] = int.Parse(Console.ReadLine());
        //        }
        //        foreach (var item in a)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        RemoveZero(a);
        //        foreach (var item in a)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        Console.ReadLine();
        //    }
        //    }*/

    }
}
