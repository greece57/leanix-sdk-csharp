  using System;
  using System.Collections.Generic;
  using LeanIX.Api.Common;
  using LeanIX.Api.Models;
  namespace LeanIX.Api {
    public class ProcessesApi {
      private readonly ApiClient apiClient = ApiClient.GetInstance();

      public ApiClient getClient() {
        return apiClient;
      }

      /// <summary>
      /// Read all Process 
      /// </summary>
      /// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
      /// <param name="filter">Full-text filter</param>
      /// <returns></returns>
      public List<Process> getProcesses (bool relations, string filter) {
        // create path and map variables
        var path = "/processes".Replace("{format}","json");

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
             return (List<Process>) ApiClient.deserialize(response, typeof(List<Process>));
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
      /// Create a new Process 
      /// </summary>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public Process createProcess (Process body) {
        // create path and map variables
        var path = "/processes".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (Process) ApiClient.deserialize(response, typeof(Process));
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
      /// Read a Process by a given ID 
      /// </summary>
      /// <param name="ID">Unique ID of the Process</param>
      /// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
      /// <returns></returns>
      public Process getProcess (string ID, bool relations) {
        // create path and map variables
        var path = "/processes/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (Process) ApiClient.deserialize(response, typeof(Process));
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
      /// Update a Process by a given ID 
      /// </summary>
      /// <param name="ID">Unique ID of the Process</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public Process updateProcess (string ID, Process body) {
        // create path and map variables
        var path = "/processes/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (Process) ApiClient.deserialize(response, typeof(Process));
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
      /// Delete a Process by a given ID 
      /// </summary>
      /// <param name="ID">Unique ID of the Process</param>
      /// <returns></returns>
      public void deleteProcess (string ID) {
        // create path and map variables
        var path = "/processes/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
      /// <param name="ID">Unique ID of the Process</param>
      /// <returns></returns>
      public List<ServiceHasProcess> getServiceHasProcesses (string ID) {
        // create path and map variables
        var path = "/processes/{ID}/serviceHasProcesses".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (List<ServiceHasProcess>) ApiClient.deserialize(response, typeof(List<ServiceHasProcess>));
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
      /// <param name="ID">Unique ID of the Process</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ServiceHasProcess createServiceHasProcess (string ID, Process body) {
        // create path and map variables
        var path = "/processes/{ID}/serviceHasProcesses".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (ServiceHasProcess) ApiClient.deserialize(response, typeof(ServiceHasProcess));
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
      /// <param name="ID">Unique ID of the Process</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public ServiceHasProcess getServiceHasProcess (string ID, string relationID) {
        // create path and map variables
        var path = "/processes/{ID}/serviceHasProcesses/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
             return (ServiceHasProcess) ApiClient.deserialize(response, typeof(ServiceHasProcess));
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
      /// <param name="ID">Unique ID of the Process</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ServiceHasProcess updateServiceHasProcess (string ID, string relationID, Process body) {
        // create path and map variables
        var path = "/processes/{ID}/serviceHasProcesses/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
             return (ServiceHasProcess) ApiClient.deserialize(response, typeof(ServiceHasProcess));
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
      /// <param name="ID">Unique ID of the Process</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public void deleteServiceHasProcess (string ID, string relationID) {
        // create path and map variables
        var path = "/processes/{ID}/serviceHasProcesses/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
