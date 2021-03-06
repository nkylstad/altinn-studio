﻿using System.Collections.Generic;

namespace AltinnCore.ServiceLibrary
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The resource collection.
    /// </summary>
    public class ResourceCollection
    {
        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        [JsonProperty("resources")]
        public IList<Resource> Resources { get; set; }

        /// <summary>
        /// Adds text resource to the Resources list.
        /// </summary>
        /// <param name="id"> The id. </param>
        /// <param name="value"> The value. </param>
        /// <exception cref="ArgumentException">id missing</exception>
        public void Add(string id, string value)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Argument null or whitespace", nameof(id));
            }

            Resources.Add(new Resource { Id = id, Value = value ?? string.Empty });
        }
    }
}
