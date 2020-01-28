﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.IES.Settings;

using BH.oM.Reflection.Attributes;
using System.ComponentModel;

namespace BH.Engine.IES
{
    public static partial class Create
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        [Deprecated("3.0", "Deprecated to expose Decimal Places settings", null, "SettingsIES(double planarTolerance = BH.oM.Geometry.Distance.Tolerance, int decimalPlaces = 6")]
        [Input("planarTolerance", "Set tolarance for planar surfaces")]
        public static SettingsIES SettingsIES(double planarTolerance = BH.oM.Geometry.Tolerance.Distance)
        {
            return SettingsIES(planarTolerance, 6);
        }

        [Description("Create a SettingsIES object for use with the IES Adapter")]
        [Input("planarTolerance", "Set tolarance for planar surfaces")]
        [Input("decimalPlaces", "Set how many decimal places coordinates should have on export")]
        [Output("settingsIES", "The IES settings to use with the IES adapter for pull and push")]
        [Deprecated("3.1", "Deprecated in favour of default create components produced by BHoM")]
        public static SettingsIES SettingsIES(double planarTolerance = BH.oM.Geometry.Tolerance.Distance, int decimalPlaces = 6)
        {
            return new SettingsIES
            {
                PlanarTolerance = planarTolerance,
                DecimalPlaces = decimalPlaces,
            };
        }            
    }
}
