using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace WebApi.Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommandValidator : AbstractValidator<CreateGenreCommand>
    {
        public CreateGenreCommandValidator()
        {
            RuleFor(x => x.Model.Name).NotEmpty().MinimumLength(4);
        }
    }
}