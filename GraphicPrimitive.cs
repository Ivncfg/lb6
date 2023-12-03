using System;
using System.Collections.Generic;

// Абстрактний клас GraphicPrimitive
abstract class GraphicPrimitive
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Draw();
    public abstract void Move(int x, int y);
}

// Спадкоємці класу GraphicPrimitive
class Circle : GraphicPrimitive
{
    public int Radius { get; set; }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Circle at ({X}, {Y}) with Radius {Radius}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Circle to ({X}, {Y})");
    }
}

class Rectangle : GraphicPrimitive
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Rectangle at ({X}, {Y}) with Width {Width} and Height {Height}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Rectangle to ({X}, {Y})");
    }
}

class Triangle : GraphicPrimitive
{
    public int SideLength { get; set; }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Triangle at ({X}, {Y}) with Side Length {SideLength}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Triangle to ({X}, {Y})");
    }
}

// Клас Group
class Group : GraphicPrimitive
{
    private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

    public void AddPrimitive(GraphicPrimitive primitive)
    {
        primitives.Add(primitive);
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Group at ({X}, {Y})");
        foreach (var primitive in primitives)
        {
            primitive.Draw();
        }
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Group to ({X}, {Y})");
        foreach (var primitive in primitives)
        {
            primitive.Move(x, y);
        }
    }
}

// Клас GraphicsEditor
class GraphicsEditor
{
    private List<GraphicPrimitive> graphicPrimitives = new List<GraphicPrimitive>();

    public void AddGraphicPrimitive(GraphicPrimitive graphicPrimitive)
    {
        graphicPrimitives.Add(graphicPrimitive);
    }

    public void DrawAll()
    {
        foreach (var primitive in graphicPrimitives)
        {
            primitive.Draw();
        }
    }

    public void Scale(float factor)
    {
        foreach (var primitive in graphicPrimitives)
        {
            // Логіка масштабування кожного примітиву
            if (primitive is Circle circle)
            {
                circle.Radius = (int)(circle.Radius * factor);
            }
            else if (primitive is Rectangle rectangle)
            {
                rectangle.Width = (int)(rectangle.Width * factor);
                rectangle.Height = (int)(rectangle.Height * factor);
            }
            else if (primitive is Triangle triangle)
            {
                // Логіка масштабування трикутника
            }
            else if (primitive is Group group)
            {
                group.Scale(factor);
            }
        }
    }
}
