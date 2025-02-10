// Decompiled with JetBrains decompiler
// Type: ScriptableHealthLost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
