﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class BebidasDALObjetos : IBebidasDAL
    {
        public List<Bebida> ObtenerBebidas()
        {
            return new List<Bebida>
            {
            new Bebida
            {
            Nombre = "Frapuccino",
            Codigo = "FRAP-01"
            },
            new Bebida
            {
            Nombre="Cafe Del Dia",
            Codigo ="CAF-01"
            },
            new Bebida
            {
            Nombre="Te Del Dia",
            Codigo="TE-01"
            },
            new Bebida
            {
            Nombre="Te Chai",
            Codigo="TE-02"
            }
            };
        }


    }
}
