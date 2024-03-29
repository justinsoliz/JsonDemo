﻿using System;

namespace CorporationWiki.Web.Common
{
    /// <summary>
    /// Interface for serializing and deserializing JSON.
    /// </summary>
    public interface IJsonSerializer
    {
        /// <summary>
        /// Serialize object to json string.
        /// </summary>
        /// <param name="obj">Object to serialize.</param>
        /// <returns>The json string.</returns>
        string SerializeObject(object obj);

        /// <summary>
        /// Deserialize string to the specified type.
        /// </summary>
        /// <param name="json">The json string.</param>
        /// <param name="type">The type of object to deserialize into.</param>
        /// <returns>The deserialized object.</returns>
        object DeserializeObject(string json, Type type);

        /// <summary>
        /// Deserialize string to the specified typle.
        /// </summary>
        /// <typeparam name="T">The type of object to deserialize into.</typeparam>
        /// <param name="json">The json string.</param>
        /// <returns>The deserialized object.</returns>
        T DeserializeObject<T>(string json);

        /// <summary>
        /// Deserialize string to object.
        /// </summary>
        /// <param name="json">The json string.</param>
        /// <returns>The deserialized object.</returns>
        object DeserializeObject(string json);
    }
}
