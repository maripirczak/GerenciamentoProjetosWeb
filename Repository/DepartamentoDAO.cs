using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class DepartamentoDAO: IRepository<Departamento>
    {
        private readonly Context _context;

        public DepartamentoDAO(Context context)
        {
            _context = context;
        }

        public void CadastrarDepartamento(Departamento d)
        {
            _context.Departamentos.Add(d);
            _context.SaveChanges();
        }

        //Where: metodo que retorna todas as ocorrências em uma busca
        public List<Departamento> ListarDepartamentos()
        {
            return _context.Departamentos.ToList();
        }






    }
}
