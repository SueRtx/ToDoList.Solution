using System;
using ToDoList.Models;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to the To-Do list");
    SkipWelcome();
    static void SkipWelcome()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string addList = Console.ReadLine();
      if (addList.ToLower() == "add")
      {
        Console.WriteLine("Please enter the description for the new item");
        string taskToDo = Console.ReadLine();
      Item taskToDoItem = new Item(taskToDo);
      Console.WriteLine($"{taskToDo} was added to your To Do List.");
      Console.WriteLine("You may choose to finish TO Do List or exit program anytime. (Finish/Exit)");

      SkipWelcome();
      }
      else if (addList.ToLower() == "view")
      {
        List<Item> toDoList = Item.GetAll();
        if (toDoList.Count == 0) 
        {
          Console.WriteLine("Your list is empty");
        } 
        else
        {
          for (int i = 0; i <toDoList.Count; i++)
          {
            string number = (i + 1).ToString();
            Console.WriteLine(number + ": " +toDoList[i].Description);
          } 
        }
        Console.WriteLine("You may choose to finish TO Do List or exit program anytime. (Finish/Exit)");
        SkipWelcome();
      }
      else if (addList.ToLower() == "exit")
      {
        return;
      }
      else if (addList.ToLower() == "finish")
      {
        Item.ClearAll();
        Console.WriteLine("You've completed all your tasks!");
        Console.WriteLine("You may choose to finish TO Do List or exit program anytime. (Finish/Exit)");
        SkipWelcome();
      }
      else
      {
        Console.WriteLine("Please choose Add/View/Finish/Exit");
        SkipWelcome();
      }
    }
  }
}


