using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Datos.Repositorios
{
    public class RepositorioFrutoSeco
    {
        private List<FrutoSeco> _frutoseco = new();
        private readonly string ruta = null!;
        public RepositorioFrutoSeco(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
        }
       
        public List<FrutoSeco> GetFrutosSecos()
        {
            return _frutoseco;
        }

        private void LeerDatos()
        {
            if (!File.Exists(ruta))
            {
                return;
            }
            var registros = File.ReadAllLines(ruta);
            foreach (var registro in registros)
            {
                FrutoSeco frutoseco = ConstruirFrutoSeco(registro);
                _frutoseco.Add(frutoseco);
            }

        }

        private FrutoSeco ConstruirFrutoSeco(string registro)
        {
            var campos = registro.Split('|');
            var frutoSecoId = int.Parse(campos[0]);
            var nombreFrutoSeco = campos[1];
            return new FrutoSeco()
            {
                NombreFrutoSeco = nombreFrutoSeco,
                FrutoSecoId = frutoSecoId,
            };
        }
    }
}
