using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<ClassType, IdType, ReturnType>
    {
        List<ClassType> All();
        ClassType Get(IdType Id);
        ReturnType Add(ClassType Obj);
        ReturnType Update(ClassType Obj);
        bool Delete(IdType Id);

    }
}
