using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios
{
    public class FrutoSecoServicio
    {
        private readonly RepositorioFrutoSeco _frutosecoRepositorio = null!;
        public FrutoSecoServicio(string ruta)
        {
            _frutosecoRepositorio = new RepositorioFrutoSeco(ruta);
           
        }


        public List<FrutoSeco> GetFrutosSecos()
        {
            return _frutosecoRepositorio.GetFrutosSecos();
        }
    }
}
