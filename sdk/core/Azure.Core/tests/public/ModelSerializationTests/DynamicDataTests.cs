// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using Azure.Core.Serialization;
using Azure.Core.Tests.Public.ModelSerializationTests.Models;
using NUnit.Framework;

namespace Azure.Core.Tests.Public.ModelSerializationTests
{
    internal class DynamicDataTests
    {
        [TestCase("D")]
        [TestCase("W")]
        public void CanRoundTripFutureVersionWithoutLoss(string format)
        {
            ModelSerializerOptions options = new ModelSerializerOptions(format);

            string serviceResponse =
            "{\"name\":\"dynamo\"," +
            "\"miniModel\":{\"foo\":\"xProperty\"}" +
            "}";

            BinaryData binaryData = BinaryData.FromString(serviceResponse);

            dynamic widget = binaryData.ToDynamicFromJson();
            widget.MiniModel = new DynamicDataMiniModel { X = "xProperty" };
            DynamicDataBaseModel model = (DynamicDataBaseModel)widget;

            string modifiedServiceResponse =
            @"{
              ""DynamicDataModel"": {
                  ""Cold"": {
                      ""High"": 00,
                      ""Low"": -15
                  },
                  ""Hot"": {
                      ""High"": 100,
                      ""Low"": 70
                  }
              }
            }
            ";
            BinaryData modifiedBinaryData = BinaryData.FromString(modifiedServiceResponse);

            dynamic modifiedWidget = modifiedBinaryData.ToDynamicFromJson();
            RequestContent.Create(modifiedWidget);
            DynamicDataBaseModel modifiedModel = (DynamicDataBaseModel)modifiedWidget.SpecialValue;

            Assert.AreEqual(0, widget.DynamicDataModel.Cold.High);
            Assert.AreEqual(-15, widget.DynamicDataModel.Cold.Low);
            Assert.AreEqual(100, widget.DynamicDataModel.Hot.High);
            Assert.AreEqual(70, widget.DynamicDataModel.Hot.Low);

            //string expected = serviceResponse;

            //var expectedSerializedString = "\uFEFF<?xml version=\"1.0\" encoding=\"utf-8\"?><Tag><Key>Color</Key><Value>Red</Value>";
            //if (format.Equals(ModelSerializerFormat.Data))
            //    expectedSerializedString += "<ReadOnlyProperty>ReadOnly</ReadOnlyProperty>";
            //expectedSerializedString += "</Tag>";

            //ModelXml model = ModelSerializer.Deserialize<ModelXml>(new BinaryData(Encoding.UTF8.GetBytes(serviceResponse)), options);

            //Assert.AreEqual("Color", model.Key);
            //Assert.AreEqual("Red", model.Value);
            //Assert.AreEqual("ReadOnly", model.ReadOnlyProperty);
            //var data = ModelSerializer.Serialize(model, options);
            //string roundTrip = data.ToString();

            //Assert.That(roundTrip, Is.EqualTo(expectedSerializedString));

            //ModelXml model2 = ModelSerializer.Deserialize<ModelXml>(new BinaryData(Encoding.UTF8.GetBytes(roundTrip)), options);
            //VerifyModelXml(model, model2, format);
        }

        internal static void VerifyModelXml(ModelXml correctModelXml, ModelXml model2, string format)
        {
            Assert.AreEqual(correctModelXml.Key, model2.Key);
            Assert.AreEqual(correctModelXml.Value, model2.Value);
            if (format.Equals(ModelSerializerFormat.Data))
                Assert.AreEqual(correctModelXml.ReadOnlyProperty, model2.ReadOnlyProperty);
        }
    }
}
