// Decompiled with JetBrains decompiler
// Type: BlessingSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Components;

public class BlessingSelect : MonoBehaviour
{
  [SerializeField]
  private InputAction inputAction;
  [SerializeField]
  private ImageSprite bellImage;
  [SerializeField]
  private ImageSprite dingerImage;
  [SerializeField]
  private LocalizeStringEvent titleString;
  [SerializeField]
  private LocalizeStringEvent descString;

  public void SetUp(BlessingData blessingData, GainBlessingSequence gainBlessingSequence)
  {
    this.inputAction.action.AddListener((UnityAction) (() => gainBlessingSequence.SelectBlessing(blessingData)));
    this.bellImage.SetSprite(blessingData.modifierToAdd.bellSprite);
    this.dingerImage.SetSprite(blessingData.modifierToAdd.dingerSprite);
    this.titleString.StringReference = blessingData.modifierToAdd.titleKey;
    this.descString.StringReference = blessingData.modifierToAdd.descriptionKey;
  }
}
