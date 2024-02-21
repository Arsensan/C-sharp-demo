using System;

public class Homework {
   

    static public void Main(string[] args) {
     //   Homework.Multiply(17);
      //  Homework.Coordinates (0,-1);
    //  Homework.MaxNumber(100);
    Homework.NaturalNumber(325);
      
}
 // 1) Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
public static void Multiply (int a) {
 if (a % 7 == 0 | a % 23 == 0){
    Console.Write("Кратно");
 }
 else{
    Console.Write("Не кратно"); 
 }
}

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// выдаёт номер координатной четверти плоскости, в которой находится эта точка.
public static void Coordinates (int x, int y){
if( x != 0 | y != 0){
    if ( x > 0 & y > 0) {
         Console.Write("1");
    }
    if ( x < 0 & y > 0) {
         Console.Write("2");
    } 
     if ( x < 0 & y < 0) {
         Console.Write("3");
    }
     if ( x > 0 & y < 0) {
         Console.Write("4");
    }
}
    Console.Write("Ни одна из координат не должна быть равна 0");
}
//Задача 3: Напишите программу, которая принимает
//на вход целое число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
public static void MaxNumber (int x){
    int first = 0;
    int second = 0;
    if ( x >= 10 & x <= 99){
 first = x/10;
 second = x%10;
 if (first > second){
    Console.Write(first);
 } else if (second > first){
     Console.Write(second);
 } else{
  Console.Write("Числа равны");
 }
    }
    else {
        Console.Write("Число должно быть больше 9 и меньше 100");
    }
}

// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую. 687

public static void NaturalNumber (int x){
 if (x > 0){
        int num = x;
        int count = 0;
        int digit = 0;
        while (num > 0){
            num /=10;
            count++;
        }
        for (int i = 0; i < count; i++) {
            digit  = x %10;
            x /=10;
            Console.Write(digit + ",");
        }
    }
}
}