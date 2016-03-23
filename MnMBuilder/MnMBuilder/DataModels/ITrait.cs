using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnMBuilder.DataModels
{
    public interface ITrait
    {
        string Name { get; set; }

        bool IsValid { get; }
    }
}
