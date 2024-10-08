using System;

namespace learndotnet.Entities;

public class Student
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string name { get; set; }
    public int age { get; set; }  
}
