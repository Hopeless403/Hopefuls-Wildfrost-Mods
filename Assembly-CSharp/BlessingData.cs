// Decompiled with JetBrains decompiler
// Type: BlessingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

[Serializable]
public class BlessingData
{
  public GameModifierData modifierToAdd;

  public void Select()
  {
    ModifierSystem.AddModifier(Campaign.Data, this.modifierToAdd);
    Routine.Clump clump = new Routine.Clump();
    foreach (Script startScript in this.modifierToAdd.startScripts)
      clump.Add(startScript.Run());
    foreach (Script setupScript in this.modifierToAdd.setupScripts)
      clump.Add(setupScript.Run());
    foreach (string componentName in this.modifierToAdd.systemsToAdd)
    {
      Debug.Log((object) string.Format("[{0}] adding system: {1}", (object) this.modifierToAdd, (object) componentName));
      Campaign.instance.gameObject.AddComponentByName(componentName);
    }
  }
}
