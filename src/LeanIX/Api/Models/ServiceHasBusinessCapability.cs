using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ServiceHasBusinessCapability {
    /*  */
    public string ID { get; set; }

    /*  */
    public string serviceID { get; set; }

    /*  */
    public string businessCapabilityID { get; set; }

    /*  */
    public bool isLeading { get; set; }

    /*  */
    public string functionalSuitabilityID { get; set; }

    /*  */
    public string comment { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceHasBusinessCapability {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  serviceID: ").Append(serviceID).Append("\n");
      sb.Append("  businessCapabilityID: ").Append(businessCapabilityID).Append("\n");
      sb.Append("  isLeading: ").Append(isLeading).Append("\n");
      sb.Append("  functionalSuitabilityID: ").Append(functionalSuitabilityID).Append("\n");
      sb.Append("  comment: ").Append(comment).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
