using Life;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteInjector581
{
    public class Main : Plugin
    {
        /////////////////////////////////////////////////
        //Tout le code ne se trouve pas dans ce fichier//
        /////////////////////////////////////////////////

        public Main(IGameAPI api) : base(api) { }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[LiteInjector581] - Succes : Initialise !");
            Console.ResetColor();
        }
    }
}
