//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\nsisvc.dll
// Interface ID: 7ea70bcf-48af-4f6a-8968-6a440754d5fa
// Interface Version: 1.0



namespace rpc_7ea70bcf_48af_4f6a_8968_6a440754d5fa_1_0
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
        public void Write_2(Union_2 p0, long p1)
        {
            WriteUnion<Union_2>(p0, p1);
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
        public void Write_8(Struct_9 p0)
        {
            WriteStruct<Struct_9>(p0);
        }
        public void Write_9(Struct_10 p0)
        {
            WriteStruct<Struct_10>(p0);
        }
        public void Write_10(Struct_11 p0)
        {
            WriteStruct<Struct_11>(p0);
        }
        public void Write_11(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_12(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_13(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_14(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_15(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_16(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_17(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
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
        public Union_2 Read_2()
        {
            return ReadStruct<Union_2>();
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
        public Struct_9 Read_8()
        {
            return ReadStruct<Struct_9>();
        }
        public Struct_10 Read_9()
        {
            return ReadStruct<Struct_10>();
        }
        public Struct_11 Read_10()
        {
            return ReadStruct<Struct_11>();
        }
        public sbyte[] Read_11()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_12()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_13()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_14()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_15()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_16()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_17()
        {
            return ReadConformantArray<sbyte>();
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
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<Struct_1>(Member8, new System.Action<Struct_1>(m.Write_1));
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_1> Member8;
        public int Member10;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, System.Nullable<Struct_1> Member8, int Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
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
            m.WriteInt16(Member0);
            m.WriteEnum16(Member4);
            m.Write_2(Member8, Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member4 = u.ReadEnum16();
            Member8 = u.Read_2();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public short Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4;
        public Union_2 Member8;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(short Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4, Union_2 Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    public struct Union_2 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            throw new System.NotImplementedException();
        }
        void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
        {
            Selector = ((NtApiDotNet.Ndr.Marshal.NdrEnum16)(l));
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Selector);
            if ((Selector == 1))
            {
                m.WriteGuid(Arm_1);
                goto done;
            }
            if ((Selector == 2))
            {
                m.Write_3(Arm_2);
                goto done;
            }
            m.WriteEmpty(Arm_Default);
        done:
            return;
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Selector = u.ReadEnum16();
            if ((Selector == 1))
            {
                Arm_1 = u.ReadGuid();
                goto done;
            }
            if ((Selector == 2))
            {
                Arm_2 = u.Read_3();
                goto done;
            }
            Arm_Default = u.ReadEmpty();
        done:
            return;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        private NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector;
        public System.Guid Arm_1;
        public Struct_4 Arm_2;
        public NtApiDotNet.Ndr.Marshal.NdrEmpty Arm_Default;
        public static Union_2 CreateDefault()
        {
            return new Union_2();
        }
        public Union_2(NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector, System.Guid Arm_1, Struct_4 Arm_2, NtApiDotNet.Ndr.Marshal.NdrEmpty Arm_Default)
        {
            this.Selector = Selector;
            this.Arm_1 = Arm_1;
            this.Arm_2 = Arm_2;
            this.Arm_Default = Arm_Default;
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
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
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
            m.WriteEmbeddedPointer<sbyte[], long>(Member0, new System.Action<sbyte[], long>(m.Write_11), Member8);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_11), false);
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member0;
        public int Member8;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(sbyte[] Member0, int Member8)
        {
            this.Member0 = Member0;
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
            m.WriteEnum16(Member0);
            m.WriteEmbeddedPointer<sbyte[], long>(Member8, new System.Action<sbyte[], long>(m.Write_12), Member10);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member8 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_12), false);
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member8;
        public int Member10;
        public int Member14;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, sbyte[] Member8, int Member10, int Member14)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member14 = Member14;
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
            m.WriteEmbeddedPointer<sbyte[], long>(Member0, new System.Action<sbyte[], long>(m.Write_11), Member8);
            m.WriteInt32(Member8);
            m.WriteEmbeddedPointer<sbyte[], long>(Member10, new System.Action<sbyte[], long>(m.Write_13), Member18);
            m.WriteInt32(Member18);
            m.WriteEmbeddedPointer<sbyte[], long>(Member20, new System.Action<sbyte[], long>(m.Write_14), Member28);
            m.WriteInt32(Member28);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_11), false);
            Member8 = u.ReadInt32();
            Member10 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_13), false);
            Member18 = u.ReadInt32();
            Member20 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_14), false);
            Member28 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member0;
        public int Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member10;
        public int Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member20;
        public int Member28;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(sbyte[] Member0, int Member8, sbyte[] Member10, int Member18, sbyte[] Member20, int Member28)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
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
            m.WriteEmbeddedPointer<sbyte[], long>(Member0, new System.Action<sbyte[], long>(m.Write_15), MemberC);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_15), false);
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member0;
        public int Member8;
        public int MemberC;
        public static Struct_8 CreateDefault()
        {
            return new Struct_8();
        }
        public Struct_8(sbyte[] Member0, int Member8, int MemberC)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.MemberC = MemberC;
        }
    }
    public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<sbyte[], long>(Member0, new System.Action<sbyte[], long>(m.Write_15), MemberC);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteEmbeddedPointer<sbyte[], long>(Member10, new System.Action<sbyte[], long>(m.Write_16), Member1C);
            m.WriteInt32(Member18);
            m.WriteInt32(Member1C);
            m.WriteEmbeddedPointer<sbyte[], long>(Member20, new System.Action<sbyte[], long>(m.Write_17), Member2C);
            m.WriteInt32(Member28);
            m.WriteInt32(Member2C);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_15), false);
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_16), false);
            Member18 = u.ReadInt32();
            Member1C = u.ReadInt32();
            Member20 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_17), false);
            Member28 = u.ReadInt32();
            Member2C = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member0;
        public int Member8;
        public int MemberC;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member10;
        public int Member18;
        public int Member1C;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member20;
        public int Member28;
        public int Member2C;
        public static Struct_9 CreateDefault()
        {
            return new Struct_9();
        }
        public Struct_9(sbyte[] Member0, int Member8, int MemberC, sbyte[] Member10, int Member18, int Member1C, sbyte[] Member20, int Member28, int Member2C)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member1C = Member1C;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member2C = Member2C;
        }
    }
    public struct Struct_10 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<sbyte[], long>(Member0, new System.Action<sbyte[], long>(m.Write_11), Member8);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_11), false);
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member0;
        public int Member8;
        public static Struct_10 CreateDefault()
        {
            return new Struct_10();
        }
        public Struct_10(sbyte[] Member0, int Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_11 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public static Struct_11 CreateDefault()
        {
            return new Struct_11();
        }
        public Struct_11(int Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("7ea70bcf-48af-4f6a-8968-6a440754d5fa", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcNsiGetParameter(Struct_0 p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, ref Struct_5 p3, ref Struct_6 p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteEnum16(p1);
            m.WriteEnum16(p2);
            m.Write_4(p3);
            m.Write_5(p4);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.Read_4();
            p4 = u.Read_5();
            return u.ReadInt32();
        }
        public int RpcNsiGetAllParameters(Struct_0 p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, ref Struct_5 p3, ref Struct_7 p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteEnum16(p1);
            m.WriteEnum16(p2);
            m.Write_4(p3);
            m.Write_6(p4);
            _Unmarshal_Helper u = SendReceive(1, m);
            p3 = u.Read_4();
            p4 = u.Read_6();
            return u.ReadInt32();
        }
        public int RpcNsiEnumerateObjectsAllParameters(Struct_0 p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, ref Struct_8 p3, ref Struct_9 p4, ref int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteEnum16(p1);
            m.WriteEnum16(p2);
            m.Write_7(p3);
            m.Write_8(p4);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(2, m);
            p3 = u.Read_7();
            p4 = u.Read_8();
            p5 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcNsiSetParameter(Struct_0 p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, ref Struct_5 p3, ref Struct_6 p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteEnum16(p1);
            m.WriteEnum16(p2);
            m.Write_4(p3);
            m.Write_5(p4);
            _Unmarshal_Helper u = SendReceive(3, m);
            p3 = u.Read_4();
            p4 = u.Read_5();
            return u.ReadInt32();
        }
        public int RpcNsiSetAllParameters(Struct_0 p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, ref Struct_5 p3, ref Struct_10 p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteEnum16(p1);
            m.WriteEnum16(p2);
            m.Write_4(p3);
            m.Write_9(p4);
            _Unmarshal_Helper u = SendReceive(4, m);
            p3 = u.Read_4();
            p4 = u.Read_9();
            return u.ReadInt32();
        }
        public int RpcNsiRegisterChangeNotification(Struct_0 p0, Struct_4 p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.Write_3(p1);
            _Unmarshal_Helper u = SendReceive(5, m);
            p2 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcNsiDeregisterChangeNotification(Struct_0 p0, ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteContextHandle(p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        // async
        public int RpcNsiRequestChangeNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_5 p1, out Struct_6 p2, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.Read_4();
            p2 = u.Read_5();
            p3 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int RpcNsiParameterChange(Struct_0 p0, Struct_5 p1, Struct_6 p2, Struct_11 p3, NtApiDotNet.Ndr.Marshal.NdrEnum16 p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.Write_4(p1);
            m.Write_5(p2);
            m.Write_10(p3);
            m.WriteEnum16(p4);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadInt32();
        }
    }
    #endregion
}
