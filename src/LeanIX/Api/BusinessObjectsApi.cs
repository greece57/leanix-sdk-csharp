/*
* The MIT License (MIT)	 
*
* Copyright (c) 2014 LeanIX GmbH
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy of
* this software and associated documentation files (the "Software"), to deal in
* the Software without restriction, including without limitation the rights to
* use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
* the Software, and to permit persons to whom the Software is furnished to do so,
* subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
* FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
* COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
* IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
* CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using LeanIX.Api.Common;
using LeanIX.Api.Models;
namespace LeanIX.Api {
	public class BusinessObjectsApi {
		private readonly ApiClient apiClient = ApiClient.GetInstance();

		public ApiClient getClient() {
			return apiClient;
		}

		/// <summary>
		/// Read all Data Object 
		/// </summary>
		/// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
		/// <param name="filter">Full-text filter</param>
		/// <returns></returns>
		public List<BusinessObject> getBusinessObjects (bool relations, string filter) {
			// create path and map variables
			var path = "/businessObjects".Replace("{format}","json");

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
					return (List<BusinessObject>) ApiClient.deserialize(response, typeof(List<BusinessObject>));
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
		/// Create a new Data Object 
		/// </summary>
		/// <param name="body">Message-Body</param>
		/// <returns></returns>
		public BusinessObject createBusinessObject (BusinessObject body) {
			// create path and map variables
			var path = "/businessObjects".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			string paramStr = null;
			try {
				var response = apiClient.invokeAPI(path, "POST", queryParams, body, headerParams);
				if(response != null){
					return (BusinessObject) ApiClient.deserialize(response, typeof(BusinessObject));
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
		/// Read a Data Object by a given ID 
		/// </summary>
		/// <param name="ID">Unique ID</param>
		/// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
		/// <returns></returns>
		public BusinessObject getBusinessObject (string ID, bool relations) {
			// create path and map variables
			var path = "/businessObjects/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (BusinessObject) ApiClient.deserialize(response, typeof(BusinessObject));
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
		/// Update a Data Object by a given ID 
		/// </summary>
		/// <param name="ID">Unique ID</param>
		/// <param name="body">Message-Body</param>
		/// <returns></returns>
		public BusinessObject updateBusinessObject (string ID, BusinessObject body) {
			// create path and map variables
			var path = "/businessObjects/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (BusinessObject) ApiClient.deserialize(response, typeof(BusinessObject));
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
		/// Delete a Data Object by a given ID 
		/// </summary>
		/// <param name="ID">Unique ID</param>
		/// <returns></returns>
		public void deleteBusinessObject (string ID) {
			// create path and map variables
			var path = "/businessObjects/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
		/// <param name="ID">Unique ID</param>
		/// <returns></returns>
		public List<ServiceHasBusinessObject> getServiceHasBusinessObjects (string ID) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasBusinessObjects".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (List<ServiceHasBusinessObject>) ApiClient.deserialize(response, typeof(List<ServiceHasBusinessObject>));
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
		/// <param name="ID">Unique ID</param>
		/// <param name="body">Message-Body</param>
		/// <returns></returns>
		public ServiceHasBusinessObject createServiceHasBusinessObject (string ID, BusinessObject body) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasBusinessObjects".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (ServiceHasBusinessObject) ApiClient.deserialize(response, typeof(ServiceHasBusinessObject));
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
		/// <param name="ID">Unique ID</param>
		/// <param name="relationID">Unique ID of the Relation</param>
		/// <returns></returns>
		public ServiceHasBusinessObject getServiceHasBusinessObject (string ID, string relationID) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasBusinessObjects/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
					return (ServiceHasBusinessObject) ApiClient.deserialize(response, typeof(ServiceHasBusinessObject));
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
		/// <param name="ID">Unique ID</param>
		/// <param name="relationID">Unique ID of the Relation</param>
		/// <param name="body">Message-Body</param>
		/// <returns></returns>
		public ServiceHasBusinessObject updateServiceHasBusinessObject (string ID, string relationID, BusinessObject body) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasBusinessObjects/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
					return (ServiceHasBusinessObject) ApiClient.deserialize(response, typeof(ServiceHasBusinessObject));
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
		/// <param name="ID">Unique ID</param>
		/// <param name="relationID">Unique ID of the Relation</param>
		/// <returns></returns>
		public void deleteServiceHasBusinessObject (string ID, string relationID) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasBusinessObjects/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
		/// <param name="ID">Unique ID</param>
		/// <returns></returns>
		public List<ServiceHasInterface> getServiceHasInterfaces (string ID) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasInterfaces".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (List<ServiceHasInterface>) ApiClient.deserialize(response, typeof(List<ServiceHasInterface>));
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
		/// <param name="ID">Unique ID</param>
		/// <param name="body">Message-Body</param>
		/// <returns></returns>
		public ServiceHasInterface createServiceHasInterface (string ID, BusinessObject body) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasInterfaces".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (ServiceHasInterface) ApiClient.deserialize(response, typeof(ServiceHasInterface));
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
		/// <param name="ID">Unique ID</param>
		/// <param name="relationID">Unique ID of the Relation</param>
		/// <returns></returns>
		public ServiceHasInterface getServiceHasInterface (string ID, string relationID) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasInterfaces/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
					return (ServiceHasInterface) ApiClient.deserialize(response, typeof(ServiceHasInterface));
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
		/// <param name="ID">Unique ID</param>
		/// <param name="relationID">Unique ID of the Relation</param>
		/// <param name="body">Message-Body</param>
		/// <returns></returns>
		public ServiceHasInterface updateServiceHasInterface (string ID, string relationID, BusinessObject body) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasInterfaces/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
					return (ServiceHasInterface) ApiClient.deserialize(response, typeof(ServiceHasInterface));
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
		/// <param name="ID">Unique ID</param>
		/// <param name="relationID">Unique ID of the Relation</param>
		/// <returns></returns>
		public void deleteServiceHasInterface (string ID, string relationID) {
			// create path and map variables
			var path = "/businessObjects/{ID}/serviceHasInterfaces/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
