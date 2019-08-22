using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Model.Interfaces
{
    public interface IDatabaseOperation
    {
        void Write(List<PersonDetails> list);
        void Read();     
    }
}
