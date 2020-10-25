using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.DB
{
    public interface IEntity
    {
        void Populate(DataRow dr);
    }
}
