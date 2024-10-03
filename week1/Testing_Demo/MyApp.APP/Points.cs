namespace MyApp.APP;

public class Point
{
    private int _x = 0;
    private int _y = 0;

    public Point(){}

    public void Set_X(int x)
    {
        if(x < -100) _x = -100;
        else if(x > 100) _x = 100;
        else _x = x;
    }

    public int Get_X()
    {
        return _x;
    }

    public int Y {
        get => _y;
        set
        {
            if(value < -100) _y = -100;
            else if(value > 100) _y = 100;
            else _y = value;
        }
    }

    public override string ToString()
    {
        return $"{_x}, {_y}";
    }
}