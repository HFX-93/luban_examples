
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package proto

import "bright/net"

type ProtocolFactory = func () net.Protocol

var ProtocolStub map[int]ProtocolFactory

func init() {
	ProtocolStub = make(map[int]ProtocolFactory)
	ProtocolStub[23983] = func () net.Protocol { return &TestTestProto1{} }
	ProtocolStub[1234] = func () net.Protocol { return &TestFoo{} }
	ProtocolStub[8879] = func () net.Protocol { return &TestTestRpc{} }
	ProtocolStub[2355] = func () net.Protocol { return &TestTestRpc2{} }
}
