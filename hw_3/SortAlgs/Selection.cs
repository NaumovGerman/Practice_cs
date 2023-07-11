namespace hw_second.SortAlgs;

public class Selection
{
    public static T[] SelectionSort<T>(T[]? col,
        LetsSort.Mode mymode, Comparison<T> comp)
    {
        if (col == null)
        {
            throw new ArgumentNullException(nameof(col));
            
        }

        var colLength = col.Length;
        for (int i = 0; i < colLength - 1; i++)
        {
            var cur = i;
            for (int j = i + 1; j < colLength; j++)
            {
                if (mymode == LetsSort.Mode.Ascending ? comp(col[j], col[cur]) < 0 : comp(col[j], col[cur]) > 0)
                {
                    cur = j;
                }
            }

            (col[cur], col[i]) = (col[i], col[cur]);
        }

        return col;
    }
}   