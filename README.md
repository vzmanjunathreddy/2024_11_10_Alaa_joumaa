Question 1:
=======================
You’re building an application that includes the following components:
A UserRegistrationService that registers users.
A NotificationService that sends welcome emails and SMS notifications to new users.
A Logger that records registration activities to different storage options (e.g., file, database).
Design this system to follow all five SOLID principles. Describe the class structure and provide code snippets for key components. Explain how each SOLID principle applies to your design.


Question 2:
=======================
Implementing a generic class that can sort any data type. Your sorting algorithm should be able to handle any comparable type (such as integers, strings, or custom objects), and it should be able to sort collections of that type in ascending order.
Requirements:
Implement a generic class called GenericSorter<T>, where T is a type parameter.
The class should include a method Sort(List<T> items) that sorts the list of items in ascending order.
The sorting algorithm should work for any data type that implements the IComparable<T> interface (i.e., the class should be able to compare instances of T).
Implement at least one sorting algorithm (e.g., Bubble Sort, Quick Sort, or Merge Sort) to perform the sorting.
The Sort method should sort the list in-place (i.e., without creating a new list).

Question 3:
=======================
Suppose you have a performance-critical C# application that frequently creates and disposes of short-lived objects. 
Implement an object pool to reuse objects instead of creating new instances, which can reduce memory allocations and improve performance.


Question 4:
=======================
You have two asynchronous methods FetchDataFromAPI1() and FetchDataFromAPI2(). Both methods return Task<string>. 
Write an example of how you would run both methods concurrently and wait for both to complete, using await.
Write a scenario where you would use Task.WhenAll() and Task.WhenAny()  in an asynchronous method.
