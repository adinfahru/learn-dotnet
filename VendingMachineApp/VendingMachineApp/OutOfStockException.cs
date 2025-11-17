namespace VendingMachineApp;

public class OutOfStockException : Exception
{
  public OutOfStockException(string message) : base(message)
  {
    
  }
}