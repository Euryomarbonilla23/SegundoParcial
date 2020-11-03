using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcial.BLL
{
    public class TiposBLL
    {
        public static List<Tipos> GetList(Expression<Func<Tipos, bool>> criterio)
        {
            List<Tipos> lista = new List<Tipos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Tipos.Where(criterio).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}