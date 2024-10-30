using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public interface IGestor<T> where T : IEntidad
    {
        //Interfaz genérica con param T Gestor para declarar métodos CRUD
        List<T> ListarTodo();

        bool Guardar(T obj);

        bool Borrar(T obj);
    }
}
