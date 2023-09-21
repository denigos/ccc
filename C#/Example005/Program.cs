Console.Write("Введите Имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
   Console.WriteLine("Ура это Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}