using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBuradaStudyCase.App.Models
{
    public class Rover
    {
        /// <summary>
        /// Başta belirtilen maksimum koordinatların tutulduğu yer.
        /// </summary>
        public Coordinate MaximumCoordinate { get; set; }
        /// <summary>
        /// Aracın bulunduğu koordinatlar
        /// </summary>
        public Coordinate RoverCoordinate { get; set; }
        /// <summary>
        /// Aracın Yönü
        /// </summary>
        public Direction Direction { get; set; }
        /// <summary>
        /// Aracın yapacağı hamleler dizisi
        /// </summary>
        public List<string> Movement { get; set; }

        public Rover()
        {
            this.RoverCoordinate = new Coordinate();
            this.MaximumCoordinate = new Coordinate();
            this.Movement = new List<string>();
        }
    }
}
