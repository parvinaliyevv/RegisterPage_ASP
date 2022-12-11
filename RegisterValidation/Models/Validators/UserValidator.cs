namespace RegisterValidation.Models.Validators;

public class UserValidator: AbstractValidator<User>
{
	public UserValidator()
	{
		RuleFor(user => user.Username).MinimumLength(5).WithMessage("Username length cannot be less than 5");
		RuleFor(user => user.Username).MaximumLength(20).WithMessage("Username length cannot be more than 20");
		RuleFor(user => user.Username).Matches("^[a-zA-Z0-9]").WithMessage("Username can only contain letters and numbers");

		RuleFor(user => user.Email).EmailAddress().WithMessage("You should use '@' and '.'");

        RuleFor(user => user.Password).MinimumLength(5).WithMessage("Password length cannot be less than 5");
        RuleFor(user => user.Password).MaximumLength(30).WithMessage("Password length cannot be more than 30");
        RuleFor(user => user.Password).Matches("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
    }
}
