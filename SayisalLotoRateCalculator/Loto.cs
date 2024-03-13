using System.ComponentModel.DataAnnotations;

public class Loto
{
    static Random rnd = new Random();
    public int[] generateLoteryNumbers(int numberCount, int from, int to)
    {

        int[] answer = new int[numberCount];
        for (int i = 0; i < numberCount; i++)
        {
            int number;
            do
                number = rnd.Next(from, to + 1);
            while (answer.Contains(number));
            answer[i] = number;
        }

        return answer;
    }
    public int getMatchedCount(int[] first, int[] second)
    {
        int findedCount = 0;
        for (int i = 0; i < first.Length; i++)
            findedCount += second.Contains(first[i]) ? 1 : 0;
        return findedCount;
    }


}
