using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ResourceHasProviderSvc {
    /*  */
    public string ID { get; set; }

    /*  */
    public string providerID { get; set; }

    /*  */
    public string resourceID { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResourceHasProviderSvc {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  providerID: ").Append(providerID).Append("\n");
      sb.Append("  resourceID: ").Append(resourceID).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
