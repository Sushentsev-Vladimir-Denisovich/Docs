using System;

namespace Docs
{

    /// <summary>
    ///  Описание функцинала формы
    /// </summary>
    public partial class Form1
    {

        static bool tok = true;
        static double[,] setka = new double[13, 13];
        static double rez;
        static bool flag = false;
        public static Random rnd = new Random();
        //static int[] n = new int[100];
        //static int[] m = new int[100];
        static int n;
        static int m;
        static int pok = 0;
        static double current, count = 0;
        static bool minitok = false;

        /// <summary>
        ///  Функция, осуществляющая разрез по случайному числу
        /// </summary>
        /// <param name="mas">Массив, определяющий сетку.</param>
        /// <param name="rez">Случайное число, по которому вычисляется разрез</param>
        public static double[,] Rez(double[,] mas, double rez)
        {
            flag = false;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 1; j < 12; j++)
                {
                    if (mas[i, j] == rez)
                    {
                        //count++;
                        //mas[i, j] = 1;
                        //flag = true;
                        //n[pok] = i;
                        //m[pok] = j;
                        //pok++;
                        count++;
                        mas[i, j] = -5;
                        flag = true;
                        n = i;
                        m = j;
                    }
                }
            }

            return mas;
        }

        /// <summary>
        /// Проверяет есть ли сгенерированное случайное число в массиве
        /// </summary>
        /// <param name="mas">Массив, определяющий сетку.</param>
        /// <param name="x">Число x</param>
        /// <param name="y">Число y</param>
        public static bool Prov(double[,] mas, int x, int y)
        {
            bool t = false;

            for (int i = 0; i < x + 1; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == x && j == y - 1)
                    {
                        return t;
                    }
                    if (mas[i, j] == current)
                    {
                        t = true;
                        return t;
                    }
                }
            }

            return t;
        }

        /*public static bool Tok(double[,] mas)
        {
            bool t;


            return t;
        }*/
        /// <summary>
        ///  Проверяет есть ли ток на сетке
        /// </summary>
        /// <param name="mas">Массив, определяющий сетку.</param>
        public static bool Proverka(double[,] mas)
        {
            bool t = true, f = false;
            int i = 0;

            for (int j = 1; j < 12; j++)
            {
                if (j % 2 == 1)
                {
                    if (mas[i, j] == -5 && mas[i + 2, j] == -5 && mas[i + 4, j] == -5 && mas[i + 6, j] == -5 && mas[i + 8, j] == -5 && mas[i + 10, j] == -5 && mas[i + 12, j] == -5)
                    {
                        t = false;
                        return t;
                    }
                }
                else
                {
                    if (mas[i + 1, j] == -5 && mas[i + 3, j] == -5 && mas[i + 5, j] == -5 && mas[i + 7, j] == -5 && mas[i + 9, j] == -5 && mas[i + 11, j] == -5)
                    {
                        t = false;
                        return t;
                    }
                }
            }

            i = 0;
            int k, l;
            int[,] prov = new int[13, 13];

            for (int j = 1; j < 12; j += 2)//0
            {
                if (mas[i, j] == -5)
                {
                    f = true;

                    if (j != 0)
                    {
                        if (j != 12)
                        {
                            prov[i + 1, j - 1] = 1;
                            prov[i + 1, j + 1] = 1;
                        }
                        else prov[i + 1, j - 1] = 1;
                    }
                    else
                    {
                        prov[i + 1, j + 1] = 1;
                    }
                }
            }

            if (f == true)
            {
                f = false;

                i += 1;
                for (int j = 0; j < 13; j += 2)//1
                {
                    if (prov[i, j] == 1 && mas[i, j] == -5)
                    {
                        f = true;

                        if (j != 0)
                        {
                            if (j != 12)
                            {
                                prov[i + 1, j - 1] = 1;
                                prov[i + 1, j + 1] = 1;
                            }
                            else prov[i + 1, j - 1] = 1;
                        }
                        else
                        {
                            prov[i + 1, j + 1] = 1;
                        }
                    }
                }
                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//2
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//3
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//4
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//5
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//6
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//7
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//8
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//9
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//10
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 0; j < 13; j += 2)//11
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            f = true;

                            if (j != 0)
                            {
                                if (j != 12)
                                {
                                    prov[i + 1, j - 1] = 1;
                                    prov[i + 1, j + 1] = 1;
                                }
                                else prov[i + 1, j - 1] = 1;
                            }
                            else
                            {
                                prov[i + 1, j + 1] = 1;
                            }
                        }
                    }
                }

                if (f == true)
                {
                    f = false;

                    i += 1;
                    for (int j = 1; j < 12; j += 2)//12
                    {
                        if (prov[i, j] == 1 && mas[i, j] == -5)
                        {
                            t = false;
                            return t;
                        }
                    }
                }
            }


            /*int i = 0, j, k, l;

            for (j = 1; j < 12; j++)
            {
                if (mas[j, j] == -5)
                {
                    k = j + 1;
                    l = j - 1;
                    i += 1;

                }
            }*/


            return t;
        }


    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
