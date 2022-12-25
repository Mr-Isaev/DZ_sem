Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(number);
if (a.Length > 2){
  Console.WriteLine("Третья цифра: " + a[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}