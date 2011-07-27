// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUser007VTable
	{
		public IntPtr GetHSteamUser0;
		public IntPtr LogOn1;
		public IntPtr LogOff2;
		public IntPtr BLoggedOn3;
		public IntPtr GetSteamID4;
		public IntPtr SetRegistryString5;
		public IntPtr GetRegistryString6;
		public IntPtr SetRegistryInt7;
		public IntPtr GetRegistryInt8;
		public IntPtr InitiateGameConnection9;
		public IntPtr TerminateGameConnection10;
		public IntPtr TrackAppUsageEvent11;
		public IntPtr RefreshSteam2Login12;
		private IntPtr DTorISteamUser00713;
	};
	
	[InteropHelp.InterfaceVersion("SteamUser007")]
	public class ISteamUser007 : InteropHelp.NativeWrapper<ISteamUser007VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetHSteamUser( IntPtr thisptr );
		public Int32 GetHSteamUser(  ) 
		{
			return this.GetFunction<NativeGetHSteamUser>( this.Functions.GetHSteamUser0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOnC( IntPtr thisptr, UInt64 steamID );
		public void LogOn( CSteamID steamID ) 
		{
			this.GetFunction<NativeLogOnC>( this.Functions.LogOn1 )( this.ObjectAddress, steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOff( IntPtr thisptr );
		public void LogOff(  ) 
		{
			this.GetFunction<NativeLogOff>( this.Functions.LogOff2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBLoggedOn( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BLoggedOn(  ) 
		{
			return this.GetFunction<NativeBLoggedOn>( this.Functions.BLoggedOn3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID( IntPtr thisptr, ref UInt64 retarg );
		public CSteamID GetSteamID(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetSteamID>( this.Functions.GetSteamID4 )( this.ObjectAddress, ref ret ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetRegistryStringESS( IntPtr thisptr, ERegistrySubTree eRegistrySubTree, string pchKey, string pchValue );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetRegistryString( ERegistrySubTree eRegistrySubTree, string pchKey, string pchValue ) 
		{
			return this.GetFunction<NativeSetRegistryStringESS>( this.Functions.SetRegistryString5 )( this.ObjectAddress, eRegistrySubTree, pchKey, pchValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetRegistryStringESSI( IntPtr thisptr, ERegistrySubTree eRegistrySubTree, string pchKey, StringBuilder pchValue, Int32 cbValue );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetRegistryString( ERegistrySubTree eRegistrySubTree, string pchKey, StringBuilder pchValue ) 
		{
			return this.GetFunction<NativeGetRegistryStringESSI>( this.Functions.GetRegistryString6 )( this.ObjectAddress, eRegistrySubTree, pchKey, pchValue, (Int32) pchValue.Capacity ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetRegistryIntESI( IntPtr thisptr, ERegistrySubTree eRegistrySubTree, string pchKey, Int32 iValue );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetRegistryInt( ERegistrySubTree eRegistrySubTree, string pchKey, Int32 iValue ) 
		{
			return this.GetFunction<NativeSetRegistryIntESI>( this.Functions.SetRegistryInt7 )( this.ObjectAddress, eRegistrySubTree, pchKey, iValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetRegistryIntESI( IntPtr thisptr, ERegistrySubTree eRegistrySubTree, string pchKey, ref Int32 piValue );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetRegistryInt( ERegistrySubTree eRegistrySubTree, string pchKey, ref Int32 piValue ) 
		{
			return this.GetFunction<NativeGetRegistryIntESI>( this.Functions.GetRegistryInt8 )( this.ObjectAddress, eRegistrySubTree, pchKey, ref piValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeInitiateGameConnectionBICCUUBBI( IntPtr thisptr, Byte[] pBlob, Int32 cbMaxBlob, UInt64 steamID, UInt64 nGameAppID, UInt32 unIPServer, UInt16 usPortServer, [MarshalAs(UnmanagedType.I1)] bool bSecure, Byte[] pvSteam2GetEncryptionKey, Int32 cbSteam2GetEncryptionKey );
		public Int32 InitiateGameConnection( Byte[] pBlob, CSteamID steamID, CGameID nGameAppID, UInt32 unIPServer, UInt16 usPortServer, bool bSecure, Byte[] pvSteam2GetEncryptionKey ) 
		{
			return this.GetFunction<NativeInitiateGameConnectionBICCUUBBI>( this.Functions.InitiateGameConnection9 )( this.ObjectAddress, pBlob, (Int32) pBlob.Length, steamID.ConvertToUint64(), nGameAppID.ConvertToUint64(), unIPServer, usPortServer, bSecure, pvSteam2GetEncryptionKey, (Int32) pvSteam2GetEncryptionKey.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTerminateGameConnectionUU( IntPtr thisptr, UInt32 unIPServer, UInt16 usPortServer );
		public void TerminateGameConnection( UInt32 unIPServer, UInt16 usPortServer ) 
		{
			this.GetFunction<NativeTerminateGameConnectionUU>( this.Functions.TerminateGameConnection10 )( this.ObjectAddress, unIPServer, usPortServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTrackAppUsageEventCES( IntPtr thisptr, UInt64 gameID, EAppUsageEvent eAppUsageEvent, string pchExtraInfo );
		public void TrackAppUsageEvent( CGameID gameID, EAppUsageEvent eAppUsageEvent, string pchExtraInfo ) 
		{
			this.GetFunction<NativeTrackAppUsageEventCES>( this.Functions.TrackAppUsageEvent11 )( this.ObjectAddress, gameID.ConvertToUint64(), eAppUsageEvent, pchExtraInfo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRefreshSteam2Login( IntPtr thisptr );
		public void RefreshSteam2Login(  ) 
		{
			this.GetFunction<NativeRefreshSteam2Login>( this.Functions.RefreshSteam2Login12 )( this.ObjectAddress ); 
		}
		
	};
}
