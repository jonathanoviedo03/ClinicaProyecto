﻿using System;
using Entities.Entities;

namespace DAL.Interfaces
{
    public interface IEspecialidadDAL : IDALGenerico<Especialidad>
    {
        Task<IEnumerable<SpObtenerInfoEspecialidadesResult>> GetEspecialidadesInfo();
    }
}

