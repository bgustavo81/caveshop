using System;

namespace CORE.Entities.OrderAggregate;

public enum OrderStatus
{
  Pending,
  PaymentRecieved,
  PaymentFailed,
  PaymentMismatch,
  Refunded
}
