/*
* PROJECT:          AuraTeam - CosmosLostLibrary
* CONTENT:          String Extentions
* PROGRAMMERS:      John Welsh <djlw78@gmail.com>
*                   
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuraTeam.CosmosLostLibrary
{
    class String
    {
        public static uint GetHashCode(string hashCode)
        {
            if (hashCode.Length == 0) return 0;
            uint hash = hashCode[0];
            for (int i = 1; hashCode[i] != 0; i++)
                hash = (hash << 4) + hashCode[i];
            return (uint)(hash % hashCode.Length);
        }
    }
}
