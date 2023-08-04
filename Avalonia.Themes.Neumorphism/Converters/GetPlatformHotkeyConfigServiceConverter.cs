﻿using System;
using System.Globalization;
using System.Linq;
using Avalonia.Data.Converters;
using Avalonia.Input.Platform;

namespace Avalonia.Themes.Neumorphism.Converters
{
    public class GetPlatformHotkeyConfigServiceConverter : IValueConverter
    {
        private readonly PlatformHotkeyConfiguration _config = Application.Current?.PlatformSettings?.HotkeyConfiguration;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is not string kind)
                return null;

            if (_config == null)
                return null;

            var gestures = kind switch
            {
                "copy" => _config.Copy,
                "cut" => _config.Cut,
                "paste" => _config.Paste,
                "selectall" => _config.SelectAll,
                "undo" => _config.Undo,
                "redo" => _config.Redo,
                _ => null
            };

            return gestures?.FirstOrDefault();
        }

        /// <summary>
        /// Unsupported procedure. Dont use it.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}