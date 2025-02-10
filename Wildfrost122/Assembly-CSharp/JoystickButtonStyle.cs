// Decompiled with JetBrains decompiler
// Type: JoystickButtonStyle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Rewired;
using Rewired.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
[CreateAssetMenu(menuName = "Joystick Button Style", fileName = "Joystick Button Style")]
public class JoystickButtonStyle : ScriptableObject
{
  public HardwareJoystickMap[] hardwareMaps;
  public string hardwareIdentifier;
  public int templateId;
  public string tag;
  [SerializeField]
  private JoystickButtonStyle.ElementButton[] elements;
  [SerializeField]
  private ControllerType type = ControllerType.Joystick;

  public IEnumerable<Guid> guids
  {
    get
    {
      return ((IEnumerable<HardwareJoystickMap>) this.hardwareMaps).Select<HardwareJoystickMap, Guid>((Func<HardwareJoystickMap, Guid>) (a => a.Guid));
    }
  }

  public JoystickButtonStyle.ElementButton GetElement(Player player, string actionName)
  {
    ActionElementMap elementMapWithAction = player.controllers.maps.GetFirstElementMapWithAction(this.type, actionName, true);
    return elementMapWithAction != null ? this.elements[elementMapWithAction.elementIndex] : (JoystickButtonStyle.ElementButton) null;
  }

  [Serializable]
  public class ElementButton
  {
    public string elementName;
    public Sprite buttonSprite;
    public LocalizedString textKey;

    public bool hasSprite => (bool) (UnityEngine.Object) this.buttonSprite;

    public string text => this.textKey.GetLocalizedString();
  }
}
