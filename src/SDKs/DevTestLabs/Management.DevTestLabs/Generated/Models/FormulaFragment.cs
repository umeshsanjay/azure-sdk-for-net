// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A formula for creating a VM, specifying an image base and other
    /// parameters
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FormulaFragment : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the FormulaFragment class.
        /// </summary>
        public FormulaFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FormulaFragment class.
        /// </summary>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="description">The description of the formula.</param>
        /// <param name="author">The author of the formula.</param>
        /// <param name="osType">The OS type of the formula.</param>
        /// <param name="formulaContent">The content of the formula.</param>
        /// <param name="vm">Information about a VM from which a formula is to
        /// be created.</param>
        public FormulaFragment(IDictionary<string, string> tags = default(IDictionary<string, string>), string description = default(string), string author = default(string), string osType = default(string), LabVirtualMachineCreationParameterFragment formulaContent = default(LabVirtualMachineCreationParameterFragment), FormulaPropertiesFromVmFragment vm = default(FormulaPropertiesFromVmFragment))
            : base(tags)
        {
            Description = description;
            Author = author;
            OsType = osType;
            FormulaContent = formulaContent;
            Vm = vm;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description of the formula.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the author of the formula.
        /// </summary>
        [JsonProperty(PropertyName = "properties.author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the OS type of the formula.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the content of the formula.
        /// </summary>
        [JsonProperty(PropertyName = "properties.formulaContent")]
        public LabVirtualMachineCreationParameterFragment FormulaContent { get; set; }

        /// <summary>
        /// Gets or sets information about a VM from which a formula is to be
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vm")]
        public FormulaPropertiesFromVmFragment Vm { get; set; }

    }
}
