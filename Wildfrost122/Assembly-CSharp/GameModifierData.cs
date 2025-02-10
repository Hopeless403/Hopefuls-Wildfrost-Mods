// Decompiled with JetBrains decompiler
// Type: GameModifierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using FMODUnity;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
[CreateAssetMenu(fileName = "Modifier", menuName = "Modifiers/Game Modifier")]
public class GameModifierData : DataFile
{
  public int value = 100;
  public bool visible = true;
  [ShowAssetPreview(64, 64)]
  public Sprite bellSprite;
  [ShowAssetPreview(64, 64)]
  public Sprite dingerSprite;
  public LocalizedString titleKey;
  public LocalizedString descriptionKey;
  public string[] systemsToAdd;
  public Script[] setupScripts;
  public Script[] startScripts;
  public int scriptPriority;
  public GameModifierData[] blockedBy;
  public HardModeModifierData linkedStormBell;
  [SerializeField]
  internal EventReference ringSfxEvent;
  [SerializeField]
  internal Vector2 ringSfxPitch = new Vector2(1f, 1f);

  public void PlayRingSfx()
  {
    if (this.ringSfxEvent.IsNull)
      return;
    int num = (int) SfxSystem.OneShot(this.ringSfxEvent).setPitch(this.ringSfxPitch.PettyRandom() * PettyRandom.Range(0.95f, 1.05f));
  }
}
