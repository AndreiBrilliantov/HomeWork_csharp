// void - функции ничего не возвращают
void Method2(string msg) {
    Console.WriteLine(msg);
}
//Явное указание передаваемых аргументов
Method2(msg: "Text");


// Метод который возвращает значения
String Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //Задает пустую строку
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(text: "Привет", count: 4);
Console.WriteLine(res);