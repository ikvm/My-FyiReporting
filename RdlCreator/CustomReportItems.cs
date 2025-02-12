﻿using System.Xml.Serialization;

namespace fyiReporting.RdlCreator
{
    public class CustomReportItems
    {
        public string Type { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Left { get; set; }
        public string Top { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "CustomProperties")]
        public CustomProperties CustomProperties { get; set; }
    }
}