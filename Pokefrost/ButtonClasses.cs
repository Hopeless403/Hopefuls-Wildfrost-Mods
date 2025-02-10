// Decompiled with JetBrains decompiler
// Type: Pokefrost.ButtonExt
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  public class ButtonExt : Button
  {
    internal static ButtonExt dragBlocker;

    internal StatusIconExt Icon => this.GetComponent<StatusIconExt>();

    internal Entity Entity => this.Icon?.target;

    public override void OnPointerEnter(PointerEventData eventData) => ButtonExt.dragBlocker = this;

    public override void OnPointerExit(PointerEventData eventData) => this.DisableDragBlocking();

    public void DisableDragBlocking()
    {
      if (!((Object) ButtonExt.dragBlocker == (Object) this))
        return;
      ButtonExt.dragBlocker = (ButtonExt) null;
    }

    public static void DisableDrag(ref Entity arg0, ref bool arg1)
    {
      if ((Object) ButtonExt.dragBlocker == (Object) null || (Object) arg0 != (Object) ButtonExt.dragBlocker.Entity)
        return;
      arg1 = false;
    }
  }
}
