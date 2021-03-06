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
	public class ConsumersApi {
		private readonly ApiClient apiClient = ApiClient.GetInstance();

		public ApiClient getClient() {
			return apiClient;
		}

		/// <summary>
		/// Read all User Group 
		/// </summary>
		/// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
		/// <param name="filter">Full-text filter</param>
		/// <returns></returns>
		public List<Consumer> getConsumers (bool relations, string filter) {
			// create path and map variables
			var path = "/consumers".Replace("{format}","json");

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
					return (List<Consumer>) ApiClient.deserialize(response, typeof(List<Consumer>));
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
		/// Create a new User Group 
		/// </summary>
		/// <param name="body">Message-Body</param>
		/// <returns></returns>
		public Consumer createConsumer (Consumer body) {
			// create path and map variables
			var path = "/consumers".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			string paramStr = null;
			try {
				var response = apiClient.invokeAPI(path, "POST", queryParams, body, headerParams);
				if(response != null){
					return (Consumer) ApiClient.deserialize(response, typeof(Consumer));
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
		/// Read a User Group by a given ID 
		/// </summary>
		/// <param name="ID">Unique ID</param>
		/// <param name="relations">If set to true, all relations of the Fact Sheet are fetched as well. Fetching all relations can be slower. Default: false.</param>
		/// <returns></returns>
		public Consumer getConsumer (string ID, bool relations) {
			// create path and map variables
			var path = "/consumers/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (Consumer) ApiClient.deserialize(response, typeof(Consumer));
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
		/// Update a User Group by a given ID 
		/// </summary>
		/// <param name="ID">Unique ID</param>
		/// <param name="body">Message-Body</param>
		/// <returns></returns>
		public Consumer updateConsumer (string ID, Consumer body) {
			// create path and map variables
			var path = "/consumers/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (Consumer) ApiClient.deserialize(response, typeof(Consumer));
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
		/// Delete a User Group by a given ID 
		/// </summary>
		/// <param name="ID">Unique ID</param>
		/// <returns></returns>
		public void deleteConsumer (string ID) {
			// create path and map variables
			var path = "/consumers/{ID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
		public List<ServiceHasConsumer> getServiceHasConsumers (string ID) {
			// create path and map variables
			var path = "/consumers/{ID}/serviceHasConsumers".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (List<ServiceHasConsumer>) ApiClient.deserialize(response, typeof(List<ServiceHasConsumer>));
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
		public ServiceHasConsumer createServiceHasConsumer (string ID, Consumer body) {
			// create path and map variables
			var path = "/consumers/{ID}/serviceHasConsumers".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));

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
					return (ServiceHasConsumer) ApiClient.deserialize(response, typeof(ServiceHasConsumer));
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
		public ServiceHasConsumer getServiceHasConsumer (string ID, string relationID) {
			// create path and map variables
			var path = "/consumers/{ID}/serviceHasConsumers/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
					return (ServiceHasConsumer) ApiClient.deserialize(response, typeof(ServiceHasConsumer));
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
		public ServiceHasConsumer updateServiceHasConsumer (string ID, string relationID, Consumer body) {
			// create path and map variables
			var path = "/consumers/{ID}/serviceHasConsumers/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
					return (ServiceHasConsumer) ApiClient.deserialize(response, typeof(ServiceHasConsumer));
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
		public void deleteServiceHasConsumer (string ID, string relationID) {
			// create path and map variables
			var path = "/consumers/{ID}/serviceHasConsumers/{relationID}".Replace("{format}","json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString())).Replace("{" + "relationID" + "}", apiClient.escapeString(relationID.ToString()));

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
