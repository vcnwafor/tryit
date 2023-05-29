﻿namespace FluentPos.Catalog.Application.Products.Dtos;
public class ProductDetailsDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Details { get; set; }
    public string? Code { get; set; }
    public string? Slug { get; set; }
    public decimal? Price { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? LastModifiedOn { get; set; } = null;
}
