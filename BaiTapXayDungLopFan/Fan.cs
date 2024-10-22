public class Fan
{
    const int SLOW = 1;

    const int MEDIUM = 2;

    const int HIGH = 3;

    private int speed = SLOW;

    private bool on = false;

    private double radius = 5;

    private string color = "blue";

    public int Speed {  get { return speed; } set { speed = value; } }

    public bool On { get { return on; } set { on = value; } }

    public double Radius { get { return radius; } set { radius = value; } }

    public string Color { get { return color; } set { color = value; } }

    public Fan(int speed, bool on, double radius, string color)
    {

    }
    public Fan()
    {

    }
    override public string ToString()
    {
        if (on == true)
        {
            return "Fans is On";
        }
        else
        {
            return "Fans is Off";
        }
    }
}

