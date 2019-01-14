using Xunit;

namespace TMP
{
    public class ChessForThree2
    {
        private int Alex = 1;
        private int Bob = 2;
        private int Carl = 3;
        public bool Run(int NumberOfGames, int[] gameResult)
        {

            int spectating = Carl;
            int winner;
            int secondPlayer = Bob;

            var result = true;

            for (var game = 0; game < NumberOfGames; game++)
            {
                winner = gameResult[game];
                if (winner == spectating) return false;
                secondPlayer = spectating;

                spectating = 6 - winner - spectating;
            }

            return result;
        }

        /// <summary>
        /// Examples input 3 1 1 2  output YES
        /// </summary>
        [Fact]
        public void test1()
        {
            int[] b = { 1, 1, 2 };
            Assert.True(Run(3, b));
        }

        /// <summary>
        /// Examples input 2 1 2 output NO 
        ///  </summary>
        [Fact]
        public void test2()
        {
            int[] b = { 1, 2 };
            Assert.False(Run(2, b));
        }

        /// <summary>
        /// Examples input 2 1 2 output NO 
        ///  </summary>
        [Fact]
        public void test3()
        {
            int[] b = { 2,3,1 };
            Assert.True(Run(3, b));
        }
    }
}



//if (winner == 1)
//{
//    if (secondPlayer == 2)
//    {
//        spectating = 3;
//    }
//    if (secondPlayer == 3)
//    {
//        spectating = 2;
//    }
//}
//if (winner == 2)
//{
//    if (secondPlayer == 1)
//    {
//        spectating = 3;
//    }
//    if (secondPlayer == 3)
//    {
//        spectating = 1;
//    }
//}
//if (winner == 3)
//{
//    if (secondPlayer == 1)
//    {
//        spectating = 2;
//    }
//    if (secondPlayer == 2)
//    {
//        spectating = 1;
//    }
//}