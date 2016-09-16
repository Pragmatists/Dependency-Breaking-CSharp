namespace BreakOutMethodObject
{
    public class OrderItem
    {
        public int Quantity { get; } 
        public int Size { get; }

        public OrderItem(int quantity, int size)
        {
            Quantity = quantity;
            Size = size;
        }
    }
}