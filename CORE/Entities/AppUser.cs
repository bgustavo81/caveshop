using System;
using CORE.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity;

namespace CORE.Entities;

public class AppUser : IdentityUser
{
  public string? FirstName { get; set; }
  public string? LastName { get; set; }
  public Address? Address { get; set; }
}
