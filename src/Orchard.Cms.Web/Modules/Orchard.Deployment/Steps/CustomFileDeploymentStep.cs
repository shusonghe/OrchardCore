﻿using System.ComponentModel.DataAnnotations;

namespace Orchard.Deployment.Steps
{
    /// <summary>
    /// Adds a custom file to a <see cref="DeploymentPlanResult"/>. 
    /// </summary>
    public class CustomFileDeploymentStep : DeploymentStep
    {
        public CustomFileDeploymentStep()
        {
            Name = "CustomFileDeploymentStep";
        }

        [Required]
        public string FileName { get; set; }
        public string FileContent { get; set; }
    }
}
