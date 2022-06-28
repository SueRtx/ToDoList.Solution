using System;
using System.Collections.Generic;
using ToDoList.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to the To Do List");
    Console.WriteLine("Would like to add an item to your list or view your list? (Add/View)");
    string addList = Console.ReadLine();
    
    if(addList.ToLower() == "add")
    {
      Console.WriteLine("Please enter description for the new item");
      string taskToDo = Console.ReadLine();
      Item taskToDoItem = new Item(taskToDo);
      Console.WriteLine($"{taskToDo} was added to your To Do List.");
      Main();
    } 
    else if (addList.ToLower() == "view")
    {
      List<Item> toDoList = Item.GetAll();
      foreach(Item item in toDoList) 
      {
        Console.WriteLine(item.Description);
      }
    } 
  }
}
