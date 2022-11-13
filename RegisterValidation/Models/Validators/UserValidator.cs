namespace RegisterValidation.Models.Validators;

public class UserValidator: AbstractValidator<User>
{
	public UserValidator()
	{
		RuleFor(user => user.Username).NotEmpty().WithMessage("");
	}
}