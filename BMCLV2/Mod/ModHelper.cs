﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BMCLV2.Mod
{
    static class ModHelper
    {
        static public string SetupModPath(string version)
        {
            var versionPath = new StringBuilder(BmclCore.BaseDirectory +  @".minecraft\versions\");
            versionPath.Append(version).Append("\\");
            var modpath = new StringBuilder(versionPath.ToString());
            var configpath = new StringBuilder(versionPath.ToString());
            var coremodpath = new StringBuilder(versionPath.ToString());
            var moddirpath = new StringBuilder(versionPath.ToString());
            modpath.Append("mods");
            configpath.Append("config");
            coremodpath.Append("coremods");
            moddirpath.Append("moddir");
            if (!Directory.Exists(modpath.ToString()))
            {
                Directory.CreateDirectory(versionPath.ToString());
            }
            if (!Directory.Exists(configpath.ToString()))
            {
                Directory.CreateDirectory(configpath.ToString());
            }
            if (!Directory.Exists(coremodpath.ToString()))
            {
                Directory.CreateDirectory(coremodpath.ToString());
            }
            if (!Directory.Exists(moddirpath.ToString()))
            {
                Directory.CreateDirectory(moddirpath.ToString());
            }
            return versionPath.ToString();
        }
    }
}
