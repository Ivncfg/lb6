using System;

class Quaternion
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public double W { get; set; }

    // Конструктор та інші методи

    public static Quaternion operator +(Quaternion a, Quaternion b)
    {
        return new Quaternion
        {
            X = a.X + b.X,
            Y = a.Y + b.Y,
            Z = a.Z + b.Z,
            W = a.W + b.W
        };
    }

    public static Quaternion operator -(Quaternion a, Quaternion b)
    {
        return new Quaternion
        {
            X = a.X - b.X,
            Y = a.Y - b.Y,
            Z = a.Z - b.Z,
            W = a.W - b.W
        };
    }

    public static Quaternion operator *(Quaternion a, Quaternion b)
    {
        return new Quaternion
        {
            X = a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y,
            Y = a.W * b.Y - a.X * b.Z + a.Y * b.W + a.Z * b.X,
            Z = a.W * b.Z + a.X * b.Y - a.Y * b.X + a.Z * b.W,
            W = a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z
        };
    }

    public double Norm()
    {
        // Логіка обчислення норми
        return Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
    }

    public Quaternion Conjugate()
    {
        // Логіка обчислення спряженого кватерніона
        return new Quaternion { X = -X, Y = -Y, Z = -Z, W = W };
    }

    public Quaternion Inverse()
    {
        // Логіка обчислення інверсії кватерніона
        double norm = Norm();
        return new Quaternion { X = -X / norm, Y = -Y / norm, Z = -Z / norm, W = W / norm };
    }

    public static bool operator ==(Quaternion a, Quaternion b)
    {
        // Логіка порівняння
        return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
    }

    public static bool operator !=(Quaternion a, Quaternion b)
    {
        // Логіка порівняння
        return !(a == b);
    }

    // Конвертація в матрицю обертання та навпаки
}

