using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace StardewXnbHack.Framework.Writers
{
    /// <summary>Writes <see cref="Dictionary{TKey,TValue}"/> and <see cref="List{T}"/> assets to disk.</summary>
    internal class DataWriter : IAssetWriter
    {
        /*********
        ** Public methods
        *********/
        /// <summary>Whether the writer can handle a given asset.</summary>
        /// <param name="asset">The asset value.</param>
        public bool CanWrite(object asset)
        {
            Type type = asset.GetType();
            type = type.IsGenericType ? type.GetGenericTypeDefinition() : type;

            return type == typeof(Dictionary<,>) || type == typeof(List<>);
        }

        /// <summary>Write an asset instance to disk.</summary>
        /// <param name="asset">The asset value.</param>
        /// <param name="toPathWithoutExtension">The absolute path to the export file, without the file extension.</param>
        /// <param name="relativePath">The relative path within the content folder.</param>
        /// <param name="error">An error phrase indicating why writing to disk failed (if applicable).</param>
        /// <returns>Returns whether writing to disk completed successfully.</returns>
        public bool TryWriteFile(object asset, string toPathWithoutExtension, string relativePath, out string error)
        {
            string json = JsonConvert.SerializeObject(asset, Formatting.Indented);
            File.WriteAllText($"{toPathWithoutExtension}.json", json);

            error = null;
            return true;
        }
    }
}