// Decompiled with JetBrains decompiler
// Type: StatusEffectImmuneToX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Immunity/Immune To X", fileName = "Immune To X")]
public class StatusEffectImmuneToX : StatusEffectData
{
  [SerializeField]
  public string immunityType = "snow";
  public const int max = 1;

  public override void Init()
  {
    this.OnBegin += new StatusEffectData.EffectEventHandler(this.Begin);
  }

  public IEnumerator Begin()
  {
    StatusEffectImmuneToX statusEffectImmuneToX = this;
    StatusEffectData status = statusEffectImmuneToX.target.FindStatus(statusEffectImmuneToX.immunityType);
    if ((bool) (Object) status && status.count > 1)
      yield return (object) status.RemoveStacks(status.count - 1, false);
  }

  public override bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    if ((Object) apply.target == (Object) this.target && (bool) (Object) apply.effectData && apply.effectData.type == this.immunityType)
    {
      StatusEffectData status = this.target.FindStatus(this.immunityType);
      int count = (bool) (Object) status ? status.count : 0;
      apply.count = Mathf.Max(new int[1]{ 1 - count });
    }
    return false;
  }
}
