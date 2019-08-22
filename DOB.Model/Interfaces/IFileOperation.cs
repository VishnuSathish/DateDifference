using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Model.Interfaces
{
    public interface IFileOperation
    {
        List<T> Serializer<T>(List<T> item);
        void Deserializer();
    }
}
