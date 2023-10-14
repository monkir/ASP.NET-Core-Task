using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<claasT, IdT, retT>
    {
        public List<claasT> All();
        public claasT Get(IdT Id);
        public retT Create(claasT Obj);
        public retT Update(int id, claasT Obj);
        public bool Delete(int id);
    }
}
