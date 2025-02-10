// Decompiled with JetBrains decompiler
// Type: DisableWhenDeckpackOpened
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DisableWhenDeckpackOpened : MonoBehaviour
{
  [SerializeField]
  private Behaviour[] components;
  [SerializeField]
  private GameObject[] gameObjects;

  private void OnEnable()
  {
    global::Events.OnDeckpackOpen += new UnityAction(this.Open);
    global::Events.OnDeckpackClose += new UnityAction(this.Close);
  }

  private void OnDisable()
  {
    global::Events.OnDeckpackOpen -= new UnityAction(this.Open);
    global::Events.OnDeckpackClose -= new UnityAction(this.Close);
  }

  private void Open()
  {
    foreach (Behaviour component in this.components)
      component.enabled = false;
    foreach (GameObject gameObject in this.gameObjects)
      gameObject.SetActive(false);
  }

  private void Close()
  {
    foreach (Behaviour component in this.components)
      component.enabled = true;
    foreach (GameObject gameObject in this.gameObjects)
      gameObject.SetActive(true);
  }
}
