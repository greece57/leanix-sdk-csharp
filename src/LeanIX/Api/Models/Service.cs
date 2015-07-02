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
	public class Service : FactSheet{

        public override FactSheetType factSheetType { get { return FactSheetType.APPLICATION; } }

		/*  */
		public string release { get; set; }

		/*  */
		public string reference { get; set; }

		/*  */
		public string alias { get; set; }

		/*  */
		public string description { get; set; }

		/*  */
		public string businessCriticalityID { get; set; }

		/*  */
		public string businessCriticalityDescription { get; set; }

		/*  */
		public string functionalSuitabilityID { get; set; }

		/*  */
		public string functionalSuitabilityDescription { get; set; }

		/*  */
		public string technicalSuitabilityID { get; set; }

		/*  */
		public string technicalSuitabilityDescription { get; set; }

		/*  */
		public List<ServiceHasProject> serviceHasProjects { get; set; }

		/*  */
		public List<ServiceHasBusinessCapability> serviceHasBusinessCapabilities { get; set; }

		/*  */
		public List<ServiceHasProcess> serviceHasProcesses { get; set; }

		/*  */
		public List<ServiceHasConsumer> serviceHasConsumers { get; set; }

		/*  */
		public List<ServiceHasBusinessObject> serviceHasBusinessObjects { get; set; }

		/*  */
		public List<ServiceHasInterface> serviceHasInterfaces { get; set; }

		/*  */
		public List<ServiceHasResource> serviceHasResources { get; set; }

		public override string ToString()  {
			var sb = new StringBuilder();
			sb.Append("class Service {\n");
			sb.Append("  ID: ").Append(ID).Append("\n");
			sb.Append("  release: ").Append(release).Append("\n");
			sb.Append("  name: ").Append(name).Append("\n");
			sb.Append("  reference: ").Append(reference).Append("\n");
			sb.Append("  alias: ").Append(alias).Append("\n");
			sb.Append("  description: ").Append(description).Append("\n");
			sb.Append("  businessCriticalityID: ").Append(businessCriticalityID).Append("\n");
			sb.Append("  businessCriticalityDescription: ").Append(businessCriticalityDescription).Append("\n");
			sb.Append("  functionalSuitabilityID: ").Append(functionalSuitabilityID).Append("\n");
			sb.Append("  functionalSuitabilityDescription: ").Append(functionalSuitabilityDescription).Append("\n");
			sb.Append("  technicalSuitabilityID: ").Append(technicalSuitabilityID).Append("\n");
			sb.Append("  technicalSuitabilityDescription: ").Append(technicalSuitabilityDescription).Append("\n");
            sb.Append("  tags: ").Append(tags).Append("\n");
			sb.Append("  serviceHasProjects: ").Append(serviceHasProjects).Append("\n");
			sb.Append("  serviceHasBusinessCapabilities: ").Append(serviceHasBusinessCapabilities).Append("\n");
			sb.Append("  serviceHasProcesses: ").Append(serviceHasProcesses).Append("\n");
			sb.Append("  serviceHasConsumers: ").Append(serviceHasConsumers).Append("\n");
			sb.Append("  serviceHasBusinessObjects: ").Append(serviceHasBusinessObjects).Append("\n");
			sb.Append("  serviceHasInterfaces: ").Append(serviceHasInterfaces).Append("\n");
			sb.Append("  serviceHasResources: ").Append(serviceHasResources).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
	}
