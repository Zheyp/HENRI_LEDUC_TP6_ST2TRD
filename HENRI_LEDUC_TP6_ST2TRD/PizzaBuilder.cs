namespace HENRI_LEDUC_TP6_ST2TRD
{
    public class Pizza
    {
        public string PizzaBase;
        public string Mozzarella;
        public string Toppings;
        public string Sauce;
    }

    public class PizzaBuilder : Builder // do all the steps to create the pizza
    {
        private Pizza pizza;

        public PizzaBuilder() // Constructor
        {
            this.Reset(); // Start from scratch
        }
        
        public void Reset()
        {
            this.pizza = new Pizza();
        }

        public void SetBase(string pizzaBase)
        {
            this.pizza.PizzaBase = pizzaBase;
        }
        

        public void SetMozzarella()
        {
            this.pizza.Mozzarella = "Mozzarella";
        }

        public void SetToppings(string toppings)
        {
            this.pizza.Toppings = toppings;
        }

        public void SetSauce(string sauce)
        {
            this.pizza.Sauce = sauce;
        }

        public override string ToString()
        {
            return this.pizza.PizzaBase + " " + this.pizza.Mozzarella + "\nToppings : " +
                   this.pizza.Toppings + "\n" + this.pizza.Sauce;
        }
    }
}