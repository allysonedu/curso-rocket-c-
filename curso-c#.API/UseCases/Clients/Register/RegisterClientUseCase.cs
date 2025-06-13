using ClassLibrary1.Execeptions.ExeptionsBase;
using curso_c_.API.Entities;
using curso_c_.API.Infrastruture;
using curso_rocket.Communication.Requests;
using curso_rocket.Communication.Response;


namespace curso_c_.API.UseCases.Clients.Register;

public class RegisterClientUseCase
{
    public ResposeClientJson Execute(ClientsRequestJson request)

    {
        Validate(request);

        var dbContext = new ClientHubDbContext();

        var entity = new Client
        {
            Name = request.Name,
            Email = request.Email,
            
        };

        dbContext.Client.Add(entity);

        dbContext.SaveChanges();

        return new ResposeClientJson();

    }

    private void Validate(ClientsRequestJson request)
    {
        var validator = new RegisterClientValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errors);
        }

    }
}
