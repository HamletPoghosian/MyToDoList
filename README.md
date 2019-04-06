# MyToDoList
This is a library where our assignments are kept
 
 ## The library allows you to use different functions
 
* Add
* Delete
* Show Data
* etc
### Using the library you can keep your tasks, deadlines and performance of their.
 
The code example shows only those tasks that are made
```csharp
public IEnumerable<MyTask> ShowCompletit(MyToDoList todo)
{
        return todo.Where(x => x.Isdone == true);
}
```
The code example shows all  tasks 
```csharp
public IEnumerable<MyTask> ShowAll(MyToDoList todo)
{
	return todo.Select(x=>x);
}
```
