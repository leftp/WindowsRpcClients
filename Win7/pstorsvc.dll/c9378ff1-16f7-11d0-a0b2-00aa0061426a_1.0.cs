//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\pstorsvc.dll
// Interface ID: c9378ff1-16f7-11d0-a0b2-00aa0061426a
// Interface Version: 1.0



namespace rpc_c9378ff1_16f7_11d0_a0b2_00aa0061426a_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(Struct_6[] p0, long p1)
        {
            WriteConformantStructArray<Struct_6>(p0, p1);
        }
        public void Write_9(Struct_7[] p0, long p1)
        {
            WriteConformantStructArray<Struct_7>(p0, p1);
        }
        public void Write_10(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_11(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_12(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_13(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_14(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_15(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public Struct_6[] Read_8()
        {
            return ReadConformantStructArray<Struct_6>();
        }
        public Struct_7[] Read_9()
        {
            return ReadConformantStructArray<Struct_7>();
        }
        public byte[] Read_10()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_11()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_12()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_13()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_14()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_15()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteUInt3264(Member0);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadUInt3264();
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0;
        public int Member8;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0, int Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteGuid(Member4);
            m.WriteInt32(Member14);
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadGuid();
            Member14 = u.ReadInt32();
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public System.Guid Member4;
        public int Member14;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, System.Guid Member4, int Member14, string Member18)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member14 = Member14;
            this.Member18 = Member18;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt64(Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(long Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(int Member0, string Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteEmbeddedPointer<Struct_6[], long>(Member8, new System.Action<Struct_6[], long>(m.Write_8), Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<Struct_6[]>(new System.Func<Struct_6[]>(u.Read_8), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_6[]> Member8;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(int Member0, int Member4, Struct_6[] Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteEmbeddedPointer<Struct_7[], long>(Member10, new System.Action<Struct_7[], long>(m.Write_9), Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            Member10 = u.ReadEmbeddedPointer<Struct_7[]>(new System.Func<Struct_7[]>(u.Read_9), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_7[]> Member10;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(int Member0, int Member4, int Member8, Struct_7[] Member10)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteEmbeddedPointer<byte[], long>(Member10, new System.Action<byte[], long>(m.Write_10), Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            Member10 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_10), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member10;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(int Member0, int Member4, int Member8, byte[] Member10)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteUInt3264(Member8);
            m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadUInt3264();
            Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
        public static Struct_8 CreateDefault()
        {
            return new Struct_8();
        }
        public Struct_8(int Member0, int Member4, NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member8, string Member10)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("c9378ff1-16f7-11d0-a0b2-00aa0061426a", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_SSPStoreEnumProviders(Struct_0 p0, out System.Nullable<Struct_1> p1, int p2, int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            return u.ReadInt32();
        }
        public int s_SSGetProvInfo(Struct_3 p0, Struct_0 p1, out System.Nullable<Struct_1> p2, int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(1, m);
            p2 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            return u.ReadInt32();
        }
        public int s_SSGetProvParam(Struct_3 p0, Struct_0 p1, int p2, out int p3, out byte[] p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(2, m);
            p3 = u.ReadInt32();
            p4 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_11), false);
            return u.ReadInt32();
        }
        public int s_SSSetProvParam(Struct_3 p0, Struct_0 p1, int p2, int p3, byte[] p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.Write_12(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int s_SSAcquireContext(System.Guid p0, Struct_0 p1, int p2, out Struct_3 p3, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteUInt3264(p4);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(4, m);
            p3 = u.Read_2();
            return u.ReadInt32();
        }
        public int s_SSReleaseContext(Struct_3 p0, Struct_0 p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int s_SSPasswordInterface(int p0, int p1, byte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.Write_13(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int s_SSEnumTypes(Struct_3 p0, Struct_0 p1, int p2, out System.Guid p3, int p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(7, m);
            p3 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int s_SSEnumSubtypes(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, out System.Guid p4, int p5, int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteInt32(p5);
            m.WriteInt32(p6);
            _Unmarshal_Helper u = SendReceive(8, m);
            p4 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int s_SSEnumItems(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, out string p5, int p6, int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.WriteInt32(p6);
            m.WriteInt32(p7);
            _Unmarshal_Helper u = SendReceive(9, m);
            p5 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int s_SSGetTypeInfo(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, out System.Nullable<Struct_4> p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(10, m);
            p4 = u.ReadReferentValue<Struct_4>(new System.Func<Struct_4>(u.Read_3), false);
            return u.ReadInt32();
        }
        public int s_SSGetSubtypeInfo(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, out System.Nullable<Struct_4> p5, int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.WriteInt32(p6);
            _Unmarshal_Helper u = SendReceive(11, m);
            p5 = u.ReadReferentValue<Struct_4>(new System.Func<Struct_4>(u.Read_3), false);
            return u.ReadInt32();
        }
        public int s_SSCreateType(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, Struct_4 p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.Write_3(p4);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int s_SSCreateSubtype(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, Struct_4 p5, Struct_5 p6, int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.Write_3(p5);
            m.Write_4(p6);
            m.WriteInt32(p7);
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
        public int s_SSDeleteType(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(14, m);
            return u.ReadInt32();
        }
        public int s_SSDeleteSubtype(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(15, m);
            return u.ReadInt32();
        }
        public int s_SSDeleteItem(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, string p5, Struct_8 p6, int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.Write_7(p6);
            m.WriteInt32(p7);
            _Unmarshal_Helper u = SendReceive(16, m);
            return u.ReadInt32();
        }
        public int s_SSReadItem(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, string p5, out int p6, out byte[] p7, Struct_8 p8, int p9)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.Write_7(p8);
            m.WriteInt32(p9);
            _Unmarshal_Helper u = SendReceive(17, m);
            p6 = u.ReadInt32();
            p7 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_14), false);
            return u.ReadInt32();
        }
        public int s_SSWriteItem(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, string p5, int p6, byte[] p7, Struct_8 p8, int p9, int p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.WriteInt32(p6);
            m.Write_15(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"), p6);
            m.Write_7(p8);
            m.WriteInt32(p9);
            m.WriteInt32(p10);
            _Unmarshal_Helper u = SendReceive(18, m);
            return u.ReadInt32();
        }
        public int s_SSOpenItem(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, string p5, int p6, Struct_8 p7, int p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.WriteInt32(p6);
            m.Write_7(p7);
            m.WriteInt32(p8);
            _Unmarshal_Helper u = SendReceive(19, m);
            return u.ReadInt32();
        }
        public int s_SSCloseItem(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, string p5, int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.WriteInt32(p6);
            _Unmarshal_Helper u = SendReceive(20, m);
            return u.ReadInt32();
        }
        public int s_SSReadAccessRuleset(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, out System.Nullable<Struct_5> p5, int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.WriteInt32(p6);
            _Unmarshal_Helper u = SendReceive(21, m);
            p5 = u.ReadReferentValue<Struct_5>(new System.Func<Struct_5>(u.Read_4), false);
            return u.ReadInt32();
        }
        public int s_SSReadAccessRuleset_22(Struct_3 p0, Struct_0 p1, int p2, System.Guid p3, System.Guid p4, Struct_5 p5, int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_2(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteGuid(p4);
            m.Write_4(p5);
            m.WriteInt32(p6);
            _Unmarshal_Helper u = SendReceive(22, m);
            return u.ReadInt32();
        }
    }
    #endregion
}
