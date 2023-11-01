﻿namespace Play.Inventory.DTOs;

public class DtOs
{
    public record GrantItemsDto(Guid UserId, Guid CatalogItemId, int Quantity);
    
    public record InventoryItemDto(Guid CatalogItemId, int Quantity, DateTime AcquiredDate);
}