namespace TMP
{
    public class BubbleSort
    {
        public static int[] BuubleSort(int[] InputArray)
        {
            int[] Array = InputArray;
            int SizeOfArray = Array.Length;

            int TemporatyValue;

            for (int p = 0; p < SizeOfArray - 1; p++)
            {
                for (int i = 0; i < SizeOfArray - 1; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        TemporatyValue = Array[i + 1];
                        Array[i + 1] = Array[i];
                        Array[i] = TemporatyValue;
                    }
                }
            }
            return Array;
        }
    }
}