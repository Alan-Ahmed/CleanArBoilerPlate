# CleanArchBoilerplate

Ett återanvändbart .NET backend boilerplate-projekt byggt med **Clean Architecture** och **Generic Repository pattern**.  
Syftet är att snabbt kunna starta nya Web API-projekt utan att behöva sätta upp strukturen från början varje gång.

## Syfte

- Förstå och träna på Clean Architecture
- Ha en tydlig separation mellan API, Application, Domain och Infrastructure
- Ha ett generiskt repositorylager som går att återanvända i nya projekt
- Ha en grundstruktur som känns lik en “riktig” produktionskodbas

## Projektstruktur

```text
CleanArchBoilerplate/
  CleanArchBoilerplate.Api/           # ASP.NET Core Web API (controllers, Program.cs, Swagger)
  CleanArchBoilerplate.Application/   # Use cases, DTOs, tjänste- och repository-interface
  CleanArchBoilerplate.Domain/        # Domänentiteter och kärnlogik
  CleanArchBoilerplate.Infrastructure/# EF Core, GenericRepository, DbContext, DI
