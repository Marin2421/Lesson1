Console.WriteLine("Введите величину в милиметрах:");
double mm = int.Parse(Console.ReadLine());
double cm = mm / 10;
double m = mm / 1000;
double km = mm / 1000000;
double mili = mm / 1609344;
double ird = mm / 914.4;
Console.WriteLine($"Сантиметры: {cm}. Метры: {m}. Километры: {km}. Мили: {mili}. Ярды: {ird}.");