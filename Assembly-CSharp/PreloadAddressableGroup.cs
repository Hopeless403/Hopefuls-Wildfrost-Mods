// Decompiled with JetBrains decompiler
// Type: PreloadAddressableGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class PreloadAddressableGroup : MonoBehaviour
{
  [SerializeField]
  private string[] groups;
  private static bool done;

  private async void Start()
  {
    PreloadAddressableGroup addressableGroup = this;
    if (PreloadAddressableGroup.done)
    {
      Object.Destroy((Object) addressableGroup.gameObject);
    }
    else
    {
      PreloadAddressableGroup.done = true;
      Object.DontDestroyOnLoad((Object) addressableGroup.gameObject);
      Debug.Log((object) string.Format("~ ASSET PRELOADER: {0} group(s) to load", (object) addressableGroup.groups.Length));
      string[] strArray = addressableGroup.groups;
      for (int index = 0; index < strArray.Length; ++index)
      {
        string group = strArray[index];
        Debug.Log((object) ("~ ASSET PRELOADER: Loading Group [" + group + "]"));
        StopWatch.Start();
        await AddressableLoader.PreLoadGroup(group);
        Debug.Log((object) string.Format("~ ASSET PRELOADER: Group [{0}] Loaded! ({1}ms)", (object) group, (object) StopWatch.Stop()));
        group = (string) null;
      }
      strArray = (string[]) null;
      Debug.Log((object) "~ ASSET PRELOADER: Finished");
      Object.Destroy((Object) addressableGroup.gameObject);
    }
  }
}
