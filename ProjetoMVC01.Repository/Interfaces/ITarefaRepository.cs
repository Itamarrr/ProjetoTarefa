using ProjetoMVC01.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC01.Repository.Interfaces
{
    public interface ITarefaRepository:IBaseRepository<Tarefas>
    {
        #region Métodos Abstratos
        List<Tarefas> GetByDatas(DateTime dataMin, DateTime dataMax);
        #endregion
    }
}
