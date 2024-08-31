﻿using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    public string? WarmUp { get; set; }
    public string? Technics { get; set; }
    public string? Choreo { get; set; }
}
