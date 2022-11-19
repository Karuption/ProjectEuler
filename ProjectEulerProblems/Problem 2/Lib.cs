namespace ProjectEulerProblems.Problem_2; 

public static class Lib
{

    public static IEnumerable<int> GenerateSequence(int range)
    {
        int first = 1, second = 2;
        List<int> sequence = new List<int>{1,2};

        while (first+second < range)
        {
            sequence.Add(first+second);
            (first, second) = (second, first + second);
        }

        return sequence;
    }

    public static int SumOfEvenValues(IEnumerable<int> input) =>
        input.Where(x => x % 2 == 0).Sum();

}