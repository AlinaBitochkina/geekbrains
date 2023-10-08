void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Random rnd = new Random();
    while (index < length) 
    {
        collection[index] = rnd.Next(1, 20);
        index++;
        
    }
}
//функция 
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;   
    while (position < count) 
    {
        Console.WriteLine(col[position]);   
        position++; 
    }
}

int IndexOf (int []collection, int find)
{
    int count = collection.length;
    int index = 0;
    int position = 0;
    while(inex < count)
    {

    }


}
//это был первый шаг, определили массив из 10 элементов    

int[] array = new int[10];

//вызвали метод FillArray который заполнил массив
// и метод PrintArray который вывел массив
FillArray(array);
PrintArray(array);