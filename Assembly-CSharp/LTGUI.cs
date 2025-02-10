// Decompiled with JetBrains decompiler
// Type: LTGUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class LTGUI
{
  public static int RECT_LEVELS = 5;
  public static int RECTS_PER_LEVEL = 10;
  public static int BUTTONS_MAX = 24;
  private static LTRect[] levels;
  private static int[] levelDepths;
  private static Rect[] buttons;
  private static int[] buttonLevels;
  private static int[] buttonLastFrame;
  private static LTRect r;
  private static Color color = Color.white;
  private static bool isGUIEnabled = false;
  private static int global_counter = 0;

  public static void init()
  {
    if (LTGUI.levels != null)
      return;
    LTGUI.levels = new LTRect[LTGUI.RECT_LEVELS * LTGUI.RECTS_PER_LEVEL];
    LTGUI.levelDepths = new int[LTGUI.RECT_LEVELS];
  }

  public static void initRectCheck()
  {
    if (LTGUI.buttons != null)
      return;
    LTGUI.buttons = new Rect[LTGUI.BUTTONS_MAX];
    LTGUI.buttonLevels = new int[LTGUI.BUTTONS_MAX];
    LTGUI.buttonLastFrame = new int[LTGUI.BUTTONS_MAX];
    for (int index = 0; index < LTGUI.buttonLevels.Length; ++index)
      LTGUI.buttonLevels[index] = -1;
  }

  public static void reset()
  {
    if (!LTGUI.isGUIEnabled)
      return;
    LTGUI.isGUIEnabled = false;
    for (int index = 0; index < LTGUI.levels.Length; ++index)
      LTGUI.levels[index] = (LTRect) null;
    for (int index = 0; index < LTGUI.levelDepths.Length; ++index)
      LTGUI.levelDepths[index] = 0;
  }

  public static void update(int updateLevel)
  {
    if (!LTGUI.isGUIEnabled)
      return;
    LTGUI.init();
    if (LTGUI.levelDepths[updateLevel] <= 0)
      return;
    LTGUI.color = GUI.color;
    int num1 = updateLevel * LTGUI.RECTS_PER_LEVEL;
    int num2 = num1 + LTGUI.levelDepths[updateLevel];
    for (int index = num1; index < num2; ++index)
    {
      LTGUI.r = LTGUI.levels[index];
      if (LTGUI.r != null)
      {
        if (LTGUI.r.useColor)
          GUI.color = LTGUI.r.color;
        Rect rect;
        if (LTGUI.r.type == LTGUI.Element_Type.Label)
        {
          if (LTGUI.r.style != null)
            GUI.skin.label = LTGUI.r.style;
          if (LTGUI.r.useSimpleScale)
          {
            rect = LTGUI.r.rect;
            double x = ((double) rect.x + (double) LTGUI.r.margin.x + (double) LTGUI.r.relativeRect.x) * (double) LTGUI.r.relativeRect.width;
            rect = LTGUI.r.rect;
            double y = ((double) rect.y + (double) LTGUI.r.margin.y + (double) LTGUI.r.relativeRect.y) * (double) LTGUI.r.relativeRect.height;
            rect = LTGUI.r.rect;
            double width = (double) rect.width * (double) LTGUI.r.relativeRect.width;
            rect = LTGUI.r.rect;
            double height = (double) rect.height * (double) LTGUI.r.relativeRect.height;
            GUI.Label(new Rect((float) x, (float) y, (float) width, (float) height), LTGUI.r.labelStr);
          }
          else
          {
            rect = LTGUI.r.rect;
            double x = (double) rect.x + (double) LTGUI.r.margin.x;
            rect = LTGUI.r.rect;
            double y = (double) rect.y + (double) LTGUI.r.margin.y;
            rect = LTGUI.r.rect;
            double width = (double) rect.width;
            rect = LTGUI.r.rect;
            double height = (double) rect.height;
            GUI.Label(new Rect((float) x, (float) y, (float) width, (float) height), LTGUI.r.labelStr);
          }
        }
        else if (LTGUI.r.type == LTGUI.Element_Type.Texture && (Object) LTGUI.r.texture != (Object) null)
        {
          Vector2 vector2_1;
          if (!LTGUI.r.useSimpleScale)
          {
            rect = LTGUI.r.rect;
            double width = (double) rect.width;
            rect = LTGUI.r.rect;
            double height = (double) rect.height;
            vector2_1 = new Vector2((float) width, (float) height);
          }
          else
          {
            rect = LTGUI.r.rect;
            vector2_1 = new Vector2(0.0f, (float) ((double) rect.height * (double) LTGUI.r.relativeRect.height));
          }
          Vector2 vector2_2 = vector2_1;
          if (LTGUI.r.sizeByHeight)
            vector2_2.x = (float) LTGUI.r.texture.width / (float) LTGUI.r.texture.height * vector2_2.y;
          if (LTGUI.r.useSimpleScale)
          {
            rect = LTGUI.r.rect;
            double x1 = ((double) rect.x + (double) LTGUI.r.margin.x + (double) LTGUI.r.relativeRect.x) * (double) LTGUI.r.relativeRect.width;
            rect = LTGUI.r.rect;
            double y1 = ((double) rect.y + (double) LTGUI.r.margin.y + (double) LTGUI.r.relativeRect.y) * (double) LTGUI.r.relativeRect.height;
            double x2 = (double) vector2_2.x;
            double y2 = (double) vector2_2.y;
            GUI.DrawTexture(new Rect((float) x1, (float) y1, (float) x2, (float) y2), LTGUI.r.texture);
          }
          else
          {
            rect = LTGUI.r.rect;
            double x3 = (double) rect.x + (double) LTGUI.r.margin.x;
            rect = LTGUI.r.rect;
            double y3 = (double) rect.y + (double) LTGUI.r.margin.y;
            double x4 = (double) vector2_2.x;
            double y4 = (double) vector2_2.y;
            GUI.DrawTexture(new Rect((float) x3, (float) y3, (float) x4, (float) y4), LTGUI.r.texture);
          }
        }
      }
    }
    GUI.color = LTGUI.color;
  }

  public static bool checkOnScreen(Rect rect)
  {
    int num1 = (double) rect.x + (double) rect.width < 0.0 ? 1 : 0;
    bool flag1 = (double) rect.x > (double) Screen.width;
    bool flag2 = (double) rect.y > (double) Screen.height;
    bool flag3 = (double) rect.y + (double) rect.height < 0.0;
    int num2 = flag1 ? 1 : 0;
    return (num1 | num2 | (flag2 ? 1 : 0) | (flag3 ? 1 : 0)) == 0;
  }

  public static void destroy(int id)
  {
    int index = id & (int) ushort.MaxValue;
    int num = id >> 16;
    if (id < 0 || LTGUI.levels[index] == null || !LTGUI.levels[index].hasInitiliazed || LTGUI.levels[index].counter != num)
      return;
    LTGUI.levels[index] = (LTRect) null;
  }

  public static void destroyAll(int depth)
  {
    int num = depth * LTGUI.RECTS_PER_LEVEL + LTGUI.RECTS_PER_LEVEL;
    for (int index = depth * LTGUI.RECTS_PER_LEVEL; LTGUI.levels != null && index < num; ++index)
      LTGUI.levels[index] = (LTRect) null;
  }

  public static LTRect label(Rect rect, string label, int depth) => LTGUI.label(new LTRect(rect), label, depth);

  public static LTRect label(LTRect rect, string label, int depth)
  {
    rect.type = LTGUI.Element_Type.Label;
    rect.labelStr = label;
    return LTGUI.element(rect, depth);
  }

  public static LTRect texture(Rect rect, Texture texture, int depth) => LTGUI.texture(new LTRect(rect), texture, depth);

  public static LTRect texture(LTRect rect, Texture texture, int depth)
  {
    rect.type = LTGUI.Element_Type.Texture;
    rect.texture = texture;
    return LTGUI.element(rect, depth);
  }

  public static LTRect element(LTRect rect, int depth)
  {
    LTGUI.isGUIEnabled = true;
    LTGUI.init();
    int num1 = depth * LTGUI.RECTS_PER_LEVEL + LTGUI.RECTS_PER_LEVEL;
    int num2 = 0;
    if (rect != null)
      LTGUI.destroy(rect.id);
    if (rect.type == LTGUI.Element_Type.Label && rect.style != null && (double) rect.style.normal.textColor.a <= 0.0)
      Debug.LogWarning((object) "Your GUI normal color has an alpha of zero, and will not be rendered.");
    if ((double) rect.relativeRect.width == double.PositiveInfinity)
      rect.relativeRect = new Rect(0.0f, 0.0f, (float) Screen.width, (float) Screen.height);
    for (int id = depth * LTGUI.RECTS_PER_LEVEL; id < num1; ++id)
    {
      LTGUI.r = LTGUI.levels[id];
      if (LTGUI.r == null)
      {
        LTGUI.r = rect;
        LTGUI.r.rotateEnabled = true;
        LTGUI.r.alphaEnabled = true;
        LTGUI.r.setId(id, LTGUI.global_counter);
        LTGUI.levels[id] = LTGUI.r;
        if (num2 >= LTGUI.levelDepths[depth])
          LTGUI.levelDepths[depth] = num2 + 1;
        ++LTGUI.global_counter;
        return LTGUI.r;
      }
      ++num2;
    }
    Debug.LogError((object) "You ran out of GUI Element spaces");
    return (LTRect) null;
  }

  public static bool hasNoOverlap(Rect rect, int depth)
  {
    LTGUI.initRectCheck();
    bool flag1 = true;
    bool flag2 = false;
    for (int index = 0; index < LTGUI.buttonLevels.Length; ++index)
    {
      if (LTGUI.buttonLevels[index] >= 0)
      {
        if (LTGUI.buttonLastFrame[index] + 1 < Time.frameCount)
          LTGUI.buttonLevels[index] = -1;
        else if (LTGUI.buttonLevels[index] > depth && LTGUI.pressedWithinRect(LTGUI.buttons[index]))
          flag1 = false;
      }
      if (!flag2 && LTGUI.buttonLevels[index] < 0)
      {
        flag2 = true;
        LTGUI.buttonLevels[index] = depth;
        LTGUI.buttons[index] = rect;
        LTGUI.buttonLastFrame[index] = Time.frameCount;
      }
    }
    return flag1;
  }

  public static bool pressedWithinRect(Rect rect)
  {
    Vector2 vector2 = LTGUI.firstTouch();
    if ((double) vector2.x < 0.0)
      return false;
    float num = (float) Screen.height - vector2.y;
    return (double) vector2.x > (double) rect.x && (double) vector2.x < (double) rect.x + (double) rect.width && (double) num > (double) rect.y && (double) num < (double) rect.y + (double) rect.height;
  }

  public static bool checkWithinRect(Vector2 vec2, Rect rect)
  {
    vec2.y = (float) Screen.height - vec2.y;
    return (double) vec2.x > (double) rect.x && (double) vec2.x < (double) rect.x + (double) rect.width && (double) vec2.y > (double) rect.y && (double) vec2.y < (double) rect.y + (double) rect.height;
  }

  public static Vector2 firstTouch()
  {
    if (Input.touchCount > 0)
      return Input.touches[0].position;
    return Input.GetMouseButton(0) ? (Vector2) Input.mousePosition : new Vector2(float.NegativeInfinity, float.NegativeInfinity);
  }

  public enum Element_Type
  {
    Texture,
    Label,
  }
}
