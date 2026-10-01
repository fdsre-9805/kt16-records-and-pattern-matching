public record Point(double X, double Y);
public record Circle(Point Center, double Radius);
public record Rectangle(Point TopLeft, Point BottomRight);

static class ShapeClassifier
{
    public static string Classify(object shape)
    {
        return shape switch
        {
            Circle { Center: { X: 0, Y: 0 } } => "окружность в начале координат",
            Circle { Radius: 0 } => "вырожденная окружность (точка)",
            Circle c => "окружность радиусом " + c.Radius,
            Rectangle r when r.TopLeft == r.BottomRight => "вырожденный прямоугольник (точка)",
            Rectangle r => "прямоугольник " + Width(r) + " x " + Height(r),
            _ => "неизвестная фигура"
        };
    }

    static double Width(Rectangle r)
    {
        return (r.BottomRight.X - r.TopLeft.X);
    }

    static double Height(Rectangle r)
    {
        return (r.BottomRight.Y - r.TopLeft.Y);
    }
}
