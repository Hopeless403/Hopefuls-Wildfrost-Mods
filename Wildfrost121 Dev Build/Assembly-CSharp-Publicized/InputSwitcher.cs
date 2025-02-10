// Decompiled with JetBrains decompiler
// Type: InputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class InputSwitcher : MonoBehaviour
{
  public static int justSwitchedCount = 3;
  public const int maxJustSwitchedCount = 3;
  public static bool justSwitched;
  public int currentIndex = -1;
  [SerializeField]
  public BaseInputSwitcher startingInput;
  [SerializeReference]
  public BaseInputSwitcher[] switchers;

  public void Awake()
  {
    foreach (Component switcher in this.switchers)
      switcher.gameObject.SetActive(false);
  }

  public void Start()
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

  public void Update()
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

  public void SwitchTo(int profileIndex)
  {
    if (this.currentIndex >= 0)
      this.switchers[this.currentIndex].gameObject.SetActive(false);
    this.switchers[profileIndex].SwitchTo();
    this.currentIndex = profileIndex;
    InputSwitcher.justSwitched = true;
    InputSwitcher.justSwitchedCount = 3;
  }
}
