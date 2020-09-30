using HepsiBuradaStudyCase.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBuradaStudyCase.App.Managers.Abstract
{
    public interface IRoverManager
    {
        Rover Move(Rover rover);
    }
}
