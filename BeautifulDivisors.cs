using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TMP
{
    public class BeautifulDivisors
    {
        public int Run(int a)
        {
            var inputNumber = a;
            var divider = a;
            for (var q = 1; q < inputNumber; q++)
            {
                if (inputNumber % divider != 0)//ищем делитель
                {
                    divider--;
                    continue;
                }
                string binaryCode = Convert.ToString(divider, 2);
                char[] charArray = binaryCode.ToArray();
                int[] intArray = Array.ConvertAll(charArray, c => (int)char.GetNumericValue(c));
                int middle;
                if (intArray.Length % 2 == 0)//если размер масива парный - такое число не может быть красивм
                {
                    divider--; //intArray.Length - начинается с 1
                    continue;
                }
                middle = intArray.Length / 2 + 1;//вычисляем средину масива с округление в сторону увеличения
                if (middle == intArray.Length) //если средина масива и есть размер масива - ищем новый делитель
                {
                    divider--;
                    continue;
                }
                bool Ones = true; //проверяем символы с начале масива до его средины что они 1
                for (var i = 0; i < middle; i++)
                {
                    if (intArray[i] != 1)
                    {
                        Ones = false;
                        break;
                    }
                }
                if (!Ones)
                {
                    divider--;
                    continue;
                }
                bool Zeros = true; //проверяем символы с конца масива до его средины что они 0
                for (var j = intArray.Length - 1; j >= middle; j--)
                {
                    if (intArray[j] != 0)
                    {
                        Zeros = false;
                        break;
                    }
                }
                if (!Zeros)
                {
                    divider--;
                    continue;
                }
                return divider;
            }
            return divider;
        }

        /// <summary>
        /// Examples input 3 output 1
        /// </summary>
        [Fact]
        public void test1()
        {
            Assert.Equal(1, Run(3));
        }

        /// <summary>
        /// Examples input 992 output 496 
        ///  </summary>
        [Fact]
        public void test2()
        {
            Assert.Equal(496, Run(992));
        }
        /// <summary>
        /// Examples input 81142 output 1 
        ///  </summary>
        [Fact]
        public void test3()
        {
            Assert.Equal(1, Run(81142));
        }

        /// <summary>
        /// Examples input 42 output 6 
        ///  </summary>
        [Fact]
        public void test4()
        {
            Assert.Equal(6, Run(42));
        }


        /// <summary>
        /// Examples input 248 output 1 
        ///  </summary>
        [Fact]
        public void test5()
        {
            Assert.Equal(1, Run(248));
        }



    }
}
