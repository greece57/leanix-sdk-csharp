using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LeanIX.Api.Models {
  public class ProjectUpdate {
    /*  */
    public string ID { get; set; }

    /*  */
    public string projectID { get; set; }

    /*  */
    public string projectStatusID { get; set; }

    /*  */
    public string statusDate { get; set; }

    /*  */
    public string description { get; set; }

    /*  */
    public string createUserID { get; set; }

    /*  */
    public string updateUserID { get; set; }

    /*  */
    public double etcOpex { get; set; }

    /*  */
    public double etcCapex { get; set; }

    /*  */
    public double actualsOpex { get; set; }

    /*  */
    public double actualsCapex { get; set; }

    /*  */
    public long statusDateYear { get; set; }

    /*  */
    public long statusDateMonth { get; set; }

    /*  */
    public List<Project> projects { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectUpdate {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  projectID: ").Append(projectID).Append("\n");
      sb.Append("  projectStatusID: ").Append(projectStatusID).Append("\n");
      sb.Append("  statusDate: ").Append(statusDate).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  createUserID: ").Append(createUserID).Append("\n");
      sb.Append("  updateUserID: ").Append(updateUserID).Append("\n");
      sb.Append("  etcOpex: ").Append(etcOpex).Append("\n");
      sb.Append("  etcCapex: ").Append(etcCapex).Append("\n");
      sb.Append("  actualsOpex: ").Append(actualsOpex).Append("\n");
      sb.Append("  actualsCapex: ").Append(actualsCapex).Append("\n");
      sb.Append("  statusDateYear: ").Append(statusDateYear).Append("\n");
      sb.Append("  statusDateMonth: ").Append(statusDateMonth).Append("\n");
      sb.Append("  projects: ").Append(projects).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
