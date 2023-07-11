namespace hw_second.SortAlgs;

public class Insertion
{
    public static T[] InsertionSort<T>(T[]? col,
        LetsSort.Mode mymode, Comparison<T> comp)
    {
        
        var n = col.Length;
        
        for (int i = 1; i < n; ++i) {
            var key = col[i];
            int j = i - 1;
            
            // while (j >= 0 && (col[j] > key)) {
            while (j >= 0 && (mymode == LetsSort.Mode.Ascending ? comp(col[j], key) > 0 : comp(col[j], key) < 0)) {
                col[j + 1] = col[j];
                j = j - 1;
            }
            col[j + 1] = key;
        }

        return col;
    }
}