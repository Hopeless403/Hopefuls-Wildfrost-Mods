// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ModsSceneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class ModsSceneManager : MonoBehaviour
  {
    [SerializeField]
    public GameObject Content;
    [SerializeField]
    public GameObject ModPrefab;
    public List<WildfrostMod> instantiatedMods = new List<WildfrostMod>();

    public IEnumerator Start()
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
