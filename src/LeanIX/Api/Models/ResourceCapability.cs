using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ResourceCapability {
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
    public List<ResourceCapability> resourceCapabilities { get; set; }

    /*  */
    public List<ResourceHasResourceCapability> resourceHasResourceCapabilities { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResourceCapability {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  reference: ").Append(reference).Append("\n");
      sb.Append("  alias: ").Append(alias).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  parentID: ").Append(parentID).Append("\n");
      sb.Append("  resourceCapabilities: ").Append(resourceCapabilities).Append("\n");
      sb.Append("  resourceHasResourceCapabilities: ").Append(resourceHasResourceCapabilities).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
