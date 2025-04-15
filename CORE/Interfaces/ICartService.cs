using System;
using CORE.Entities;

namespace CORE.Interfaces;

public interface ICartService
{
  Task<ShoppingCart?> GetCartAsync(string key);
  Task<ShoppingCart?> SetCartAsync(ShoppingCart cart);
  Task<bool> DeleteCartAsync(string key);
}
