// Decompiled with JetBrains decompiler
// Type: InspectCharmsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InspectCharmsSystem : GameSystem
{
  [SerializeField]
  public InspectSystem inspectSystem;
  [SerializeField]
  public CardCharm charmPrefab;
  [SerializeField]
  public GridLayoutGroup grid;
  [SerializeField]
  public string[] closeInputs = new string[3]
  {
    "Select",
    "Back",
    "Inspect"
  };
  public readonly List<CardCharm> charms = new List<CardCharm>();
  public const int maxCharms = 30;
  public const int maxColumns = 6;
  public float wait;

  public void Update()
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

  public void Create(CardUpgradeData[] cardUpgrades)
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

  public void SetGridSize(int count)
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

  public void Hide()
  {
    foreach (Component charm in this.charms)
      charm.gameObject.Destroy();
    this.charms.Clear();
    this.gameObject.SetActive(false);
  }
}
