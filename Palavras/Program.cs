string firstName = "Gabriel";
string lastName = "Jesus";

string note = lastName.ToUpper () + " " + firstName;

string initials = lastName[0] + "" + firstName[0];

Console.WriteLine("" + initials);

// Formatação de String
string texto = string.Format ("{0} {1} nascido em {2}", firstName, lastName, "2009");

Console.WriteLine (texto);