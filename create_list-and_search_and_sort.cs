//create list
var names = new List<String> {"Ana","amad"};
//add & remove content in the list
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");

foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[1]} and {names[2]} to the list.");
Console.WriteLine($"The list has {names.Count} people in it");

//search and sort list
var index = names.IndexOf("amad");
if (index != -1)
{
  Console.WriteLine($"The name {names[index]} is at index {index}");
}
var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");