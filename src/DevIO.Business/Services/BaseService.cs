﻿using DevIO.Business.Models;
using FluentValidation;

namespace DevIO.Business.Services
{
    public abstract class BaseService
    {
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            return false;
        }
    }
}
