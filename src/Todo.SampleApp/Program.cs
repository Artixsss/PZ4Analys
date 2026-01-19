using System;
using Todo.Core;

var list = new TodoList();

_ = list.Add("Buy milk");
_ = list.Add("Read book");

Console.WriteLine("All tasks:");
foreach (var item in list.Items)
{
    Console.WriteLine($"- {item.Title} (done: {item.IsDone})");
}

Console.WriteLine();
Console.WriteLine("Search: 'buy'");
foreach (var item in list.Find("buy"))
{
    Console.WriteLine($"- {item.Title}");
}
