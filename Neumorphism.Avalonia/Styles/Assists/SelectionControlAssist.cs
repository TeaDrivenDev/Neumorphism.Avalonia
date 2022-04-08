﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace Neumorphism.Avalonia.Styles.Assists {
    public static class SelectionControlAssist {
        #region Size of selection widget

        public static readonly AvaloniaProperty<double> SizeProperty
            = AvaloniaProperty.RegisterAttached<Button, double>("Size", typeof(SelectionControlAssist));

        public static double GetSize(Button element) {
            return (double) element.GetValue(SizeProperty);
        }

        public static void SetSize(Button element, double checkBoxSize) {
            element.SetValue(SizeProperty, checkBoxSize);
        }

        #endregion

        #region InnerSize of selection widget

        public static readonly AvaloniaProperty<double> InnerSizeProperty
            = AvaloniaProperty.RegisterAttached<Button, double>("InnerSize", typeof(SelectionControlAssist));

        public static double GetInnerSize(Button element)
        {
            return (double)element.GetValue(InnerSizeProperty);
        }

        public static void SetInnerSize(Button element, double checkBoxInnerSize)
        {
            element.SetValue(InnerSizeProperty, checkBoxInnerSize);
        }

        #endregion

        #region Main selection widget foreground

        public static readonly AvaloniaProperty<IBrush> ForegroundProperty
            = AvaloniaProperty.RegisterAttached<Button, IBrush>("Foreground", typeof(SelectionControlAssist));

        public static IBrush GetForeground(Button element) {
            return (IBrush) element.GetValue(ForegroundProperty);
        }

        public static void SetForeground(Button element, IBrush brush) {
            element.SetValue(ForegroundProperty, brush);
        }

        #endregion

        #region Inner widget foreground color of selection widget

        public static readonly AvaloniaProperty<IBrush> InnerForegroundProperty
            = AvaloniaProperty.RegisterAttached<Button, IBrush>("InnerForeground", typeof(SelectionControlAssist));

        public static IBrush GetInnerForeground(Button element) {
            return (IBrush) element.GetValue(InnerForegroundProperty);
        }

        public static void SetInnerForeground(Button element, IBrush brush) {
            element.SetValue(InnerForegroundProperty, brush);
        }

        #endregion
    }
}