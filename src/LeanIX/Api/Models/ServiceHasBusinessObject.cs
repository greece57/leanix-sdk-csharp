using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ServiceHasBusinessObject {
    /*  */
    public string ID { get; set; }

    /*  */
    public string serviceID { get; set; }

    /*  */
    public string businessObjectID { get; set; }

    /*  */
    public string businessObjectRelationID { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceHasBusinessObject {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  serviceID: ").Append(serviceID).Append("\n");
      sb.Append("  businessObjectID: ").Append(businessObjectID).Append("\n");
      sb.Append("  businessObjectRelationID: ").Append(businessObjectRelationID).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
