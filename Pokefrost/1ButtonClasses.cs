// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusIconExt
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class StatusIconExt : StatusIcon
  {
    public ButtonAnimator animator;
    public ButtonExt button;
    private IStatusToken effectToken;

    public override void Assign(Entity entity)
    {
      base.Assign(entity);
      this.SetText();
      this.onValueDown.AddListener((UnityAction<Stat, Stat>) ((_param1, _param2) => this.Ping()));
      this.onValueUp.AddListener((UnityAction<Stat, Stat>) ((_param1, _param2) => this.Ping()));
      this.afterUpdate.AddListener(new UnityAction(((StatusIcon) this).SetText));
      this.onValueDown.AddListener(new UnityAction<Stat, Stat>(((StatusIcon) this).CheckDestroy));
      if (!(entity.FindStatus(this.type) is IStatusToken status))
        return;
      this.effectToken = status;
      status.ButtonCreate(this);
      this.button.onClick.AddListener(new UnityAction(this.effectToken.RunButtonClicked));
      this.onDestroy.AddListener(new UnityAction(this.DisableDragBlocker));
    }

    public void DisableDragBlocker() => this.button.DisableDragBlocking();
  }
}
