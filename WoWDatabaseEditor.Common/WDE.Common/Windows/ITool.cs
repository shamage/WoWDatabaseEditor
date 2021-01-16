﻿using System.Windows;
using WDE.Module.Attributes;

namespace WDE.Common.Windows
{
    [NonUniqueProvider]
    public interface ITool
    {
        string Title { get; }
        string UniqueId { get; }
        Visibility Visibility { get; set; }
        ToolPreferedPosition PreferedPosition { get; }
        bool OpenOnStart { get; }
    }

    public enum ToolPreferedPosition
    {
        Left, Right, Bottom
    }
}