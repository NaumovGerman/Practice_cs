namespace hw_second.SortAlgs;

public class Quick
{
    public static T[] QuickSort<T>(T[]? col,
        LetsSort.Mode mymode, Comparison<T> comp)
    {
        if (col == null)
        {
            throw new ArgumentNullException(nameof(col));
        }

        return Quickest(col, mymode, comp, 0, col.Length - 1);
    }
    
    private static T[] Quickest<T>(T[]? col,
        LetsSort.Mode mymode, Comparison<T> comp, int minInd, int maxInd)
    {
        if (minInd >= maxInd)
        {
            return col;
        }

        var el = FindInd(col, mymode, comp, minInd, maxInd);
        Quickest(col, mymode, comp, minInd, el - 1);
        Quickest(col, mymode, comp, el + 1, maxInd);
        return col;
    }

    private static int FindInd<T>(T[]? col,
        LetsSort.Mode mymode, Comparison<T> comp,
        int min, int max)
    {
        var el = min - 1;
        for (int i = min; i < max; i++)
        {
            if (mymode == LetsSort.Mode.Ascending ? comp(col[i], col[max]) < 0 : comp(col[i], col[max]) > 0)
            {
                el++;
                (col[el], col[i]) = (col[i], col[el]);
            }
        }

        el++;
        (col[el], col[max]) = (col[max], col[el]);
        return el;
    }
}