// Decompiled with JetBrains decompiler
// Type: StatusEffectInjury
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Injuries/Injury", fileName = "Injury")]
public class StatusEffectInjury : StatusEffectData
{
  [SerializeField]
  private float healthFactor = 0.5f;
  [SerializeField]
  private float damageFactor = 0.5f;
  [SerializeField]
  private int counterIncrease;
  private bool hasRun;

  protected override void Init() => global::Events.OnBattleStart += new UnityAction(this.BattleStart);

  private void OnDestroy() => global::Events.OnBattleStart -= new UnityAction(this.BattleStart);

  private void BattleStart() => this.Run();

  public override bool RunBeginEvent()
  {
    if (!this.target.inPlay)
      this.Run();
    return false;
  }

  private void Run()
  {
    if (this.hasRun)
      return;
    this.hasRun = true;
    if (this.counterIncrease > 0 && this.target.counter.max > 0)
    {
      this.target.counter.max += this.counterIncrease;
      this.target.counter.current += this.counterIncrease;
    }
    this.target.damage.current = Mathf.CeilToInt((float) this.target.damage.current * this.damageFactor);
    this.target.hp.current = Mathf.CeilToInt((float) this.target.hp.current * this.healthFactor);
    this.target.PromptUpdate();
  }
}
