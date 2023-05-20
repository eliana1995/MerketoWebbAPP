﻿namespace WebbAPP.Models.Entities;

    public class ContactFormEntity
    {
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Massage { get; set; } = null!;

    public DateTime Created { get; set; } = DateTime.Now;
}

