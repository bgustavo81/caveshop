using System;
using CORE.Entities;

namespace CORE.Interfaces;

public interface IPaymentService
{
  Task<ShoppingCart?> CreateOrUpdatePaymentIntent(string cartId);
  Task<string> RefundPayment(string paymentIntentId);
}
