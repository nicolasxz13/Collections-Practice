int[] matrizNum = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string[] matrizNombres = { "Tim", "Martin", "Nikki", "Sara" };
bool[] matrizBoleana = { true, false, true, false, true, false, true, false, true, false };

List<string> saboresHelado = new List<string> { "Frutilla", "Chocolate", "Vainilla", "Menta", "Cafe", "Turron" };

Console.WriteLine("Cantidad de sabores de helados : " + saboresHelado.Count);

Console.WriteLine("Sabor de helado a eliminar : " + saboresHelado[3]);
saboresHelado.RemoveAt(3);

Console.WriteLine("Cantidad de sabores de helados : " + saboresHelado.Count);

Dictionary<string, string> usuarioInformacion = new Dictionary<string, string>();

for (int i = 0; i < matrizNombres.Length; i++)
{
    Random rand = new Random();
    int randomsabor = rand.Next(0, saboresHelado.Count - 1);
    usuarioInformacion.Add(matrizNombres[i], saboresHelado[randomsabor]);
}

foreach (var informacion in usuarioInformacion)
{
    Console.WriteLine("Nombre : " + informacion.Key + " --- " + informacion.Value);
}