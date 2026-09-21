
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;




List<Student> list = new List<Student>
{
    
    new Student{name="Seren" , age=33},
    new Student{name="narine" , age=30}
};
var res = list.GroupBy(x=> x.age);

foreach(var group in res)
{
    Console.WriteLine(group.Key);
}






public class Student
{
    public int age;
    public string name;
}