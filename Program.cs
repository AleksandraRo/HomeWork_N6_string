// //Задача 1: 
// //Задайте двумерный массив символов (тип char [,]).
// //Создать строку из символов этого массива. 


// char [,] Create2DCharArrayAZ(int row, int col){
//     char [,] ch = new char [row,col];
//     Random random = new Random();
//     for(int i = 0; i<row; i++){
//         for(int j=0; j<col; j++){
//             char randomChar = (char)random.Next('a', 'z' + 1);
//             ch[i,j] = randomChar;
//         }
//     }
//     return ch;
// }

// void Show2DCharArray(char [,] ch){
//     for(int i = 0; i<ch.GetLength(0); i++){
//         for(int j=0; j<ch.GetLength(1); j++){
//             Console.Write($"{ch[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// string MakeStringFromArray(char[,] ch){
//     string str = "";
//     foreach (char e in ch ) {
//         str += e;
//     }
//     return str; 
// }

// Console.Write("Введите количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int col = Convert.ToInt32(Console.ReadLine());

// char [,] ch = Create2DCharArrayAZ(row,col);
// Console.WriteLine("Двумерный массив символов:");
// Show2DCharArray(ch);
// Console.WriteLine();
// string str = MakeStringFromArray(ch);
// Console.WriteLine($"Строка из массива: {str}");

// Задача 2
//Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Console.WriteLine("Введите строку, содержащую латинские буквы в обоих регистрах:");
// string input = Console.ReadLine();
// string lowerstring = input.ToLower();
// Console.WriteLine(lowerstring);


//Задача 3 
// //Задайте произвольную строку. Выясните, является ли она палиндромом.


bool IsPalindrome(string str) {
    int k = str.Length;
    for (int i = 0; i < k / 2; i++) {
        if (str[i] != str[k - i - 1]) {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Введите строку для проверки на палиндром:");
string str = Console.ReadLine();
string lowerInput = str.ToLower();
if (IsPalindrome(lowerInput)) {
    Console.WriteLine("Строка является палиндромом.");
}
else {
    Console.WriteLine("Строка не является палиндромом.");
}

