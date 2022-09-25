namespace _08_rectangle;

public class Coordinate{
    public int X;
    public int Y;

    public Coordinate(int x, int y){
        X = x;
        Y = y;
    }
}

public class Rectangle
{
    public Coordinate TopLeft;
    public Coordinate BottomRight;

    double area, circ;

    public Rectangle(int x1, int y1, int x2, int y2){

        if(x1 == x2 || y1 == y2){
            throw new Exception("x1 cannot be equal to x2 and y1 cannot be equal to y2");
        }

        TopLeft = new Coordinate(Math.Min(x1,x2), Math.Min(y1,y2));
        BottomRight = new Coordinate(Math.Max(x1,x2), Math.Max(y1,y2));
        area =  (BottomRight.X - TopLeft.X)*(BottomRight.Y - TopLeft.Y);
        circ = (BottomRight.X - TopLeft.X)*2 + (BottomRight.Y - TopLeft.Y)*2;
    }

    public String GetArea(){
        return area.ToString();
    }

    public String GetCirc(){
        return circ.ToString();
    }

}

public class Circle
{
    public Coordinate Center;
    public int Radius;
    
    double area, circ;
    const double pi = Math.PI;

    public Circle(int x, int y, int radius){
        Center = new Coordinate(x,y);
        Radius = radius;
        area = pi*Radius*Radius;
        circ = 2*Radius*pi;
    }

    public double GetArea(){
        return area;
    }

    public double GetCirc(){
        return circ;
    }

}
