using System;

public class RandomList
{
    private Random _rnd = new Random();

    private List<string> _unorderedList = new List<string>();

    private int _nextItemIndex = 0;

    public RandomList(string[] items)
    {
        List<string> orderedList = new List<string>(items);
        while (orderedList.Count > 0)
        {
            int index = _rnd.Next(0, orderedList.Count);
            string item = orderedList[index];
            _unorderedList.Add(item);
            orderedList.RemoveAt(index);
        }
    }

    public string Next()
    {
        int index = _nextItemIndex % _unorderedList.Count;
        _nextItemIndex++;
        return _unorderedList[index];
    }
}
