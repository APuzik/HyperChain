using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HyperChainModel.Enums
{
    public enum WordChainType
    {
        [EnumMember(Value = "Normal")]
        eNormal = 0,
        [EnumMember(Value = "Ignored")]
        eIgnored,
        [EnumMember(Value = "Tentative")]
        eTentative,
        [EnumMember(Value = "Absent")]
        eAbsent
    }
}
