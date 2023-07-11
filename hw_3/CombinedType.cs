namespace hw_second;

public class CombinedType:
    IComparable<CombinedType>,
    IComparable
{
    private string _mystr;
    private int _myint;

    public int Myint
    {
        get => _myint;
        set => _myint = value;
    }
    public string Mystr
    {
        get => _mystr;
        set => _mystr = value ?? throw new ArgumentNullException(nameof(value));
    }

    public CombinedType(int x, String y)
    {
        _myint = x;
        _mystr = y ?? throw new ArgumentNullException();
    }

    public int CompareTo(object? smth)
    {
        if (smth is null)
        {
            throw new ArgumentNullException(nameof(smth));
        }

        if (smth is CombinedType obj)
        {
            return CompareTo(obj);
        }

        throw new ArgumentException(nameof(smth));

    }

    public int CompareTo(CombinedType? piece)
    {
        if (piece is null)
        {
            throw new ArgumentNullException(nameof(piece));
        }
        return this.Myint.CompareTo(piece.Myint);
    }


}