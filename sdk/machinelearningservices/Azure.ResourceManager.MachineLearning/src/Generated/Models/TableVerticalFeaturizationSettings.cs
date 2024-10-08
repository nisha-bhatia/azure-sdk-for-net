// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Featurization Configuration. </summary>
    public partial class TableVerticalFeaturizationSettings : MachineLearningFeaturizationSettings
    {
        /// <summary> Initializes a new instance of <see cref="TableVerticalFeaturizationSettings"/>. </summary>
        public TableVerticalFeaturizationSettings()
        {
            BlockedTransformers = new ChangeTrackingList<BlockedTransformer>();
            ColumnNameAndTypes = new ChangeTrackingDictionary<string, string>();
            TransformerParams = new ChangeTrackingDictionary<string, IList<ColumnTransformer>>();
        }

        /// <summary> Initializes a new instance of <see cref="TableVerticalFeaturizationSettings"/>. </summary>
        /// <param name="datasetLanguage"> Dataset language, useful for the text data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="mode">
        /// Featurization mode - User can keep the default 'Auto' mode and AutoML will take care of necessary transformation of the data in featurization phase.
        /// If 'Off' is selected then no featurization is done.
        /// If 'Custom' is selected then user can specify additional inputs to customize how featurization is done.
        /// </param>
        /// <param name="blockedTransformers"> These transformers shall not be used in featurization. </param>
        /// <param name="columnNameAndTypes"> Dictionary of column name and its type (int, float, string, datetime etc). </param>
        /// <param name="transformerParams"> User can specify additional transformers to be used along with the columns to which it would be applied and parameters for the transformer constructor. </param>
        /// <param name="enableDnnFeaturization"> Determines whether to use Dnn based featurizers for data featurization. </param>
        internal TableVerticalFeaturizationSettings(string datasetLanguage, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningFeaturizationMode? mode, IList<BlockedTransformer> blockedTransformers, IDictionary<string, string> columnNameAndTypes, IDictionary<string, IList<ColumnTransformer>> transformerParams, bool? enableDnnFeaturization) : base(datasetLanguage, serializedAdditionalRawData)
        {
            Mode = mode;
            BlockedTransformers = blockedTransformers;
            ColumnNameAndTypes = columnNameAndTypes;
            TransformerParams = transformerParams;
            EnableDnnFeaturization = enableDnnFeaturization;
        }

        /// <summary>
        /// Featurization mode - User can keep the default 'Auto' mode and AutoML will take care of necessary transformation of the data in featurization phase.
        /// If 'Off' is selected then no featurization is done.
        /// If 'Custom' is selected then user can specify additional inputs to customize how featurization is done.
        /// </summary>
        [WirePath("mode")]
        public MachineLearningFeaturizationMode? Mode { get; set; }
        /// <summary> These transformers shall not be used in featurization. </summary>
        [WirePath("blockedTransformers")]
        public IList<BlockedTransformer> BlockedTransformers { get; set; }
        /// <summary> Dictionary of column name and its type (int, float, string, datetime etc). </summary>
        [WirePath("columnNameAndTypes")]
        public IDictionary<string, string> ColumnNameAndTypes { get; set; }
        /// <summary> User can specify additional transformers to be used along with the columns to which it would be applied and parameters for the transformer constructor. </summary>
        [WirePath("transformerParams")]
        public IDictionary<string, IList<ColumnTransformer>> TransformerParams { get; set; }
        /// <summary> Determines whether to use Dnn based featurizers for data featurization. </summary>
        [WirePath("enableDnnFeaturization")]
        public bool? EnableDnnFeaturization { get; set; }
    }
}
