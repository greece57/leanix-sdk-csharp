using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ServiceHasConsumer {
    /*  */
    public string ID { get; set; }

    /*  */
    public string serviceID { get; set; }

    /*  */
    public string consumerID { get; set; }

    /*  */
    public long numberOfUsers { get; set; }

    /*  */
    public string comment { get; set; }

    /*  */
    public string functionalSuitabilityID { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceHasConsumer {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  serviceID: ").Append(serviceID).Append("\n");
      sb.Append("  consumerID: ").Append(consumerID).Append("\n");
      sb.Append("  numberOfUsers: ").Append(numberOfUsers).Append("\n");
      sb.Append("  comment: ").Append(comment).Append("\n");
      sb.Append("  functionalSuitabilityID: ").Append(functionalSuitabilityID).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
