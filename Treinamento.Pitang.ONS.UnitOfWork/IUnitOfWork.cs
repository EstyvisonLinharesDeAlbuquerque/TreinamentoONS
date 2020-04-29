using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.Pitang.ONS.UnitOfWork
{
    public interface IUnitOfWork
    {
       
        void Commit();
    }
}
