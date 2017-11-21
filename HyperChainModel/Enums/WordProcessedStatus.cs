using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HyperChainModel.Enums
{
    public enum WordProcessedStatus
    {
        [EnumMember(Value = "Не обработано")]
        NotProcessed,
        [EnumMember(Value = "В процессе")]
        InProgress,
        [EnumMember(Value = "Завершено")]
        Completed,
        [EnumMember(Value = "Просмотрено")]
        Reviewed,
    }
}
