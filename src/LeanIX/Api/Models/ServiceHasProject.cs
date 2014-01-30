using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ServiceHasProject {
    /*  */
    public string ID { get; set; }

    /*  */
    public string serviceID { get; set; }

    /*  */
    public string projectID { get; set; }

    /*  */
    public string comment { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceHasProject {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  serviceID: ").Append(serviceID).Append("\n");
      sb.Append("  projectID: ").Append(projectID).Append("\n");
      sb.Append("  comment: ").Append(comment).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
