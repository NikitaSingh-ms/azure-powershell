// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Connector properties of a CDC table in terms of name / value pairs.
    /// </summary>
    public partial class MapperDslConnectorProperties
    {
        /// <summary>
        /// Initializes a new instance of the MapperDslConnectorProperties class.
        /// </summary>
        public MapperDslConnectorProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MapperDslConnectorProperties class.
        /// </summary>

        /// <param name="name">Name of the property.
        /// </param>

        /// <param name="value">Value of the property.
        /// </param>
        public MapperDslConnectorProperties(string name = default(string), object value = default(object))

        {
            this.Name = name;
            this.Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets value of the property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public object Value {get; set; }
    }
}