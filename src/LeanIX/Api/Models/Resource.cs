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
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
	public class Resource {
		/*  */
		public string ID { get; set; }

		/*  */
		public string name { get; set; }

		/*  */
		public string displayName { get; set; }

		/*  */
		public string reference { get; set; }

		/*  */
		public string alias { get; set; }

		/*  */
		public string description { get; set; }

		/*  */
		public string objectCategoryID { get; set; }

		/*  */
		public string locationID { get; set; }

		/*  */
		public List<ResourceHasProviderSvc> resourceHasProvidersSvc { get; set; }

		/*  */
		public List<ResourceHasProviderSW> resourceHasProvidersSW { get; set; }

		/*  */
		public List<ResourceHasProviderHW> resourceHasProvidersHW { get; set; }

		/*  */
		public List<ResourceHasResourceCapability> resourceHasResourceCapabilities { get; set; }

		/*  */
		public List<ServiceHasResourceSvc> serviceHasResourcesSvc { get; set; }

		/*  */
		public List<ServiceHasResourceSW> serviceHasResourcesSW { get; set; }

		/*  */
		public List<ServiceHasResourceHW> serviceHasResourcesHW { get; set; }

		public override string ToString()  {
			var sb = new StringBuilder();
			sb.Append("class Resource {\n");
			sb.Append("  ID: ").Append(ID).Append("\n");
			sb.Append("  name: ").Append(name).Append("\n");
			sb.Append("  displayName: ").Append(displayName).Append("\n");
			sb.Append("  reference: ").Append(reference).Append("\n");
			sb.Append("  alias: ").Append(alias).Append("\n");
			sb.Append("  description: ").Append(description).Append("\n");
			sb.Append("  objectCategoryID: ").Append(objectCategoryID).Append("\n");
			sb.Append("  locationID: ").Append(locationID).Append("\n");
			sb.Append("  resourceHasProvidersSvc: ").Append(resourceHasProvidersSvc).Append("\n");
			sb.Append("  resourceHasProvidersSW: ").Append(resourceHasProvidersSW).Append("\n");
			sb.Append("  resourceHasProvidersHW: ").Append(resourceHasProvidersHW).Append("\n");
			sb.Append("  resourceHasResourceCapabilities: ").Append(resourceHasResourceCapabilities).Append("\n");
			sb.Append("  serviceHasResourcesSvc: ").Append(serviceHasResourcesSvc).Append("\n");
			sb.Append("  serviceHasResourcesSW: ").Append(serviceHasResourcesSW).Append("\n");
			sb.Append("  serviceHasResourcesHW: ").Append(serviceHasResourcesHW).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
	}
