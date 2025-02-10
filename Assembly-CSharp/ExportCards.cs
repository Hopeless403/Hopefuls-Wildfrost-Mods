// Decompiled with JetBrains decompiler
// Type: ExportCards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.IO;
using UnityEngine;

public class ExportCards : MonoBehaviour
{
  [SerializeField]
  private string folder = nameof (ExportCards);
  private Camera _camera;

  private Camera camera => this._camera ?? (this._camera = Camera.main);

  private IEnumerator Start()
  {
    ExportCards exportCards = this;
    yield return (object) new WaitUntil((Func<bool>) (() => CardManager.init));
    foreach (CardData cardData1 in AddressableLoader.GetGroup<CardData>("CardData"))
    {
      CardData cardData = cardData1;
      if (!((UnityEngine.Object) cardData.mainSprite == (UnityEngine.Object) null) && !(cardData.mainSprite.name == "Nothing"))
      {
        Card card = CardManager.Get(cardData, (CardController) null, (Character) null, false, false);
        yield return (object) card.UpdateData(false);
        card.transform.position = Vector3.zero;
        yield return (object) null;
        exportCards.Screenshot(Application.dataPath + "/../" + exportCards.folder + "/" + cardData.cardType.name, card.titleText.text + " (" + card.name + ").png");
        yield return (object) null;
        CardManager.ReturnToPool(card);
        card = (Card) null;
        cardData = (CardData) null;
      }
    }
  }

  private void Screenshot(string directory, string fileName)
  {
    string str = directory + "/" + fileName;
    Texture2D tex = new Texture2D(Screen.width, Screen.height, TextureFormat.ARGB32, false);
    RenderTexture renderTexture = new RenderTexture(tex.width, tex.height, 24);
    this.camera.targetTexture = renderTexture;
    this.camera.Render();
    RenderTexture.active = renderTexture;
    tex.ReadPixels(new Rect(0.0f, 0.0f, (float) tex.width, (float) tex.height), 0, 0);
    tex.Apply();
    byte[] png = tex.EncodeToPNG();
    System.IO.Directory.CreateDirectory(directory);
    File.WriteAllBytes(str, png);
    Debug.Log((object) str);
  }
}
