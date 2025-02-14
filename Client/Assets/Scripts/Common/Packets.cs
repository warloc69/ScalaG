using System;

public enum Packets : short
{
	C_PKT_AUTH_REQUEST		= 0x1001,
	C_PKT_DISCONNECT	    = 0x1002,
	C_PKT_PLAYER_ACTION		= 0x1003,
	C_PKT_GO_SPAWN	    	= 0x1004,
	C_PKT_GO_DESTROY	    = 0x1005,
	C_PKT_GO_MOVE	        = 0x1006,
	C_PKT_GO_FIRE	        = 0x1007,
	C_PKT_GO_PARAM_UPDATE	= 0x1008,
	
	E_PKT_GO_SPAWN	    	= 0x2004,
	E_PKT_GO_DESTROY	    = 0x2005,
	E_PKT_GO_MOVE	        = 0x2006,
	E_PKT_GO_FIRE	        = 0x2007,
	E_PKT_GO_PARAM_UPDATE	= 0x2008,
	
	S_PKT_AUTH_RESPONSE		= 0x4000,
}
