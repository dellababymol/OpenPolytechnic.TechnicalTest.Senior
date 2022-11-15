using OpenPolytechnic.Business.Model.Menu;
using OpenPolytechnic.Business.Model.Menu.Enum;
using System.Collections.Generic;

namespace OpenPolytechnic.Business.Factories
{
    public class MenuItemFactory
    {
        // Tapas
        public MenuItem CurlyFries() { return new MenuItem(1, "Curly Fries", "Like a pig's tail -- a fan favourite!", 4.99m, MenuItemType.Tapas, false); }
        public MenuItem HotWings() { return new MenuItem(2, "Hot Wings", "Spicy chicken wings -- not for wimps!", 9.99m, MenuItemType.Tapas, false); }
        public MenuItem GarlicBread() { return new MenuItem(3, "Curly Fries", "A simple classic to keep the vampires at bay.", 3.99m, MenuItemType.Tapas, false); }
        public MenuItem SquidRings() { return new MenuItem(4, "Squid Rings", "Deep fried squid service with sweet chili sauce.", 7.99m, MenuItemType.Tapas, false); }

        // Main Courses
        public MenuItem CheeseBurger() { 
            return new MenuItem(
                5,
                "Cheese Burger",
                "American style, with butter pickles. Comes with curly fries. Yeehaw!",
                15.99m,
                MenuItemType.MainCourse,
                false); 
        }
        public MenuItem KidsBurger() { return new MenuItem(6, "Kids Burger", "Beef burger and tomato sauce with a side of curly fries.", 7.99m, MenuItemType.MainCourse, true); }
        public MenuItem ChickenNuggets() { return new MenuItem(7, "Chicken Nuggets", "Nothing says happiness like nuggies.", 8.50m, MenuItemType.MainCourse, true); }
        public MenuItem Pizza() { return new MenuItem(8, "Pizza", "Thin crust pizza -- choose from Meat Lovers, Hawaiian, or Supreme.", 16.99m, MenuItemType.MainCourse, false); }
        public MenuItem Steak() { return new MenuItem(9, "Sirloin Steak", "Cooked to your preference, served with mushroom sauce and curly fries.", 27.99m, MenuItemType.MainCourse, false); }
        public MenuItem FishAndChips() { return new MenuItem(10, "Fish and Chips", "Battered fish of the day, fresh from the sea to your plate.", 18.99m, MenuItemType.MainCourse, false); }
        public MenuItem GardenSalad() { 
            return new MenuItem(
                11,
                "Garden Salad",
                "Lettuce, cucumber, carrot, beetroot, pumpkinm and chickpeas, topped with soy and honey dressing.",
                12.99m,
                MenuItemType.MainCourse,
                false);
        }
        public MenuItem AllDayBreakfast() { 
            return new MenuItem(
                12,
                "All-Day Breakfast",
                "Bacon, eggs (your way), sausages, tomatoes, mushrooms, baked beans, all on top of freshly toasted sourdough bread.",
                18.99m,
                MenuItemType.MainCourse,
                false);
        }

        // Deserts
        public MenuItem IceCreamCone() { return new MenuItem(13, "Ice Cream Cone", "A simple treat for the little ones.", 1.99m, MenuItemType.Dessert, true); }

        public MenuItem FruitSalad() { 
            return new MenuItem(
                14,
                "Fruit Salad", "An assortment of pinapple, mango, melon, peaches, and kiwifruit, topped with cream or custard",
                5.00m,
                MenuItemType.Dessert,
                false); 
        }
        public MenuItem Sundae() {
            return new MenuItem(
                15,
                "Ice Cream Sundae",
                "A tower of vanilla, chocolate, and banana ice cream, topped with gooey caramel sauce.",
                5.00m,
                MenuItemType.Dessert,
                false); 
        }
        public MenuItem BananaSplit() { 
            return new MenuItem(
                16,
                "Banana Split",
                "Two split bananas, topped with vanilla ice cream and chocolate sauce.",
                5.00m,
                MenuItemType.Dessert,
                false); 
        }

        // Drinks
        public MenuItem Cola() { return new MenuItem(17, "Cola", string.Empty, 3.99m, MenuItemType.Beverage, false); }
        public MenuItem Lemonade() { return new MenuItem(18, "Lemonade", string.Empty, 3.99m, MenuItemType.Beverage, false); }
        public MenuItem AppleJuice() { return new MenuItem(19, "Apple Juice", string.Empty, 5.99m, MenuItemType.Beverage, false); }
        public MenuItem StrawberryMilk() { return new MenuItem(20, "Strawberry Milk", string.Empty, 2.50m, MenuItemType.Beverage, true); }
        public MenuItem SodaWater() { return new MenuItem(21, "Soda Water", string.Empty, 1.25m, MenuItemType.Beverage, false); }

        // Catering Items
        public MenuItem SushiPlatter() { return new MenuItem(22, "Sushi Platter", string.Empty, 99.79m, MenuItemType.MainCourse, false); }
        public MenuItem SandwichPlatter() { return new MenuItem(23, "Sandwich Platter", string.Empty, 67.89m, MenuItemType.MainCourse, false); }
        public MenuItem CheesePlatter() { return new MenuItem(24, "Cheese Platter", string.Empty, 77.99m, MenuItemType.Dessert, false); }
        public MenuItem FruitPlatter() { return new MenuItem(25, "Fruit Platter", string.Empty, 44.29m, MenuItemType.Dessert, false); }
        public MenuItem SoupBowl() { return new MenuItem(26, "Soup Bowl", string.Empty, 30.00m, MenuItemType.MainCourse, false); }
        public MenuItem TeaDispenser() { return new MenuItem(27, "Tea Dispenser", string.Empty, 21.99m, MenuItemType.Beverage, false); }
        public MenuItem CoffeeDispenser() { return new MenuItem(28, "Coffee Dispenser", string.Empty, 26.99m, MenuItemType.Beverage, false); }

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return new List<MenuItem>
            {
                CurlyFries(),
                HotWings(),
                GarlicBread(),
                SquidRings(),
                CheeseBurger(),
                KidsBurger(),
                ChickenNuggets(),
                Pizza(),
                Steak(),
                FishAndChips(),
                GardenSalad(),
                AllDayBreakfast(),
                IceCreamCone(),
                FruitSalad(),
                Sundae(),
                BananaSplit(),
                Cola(),
                Lemonade(),
                AppleJuice(),
                StrawberryMilk(),
                SodaWater(),
                SushiPlatter(),
                SandwichPlatter(),
                CheesePlatter(),
                FruitPlatter(),
                SoupBowl(),
                TeaDispenser(),
                CoffeeDispenser()
            };
        }
        public MenuItem GetMenuItemById(int id)
        {
            if (id == 1)
                return CurlyFries();
            else if (id == 2)
                return HotWings();
            else if (id == 3)
                return GarlicBread();
            else if (id == 4)
                return SquidRings();
            else if (id == 5)
                return CheeseBurger();
            else if (id == 6)
                return KidsBurger();
            else if (id == 7)
                return ChickenNuggets();
            else if (id == 8)
                return Pizza();
            else if (id == 9)
                return Steak();
            else if (id == 10)
                return FishAndChips();
            else if (id == 11)
                return GardenSalad();
            else if (id == 12)
                return AllDayBreakfast();
            else if (id == 13)
                return IceCreamCone();
            else if (id == 14)
                return FruitSalad();
            else if (id == 15)
                return Sundae();
            else if (id == 16)
                return BananaSplit();
            else if (id == 17)
                return Cola();
            else if (id == 18)
                return Lemonade();
            else if (id == 19)
                return AppleJuice();
            else if (id == 20)
                return StrawberryMilk();
            else if (id == 21)
                return SodaWater();
            else if (id == 22)
                return SushiPlatter();
            else if (id == 23)
                return SandwichPlatter();
            else if(id == 24)
                return CheesePlatter();
            else if (id == 25)
                return FruitPlatter();
            else if (id == 26)
                return SoupBowl();
            else if (id == 27)
                return TeaDispenser();
            else if (id == 28)
                return CoffeeDispenser();

            return null;
        }

        public bool IsItemBelongToKidsItem(int id)
        {
            if (id == 6|| id == 7||id == 13)
                return true;

            return false;
        }
    }
}
