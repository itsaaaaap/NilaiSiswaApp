// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string nama;

Console.WriteLine("Aplikasi Nilai Siswa Itsa");

Console.Write("Masukkan Nama Siswa: ");
nama = Console.ReadLine();

Console.Write("Input Nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
    Console.WriteLine("Selamat, kamu uda lulus.");
else
    Console.WriteLine("Maaf, kamu belom belom lulus.");