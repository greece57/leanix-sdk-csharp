using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ServiceHasProcess {
    /*  */
    public string ID { get; set; }

    /*  */
    public string serviceID { get; set; }

    /*  */
    public string processID { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceHasProcess {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  serviceID: ").Append(serviceID).Append("\n");
      sb.Append("  processID: ").Append(processID).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
