using PeopleLibrary;
using static System.Console;

Person dante = new Person();
dante.Name = "Dante";
dante.SurName = "Cruz";
Person luis = new Person("Luis");
WriteLine($"Hello {dante.Name}");