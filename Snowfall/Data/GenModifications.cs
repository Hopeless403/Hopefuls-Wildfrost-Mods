// Decompiled with JetBrains decompiler
// Type: Snowfall2.Data.GenModifications
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

namespace Snowfall2.Data
{
  public static class GenModifications
  {
    private static CampaignGenerator Generator => SnowfallMod.GameMode.generator;

    private static StringTable UITextTable => LocalizationHelper.GetCollection("UI Text", new LocaleIdentifier(SystemLanguage.English));

    public static void Load(WildfrostMod mod)
    {
      GenModifications.Generator.nodeSpacing = new Vector2(-3.2f, -2f);
      CampaignNodeType campaignNodeType1 = mod.Get<CampaignNodeType>("CampaignNodeStart");
      CampaignNodeType campaignNodeType2 = mod.Get<CampaignNodeType>("CampaignNodeFinalBoss");
      CampaignNodeType campaignNodeType3 = mod.Get<CampaignNodeType>("CampaignNodeDetail1");
      CampaignNodeType campaignNodeType4 = mod.Get<CampaignNodeType>("CampaignNodeDetail3");
      campaignNodeType1.size = 2f;
      CampaignNodeType campaignNodeType5 = campaignNodeType1;
      CampaignNodeType campaignNodeType6 = campaignNodeType2;
      MapNode mapNodePrefab1 = campaignNodeType2.mapNodePrefab;
      MapNode mapNodePrefab2 = campaignNodeType1.mapNodePrefab;
      MapNode mapNode1 = mapNodePrefab1;
      campaignNodeType5.mapNodePrefab = mapNode1;
      campaignNodeType6.mapNodePrefab = mapNodePrefab2;
      CampaignNodeType campaignNodeType7 = campaignNodeType3;
      CampaignNodeType campaignNodeType8 = campaignNodeType4;
      MapNode mapNodePrefab3 = campaignNodeType4.mapNodePrefab;
      MapNode mapNodePrefab4 = campaignNodeType3.mapNodePrefab;
      MapNode mapNode2 = mapNodePrefab3;
      campaignNodeType7.mapNodePrefab = mapNode2;
      campaignNodeType8.mapNodePrefab = mapNodePrefab4;
      GenModifications.UITextTable.SetString("map area 3", "THE SHADEYARDS");
      GenModifications.UITextTable.SetString("map area 3", "SNOWDWELL DEFENSES");
      AreaData[] areas1 = References.Areas;
      AreaData[] areas2 = References.Areas;
      AreaData area1 = References.Areas[2];
      AreaData area2 = References.Areas[0];
      AreaData areaData = area1;
      areas1[0] = areaData;
      areas2[2] = area2;
    }

    public static void Unload(WildfrostMod mod)
    {
      GenModifications.Generator.nodeSpacing = new Vector2(3.2f, 2f);
      CampaignNodeType campaignNodeType1 = mod.Get<CampaignNodeType>("CampaignNodeStart");
      CampaignNodeType campaignNodeType2 = mod.Get<CampaignNodeType>("CampaignNodeFinalBoss");
      CampaignNodeType campaignNodeType3 = mod.Get<CampaignNodeType>("CampaignNodeDetail1");
      CampaignNodeType campaignNodeType4 = mod.Get<CampaignNodeType>("CampaignNodeDetail3");
      campaignNodeType1.size = 1f;
      CampaignNodeType campaignNodeType5 = campaignNodeType1;
      CampaignNodeType campaignNodeType6 = campaignNodeType2;
      MapNode mapNodePrefab1 = campaignNodeType2.mapNodePrefab;
      MapNode mapNodePrefab2 = campaignNodeType1.mapNodePrefab;
      MapNode mapNode1 = mapNodePrefab1;
      campaignNodeType5.mapNodePrefab = mapNode1;
      campaignNodeType6.mapNodePrefab = mapNodePrefab2;
      CampaignNodeType campaignNodeType7 = campaignNodeType3;
      CampaignNodeType campaignNodeType8 = campaignNodeType4;
      MapNode mapNodePrefab3 = campaignNodeType4.mapNodePrefab;
      MapNode mapNodePrefab4 = campaignNodeType3.mapNodePrefab;
      MapNode mapNode2 = mapNodePrefab3;
      campaignNodeType7.mapNodePrefab = mapNode2;
      campaignNodeType8.mapNodePrefab = mapNodePrefab4;
      GenModifications.UITextTable.SetString("map area 2", "THE ICE CAVES");
      GenModifications.UITextTable.SetString("map area 3", "THE FROSTLANDS");
      AreaData[] areas1 = References.Areas;
      AreaData[] areas2 = References.Areas;
      AreaData area1 = References.Areas[2];
      AreaData area2 = References.Areas[0];
      AreaData areaData = area1;
      areas1[0] = areaData;
      areas2[2] = area2;
    }
  }
}
