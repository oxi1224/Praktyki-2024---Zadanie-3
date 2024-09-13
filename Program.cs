using System.Text;

string[] imiona = { "Ania", "Kasia", "Basia", "Zosia" };
string[] nazwiska = { "Kowalska", "Nowak" };

Random r = new();
StringBuilder sb = new StringBuilder();
sb.AppendLine("LP,Imię,Nazwisko,Rok urodzenia");
for (int i = 0; i < 100; i++) {
  string imie = imiona[r.Next(imiona.Length)];
  string nazwisko = nazwiska[r.Next(nazwiska.Length)];
  int rok = 1990 + r.Next(11);
  sb.AppendLine($"{i},{imie},{nazwisko},{rok}");
}

string data = DateTime.Now.ToString("HH_mm_dd_MM_yyyy");
FileStream f = File.Open($"C:\\test\\users-{data}.txt", FileMode.OpenOrCreate);
f.Write(Encoding.UTF8.GetBytes(sb.ToString()));
f.Close();
