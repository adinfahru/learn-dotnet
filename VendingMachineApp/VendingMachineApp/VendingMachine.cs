using VendingMachineApp;

public class VendingMachine
{
  private Dictionary<string, Item> _inventory = new Dictionary<string, Item>();
  private decimal _currentBalance;

  public decimal CurrentBalance
  {
    get { return _currentBalance; }
  }

  public VendingMachine()
  {
    _inventory = new Dictionary<string, Item>();
    InitializeInventory();
  }

  private void InitializeInventory()
  {
    _inventory.Add("A1", new Drink("Cola", 1.50m, 5));
    _inventory.Add("A2", new Drink("Water", 1.00m, 8));
    _inventory.Add("B1", new Chip("Chips", 1.25m, 3));
    _inventory.Add("B2", new Chip("Pretzels", 1.25m, 4));
    _inventory.Add("C1", new Candy("Candy Bar", 0.75m, 0));
    _inventory.Add("C2", new Candy("Gum", 0.50m, 1));
  }

  public Dictionary<string, Item> GetInventory()
  {
    return _inventory;
  }

  public void InsertMoney(decimal amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException();
    }
    else
    {
      _currentBalance += amount;
    }
  }

  public decimal Refund()
  {
    decimal tempBalance = _currentBalance;
    _currentBalance = 0;
    return tempBalance;
  }

  public decimal PurchaseItem(string selectionCode)
  {
    if (!_inventory.ContainsKey(selectionCode))
    {
      throw new KeyNotFoundException("");
    }

    var item = _inventory[selectionCode];

    if (item.Quantity <= 0)
    {
      throw new OutOfStockException("Stok abis");
    }

    if (_currentBalance < item.Price)
    {
      throw new InsufficientFundsException("Uang lu ghoib");
    }

    _currentBalance -= item.Price;
    item.Quantity--;

    Console.WriteLine($"\n  [Dispensing]: {item.Name}");

    item.Dispense();

    return _currentBalance;
  }
}