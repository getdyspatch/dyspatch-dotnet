#!/bin/bash

problem='if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept));'
replace='if (accept != null) localVarHeaderParams["Accept"] = this.Configuration.ApiClient.ParameterToString(accept);'

function patch() {
  sed -i "s/${problem}/${replace}/g" $1
}

patch src/IO.Dyspatch/Api/DraftsApi.cs
patch src/IO.Dyspatch/Api/LocalizationsApi.cs
patch src/IO.Dyspatch/Api/TemplatesApi.cs
