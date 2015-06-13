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

namespace LeanIX.Api
{
    public class FactSheetApi
    {
        private readonly ApiClient apiClient = ApiClient.GetInstance();

        public ApiClient getClient()
        {
            return apiClient;
        }
        /// <summary>
        /// factSheetCall
        /// </summary>
        /// <param name="path">Path where to send the message to</param>
        /// <param name="method">GET, PUSH, PUT or DELETE</param>
        /// <param name="ID">Unique ID</param>
        /// <param name="body">Message-body</param>
        /// <returns>response message string</returns>
        private string factSheetApiCall(string path, string method, string ID, object body = null)
        {
            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();

            // verify required params are set
            if (ID == null || (body == null && !method.Equals("GET")))
            {
                throw new ApiException(400, "missing required params");
            }
            string paramStr = null;
            try
            {
                var response = apiClient.invokeAPI(path, method, queryParams, body, headerParams);
                if (response != null)
                {
                    return response;
                }
                else
                {
                    return null;
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Generate Path String for GET, POST, PUT and DELETE requests
        /// </summary>
        /// <param name="factSheetType">The FactSheetType of the Factsheet</param>
        /// <param name="requestUrlEnding">can be empty</param>
        /// <param name="ID">factSheetID</param>
        /// <returns></returns>
        private string generatePathString(FactSheetType factSheetType, string requestUrlEnding, string ID)
        {
            return String.Concat("/", factSheetType, "/{ID}/", requestUrlEnding).Replace("{format}", "json").Replace("{" + "ID" + "}", apiClient.escapeString(ID.ToString()));
        }
        

        /// <summary>
        /// Read all of relation 
        /// </summary>
        /// <param name="ID">Unique ID</param>
        /// <returns></returns>
        public List<FactSheetHasLifecycle> getFactSheetHasLifecycle(string ID, FactSheet factSheet)
        {
            // create path and map variables
            var path = generatePathString(factSheet.factSheetType, "factSheetHasLifecycles", ID);

            var response = factSheetApiCall(path, "GET", ID);
            return (List<FactSheetHasLifecycle>)ApiClient.deserialize(response, typeof(List<FactSheetHasLifecycle>));
        }
        /// <summary>
        /// Create a new relation 
        /// </summary>
        /// <param name="ID">Unique ID</param>
        /// <param name="body">Message-Body</param>
        /// <returns></returns>
        public List<FactSheetHasLifecycle> createFactSheetHasLifecycles(string ID, FactSheet body)
        {
            // create path and map variables
            var path = generatePathString(body.factSheetType, "factSheetHasLifecycles", ID);

            List<FactSheetHasLifecycle> responseList = new List<FactSheetHasLifecycle>();
            foreach (FactSheetHasLifecycle lifecycle in body.factSheetHasLifecycles)
            {
                var response = factSheetApiCall(path, "POST", ID, lifecycle);
                responseList.Add((FactSheetHasLifecycle)ApiClient.deserialize(response, typeof(FactSheetHasLifecycle)));
            }
            return responseList;

            // Throwing error
            //var response = factSheetApiCall(path, "POST", ID, body.factSheetHasLifecycles);
            //return (FactSheetHasLifecycle)ApiClient.deserialize(response, typeof (FactSheetHasLifecycle));
        }
        /// <summary>
        /// Update relation
        /// </summary>
        /// <param name="ID">Unique ID</param>
        /// <param name="body">Message-Body</param>
        /// <returns></returns>
        public List<FactSheetHasLifecycle> updateFactSheetHasLifecycle(string ID, FactSheet body)
        {
            // create path and map variables
            var path = generatePathString(body.factSheetType, "factSheetHasLifecycles", ID);

            List<FactSheetHasLifecycle> responseList = new List<FactSheetHasLifecycle>();
            foreach (FactSheetHasLifecycle lifecycle in body.factSheetHasLifecycles)
            {
                var response = factSheetApiCall(path, "PUT", ID, lifecycle);
                responseList.Add((FactSheetHasLifecycle)ApiClient.deserialize(response, typeof(FactSheetHasLifecycle)));
            }
            return responseList;

            //string response = factSheetApiCall(path, "PUT", ID, body);
            //return (FactSheetHasLifecycle)ApiClient.deserialize(response, typeof(FactSheetHasLifecycle));
        }
        /// <summary>
        /// Delete relation
        /// </summary>
        /// <param name="ID">Unique ID</param>
        /// <returns></returns>
        public void deleteFactSheetHasLifecycle(string ID, FactSheet body)
        {
            // create path and map variables
            var path = generatePathString(body.factSheetType, "factSheetHasLifecycles", ID);

            foreach (FactSheetHasLifecycle lifecycle in body.factSheetHasLifecycles)
            {
                var response = factSheetApiCall(path, "DELETE", ID, lifecycle);
            }

            //factSheetApiCall(path, "DELETE", ID, body);
        }
    }
}
