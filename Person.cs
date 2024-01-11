﻿namespace DateOnlyWebApiExample;

public sealed class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly? BirthDate { get; set; }
}
