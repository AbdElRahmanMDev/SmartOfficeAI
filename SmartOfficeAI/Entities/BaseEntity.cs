﻿namespace SmartOfficeAI.Entities;

public class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; } = false;
}
