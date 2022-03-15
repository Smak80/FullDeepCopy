// See https://aka.ms/new-console-template for more information

using VMK_L2022_03_15;

var sc1 = new SomeClass();
sc1.AddElem(new ElemClass("Сергей"));
sc1.AddElem(new ElemClass("Наталья"));
foreach (var e in sc1.list)
{
    Console.WriteLine(e.Name);
}
var sc2 = (SomeClass)sc1.DeepCopy();
foreach (var e in sc1.list)
{
    Console.WriteLine(e.Name);
}
sc2.list[0].Name = "Иван";
sc2.AddElem(new ElemClass("Семён"));
foreach (var e in sc2.list)
{
    Console.WriteLine(e.Name);
}
foreach (var e in sc1.list)
{
    Console.WriteLine(e.Name);
}