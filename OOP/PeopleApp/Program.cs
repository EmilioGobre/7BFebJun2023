using PeopleLibrary;
using static System.Console;

Person dante = new Person();
dante.Name = "Dante";
dante.SurName = "Cruz";
Person luis = new Person("Luis");
luis.favoriteFood = FavoriteFood.Mole;
WriteLine($"Hello {dante.Name}");
WriteLine($"Val of Mole is {(int)FavoriteFood.Mole}");
WriteLine($"Hi {luis.Name} : your favorite food is {luis.favoriteFood}");
Person cristian = new("Cristian");
cristian.Children.Add(
    new Person // Implicit Instance
    {
        Name = "Christian",
        SurName = "Con H",
        DateOfBirth = new DateTime(2002, 12, 19)
    }
);

foreach (var item in cristian.Children)
{
    WriteLine($"Name of children {item.Name}");
}