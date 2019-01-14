using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TMP
{
    public class Graphs
    {
        private static int Run(IDictionary<int, int> peopleAndConnectionBetweenThem, IList<int> money, IDictionary<int, int> connections)
        {
            var NumberOfPeople = peopleAndConnectionBetweenThem.FirstOrDefault().Key;
            bool[][] matrix = new bool[NumberOfPeople][];
            
            for (var i = 0; i < NumberOfPeople; i++)
            {
                matrix[i]=new bool[peopleAndConnectionBetweenThem.FirstOrDefault().Key];
                matrix[i][i] = false;
                
            }
            foreach (var coonection in connections)
            {
                matrix[coonection.Key - 1][coonection.Value - 1] = true;
            }


           



                return 1;
        }



        void justBFS(int v)
        {
            int vNum = 5; // количество вершин
            bool[][] graph = new bool[5][]; // матрица смежности
            graph[0] = new bool[1];


            //int[][] b = new int[3][]; // Ступенчатый массив
            //b[0] = new int[5] { 2, 4, -5, 9, 12 };
            //b[1] = new int[3] { 3, 10, -2 };
            //b[2] = new int[4] { 6, 2, 15, -1 };

            bool[] used = new bool[vNum]; // массив пометок
            int[] queue = new int[vNum]; // очередь
            int qH = 0; // голова очереди
            int qT = 0; // хвост

            /* <обработка вершины v> */
            used[v] = true; // помечаем исходную вершину
            queue[qT++] = v; // помещаем ее в очередь 

            while (qH < qT)
            {
                // пока очередь не пуста
                v = queue[qH++]; // извлекаем текущую вершину
                for (int nv = 0; nv < vNum; nv++)
                {
                    // перебираем вершины
                    if (!used[nv] && graph[v][nv])
                    {
                        // если nv не помечена и смежна с v
                        /* <обработка вершины nv> */
                        used[nv] = true; // помечаем ее
                        queue[qT++] = nv; // и добавляем в очередь
                    }
                }
            }
        }





        [Fact]
        public void test1()
        {
            IDictionary<int, int> PeopleAndConnectionBetweenThem = new Dictionary<int, int>();
            PeopleAndConnectionBetweenThem.Add(5, 2);

            IList<Int32> Money = new List<Int32>() { 2, 5, 3, 4, 6 };

            IDictionary<int, int> Connections = new Dictionary<int, int>();
            Connections.Add(1, 4);
            Connections.Add(4, 5);

            Assert.Equal(10, Run(PeopleAndConnectionBetweenThem, Money, Connections));
        }

        [Fact]
        public void test2()
        {
            IDictionary<int, int> PeopleAndConnectionBetweenThem = new Dictionary<int, int>();
            PeopleAndConnectionBetweenThem.Add(10, 0);

            IList<Int32> Money = new List<Int32>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IDictionary<int, int> Connections = new Dictionary<int, int>();

            Assert.Equal(55, Run(PeopleAndConnectionBetweenThem, Money, Connections));
        }

        [Fact]
        public void test3()
        {
            IDictionary<int, int> PeopleAndConnectionBetweenThem = new Dictionary<int, int>();
            PeopleAndConnectionBetweenThem.Add(10, 5);

            IList<Int32> Money = new List<Int32>() { 1, 6, 2, 7, 3, 8, 4, 9, 5, 10 };

            IDictionary<int, int> Connections = new Dictionary<int, int>();

            Connections.Add(1, 2);
            Connections.Add(3, 4);
            Connections.Add(5, 6);
            Connections.Add(7, 8);
            Connections.Add(9, 10);

            Assert.Equal(15, Run(PeopleAndConnectionBetweenThem, Money, Connections));
        }
    }
}
