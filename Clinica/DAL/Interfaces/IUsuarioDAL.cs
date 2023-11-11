﻿using System;
using Entities.Entities;

namespace DAL.Interfaces
{
    public interface IUsuarioDAL : IDALGenerico<Usuario>
    {
        Task<IEnumerable<SpObtenerInfoUsuariosConRolResult>> GetUsuariosInfo();
    }
}

