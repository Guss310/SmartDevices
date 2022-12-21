//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using AdapterExample;
using NecessaryClass;

namespace ProgramDemostration 
{
    /// <summary>
    /// Demostración 
    /// </summary>
    public static class Demostration
    {
        /// <summary>
        /// Main de Demostration
        /// </summary>
           public static void Main()
        {
            Plug plug = new Plug("1");
            ISmartDevice SmartPlug = new driver(plug);
            Console.WriteLine(SmartPlug.GetStatus());
            SmartPlug.On();
        }
    }
}
