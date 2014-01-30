using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class Project {
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
    public string businessValueID { get; set; }

    /*  */
    public string businessValueDescription { get; set; }

    /*  */
    public string projectRiskID { get; set; }

    /*  */
    public string projectRiskDescription { get; set; }

    /*  */
    public double budgetOpex { get; set; }

    /*  */
    public double budgetCapex { get; set; }

    /*  */
    public List<ServiceHasProject> serviceHasProjects { get; set; }

    /*  */
    public List<ProjectHasProvider> projectHasProviders { get; set; }

    /*  */
    public List<ProjectUpdate> projectUpdates { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Project {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  reference: ").Append(reference).Append("\n");
      sb.Append("  alias: ").Append(alias).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  businessValueID: ").Append(businessValueID).Append("\n");
      sb.Append("  businessValueDescription: ").Append(businessValueDescription).Append("\n");
      sb.Append("  projectRiskID: ").Append(projectRiskID).Append("\n");
      sb.Append("  projectRiskDescription: ").Append(projectRiskDescription).Append("\n");
      sb.Append("  budgetOpex: ").Append(budgetOpex).Append("\n");
      sb.Append("  budgetCapex: ").Append(budgetCapex).Append("\n");
      sb.Append("  serviceHasProjects: ").Append(serviceHasProjects).Append("\n");
      sb.Append("  projectHasProviders: ").Append(projectHasProviders).Append("\n");
      sb.Append("  projectUpdates: ").Append(projectUpdates).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
