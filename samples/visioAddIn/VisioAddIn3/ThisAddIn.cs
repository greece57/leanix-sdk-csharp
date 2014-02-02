using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Visio = Microsoft.Office.Interop.Visio;
using Office = Microsoft.Office.Core;
using LeanIX.Api;
using LeanIX.Api.Models;
using LeanIX.Api.Common;

namespace VisioAddIn3
{
    public partial class ThisAddIn
    {
        private ApiClient apiClient;

        private string ApiPath = "https://app.leanix.net/demo/api/v1";
        private string ApiKey = "9d8372d55b307f0912facb66f5f36780";

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.apiClient = ApiClient.GetInstance();
            this.apiClient.setBasePath(this.ApiPath);
            this.apiClient.setApiKey(this.ApiKey);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion

        public void AddShapes()
        {
            Visio.Application visio = this.Application;
            Visio.Documents documents = this.Application.Documents;

            Visio.Page page = visio.ActivePage;
            Visio.Document document = visio.ActiveDocument;
            if (document == null)
                document = visio.Documents.Add("");

            if (page == null)
                page = document.Pages.Add();

            List<Service> services = null;
            try
            {
                ServicesApi api = new ServicesApi();
                services = api.getServices(true, "");
            }
            catch (ApiException e)
            {
                System.Windows.Forms.MessageBox.Show("Error calling the LeanIX API: " + e.Message);
                return;
            }
            catch(System.Net.WebException)
            {
                System.Windows.Forms.MessageBox.Show("Please check your internet connection");
                return;
            }            

            if (services == null || services.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No data received from API");
                return;
            }

            Dictionary<String, Visio.Shape> placedShapes = new Dictionary<String, Visio.Shape>();

            //add shapes
            foreach (Service s in services)
            {
                if (s.serviceHasInterfaces == null || s.serviceHasInterfaces.Count == 0)
                    continue;

                Visio.Document stencil = documents.OpenEx("Basic Shapes.vss",
                    (short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenDocked);
                Visio.Master visioRectMaster = stencil.Masters.get_ItemU(@"Rounded Rectangle");
                
                Visio.Shape visioRectShape = page.Drop(visioRectMaster, 0, 0);
                visioRectShape.Text = s.name;
                placedShapes.Add(s.ID, visioRectShape);
            }

            //connect shapes
            foreach (Service s in services)
            {
                foreach (ServiceHasInterface si in s.serviceHasInterfaces)
                {
                    Visio.Shape sourceShape = placedShapes[s.ID];
                    Visio.Shape targetShape = placedShapes[si.serviceRefID];
                    if (targetShape != null)
                    {
                        sourceShape.AutoConnect(targetShape, Visio.VisAutoConnectDir.visAutoConnectDirLeft);
                    }
                }
            }

            //set the layout and resize the page
            page.PageSheet.get_CellsSRC(
                (short)Visio.VisSectionIndices.visSectionObject,
                (short)Visio.VisRowIndices.visRowPageLayout,
                (short)Visio.VisCellIndices.visPLOPlaceStyle).ResultIU = 6;

            page.PageSheet.get_CellsSRC(
                (short)Visio.VisSectionIndices.visSectionObject,
                (short)Visio.VisRowIndices.visRowPageLayout,
                (short)Visio.VisCellIndices.visPLORouteStyle).ResultIU = 1;

            page.PageSheet.get_CellsSRC(
                (short)Visio.VisSectionIndices.visSectionObject,
                (short)Visio.VisRowIndices.visRowPageLayout,
                (short)Visio.VisCellIndices.visPLOSplit).ResultIU = 1;

            page.Layout();
            page.ResizeToFitContents();

        }

    }


}
