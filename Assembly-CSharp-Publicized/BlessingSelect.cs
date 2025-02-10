// Decompiled with JetBrains decompiler
// Type: BlessingSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Components;

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
