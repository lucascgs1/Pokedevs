﻿using Pokedevs.Models;
using System.Collections.Generic;

namespace Pokedevs.Services.Interfaces
{
    public interface IUsuarioServices
    {
        #region crud

        /// <summary>
        /// obtem um usuario pelo codigo
        /// </summary>
        /// <param name="id">codigo do usuario</param>
        /// <returns>dados do usuario</returns>
        Usuario GetById(int id);

        /// <summary>
        /// obtem os dados de todos os usuarios
        /// </summary>
        /// <returns></returns>
        IEnumerable<Usuario> GetAllUsuarios();

        /// <summary>
        /// Salva ou atualiza um usuario
        /// </summary>
        /// <param name="usuarioNovo">dados do usuario</param>
        /// <param name="usuarioId">codigo do usuario autenticado</param>
        /// <returns></returns>
        Usuario Save(Usuario usuario, int usuarioId = 0);

        /// <summary>
        /// exclui um usuario pelo codigo
        /// </summary>
        /// <param name="usuarioId">codigo do usuario</param>
        void DeleteById(int usuarioId);

        #endregion crud
    }
}