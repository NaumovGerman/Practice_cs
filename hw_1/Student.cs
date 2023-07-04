namespace hw_first;

public class Student:
    IEquatable<string>,
    IEquatable<char>,
    IEquatable<Student>,
    IEquatable<object>
{
    private string _surname;
    private string _name;
    private string _patronymic;
    private string _group;
    private string _practice_choice;
    public Student(string @surname,
                   string @name,
                   string @patronymic,
                   string @group,
                   string @practiceChoice)
    {
        _surname = surname ?? throw new ArgumentNullException(nameof(@surname));
        _name = @name ?? throw new ArgumentNullException(nameof(@name));
        _patronymic = @patronymic ?? throw new ArgumentNullException(nameof(@patronymic));
        _group = @group ?? throw new ArgumentNullException(nameof(@group));
        _practice_choice = @practiceChoice ?? throw new ArgumentNullException(nameof(@practiceChoice));
    }

    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Patronomyc
    {
        get { return _patronymic; }
        set { _patronymic = value; }
    }
    public string Group
    {
        get { return _group; }
        set { _group = value;  }
    }
    public string Choice
    {
        get { return _practice_choice; }
        set { _practice_choice = value; }
    }

    public char CourseNumber => _group[4];

    public override bool Equals(object? obj)
    {

        if (obj == null)
        {
            return false;
        }

        if (obj is Student sample)
        {
            return Equals(sample);
        }

        if (obj is string @mystr)
        {
            return Equals(@mystr);
        }

        if (obj is int @myint)
        {
            return Equals(@myint);
        }

        return false;
    }

    public bool Equals(Student @student)
    {
        return this.Surname.Equals(@student.Surname) &&
               this.Name.Equals(@student.Name) &&
               this.Patronomyc.Equals(@student.Patronomyc) &&
               this.Group.Equals(@student.Group) &&
               this.Choice.Equals(@student.Choice);
    }
    
    public bool Equals(string @string)
    {
        return this.Equals(@string);
    }

    public bool Equals(char @chr)
    {
        return this.Equals(@chr);
    }

    public override string ToString()
    {
        return $"{this}";
    }

    public override int GetHashCode()
    {
        return this.GetHashCode() * 11 + 19;
    }

    bool IEquatable<object>.Equals(object? obj)
    {

        if (obj == null)
        {
            return false;
        }

        if (obj is Student @sample)
        {
            return Equals(@sample);
        }

        if (obj is string @str)
        {
            return Equals(@str);
        }

        if (obj is char @chr)
        {
            return Equals(@chr);
        }

        return false;
    }
}
