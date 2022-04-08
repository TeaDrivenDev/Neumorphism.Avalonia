﻿using System.Collections.Generic;

namespace Neumorphism.Avalonia.Styles.Internal
{
    internal static class IconsDataSet
    {
        internal const string UnknownIconData =
            "M11,15H13V17H11V15M11,7H13V13H11V7M12,2C6.47,2 2,6.5 2,12A10,10 0 0,0 12,22A10,10 0 0,0 22,12A10,10 0 0,0 12,2M12,20A8,8 0 0,1 4,12A8,8 0 0,1 12,4A8,8 0 0,1 20,12A8,8 0 0,1 12,20Z";

        internal static IDictionary<string, string> CreateDataSet() => new Dictionary<string, string>
        {
            {"Calendar", "M19,19H5V8H19M16,1V3H8V1H6V3H5C3.89,3 3,3.89 3,5V19A2,2 0 0,0 5,21H19A2,2 0 0,0 21,19V5C21,3.89 20.1,3 19,3H18V1M17,12H12V17H17V12Z"}, 
            {"ChevronLeft", "M15.41,16.58L10.83,12L15.41,7.41L14,6L8,12L14,18L15.41,16.58Z"},
            {"ChevronRight", "M8.59,16.58L13.17,12L8.59,7.41L10,6L16,12L10,18L8.59,16.58Z"},
            {"EyeOutline", "M12,9A3,3 0 0,1 15,12A3,3 0 0,1 12,15A3,3 0 0,1 9,12A3,3 0 0,1 12,9M12,4.5C17,4.5 21.27,7.61 23,12C21.27,16.39 17,19.5 12,19.5C7,19.5 2.73,16.39 1,12C2.73,7.61 7,4.5 12,4.5M3.18,12C4.83,15.36 8.24,17.5 12,17.5C15.76,17.5 19.17,15.36 20.82,12C19.17,8.64 15.76,6.5 12,6.5C8.24,6.5 4.83,8.64 3.18,12Z"},
            {"EyeOffOutline", "M2,5.27L3.28,4L20,20.72L18.73,22L15.65,18.92C14.5,19.3 13.28,19.5 12,19.5C7,19.5 2.73,16.39 1,12C1.69,10.24 2.79,8.69 4.19,7.46L2,5.27M12,9A3,3 0 0,1 15,12C15,12.35 14.94,12.69 14.83,13L11,9.17C11.31,9.06 11.65,9 12,9M12,4.5C17,4.5 21.27,7.61 23,12C22.18,14.08 20.79,15.88 19,17.19L17.58,15.76C18.94,14.82 20.06,13.54 20.82,12C19.17,8.64 15.76,6.5 12,6.5C10.91,6.5 9.84,6.68 8.84,7L7.3,5.47C8.74,4.85 10.33,4.5 12,4.5M3.18,12C4.83,15.36 8.24,17.5 12,17.5C12.69,17.5 13.37,17.43 14,17.29L11.72,15C10.29,14.85 9.15,13.71 9,12.28L5.6,8.87C4.61,9.72 3.78,10.78 3.18,12Z"},
            {"Close", "M19,6.41L17.59,5L12,10.59L6.41,5L5,6.41L10.59,12L5,17.59L6.41,19L12,13.41L17.59,19L19,17.59L13.41,12L19,6.41Z"},
            {"Heart", "M12,21.35L10.55,20.03C5.4,15.36 2,12.27 2,8.5C2,5.41 4.42,3 7.5,3C9.24,3 10.91,3.81 12,5.08C13.09,3.81 14.76,3 16.5,3C19.58,3 22,5.41 22,8.5C22,12.27 18.6,15.36 13.45,20.03L12,21.35Z" },
            
            // Context menu -- For TextBox context menu use
            {"MaterialContentCut", "M19 3L13 9L15 11L22 4V3M12 12.5A0.5 0.5 0 0 1 11.5 12A0.5 0.5 0 0 1 12 11.5A0.5 0.5 0 0 1 12.5 12A0.5 0.5 0 0 1 12 12.5M6 20A2 2 0 0 1 4 18C4 16.89 4.9 16 6 16A2 2 0 0 1 8 18C8 19.11 7.1 20 6 20M6 8A2 2 0 0 1 4 6C4 4.89 4.9 4 6 4A2 2 0 0 1 8 6C8 7.11 7.1 8 6 8M9.64 7.64C9.87 7.14 10 6.59 10 6A4 4 0 0 0 6 2A4 4 0 0 0 2 6A4 4 0 0 0 6 10C6.59 10 7.14 9.87 7.64 9.64L10 12L7.64 14.36C7.14 14.13 6.59 14 6 14A4 4 0 0 0 2 18A4 4 0 0 0 6 22A4 4 0 0 0 10 18C10 17.41 9.87 16.86 9.64 16.36L12 14L19 21H22V20L9.64 7.64Z"},
            {"MaterialContentCopy", "M19 21H8V7H19M19 5H8A2 2 0 0 0 6 7V21A2 2 0 0 0 8 23H19A2 2 0 0 0 21 21V7A2 2 0 0 0 19 5M16 1H4A2 2 0 0 0 2 3V17H4V3H16V1Z"},
            {"MaterialContentPaste", "M19 20H5V4H7V7H17V4H19M12 2A1 1 0 0 1 13 3A1 1 0 0 1 12 4A1 1 0 0 1 11 3A1 1 0 0 1 12 2M19 2H14.82C14.4 0.84 13.3 0 12 0C10.7 0 9.6 0.84 9.18 2H5A2 2 0 0 0 3 4V20A2 2 0 0 0 5 22H19A2 2 0 0 0 21 20V4A2 2 0 0 0 19 2Z"},
            {"MaterialSelectAll", "M9 9H15V15H9M7 17H17V7H7M15 5H17V3H15M15 21H17V19H15M19 17H21V15H19M19 9H21V7H19M19 21A2 2 0 0 0 21 19H19M19 13H21V11H19M11 21H13V19H11M9 3H7V5H9M3 17H5V15H3M5 21V19H3A2 2 0 0 0 5 21M19 3V5H21A2 2 0 0 0 19 3M13 3H11V5H13M3 9H5V7H3M7 21H9V19H7M3 13H5V11H3M3 5H5V3A2 2 0 0 0 3 5Z"},
        };
    }
}