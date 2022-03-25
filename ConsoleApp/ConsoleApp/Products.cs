namespace ConsoleApp
{
    public class Products
    {
        public string Warehouses;
        public string Name;
        public int Klgm;
        public double Ton;
        public double Remainder;

        public Products(string warehouses, string name, int klgm, double ton)
        {
            Warehouses = warehouses;
            Name = name;
            Klgm = klgm;
            Ton = ton;
        }
    }
}