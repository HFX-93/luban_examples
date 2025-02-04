// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct BonusCoefficientItem : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static BonusCoefficientItem GetRootAsBonusCoefficientItem(ByteBuffer _bb) { return GetRootAsBonusCoefficientItem(_bb, new BonusCoefficientItem()); }
  public static BonusCoefficientItem GetRootAsBonusCoefficientItem(ByteBuffer _bb, BonusCoefficientItem obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BonusCoefficientItem __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int BonusId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public cfg.BonusItems? BonusList { get { int o = __p.__offset(6); return o != 0 ? (cfg.BonusItems?)(new cfg.BonusItems()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<cfg.BonusCoefficientItem> CreateBonusCoefficientItem(FlatBufferBuilder builder,
      int bonus_id = 0,
      Offset<cfg.BonusItems> bonus_listOffset = default(Offset<cfg.BonusItems>)) {
    builder.StartTable(2);
    BonusCoefficientItem.AddBonusList(builder, bonus_listOffset);
    BonusCoefficientItem.AddBonusId(builder, bonus_id);
    return BonusCoefficientItem.EndBonusCoefficientItem(builder);
  }

  public static void StartBonusCoefficientItem(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddBonusId(FlatBufferBuilder builder, int bonusId) { builder.AddInt(0, bonusId, 0); }
  public static void AddBonusList(FlatBufferBuilder builder, Offset<cfg.BonusItems> bonusListOffset) { builder.AddOffset(1, bonusListOffset.Value, 0); }
  public static Offset<cfg.BonusCoefficientItem> EndBonusCoefficientItem(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 6);  // bonus_list
    return new Offset<cfg.BonusCoefficientItem>(o);
  }
};


}
