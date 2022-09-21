using System;

class Vehicle
{
    public int count;
    public int speed;
    public int year;
    public Vehicle(int count,int speed,int year)
    {
        this.count = count;
        this.speed = speed;
        this.year = year;
    }
    public virtual void print()
    {
        Console.WriteLine($"count: {count} speed: {speed} yaer: {year} ");
    }
}

class Plane : Vehicle
{
    int hight;
    int passeger;
    public Plane(int count, int speed, int year, int hight, int passeger) : base(count, speed, year)
    {
        this.hight = hight;
        this.passeger = passeger;
    }
    public override void print()
    {
        Console.WriteLine("plane");
        base.print();
        Console.WriteLine($"hight: {hight} passeger: {passeger}");
    }

}

class Car : Vehicle
{
    public Car(int count, int speed, int year) : base(count, speed, year) { }
    public override void print()
    {
        Console.WriteLine("car");
        base.print();
    }

}

class Ship : Vehicle
{
    string port;
    int passegers;
    public Ship(int count, int speed, int year, string port, int passegers) : base(count, speed, year)
    {
        this.port = port;
        this.passegers = passegers;
    }
    public override void print()
    {
        Console.WriteLine("ship");
        base.print();
        Console.WriteLine($"port: {port} passegers: {passegers}");
    }

}
class Program
    {
        static void Main(string[] args)
        {
        Car audi = new Car(1600000, 180, 2020);
        audi.print();
        Plane aero32 = new Plane(3000000, 500, 2022, 480, 160);
        aero32.print();
        Ship gr2 = new Ship(49209342, 380, 2009, "mew", 420);
        gr2.print();
        }
    }