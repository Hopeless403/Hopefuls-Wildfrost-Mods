// Decompiled with JetBrains decompiler
// Type: ScriptableHealthLost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Scriptable Amount/Health Lost", fileName = "HealthLost")]
public class ScriptableHealthLost : ScriptableAmount
{
  public override int Get(Entity entity)
  {
    if (!(bool) (Object) entity)
      return 0;
    Hit lastHit = entity.lastHit;
    return lastHit == null ? 0 : lastHit.damageDealt;
  }
}
