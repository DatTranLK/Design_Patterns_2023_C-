using DesignPatterns2023.Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Builder
{
    public class CarBuilder : ICarBuilder
    {
        public int NumberOfWheels { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public string Color { get; set; }
        public Windscreen Windscreen { get; set; }
        public Engine Engine { get; set; }

        public CarBuilder AddEngine(Engine engine)
        {
            Engine = engine;
            return this;
        }

        public CarBuilder AddSeatBelts(SeatBelt seatBelt)
        {
            SeatBelt = seatBelt;
            return this;
        }

        public CarBuilder AddWheels(int numberOfWheels)
        {
           NumberOfWheels = numberOfWheels;
            return this;
        }

        public CarBuilder AddWindscreen(Windscreen windscreen)
        {
            Windscreen = windscreen;
            return this;
        }

        public Car Build()
        {
            return new Car(NumberOfWheels, SeatBelt, Color, Windscreen, Engine);
        }

        public CarBuilder Paint(string color)
        {
            Color = color;
            return this;
        }
    }
}
