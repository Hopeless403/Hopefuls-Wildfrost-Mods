// Decompiled with JetBrains decompiler
// Type: ConsoleArgsDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class ConsoleArgsDisplay : MonoBehaviourRect
{
  [SerializeField]
  public TMP_Text textPrefab;
  [SerializeField]
  public int poolStartSize = 20;
  [SerializeField]
  public int maxItems = 30;
  public Queue<TMP_Text> pool = new Queue<TMP_Text>();
  public List<TMP_Text> outOfPool = new List<TMP_Text>();
  public Console.Command[] commands;
  public string[] current;
  public Vector2 targetPos;

  public int Count => this.current.Length;

  public string TopArgument => ((IEnumerable<string>) this.current).Last<string>();

  public string TopCommand => ((IEnumerable<Console.Command>) this.commands).Last<Console.Command>().id + (((IEnumerable<Console.Command>) this.commands).Last<Console.Command>().format != ((IEnumerable<Console.Command>) this.commands).Last<Console.Command>().id ? " " : "");

  public void Awake()
  {
    this.targetPos = this.rectTransform.anchoredPosition;
    for (int index = 0; index < this.poolStartSize; ++index)
      this.pool.Enqueue(UnityEngine.Object.Instantiate<TMP_Text>(this.textPrefab, this.transform));
  }

  public void Update() => this.rectTransform.anchoredPosition = Delta.Lerp(this.rectTransform.anchoredPosition, this.targetPos, 0.1f, Time.deltaTime);

  public void Show() => this.gameObject.SetActive(true);

  public void Hide() => this.gameObject.SetActive(false);

  public void MoveTo(float x) => this.targetPos = this.targetPos.WithX(x);

  public void DisplayCommands(Console.Command[] commands)
  {
    string[] array = ((IEnumerable<Console.Command>) commands).Select<Console.Command, string>((Func<Console.Command, string>) (a => a.format)).ToArray<string>();
    if (this.current != null && ((IEnumerable<string>) array).SequenceEqual<string>((IEnumerable<string>) this.current))
      return;
    this.Create(array);
    this.current = array;
    this.commands = commands;
  }

  public void DisplayArgs(string[] items)
  {
    if (this.current != null && ((IEnumerable<string>) items).SequenceEqual<string>((IEnumerable<string>) this.current))
      return;
    this.Create(items);
    this.current = items;
  }

  public void Clear()
  {
    foreach (TMP_Text inst in this.outOfPool)
      this.Pool(inst);
    this.outOfPool.Clear();
  }

  public void Create(string[] items)
  {
    this.Clear();
    int index = items.Length - 1;
    while (index >= 0 && this.Create(items[index]))
      --index;
  }

  public bool Create(string item)
  {
    bool flag = false;
    if (this.outOfPool.Count < this.maxItems + 1)
    {
      TMP_Text tmpText = this.pool.Count > 0 ? this.pool.Dequeue() : UnityEngine.Object.Instantiate<TMP_Text>(this.textPrefab, this.transform);
      if (this.outOfPool.Count < this.maxItems)
      {
        tmpText.text = item;
        tmpText.transform.SetAsLastSibling();
        flag = true;
      }
      else
      {
        tmpText.text = "...";
        tmpText.transform.SetAsLastSibling();
      }
      tmpText.gameObject.SetActive(true);
      this.outOfPool.Add(tmpText);
    }
    return flag;
  }

  public void Pool(TMP_Text inst)
  {
    this.pool.Enqueue(inst);
    inst.gameObject.SetActive(false);
  }
}
