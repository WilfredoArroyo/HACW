using HeladosLDSisInf.Context;
using HeladosLDSisInf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Controllers
{
    public class HIstorialVentasController
    {
        HeladeriaContext _context = new HeladeriaContext();
        //mostrar toda la lista en general
        public List<HistorialVenta> GetAll()
        {
            return _context.HistorialVenta.ToList();
        }
        //Ganancia de todo el historial de ventas
        public decimal GetAllGanancia()
        {
            _context.HistorialVenta.ToList();
            var SumaT = _context.HistorialVenta.Sum(x => x.Ganancia);
            return SumaT;
        }
        public decimal GetGananciaF(DateTime Inicio,DateTime Final)
        {
            SearchHV(Inicio, Final);
            var SumaInter = _context.HistorialVenta.Where(x => x.FechaHora >= Inicio && x.FechaHora <= Final).Sum(x => x.Ganancia);
            return SumaInter;
        }
        //para que devuelva algun elemento mencionado ->buscar
        //Buscar por descripcion
        public List<HistorialVenta> Search(String par)
        {
            if (String.IsNullOrEmpty(par))
            {
                return GetAll();
            }
            else
            {
                //Pe Devolver Perez 
                //Da Devolver Daniel,David,Danilo
                return _context.HistorialVenta.Where(x => x.V_Desc.Contains(par)).ToList();
            }
        }
        //buscar resultados por fechas 
        public List<HistorialVenta> SearchHV(DateTime Inicio, DateTime Final)
        {
            if (Inicio==null && Final==null)
            {
                return GetAll();
            }
            else
            {
                return _context.HistorialVenta.Where(x => x.FechaHora >= Inicio && x.FechaHora <= Final).ToList();
            }
        }

    }
}
