﻿using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.FeatureSlices
{
    public class RazorFeaturesOptions
    {
        public RazorFeaturesOptions()
        {
            FeatureFolderName = "Features";
            FeatureNamePlaceholder = "{Feature}";

            KeepDefaultViewLocation = true;
            DeriveFeatureFolderName = null;
        }

        /// <summary>
        /// The name of the root feature folder on disk (default: 'Features')
        /// </summary>
        public string FeatureFolderName { get; set; }

        /// <summary>
        /// Given a ControllerModel object, returns the path to the feature folder.
        /// Only set this property if you want to override the default logic.
        /// The default logic takes the namespace of a Controller and assumes the 
        /// namespace maps to a folder. Examples:
        ///     Project.Name.Features.Admin.ManageUsers -> Features\Admin\ManageUsers
        ///     Project.Name.Features.Admin -> Features\Admin
        /// Note the name "Features" is set by the FeatureFolderName property. 
        /// </summary>
        public Func<ControllerModel, string> DeriveFeatureFolderName { get; set; }


        /// <summary>
        /// Used internally in RazorOptions.ViewLocationFormats strings. The Default is {Feature},
        /// so the first format string in Razor options will be {Feature}\{0}.cshtml. Razor places 
        /// the view name into the {0} placeholder, the FeatureViewLocationExander class in this project
        /// replaces {feature} with the feature path derived from the ControllerModel
        /// </summary>
        public string FeatureNamePlaceholder { get; set; }
        public bool KeepDefaultViewLocation { get; set; }
    }
}