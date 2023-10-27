﻿using System;
using Avalonia.Controls;
using Neumorphism.Avalonia.Demo.Dialogs.ViewModels.Elements;
using Neumorphism.Avalonia.Demo.Dialogs.ViewModels.Elements.Header.Icons;

namespace Neumorphism.Avalonia.Demo.Dialogs.Resources
{
    // ReSharper disable once UnusedType.Global
    public sealed class TemplateResources : ResourceDictionary
    {
        // ReSharper disable UnusedMember.Local
        private void DialogButtonTemplate_OnSelectTemplateKey(object sender, SelectTemplateEventArgs e)
        {
            e.TemplateKey = e.DataContext switch
            {
                ObsoleteDialogButtonViewModel _ => "ObsoleteButton",
                DialogButtonViewModel _ => "StandardButton",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private void DialogHeaderIconTemplate_OnSelectTemplateKey(object sender, SelectTemplateEventArgs e)
        {
            e.TemplateKey = e.DataContext switch
            {
                DialogIconViewModel _ => "DialogIcon",
                ImageIconViewModel _ => "DialogImageIcon",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        // ReSharper restore UnusedMember.Local
    }
}