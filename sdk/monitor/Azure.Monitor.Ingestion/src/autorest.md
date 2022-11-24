# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file:
- https://github.com/Azure/azure-rest-api-specs/blob/d0188b838d6d338a688707c714803fdb3c1384ec/specification/monitor/data-plane/ingestion/preview/2021-11-01-preview/DataCollectionRules.json
namespace: Azure.Monitor.Ingestion
security: AADToken
security-scopes: https://monitor.azure.com//.default
```
