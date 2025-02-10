// Decompiled with JetBrains decompiler
// Type: DisableWhenDeckpackOpened
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

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
