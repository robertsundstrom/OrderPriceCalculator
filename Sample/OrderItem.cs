﻿namespace OrderPriceCalculator.Sample;

using System.Collections.Generic;

public class OrderItem : IOrderItem2
{
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public double VatRate { get; set; }
    public double Quantity { get; set; }
    public decimal Vat { get; set; }
    public decimal Total { get; set; }

    public List<OrderDiscount> Discounts { get; set; } = new List<OrderDiscount>();
    public decimal? Discount { get; set; }

    IEnumerable<IDiscount> IHasDiscounts.Discounts => Discounts;
    IEnumerable<IDiscountWithTotal> IHasDiscountsWithTotal.Discounts => Discounts;

    public List<OrderCharge> Charges { get; set; } = new List<OrderCharge>();
    public decimal? Charge { get; set; }

    IEnumerable<ICharge> IHasCharges.Charges => Charges;
    IEnumerable<IChargeWithTotal> IHasChargesWithTotal.Charges => Charges;
}