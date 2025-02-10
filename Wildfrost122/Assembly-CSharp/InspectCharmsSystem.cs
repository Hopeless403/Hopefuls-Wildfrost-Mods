// Decompiled with JetBrains decompiler
// Type: InspectCharmsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class InspectCharmsSystem : GameSystem
{
  [SerializeField]
  private InspectSystem inspectSystem;
  [SerializeField]
  private CardCharm charmPrefab;
  [SerializeField]
  private GridLayoutGroup grid;
  [SerializeField]
  private string[] closeInputs = new string[3]
  {
    "Select",
    "Back",
    "Inspect"
  };
  private readonly List<CardCharm> charms = new List<CardCharm>();
  private const int maxCharms = 30;
  private const int maxColumns = 6;
  private float wait;

  private void Update()
  {
    if ((double) this.wait <= 0.0 && !MonoBehaviourSingleton<Cursor3d>.instance.usingMouse && ((IEnumerable<string>) this.closeInputs).Any<string>((Func<string, bool>) (i => InputSystem.IsButtonPressed(i))))
      this.Hide();
    if ((double) this.wait <= 0.0)
      return;
    this.wait -= Time.deltaTime;
  }

  public void Show()
  {
    this.gameObject.SetActive(true);
    this.Create(this.inspectSystem.inspect.data.upgrades.Where<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.type == CardUpgradeData.Type.Charm)).ToArray<CardUpgradeData>());
    this.wait = 0.15f;
  }

  private void Create(CardUpgradeData[] cardUpgrades)
  {
    int count = Mathf.Min(30, cardUpgrades.Length);
    this.SetGridSize(count);
    for (int index = 0; index < count; ++index)
    {
      CardCharm cardCharm = UnityEngine.Object.Instantiate<CardCharm>(this.charmPrefab, this.grid.transform);
      cardCharm.SetData(cardUpgrades[index]);
      cardCharm.holder = cardCharm.transform;
      this.charms.Add(cardCharm);
    }
  }

  private void SetGridSize(int count)
  {
    int num1 = Mathf.Min(6, count);
    int num2 = Mathf.CeilToInt((float) count / 6f);
    if (!(this.grid.transform is RectTransform transform))
      return;
    transform.sizeDelta = new Vector2((float) num1 * this.grid.cellSize.x, (float) num2 * this.grid.cellSize.y);
  }

  public void TryHide()
  {
    if ((double) this.wait > 0.0)
      return;
    this.Hide();
  }

  private void Hide()
  {
    foreach (Component charm in this.charms)
      charm.gameObject.Destroy();
    this.charms.Clear();
    this.gameObject.SetActive(false);
  }
}
