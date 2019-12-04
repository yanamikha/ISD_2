//3. Создать класс Vehicle.

//В теле класса создайте поля:  координаты и параметры средств передвижения(цена, скорость, год выпуска).  
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicle = new Vehicle[3];
            vehicle[1] = new Саг("55, 55", 231, 120, 1999);
            vehicle[0] = new Ship("11, 22", 600000, 120, 2000, 32, "gde-to");
            vehicle[2] = new Plane("null", 600000, 200, 2005, 3, 2);

            foreach(Vehicle value in vehicle)
            {
                Console.WriteLine(value.GetType().Name + ": \n" + value);
            }
        }
    }
    class Vehicle
    {
        public string Coordinates { get; protected set; }
        public decimal Price { get; protected set; }
        public byte Speed { get; protected set; }
        public int Year { get; protected set; }
        public Vehicle(string coord, decimal price, byte speed, int year)
        {
            Coordinates = coord;
            Price = price;
            Speed = speed;
            Year = year;
        }
     
    }
    class Plane : Vehicle
    {
        public double Highness { get; set; }
        public int CountOfPassengers { get; set; }
        public Plane(string coord, decimal price, byte speed, int year, double heighness, int countOfPassengers) : base(coord, price, speed, year)
        {
            Highness = heighness;
            CountOfPassengers = countOfPassengers;
        }
        public override string ToString()
        {
            return "coord: " + Coordinates + ", price: " + Price + ", speed: " + Speed + Price + ", year: " + Year + " highness: "+ Highness + " countOfPassengers: " + CountOfPassengers;
        }
    }
    class Саг : Vehicle
    {
        public Саг(string coord, decimal price, byte speed, int year) : base(coord, price, speed, year)
        {
        }
        public override string ToString()
        {
            return "coord: " + Coordinates + ", price: " + Price + ", speed: " + Speed + Price + ", year: " + Year;
        }
    }
    class Ship : Vehicle
    {
        public int CountOfPassengers { get; set; }
        public string Harbor { get; set; }
        public Ship(string coord, decimal price, byte speed, int year, int countOfPassengers, string harbor) : base(coord, price, speed, year)
        {
            CountOfPassengers = countOfPassengers;
            Harbor = harbor;
        }

        public override string ToString()
        {
            return "coord: " + Coordinates + ", price: " + Price + ", speed: " + Speed + Price + ", year: " + Year + ", countOfPassengers: " + CountOfPassengers+ ", harbor: " + Harbor;
        }
    }
}