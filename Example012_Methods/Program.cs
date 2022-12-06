//Вид 1
void Met1()
{
    Console.WriteLine("Автор ...");
}
Met1();



//Вид 2
void Met2(string msg)
{
    Console.WriteLine(msg);
}
Met2("Текст сообщения ");



//Вид 21

void Met21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Met21("Текст",4);
//Met21(msg: "Текст", count: 4);
Met21(count: 2, msg: "New text");



//Вид 3

int Met3()
{
    return DateTime.Now.Year;
}
int year = Met3();
Console.WriteLine(year);



//Вид 4
string Met4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Met4(10, "Guzel");
Console.WriteLine(res);


