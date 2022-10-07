﻿using Microsoft.AspNetCore.Components;
using SD.Shared.Modal.Enum;

namespace SD.WEB.Core
{
    public static class RefreshCore
    {
        public static EventCallback<Region> RegionChanged { get; set; }

        public static EventCallback<Language> LanguageChanged { get; set; }

        public static async Task ChangeRegion(Region value)
        {
            await RegionChanged.InvokeAsync(value);
        }

        public static async Task ChangeLanguage(Language value)
        {
            await LanguageChanged.InvokeAsync(value);
        }
    }
}