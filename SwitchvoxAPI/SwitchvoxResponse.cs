﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SwitchvoxAPI
{
    /// <summary>
    /// Encapsulates a response from a <see cref="T:SwitchvoxAPI.SwitchvoxRequest"/>.
    /// </summary>
    public class SwitchvoxResponse
    {
        private readonly XDocument xml;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SwitchvoxAPI.SwitchvoxResponse"/> class.
        /// </summary>
        /// <param name="xml">The XML to be contained in the response.</param>
        public SwitchvoxResponse(XDocument xml)
        {
            this.xml = xml;
        }

        /// <summary>
        /// Retrieve all elements with a specified tag name from the <see cref="T:SwitchvoxAPI.SwitchvoxResponse"/>.
        /// </summary>
        /// <param name="name">The name of the XML tag</param>
        /// <returns>An enumeration of <see cref="T:System.Xml.Linq.XElement"/>s with the specified name</returns>
        public IEnumerable<XElement> GetElements(string name)
        {
            return xml.Descendants(name);
        }
        
        /// <summary>
        /// Retrieve a single attribute of a specified XML tag name
        /// </summary>
        /// <param name="element">The name of the XML tag</param>
        /// <param name="attribute">The name of the attribute</param>
        /// <returns>The value of the attribute</returns>
        public string GetAttribute(string element, string attribute)
        {
            var attrib = xml.Descendants(element).Single().Attribute(attribute).Value;

            return attrib;
        }

        /// <summary>
        /// Retrieve all attributes of a specified XML tag name
        /// </summary>
        /// <param name="element">The name of the XML tag</param>
        /// <param name="attribute">The name of the XML attribute</param>
        /// <returns>A string array containing the value of specified attribute of each specified element</returns>
        public string[] GetAttributes(string element, string attribute)
        {
            var attribs = xml.Descendants(element).Select(e => e.Attribute(attribute).Value);

            return attribs.ToArray();
        }

    }
}