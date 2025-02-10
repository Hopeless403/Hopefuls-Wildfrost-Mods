// Decompiled with JetBrains decompiler
// Type: ScriptableCurrentStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Amount/Current Status", fileName = "CurrentStatus")]
public class ScriptableCurrentStatus : ScriptableAmount
{
  [SerializeField]
  private string statusType = "shroom";
  [SerializeField]
  private int offset;

  public override int Get(Entity entity)
  {
    if (!(bool) (Object) entity)
      return this.offset;
    StatusEffectData status = entity.FindStatus(this.statusType);
    return status == null ? this.offset : status.count + this.offset;
  }
}
