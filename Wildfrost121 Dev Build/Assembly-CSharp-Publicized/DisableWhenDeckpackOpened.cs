// Decompiled with JetBrains decompiler
// Type: DisableWhenDeckpackOpened
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DisableWhenDeckpackOpened : MonoBehaviour
{
  [SerializeField]
  public Behaviour[] components;
  [SerializeField]
  public GameObject[] gameObjects;

  public void OnEnable()
  {
    global::Events.OnDeckpackOpen += new UnityAction(this.Open);
    global::Events.OnDeckpackClose += new UnityAction(this.Close);
  }

  public void OnDisable()
  {
    global::Events.OnDeckpackOpen -= new UnityAction(this.Open);
    global::Events.OnDeckpackClose -= new UnityAction(this.Close);
  }

  public void Open()
  {
    foreach (Behaviour component in this.components)
      component.enabled = false;
    foreach (GameObject gameObject in this.gameObjects)
      gameObject.SetActive(false);
  }

  public void Close()
  {
    foreach (Behaviour component in this.components)
      component.enabled = true;
    foreach (GameObject gameObject in this.gameObjects)
      gameObject.SetActive(true);
  }
}
