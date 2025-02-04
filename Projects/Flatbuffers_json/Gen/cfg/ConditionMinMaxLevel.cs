// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ConditionMinMaxLevel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static ConditionMinMaxLevel GetRootAsConditionMinMaxLevel(ByteBuffer _bb) { return GetRootAsConditionMinMaxLevel(_bb, new ConditionMinMaxLevel()); }
  public static ConditionMinMaxLevel GetRootAsConditionMinMaxLevel(ByteBuffer _bb, ConditionMinMaxLevel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConditionMinMaxLevel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Min { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Max { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<cfg.ConditionMinMaxLevel> CreateConditionMinMaxLevel(FlatBufferBuilder builder,
      int min = 0,
      int max = 0) {
    builder.StartTable(2);
    ConditionMinMaxLevel.AddMax(builder, max);
    ConditionMinMaxLevel.AddMin(builder, min);
    return ConditionMinMaxLevel.EndConditionMinMaxLevel(builder);
  }

  public static void StartConditionMinMaxLevel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddMin(FlatBufferBuilder builder, int min) { builder.AddInt(0, min, 0); }
  public static void AddMax(FlatBufferBuilder builder, int max) { builder.AddInt(1, max, 0); }
  public static Offset<cfg.ConditionMinMaxLevel> EndConditionMinMaxLevel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.ConditionMinMaxLevel>(o);
  }
};


}
