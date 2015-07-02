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
	public class BusinessCapability : FactSheet {

        public override FactSheetType factSheetType { get { return FactSheetType.BUSINESS_CAPABILITY; } }

		/*  */
		public string ID { get; set; }

		/*  */
		public string name { get; set; }

		/*  */
		public string reference { get; set; }

		/*  */
		public string alias { get; set; }

		/*  */
		public string description { get; set; }

		/*  */
		public string parentID { get; set; }

		/*  */
		public List<BusinessCapability> businessCapabilities { get; set; }

		/*  */
		public List<ServiceHasBusinessCapability> serviceHasBusinessCapabilities { get; set; }

		public override string ToString()  {
			var sb = new StringBuilder();
			sb.Append("class BusinessCapability {\n");
			sb.Append("  ID: ").Append(ID).Append("\n");
			sb.Append("  name: ").Append(name).Append("\n");
			sb.Append("  reference: ").Append(reference).Append("\n");
			sb.Append("  alias: ").Append(alias).Append("\n");
            sb.Append("  tags: ").Append(tags).Append("\n");
			sb.Append("  description: ").Append(description).Append("\n");
			sb.Append("  parentID: ").Append(parentID).Append("\n");
			sb.Append("  businessCapabilities: ").Append(businessCapabilities).Append("\n");
			sb.Append("  serviceHasBusinessCapabilities: ").Append(serviceHasBusinessCapabilities).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
	}
