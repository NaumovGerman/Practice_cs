namespace hw_second;

public class CombinationCompare:
    IComparer<CombinedType>
{
    private static CombinationCompare? _instance;

    private CombinationCompare()
    {
        
    }

    public static CombinationCompare Instance =>
        _instance ??= new CombinationCompare();


    int IComparer<CombinedType>.Compare(CombinedType? x, CombinedType? y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (ReferenceEquals(null, y)) return 1;
        if (ReferenceEquals(null, x)) return -1;
        
        return string.Compare(x.Mystr, y.Mystr, StringComparison.Ordinal);
    }
    
    public static int Compare(CombinedType? x, CombinedType? y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (ReferenceEquals(null, y)) return 1;
        if (ReferenceEquals(null, x)) return -1;
        
        return string.Compare(x.Mystr, y.Mystr, StringComparison.Ordinal);
    }
}
