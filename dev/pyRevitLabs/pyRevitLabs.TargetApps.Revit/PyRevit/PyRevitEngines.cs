﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyRevitLabs.TargetApps.Revit {
    public static class PyRevitEngines {
        public static PyRevitEngine GetEngineFromManifest(RevitAddonManifest manifest, PyRevitClone clone) {
            foreach (var engine in clone.GetEngines())
                if (manifest.Assembly.Contains(engine.Path))
                    return engine;
            return null;
        }
    }
}
