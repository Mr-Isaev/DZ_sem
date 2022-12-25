Console.Clear();
Console.WriteLine("Программa, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.Write("Введите цифру ");
int a = Convert.ToInt32(Console.ReadLine());

void Metod (int a) {
  if (a == 6 || a == 7) {
  Console.WriteLine("Выходной день");
  }
  else if (a < 1 || a > 7) {
    Console.WriteLine("Давай без этого, вводи от 1 до 7");
  }
  else Console.WriteLine("Будний день");
}

Metod(a);
