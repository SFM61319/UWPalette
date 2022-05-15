using System;
using System.Runtime.InteropServices;

using Windows.ApplicationModel.Resources;

namespace UWPalette.Helpers
{
    internal static class ResourceExtensions
    {
        private static ResourceLoader _resLoader = new ResourceLoader();

        public static string GetLocalized(this string resourceKey)
        {
            return _resLoader.GetString(resourceKey);
        }
    }
}
