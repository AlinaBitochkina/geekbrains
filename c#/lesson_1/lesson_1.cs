//ввод будет происходит в той же строке, а если writeline - то на новой

Console.WriteLine("Введите ваше имя:");

// инициализация переменной username с типом данных string, сохранение текста с консоли в переменной

string username = Console.ReadLine();

// выводит текст приветик в одну строку вместе с именем

Console.Write("Приветик, ");
Console.Write(username);