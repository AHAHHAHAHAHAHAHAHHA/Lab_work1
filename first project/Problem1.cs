List<object> firstList = new List<object> { 1, 2, '3', "aboba", 667 };
List<object> secondList = new List<object> { 11, "Mr Smith", '9', "aboba1", 1000 };

Dictionary<object, object> dictionary = new Dictionary<object, object>();

for (int i = 0; i < firstList.Count; i++)
{
    dictionary.Add(firstList[i], secondList[i]);
}

foreach(var kvp in dictionary) 
    Console.WriteLine("{0} => {1}", kvp.Key, kvp.Value);
