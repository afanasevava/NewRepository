using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace sort
{
    class Program
    {
        static int[] randomarray = new int[100000];

        static void Main(string[] args)
        {

            Random randB = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом пузырька для массива,\nзаполненного случайным образом \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = randB.Next();
                }

                stopWatch.Start(); 
                BubbleSort(randomarray);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine(elapsedTime);
            }
            Console.WriteLine("\n\n");



             Random randS = new Random();
             Console.WriteLine("Время работы алгоритма сортировки методом выбора наибольшего элемента\nдля массива, заполненного случайным образом \n");
             for (int repeat = 1; repeat <= 10; repeat++)
             {
                 Stopwatch stopWatch = new Stopwatch();
                 for (int i = 0; i < randomarray.Length; i++)
                 {
                     randomarray[i] = randS.Next();
                 }

                 stopWatch.Start();
                 SelectionSort(randomarray);
                 stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                 string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                 ts.Hours, ts.Minutes, ts.Seconds,
                 ts.Milliseconds / 10);
                 Console.WriteLine(elapsedTime);
             }
             Console.WriteLine("\n\n");



            Random randI = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом вставки для массива,\nзаполненного случайным образом \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = randI.Next();
                }

                 stopWatch.Start();
                 InsertionSort(randomarray);
                 stopWatch.Stop();

                 TimeSpan ts = stopWatch.Elapsed;
                 string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                 ts.Hours, ts.Minutes, ts.Seconds,
                 ts.Milliseconds / 10);
                 Console.WriteLine(elapsedTime);
            }

            Console.WriteLine("\n\n");



            Random randMS = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом 'разделяй и властвуй' для массива,\nзаполненного случайным образом \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = randMS.Next();
                }

               stopWatch.Start();
               MergeAndSort(randomarray, 1, randomarray.Length - 1);
               stopWatch.Stop();

               TimeSpan ts = stopWatch.Elapsed;
               string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
               ts.Hours, ts.Minutes, ts.Seconds,
               ts.Milliseconds / 10);
               Console.WriteLine(elapsedTime);
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n");










            Random rndB = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом пузырька для массива,\nотсортированного в порядке возрастания \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = rndB.Next();
                }
                Array.Sort(randomarray);

                stopWatch.Start();
                BubbleSort(randomarray);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine(elapsedTime);
            }
            Console.WriteLine("\n\n");



            Random rndS = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом выбора наибольшего элемента\n для массива, отсортированного в порядке возрастания \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = rndS.Next();
                }
                Array.Sort(randomarray);

                stopWatch.Start();
                SelectionSort(randomarray);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine(elapsedTime);
            }
            Console.WriteLine("\n\n");



            Random rndI = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом вставки для массива, отсортированного в порядке возрастания \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = rndI.Next();
                }
                Array.Sort(randomarray);

                stopWatch.Start();
                InsertionSort(randomarray);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine(elapsedTime);
            }
            Console.WriteLine("\n\n");



            Random rndMS = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом 'разделяй и властвуй' для массива,\nотсортированного в порядке возрастания \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = rndMS.Next();
                }
                Array.Sort(randomarray);

                stopWatch.Start();
                MergeAndSort(randomarray, 1, randomarray.Length - 1);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine(elapsedTime);
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n");









            Random rndBdec = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом пузырька для массива,\nотсортированного в порядке убывания \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = rndBdec.Next();
                }
                Array.Sort(randomarray);
                Array.Reverse(randomarray);

                stopWatch.Start();
                BubbleSort(randomarray);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine(elapsedTime);
            }
            Console.WriteLine("\n\n");



            Random rndSdec = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом выбора наибольшего элемента\n для массива, отсортированного в порядке убывания \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = rndSdec.Next();
                }
                Array.Sort(randomarray);
                Array.Reverse(randomarray);

                stopWatch.Start();
                SelectionSort(randomarray);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine(elapsedTime);
            }
            Console.WriteLine("\n\n");



            Random rndIdec = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом вставки для массива, отсортированного в порядке убывания \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = rndIdec.Next();
                }
                Array.Sort(randomarray);
                Array.Reverse(randomarray);

                stopWatch.Start();
                InsertionSort(randomarray);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine(elapsedTime);
            }
            Console.WriteLine("\n\n");



            Random rndMSdec = new Random();
            Console.WriteLine("Время работы алгоритма сортировки методом 'разделяй и властвуй' для массива,\nотсортированного в порядке убывания \n");
            for (int repeat = 1; repeat <= 10; repeat++)
            {
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < randomarray.Length; i++)
                {
                    randomarray[i] = rndMSdec.Next();
                }
                Array.Sort(randomarray);
                Array.Reverse(randomarray);

                stopWatch.Start();
                MergeAndSort(randomarray, 1, randomarray.Length - 1);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine(elapsedTime);
            }

            Console.WriteLine("\n\n");
            Console.ReadLine();
        }





        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        int extra = array[i];
                        array[i] = array[j];
                        array[j] = extra;
                    }
        }





        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[min])
                    {
                        min = j;
                    }
                }
                
                if( min!= i)
                {
                    int extra = array[i];
                    array[i] = array[min];
                    array[min] = extra;
                }

            }      
        }




        public static void InsertionSort(int[] array)
        {
            int temp, j = 0;

            for(int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > temp) 
                {
                   array[j + 1] = array[j];
                   j--;
                }

                array[j + 1] = temp;
            }
        }





        public static void MergeAndSort(int[] array,  int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                MergeAndSort(array, leftIndex, middleIndex);
                MergeAndSort(array, middleIndex + 1, rightIndex);
                Merge(array, leftIndex, middleIndex, rightIndex);
            }
        }


        public static void Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            int lengthLeft = middleIndex - leftIndex + 1;
            int lengthRight = rightIndex - middleIndex;
            int[] leftArray = new int[lengthLeft + 1];
            int[] rightArrray = new int[lengthRight + 1];
            for (int i = 0; i < lengthLeft; i++)
            {
                leftArray[i] = array[leftIndex + i];
            }
            for (int j = 0; j < lengthRight; j++)
            {
                rightArrray[j] = array[middleIndex + j + 1];
            }

            leftArray[lengthLeft] = int.MaxValue;        // метод для того, чтобы не брать элементы с индексом большим, чем размер массива
            rightArrray[lengthRight] = int.MaxValue;     // самый крайний элемент массива будет больше всех остальных и, следовательно, никогда не будет выбран

            int iIndex = 0;
            int jIndex = 0;

            for (int k = leftIndex; k <= rightIndex; k++)
            {
                if (leftArray[iIndex] <= rightArrray[jIndex])
                {
                    array[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = rightArrray[jIndex];
                    jIndex++;
                }
            }
        }



    }
}

