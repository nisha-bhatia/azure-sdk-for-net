# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
title: MonitorQuery
input-file:
    - https://github.com/srnagar/azure-rest-api-specs/blob/154cb5c6d5bdd2b183ea8d9d1b7e5bbd0caa625b/specification/monitor/data-plane/Microsoft.Insights/preview/2023-05-01-preview/metricBatch.json
generation1-convenience-client: true
modelerfour:
    lenient-model-deduplication: true
```

### Remove metadata operations

``` yaml
directive:
- from: swagger-document
  where: $
  transform: >
    delete $.securityDefinitions
```

``` yaml
directive:
- from: swagger-document
  where: $.paths
  transform: >
    for (var path in $)
    {
        if ($[path].get?.operationId.startsWith("Metadata_"))
        {
            delete $[path];
        }
    }
```

### Add statistics and render

``` yaml
directive:
- from: swagger-document
  where: $.definitions.logQueryResult
  transform: >
    $.properties["statistics"] = { "type": "object" };
    $.properties["render"] = { "type": "object" };
```

``` yaml
directive:
- from: swagger-document
  where: $.definitions.queryResults
  transform: >
    $.properties["error"] = { "type": "object" };
    $.properties["statistics"] = { "type": "object" };
    $.properties["render"] = { "type": "object" };
```

### Make properties required

``` yaml
directive:
- from: swagger-document
  where: $.definitions.column
  transform: >
    $.required = ["name", "type"]
```

``` yaml
directive:
- from: swagger-document
  where: $.parameters.ResourceIdParameter
  transform:
    $["x-ms-format"] = "arm-id"
```

### Keep previous constant behavior

Adding these two properties into required keeps the generator to generate the assignment of this property in ctor.

Adding the `x-ms-constant` extension prevents the generator from wrapping the type into an extensible enum

``` yaml
directive:
- from: swagger-document
  where: $.definitions.batchQueryRequest
  transform: >
    $.required.push("path");
    $.required.push("method");
    $.properties.path["x-ms-constant"] = true;
    $.properties.method["x-ms-constant"] = true;
```
