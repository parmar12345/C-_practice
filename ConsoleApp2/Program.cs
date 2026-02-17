using System;
using System.Collections;
using System.Net.NetworkInformation;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create ArrayList
        ArrayList list = new ArrayList();

        // Add elements (different types)
        list.Add(10);           // int
        list.Add("Hello");      // string
        list.Add(3.14);         // double
        list.Add(true);         // bool
        list.Add('A');          // char

        Console.WriteLine("=== ArrayList Elements ===");
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("Capacity: " + list.Capacity);

        // Display elements
        Console.WriteLine("\n--- Using for loop ---");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"Index {i}: {list[i]} (Type: {list[i].GetType().Name})");
        }

        // Display using foreach
        Console.WriteLine("\n--- Using foreach ---");
        foreach (object item in list)
        {
            Console.WriteLine(item);
        }

        // Insert at specific position
        list.Insert(1, "Inserted");
        Console.WriteLine("\nAfter Insert at index 1:");
        foreach (object item in list)
        {
            Console.Write(item + " ");
        }

        // Remove element
        list.Remove("Hello");
        Console.WriteLine("\n\nAfter removing 'Hello':");
        foreach (object item in list)
        {
            Console.Write(item + " ");
        }

        // Remove at index
        list.RemoveAt(0);
        Console.WriteLine("\n\nAfter removing at index 0:");
        foreach (object item in list)
        {
            Console.Write(item + " ");
        }

        // Check if contains
        Console.WriteLine("\n\nContains 3.14? " + list.Contains(3.14));

        // Clear all elements
        list.Clear();
        Console.WriteLine("\nAfter Clear - Count: " + list.Count);
    }
}
