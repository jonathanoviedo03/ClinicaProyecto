﻿using System;
using Entities.Entities;

namespace DAL.Interfaces
{
    public interface IDiagnosticoDAL : IDALGenerico<Diagnostico>
    {
        Task<IEnumerable<SpObtenerInfoDiagnosticosResult>> GetDiagnosticosInfo();
    }
}

