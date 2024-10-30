string[] snacks = { "sushi", "Riis kanaga", "hiinakat", "wrapp", "vana villem", "pasta", "burks" };


Random rnd = new Random();
int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"We go eat {snacks[randomIndex]}");
