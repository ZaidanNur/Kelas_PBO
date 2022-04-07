bool counter = true;
do
{
    Console.Write("Masukkan Nilai x : ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Masukkan Operasi (+,-,*,/) : ");
    char OPERASI = Convert.ToChar(Console.ReadLine());

    Console.Write("Masukkan Nilai y : ");
    int y = Convert.ToInt32(Console.ReadLine());

    if (OPERASI == '+')
    {
        Console.WriteLine("Hasil dari x + y = {0}", x + y);
    }
    else if (OPERASI == '-')
    {
        Console.WriteLine("Hasil dari x - y = {0}", x - y);
    }
    else if (OPERASI == '*')
    {
        Console.WriteLine("Hasil dari x * y = {0}", x * y);
    }
    else if (OPERASI == '/')
    {
        Console.WriteLine("Hasil dari x / y = {0}", Convert.ToDouble(x) / Convert.ToDouble(y));
    }
    else
    {
        Console.WriteLine("Simbol Operasi Salah");
    }

    Console.Write("Mulai Lagi? (y/n) : ");
    char ulang = Convert.ToChar(Console.ReadLine());

    if (ulang == 'y')
    {
        counter = true;
    }
    else
    {
        counter = false;
    }
}
while (counter);

Console.ReadLine();