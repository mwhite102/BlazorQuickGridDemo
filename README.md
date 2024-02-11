# A simple Blazor QuickGrid demo

Demonstrates how to populate QuickGrid using EF Core 8 and implement sorting and paging.

## Prerequisties

* .NET 8
* Visual Studio 2022

## Database

A ContactsDatabase.bacpac file is included in the DBBacPac folder in the root of the solution and can be restored using SQL Server Management Studio.

The database is prepopulated the generic contact data.

I used ```(localdb)\MSSQLLocalDB``` for the SQL instance.

If the connection string needs to be changed for the demo, update the connection string in the OnConfigureing method in the ContactsContext.cs class.

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer(
        "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ContactsDatabase");
}
```
