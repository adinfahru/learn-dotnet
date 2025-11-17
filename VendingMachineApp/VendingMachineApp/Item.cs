public abstract class Item
{
  public string? Name { get; protected set; }
  public decimal Price { get; protected set; }
  public int Quantity { get; set; }

  protected Item(string name, decimal price, int quantity)
  {
    this.Name = name;
    this.Price = price;
    this.Quantity = quantity;
  }

  public abstract void Dispense();
}