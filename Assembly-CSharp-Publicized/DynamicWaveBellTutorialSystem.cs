// Decompiled with JetBrains decompiler
// Type: DynamicWaveBellTutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

public class DynamicWaveBellTutorialSystem : GameSystem
{
  public LocalizedString helpKey;
  public Prompt.Emote.Type emote = Prompt.Emote.Type.Explain;
  public LocalizedString buttonKey;
  public Sprite helpSprite;

  public void OnEnable()
  {
    global::Events.OnWaveDeployerPostCountDown += new UnityAction<int>(this.WaveDeployerCountDown);
    if (!SaveSystem.LoadProgressData<bool>("dynamicWaveBellTutorial", false))
      return;
    this.enabled = false;
  }

  public void OnDisable() => global::Events.OnWaveDeployerPostCountDown -= new UnityAction<int>(this.WaveDeployerCountDown);

  public void WaveDeployerCountDown(int counter)
  {
    if (counter <= 0 || Battle.GetCardsOnBoard(References.Battle.enemy).Count != 0)
      return;
    this.ShowHelp();
  }

  public void ShowHelp()
  {
    HelpPanelSystem.Show(this.helpKey);
    HelpPanelSystem.SetEmote(this.emote);
    HelpPanelSystem.SetImage(2f, 2f, this.helpSprite);
    HelpPanelSystem.SetBackButtonActive(false);
    HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, this.buttonKey, "Select", new UnityAction(this.End));
  }

  public void End()
  {
    SaveSystem.SaveProgressData<bool>("dynamicWaveBellTutorial", true);
    this.enabled = false;
  }
}
