Console.Write("Введите имя пользователя : ");
string username = Console.ReadLine();

if(username.ToLower() == "влад")
{
    Console.WriteLine("Ура, это же ВЛАД ЧЕПУХ !!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}