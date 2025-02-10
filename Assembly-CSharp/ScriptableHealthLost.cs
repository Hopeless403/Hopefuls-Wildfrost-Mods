// Decompiled with JetBrains decompiler
// Type: ScriptableHealthLost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
