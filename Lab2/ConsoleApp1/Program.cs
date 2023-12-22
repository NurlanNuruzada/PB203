#region Task1
//Verilmis ededin kavadratini tapan proqram
//Console.Write("Ededi Daxil Edin :");
//string numberStr = Console.ReadLine();
//int number = int.Parse(numberStr); 
//int number2 = Convert.ToInt32(numberStr); 
//int Result  = 0;
//Result = number2 * number2;
//Console.WriteLine(Result);
#endregion
#region Task2
//Verilmis ededin verilmis quvvetini tapan proqram
//Console.Write("Ededi Daxil Edin :");
//string numberStr = Console.ReadLine();
//Console.Write("Quvveti Daxil Edin :");
//string number2Str = Console.ReadLine();
//int number = Convert.ToInt32(numberStr);
//int power = Convert.ToInt32(number2Str);
//int Result = 1;
//for (int i = 0; i < power; i++)
//{
//    Result *= number;
//}
//Console.WriteLine(Result);
#endregion
#region Task3
//2-ci meselede verilmis quvvet musbet eded olmasa yeniden daxil edilmesini istesin
//Console.Write("Ededi Daxil Edin :");
//string numberStr = Console.ReadLine();
//Console.Write("Quvveti Daxil Edin :");
//string number2Str = Console.ReadLine();
//int number = Convert.ToInt32(numberStr);
//int power = Convert.ToInt32(number2Str);
//int Result = 1;
//do
//{
//    Console.Write("Quvveti Daxil Edin :");
//    number2Str = Console.ReadLine();
//    power = Convert.ToInt32(number2Str);
//}
//while (power < 0);

//for (int i = 0; i < power; i++)
//{
//    Result *= number;
//}
//Console.WriteLine(Result);
#endregion
#region Task4
// verilmis yazinin icindeki boslularin sayini tapan proqram
//Console.WriteLine("Yazinin Daxil edin :");
//string Str = Console.ReadLine();
//string TempStr = "";
//for (int i = 0; i < Str.Length; i++){
//    if (Str[i] !=  ' ')
//    {
//        TempStr += Str[i];
//    }
//}
//Console.WriteLine(TempStr);
#endregion
#region Task5
//verilmis textin solundan verilen eded geder silinsin 
//Console.WriteLine("Bir metin daxil edin ");
//string text = Console.ReadLine();
//Console.WriteLine("bir eded daxil edin ");
//int num = Convert.ToInt32(Console.ReadLine());
//string result = "";
//for (int i = num; i < text.Length; i++)
//{
//    result += text[i];
//}
//Console.WriteLine(result);

#endregion
#region Task6
//Verilmis adlar siyahisinda adinin uzunlugu 5-den uzun olan nece ad oldugunu tapanm proqram
//Console.WriteLine("Adlar Siyahisinin uzunlugunu daxil edin:");
//string lengthStr = Console.ReadLine();
//int length = int.Parse(lengthStr);
//string[] names = new string[length];

//for (int i = 0; i < names.Length; i++)
//{
//    Console.Write($"ad daxil edin #{i + 1}: ");
//    names[i] = Console.ReadLine();
//}

//int sum = 0;
//for (int i = 0; i < names.Length; i++)
//{
//    if (names[i].Length > 5)
//    {
//        sum++;
//    }
//}
//Console.WriteLine("boyukler: " + sum);
#endregion
#region Task7
//Verilmis adlar siyahisinda adinin uzunlugu 5-den uzun olan adlardan
//ibaret yeni bir array duzelden proqram
//Console.WriteLine("Adlar Siyahisinin uzunlugunu daxil edin:");
//string lengthStr = Console.ReadLine();
//int length = int.Parse(lengthStr);
//string[] names = new string[length];

//for (int i = 0; i < names.Length; i++)
//{
//    Console.Write($"ad daxil edin #{i + 1}: ");
//    names[i] = Console.ReadLine();
//}
//int sum = 0;
//for (int i = 0; i < names.Length; i++)
//{
//    if (names[i].Length > 5)
//    {
//        sum++;
//    }
//}
//int Index = 0;
//string[] LongNames = new string[sum];
//for (int i = 0; i < names.Length; i++)
//{
//    if (names[i].Length > 5)
//    {
//        LongNames[Index] = names[i];
//        Index++;
//    }
//}

//for (int i = 0; i < LongNames.Length; i++)
//{
//    Console.WriteLine("Boyuk ad  " + LongNames[i]);
//}
//Console.WriteLine("boyukler: " + sum);
#endregion


