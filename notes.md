# Notes from the [documentation](https://learn.microsoft.com/en-us/training/modules/build-web-api-minimal-api/2-what-is-minimal-api)

- This will be notes from each of the section of the [documentation](https://learn.microsoft.com/en-us/training/modules/build-web-api-minimal-api/2-what-is-minimal-api)

## Understand the code

1. adding CORS, Entity Framework, or Swagger

- builder.Services.AddCors(options => {});

2. adding middleware (such as CORS)

- app.UseCors("some unique string");
