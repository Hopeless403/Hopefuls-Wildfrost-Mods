// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ModsSceneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deadpan.Enums.Engine.Components.Modding
{
  public class ModsSceneManager : MonoBehaviour
  {
    [SerializeField]
    private GameObject Content;
    [SerializeField]
    private GameObject ModPrefab;
    private List<WildfrostMod> instantiatedMods = new List<WildfrostMod>();

    private IEnumerator Start()
    {
      foreach (WildfrostMod mod in Bootstrap.Mods)
      {
        if (!this.instantiatedMods.Contains(mod))
        {
          GameObject gameObject = this.ModPrefab.InstantiateKeepName<GameObject>();
          gameObject.transform.SetParent(this.Content.transform);
          gameObject.transform.SetLocalZ(0.0f);
          gameObject.transform.SetLocalPositionAndRotation(gameObject.transform.localPosition, Quaternion.identity);
          ModHolder componentInChildren = gameObject.GetComponentInChildren<ModHolder>();
          componentInChildren.Mod = mod;
          componentInChildren.UpdateInfo();
          this.instantiatedMods.Add(mod);
        }
      }
      Time.timeScale = 1f;
      yield break;
    }
  }
}
