  using System;
  using System.Collections.Generic;
  using LeanIX.Api.Common;
  using LeanIX.Api.Models;
  namespace LeanIX.Api {
    public class ResourceCapabilitiesApi {
      private readonly ApiClient apiClient = ApiClient.GetInstance();

      public ApiClient getClient() {
        return apiClient;
      }

      /// <summary>
      /// Read all Tech. Stack 
      /// </summary>
      /// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
      /// <param name="filter">Full-text filter</param>
      /// <returns></returns>
      public List<ResourceCapability> getResourceCapabilities (bool relations, string filter) {
        // create path and map variables
        var path = "/resourceCapabilities".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (relations != null){
          paramStr = (relations != null && relations is DateTime) ? ((DateTime)(object)relations).ToString("u") : Convert.ToString(relations);
          queryParams.Add("relations", paramStr);
		}
        if (filter != null){
          paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
          queryParams.Add("filter", paramStr);
		}
        try {
          var response = apiClient.invokeAPI(path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (List<ResourceCapability>) ApiClient.deserialize(response, typeof(List<ResourceCapability>));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Create a new Tech. Stack 
      /// </summary>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ResourceCapability createResourceCapability (ResourceCapability body) {
        // create path and map variables
        var path = "/resourceCapabilities".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (ResourceCapability) ApiClient.deserialize(response, typeof(ResourceCapability));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Read a Tech. Stack by a given ID 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
      /// <returns></returns>
      public ResourceCapability getResourceCapability (string ID, bool relations) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (relations != null){
          paramStr = (relations != null && relations is DateTime) ? ((DateTime)(object)relations).ToString("u") : Convert.ToString(relations);
          queryParams.Add("relations", paramStr);
		}
        try {
          var response = apiClient.invokeAPI(path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (ResourceCapability) ApiClient.deserialize(response, typeof(ResourceCapability));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Update a Tech. Stack by a given ID 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ResourceCapability updateResourceCapability (string ID, ResourceCapability body) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "PUT", queryParams, body, headerParams);
          if(response != null){
             return (ResourceCapability) ApiClient.deserialize(response, typeof(ResourceCapability));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Delete a Tech. Stack by a given ID 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <returns></returns>
      public void deleteResourceCapability (string ID) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return ;
          }
          else {
            return ;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Read all of relation 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <returns></returns>
      public List<ResourceCapability> getResourceCapabilities (string ID) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceCapabilities".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (List<ResourceCapability>) ApiClient.deserialize(response, typeof(List<ResourceCapability>));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Create a new relation 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ResourceCapability createResourceCapability (string ID, ResourceCapability body) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceCapabilities".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (ResourceCapability) ApiClient.deserialize(response, typeof(ResourceCapability));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Read by relationID 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public ResourceCapability getResourceCapability (string ID, string relationID) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceCapabilities/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null || relationID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (ResourceCapability) ApiClient.deserialize(response, typeof(ResourceCapability));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Update relation by a given relationID 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ResourceCapability updateResourceCapability (string ID, string relationID, ResourceCapability body) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceCapabilities/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null || relationID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "PUT", queryParams, body, headerParams);
          if(response != null){
             return (ResourceCapability) ApiClient.deserialize(response, typeof(ResourceCapability));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Delete relation by a given relationID 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public void deleteResourceCapability (string ID, string relationID) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceCapabilities/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null || relationID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return ;
          }
          else {
            return ;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Read all of relation 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <returns></returns>
      public List<ResourceHasResourceCapability> getResourceHasResourceCapabilities (string ID) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceHasResourceCapabilities".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (List<ResourceHasResourceCapability>) ApiClient.deserialize(response, typeof(List<ResourceHasResourceCapability>));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Create a new relation 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ResourceHasResourceCapability createResourceHasResourceCapability (string ID, ResourceCapability body) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceHasResourceCapabilities".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (ResourceHasResourceCapability) ApiClient.deserialize(response, typeof(ResourceHasResourceCapability));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Read by relationID 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public ResourceHasResourceCapability getResourceHasResourceCapability (string ID, string relationID) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceHasResourceCapabilities/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null || relationID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (ResourceHasResourceCapability) ApiClient.deserialize(response, typeof(ResourceHasResourceCapability));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Update relation by a given relationID 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ResourceHasResourceCapability updateResourceHasResourceCapability (string ID, string relationID, ResourceCapability body) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceHasResourceCapabilities/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null || relationID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "PUT", queryParams, body, headerParams);
          if(response != null){
             return (ResourceHasResourceCapability) ApiClient.deserialize(response, typeof(ResourceHasResourceCapability));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Delete relation by a given relationID 
      /// </summary>
      /// <param name="ID">Unique ID of the Tech. Stack</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public void deleteResourceHasResourceCapability (string ID, string relationID) {
        // create path and map variables
        var path = "/resourceCapabilities/{ID}/resourceHasResourceCapabilities/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (ID == null || relationID == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return ;
          }
          else {
            return ;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      }
    }
