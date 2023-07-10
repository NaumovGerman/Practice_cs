using System.Collections;

namespace hw_second;

public static class Advantages
{
    // Генерация сочетаний
    private static IEnumerable<IEnumerable<T>> GetAllCombination<T>(this IEnumerable<T> collection, int k)
    {
        return k == 0 ? new[] { Array.Empty<T>() } :
            collection.SelectMany((e, i) =>
                collection.Skip(i).GetAllCombination(k - 1).Select(c => (new[] {e}).Concat(c)));
    }

    public static IEnumerable<IEnumerable<T>> FirstTask<T>(this IEnumerable<T> collection, int k)
    {
        foreach (var item in GetAllCombination(collection, k))
        {
            yield return item;
        }
    }
    
    // Генерация подмножеств
    public static IEnumerable<IEnumerable<T>> SecondTask<T>(this IEnumerable<T>? collection)
    {
        var enumerable = collection.ToArray();

        var result = Enumerable
            .Range(0, 1 << enumerable.Length)
            .Select(index => enumerable.Where((type, element) => (index & (1 << element)) != 0).ToArray());

        foreach (var item in result)
        {
            yield return item;
        }
    }
    
    // Генерация перестановок
    private static IEnumerable<IEnumerable<T>> GetAllPermutation<T>(this IEnumerable<T> collection)
    {
        if (collection.Count() == 1)
            return new[] { collection };            
 
        return collection.SelectMany(v => GetAllPermutation(collection.Where(x => !x.Equals(v))), (v, p) => p.Prepend(v));
    }
    
    public static IEnumerable<IEnumerable<T>> ThirdTask<T>(this IEnumerable<T>? collection)
    {
        foreach (var item in GetAllPermutation(collection))
        {
            yield return item;
        }
    }
    
    
}
