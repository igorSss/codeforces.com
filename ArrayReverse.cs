namespace TMP
{
    public class ArrayReverse
    {
        public void ReverseTheArray()
        {
            int[] Array = new[] {7, 0, 9, 3, 6, 3, 2, 1, 11, 8};
                              
            //{8, 11, 1, 2, 3, 6, 3, 9, 0, 7};

            int SizeOfArray = Array.Length - 1;
            int TemporatyValue;

            for (int i = 0; i < SizeOfArray; i++)
            {
                TemporatyValue = Array[i];
                Array[i] = Array[SizeOfArray];
                Array[SizeOfArray] = TemporatyValue;
                SizeOfArray--;
            }
        }
    }
}