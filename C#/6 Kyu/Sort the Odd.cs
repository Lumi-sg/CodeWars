//You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.
using System.Linq;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        var indexedNums = array.Select((num, idx) => new { num, idx }).ToList();

        var odds = indexedNums.Where(x => x.num % 2 == 1);
        var evens = indexedNums.Where(x => x.num % 2 == 0);

        var sortedOdds = odds.OrderBy(x => x.num);
        var reindexedOdds = sortedOdds.Zip(odds, (o1, o2) => new { o1.num, o2.idx });

        var endSequence = evens.Concat(reindexedOdds).OrderBy(x => x.idx).Select(x => x.num);

        return endSequence.ToArray();
    }
}
