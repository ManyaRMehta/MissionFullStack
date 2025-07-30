using System;
using System.ComponentModel.DataAnnotations;

namespace Mission.Entities.Entities;

public class MissionTheme
{
    [Key]
    public int Id { get; set; }
    public string ThemeName { get; set; }
    public string Status { get; set; }
}
