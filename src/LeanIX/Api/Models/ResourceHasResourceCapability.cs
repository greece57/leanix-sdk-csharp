using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ResourceHasResourceCapability {
    /*  */
    public string ID { get; set; }

    /*  */
    public string resourceCapabilityID { get; set; }

    /*  */
    public string resourceID { get; set; }

    /*  */
    public bool isLeading { get; set; }

    /*  */
    public string comment { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResourceHasResourceCapability {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  resourceCapabilityID: ").Append(resourceCapabilityID).Append("\n");
      sb.Append("  resourceID: ").Append(resourceID).Append("\n");
      sb.Append("  isLeading: ").Append(isLeading).Append("\n");
      sb.Append("  comment: ").Append(comment).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
