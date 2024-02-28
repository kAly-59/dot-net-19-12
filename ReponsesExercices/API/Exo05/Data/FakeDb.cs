using Exo05.Model;

public class FakeDb
{
    public List<User> Users { get; set; }
    public List<Pizza> Pizzas { get; set; }

    public FakeDb()
    {
        Users = new List<User>()
        {
            new User
            {
                Id = 1,
                FirstName = "kAly",
                LastName = "LykA",
                Email = "kAly@gmail.com",
                PhoneNumber = "060102230405",
                Address = "92 rue de la Piraterie",
                AdminStatus = true
            }
        };

        Pizzas = new List<Pizza>()
        {
            new Pizza
            {
                Id = 1,
                Name = "Pizza Margherita",
                Description = "Tomato sauce, mozzarella, basil",
                Price = 8.99m,
                Image = "margherita.jpg"
            }
        };
    }
}
