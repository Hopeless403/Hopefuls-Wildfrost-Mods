// Decompiled with JetBrains decompiler
// Type: ScriptableCurrentStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Amount/Current Status", fileName = "CurrentStatus")]
public class ScriptableCurrentStatus : ScriptableAmount
{
  [SerializeField]
  public string statusType = "shroom";
  [SerializeField]
  public int offset;

  public override int Get(Entity entity)
  {
    if (!(bool) (Object) entity)
      return this.offset;
    StatusEffectData status = entity.FindStatus(this.statusType);
    return status == null ? this.offset : status.count + this.offset;
  }
}
