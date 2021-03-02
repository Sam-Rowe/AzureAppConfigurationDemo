Azure Application Configurtaion Demo is a resource that I created one late night to play with and demo using Azure Application Config.

Current features:

- Config read from Azure App Config in dev on local machine
- Config read from Azure App Config on App Service in container using Managed Identity
	- Enable Managed Identity by using Evnironment variable AZURE_MANAGED_IDENTITY
- Feature Flag read from Feature managment 
- Config uses labels based on ASPNETCORE_ENVIRONMENT to set different values for font, background colour and text message

Features outstanding:

- Using KeyVault pass through
- Feature Flag filtering on browser 
- Feature Flag filtering on user/group 




# Resource links
[Azure Friday on App Config 1](https://channel9.msdn.com/Shows/Azure-Friday/Getting-started-with-Azure-App-Configuration)
[Azure Friday on App Config with Feature Management](https://azure.microsoft.com/en-us/resources/videos/azure-friday-how-azure-app-configuration-helps-developers-roll-out-new-features/)
[Getting started with .net core 5x and Feature Managment](https://docs.microsoft.com/en-us/azure/azure-app-configuration/quickstart-feature-flag-aspnet-core?tabs=core5x#create-an-aspnet-core-web-app)
[Getting started with .net core 5x and App Config](https://docs.microsoft.com/en-us/azure/azure-app-configuration/quickstart-aspnet-core-app?tabs=core5xs)
[Using Labels](https://docs.microsoft.com/en-us/azure/azure-app-configuration/howto-labels-aspnet-core#load-configuration-values-with-a-specified-label)

[Using Multiple Envornments in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-5.0)

[Managed identities to access app config](https://docs.microsoft.com/en-gb/azure/azure-app-configuration/howto-integrate-azure-managed-service-identity?tabs=core3x#use-a-managed-identity)


## more resources, but not used yet
[Dynamic updates using a Poll method](https://docs.microsoft.com/en-us/azure/azure-app-configuration/enable-dynamic-configuration-aspnet-core?tabs=core5x)
[Dynamic updates using a push model and Event Hubs](https://docs.microsoft.com/en-us/azure/azure-app-configuration/enable-dynamic-configuration-dotnet-core-push-refresh)