using ClassLibrary1.Execeptions.ExeptionsBase;
using curso_rocket.Communication.Requests;
using curso_rocket.Communication.Response;


namespace curso_c_.API.UseCases.Clients.Register;

public class RegisterClientUseCase
{
    public ResposeClientJson Execute(ClientsRequestJson request)

    {
        var validator = new RegisterClientValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errors);
        }

        return new ResposeClientJson();

    }
}
