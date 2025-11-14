
try
{
    List<string> lista = new List<string>()
    {
        "Matemáticas",
        "Español",
        "Música",
    };

    lista.Add("Programación II");
    lista.Insert(lista.Count, "Programación II");
    lista.Insert(lista.Count, "Programación III");
    lista.Insert(lista.Count, "Programación");
    lista.Insert(0, "Historia de Honduras");
    //lista.Remove("Programación II");
    lista.RemoveAll(nombre => nombre.Contains("Programación"));

    Console.WriteLine($"Número de elementos en la lista: {lista.Count}");
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();

    Dictionary<int, string> dic = new Dictionary<int, string>()
    {
        {1, "Juan Perez"},
        {2, "Carlos Perez"},
    };
    dic.Add(15, "Sandra Perez");

    Console.WriteLine($"Cantidad de registros en el diccionario: {dic.Count}");
    foreach (var item in dic)
    {
        Console.WriteLine($"Clave: {item.Key}, Valor: {item.Value}");
    }
    //Console.WriteLine(dic[10]);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}