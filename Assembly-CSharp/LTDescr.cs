// Decompiled with JetBrains decompiler
// Type: LTDescr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.UI;

public class LTDescr
{
  public bool toggle;
  public bool useEstimatedTime;
  public bool useFrames;
  public bool useManualTime;
  public bool usesNormalDt;
  public bool hasInitiliazed;
  public bool hasExtraOnCompletes;
  public bool hasPhysics;
  public bool onCompleteOnRepeat;
  public bool onCompleteOnStart;
  public bool useRecursion;
  public float ratioPassed;
  public float passed;
  public float delay;
  public float time;
  public float speed;
  public float lastVal;
  private uint _id;
  public int loopCount;
  public uint counter = uint.MaxValue;
  public float direction;
  public float directionLast;
  public float overshoot;
  public float period;
  public float scale;
  public bool destroyOnComplete;
  public Transform trans;
  internal Vector3 fromInternal;
  internal Vector3 toInternal;
  internal Vector3 diff;
  internal Vector3 diffDiv2;
  public TweenAction type;
  private LeanTweenType easeType;
  public LeanTweenType loopType;
  public bool hasUpdateCallback;
  public LTDescr.EaseTypeDelegate easeMethod;
  public SpriteRenderer spriteRen;
  public RectTransform rectTransform;
  public UnityEngine.UI.Text uiText;
  public Image uiImage;
  public RawImage rawImage;
  public Sprite[] sprites;
  public LTDescrOptional _optional = new LTDescrOptional();
  public static float val;
  public static float dt;
  public static Vector3 newVect;

  public Vector3 from
  {
    get => this.fromInternal;
    set => this.fromInternal = value;
  }

  public Vector3 to
  {
    get => this.toInternal;
    set => this.toInternal = value;
  }

  public LTDescr.ActionMethodDelegate easeInternal { get; set; }

  public LTDescr.ActionMethodDelegate initInternal { get; set; }

  public Transform toTrans => this.optional.toTrans;

  public override string ToString() => ((UnityEngine.Object) this.trans != (UnityEngine.Object) null ? "name:" + this.trans.gameObject.name : "gameObject:null") + " toggle:" + this.toggle.ToString() + " passed:" + this.passed.ToString() + " time:" + this.time.ToString() + " delay:" + this.delay.ToString() + " direction:" + this.direction.ToString() + " from:" + this.from.ToString() + " to:" + this.to.ToString() + " diff:" + this.diff.ToString() + " type:" + this.type.ToString() + " ease:" + this.easeType.ToString() + " useEstimatedTime:" + this.useEstimatedTime.ToString() + " id:" + this.id.ToString() + " hasInitiliazed:" + this.hasInitiliazed.ToString();

  [Obsolete("Use 'LeanTween.cancel( id )' instead")]
  public LTDescr cancel(GameObject gameObject)
  {
    if ((UnityEngine.Object) gameObject == (UnityEngine.Object) this.trans.gameObject)
      LeanTween.removeTween((int) this._id, this.uniqueId);
    return this;
  }

  public int uniqueId => (int) this._id | (int) this.counter << 16;

  public int id => this.uniqueId;

  public LTDescrOptional optional
  {
    get => this._optional;
    set => this._optional = value;
  }

  public void reset()
  {
    this.toggle = this.useRecursion = this.usesNormalDt = true;
    this.trans = (Transform) null;
    this.spriteRen = (SpriteRenderer) null;
    this.passed = this.delay = this.lastVal = 0.0f;
    this.hasUpdateCallback = this.useEstimatedTime = this.useFrames = this.hasInitiliazed = this.onCompleteOnRepeat = this.destroyOnComplete = this.onCompleteOnStart = this.useManualTime = this.hasExtraOnCompletes = false;
    this.easeType = LeanTweenType.linear;
    this.loopType = LeanTweenType.once;
    this.loopCount = 0;
    this.direction = this.directionLast = this.overshoot = this.scale = 1f;
    this.period = 0.3f;
    this.speed = -1f;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeLinear);
    this.from = this.to = Vector3.zero;
    this._optional.reset();
  }

  public LTDescr setFollow()
  {
    this.type = TweenAction.FOLLOW;
    return this;
  }

  public LTDescr setMoveX()
  {
    this.type = TweenAction.MOVE_X;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.position.x);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.position = new Vector3(this.easeMethod().x, this.trans.position.y, this.trans.position.z));
    return this;
  }

  public LTDescr setMoveY()
  {
    this.type = TweenAction.MOVE_Y;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.position.y);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.position = new Vector3(this.trans.position.x, this.easeMethod().x, this.trans.position.z));
    return this;
  }

  public LTDescr setMoveZ()
  {
    this.type = TweenAction.MOVE_Z;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.position.z);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.position = new Vector3(this.trans.position.x, this.trans.position.y, this.easeMethod().x));
    return this;
  }

  public LTDescr setMoveLocalX()
  {
    this.type = TweenAction.MOVE_LOCAL_X;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.localPosition.x);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.localPosition = new Vector3(this.easeMethod().x, this.trans.localPosition.y, this.trans.localPosition.z));
    return this;
  }

  public LTDescr setMoveLocalY()
  {
    this.type = TweenAction.MOVE_LOCAL_Y;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.localPosition.y);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.localPosition = new Vector3(this.trans.localPosition.x, this.easeMethod().x, this.trans.localPosition.z));
    return this;
  }

  public LTDescr setMoveLocalZ()
  {
    this.type = TweenAction.MOVE_LOCAL_Z;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.localPosition.z);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.localPosition = new Vector3(this.trans.localPosition.x, this.trans.localPosition.y, this.easeMethod().x));
    return this;
  }

  private void initFromInternal() => this.fromInternal.x = 0.0f;

  public LTDescr setOffset(Vector3 offset)
  {
    this.toInternal = offset;
    return this;
  }

  public LTDescr setMoveCurved()
  {
    this.type = TweenAction.MOVE_CURVED;
    this.initInternal = new LTDescr.ActionMethodDelegate(this.initFromInternal);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      if (this._optional.path.orientToPath)
      {
        if (this._optional.path.orientToPath2d)
          this._optional.path.place2d(this.trans, LTDescr.val);
        else
          this._optional.path.place(this.trans, LTDescr.val);
      }
      else
        this.trans.position = this._optional.path.point(LTDescr.val);
    });
    return this;
  }

  public LTDescr setMoveCurvedLocal()
  {
    this.type = TweenAction.MOVE_CURVED_LOCAL;
    this.initInternal = new LTDescr.ActionMethodDelegate(this.initFromInternal);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      if (this._optional.path.orientToPath)
      {
        if (this._optional.path.orientToPath2d)
          this._optional.path.placeLocal2d(this.trans, LTDescr.val);
        else
          this._optional.path.placeLocal(this.trans, LTDescr.val);
      }
      else
        this.trans.localPosition = this._optional.path.point(LTDescr.val);
    });
    return this;
  }

  public LTDescr setMoveSpline()
  {
    this.type = TweenAction.MOVE_SPLINE;
    this.initInternal = new LTDescr.ActionMethodDelegate(this.initFromInternal);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      if (this._optional.spline.orientToPath)
      {
        if (this._optional.spline.orientToPath2d)
          this._optional.spline.place2d(this.trans, LTDescr.val);
        else
          this._optional.spline.place(this.trans, LTDescr.val);
      }
      else
        this.trans.position = this._optional.spline.point(LTDescr.val);
    });
    return this;
  }

  public LTDescr setMoveSplineLocal()
  {
    this.type = TweenAction.MOVE_SPLINE_LOCAL;
    this.initInternal = new LTDescr.ActionMethodDelegate(this.initFromInternal);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      if (this._optional.spline.orientToPath)
      {
        if (this._optional.spline.orientToPath2d)
          this._optional.spline.placeLocal2d(this.trans, LTDescr.val);
        else
          this._optional.spline.placeLocal(this.trans, LTDescr.val);
      }
      else
        this.trans.localPosition = this._optional.spline.point(LTDescr.val);
    });
    return this;
  }

  public LTDescr setScaleX()
  {
    this.type = TweenAction.SCALE_X;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.localScale.x);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.localScale = new Vector3(this.easeMethod().x, this.trans.localScale.y, this.trans.localScale.z));
    return this;
  }

  public LTDescr setScaleY()
  {
    this.type = TweenAction.SCALE_Y;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.localScale.y);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.localScale = new Vector3(this.trans.localScale.x, this.easeMethod().x, this.trans.localScale.z));
    return this;
  }

  public LTDescr setScaleZ()
  {
    this.type = TweenAction.SCALE_Z;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.localScale.z);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.localScale = new Vector3(this.trans.localScale.x, this.trans.localScale.y, this.easeMethod().x));
    return this;
  }

  public LTDescr setRotateX()
  {
    this.type = TweenAction.ROTATE_X;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.fromInternal.x = this.trans.eulerAngles.x;
      this.toInternal.x = LeanTween.closestRot(this.fromInternal.x, this.toInternal.x);
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.eulerAngles = new Vector3(this.easeMethod().x, this.trans.eulerAngles.y, this.trans.eulerAngles.z));
    return this;
  }

  public LTDescr setRotateY()
  {
    this.type = TweenAction.ROTATE_Y;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.fromInternal.x = this.trans.eulerAngles.y;
      this.toInternal.x = LeanTween.closestRot(this.fromInternal.x, this.toInternal.x);
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.eulerAngles = new Vector3(this.trans.eulerAngles.x, this.easeMethod().x, this.trans.eulerAngles.z));
    return this;
  }

  public LTDescr setRotateZ()
  {
    this.type = TweenAction.ROTATE_Z;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.fromInternal.x = this.trans.eulerAngles.z;
      this.toInternal.x = LeanTween.closestRot(this.fromInternal.x, this.toInternal.x);
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.eulerAngles = new Vector3(this.trans.eulerAngles.x, this.trans.eulerAngles.y, this.easeMethod().x));
    return this;
  }

  public LTDescr setRotateAround()
  {
    this.type = TweenAction.ROTATE_AROUND;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.fromInternal.x = 0.0f;
      this._optional.origRotation = this.trans.rotation;
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      Vector3 localPosition = this.trans.localPosition;
      this.trans.RotateAround(this.trans.TransformPoint(this._optional.point), this._optional.axis, -this._optional.lastVal);
      Vector3 vector3 = localPosition - this.trans.localPosition;
      this.trans.localPosition = localPosition - vector3;
      this.trans.rotation = this._optional.origRotation;
      this.trans.RotateAround(this.trans.TransformPoint(this._optional.point), this._optional.axis, LTDescr.val);
      this._optional.lastVal = LTDescr.val;
    });
    return this;
  }

  public LTDescr setRotateAroundLocal()
  {
    this.type = TweenAction.ROTATE_AROUND_LOCAL;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.fromInternal.x = 0.0f;
      this._optional.origRotation = this.trans.localRotation;
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      Vector3 localPosition = this.trans.localPosition;
      this.trans.RotateAround(this.trans.TransformPoint(this._optional.point), this.trans.TransformDirection(this._optional.axis), -this._optional.lastVal);
      Vector3 vector3 = localPosition - this.trans.localPosition;
      this.trans.localPosition = localPosition - vector3;
      this.trans.localRotation = this._optional.origRotation;
      this.trans.RotateAround(this.trans.TransformPoint(this._optional.point), this.trans.TransformDirection(this._optional.axis), LTDescr.val);
      this._optional.lastVal = LTDescr.val;
    });
    return this;
  }

  public LTDescr setAlpha()
  {
    this.type = TweenAction.ALPHA;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      SpriteRenderer component = this.trans.GetComponent<SpriteRenderer>();
      if ((UnityEngine.Object) component != (UnityEngine.Object) null)
        this.fromInternal.x = component.color.a;
      else if ((UnityEngine.Object) this.trans.GetComponent<Renderer>() != (UnityEngine.Object) null && this.trans.GetComponent<Renderer>().material.HasProperty("_Color"))
        this.fromInternal.x = this.trans.GetComponent<Renderer>().material.color.a;
      else if ((UnityEngine.Object) this.trans.GetComponent<Renderer>() != (UnityEngine.Object) null && this.trans.GetComponent<Renderer>().material.HasProperty("_TintColor"))
        this.fromInternal.x = this.trans.GetComponent<Renderer>().material.GetColor("_TintColor").a;
      else if (this.trans.childCount > 0)
      {
        foreach (Transform tran in this.trans)
        {
          if ((UnityEngine.Object) tran.gameObject.GetComponent<Renderer>() != (UnityEngine.Object) null)
          {
            this.fromInternal.x = tran.gameObject.GetComponent<Renderer>().material.color.a;
            break;
          }
        }
      }
      this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
      {
        LTDescr.val = this.easeMethod().x;
        if ((UnityEngine.Object) this.spriteRen != (UnityEngine.Object) null)
        {
          this.spriteRen.color = new Color(this.spriteRen.color.r, this.spriteRen.color.g, this.spriteRen.color.b, LTDescr.val);
          LTDescr.alphaRecursiveSprite(this.trans, LTDescr.val);
        }
        else
          LTDescr.alphaRecursive(this.trans, LTDescr.val, this.useRecursion);
      });
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      if ((UnityEngine.Object) this.spriteRen != (UnityEngine.Object) null)
      {
        this.spriteRen.color = new Color(this.spriteRen.color.r, this.spriteRen.color.g, this.spriteRen.color.b, LTDescr.val);
        LTDescr.alphaRecursiveSprite(this.trans, LTDescr.val);
      }
      else
        LTDescr.alphaRecursive(this.trans, LTDescr.val, this.useRecursion);
    });
    return this;
  }

  public LTDescr setTextAlpha()
  {
    this.type = TweenAction.TEXT_ALPHA;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.uiText = this.trans.GetComponent<UnityEngine.UI.Text>();
      this.fromInternal.x = (UnityEngine.Object) this.uiText != (UnityEngine.Object) null ? this.uiText.color.a : 1f;
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => LTDescr.textAlphaRecursive(this.trans, this.easeMethod().x, this.useRecursion));
    return this;
  }

  public LTDescr setAlphaVertex()
  {
    this.type = TweenAction.ALPHA_VERTEX;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = (float) this.trans.GetComponent<MeshFilter>().mesh.colors32[0].a);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      Mesh mesh = this.trans.GetComponent<MeshFilter>().mesh;
      Vector3[] vertices = mesh.vertices;
      Color32[] color32Array = new Color32[vertices.Length];
      if (color32Array.Length == 0)
      {
        Color32 color32 = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, (byte) 0);
        color32Array = new Color32[mesh.vertices.Length];
        for (int index = 0; index < color32Array.Length; ++index)
          color32Array[index] = color32;
        mesh.colors32 = color32Array;
      }
      Color32 color32_1 = mesh.colors32[0];
      Color32 color32_2 = (Color32) new Color((float) color32_1.r, (float) color32_1.g, (float) color32_1.b, LTDescr.val);
      for (int index = 0; index < vertices.Length; ++index)
        color32Array[index] = color32_2;
      mesh.colors32 = color32Array;
    });
    return this;
  }

  public LTDescr setColor()
  {
    this.type = TweenAction.COLOR;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      SpriteRenderer component = this.trans.GetComponent<SpriteRenderer>();
      if ((UnityEngine.Object) component != (UnityEngine.Object) null)
        this.setFromColor(component.color);
      else if ((UnityEngine.Object) this.trans.GetComponent<Renderer>() != (UnityEngine.Object) null && this.trans.GetComponent<Renderer>().material.HasProperty("_Color"))
        this.setFromColor(this.trans.GetComponent<Renderer>().material.color);
      else if ((UnityEngine.Object) this.trans.GetComponent<Renderer>() != (UnityEngine.Object) null && this.trans.GetComponent<Renderer>().material.HasProperty("_TintColor"))
      {
        this.setFromColor(this.trans.GetComponent<Renderer>().material.GetColor("_TintColor"));
      }
      else
      {
        if (this.trans.childCount <= 0)
          return;
        foreach (Transform tran in this.trans)
        {
          if ((UnityEngine.Object) tran.gameObject.GetComponent<Renderer>() != (UnityEngine.Object) null)
          {
            this.setFromColor(tran.gameObject.GetComponent<Renderer>().material.color);
            break;
          }
        }
      }
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      Color toColor = LTDescr.tweenColor(this, LTDescr.val);
      if ((UnityEngine.Object) this.spriteRen != (UnityEngine.Object) null)
      {
        this.spriteRen.color = toColor;
        LTDescr.colorRecursiveSprite(this.trans, toColor);
      }
      else if (this.type == TweenAction.COLOR)
        LTDescr.colorRecursive(this.trans, toColor, this.useRecursion);
      if ((double) LTDescr.dt != 0.0 && this._optional.onUpdateColor != null)
      {
        this._optional.onUpdateColor(toColor);
      }
      else
      {
        if ((double) LTDescr.dt == 0.0 || this._optional.onUpdateColorObject == null)
          return;
        this._optional.onUpdateColorObject(toColor, this._optional.onUpdateParam);
      }
    });
    return this;
  }

  public LTDescr setCallbackColor()
  {
    this.type = TweenAction.CALLBACK_COLOR;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.diff = new Vector3(1f, 0.0f, 0.0f));
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      Color toColor = LTDescr.tweenColor(this, LTDescr.val);
      if ((UnityEngine.Object) this.spriteRen != (UnityEngine.Object) null)
      {
        this.spriteRen.color = toColor;
        LTDescr.colorRecursiveSprite(this.trans, toColor);
      }
      else if (this.type == TweenAction.COLOR)
        LTDescr.colorRecursive(this.trans, toColor, this.useRecursion);
      if ((double) LTDescr.dt != 0.0 && this._optional.onUpdateColor != null)
      {
        this._optional.onUpdateColor(toColor);
      }
      else
      {
        if ((double) LTDescr.dt == 0.0 || this._optional.onUpdateColorObject == null)
          return;
        this._optional.onUpdateColorObject(toColor, this._optional.onUpdateParam);
      }
    });
    return this;
  }

  public LTDescr setTextColor()
  {
    this.type = TweenAction.TEXT_COLOR;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.uiText = this.trans.GetComponent<UnityEngine.UI.Text>();
      this.setFromColor((UnityEngine.Object) this.uiText != (UnityEngine.Object) null ? this.uiText.color : Color.white);
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      Color toColor = LTDescr.tweenColor(this, LTDescr.val);
      this.uiText.color = toColor;
      if ((double) LTDescr.dt != 0.0 && this._optional.onUpdateColor != null)
        this._optional.onUpdateColor(toColor);
      if (!this.useRecursion || this.trans.childCount <= 0)
        return;
      LTDescr.textColorRecursive(this.trans, toColor);
    });
    return this;
  }

  public LTDescr setCanvasAlpha()
  {
    this.type = TweenAction.CANVAS_ALPHA;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.uiImage = this.trans.GetComponent<Image>();
      if ((UnityEngine.Object) this.uiImage != (UnityEngine.Object) null)
      {
        this.fromInternal.x = this.uiImage.color.a;
      }
      else
      {
        this.rawImage = this.trans.GetComponent<RawImage>();
        if ((UnityEngine.Object) this.rawImage != (UnityEngine.Object) null)
          this.fromInternal.x = this.rawImage.color.a;
        else
          this.fromInternal.x = 1f;
      }
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      if ((UnityEngine.Object) this.uiImage != (UnityEngine.Object) null)
        this.uiImage.color = this.uiImage.color with
        {
          a = LTDescr.val
        };
      else if ((UnityEngine.Object) this.rawImage != (UnityEngine.Object) null)
        this.rawImage.color = this.rawImage.color with
        {
          a = LTDescr.val
        };
      if (!this.useRecursion)
        return;
      LTDescr.alphaRecursive(this.rectTransform, LTDescr.val, 0);
      LTDescr.textAlphaChildrenRecursive((Transform) this.rectTransform, LTDescr.val);
    });
    return this;
  }

  public LTDescr setCanvasGroupAlpha()
  {
    this.type = TweenAction.CANVASGROUP_ALPHA;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.trans.GetComponent<CanvasGroup>().alpha);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.trans.GetComponent<CanvasGroup>().alpha = this.easeMethod().x);
    return this;
  }

  public LTDescr setCanvasColor()
  {
    this.type = TweenAction.CANVAS_COLOR;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.uiImage = this.trans.GetComponent<Image>();
      if ((UnityEngine.Object) this.uiImage == (UnityEngine.Object) null)
      {
        this.rawImage = this.trans.GetComponent<RawImage>();
        this.setFromColor((UnityEngine.Object) this.rawImage != (UnityEngine.Object) null ? this.rawImage.color : Color.white);
      }
      else
        this.setFromColor(this.uiImage.color);
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      Color toColor = LTDescr.tweenColor(this, LTDescr.val);
      if ((UnityEngine.Object) this.uiImage != (UnityEngine.Object) null)
        this.uiImage.color = toColor;
      else if ((UnityEngine.Object) this.rawImage != (UnityEngine.Object) null)
        this.rawImage.color = toColor;
      if ((double) LTDescr.dt != 0.0 && this._optional.onUpdateColor != null)
        this._optional.onUpdateColor(toColor);
      if (!this.useRecursion)
        return;
      LTDescr.colorRecursive(this.rectTransform, toColor);
    });
    return this;
  }

  public LTDescr setCanvasMoveX()
  {
    this.type = TweenAction.CANVAS_MOVE_X;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.rectTransform.anchoredPosition3D.x);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      Vector3 anchoredPosition3D = this.rectTransform.anchoredPosition3D;
      this.rectTransform.anchoredPosition3D = new Vector3(this.easeMethod().x, anchoredPosition3D.y, anchoredPosition3D.z);
    });
    return this;
  }

  public LTDescr setCanvasMoveY()
  {
    this.type = TweenAction.CANVAS_MOVE_Y;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.rectTransform.anchoredPosition3D.y);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      Vector3 anchoredPosition3D = this.rectTransform.anchoredPosition3D;
      this.rectTransform.anchoredPosition3D = new Vector3(anchoredPosition3D.x, this.easeMethod().x, anchoredPosition3D.z);
    });
    return this;
  }

  public LTDescr setCanvasMoveZ()
  {
    this.type = TweenAction.CANVAS_MOVE_Z;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this.rectTransform.anchoredPosition3D.z);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      Vector3 anchoredPosition3D = this.rectTransform.anchoredPosition3D;
      this.rectTransform.anchoredPosition3D = new Vector3(anchoredPosition3D.x, anchoredPosition3D.y, this.easeMethod().x);
    });
    return this;
  }

  private void initCanvasRotateAround()
  {
    this.lastVal = 0.0f;
    this.fromInternal.x = 0.0f;
    this._optional.origRotation = this.rectTransform.rotation;
  }

  public LTDescr setCanvasRotateAround()
  {
    this.type = TweenAction.CANVAS_ROTATEAROUND;
    this.initInternal = new LTDescr.ActionMethodDelegate(this.initCanvasRotateAround);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      RectTransform rectTransform = this.rectTransform;
      Vector3 localPosition = rectTransform.localPosition;
      rectTransform.RotateAround(rectTransform.TransformPoint(this._optional.point), this._optional.axis, -LTDescr.val);
      Vector3 vector3 = localPosition - rectTransform.localPosition;
      rectTransform.localPosition = localPosition - vector3;
      rectTransform.rotation = this._optional.origRotation;
      rectTransform.RotateAround(rectTransform.TransformPoint(this._optional.point), this._optional.axis, LTDescr.val);
    });
    return this;
  }

  public LTDescr setCanvasRotateAroundLocal()
  {
    this.type = TweenAction.CANVAS_ROTATEAROUND_LOCAL;
    this.initInternal = new LTDescr.ActionMethodDelegate(this.initCanvasRotateAround);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      RectTransform rectTransform = this.rectTransform;
      Vector3 localPosition = rectTransform.localPosition;
      rectTransform.RotateAround(rectTransform.TransformPoint(this._optional.point), rectTransform.TransformDirection(this._optional.axis), -LTDescr.val);
      Vector3 vector3 = localPosition - rectTransform.localPosition;
      rectTransform.localPosition = localPosition - vector3;
      rectTransform.rotation = this._optional.origRotation;
      rectTransform.RotateAround(rectTransform.TransformPoint(this._optional.point), rectTransform.TransformDirection(this._optional.axis), LTDescr.val);
    });
    return this;
  }

  public LTDescr setCanvasPlaySprite()
  {
    this.type = TweenAction.CANVAS_PLAYSPRITE;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.uiImage = this.trans.GetComponent<Image>();
      this.fromInternal.x = 0.0f;
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      LTDescr.val = LTDescr.newVect.x;
      this.uiImage.sprite = this.sprites[(int) Mathf.Round(LTDescr.val)];
    });
    return this;
  }

  public LTDescr setCanvasMove()
  {
    this.type = TweenAction.CANVAS_MOVE;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal = this.rectTransform.anchoredPosition3D);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.rectTransform.anchoredPosition3D = this.easeMethod());
    return this;
  }

  public LTDescr setCanvasScale()
  {
    this.type = TweenAction.CANVAS_SCALE;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.from = this.rectTransform.localScale);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.rectTransform.localScale = this.easeMethod());
    return this;
  }

  public LTDescr setCanvasSizeDelta()
  {
    this.type = TweenAction.CANVAS_SIZEDELTA;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.from = (Vector3) this.rectTransform.sizeDelta);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this.rectTransform.sizeDelta = (Vector2) this.easeMethod());
    return this;
  }

  private void callback()
  {
    LTDescr.newVect = this.easeMethod();
    LTDescr.val = LTDescr.newVect.x;
  }

  public LTDescr setCallback()
  {
    this.type = TweenAction.CALLBACK;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => { });
    this.easeInternal = new LTDescr.ActionMethodDelegate(this.callback);
    return this;
  }

  public LTDescr setValue3()
  {
    this.type = TweenAction.VALUE3;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => { });
    this.easeInternal = new LTDescr.ActionMethodDelegate(this.callback);
    return this;
  }

  public LTDescr setMove()
  {
    this.type = TweenAction.MOVE;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.from = this.trans.position);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      this.trans.position = LTDescr.newVect;
    });
    return this;
  }

  public LTDescr setMoveLocal()
  {
    this.type = TweenAction.MOVE_LOCAL;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.from = this.trans.localPosition);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      this.trans.localPosition = LTDescr.newVect;
    });
    return this;
  }

  public LTDescr setMoveToTransform()
  {
    this.type = TweenAction.MOVE_TO_TRANSFORM;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.from = this.trans.position);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.to = this._optional.toTrans.position;
      this.diff = this.to - this.from;
      this.diffDiv2 = this.diff * 0.5f;
      LTDescr.newVect = this.easeMethod();
      this.trans.position = LTDescr.newVect;
    });
    return this;
  }

  public LTDescr setRotate()
  {
    this.type = TweenAction.ROTATE;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.from = this.trans.eulerAngles;
      this.to = new Vector3(LeanTween.closestRot(this.fromInternal.x, this.toInternal.x), LeanTween.closestRot(this.from.y, this.to.y), LeanTween.closestRot(this.from.z, this.to.z));
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      this.trans.eulerAngles = LTDescr.newVect;
    });
    return this;
  }

  public LTDescr setRotateLocal()
  {
    this.type = TweenAction.ROTATE_LOCAL;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      this.from = this.trans.localEulerAngles;
      this.to = new Vector3(LeanTween.closestRot(this.fromInternal.x, this.toInternal.x), LeanTween.closestRot(this.from.y, this.to.y), LeanTween.closestRot(this.from.z, this.to.z));
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      this.trans.localEulerAngles = LTDescr.newVect;
    });
    return this;
  }

  public LTDescr setScale()
  {
    this.type = TweenAction.SCALE;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.from = this.trans.localScale);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      LTDescr.newVect = this.easeMethod();
      this.trans.localScale = LTDescr.newVect;
    });
    return this;
  }

  public LTDescr setGUIMove()
  {
    this.type = TweenAction.GUI_MOVE;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      Rect rect = this._optional.ltRect.rect;
      double x = (double) rect.x;
      rect = this._optional.ltRect.rect;
      double y = (double) rect.y;
      this.from = new Vector3((float) x, (float) y, 0.0f);
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      Vector3 vector3 = this.easeMethod();
      LTRect ltRect = this._optional.ltRect;
      double x = (double) vector3.x;
      double y = (double) vector3.y;
      Rect rect1 = this._optional.ltRect.rect;
      double width = (double) rect1.width;
      rect1 = this._optional.ltRect.rect;
      double height = (double) rect1.height;
      Rect rect2 = new Rect((float) x, (float) y, (float) width, (float) height);
      ltRect.rect = rect2;
    });
    return this;
  }

  public LTDescr setGUIMoveMargin()
  {
    this.type = TweenAction.GUI_MOVE_MARGIN;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.from = (Vector3) new Vector2(this._optional.ltRect.margin.x, this._optional.ltRect.margin.y));
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      Vector3 vector3 = this.easeMethod();
      this._optional.ltRect.margin = new Vector2(vector3.x, vector3.y);
    });
    return this;
  }

  public LTDescr setGUIScale()
  {
    this.type = TweenAction.GUI_SCALE;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      Rect rect = this._optional.ltRect.rect;
      double width = (double) rect.width;
      rect = this._optional.ltRect.rect;
      double height = (double) rect.height;
      this.from = new Vector3((float) width, (float) height, 0.0f);
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      Vector3 vector3 = this.easeMethod();
      LTRect ltRect = this._optional.ltRect;
      Rect rect1 = this._optional.ltRect.rect;
      double x1 = (double) rect1.x;
      rect1 = this._optional.ltRect.rect;
      double y1 = (double) rect1.y;
      double x2 = (double) vector3.x;
      double y2 = (double) vector3.y;
      Rect rect2 = new Rect((float) x1, (float) y1, (float) x2, (float) y2);
      ltRect.rect = rect2;
    });
    return this;
  }

  public LTDescr setGUIAlpha()
  {
    this.type = TweenAction.GUI_ALPHA;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.fromInternal.x = this._optional.ltRect.alpha);
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this._optional.ltRect.alpha = this.easeMethod().x);
    return this;
  }

  public LTDescr setGUIRotate()
  {
    this.type = TweenAction.GUI_ROTATE;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() =>
    {
      if (!this._optional.ltRect.rotateEnabled)
      {
        this._optional.ltRect.rotateEnabled = true;
        this._optional.ltRect.resetForRotation();
      }
      this.fromInternal.x = this._optional.ltRect.rotation;
    });
    this.easeInternal = (LTDescr.ActionMethodDelegate) (() => this._optional.ltRect.rotation = this.easeMethod().x);
    return this;
  }

  public LTDescr setDelayedSound()
  {
    this.type = TweenAction.DELAYED_SOUND;
    this.initInternal = (LTDescr.ActionMethodDelegate) (() => this.hasExtraOnCompletes = true);
    this.easeInternal = new LTDescr.ActionMethodDelegate(this.callback);
    return this;
  }

  public LTDescr setTarget(Transform trans)
  {
    this.optional.toTrans = trans;
    return this;
  }

  private void init()
  {
    this.hasInitiliazed = true;
    this.usesNormalDt = !this.useEstimatedTime && !this.useManualTime && !this.useFrames;
    if (this.useFrames)
      this.optional.initFrameCount = Time.frameCount;
    if ((double) this.time <= 0.0)
      this.time = Mathf.Epsilon;
    if (this.initInternal != null)
      this.initInternal();
    this.diff = this.to - this.from;
    this.diffDiv2 = this.diff * 0.5f;
    if (this._optional.onStart != null)
      this._optional.onStart();
    if (this.onCompleteOnStart)
      this.callOnCompletes();
    if ((double) this.speed < 0.0)
      return;
    this.initSpeed();
  }

  private void initSpeed()
  {
    if (this.type == TweenAction.MOVE_CURVED || this.type == TweenAction.MOVE_CURVED_LOCAL)
      this.time = this._optional.path.distance / this.speed;
    else if (this.type == TweenAction.MOVE_SPLINE || this.type == TweenAction.MOVE_SPLINE_LOCAL)
      this.time = this._optional.spline.distance / this.speed;
    else
      this.time = (this.to - this.from).magnitude / this.speed;
  }

  public LTDescr updateNow()
  {
    this.updateInternal();
    return this;
  }

  public bool updateInternal()
  {
    float direction = this.direction;
    if (this.usesNormalDt)
      LTDescr.dt = LeanTween.dtActual;
    else if (this.useEstimatedTime)
      LTDescr.dt = LeanTween.dtEstimated;
    else if (this.useFrames)
    {
      LTDescr.dt = this.optional.initFrameCount == 0 ? 0.0f : 1f;
      this.optional.initFrameCount = Time.frameCount;
    }
    else if (this.useManualTime)
      LTDescr.dt = LeanTween.dtManual;
    if ((double) this.delay <= 0.0 && (double) direction != 0.0)
    {
      if ((UnityEngine.Object) this.trans == (UnityEngine.Object) null)
        return true;
      if (!this.hasInitiliazed)
        this.init();
      LTDescr.dt *= direction;
      this.passed += LTDescr.dt;
      this.passed = Mathf.Clamp(this.passed, 0.0f, this.time);
      this.ratioPassed = this.passed / this.time;
      this.easeInternal();
      if (this.hasUpdateCallback)
        this._optional.callOnUpdate(LTDescr.val, this.ratioPassed);
      if (((double) direction > 0.0 ? ((double) this.passed >= (double) this.time ? 1 : 0) : ((double) this.passed <= 0.0 ? 1 : 0)) != 0)
      {
        --this.loopCount;
        if (this.loopType == LeanTweenType.pingPong)
          this.direction = 0.0f - direction;
        else
          this.passed = Mathf.Epsilon;
        int num = this.loopCount == 0 ? 1 : (this.loopType == LeanTweenType.once ? 1 : 0);
        if (num != 0)
          return num != 0;
        if (!this.onCompleteOnRepeat)
          return num != 0;
        if (!this.hasExtraOnCompletes)
          return num != 0;
        this.callOnCompletes();
        return num != 0;
      }
    }
    else
      this.delay -= LTDescr.dt;
    return false;
  }

  public void callOnCompletes()
  {
    if (this.type == TweenAction.GUI_ROTATE)
      this._optional.ltRect.rotateFinished = true;
    if (this.type == TweenAction.DELAYED_SOUND)
      AudioSource.PlayClipAtPoint((AudioClip) this._optional.onCompleteParam, this.to, this.from.x);
    if (this._optional.onComplete != null)
    {
      this._optional.onComplete();
    }
    else
    {
      if (this._optional.onCompleteObject == null)
        return;
      this._optional.onCompleteObject(this._optional.onCompleteParam);
    }
  }

  public LTDescr setFromColor(Color col)
  {
    this.from = new Vector3(0.0f, col.a, 0.0f);
    this.diff = new Vector3(1f, 0.0f, 0.0f);
    this._optional.axis = new Vector3(col.r, col.g, col.b);
    return this;
  }

  private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
  {
    Renderer component = transform.gameObject.GetComponent<Renderer>();
    if ((UnityEngine.Object) component != (UnityEngine.Object) null)
    {
      foreach (Material material in component.materials)
      {
        if (material.HasProperty("_Color"))
          material.color = new Color(material.color.r, material.color.g, material.color.b, val);
        else if (material.HasProperty("_TintColor"))
        {
          Color color = material.GetColor("_TintColor");
          material.SetColor("_TintColor", new Color(color.r, color.g, color.b, val));
        }
      }
    }
    if (!useRecursion || transform.childCount <= 0)
      return;
    foreach (Transform transform1 in transform)
      LTDescr.alphaRecursive(transform1, val);
  }

  private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
  {
    Renderer component = transform.gameObject.GetComponent<Renderer>();
    if ((UnityEngine.Object) component != (UnityEngine.Object) null)
    {
      foreach (Material material in component.materials)
        material.color = toColor;
    }
    if (!useRecursion || transform.childCount <= 0)
      return;
    foreach (Transform transform1 in transform)
      LTDescr.colorRecursive(transform1, toColor);
  }

  private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
  {
    if (rectTransform.childCount <= 0)
      return;
    foreach (RectTransform rectTransform1 in (Transform) rectTransform)
    {
      MaskableGraphic component1 = (MaskableGraphic) rectTransform1.GetComponent<Image>();
      if ((UnityEngine.Object) component1 != (UnityEngine.Object) null)
      {
        Color color = component1.color with { a = val };
        component1.color = color;
      }
      else
      {
        MaskableGraphic component2 = (MaskableGraphic) rectTransform1.GetComponent<RawImage>();
        if ((UnityEngine.Object) component2 != (UnityEngine.Object) null)
        {
          Color color = component2.color with { a = val };
          component2.color = color;
        }
      }
      LTDescr.alphaRecursive(rectTransform1, val, recursiveLevel + 1);
    }
  }

  private static void alphaRecursiveSprite(Transform transform, float val)
  {
    if (transform.childCount <= 0)
      return;
    foreach (Transform transform1 in transform)
    {
      SpriteRenderer component = transform1.GetComponent<SpriteRenderer>();
      if ((UnityEngine.Object) component != (UnityEngine.Object) null)
        component.color = new Color(component.color.r, component.color.g, component.color.b, val);
      LTDescr.alphaRecursiveSprite(transform1, val);
    }
  }

  private static void colorRecursiveSprite(Transform transform, Color toColor)
  {
    if (transform.childCount <= 0)
      return;
    foreach (Transform transform1 in transform)
    {
      SpriteRenderer component = transform.gameObject.GetComponent<SpriteRenderer>();
      if ((UnityEngine.Object) component != (UnityEngine.Object) null)
        component.color = toColor;
      Color toColor1 = toColor;
      LTDescr.colorRecursiveSprite(transform1, toColor1);
    }
  }

  private static void colorRecursive(RectTransform rectTransform, Color toColor)
  {
    if (rectTransform.childCount <= 0)
      return;
    foreach (RectTransform rectTransform1 in (Transform) rectTransform)
    {
      MaskableGraphic component1 = (MaskableGraphic) rectTransform1.GetComponent<Image>();
      if ((UnityEngine.Object) component1 != (UnityEngine.Object) null)
      {
        component1.color = toColor;
      }
      else
      {
        MaskableGraphic component2 = (MaskableGraphic) rectTransform1.GetComponent<RawImage>();
        if ((UnityEngine.Object) component2 != (UnityEngine.Object) null)
          component2.color = toColor;
      }
      LTDescr.colorRecursive(rectTransform1, toColor);
    }
  }

  private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
  {
    if (!useRecursion || trans.childCount <= 0)
      return;
    foreach (Transform tran in trans)
    {
      UnityEngine.UI.Text component = tran.GetComponent<UnityEngine.UI.Text>();
      if ((UnityEngine.Object) component != (UnityEngine.Object) null)
      {
        Color color = component.color with { a = val };
        component.color = color;
      }
      LTDescr.textAlphaChildrenRecursive(tran, val);
    }
  }

  private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
  {
    UnityEngine.UI.Text component = trans.GetComponent<UnityEngine.UI.Text>();
    if ((UnityEngine.Object) component != (UnityEngine.Object) null)
    {
      Color color = component.color with { a = val };
      component.color = color;
    }
    if (!useRecursion || trans.childCount <= 0)
      return;
    foreach (Transform tran in trans)
      LTDescr.textAlphaRecursive(tran, val);
  }

  private static void textColorRecursive(Transform trans, Color toColor)
  {
    if (trans.childCount <= 0)
      return;
    foreach (Transform tran in trans)
    {
      UnityEngine.UI.Text component = tran.GetComponent<UnityEngine.UI.Text>();
      if ((UnityEngine.Object) component != (UnityEngine.Object) null)
        component.color = toColor;
      LTDescr.textColorRecursive(tran, toColor);
    }
  }

  private static Color tweenColor(LTDescr tween, float val)
  {
    Vector3 vector3 = tween._optional.point - tween._optional.axis;
    float num = tween.to.y - tween.from.y;
    return new Color(tween._optional.axis.x + vector3.x * val, tween._optional.axis.y + vector3.y * val, tween._optional.axis.z + vector3.z * val, tween.from.y + num * val);
  }

  public LTDescr pause()
  {
    if ((double) this.direction != 0.0)
    {
      this.directionLast = this.direction;
      this.direction = 0.0f;
    }
    return this;
  }

  public LTDescr resume()
  {
    this.direction = this.directionLast;
    return this;
  }

  public LTDescr setAxis(Vector3 axis)
  {
    this._optional.axis = axis;
    return this;
  }

  public LTDescr setDelay(float delay)
  {
    this.delay = delay;
    return this;
  }

  public LTDescr setEase(LeanTweenType easeType)
  {
    switch (easeType)
    {
      case LeanTweenType.linear:
        this.setEaseLinear();
        break;
      case LeanTweenType.easeOutQuad:
        this.setEaseOutQuad();
        break;
      case LeanTweenType.easeInQuad:
        this.setEaseInQuad();
        break;
      case LeanTweenType.easeInOutQuad:
        this.setEaseInOutQuad();
        break;
      case LeanTweenType.easeInCubic:
        this.setEaseInCubic();
        break;
      case LeanTweenType.easeOutCubic:
        this.setEaseOutCubic();
        break;
      case LeanTweenType.easeInOutCubic:
        this.setEaseInOutCubic();
        break;
      case LeanTweenType.easeInQuart:
        this.setEaseInQuart();
        break;
      case LeanTweenType.easeOutQuart:
        this.setEaseOutQuart();
        break;
      case LeanTweenType.easeInOutQuart:
        this.setEaseInOutQuart();
        break;
      case LeanTweenType.easeInQuint:
        this.setEaseInQuint();
        break;
      case LeanTweenType.easeOutQuint:
        this.setEaseOutQuint();
        break;
      case LeanTweenType.easeInOutQuint:
        this.setEaseInOutQuint();
        break;
      case LeanTweenType.easeInSine:
        this.setEaseInSine();
        break;
      case LeanTweenType.easeOutSine:
        this.setEaseOutSine();
        break;
      case LeanTweenType.easeInOutSine:
        this.setEaseInOutSine();
        break;
      case LeanTweenType.easeInExpo:
        this.setEaseInExpo();
        break;
      case LeanTweenType.easeOutExpo:
        this.setEaseOutExpo();
        break;
      case LeanTweenType.easeInOutExpo:
        this.setEaseInOutExpo();
        break;
      case LeanTweenType.easeInCirc:
        this.setEaseInCirc();
        break;
      case LeanTweenType.easeOutCirc:
        this.setEaseOutCirc();
        break;
      case LeanTweenType.easeInOutCirc:
        this.setEaseInOutCirc();
        break;
      case LeanTweenType.easeInBounce:
        this.setEaseInBounce();
        break;
      case LeanTweenType.easeOutBounce:
        this.setEaseOutBounce();
        break;
      case LeanTweenType.easeInOutBounce:
        this.setEaseInOutBounce();
        break;
      case LeanTweenType.easeInBack:
        this.setEaseInBack();
        break;
      case LeanTweenType.easeOutBack:
        this.setEaseOutBack();
        break;
      case LeanTweenType.easeInOutBack:
        this.setEaseInOutBack();
        break;
      case LeanTweenType.easeInElastic:
        this.setEaseInElastic();
        break;
      case LeanTweenType.easeOutElastic:
        this.setEaseOutElastic();
        break;
      case LeanTweenType.easeInOutElastic:
        this.setEaseInOutElastic();
        break;
      case LeanTweenType.easeSpring:
        this.setEaseSpring();
        break;
      case LeanTweenType.easeShake:
        this.setEaseShake();
        break;
      case LeanTweenType.punch:
        this.setEasePunch();
        break;
      default:
        this.setEaseLinear();
        break;
    }
    return this;
  }

  public LTDescr setEaseLinear()
  {
    this.easeType = LeanTweenType.linear;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeLinear);
    return this;
  }

  public LTDescr setEaseSpring()
  {
    this.easeType = LeanTweenType.easeSpring;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeSpring);
    return this;
  }

  public LTDescr setEaseInQuad()
  {
    this.easeType = LeanTweenType.easeInQuad;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInQuad);
    return this;
  }

  public LTDescr setEaseOutQuad()
  {
    this.easeType = LeanTweenType.easeOutQuad;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutQuad);
    return this;
  }

  public LTDescr setEaseInOutQuad()
  {
    this.easeType = LeanTweenType.easeInOutQuad;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutQuad);
    return this;
  }

  public LTDescr setEaseInCubic()
  {
    this.easeType = LeanTweenType.easeInCubic;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInCubic);
    return this;
  }

  public LTDescr setEaseOutCubic()
  {
    this.easeType = LeanTweenType.easeOutCubic;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutCubic);
    return this;
  }

  public LTDescr setEaseInOutCubic()
  {
    this.easeType = LeanTweenType.easeInOutCubic;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutCubic);
    return this;
  }

  public LTDescr setEaseInQuart()
  {
    this.easeType = LeanTweenType.easeInQuart;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInQuart);
    return this;
  }

  public LTDescr setEaseOutQuart()
  {
    this.easeType = LeanTweenType.easeOutQuart;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutQuart);
    return this;
  }

  public LTDescr setEaseInOutQuart()
  {
    this.easeType = LeanTweenType.easeInOutQuart;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutQuart);
    return this;
  }

  public LTDescr setEaseInQuint()
  {
    this.easeType = LeanTweenType.easeInQuint;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInQuint);
    return this;
  }

  public LTDescr setEaseOutQuint()
  {
    this.easeType = LeanTweenType.easeOutQuint;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutQuint);
    return this;
  }

  public LTDescr setEaseInOutQuint()
  {
    this.easeType = LeanTweenType.easeInOutQuint;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutQuint);
    return this;
  }

  public LTDescr setEaseInSine()
  {
    this.easeType = LeanTweenType.easeInSine;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInSine);
    return this;
  }

  public LTDescr setEaseOutSine()
  {
    this.easeType = LeanTweenType.easeOutSine;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutSine);
    return this;
  }

  public LTDescr setEaseInOutSine()
  {
    this.easeType = LeanTweenType.easeInOutSine;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutSine);
    return this;
  }

  public LTDescr setEaseInExpo()
  {
    this.easeType = LeanTweenType.easeInExpo;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInExpo);
    return this;
  }

  public LTDescr setEaseOutExpo()
  {
    this.easeType = LeanTweenType.easeOutExpo;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutExpo);
    return this;
  }

  public LTDescr setEaseInOutExpo()
  {
    this.easeType = LeanTweenType.easeInOutExpo;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutExpo);
    return this;
  }

  public LTDescr setEaseInCirc()
  {
    this.easeType = LeanTweenType.easeInCirc;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInCirc);
    return this;
  }

  public LTDescr setEaseOutCirc()
  {
    this.easeType = LeanTweenType.easeOutCirc;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutCirc);
    return this;
  }

  public LTDescr setEaseInOutCirc()
  {
    this.easeType = LeanTweenType.easeInOutCirc;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutCirc);
    return this;
  }

  public LTDescr setEaseInBounce()
  {
    this.easeType = LeanTweenType.easeInBounce;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInBounce);
    return this;
  }

  public LTDescr setEaseOutBounce()
  {
    this.easeType = LeanTweenType.easeOutBounce;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutBounce);
    return this;
  }

  public LTDescr setEaseInOutBounce()
  {
    this.easeType = LeanTweenType.easeInOutBounce;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutBounce);
    return this;
  }

  public LTDescr setEaseInBack()
  {
    this.easeType = LeanTweenType.easeInBack;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInBack);
    return this;
  }

  public LTDescr setEaseOutBack()
  {
    this.easeType = LeanTweenType.easeOutBack;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutBack);
    return this;
  }

  public LTDescr setEaseInOutBack()
  {
    this.easeType = LeanTweenType.easeInOutBack;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutBack);
    return this;
  }

  public LTDescr setEaseInElastic()
  {
    this.easeType = LeanTweenType.easeInElastic;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInElastic);
    return this;
  }

  public LTDescr setEaseOutElastic()
  {
    this.easeType = LeanTweenType.easeOutElastic;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeOutElastic);
    return this;
  }

  public LTDescr setEaseInOutElastic()
  {
    this.easeType = LeanTweenType.easeInOutElastic;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.easeInOutElastic);
    return this;
  }

  public LTDescr setEasePunch()
  {
    this._optional.animationCurve = LeanTween.punch;
    this.toInternal.x = this.from.x + this.to.x;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.tweenOnCurve);
    return this;
  }

  public LTDescr setEaseShake()
  {
    this._optional.animationCurve = LeanTween.shake;
    this.toInternal.x = this.from.x + this.to.x;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.tweenOnCurve);
    return this;
  }

  private Vector3 tweenOnCurve() => new Vector3(this.from.x + this.diff.x * this._optional.animationCurve.Evaluate(this.ratioPassed), this.from.y + this.diff.y * this._optional.animationCurve.Evaluate(this.ratioPassed), this.from.z + this.diff.z * this._optional.animationCurve.Evaluate(this.ratioPassed));

  private Vector3 easeInOutQuad()
  {
    LTDescr.val = this.ratioPassed * 2f;
    if ((double) LTDescr.val < 1.0)
    {
      LTDescr.val *= LTDescr.val;
      return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
    }
    LTDescr.val = (float) ((1.0 - (double) LTDescr.val) * ((double) LTDescr.val - 3.0) + 1.0);
    return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInQuad()
  {
    LTDescr.val = this.ratioPassed * this.ratioPassed;
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeOutQuad()
  {
    LTDescr.val = this.ratioPassed;
    LTDescr.val = (float) (-(double) LTDescr.val * ((double) LTDescr.val - 2.0));
    return this.diff * LTDescr.val + this.from;
  }

  private Vector3 easeLinear()
  {
    LTDescr.val = this.ratioPassed;
    return new Vector3(this.from.x + this.diff.x * LTDescr.val, this.from.y + this.diff.y * LTDescr.val, this.from.z + this.diff.z * LTDescr.val);
  }

  private Vector3 easeSpring()
  {
    LTDescr.val = Mathf.Clamp01(this.ratioPassed);
    LTDescr.val = (float) (((double) Mathf.Sin((float) ((double) LTDescr.val * 3.1415927410125732 * (0.20000000298023224 + 2.5 * (double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val))) * (double) Mathf.Pow(1f - LTDescr.val, 2.2f) + (double) LTDescr.val) * (1.0 + 1.2000000476837158 * (1.0 - (double) LTDescr.val)));
    return this.from + this.diff * LTDescr.val;
  }

  private Vector3 easeInCubic()
  {
    LTDescr.val = this.ratioPassed * this.ratioPassed * this.ratioPassed;
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeOutCubic()
  {
    LTDescr.val = this.ratioPassed - 1f;
    LTDescr.val = (float) ((double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val + 1.0);
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInOutCubic()
  {
    LTDescr.val = this.ratioPassed * 2f;
    if ((double) LTDescr.val < 1.0)
    {
      LTDescr.val = LTDescr.val * LTDescr.val * LTDescr.val;
      return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
    }
    LTDescr.val -= 2f;
    LTDescr.val = (float) ((double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val + 2.0);
    return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInQuart()
  {
    LTDescr.val = this.ratioPassed * this.ratioPassed * this.ratioPassed * this.ratioPassed;
    return this.diff * LTDescr.val + this.from;
  }

  private Vector3 easeOutQuart()
  {
    LTDescr.val = this.ratioPassed - 1f;
    LTDescr.val = (float) -((double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val - 1.0);
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInOutQuart()
  {
    LTDescr.val = this.ratioPassed * 2f;
    if ((double) LTDescr.val < 1.0)
    {
      LTDescr.val = LTDescr.val * LTDescr.val * LTDescr.val * LTDescr.val;
      return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
    }
    LTDescr.val -= 2f;
    return -this.diffDiv2 * (float) ((double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val - 2.0) + this.from;
  }

  private Vector3 easeInQuint()
  {
    LTDescr.val = this.ratioPassed;
    LTDescr.val = LTDescr.val * LTDescr.val * LTDescr.val * LTDescr.val * LTDescr.val;
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeOutQuint()
  {
    LTDescr.val = this.ratioPassed - 1f;
    LTDescr.val = (float) ((double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val + 1.0);
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInOutQuint()
  {
    LTDescr.val = this.ratioPassed * 2f;
    if ((double) LTDescr.val < 1.0)
    {
      LTDescr.val = LTDescr.val * LTDescr.val * LTDescr.val * LTDescr.val * LTDescr.val;
      return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
    }
    LTDescr.val -= 2f;
    LTDescr.val = (float) ((double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val * (double) LTDescr.val + 2.0);
    return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInSine()
  {
    LTDescr.val = -Mathf.Cos(this.ratioPassed * LeanTween.PI_DIV2);
    return new Vector3(this.diff.x * LTDescr.val + this.diff.x + this.from.x, this.diff.y * LTDescr.val + this.diff.y + this.from.y, this.diff.z * LTDescr.val + this.diff.z + this.from.z);
  }

  private Vector3 easeOutSine()
  {
    LTDescr.val = Mathf.Sin(this.ratioPassed * LeanTween.PI_DIV2);
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInOutSine()
  {
    LTDescr.val = (float) -((double) Mathf.Cos(3.14159274f * this.ratioPassed) - 1.0);
    return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInExpo()
  {
    LTDescr.val = Mathf.Pow(2f, (float) (10.0 * ((double) this.ratioPassed - 1.0)));
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeOutExpo()
  {
    LTDescr.val = (float) (-(double) Mathf.Pow(2f, -10f * this.ratioPassed) + 1.0);
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInOutExpo()
  {
    LTDescr.val = this.ratioPassed * 2f;
    if ((double) LTDescr.val < 1.0)
      return this.diffDiv2 * Mathf.Pow(2f, (float) (10.0 * ((double) LTDescr.val - 1.0))) + this.from;
    --LTDescr.val;
    return this.diffDiv2 * (float) (-(double) Mathf.Pow(2f, -10f * LTDescr.val) + 2.0) + this.from;
  }

  private Vector3 easeInCirc()
  {
    LTDescr.val = (float) -((double) Mathf.Sqrt((float) (1.0 - (double) this.ratioPassed * (double) this.ratioPassed)) - 1.0);
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeOutCirc()
  {
    LTDescr.val = this.ratioPassed - 1f;
    LTDescr.val = Mathf.Sqrt((float) (1.0 - (double) LTDescr.val * (double) LTDescr.val));
    return new Vector3(this.diff.x * LTDescr.val + this.from.x, this.diff.y * LTDescr.val + this.from.y, this.diff.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInOutCirc()
  {
    LTDescr.val = this.ratioPassed * 2f;
    if ((double) LTDescr.val < 1.0)
    {
      LTDescr.val = (float) -((double) Mathf.Sqrt((float) (1.0 - (double) LTDescr.val * (double) LTDescr.val)) - 1.0);
      return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
    }
    LTDescr.val -= 2f;
    LTDescr.val = Mathf.Sqrt((float) (1.0 - (double) LTDescr.val * (double) LTDescr.val)) + 1f;
    return new Vector3(this.diffDiv2.x * LTDescr.val + this.from.x, this.diffDiv2.y * LTDescr.val + this.from.y, this.diffDiv2.z * LTDescr.val + this.from.z);
  }

  private Vector3 easeInBounce()
  {
    LTDescr.val = this.ratioPassed;
    LTDescr.val = 1f - LTDescr.val;
    return new Vector3(this.diff.x - LeanTween.easeOutBounce(0.0f, this.diff.x, LTDescr.val) + this.from.x, this.diff.y - LeanTween.easeOutBounce(0.0f, this.diff.y, LTDescr.val) + this.from.y, this.diff.z - LeanTween.easeOutBounce(0.0f, this.diff.z, LTDescr.val) + this.from.z);
  }

  private Vector3 easeOutBounce()
  {
    LTDescr.val = this.ratioPassed;
    float num1;
    if ((double) LTDescr.val < (double) (num1 = (float) (1.0 - 1.75 * (double) this.overshoot / 2.75)))
    {
      LTDescr.val = 1f / num1 / num1 * LTDescr.val * LTDescr.val;
    }
    else
    {
      float num2;
      if ((double) LTDescr.val < (double) (num2 = (float) (1.0 - 0.75 * (double) this.overshoot / 2.75)))
      {
        LTDescr.val -= (float) (((double) num1 + (double) num2) / 2.0);
        LTDescr.val = (float) (121.0 / 16.0 * (double) LTDescr.val * (double) LTDescr.val + 1.0 - 0.25 * (double) this.overshoot * (double) this.overshoot);
      }
      else
      {
        float num3;
        if ((double) LTDescr.val < (double) (num3 = (float) (1.0 - 0.25 * (double) this.overshoot / 2.75)))
        {
          LTDescr.val -= (float) (((double) num3 + (double) num2) / 2.0);
          LTDescr.val = (float) (121.0 / 16.0 * (double) LTDescr.val * (double) LTDescr.val + 1.0 - 1.0 / 16.0 * (double) this.overshoot * (double) this.overshoot);
        }
        else
        {
          LTDescr.val -= (float) (((double) num3 + 1.0) / 2.0);
          LTDescr.val = (float) (121.0 / 16.0 * (double) LTDescr.val * (double) LTDescr.val + 1.0 - 1.0 / 64.0 * (double) this.overshoot * (double) this.overshoot);
        }
      }
    }
    return this.diff * LTDescr.val + this.from;
  }

  private Vector3 easeInOutBounce()
  {
    LTDescr.val = this.ratioPassed * 2f;
    if ((double) LTDescr.val < 1.0)
      return new Vector3(LeanTween.easeInBounce(0.0f, this.diff.x, LTDescr.val) * 0.5f + this.from.x, LeanTween.easeInBounce(0.0f, this.diff.y, LTDescr.val) * 0.5f + this.from.y, LeanTween.easeInBounce(0.0f, this.diff.z, LTDescr.val) * 0.5f + this.from.z);
    --LTDescr.val;
    return new Vector3(LeanTween.easeOutBounce(0.0f, this.diff.x, LTDescr.val) * 0.5f + this.diffDiv2.x + this.from.x, LeanTween.easeOutBounce(0.0f, this.diff.y, LTDescr.val) * 0.5f + this.diffDiv2.y + this.from.y, LeanTween.easeOutBounce(0.0f, this.diff.z, LTDescr.val) * 0.5f + this.diffDiv2.z + this.from.z);
  }

  private Vector3 easeInBack()
  {
    LTDescr.val = this.ratioPassed;
    LTDescr.val /= 1f;
    float num = 1.70158f * this.overshoot;
    return this.diff * LTDescr.val * LTDescr.val * ((num + 1f) * LTDescr.val - num) + this.from;
  }

  private Vector3 easeOutBack()
  {
    float num = 1.70158f * this.overshoot;
    LTDescr.val = (float) ((double) this.ratioPassed / 1.0 - 1.0);
    LTDescr.val = (float) ((double) LTDescr.val * (double) LTDescr.val * (((double) num + 1.0) * (double) LTDescr.val + (double) num) + 1.0);
    return this.diff * LTDescr.val + this.from;
  }

  private Vector3 easeInOutBack()
  {
    float num1 = 1.70158f * this.overshoot;
    LTDescr.val = this.ratioPassed * 2f;
    if ((double) LTDescr.val < 1.0)
    {
      float num2 = num1 * (1.525f * this.overshoot);
      return this.diffDiv2 * (float) ((double) LTDescr.val * (double) LTDescr.val * (((double) num2 + 1.0) * (double) LTDescr.val - (double) num2)) + this.from;
    }
    LTDescr.val -= 2f;
    float num3 = num1 * (1.525f * this.overshoot);
    LTDescr.val = (float) ((double) LTDescr.val * (double) LTDescr.val * (((double) num3 + 1.0) * (double) LTDescr.val + (double) num3) + 2.0);
    return this.diffDiv2 * LTDescr.val + this.from;
  }

  private Vector3 easeInElastic() => new Vector3(LeanTween.easeInElastic(this.from.x, this.to.x, this.ratioPassed, this.overshoot, this.period), LeanTween.easeInElastic(this.from.y, this.to.y, this.ratioPassed, this.overshoot, this.period), LeanTween.easeInElastic(this.from.z, this.to.z, this.ratioPassed, this.overshoot, this.period));

  private Vector3 easeOutElastic() => new Vector3(LeanTween.easeOutElastic(this.from.x, this.to.x, this.ratioPassed, this.overshoot, this.period), LeanTween.easeOutElastic(this.from.y, this.to.y, this.ratioPassed, this.overshoot, this.period), LeanTween.easeOutElastic(this.from.z, this.to.z, this.ratioPassed, this.overshoot, this.period));

  private Vector3 easeInOutElastic() => new Vector3(LeanTween.easeInOutElastic(this.from.x, this.to.x, this.ratioPassed, this.overshoot, this.period), LeanTween.easeInOutElastic(this.from.y, this.to.y, this.ratioPassed, this.overshoot, this.period), LeanTween.easeInOutElastic(this.from.z, this.to.z, this.ratioPassed, this.overshoot, this.period));

  public LTDescr setOvershoot(float overshoot)
  {
    this.overshoot = overshoot;
    return this;
  }

  public LTDescr setPeriod(float period)
  {
    this.period = period;
    return this;
  }

  public LTDescr setScale(float scale)
  {
    this.scale = scale;
    return this;
  }

  public LTDescr setEase(AnimationCurve easeCurve)
  {
    this._optional.animationCurve = easeCurve;
    this.easeMethod = new LTDescr.EaseTypeDelegate(this.tweenOnCurve);
    this.easeType = LeanTweenType.animationCurve;
    return this;
  }

  public LTDescr setTo(Vector3 to)
  {
    if (this.hasInitiliazed)
    {
      this.to = to;
      this.diff = to - this.from;
    }
    else
      this.to = to;
    return this;
  }

  public LTDescr setTo(Transform to)
  {
    this._optional.toTrans = to;
    return this;
  }

  public LTDescr setFrom(Vector3 from)
  {
    if ((bool) (UnityEngine.Object) this.trans)
      this.init();
    this.from = from;
    this.diff = this.to - this.from;
    this.diffDiv2 = this.diff * 0.5f;
    return this;
  }

  public LTDescr setFrom(float from) => this.setFrom(new Vector3(from, 0.0f, 0.0f));

  public LTDescr setDiff(Vector3 diff)
  {
    this.diff = diff;
    return this;
  }

  public LTDescr setHasInitialized(bool has)
  {
    this.hasInitiliazed = has;
    return this;
  }

  public LTDescr setId(uint id, uint global_counter)
  {
    this._id = id;
    this.counter = global_counter;
    return this;
  }

  public LTDescr setPassed(float passed)
  {
    this.passed = passed;
    return this;
  }

  public LTDescr setTime(float time)
  {
    float num = this.passed / this.time;
    this.passed = time * num;
    this.time = time;
    return this;
  }

  public LTDescr setSpeed(float speed)
  {
    this.speed = speed;
    if (this.hasInitiliazed)
      this.initSpeed();
    return this;
  }

  public LTDescr setRepeat(int repeat)
  {
    this.loopCount = repeat;
    if (repeat > 1 && this.loopType == LeanTweenType.once || repeat < 0 && this.loopType == LeanTweenType.once)
      this.loopType = LeanTweenType.clamp;
    if (this.type == TweenAction.CALLBACK || this.type == TweenAction.CALLBACK_COLOR)
      this.setOnCompleteOnRepeat(true);
    return this;
  }

  public LTDescr setLoopType(LeanTweenType loopType)
  {
    this.loopType = loopType;
    return this;
  }

  public LTDescr setUseEstimatedTime(bool useEstimatedTime)
  {
    this.useEstimatedTime = useEstimatedTime;
    this.usesNormalDt = false;
    return this;
  }

  public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
  {
    this.useEstimatedTime = useUnScaledTime;
    this.usesNormalDt = false;
    return this;
  }

  public LTDescr setUseFrames(bool useFrames)
  {
    this.useFrames = useFrames;
    this.usesNormalDt = false;
    return this;
  }

  public LTDescr setUseManualTime(bool useManualTime)
  {
    this.useManualTime = useManualTime;
    this.usesNormalDt = false;
    return this;
  }

  public LTDescr setLoopCount(int loopCount)
  {
    this.loopType = LeanTweenType.clamp;
    this.loopCount = loopCount;
    return this;
  }

  public LTDescr setLoopOnce()
  {
    this.loopType = LeanTweenType.once;
    return this;
  }

  public LTDescr setLoopClamp()
  {
    this.loopType = LeanTweenType.clamp;
    if (this.loopCount == 0)
      this.loopCount = -1;
    return this;
  }

  public LTDescr setLoopClamp(int loops)
  {
    this.loopCount = loops;
    return this;
  }

  public LTDescr setLoopPingPong()
  {
    this.loopType = LeanTweenType.pingPong;
    if (this.loopCount == 0)
      this.loopCount = -1;
    return this;
  }

  public LTDescr setLoopPingPong(int loops)
  {
    this.loopType = LeanTweenType.pingPong;
    this.loopCount = loops == -1 ? loops : loops * 2;
    return this;
  }

  public LTDescr setOnComplete(System.Action onComplete)
  {
    this._optional.onComplete = onComplete;
    this.hasExtraOnCompletes = true;
    return this;
  }

  public LTDescr setOnComplete(Action<object> onComplete)
  {
    this._optional.onCompleteObject = onComplete;
    this.hasExtraOnCompletes = true;
    return this;
  }

  public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
  {
    this._optional.onCompleteObject = onComplete;
    this.hasExtraOnCompletes = true;
    if (onCompleteParam != null)
      this._optional.onCompleteParam = onCompleteParam;
    return this;
  }

  public LTDescr setOnCompleteParam(object onCompleteParam)
  {
    this._optional.onCompleteParam = onCompleteParam;
    this.hasExtraOnCompletes = true;
    return this;
  }

  public LTDescr setOnUpdate(Action<float> onUpdate)
  {
    this._optional.onUpdateFloat = onUpdate;
    this.hasUpdateCallback = true;
    return this;
  }

  public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
  {
    this._optional.onUpdateFloatRatio = onUpdate;
    this.hasUpdateCallback = true;
    return this;
  }

  public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
  {
    this._optional.onUpdateFloatObject = onUpdate;
    this.hasUpdateCallback = true;
    return this;
  }

  public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
  {
    this._optional.onUpdateVector2 = onUpdate;
    this.hasUpdateCallback = true;
    return this;
  }

  public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
  {
    this._optional.onUpdateVector3 = onUpdate;
    this.hasUpdateCallback = true;
    return this;
  }

  public LTDescr setOnUpdateColor(Action<Color> onUpdate)
  {
    this._optional.onUpdateColor = onUpdate;
    this.hasUpdateCallback = true;
    return this;
  }

  public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
  {
    this._optional.onUpdateColorObject = onUpdate;
    this.hasUpdateCallback = true;
    return this;
  }

  public LTDescr setOnUpdate(Action<Color> onUpdate)
  {
    this._optional.onUpdateColor = onUpdate;
    this.hasUpdateCallback = true;
    return this;
  }

  public LTDescr setOnUpdate(Action<Color, object> onUpdate)
  {
    this._optional.onUpdateColorObject = onUpdate;
    this.hasUpdateCallback = true;
    return this;
  }

  public LTDescr setOnUpdate(Action<float, object> onUpdate, object onUpdateParam = null)
  {
    this._optional.onUpdateFloatObject = onUpdate;
    this.hasUpdateCallback = true;
    if (onUpdateParam != null)
      this._optional.onUpdateParam = onUpdateParam;
    return this;
  }

  public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, object onUpdateParam = null)
  {
    this._optional.onUpdateVector3Object = onUpdate;
    this.hasUpdateCallback = true;
    if (onUpdateParam != null)
      this._optional.onUpdateParam = onUpdateParam;
    return this;
  }

  public LTDescr setOnUpdate(Action<Vector2> onUpdate, object onUpdateParam = null)
  {
    this._optional.onUpdateVector2 = onUpdate;
    this.hasUpdateCallback = true;
    if (onUpdateParam != null)
      this._optional.onUpdateParam = onUpdateParam;
    return this;
  }

  public LTDescr setOnUpdate(Action<Vector3> onUpdate, object onUpdateParam = null)
  {
    this._optional.onUpdateVector3 = onUpdate;
    this.hasUpdateCallback = true;
    if (onUpdateParam != null)
      this._optional.onUpdateParam = onUpdateParam;
    return this;
  }

  public LTDescr setOnUpdateParam(object onUpdateParam)
  {
    this._optional.onUpdateParam = onUpdateParam;
    return this;
  }

  public LTDescr setOrientToPath(bool doesOrient)
  {
    if (this.type == TweenAction.MOVE_CURVED || this.type == TweenAction.MOVE_CURVED_LOCAL)
    {
      if (this._optional.path == null)
        this._optional.path = new LTBezierPath();
      this._optional.path.orientToPath = doesOrient;
    }
    else
      this._optional.spline.orientToPath = doesOrient;
    return this;
  }

  public LTDescr setOrientToPath2d(bool doesOrient2d)
  {
    this.setOrientToPath(doesOrient2d);
    if (this.type == TweenAction.MOVE_CURVED || this.type == TweenAction.MOVE_CURVED_LOCAL)
      this._optional.path.orientToPath2d = doesOrient2d;
    else
      this._optional.spline.orientToPath2d = doesOrient2d;
    return this;
  }

  public LTDescr setRect(LTRect rect)
  {
    this._optional.ltRect = rect;
    return this;
  }

  public LTDescr setRect(Rect rect)
  {
    this._optional.ltRect = new LTRect(rect);
    return this;
  }

  public LTDescr setPath(LTBezierPath path)
  {
    this._optional.path = path;
    return this;
  }

  public LTDescr setPoint(Vector3 point)
  {
    this._optional.point = point;
    return this;
  }

  public LTDescr setDestroyOnComplete(bool doesDestroy)
  {
    this.destroyOnComplete = doesDestroy;
    return this;
  }

  public LTDescr setAudio(object audio)
  {
    this._optional.onCompleteParam = audio;
    return this;
  }

  public LTDescr setOnCompleteOnRepeat(bool isOn)
  {
    this.onCompleteOnRepeat = isOn;
    return this;
  }

  public LTDescr setOnCompleteOnStart(bool isOn)
  {
    this.onCompleteOnStart = isOn;
    return this;
  }

  public LTDescr setRect(RectTransform rect)
  {
    this.rectTransform = rect;
    return this;
  }

  public LTDescr setSprites(Sprite[] sprites)
  {
    this.sprites = sprites;
    return this;
  }

  public LTDescr setFrameRate(float frameRate)
  {
    this.time = (float) this.sprites.Length / frameRate;
    return this;
  }

  public LTDescr setOnStart(System.Action onStart)
  {
    this._optional.onStart = onStart;
    return this;
  }

  public LTDescr setDirection(float direction)
  {
    if ((double) this.direction != -1.0 && (double) this.direction != 1.0)
    {
      Debug.LogWarning((object) ("You have passed an incorrect direction of '" + direction.ToString() + "', direction must be -1f or 1f"));
      return this;
    }
    if ((double) this.direction != (double) direction)
    {
      if (this.hasInitiliazed)
        this.direction = direction;
      else if (this._optional.path != null)
        this._optional.path = new LTBezierPath(LTUtility.reverse(this._optional.path.pts));
      else if (this._optional.spline != null)
        this._optional.spline = new LTSpline(LTUtility.reverse(this._optional.spline.pts));
    }
    return this;
  }

  public LTDescr setRecursive(bool useRecursion)
  {
    this.useRecursion = useRecursion;
    return this;
  }

  public delegate Vector3 EaseTypeDelegate();

  public delegate void ActionMethodDelegate();
}
