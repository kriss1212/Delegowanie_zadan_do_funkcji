using System;

public class Program
{
    public static void Main()
    {
        double x1 = 2.0; // współrzędna x początkowego punktu
        double y1 = 3.0; // współrzędna y początkowego punktu
        double x2 = 5.0; // współrzędna x końcowego punktu
        double y2 = 7.0; // współrzędna y końcowego punktu

        double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine("Długość odcinka: " + dlugosc);
    }

    public static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dlugosc = Math.Sqrt(dx * dx + dy * dy);
        return dlugosc;
    }
}
