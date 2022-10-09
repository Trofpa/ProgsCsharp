/* Сортировка min - max


*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortAscend(int[] array)
{
    
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; // Ищем min
        }
        //Swap
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

void SelectionSortDescend(int[] array)
{
    
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j; // Ищем max
        }
        //Swap
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}





PrintArray(arr);

SelectionSortAscend(arr);

PrintArray(arr);

SelectionSortDescend(arr);

PrintArray(arr);

/* Вопрос: каким образом адаптировать код,
чтобы производилось упорядочивание в обратном порядке?
- Решение метод SelectionSortDescent()
*/ 