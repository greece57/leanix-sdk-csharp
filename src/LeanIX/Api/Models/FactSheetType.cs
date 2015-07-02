using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeanIX.Api.Models
{
    public sealed class FactSheetType
    {

        private readonly String name;

        public static readonly FactSheetType APPLICATION = new FactSheetType("services");
        public static readonly FactSheetType IT_COMPONENT = new FactSheetType("resources");
        public static readonly FactSheetType BUSINESS_CAPABILITY = new FactSheetType("businessCapabilities");

        private FactSheetType(String name)
        {
            this.name = name;
        }

        public override String ToString()
        {
            return name;
        }

        public static implicit operator string(FactSheetType fst)
        {
            return fst.name;
        }

    }
}
