using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Console = DevConsole.Console;

namespace Proto {
	public class Mod:ModBehaviour {
        public override void OnActivate() {
            Console.Log("Prototype mod activated.");
        }

        public override void OnDeactivate() {
            Console.Log("Prototype mod deactivated.");
        }
    }    
}
