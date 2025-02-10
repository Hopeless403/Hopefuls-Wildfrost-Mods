// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.PlayerPointerEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Rewired.UI;
using System.Text;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
  public class PlayerPointerEventData : PointerEventData
  {
    public int playerId { get; set; }

    public int inputSourceIndex { get; set; }

    public IMouseInputSource mouseSource { get; set; }

    public ITouchInputSource touchSource { get; set; }

    public PointerEventType sourceType { get; set; }

    public int buttonIndex { get; set; }

    public PlayerPointerEventData(EventSystem eventSystem)
      : base(eventSystem)
    {
      this.playerId = -1;
      this.inputSourceIndex = -1;
      this.buttonIndex = -1;
    }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine("<b>Player Id</b>: " + this.playerId.ToString());
      stringBuilder.AppendLine("<b>Mouse Source</b>: " + this.mouseSource?.ToString());
      stringBuilder.AppendLine("<b>Input Source Index</b>: " + this.inputSourceIndex.ToString());
      stringBuilder.AppendLine("<b>Touch Source/b>: " + this.touchSource?.ToString());
      stringBuilder.AppendLine("<b>Source Type</b>: " + this.sourceType.ToString());
      stringBuilder.AppendLine("<b>Button Index</b>: " + this.buttonIndex.ToString());
      stringBuilder.Append(base.ToString());
      return stringBuilder.ToString();
    }
  }
}
