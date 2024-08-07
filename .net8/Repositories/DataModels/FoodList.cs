﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.DataModels;

[Table("FoodList")]
public class FoodList
{
    [Key]
    public int FoodId { get; set; }

    public bool? IsVeg { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    public double Price { get; set; }

    [InverseProperty("Food")]
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    [InverseProperty("Food")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
