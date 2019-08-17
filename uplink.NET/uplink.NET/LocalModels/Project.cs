﻿using System;
using System.Collections.Generic;
using System.Text;

namespace uplink.Net.LocalModels
{
    public class Project : uplink.Net.Contracts.Models.Project
    {
        internal SWIG.ProjectRef _projectRef = null;

        /// <summary>
        /// 
        /// </summary>
        public Project(Uplink uplink, ApiKey apiKey, string satelliteAddr, ProjectOptions projectOptions) :
            base(uplink, apiKey, satelliteAddr, projectOptions)
        {
            string error;

            _projectRef = SWIG.storj_uplink.open_project(uplink._uplinkRef, satelliteAddr, apiKey._apiKeyRef, out error);

            if (!string.IsNullOrEmpty(error))
                throw new ArgumentException(error);
            if (_projectRef == null)
                throw new NullReferenceException("Could not open project");
        }

        public override void Dispose()
        {
            if (_projectRef != null)
            {
                string error;
                SWIG.storj_uplink.close_project(_projectRef, out error);
                _projectRef = null;
            }
        }
    }
}