using FluentValidation;

namespace WebApi.Application.BookOperations.GetBookDetail
{
  public class GetBookDetailQueryValidator : AbstractValidator<GetBookDetailQuery>
  {
    public GetBookDetailQueryValidator()
    {
      RuleFor(commands=>commands.BookId).GreaterThan(0);
    }
  }
}