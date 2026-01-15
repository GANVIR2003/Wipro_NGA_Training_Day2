// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;

Console.WriteLine("getting started with arrays and collection in c#");
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
Console.WriteLine("items in order Collection");
foreach(var item in orderCollection)
{
    Console.WriteLine(item);
}
Console.WriteLine("Items in the order Collection with their types:");
foreach (var item in orderCollection)
{
    Console.WriteLine($"(item)-Type: {item.GetType()}");
}
Console.WriteLine("generic collection implementation");
List<string> genericOrderCollection = new List<string>();
genericOrderCollection.Add("Laptop");
genericOrderCollection.Add("mobile");
genericOrderCollection.Add("tablet");
genericOrderCollection.Add(12345.ToString());
Console.WriteLine("total no of elements in the generic collection" + genericOrderCollection.Count);
Console.WriteLine("Right now the memory of generic Collectiob is " + genericOrderCollection.Capacity);
Console.WriteLine("Items in the Generic Order Collection");
foreach(var item in genericOrderCollection)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n Orders in the order Collection");
List<Order> orderList = new List<Order>();
//orderCollection Add(new Order (OrderId = 1, ProductName = "Smartphone", Quantity = 2 })//Displaying the orders in the collectionList<Order> orderList = new List<Order>();
orderList.Add(new Order{OrderId = 1, ProductName = "Laptop", Quantity = 2, Price=1500.00 });
orderList.Add(new Order { OrderId = 1, ProductName = "Smartphone", Quantity = 2, Price = 800.00 });
Console.WriteLine("Orders in the Order Collections: ")
foreach(var order in orderList)
{
    Console.WriteLine(order);

}

void AddOrder(Order order)
{
    orderList.Add(order);
}
void RemoveOrder(Order order)
{
    orderList.Remove(order);
}
void GetOrder(Order order)
{
    return orderList.Find(o => o.OrderId == orderId);
}






