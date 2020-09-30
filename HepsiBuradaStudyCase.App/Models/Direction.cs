using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HepsiBuradaStudyCase.App.Models
{
    /// <summary>
    /// Yönler
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Kuzey
        /// </summary>
        N = 1,
        /// <summary>
        /// Güney
        /// </summary>
        S = 2,
        /// <summary>
        ///Doğu
        /// </summary>
        E = 3, 
        /// <summary>
        /// Batı
        /// </summary>
        W = 4
    }
}
