namespace hw_second;

public class pupu<T>:
    IEqualityComparer<T>
{
    private static pupu<T>? _instance;

    private pupu()
    {
        
    }

    public static pupu<T> Instance =>
        _instance ??= new pupu<T>();
    
    public bool Equals(
        T? x,
        T? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        if (x.GetType() != y.GetType()) return false;
        return EqualityComparer<T>.Default.Equals(x, y);
    }

    public int GetHashCode(
        T obj)
    {
        return obj.GetHashCode();
    }
}
