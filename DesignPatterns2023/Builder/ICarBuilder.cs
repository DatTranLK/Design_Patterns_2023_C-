using DesignPatterns2023.Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Builder
{
    public interface ICarBuilder
    {
        CarBuilder AddWheels(int numberOfWheels);
        CarBuilder AddSeatBelts(SeatBelt seatBelt);
        CarBuilder Paint(string color);
        CarBuilder AddWindscreen(Windscreen windscreen);
        CarBuilder AddEngine(Engine engine);
        Car Build();
    }
}
