/* 
 * directus.io
 *
 * API for directus.io
 *
 * OpenAPI spec version: 1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
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
using SwaggerDateConverter = IO.Directus.Client.SwaggerDateConverter;

namespace IO.Directus.Model
{
    /// <summary>
    /// GetFilesData
    /// </summary>
    [DataContract]
    public partial class GetFilesData :  IEquatable<GetFilesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesData" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Active">Active.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Url">Url.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Caption">Caption.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Charset">Charset.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Width">Width.</param>
        /// <param name="Height">Height.</param>
        /// <param name="Size">Size.</param>
        /// <param name="EmbedId">EmbedId.</param>
        /// <param name="User">User.</param>
        /// <param name="DateUploaded">DateUploaded.</param>
        /// <param name="StorageAdapter">StorageAdapter.</param>
        public GetFilesData(int? Id = default(int?), int? Active = default(int?), string Name = default(string), string Url = default(string), string Title = default(string), string Location = default(string), string Caption = default(string), string Type = default(string), string Charset = default(string), string Tags = default(string), int? Width = default(int?), int? Height = default(int?), int? Size = default(int?), string EmbedId = default(string), int? User = default(int?), string DateUploaded = default(string), string StorageAdapter = default(string))
        {
            this.Id = Id;
            this.Active = Active;
            this.Name = Name;
            this.Url = Url;
            this.Title = Title;
            this.Location = Location;
            this.Caption = Caption;
            this.Type = Type;
            this.Charset = Charset;
            this.Tags = Tags;
            this.Width = Width;
            this.Height = Height;
            this.Size = Size;
            this.EmbedId = EmbedId;
            this.User = User;
            this.DateUploaded = DateUploaded;
            this.StorageAdapter = StorageAdapter;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public int? Active { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Caption
        /// </summary>
        [DataMember(Name="caption", EmitDefaultValue=false)]
        public string Caption { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Charset
        /// </summary>
        [DataMember(Name="charset", EmitDefaultValue=false)]
        public string Charset { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or Sets EmbedId
        /// </summary>
        [DataMember(Name="embed_id", EmitDefaultValue=false)]
        public string EmbedId { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Gets or Sets DateUploaded
        /// </summary>
        [DataMember(Name="date_uploaded", EmitDefaultValue=false)]
        public string DateUploaded { get; set; }

        /// <summary>
        /// Gets or Sets StorageAdapter
        /// </summary>
        [DataMember(Name="storage_adapter", EmitDefaultValue=false)]
        public string StorageAdapter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFilesData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  EmbedId: ").Append(EmbedId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  DateUploaded: ").Append(DateUploaded).Append("\n");
            sb.Append("  StorageAdapter: ").Append(StorageAdapter).Append("\n");
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
            return this.Equals(input as GetFilesData);
        }

        /// <summary>
        /// Returns true if GetFilesData instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFilesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFilesData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Caption == input.Caption ||
                    (this.Caption != null &&
                    this.Caption.Equals(input.Caption))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Charset == input.Charset ||
                    (this.Charset != null &&
                    this.Charset.Equals(input.Charset))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.EmbedId == input.EmbedId ||
                    (this.EmbedId != null &&
                    this.EmbedId.Equals(input.EmbedId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.DateUploaded == input.DateUploaded ||
                    (this.DateUploaded != null &&
                    this.DateUploaded.Equals(input.DateUploaded))
                ) && 
                (
                    this.StorageAdapter == input.StorageAdapter ||
                    (this.StorageAdapter != null &&
                    this.StorageAdapter.Equals(input.StorageAdapter))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Caption != null)
                    hashCode = hashCode * 59 + this.Caption.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Charset != null)
                    hashCode = hashCode * 59 + this.Charset.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.EmbedId != null)
                    hashCode = hashCode * 59 + this.EmbedId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.DateUploaded != null)
                    hashCode = hashCode * 59 + this.DateUploaded.GetHashCode();
                if (this.StorageAdapter != null)
                    hashCode = hashCode * 59 + this.StorageAdapter.GetHashCode();
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
