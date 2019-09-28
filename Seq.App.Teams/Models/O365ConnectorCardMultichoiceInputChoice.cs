// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Seq.App.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// O365O365 connector card multiple choice input item
    /// </summary>
    public partial class O365ConnectorCardMultichoiceInputChoice
    {
        /// <summary>
        /// Initializes a new instance of the
        /// O365ConnectorCardMultichoiceInputChoice class.
        /// </summary>
        public O365ConnectorCardMultichoiceInputChoice() { }

        /// <summary>
        /// Initializes a new instance of the
        /// O365ConnectorCardMultichoiceInputChoice class.
        /// </summary>
        /// <param name="display">The text rednered on ActionCard.</param>
        /// <param name="value">The value received as results.</param>
        public O365ConnectorCardMultichoiceInputChoice(string display = default(string), string value = default(string))
        {
            Display = display;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the text rednered on ActionCard.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "display")]
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets the value received as results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
