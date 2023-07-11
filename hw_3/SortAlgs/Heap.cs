namespace hw_second.SortAlgs;

public class Heap
{
    public static T[] HeapSort<T>(T[]? col,
        LetsSort.Mode mymode, Comparison<T> comp)
    {
        if (col == null)
        {
            throw new ArgumentNullException(nameof(col));
            
        }

        var size = col.Length;
        for (int i = size / 2 - 1; i >= 0; i--)
        {
            Heapify(col, mymode, comp, size, i);
        }

        for (int i = size - 1; i >= 0; i--)
        {
            (col[0], col[i]) = (col[i], col[0]);
            Heapify(col, mymode, comp, i, 0);
        }

        return col;

    }
        
    
    
    private static void Heapify<T>(
        T[] col, LetsSort.Mode mymode, Comparison<T> comp, int size, int main)
    {
        var smth = main;
        var leftChild = 2 * main + 1;
        var rightChild = 2 * main + 2;

        if (leftChild < size && (mymode == LetsSort.Mode.Ascending
                ? comp(col[leftChild], col[smth]) > 0
                : comp(col[leftChild], col[smth]) < 0))
        {
            smth = leftChild;
        }
        
        if (rightChild < size && (mymode == LetsSort.Mode.Ascending
                ? comp(col[leftChild], col[smth]) > 0
                : comp(col[leftChild], col[smth]) < 0))
        {
            smth = leftChild;
        }

        if (smth != main)
        {
            (col[main], col[smth]) = (col[smth], col[main]);
            Heapify(col, mymode, comp, size, smth);
        }
    }
}
