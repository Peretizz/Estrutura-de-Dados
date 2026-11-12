int[] integerValues = {-11, 12, -42, 0, 1, 90, 6 , -9};

Console.WriteLine("Vetor original");

Console.WriteLine(string.Join("|", integerValues));

QuickSort.QuickSort.Sort(integerValues);

Console.WriteLine("Vetor ordenado");

Console.WriteLine(string.Join("|", integerValues));


string[] stringValues = {"Xernobil", "Eudes", "Mayckon", "Fernandes", "Serjão", "Gorgulho", "Matheus", "Christhian"};

Console.WriteLine("Vetor original");

Console.WriteLine(string.Join("|", stringValues));

QuickSort.QuickSort.Sort(stringValues);

Console.WriteLine("Vetor ordenado");

Console.WriteLine(string.Join("|", stringValues));

Console.WriteLine($"Numero de Operações: {QuickSort.QuickSort.OperationCount}");
Console.WriteLine($"Numero de Trocas: {QuickSort.QuickSort.SwapCount}");