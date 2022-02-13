namespace HENRI_LEDUC_TP6_ST2TRD
{
    public interface Builder
    {
        void Reset(); // create the new pizza
        void SetBase(string pizzaBase); // set the pizza base 
        void SetMozzarella(); // add Mozzarella
        void SetToppings(string toppings); // add other topping

        void SetSauce(string sauce); // add sauces
    }
}