// Decompiled with JetBrains decompiler
// Type: StatusIconSnow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
public class StatusIconSnow : StatusIcon
{
  public void CustomSetText()
  {
    TMP_Text textElement = this.textElement;
    Stat stat = this.GetValue();
    int num = stat.current + this.target.counter.current;
    if (!((Object) textElement != (Object) null))
      return;
    textElement.text = num.ToString();
    if (!this.alterTextColours)
      return;
    textElement.color = num > stat.max ? this.textColourAboveMax : this.textColour;
  }

  public void CustomDestroy()
  {
    Transform parent = this.transform.parent;
    if (!((Object) parent != (Object) null))
      return;
    foreach (Component component1 in parent)
    {
      StatusIcon component2 = component1.GetComponent<StatusIcon>();
      if (component2.type == "counter")
      {
        component2.Ping();
        break;
      }
    }
  }
}
