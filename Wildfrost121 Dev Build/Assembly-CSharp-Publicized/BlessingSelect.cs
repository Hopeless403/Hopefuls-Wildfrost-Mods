// Decompiled with JetBrains decompiler
// Type: BlessingSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Components;

#nullable disable
public class BlessingSelect : MonoBehaviour
{
  [SerializeField]
  public InputAction inputAction;
  [SerializeField]
  public ImageSprite bellImage;
  [SerializeField]
  public ImageSprite dingerImage;
  [SerializeField]
  public LocalizeStringEvent titleString;
  [SerializeField]
  public LocalizeStringEvent descString;

  public void SetUp(BlessingData blessingData, GainBlessingSequence gainBlessingSequence)
  {
    this.inputAction.action.AddListener((UnityAction) (() => gainBlessingSequence.SelectBlessing(blessingData)));
    this.bellImage.SetSprite(blessingData.modifierToAdd.bellSprite);
    this.dingerImage.SetSprite(blessingData.modifierToAdd.dingerSprite);
    this.titleString.StringReference = blessingData.modifierToAdd.titleKey;
    this.descString.StringReference = blessingData.modifierToAdd.descriptionKey;
  }
}
