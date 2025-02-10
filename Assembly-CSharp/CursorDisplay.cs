// Decompiled with JetBrains decompiler
// Type: CursorDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

public class CursorDisplay : MonoBehaviourRect
{
  [SerializeField]
  private TouchInputModule inputModule;
  [SerializeField]
  private RectTransform pre;
  [SerializeField]
  private TMP_Text text;

  private void LateUpdate()
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
