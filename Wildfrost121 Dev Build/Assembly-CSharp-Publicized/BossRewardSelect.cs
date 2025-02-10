// Decompiled with JetBrains decompiler
// Type: BossRewardSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class BossRewardSelect : MonoBehaviourRect
{
  [SerializeField]
  public InputAction inputAction;
  [SerializeField]
  public KeywordData popUpKeyword;
  public string title;
  public string body;
  public string popUpName;
  public bool poppedUp;
  public static readonly Vector2 popUpOffset = new Vector2(1f, 0.0f);

  public virtual void SetUp(
    BossRewardData.Data rewardData,
    GainBlessingSequence2 gainBlessingSequence)
  {
    this.inputAction.action.AddListener((UnityAction) (() => gainBlessingSequence.Select(rewardData)));
    this.inputAction.action.AddListener(new UnityAction(this.Destroy));
  }

  public void Pop()
  {
    if (this.poppedUp)
      return;
    CardPopUp.AssignTo(this.rectTransform, BossRewardSelect.popUpOffset.x, BossRewardSelect.popUpOffset.y);
    if ((bool) (Object) this.popUpKeyword)
      CardPopUp.AddPanel(this.popUpKeyword);
    else
      CardPopUp.AddPanel(this.popUpName, this.title, this.body);
    this.poppedUp = true;
  }

  public void UnPop()
  {
    if (!this.poppedUp)
      return;
    CardPopUp.RemovePanel((bool) (Object) this.popUpKeyword ? this.popUpKeyword.name : this.popUpName);
    this.poppedUp = false;
  }

  public void Destroy()
  {
    this.UnPop();
    Object.Destroy((Object) this.gameObject);
  }
}
