using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory62_ExtractInterface_after
{
    public interface IBillable
    {
        double GetRate();
        bool HasSpecialSkill();
    }
}
