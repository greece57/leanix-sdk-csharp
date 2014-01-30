using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ServiceHasInterface {
    /*  */
    public string ID { get; set; }

    /*  */
    public string name { get; set; }

    /*  */
    public string serviceID { get; set; }

    /*  */
    public string serviceRefID { get; set; }

    /*  */
    public string interfaceDirectionID { get; set; }

    /*  */
    public string interfaceFrequencyID { get; set; }

    /*  */
    public string interfaceTypeID { get; set; }

    /*  */
    public string interfaceTechnologyID { get; set; }

    /*  */
    public string reference { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceHasInterface {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  serviceID: ").Append(serviceID).Append("\n");
      sb.Append("  serviceRefID: ").Append(serviceRefID).Append("\n");
      sb.Append("  interfaceDirectionID: ").Append(interfaceDirectionID).Append("\n");
      sb.Append("  interfaceFrequencyID: ").Append(interfaceFrequencyID).Append("\n");
      sb.Append("  interfaceTypeID: ").Append(interfaceTypeID).Append("\n");
      sb.Append("  interfaceTechnologyID: ").Append(interfaceTechnologyID).Append("\n");
      sb.Append("  reference: ").Append(reference).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
