﻿using Rocket.API;
using Rocket.Unturned.Player;

namespace RocketRegions.Util
{
    public static class PermissionUtil
    {
        public static bool HasPermission(IRocketPlayer player, string permission)
        {
            var unturnedPlayer = player as UnturnedPlayer;
            if (unturnedPlayer != null && unturnedPlayer.IsAdmin)
            {
                return true;
            }
            return player.HasPermission("regiones." + permission);
        }
    }
}