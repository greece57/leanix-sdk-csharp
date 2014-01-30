using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ServiceHasResourceHW {
    /*  */
    public string ID { get; set; }

    /*  */
    public string resourceID { get; set; }

    /*  */
    public string serviceID { get; set; }

    /*  */
    public string comment { get; set; }

    /*  */
    public string technicalSuitabilityID { get; set; }

    /*  */
    public double costTotalAnnual { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceHasResourceHW {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  resourceID: ").Append(resourceID).Append("\n");
      sb.Append("  serviceID: ").Append(serviceID).Append("\n");
      sb.Append("  comment: ").Append(comment).Append("\n");
      sb.Append("  technicalSuitabilityID: ").Append(technicalSuitabilityID).Append("\n");
      sb.Append("  costTotalAnnual: ").Append(costTotalAnnual).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
