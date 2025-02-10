// Decompiled with JetBrains decompiler
// Type: StatusEffectDamageEnemiesWhenDrawn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X To Enemies When Drawn", fileName = "Apply X To Enemies When Drawn")]
public class StatusEffectDamageEnemiesWhenDrawn : StatusEffectApplyX
{
  public override void Init() => this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.Check);

  public override bool RunEnableEvent(Entity entity) => (Object) entity == (Object) this.target && this.target.InHand();

  public IEnumerator Check(Entity entity) => this.Run(this.GetTargets());
}
