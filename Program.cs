List<int> list = new List<int>{2,3,4,4,5};
var res = list.Where(x=> x>2);
foreach(var item in res)
{
    Console.WriteLine(item);
}