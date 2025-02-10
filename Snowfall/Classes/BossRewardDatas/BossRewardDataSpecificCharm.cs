// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.BossRewardDatas.BossRewardDataSpecificCharm
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

namespace Snowfall2.Classes.BossRewardDatas
{
  public class BossRewardDataSpecificCharm : BossRewardDataRandomCharm
  {
    public string upgradeName;

    public override BossRewardData.Data Pull()
    {
      BossRewardDataRandomCharm.Data data = new BossRewardDataRandomCharm.Data();
      data.type = BossRewardData.Type.Charm;
      data.upgradeName = this.upgradeName;
      return (BossRewardData.Data) data;
    }
  }
}
