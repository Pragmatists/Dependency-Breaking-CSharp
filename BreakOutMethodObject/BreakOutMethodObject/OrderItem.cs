namespace BreakOutMethodObject
{
    public class OrderItem
    {
        public int Quantity { get; } 
        public int Price { get; }
        public int Size { get; }

        public OrderItem(int quantity, int price, int size)
        {
            Quantity = quantity;
            Price = price;
            Size = size;
        }
    }
}