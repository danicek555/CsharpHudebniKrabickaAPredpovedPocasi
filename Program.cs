// // See https://aka.ms/new-console-template for more information
// Console.Beep(329, 500);
// Console.Beep(329, 500);
// Console.Beep(349, 500);
// Console.Beep(392, 500);
// Console.Beep(392, 500);
// Console.Beep(349, 500);
// Console.Beep(329, 1000);
// Console.Beep(293, 500);
// Console.Beep(261, 500);
// Console.Beep(261, 500);
// Console.Beep(293, 500);
// Console.Beep(329, 500);
// Console.Beep(329, 1000);
// Console.Beep(293, 500);
// Console.Beep(293, 500);


int pondeli = Random.Shared.Next(-10, 40);
int utery = pondeli + 3;
int streda = utery - 2;
int ctvrtek = streda + 5;
int patek = ctvrtek - 4;
int sobota = patek - 1;
int nedele = sobota + 1;

Console.WriteLine("Pondělí: " + pondeli);
Console.WriteLine("Úterý: " + utery);
Console.WriteLine("Středa: " + streda);
Console.WriteLine("Čtvrtek: " + ctvrtek);
Console.WriteLine("Pátek: " + patek);
Console.WriteLine("Sobota: " + sobota);
Console.WriteLine("Neděle: " + nedele);