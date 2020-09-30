using HepsiBuradaStudyCase.App.Managers.Abstract;
using HepsiBuradaStudyCase.App.Managers.Concrete;
using HepsiBuradaStudyCase.App.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Console = Colorful.Console;
namespace HepsiBuradaStudyCase.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Haluk GÖZCÜ - Hepsiburada Study Case";
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.WriteAscii(" GOREVIMIZ MARS :) ", Color.FromArgb(244, 212, 255));

            int numberOfRovers = 1;
            Coordinate maxCoordinate = new Coordinate();
            List<Rover> roverList = new List<Rover>();

            Console.WriteLine("Hoşgeldin Sevgili Mars Kaşifi :) \n\n Öncelikle senden gidebileceğimiz maksimum X ve Y koordinatlarını alalım.", Color.LightYellow);

            Console.WriteLine();

            Console.Write("Maksimum X koordinatı : ");
            maxCoordinate.XCoordinate = int.Parse(Console.ReadLine());

            Console.Write("Maksimum Y koordinatı : ");
            maxCoordinate.YCoordinate = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Teşekkürler. Şimdi bir de senden kaç tane öncü araç göndereceğini öğrenmemiz gerekiyor. Araç sayısı : ", Color.LightYellow);
            numberOfRovers = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= numberOfRovers; i++)
            {
                Rover rover = new Rover() { MaximumCoordinate = maxCoordinate };
                Console.Write($" {i}. aracın X koordinatı : ", i % 2 == 0 ? Color.LightYellow : Color.LightPink);
                rover.RoverCoordinate.XCoordinate = int.Parse(Console.ReadLine());
                Console.Write($" {i}. aracın Y koordinatı : ", i % 2 == 0 ? Color.LightYellow : Color.LightPink);
                rover.RoverCoordinate.YCoordinate = int.Parse(Console.ReadLine());
                Console.Write($" {i}. aracın yön bilgisini istiyoruz şimdi de. (N = Kuzey, E = Doğu, W = Batı, S = Güney) : ", i % 2 == 0 ? Color.LightYellow : Color.LightPink);
                rover.Direction = (Direction)Enum.Parse(typeof(Direction), Console.ReadLine().ToUpper());
                Console.Write($" Harikasın. {i}. aracın hareket bilgilerini arada boşluk olmadan yazmanı istiyoruz. \n (M = İleri Git, R = 90 derece sağa dön, L = 90 derece sola dön) (MLRRLM gibi): ", i % 2 == 0 ? Color.LightYellow : Color.LightPink);
                rover.Movement = Console.ReadLine().Select(z => z.ToString().ToUpper()).ToList();
                Console.WriteLine();
                Console.WriteLine("-----*****-----", Color.LightCyan);
                Console.WriteLine();
                roverList.Add(rover);
            }

            Console.WriteLine("\n\n Kemerlerini sıkı bağla. Başlıyoruz...");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);

            IRoverManager roverManager = new RoverManager();

            for (int i = 0; i < roverList.Count; i++)
            {
                roverManager.Move(roverList[i]);
                Console.WriteLine();
                Console.WriteLine($"{i + 1}. aracın işlemi tamamlandı.", i % 2 == 0 ? Color.LightYellow : Color.LightPink);
                Console.WriteLine();
                Console.WriteLine("-----*****-----", Color.Aquamarine);
            }


            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
