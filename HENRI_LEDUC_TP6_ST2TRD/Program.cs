using System;
using HENRI_LEDUC_TP6_ST2TRD.Properties;

namespace HENRI_LEDUC_TP6_ST2TRD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Pizza Builder 
            PizzaBuilder order = new PizzaBuilder();
            order.SetBase("Tomato");
            order.SetMozzarella();
            order.SetToppings("Ham, Mushroom");
            order.SetSauce("Hot Sauce");

            Console.WriteLine("####### Pizza Order #######");
            Console.WriteLine(order);

            //Baseball Template
            Console.WriteLine("####### Baseball Play #######");
            Pitcher Johnson = new Pitcher("Mariners", "Johnson");
            Pitcher Martinez = new Pitcher("Red Sox", "Martinez");
            Fieldplayer Williams = new Fieldplayer("Red Sox", "Williams");
            Johnson.Pitch();
            Williams.Swing();
            Martinez.Pitch();
            Johnson.Swing();
        }
    }
}