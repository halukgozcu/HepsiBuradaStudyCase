using HepsiBuradaStudyCase.App.Managers.Abstract;
using HepsiBuradaStudyCase.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Console = Colorful.Console;
using System.Linq;

namespace HepsiBuradaStudyCase.App.Managers.Concrete
{
    public class RoverManager : IRoverManager
    {
        public Rover Move(Rover rover)
        {
            if (!IsMovementValid(rover))
            {
                Console.WriteLine("Lütfen belirtilen hareketlerin karakterlerini kontrol ediniz. İçerisinde L,M ve R olmayan bir karakter olup olmadığından emin olunuz.", Color.MediumVioletRed);
            }
            else
            {
                bool isCoordinateValid = IsCoordinateValid(rover);

                if (!isCoordinateValid)
                {
                    Console.WriteLine($"Girilen koordinatlar sorunucunda sınırların dışına ( (0,0) ({rover.MaximumCoordinate.XCoordinate},{rover.MaximumCoordinate.YCoordinate}) )", Color.MediumVioletRed);
                }
                else
                {
                    Console.WriteLine($"Araç hareketine başladı. Başlangıç koordinatları : ({rover.RoverCoordinate.XCoordinate},{rover.RoverCoordinate.YCoordinate}). Aracın Yönü : {rover.Direction.ToString()} \n");

                    foreach (var movement in rover.Movement)
                    {

                        if (isCoordinateValid)
                        {
                            switch (movement)
                            {
                                case "M":
                                    rover = MoveForward(rover);
                                    break;
                                case "L":
                                    rover = RotateLeft(rover);
                                    break;
                                case "R":
                                    rover = RotateRight(rover);
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Girilen koordinatlar sorunucunda sınırların dışına ( (0,0) ({rover.MaximumCoordinate.XCoordinate},{rover.MaximumCoordinate.YCoordinate}) ) \n", Color.MediumVioletRed);
                        }

                        isCoordinateValid = IsCoordinateValid(rover);
                    }

                    if (isCoordinateValid)
                    {
                        Console.WriteLine($"Araç hareketi tamamlandı. Bitiş koordinatları : ({rover.RoverCoordinate.XCoordinate},{rover.RoverCoordinate.YCoordinate}) . Aracın Yönü : {rover.Direction.ToString()} \n", Color.GreenYellow);
                    }

                }
            }
            return rover;
        }



        private Rover RotateLeft(Rover rover)
        {
            switch (rover.Direction)
            {
                case Direction.N:
                    rover.Direction = Direction.W;
                    break;
                case Direction.S:
                    rover.Direction = Direction.E;
                    break;
                case Direction.E:
                    rover.Direction = Direction.N;
                    break;
                case Direction.W:
                    rover.Direction = Direction.S;
                    break;
            }
            return rover;
        }

        private Rover RotateRight(Rover rover)
        {
            switch (rover.Direction)
            {
                case Direction.N:
                    rover.Direction = Direction.E;
                    break;
                case Direction.S:
                    rover.Direction = Direction.W;
                    break;
                case Direction.E:
                    rover.Direction = Direction.S;
                    break;
                case Direction.W:
                    rover.Direction = Direction.N;
                    break;
            }
            return rover;
        }

        private Rover MoveForward(Rover rover)
        {
            switch (rover.Direction)
            {
                case Direction.N:
                    rover.RoverCoordinate.YCoordinate += 1;
                    break;
                case Direction.S:
                    rover.RoverCoordinate.YCoordinate -= 1;
                    break;
                case Direction.E:
                    rover.RoverCoordinate.XCoordinate += 1;
                    break;
                case Direction.W:
                    rover.RoverCoordinate.XCoordinate -= 1;
                    break;
            }
            return rover;
        }


        private bool IsCoordinateValid(Rover rover)
        {
            return ((rover.MaximumCoordinate.XCoordinate >= rover.RoverCoordinate.XCoordinate) && (rover.MaximumCoordinate.YCoordinate >= rover.RoverCoordinate.YCoordinate) && (rover.RoverCoordinate.XCoordinate >= 0) && (rover.RoverCoordinate.YCoordinate >= 0));
        }

        private bool IsMovementValid(Rover rover)
        {
            return rover.Movement.Any(z => (z == "M" || z == "R" || z == "L"));
        }
    }
}
