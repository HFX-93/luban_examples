
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "bright/serialization"

type TestTbTestExcelBean struct {
    _dataMap map[int32]*TestTestExcelBean1
    _dataList []*TestTestExcelBean1
}

func NewTestTbTestExcelBean(_buf *serialization.ByteBuf) (*TestTbTestExcelBean, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*TestTestExcelBean1, 0, size)
		dataMap := make(map[int32]*TestTestExcelBean1)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := DeserializeTestTestExcelBean1(_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.X1] = _v
			}
		}
		return &TestTbTestExcelBean{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *TestTbTestExcelBean) GetDataMap() map[int32]*TestTestExcelBean1 {
    return table._dataMap
}

func (table *TestTbTestExcelBean) GetDataList() []*TestTestExcelBean1 {
    return table._dataList
}

func (table *TestTbTestExcelBean) Get(key int32) *TestTestExcelBean1 {
    return table._dataMap[key]
}


