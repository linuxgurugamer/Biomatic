using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Biomatic
{

    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class BiomaticUI
    {

        public void Awake() // Runs first
        {

        }

        public void Start()
        { }


        // Following get run multiple times

        public void OnGUI()
        { }

        public void Update()
        { }

        public void LateUpdate()
        { }

        // Runs when being destroyed
        public void OnDestroy()
        { }
    }
}
