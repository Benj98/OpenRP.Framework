﻿using OpenRP.Framework.Features.DebugSettingsFeature.Components;
using SampSharp.Entities.SAMP;

namespace OpenRP.Framework.Features.DebugSettingsFeature.Services
{
    public interface IDebugSettingsService
    {
        DebugSettings ReloadDebugSettings(Player player);
        DebugSettings GetDebugSettings(Player player);
        void OpenDebugSettingsDialog(Player player);
    }
}
