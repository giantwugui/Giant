using System;
using System.Collections.Generic;
namespace Giant.Msg
{
	[Message(OuterOpcode.Msg_CA_Login)]
	public partial class Msg_CA_Login : IRequest {}

	[Message(OuterOpcode.Msg_CA_LoginZone)]
	public partial class Msg_CA_LoginZone : IRequest {}

	[Message(OuterOpcode.Msg_AC_Login)]
	public partial class Msg_AC_Login : IResponse {}

	[Message(OuterOpcode.Msg_AC_LoginZone)]
	public partial class Msg_AC_LoginZone : IResponse {}

	[Message(OuterOpcode.Msg_CG_HeartBeat_Ping)]
	public partial class Msg_CG_HeartBeat_Ping : IRequest {}

	[Message(OuterOpcode.Msg_CG_Get_SecretKey)]
	public partial class Msg_CG_Get_SecretKey : IRequest {}

	[Message(OuterOpcode.Msg_CG_PlayerInfo)]
	public partial class Msg_CG_PlayerInfo : IRequest {}

	[Message(OuterOpcode.Msg_CG_GetCharacter)]
	public partial class Msg_CG_GetCharacter : IRequest {}

	[Message(OuterOpcode.Msg_CG_CreateCharacter)]
	public partial class Msg_CG_CreateCharacter : IRequest {}

	[Message(OuterOpcode.Msg_CG_Login)]
	public partial class Msg_CG_Login : IRequest {}

	[Message(OuterOpcode.Msg_GC_HeartBeat_Pong)]
	public partial class Msg_GC_HeartBeat_Pong : IResponse {}

	[Message(OuterOpcode.Msg_GC_Get_SecretKey)]
	public partial class Msg_GC_Get_SecretKey : IResponse {}

	[Message(OuterOpcode.Msg_GC_CreateCharacter)]
	public partial class Msg_GC_CreateCharacter : IResponse {}

	[Message(OuterOpcode.Msg_CharacterInfo)]
	public partial class Msg_CharacterInfo {}

	[Message(OuterOpcode.Msg_GC_GetCharacter)]
	public partial class Msg_GC_GetCharacter : IResponse {}

	[Message(OuterOpcode.Msg_GC_Login)]
	public partial class Msg_GC_Login : IResponse {}

	[Message(OuterOpcode.Msg_PlayerInfo)]
	public partial class Msg_PlayerInfo : IMessage {}

	[Message(OuterOpcode.Msg_CG_EnterMap)]
	public partial class Msg_CG_EnterMap : IRequest {}

	[Message(OuterOpcode.Msg_GC_EnterMap)]
	public partial class Msg_GC_EnterMap : IResponse {}

	[Message(OuterOpcode.Msg_UnitInfo)]
	public partial class Msg_UnitInfo {}

	[Message(OuterOpcode.Msg_CG_TestMap)]
	public partial class Msg_CG_TestMap : IMessage {}

	[Message(OuterOpcode.Msg_GateZ_Hero_Break)]
	public partial class Msg_GateZ_Hero_Break : IRequest {}

	[Message(OuterOpcode.Msg_ZGate_Battle_Start)]
	public partial class Msg_ZGate_Battle_Start : IMessage {}

	[Message(OuterOpcode.Msg_ZGate_Hero_Break)]
	public partial class Msg_ZGate_Hero_Break : IResponse {}

}
namespace Giant.Msg
{
	public static partial class OuterOpcode
	{
		 public const ushort Msg_CA_Login = 101;
		 public const ushort Msg_CA_LoginZone = 102;
		 public const ushort Msg_AC_Login = 103;
		 public const ushort Msg_AC_LoginZone = 104;
		 public const ushort Msg_CG_HeartBeat_Ping = 105;
		 public const ushort Msg_CG_Get_SecretKey = 106;
		 public const ushort Msg_CG_PlayerInfo = 107;
		 public const ushort Msg_CG_GetCharacter = 108;
		 public const ushort Msg_CG_CreateCharacter = 109;
		 public const ushort Msg_CG_Login = 110;
		 public const ushort Msg_CG_EnterWorld = 111;
		 public const ushort Msg_GC_HeartBeat_Pong = 112;
		 public const ushort Msg_GC_Get_SecretKey = 113;
		 public const ushort Msg_GC_CreateCharacter = 114;
		 public const ushort Msg_CharacterInfo = 115;
		 public const ushort Msg_GC_GetCharacter = 116;
		 public const ushort Msg_GC_Login = 117;
		 public const ushort Msg_PlayerInfo = 118;
		 public const ushort Msg_GC_EnterWorld = 119;
		 public const ushort Msg_CG_EnterMap = 120;
		 public const ushort Msg_GC_EnterMap = 121;
		 public const ushort Msg_UnitInfo = 122;
		 public const ushort Msg_CG_TestMap = 123;
		 public const ushort Msg_GateZ_Hero_Break = 124;
		 public const ushort Msg_ZGate_Battle_Start = 125;
		 public const ushort Msg_ZGate_Hero_Break = 126;

		public static readonly Dictionary<ushort, Type> Opcode2Types = new Dictionary<ushort, Type>
		{
			{Msg_CA_Login, typeof(Msg_CA_Login)},
			{Msg_CA_LoginZone, typeof(Msg_CA_LoginZone)},
			{Msg_AC_Login, typeof(Msg_AC_Login)},
			{Msg_AC_LoginZone, typeof(Msg_AC_LoginZone)},
			{Msg_CG_HeartBeat_Ping, typeof(Msg_CG_HeartBeat_Ping)},
			{Msg_CG_Get_SecretKey, typeof(Msg_CG_Get_SecretKey)},
			{Msg_CG_PlayerInfo, typeof(Msg_CG_PlayerInfo)},
			{Msg_CG_GetCharacter, typeof(Msg_CG_GetCharacter)},
			{Msg_CG_CreateCharacter, typeof(Msg_CG_CreateCharacter)},
			{Msg_CG_Login, typeof(Msg_CG_Login)},
			{Msg_GC_HeartBeat_Pong, typeof(Msg_GC_HeartBeat_Pong)},
			{Msg_GC_Get_SecretKey, typeof(Msg_GC_Get_SecretKey)},
			{Msg_GC_CreateCharacter, typeof(Msg_GC_CreateCharacter)},
			{Msg_CharacterInfo, typeof(Msg_CharacterInfo)},
			{Msg_GC_GetCharacter, typeof(Msg_GC_GetCharacter)},
			{Msg_GC_Login, typeof(Msg_GC_Login)},
			{Msg_PlayerInfo, typeof(Msg_PlayerInfo)},
			{Msg_CG_EnterMap, typeof(Msg_CG_EnterMap)},
			{Msg_GC_EnterMap, typeof(Msg_GC_EnterMap)},
			{Msg_UnitInfo, typeof(Msg_UnitInfo)},
			{Msg_CG_TestMap, typeof(Msg_CG_TestMap)},
			{Msg_GateZ_Hero_Break, typeof(Msg_GateZ_Hero_Break)},
			{Msg_ZGate_Battle_Start, typeof(Msg_ZGate_Battle_Start)},
			{Msg_ZGate_Hero_Break, typeof(Msg_ZGate_Hero_Break)},
		};
	}
}
