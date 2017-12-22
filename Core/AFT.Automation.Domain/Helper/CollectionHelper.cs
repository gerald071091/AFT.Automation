using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AFT.Automation.Domain.Helper
{
    public static class CollectionHelper
    {
        /// <summary>
        /// Remove double quotes in string list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IList<string> ToNormalStringList(this IList<string> list)
        {
            IList<string> transformedDetails = new List<string>();
            string rawData = null;

            foreach (string data in list)
            {
                rawData = Regex.IsMatch(data, "\"\"") || data.Contains("\"") ?
                    data.Replace("\"\"", string.Empty) : data;

                transformedDetails.Add(rawData.Trim());
            }

            return transformedDetails;
        }

        /// <summary>
        /// Check if this instance is in this type list provided
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool In<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException("source");
            if (typeof(T) == typeof(string))
            {
                return list.OfType<string>().Contains((string)(object)source, StringComparer.OrdinalIgnoreCase);
            }              
            return list.Contains(source);
        }

        /// <summary>
        /// Check if this string instance is in this list provided
        /// </summary>
        /// <param name="source"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool In(this string source, params string[] list)
        {
            if(null == source) throw new ArgumentNullException("source");
            return list.Contains(source, StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Check if this string instance is in this string list provided
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static bool In(this string source, string args)
        {
            List<string> list = args.Split(',').ToList();

            if (null == source) throw new ArgumentNullException("source");
            return list.Contains(source, StringComparer.OrdinalIgnoreCase);
        } 
    }
}
