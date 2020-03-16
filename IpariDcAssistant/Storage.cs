using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpariDcAssistant
{
    static class Storage
    {
        public static string Info => $"Készítette: Csáktornyai Ádám József 13.C{Environment.NewLine}Discord: @CsakiTheOne#6800";
        public static string Version => "1.3";
        public static string[] Changelog => new string[] {
            "- a program alaposabban keresi a diákok fájlt",
            "- teljesen új design",
            "- easter egg-ek"
        };
    }
}
