// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct BonusWeightItemInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static BonusWeightItemInfo GetRootAsBonusWeightItemInfo(ByteBuffer _bb) { return GetRootAsBonusWeightItemInfo(_bb, new BonusWeightItemInfo()); }
  public static BonusWeightItemInfo GetRootAsBonusWeightItemInfo(ByteBuffer _bb, BonusWeightItemInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BonusWeightItemInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ItemId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Num { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Weight { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<cfg.BonusWeightItemInfo> CreateBonusWeightItemInfo(FlatBufferBuilder builder,
      int item_id = 0,
      int num = 0,
      int weight = 0) {
    builder.StartTable(3);
    BonusWeightItemInfo.AddWeight(builder, weight);
    BonusWeightItemInfo.AddNum(builder, num);
    BonusWeightItemInfo.AddItemId(builder, item_id);
    return BonusWeightItemInfo.EndBonusWeightItemInfo(builder);
  }

  public static void StartBonusWeightItemInfo(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddItemId(FlatBufferBuilder builder, int itemId) { builder.AddInt(0, itemId, 0); }
  public static void AddNum(FlatBufferBuilder builder, int num) { builder.AddInt(1, num, 0); }
  public static void AddWeight(FlatBufferBuilder builder, int weight) { builder.AddInt(2, weight, 0); }
  public static Offset<cfg.BonusWeightItemInfo> EndBonusWeightItemInfo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.BonusWeightItemInfo>(o);
  }
};


}
