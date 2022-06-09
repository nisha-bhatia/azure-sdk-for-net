# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file: 
- https://github.com/Azure/azure-rest-api-specs/blob/a8a52b9e6c305f03c3a4c5411d59fc4454b5b372/specification/monitor/data-plane/ingestion/preview/2021-11-01-preview/DataCollectionRules.json
namespace: Azure.Monitor.Ingestion
security: AzureKey
 
security-header-name: Ocp-Apim-Subscription-Key
```
