// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Collections.Generic;
//here is the implemetation of None generic collection as per Order management sysytem
//Step 1: Create a class to represent an Order or any type of item we want to store in the collection
//Step 2: Create a class for the None generic collection
//Step 3: Implement methods to add, remove, and retrieve items from the collection
//Step 4: Test the collection with different types of items
//Step 5: Display the items in the collection using a loop
//here is a simple implementation of a None generic collection in C#


//Creating a non generic collection class

Console.WriteLine("Non Generic Collection Implementation");

ArrayList orderCollection = new ArrayList();
orderCollection.Add("laptop");
Console.WriteLine("Right now the memory of collection is " + orderCollection.Capacity);
orderCollection.Add(12345);
orderCollection.Add(99.99);
Console.WriteLine("Right now the memory of collection is " + orderCollection.Capacity);
orderCollection.Add(new DateTime(2024, 6, 1));
orderCollection.Add(true);
orderCollection.Add('A');
Console.WriteLine("total no of elements in the collection" + orderCollection.Count);

Console.WriteLine("Right now the memory of collection is " + orderCollection.Capacity);

//orderCollection Add(new Order (OrderId = 1, ProductName = "Smartphone", Quantity = 2 });

//Displaying the orders in the collection
Console.WriteLine("Items in the order Collection:");

foreach (var order in orderCollection)
{
    Console.WriteLine(order);
}
//For displaying the type of each item in the collection

Console.WriteLine("Itens in the Order Collection with their types:");

foreach (var item in orderCollection)
{
    Console.WriteLine($"(item) Type: (item.GetType())");
}


