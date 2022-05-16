using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementacionClases.DTO;

namespace ImplementacionClases.DAL
{
    public class DatoDAL
    {

        private List<DatoDTO> listaDatos = new List<DatoDTO>();

        public DatoDAL()
        {
            this.listaDatos = new List<DatoDTO>();
        }
        public bool Insertar(DatoDTO datos)
        {
            try
            {
                listaDatos.Add(datos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Actualizar(DatoDTO datos)
        {
            return false; // NO OLVIDAR!!!!!!!! 
        }

        public bool Eliminar(DatoDTO datos)
        {
            return false; //NO OLVIDAR!!!!!!!
        }

        public List<DatoDTO> Listar()
        {
            return listaDatos;
        }
    }
}
