using curso_rocket.Communication.Requests;
using FluentValidation;

namespace curso_c_.API.UseCases.Clients.Register;

public class RegisterClientValidator : AbstractValidator<ClientsRequestJson>
{
    public RegisterClientValidator() 
    {
        RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio");
        RuleFor(client => client.Email).EmailAddress().WithMessage("O EMAIL não é valido");
    }
}
