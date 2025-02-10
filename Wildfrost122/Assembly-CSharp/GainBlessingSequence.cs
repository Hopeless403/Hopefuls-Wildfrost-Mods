// Decompiled with JetBrains decompiler
// Type: GainBlessingSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class GainBlessingSequence : UISequence
{
  [SerializeField]
  private AssetReferenceGameObject blessingPrefab;
  [SerializeField]
  private Transform blessingGroup;
  [SerializeField]
  private int options = 3;
  [SerializeField]
  private BlessingData[] blessingPool;
  [SerializeField]
  private LocalizedString titleKey;
  [SerializeField]
  private EventReference selectSfxEvent;
  private readonly List<BlessingData> blessings = new List<BlessingData>();

  public override IEnumerator Run()
  {
    GainBlessingSequence blessingSequence = this;
    List<BlessingData> blessings = blessingSequence.GetBlessings();
    if (blessings.Count > 0)
    {
      CinemaBarSystem.In();
      CinemaBarSystem.Top.SetPrompt(blessingSequence.titleKey.GetLocalizedString(), "Select");
      yield return (object) blessingSequence.CreateBlessings((IEnumerable<BlessingData>) blessings);
      while (!blessingSequence.promptEnd)
        yield return (object) null;
      CinemaBarSystem.Out();
    }
  }

  private List<BlessingData> GetBlessings()
  {
    List<BlessingData> blessings = new List<BlessingData>();
    foreach (BlessingData blessingData in this.blessingPool)
    {
      bool flag = false;
      if (Campaign.Data.Modifiers != null)
      {
        foreach (GameModifierData modifier in Campaign.Data.Modifiers)
        {
          if (blessingData.modifierToAdd.blockedBy.Contains<GameModifierData>(modifier))
          {
            flag = true;
            break;
          }
        }
      }
      if (!flag)
      {
        blessings.Add(blessingData);
        if (blessings.Count >= this.options)
          break;
      }
    }
    return blessings;
  }

  private IEnumerator CreateBlessings(IEnumerable<BlessingData> blessingsToCreate)
  {
    foreach (BlessingData blessingData in blessingsToCreate)
      yield return (object) this.CreateBlessing(blessingData);
  }

  private IEnumerator CreateBlessing(BlessingData blessingData)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    GainBlessingSequence gainBlessingSequence = this;
    AsyncOperationHandle<GameObject> handle;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      handle.Result.GetComponent<BlessingSelect>().SetUp(blessingData, gainBlessingSequence);
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    handle = gainBlessingSequence.blessingPrefab.InstantiateAsync(gainBlessingSequence.blessingGroup);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) handle;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public void SelectBlessing(BlessingData blessingData)
  {
    if (this.promptEnd)
      return;
    blessingData.Select();
    this.promptEnd = true;
    SfxSystem.OneShot(this.selectSfxEvent);
  }
}
