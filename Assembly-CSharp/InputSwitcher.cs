// Decompiled with JetBrains decompiler
// Type: InputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class InputSwitcher : MonoBehaviour
{
  private static int justSwitchedCount = 3;
  private const int maxJustSwitchedCount = 3;
  public static bool justSwitched;
  private int currentIndex = -1;
  [SerializeField]
  private BaseInputSwitcher startingInput;
  [SerializeReference]
  private BaseInputSwitcher[] switchers;

  private void Awake()
  {
    foreach (Component switcher in this.switchers)
      switcher.gameObject.SetActive(false);
  }

  private void Start()
  {
    int length = this.switchers.Length;
    for (int profileIndex = 0; profileIndex < length; ++profileIndex)
    {
      if ((Object) this.switchers[profileIndex] == (Object) this.startingInput)
      {
        this.SwitchTo(profileIndex);
        break;
      }
    }
  }

  private void Update()
  {
    int length = this.switchers.Length;
    for (int profileIndex = 0; profileIndex < length; ++profileIndex)
    {
      if (this.switchers[profileIndex].CheckSwitchTo())
      {
        if (profileIndex != this.currentIndex)
        {
          this.SwitchTo(profileIndex);
          break;
        }
        break;
      }
    }
    if (!InputSwitcher.justSwitched || --InputSwitcher.justSwitchedCount > 0)
      return;
    InputSwitcher.justSwitched = false;
  }

  private void SwitchTo(int profileIndex)
  {
    if (this.currentIndex >= 0)
      this.switchers[this.currentIndex].gameObject.SetActive(false);
    this.switchers[profileIndex].SwitchTo();
    this.currentIndex = profileIndex;
    InputSwitcher.justSwitched = true;
    InputSwitcher.justSwitchedCount = 3;
  }
}
