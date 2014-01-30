using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class Provider {
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
    public List<ProjectHasProvider> projectHasProviders { get; set; }

    /*  */
    public List<ResourceHasProviderSvc> resourceHasProvidersSvc { get; set; }

    /*  */
    public List<ResourceHasProviderSW> resourceHasProvidersSW { get; set; }

    /*  */
    public List<ResourceHasProviderHW> resourceHasProvidersHW { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Provider {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  reference: ").Append(reference).Append("\n");
      sb.Append("  alias: ").Append(alias).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  projectHasProviders: ").Append(projectHasProviders).Append("\n");
      sb.Append("  resourceHasProvidersSvc: ").Append(resourceHasProvidersSvc).Append("\n");
      sb.Append("  resourceHasProvidersSW: ").Append(resourceHasProvidersSW).Append("\n");
      sb.Append("  resourceHasProvidersHW: ").Append(resourceHasProvidersHW).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
