// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

public class Program {

    public static void Main(string[] args) {

    
    // Array 1 dimensi
    string[] namaKelas = {"SI-24-01", "SI-24-02", "SI-24-03", "SI-24-04", "SI-24-05"};
    Console.WriteLine(namaKelas[0]);
    Console.WriteLine(namaKelas[2]);

    // Array Multidimensi
    char[,] Alphabets = {
        {'a', 'b', 'c'},
        {'d', 'e', 'f'}
    };

    Console.WriteLine(Alphabets[0,2]);


    // Array Jagged
    int[][] numeric = {
        new int[] {1,2,3},
        new int[] {4,5,6}
    };
    Console.WriteLine(numeric[1][2]);


    // Perulangan pada array 1 dimensi
    for (int i = 0; i < namaKelas.Length; i++) {
        Console.WriteLine(namaKelas[i]);
    }
    foreach (var kelas in namaKelas)
    {
        Console.WriteLine(kelas);
    } 

    // Perulangan pada array multidimensi
    for (int i = 0; i < Alphabets.GetLength(0); i++)
    {
        for (int k = 0; k < Alphabets.GetLength(i); k++)
        {
            Console.WriteLine(Alphabets[i,k]);
        }
    }
 
    // Perulangan pada jagged array
    for (int i = 0; i < numeric.Length; i++)
    {
        for (int k = 0; k < numeric[i].Length; k++)
        {
            Console.WriteLine(numeric[i][k]);
        }
    }

    }
}