﻿using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace AltinnCore.RepositoryClient.Model
{
  /// <summary>
  /// SearchResults results of a successful search
  /// </summary>
  [DataContract]
  public partial class SearchResults : IEquatable<SearchResults>, IValidatableObject
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchResults" /> class.
    /// </summary>
    /// <param name="Data">Data.</param>
    /// <param name="Ok">Ok.</param>
    public SearchResults(List<Repository> Data = default(List<Repository>), bool? Ok = default(bool?))
    {
      this.Data = Data;
      this.Ok = Ok;
    }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name = "data", EmitDefaultValue = false)]
    public List<Repository> Data { get; set; }

    /// <summary>
    /// Gets or Sets Ok
    /// </summary>
    [DataMember(Name = "ok", EmitDefaultValue = false)]
    public bool? Ok { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class SearchResults {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Ok: ").Append(Ok).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson()
    {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
      return this.Equals(input as SearchResults);
    }

    /// <summary>
    /// Returns true if SearchResults instances are equal
    /// </summary>
    /// <param name="input">Instance of SearchResults to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SearchResults input)
    {
      if (input == null)
        return false;

      return
          (
              this.Data == input.Data ||
              this.Data != null &&
              this.Data.SequenceEqual(input.Data)
          ) &&
          (
              this.Ok == input.Ok ||
              (this.Ok != null &&
              this.Ok.Equals(input.Ok))
          );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
      unchecked // Overflow is fine, just wrap
      {
        int hashCode = 41;
        if (this.Data != null)
          hashCode = hashCode * 59 + this.Data.GetHashCode();
        if (this.Ok != null)
          hashCode = hashCode * 59 + this.Ok.GetHashCode();
        return hashCode;
      }
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
      yield break;
    }
  }
}
