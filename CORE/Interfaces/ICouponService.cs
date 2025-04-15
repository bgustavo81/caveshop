using System;
using CORE.Entities;

namespace CORE.Interfaces;

public interface ICouponService
{
  Task<AppCoupon?> GetCouponFromPromoCode(string code);
}
