
-- test.TbMultiRowRecord

return {
[1] = {
	-- test.MultiRowRecord
	id = 1,
	name = "xxx",
	one_rows = {{id=1,x=2,},},
	multi_rows1 = {{id=1,x=2,},},
	multi_rows2 = {{id=1,x=2,},},
	multi_rows3 = {{id=1,x=2,y=3,},},
	multi_rows4 = {[1]={id=1,x=2,y=3,},},
	multi_rows5 = {{id=1,items={{id=100,x=1,},},},},
},
[2] = {
	-- test.MultiRowRecord
	id = 2,
	name = "xxx",
	one_rows = {{id=2,x=4,},},
	multi_rows1 = {{id=2,x=4,},{id=2,x=4,},{id=2,x=4,},{id=2,x=4,},{id=2,x=4,},{id=2,x=4,},},
	multi_rows2 = {{id=3,x=4,},{id=3,x=4,},},
	multi_rows3 = {{id=2,x=3,y=4,},{id=2,x=3,y=4,},},
	multi_rows4 = {[2]={id=4,x=5,y=4,},},
	multi_rows5 = {{id=2,items={{id=100,x=1,},{id=200,x=2,},},},{id=3,items={{id=300,x=3,},},},{id=4,items={{id=400,x=4,},{id=500,x=5,},{id=600,x=6,},},},},
},
[3] = {
	-- test.MultiRowRecord
	id = 3,
	name = "ds",
	one_rows = {{id=1,x=2,},},
	multi_rows1 = {{id=1,x=2,},{id=2,x=4,},},
	multi_rows2 = {{id=3,x=4,},{id=3,x=4,},},
	multi_rows3 = {{id=1,x=2,y=3,},{id=2,x=3,y=4,},},
	multi_rows4 = {[1]={id=1,x=2,y=3,},[2]={id=4,x=5,y=4,},[3]={id=4,x=5,y=4,},},
	multi_rows5 = {{id=5,items={{id=100,x=1,},{id=200,x=2,},{id=300,x=3,},{id=400,x=4,},},},},
},
}