using curso_rocket.Communication.Requests;
using curso_rocket.Communication.Response;

namespace curso_c_.API.UseCases.Clients.Register;

public class RegisterClientUseCase
{
    public ResposeClientJson Execute(ClientsRequestJson request)

    {
        var validator = new RegisterClientValidator();

        var result = validator.Validate(request);

        return new ResposeClientJson();

    }
}
