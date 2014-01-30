  using System;
  using System.Collections.Generic;
  using LeanIX.Api.Common;
  using LeanIX.Api.Models;
  namespace LeanIX.Api {
    public class ProjectsApi {
      private readonly ApiClient apiClient = ApiClient.GetInstance();

      public ApiClient getClient() {
        return apiClient;
      }

      /// <summary>
      /// Read all Project 
      /// </summary>
      /// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
      /// <param name="filter">Full-text filter</param>
      /// <returns></returns>
      public List<Project> getProjects (bool relations, string filter) {
        // create path and map variables
        var path = "/projects".Replace("{format}","json");

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
             return (List<Project>) ApiClient.deserialize(response, typeof(List<Project>));
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
      /// Create a new Project 
      /// </summary>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public Project createProject (Project body) {
        // create path and map variables
        var path = "/projects".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiClient.invokeAPI(path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (Project) ApiClient.deserialize(response, typeof(Project));
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
      /// Read a Project by a given ID 
      /// </summary>
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
      /// <returns></returns>
      public Project getProject (string ID, bool relations) {
        // create path and map variables
        var path = "/projects/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (Project) ApiClient.deserialize(response, typeof(Project));
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
      /// Update a Project by a given ID 
      /// </summary>
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public Project updateProject (string ID, Project body) {
        // create path and map variables
        var path = "/projects/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (Project) ApiClient.deserialize(response, typeof(Project));
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
      /// Delete a Project by a given ID 
      /// </summary>
      /// <param name="ID">Unique ID of the Project</param>
      /// <returns></returns>
      public void deleteProject (string ID) {
        // create path and map variables
        var path = "/projects/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
      /// <param name="ID">Unique ID of the Project</param>
      /// <returns></returns>
      public List<ServiceHasProject> getServiceHasProjects (string ID) {
        // create path and map variables
        var path = "/projects/{ID}/serviceHasProjects".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (List<ServiceHasProject>) ApiClient.deserialize(response, typeof(List<ServiceHasProject>));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ServiceHasProject createServiceHasProject (string ID, Project body) {
        // create path and map variables
        var path = "/projects/{ID}/serviceHasProjects".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (ServiceHasProject) ApiClient.deserialize(response, typeof(ServiceHasProject));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public ServiceHasProject getServiceHasProject (string ID, string relationID) {
        // create path and map variables
        var path = "/projects/{ID}/serviceHasProjects/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
             return (ServiceHasProject) ApiClient.deserialize(response, typeof(ServiceHasProject));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ServiceHasProject updateServiceHasProject (string ID, string relationID, Project body) {
        // create path and map variables
        var path = "/projects/{ID}/serviceHasProjects/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
             return (ServiceHasProject) ApiClient.deserialize(response, typeof(ServiceHasProject));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public void deleteServiceHasProject (string ID, string relationID) {
        // create path and map variables
        var path = "/projects/{ID}/serviceHasProjects/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
      /// <param name="ID">Unique ID of the Project</param>
      /// <returns></returns>
      public List<ProjectHasProvider> getProjectHasProviders (string ID) {
        // create path and map variables
        var path = "/projects/{ID}/projectHasProviders".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (List<ProjectHasProvider>) ApiClient.deserialize(response, typeof(List<ProjectHasProvider>));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ProjectHasProvider createProjectHasProvider (string ID, Project body) {
        // create path and map variables
        var path = "/projects/{ID}/projectHasProviders".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (ProjectHasProvider) ApiClient.deserialize(response, typeof(ProjectHasProvider));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public ProjectHasProvider getProjectHasProvider (string ID, string relationID) {
        // create path and map variables
        var path = "/projects/{ID}/projectHasProviders/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
             return (ProjectHasProvider) ApiClient.deserialize(response, typeof(ProjectHasProvider));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ProjectHasProvider updateProjectHasProvider (string ID, string relationID, Project body) {
        // create path and map variables
        var path = "/projects/{ID}/projectHasProviders/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
             return (ProjectHasProvider) ApiClient.deserialize(response, typeof(ProjectHasProvider));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public void deleteProjectHasProvider (string ID, string relationID) {
        // create path and map variables
        var path = "/projects/{ID}/projectHasProviders/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
      /// <param name="ID">Unique ID of the Project</param>
      /// <returns></returns>
      public List<ProjectUpdate> getProjectUpdates (string ID) {
        // create path and map variables
        var path = "/projects/{ID}/projectUpdates".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (List<ProjectUpdate>) ApiClient.deserialize(response, typeof(List<ProjectUpdate>));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ProjectUpdate createProjectUpdate (string ID, Project body) {
        // create path and map variables
        var path = "/projects/{ID}/projectUpdates".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
             return (ProjectUpdate) ApiClient.deserialize(response, typeof(ProjectUpdate));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public ProjectUpdate getProjectUpdate (string ID, string relationID) {
        // create path and map variables
        var path = "/projects/{ID}/projectUpdates/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
             return (ProjectUpdate) ApiClient.deserialize(response, typeof(ProjectUpdate));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <param name="body">Message-Body</param>
      /// <returns></returns>
      public ProjectUpdate updateProjectUpdate (string ID, string relationID, Project body) {
        // create path and map variables
        var path = "/projects/{ID}/projectUpdates/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
             return (ProjectUpdate) ApiClient.deserialize(response, typeof(ProjectUpdate));
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
      /// <param name="ID">Unique ID of the Project</param>
      /// <param name="relationID">Unique ID of the Relation</param>
      /// <returns></returns>
      public void deleteProjectUpdate (string ID, string relationID) {
        // create path and map variables
        var path = "/projects/{ID}/projectUpdates/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
