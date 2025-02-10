// Decompiled with JetBrains decompiler
// Type: Deckpack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class Deckpack : MonoBehaviourSingleton<Deckpack>
{
  public UnityEngine.Animator animator;
  [SerializeField]
  private Button button;
  private bool open;

  public static bool IsOpen => MonoBehaviourSingleton<Deckpack>.instance.open;

  public static void Open()
  {
    Events.InvokeDeckpackOpen();
    MonoBehaviourSingleton<Deckpack>.instance.animator.SetBool(nameof (Open), true);
    MonoBehaviourSingleton<Deckpack>.instance.open = true;
  }

  public static void Close()
  {
    Events.InvokeDeckpackClose();
    MonoBehaviourSingleton<Deckpack>.instance.animator.SetBool("Open", false);
    MonoBehaviourSingleton<Deckpack>.instance.open = false;
  }

  public void Ping() => this.animator.SetTrigger(nameof (Ping));
}
