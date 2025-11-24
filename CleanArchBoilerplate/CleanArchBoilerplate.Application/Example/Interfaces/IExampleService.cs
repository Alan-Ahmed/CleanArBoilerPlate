using CleanArchBoilerplate.Application.Example.DTOs;

namespace CleanArchBoilerplate.Application.Example.Interfaces;

public interface IExampleService
{
    Task<ExampleDto> CreateAsync(string name);
    Task<IReadOnlyList<ExampleDto>> GetAllAsync();
}
