using hw_second.SortAlgs;

namespace hw_second;

public static class LetsSort
{
    public enum SortType
    {
        Merge,
        Selection,
        Heap,
        Insertion,
        Quick
        
    }
    
    public enum Mode
    {
        Ascending,
        Descending
    }
    
    public static T[] Sort<T>(this T[] col, Mode mymode,
        SortType typeSort)
    {
        var comp = Comparer<T>.Default;
        return col.Sort(mymode, typeSort, comp);
    }
    
    public static T[] Sort<T>(this T[] col, Mode mymode,
        SortType typeSort, Comparer<T> comp)
    {
        return col.Sort(mymode, typeSort, comp as IComparer<T>);
    }
    
    public static T[] Sort<T>(this T[] col, Mode mymode,
        SortType typeSort, IComparer<T> comp)
    {
        switch (typeSort)
        {
            case SortType.Merge:
                return Merge.MergeSort(col, mymode, comp.Compare);
            
            case SortType.Selection:
                return Selection.SelectionSort(col, mymode, comp.Compare);
                
            case SortType.Heap:
                return Heap.HeapSort(col, mymode, comp.Compare);
            
            case SortType.Insertion:
                return Insertion.InsertionSort(col, mymode, comp.Compare);
            
            case SortType.Quick:
                return Quick.QuickSort(col, mymode, comp.Compare);                
                
            default:
                return Quick.QuickSort(col, mymode, comp.Compare);
            
        }
    }
    

    public static T[] Sort<T>(this T[] col, Mode mymode,
        SortType typeSort, Comparison<T> del)
    {
        // туть надо подшаманить, но в целом все
        return col.Sort(mymode, typeSort, del); 
    }

}