// Decompiled with JetBrains decompiler
// Type: CardDataList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class CardDataList : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_list;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_CardData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_CardData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_Comparison_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_IComparer_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_Int32_Int32_IComparer_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindAll_Public_List_1_CardData_Predicate_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 102634, RefRangeEnd = 102654, XrefRangeStart = 102628, XrefRangeEnd = 102634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator<CardData> GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator<CardData>) null : new IEnumerator<CardData>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102654, XrefRangeEnd = 102660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 102664, RefRangeEnd = 102673, XrefRangeStart = 102660, XrefRangeEnd = 102664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Add(CardData item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102675, RefRangeEnd = 102677, XrefRangeStart = 102673, XrefRangeEnd = 102675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 102691, RefRangeEnd = 102702, XrefRangeStart = 102677, XrefRangeEnd = 102691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Contains(CardData item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102702, XrefRangeEnd = 102706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CopyTo(Il2CppReferenceArray<CardData> array, int arrayIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayIndex;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_CardData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 102718, RefRangeEnd = 102727, XrefRangeStart = 102706, XrefRangeEnd = 102718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Remove(CardData item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  public virtual unsafe int Count
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 102728, RefRangeEnd = 102734, XrefRangeStart = 102727, XrefRangeEnd = 102728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool IsReadOnly
  {
    [CallerCount(126), CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102734, XrefRangeEnd = 102743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int IndexOf(CardData item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 102747, RefRangeEnd = 102753, XrefRangeStart = 102743, XrefRangeEnd = 102747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Insert(int index, CardData item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 102757, RefRangeEnd = 102763, XrefRangeStart = 102753, XrefRangeEnd = 102757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void RemoveAt(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public virtual unsafe CardData this[int index]
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 102767, RefRangeEnd = 102773, XrefRangeStart = 102763, XrefRangeEnd = 102767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_CardData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102773, XrefRangeEnd = 102777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102777, XrefRangeEnd = 102781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Sort()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_Sort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102785, RefRangeEnd = 102786, XrefRangeStart = 102781, XrefRangeEnd = 102785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Sort(Il2CppSystem.Comparison<CardData> comparison)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) comparison)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_Sort_Public_Void_Comparison_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102786, XrefRangeEnd = 102790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Sort(IComparer<CardData> comparer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) comparer)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_Sort_Public_Void_IComparer_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102790, XrefRangeEnd = 102794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Sort(int index, int count, IComparer<CardData> comparer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) comparer);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_Sort_Public_Void_Int32_Int32_IComparer_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102798, RefRangeEnd = 102799, XrefRangeStart = 102794, XrefRangeEnd = 102798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<CardData> FindAll(Il2CppSystem.Predicate<CardData> predicate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) predicate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr_FindAll_Public_List_1_CardData_Predicate_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<CardData>) null : new List<CardData>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102808, RefRangeEnd = 102810, XrefRangeStart = 102799, XrefRangeEnd = 102808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardDataList()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardDataList>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDataList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardDataList()
  {
    Il2CppClassPointerStore<CardDataList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardDataList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardDataList>.NativeClassPtr);
    CardDataList.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, nameof (list));
    CardDataList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672521);
    CardDataList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672522);
    CardDataList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672523);
    CardDataList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672524);
    CardDataList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672525);
    CardDataList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_CardData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672526);
    CardDataList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672527);
    CardDataList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672528);
    CardDataList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672529);
    CardDataList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672530);
    CardDataList.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672531);
    CardDataList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672532);
    CardDataList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_CardData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672533);
    CardDataList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672534);
    CardDataList.NativeMethodInfoPtr_Sort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672535);
    CardDataList.NativeMethodInfoPtr_Sort_Public_Void_Comparison_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672536);
    CardDataList.NativeMethodInfoPtr_Sort_Public_Void_IComparer_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672537);
    CardDataList.NativeMethodInfoPtr_Sort_Public_Void_Int32_Int32_IComparer_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672538);
    CardDataList.NativeMethodInfoPtr_FindAll_Public_List_1_CardData_Predicate_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672539);
    CardDataList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDataList>.NativeClassPtr, 100672540);
  }

  public CardDataList(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<CardData> list
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDataList.NativeFieldInfoPtr_list));
      return pointer == System.IntPtr.Zero ? (List<CardData>) null : new List<CardData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardDataList.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
