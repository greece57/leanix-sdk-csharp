using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeanIX.Api.Models
{
    public abstract class FactSheet
    {

        /*  */
        public string ID { get; set; }

        /*  */
        public string name { get; set; }

        public abstract FactSheetType factSheetType { get; }

        /*  */
        public List<FactSheetHasLifecycle> factSheetHasLifecycles { get; set; }
    }
}
