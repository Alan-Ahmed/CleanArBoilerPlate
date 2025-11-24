using CleanArchBoilerplate.Application.Common.Interfaces;
using CleanArchBoilerplate.Application.Example.DTOs;
using CleanArchBoilerplate.Application.Example.Interfaces;
using CleanArchBoilerplate.Domain.Entities;

namespace CleanArchBoilerplate.Application.Example.Services;

public class ExampleService : IExampleService
{
    private readonly IGenericRepository<ExampleEntity> _repository;

    public ExampleService(IGenericRepository<ExampleEntity> repository)
    {
        _repository = repository;
    }

    public async Task<ExampleDto> CreateAsync(string name)
    {
        var entity = new ExampleEntity { Name = name };
        await _repository.AddAsync(entity);

        return new ExampleDto(entity.Id, entity.Name, entity.CreatedAt);
    }

    public async Task<IReadOnlyList<ExampleDto>> GetAllAsync()
    {
        var list = await _repository.ListAsync();
        return list.Select(x => new ExampleDto(x.Id, x.Name, x.CreatedAt)).ToList();
    }
}
