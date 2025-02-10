// Decompiled with JetBrains decompiler
// Type: StatusEffectInjury
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Injuries/Injury", fileName = "Injury")]
public class StatusEffectInjury : StatusEffectData
{
  [SerializeField]
  public float healthFactor = 0.5f;
  [SerializeField]
  public float damageFactor = 0.5f;
  [SerializeField]
  public int counterIncrease;
  public bool hasRun;

  public override void Init() => global::Events.OnBattleStart += new UnityAction(this.BattleStart);

  public void OnDestroy() => global::Events.OnBattleStart -= new UnityAction(this.BattleStart);

  public void BattleStart() => this.Run();

  public override bool RunBeginEvent()
  {
    if (!this.target.inPlay)
      this.Run();
    return false;
  }

  public void Run()
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
