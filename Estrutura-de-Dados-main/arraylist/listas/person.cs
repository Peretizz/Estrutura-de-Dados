// Person.cs

// Aqui criamos uma classe de tipo de dado abstrato

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public CountryEnum Nationality { get; set; }

}

public enum CountryEnum
{
    BR, US, AR, PY, PL, UK, DE
}