using System;

namespace API.DTOs;

public class OrderItemDto
{
  public int ProductId { get; set; }
  public required string PorductName { get; set; }
  public required string PictureUrl { get; set; }
  public decimal Price { get; set; }
  public int Quantity { get; set; }
}
