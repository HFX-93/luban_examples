
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "bright/serialization"

type TestTbDemoGroup_S struct {
    _dataMap map[int32]*TestDemoGroup
    _dataList []*TestDemoGroup
}

func NewTestTbDemoGroup_S(_buf *serialization.ByteBuf) (*TestTbDemoGroup_S, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*TestDemoGroup, 0, size)
		dataMap := make(map[int32]*TestDemoGroup)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := DeserializeTestDemoGroup(_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.Id] = _v
			}
		}
		return &TestTbDemoGroup_S{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *TestTbDemoGroup_S) GetDataMap() map[int32]*TestDemoGroup {
    return table._dataMap
}

func (table *TestTbDemoGroup_S) GetDataList() []*TestDemoGroup {
    return table._dataList
}

func (table *TestTbDemoGroup_S) Get(key int32) *TestDemoGroup {
    return table._dataMap[key]
}


