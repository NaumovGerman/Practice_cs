namespace hw_second.SortAlgs;

public class Merge
{
    public static T[] MergeSort<T>(T[]? col,
        LetsSort.Mode mymode, Comparison<T> comp)
    {
        if (col == null)
        {
            throw new ArgumentNullException(nameof(col));
        }

        return Mergestick(col, mymode, comp, 0, col.Length - 1);
    }
    
    private static T[] Mergestick<T>(T[]? col,
        LetsSort.Mode mymode, Comparison<T> comp, int minInd, int maxInd)
    {
        if (minInd < maxInd)
        {
            var mid = (maxInd + minInd) / 2;
            Mergestick(col, mymode, comp, minInd, mid);
            Mergestick(col, mymode, comp, mid + 1, maxInd);
            Merger(col, mymode, comp, minInd, mid, maxInd);
        }
        return col;
    }

    private static void Merger<T>(T[]? col,
        LetsSort.Mode mymode, Comparison<T> comp,
        int min, int mid, int max)
    {
        
        var left = min;
        var right = mid + 1;
        var temp = new T[max - min + 1];
        var index = 0;

        while ((left <= mid) && (right <= max))
        {
            if (mymode == LetsSort.Mode.Ascending 
                    ? comp(col[left], col[right]) < 0 
                    : comp(col[left], col[right]) > 0)
            {
                temp[index] = col[left];
                left++;
            }
            else
            {
                temp[index] = col[right];
                right++;
            }

            index++;
        }

        for (var i = left; i <= mid; i++)
        {
            temp[index] = col[i];
            index++;
        }

        for (var i = right; i <= max; i++)
        {
            temp[index] = col[i];
            index++;
        }

        for (var i = 0; i < temp.Length; i++)
        {
            col[min + i] = temp[i];
        }
    }
}