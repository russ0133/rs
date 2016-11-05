﻿using System.Linq;

namespace MetroOverhaul.Extensions
{
    public static class BuildingInfoExtensions
    {
        public static bool IsMetroDepot(this BuildingInfo info)
        {
            return info?.m_class != null && info.m_buildingAI is DepotAI && info.m_class.m_subService == ItemClass.SubService.PublicTransportMetro;
        }

        public static bool IsUndergroundMetroStation(this BuildingInfo info)
        {
            return IsMetroDepot(info) && info.m_paths != null && info.m_paths.Any(p => p?.m_netInfo != null && p.m_netInfo.name == "Metro Station Track");
        }
    }
}