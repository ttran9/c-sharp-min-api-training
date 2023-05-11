# Notes from the [documentation](https://learn.microsoft.com/en-us/training/modules/build-web-api-minimal-api/2-what-is-minimal-api)

- This will be notes from each of the section of the [documentation](https://learn.microsoft.com/en-us/training/modules/build-web-api-minimal-api/2-what-is-minimal-api)

## Understand the code

1. adding CORS, Entity Framework, or Swagger

   - builder.Services.AddCors(options => {});

2. adding middleware (such as CORS)

   - app.UseCors("some unique string");

## Add documentation with Swagger

1. Keep your API up to date and one way to do this is to make sure it's self-documenting.

   - Self-Documenting: If code changes, the documentation changes with it.

2. To use Swagger and Swagger UI in your API two things should be done

   - Install a package:
     - dotnet add package Swashbuckle.AspNetCore
   - Configure it
     - Add lines of code to Program.cs (entry point) of our API.
     - For the configuration where we set up the version number make sure to modify the service before calling the Build() function. To use the two methods that call the Swagger we can add this after creating our app object.

- Other resources
  - [Swagger Home Page](https://swagger.io/)
  - [Swagger API Design](https://swagger.io/solutions/api-design/)
  - [Swagger API Development](https://swagger.io/solutions/api-development/)
  - [Swagger API Documentation](https://swagger.io/solutions/api-documentation/)
  - [Swagger API Testing](https://swagger.io/solutions/api-testing/)
  - [Swagger API Mocking and Virtualization](https://swagger.io/solutions/mocking-and-virtualization/)
  - [Swagger Governance and Standardization](https://swagger.io/solutions/governance-and-standardization/)
