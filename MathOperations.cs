using System;

class MathOperations
{
    public static T Add<T>(T a, T b)
    {
        dynamic result = a + b;
        return result;
    }

    public static T Subtract<T>(T a, T b)
    {
        dynamic result = a - b;
        return result;
    }

    public static T Multiply<T>(T a, T b)
    {
        dynamic result = a * b;
        return result;
    }

    // Додаткові операції можна додати аналогічним чином
}

