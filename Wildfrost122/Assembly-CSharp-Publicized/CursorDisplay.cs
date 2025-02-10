// Decompiled with JetBrains decompiler
// Type: CursorDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
public class CursorDisplay : MonoBehaviourRect
{
  [SerializeField]
  public TouchInputModule inputModule;
  [SerializeField]
  public RectTransform pre;
  [SerializeField]
  public TMP_Text text;

  public void LateUpdate()
  {
    Vector2 mousePosition = this.inputModule.MousePosition;
    Vector2 lastMousePosition = this.inputModule.LastMousePosition;
    this.rectTransform.position = (Vector3) mousePosition;
    if ((bool) (Object) this.text)
    {
      Vector2 mouseMove = this.inputModule.MouseMove;
      this.text.text = string.Format("({0}, {1})\n", (object) Mathf.RoundToInt(mousePosition.x), (object) Mathf.RoundToInt(mousePosition.y)) + string.Format("({0}, {1})\n", (object) Mathf.RoundToInt(lastMousePosition.x), (object) Mathf.RoundToInt(lastMousePosition.y)) + string.Format("({0}, {1})\n", (object) Mathf.RoundToInt(mouseMove.x), (object) Mathf.RoundToInt(mouseMove.y)) + string.Format("Hovering: {0}\n", (object) this.inputModule.Hover) + string.Format("Pressing: {0}", (object) this.inputModule.Press);
    }
    if (!(bool) (Object) this.pre)
      return;
    this.pre.position = (Vector3) lastMousePosition;
  }
}
