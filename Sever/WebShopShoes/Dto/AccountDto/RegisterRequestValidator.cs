using FluentValidation;

namespace WebShopShoes.Dto.AccountDto
{
    public class RegisterRequestValidator : AbstractValidator<AccountDto>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Full name is required")
                .MaximumLength(50).WithMessage("Full can not over 50 characters");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone number is required");
            RuleFor(x => x.Username).NotEmpty().WithMessage("User name is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password is at least 6 characters");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("Confirm password is not match");
                }
            });
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is required");
        }
    }
}
