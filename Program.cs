Console.Write("Введите желаемую длину массива: ");
int n = int.Parse(Console.ReadLine()!);
if (n <= 0){
    Console.WriteLine("Длина массива не может быть отрицательной или равна 0!");
} else {
    String[] array = GetArray(n);
    Console.WriteLine("Начальный заданный массив");
    PrintArray(array);
    Console.WriteLine();
    String[] res_array = TransformArray(array);
    Console.WriteLine("Массив с элементами, длина которых <= 3");
    PrintArray(res_array);
}


String[] GetArray(int n){
    String[] mas = new String[n];
    for (int i = 0; i < mas.Length; i++){
        Console.Write($"Введите значение {i+1}-го элемента массива: ");
        mas[i] = Console.ReadLine()!;
    }
    return mas;
}

void PrintArray(String[] mas){
    for (int i = 0; i < mas.Length; i++){
        Console.Write(mas[i]+ " ");
    }
}

String[] TransformArray(String[] array){
    int count  = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3){
            count++;
        }    
    }
    String[] res_array = new String[count];
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3){
            res_array[j] = array[i];
            j++;
        }    
    }
    return res_array;
}
