/*
	Generated by KBEngine!
	Please do not modify this file!
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class EntityDef
	{
		public static Dictionary<string, UInt16> datatype2id = new Dictionary<string, UInt16>();
		public static Dictionary<string, DATATYPE_BASE> datatypes = new Dictionary<string, DATATYPE_BASE>();
		public static Dictionary<UInt16, DATATYPE_BASE> id2datatypes = new Dictionary<UInt16, DATATYPE_BASE>();
		public static Dictionary<string, Int32> entityclass = new Dictionary<string, Int32>();
		public static Dictionary<string, ScriptModule> moduledefs = new Dictionary<string, ScriptModule>();
		public static Dictionary<UInt16, ScriptModule> idmoduledefs = new Dictionary<UInt16, ScriptModule>();

		public static bool init()
		{
			initDataTypes();
			initDefTypes();
			initScriptModules();
			return true;
		}

		public static bool reset()
		{
			clear();
			return init();
		}

		public static void clear()
		{
			datatype2id.Clear();
			datatypes.Clear();
			id2datatypes.Clear();
			entityclass.Clear();
			moduledefs.Clear();
			idmoduledefs.Clear();
		}

		public static void initDataTypes()
		{
			datatypes["UINT8"] = new DATATYPE_UINT8();
			datatypes["UINT16"] = new DATATYPE_UINT16();
			datatypes["UINT32"] = new DATATYPE_UINT32();
			datatypes["UINT64"] = new DATATYPE_UINT64();

			datatypes["INT8"] = new DATATYPE_INT8();
			datatypes["INT16"] = new DATATYPE_INT16();
			datatypes["INT32"] = new DATATYPE_INT32();
			datatypes["INT64"] = new DATATYPE_INT64();

			datatypes["FLOAT"] = new DATATYPE_FLOAT();
			datatypes["DOUBLE"] = new DATATYPE_DOUBLE();

			datatypes["STRING"] = new DATATYPE_STRING();
			datatypes["VECTOR2"] = new DATATYPE_VECTOR2();

			datatypes["VECTOR3"] = new DATATYPE_VECTOR3();

			datatypes["VECTOR4"] = new DATATYPE_VECTOR4();
			datatypes["PYTHON"] = new DATATYPE_PYTHON();

			datatypes["UNICODE"] = new DATATYPE_UNICODE();
			datatypes["ENTITYCALL"] = new DATATYPE_ENTITYCALL();

			datatypes["BLOB"] = new DATATYPE_BLOB();
		}

		public static void initScriptModules()
		{
			ScriptModule pFirstEntityModule = new ScriptModule("FirstEntity");
			EntityDef.moduledefs["FirstEntity"] = pFirstEntityModule;
			EntityDef.idmoduledefs[1] = pFirstEntityModule;

			Property pFirstEntity_position = new Property();
			pFirstEntity_position.name = "position";
			pFirstEntity_position.properUtype = 40000;
			pFirstEntity_position.properFlags = 4;
			pFirstEntity_position.aliasID = 1;
			Vector3 FirstEntity_position_defval = new Vector3();
			pFirstEntity_position.defaultVal = FirstEntity_position_defval;
			pFirstEntityModule.propertys["position"] = pFirstEntity_position; 

			pFirstEntityModule.usePropertyDescrAlias = true;
			pFirstEntityModule.idpropertys[(UInt16)pFirstEntity_position.aliasID] = pFirstEntity_position;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), property(position / 40000).");

			Property pFirstEntity_direction = new Property();
			pFirstEntity_direction.name = "direction";
			pFirstEntity_direction.properUtype = 40001;
			pFirstEntity_direction.properFlags = 4;
			pFirstEntity_direction.aliasID = 2;
			Vector3 FirstEntity_direction_defval = new Vector3();
			pFirstEntity_direction.defaultVal = FirstEntity_direction_defval;
			pFirstEntityModule.propertys["direction"] = pFirstEntity_direction; 

			pFirstEntityModule.usePropertyDescrAlias = true;
			pFirstEntityModule.idpropertys[(UInt16)pFirstEntity_direction.aliasID] = pFirstEntity_direction;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), property(direction / 40001).");

			Property pFirstEntity_spaceID = new Property();
			pFirstEntity_spaceID.name = "spaceID";
			pFirstEntity_spaceID.properUtype = 40002;
			pFirstEntity_spaceID.properFlags = 16;
			pFirstEntity_spaceID.aliasID = 3;
			UInt32 FirstEntity_spaceID_defval;
			UInt32.TryParse("", out FirstEntity_spaceID_defval);
			pFirstEntity_spaceID.defaultVal = FirstEntity_spaceID_defval;
			pFirstEntityModule.propertys["spaceID"] = pFirstEntity_spaceID; 

			pFirstEntityModule.usePropertyDescrAlias = true;
			pFirstEntityModule.idpropertys[(UInt16)pFirstEntity_spaceID.aliasID] = pFirstEntity_spaceID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), property(spaceID / 40002).");

			List<DATATYPE_BASE> pFirstEntity_onCtreatName_args = new List<DATATYPE_BASE>();

			Method pFirstEntity_onCtreatName = new Method();
			pFirstEntity_onCtreatName.name = "onCtreatName";
			pFirstEntity_onCtreatName.methodUtype = 5;
			pFirstEntity_onCtreatName.aliasID = 1;
			pFirstEntity_onCtreatName.args = pFirstEntity_onCtreatName_args;

			pFirstEntityModule.methods["onCtreatName"] = pFirstEntity_onCtreatName; 
			pFirstEntityModule.useMethodDescrAlias = true;
			pFirstEntityModule.idmethods[(UInt16)pFirstEntity_onCtreatName.aliasID] = pFirstEntity_onCtreatName;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), method(onCtreatName / 5).");

			List<DATATYPE_BASE> pFirstEntity_onEnter_args = new List<DATATYPE_BASE>();
			pFirstEntity_onEnter_args.Add(EntityDef.id2datatypes[12]);

			Method pFirstEntity_onEnter = new Method();
			pFirstEntity_onEnter.name = "onEnter";
			pFirstEntity_onEnter.methodUtype = 3;
			pFirstEntity_onEnter.aliasID = 2;
			pFirstEntity_onEnter.args = pFirstEntity_onEnter_args;

			pFirstEntityModule.methods["onEnter"] = pFirstEntity_onEnter; 
			pFirstEntityModule.useMethodDescrAlias = true;
			pFirstEntityModule.idmethods[(UInt16)pFirstEntity_onEnter.aliasID] = pFirstEntity_onEnter;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), method(onEnter / 3).");

			List<DATATYPE_BASE> pFirstEntity_onSay_args = new List<DATATYPE_BASE>();
			pFirstEntity_onSay_args.Add(EntityDef.id2datatypes[12]);
			pFirstEntity_onSay_args.Add(EntityDef.id2datatypes[8]);
			pFirstEntity_onSay_args.Add(EntityDef.id2datatypes[12]);

			Method pFirstEntity_onSay = new Method();
			pFirstEntity_onSay.name = "onSay";
			pFirstEntity_onSay.methodUtype = 4;
			pFirstEntity_onSay.aliasID = 3;
			pFirstEntity_onSay.args = pFirstEntity_onSay_args;

			pFirstEntityModule.methods["onSay"] = pFirstEntity_onSay; 
			pFirstEntityModule.useMethodDescrAlias = true;
			pFirstEntityModule.idmethods[(UInt16)pFirstEntity_onSay.aliasID] = pFirstEntity_onSay;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), method(onSay / 4).");

			List<DATATYPE_BASE> pFirstEntity_CtreatName_args = new List<DATATYPE_BASE>();
			pFirstEntity_CtreatName_args.Add(EntityDef.id2datatypes[12]);

			Method pFirstEntity_CtreatName = new Method();
			pFirstEntity_CtreatName.name = "CtreatName";
			pFirstEntity_CtreatName.methodUtype = 2;
			pFirstEntity_CtreatName.aliasID = -1;
			pFirstEntity_CtreatName.args = pFirstEntity_CtreatName_args;

			pFirstEntityModule.methods["CtreatName"] = pFirstEntity_CtreatName; 
			pFirstEntityModule.cell_methods["CtreatName"] = pFirstEntity_CtreatName;

			pFirstEntityModule.idcell_methods[pFirstEntity_CtreatName.methodUtype] = pFirstEntity_CtreatName;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), method(CtreatName / 2).");

			List<DATATYPE_BASE> pFirstEntity_say_args = new List<DATATYPE_BASE>();
			pFirstEntity_say_args.Add(EntityDef.id2datatypes[12]);

			Method pFirstEntity_say = new Method();
			pFirstEntity_say.name = "say";
			pFirstEntity_say.methodUtype = 1;
			pFirstEntity_say.aliasID = -1;
			pFirstEntity_say.args = pFirstEntity_say_args;

			pFirstEntityModule.methods["say"] = pFirstEntity_say; 
			pFirstEntityModule.cell_methods["say"] = pFirstEntity_say;

			pFirstEntityModule.idcell_methods[pFirstEntity_say.methodUtype] = pFirstEntity_say;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), method(say / 1).");

		}

		public static void initDefTypes()
		{
			{
				UInt16 utype = 2;
				string typeName = "UINT8";
				string name = "UINT8";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 3;
				string typeName = "UINT16";
				string name = "UINT16";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 5;
				string typeName = "UINT64";
				string name = "UINT64";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 4;
				string typeName = "UINT32";
				string name = "UINT32";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 6;
				string typeName = "INT8";
				string name = "INT8";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 7;
				string typeName = "INT16";
				string name = "INT16";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 8;
				string typeName = "INT32";
				string name = "INT32";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 9;
				string typeName = "INT64";
				string name = "INT64";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 1;
				string typeName = "STRING";
				string name = "STRING";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 12;
				string typeName = "UNICODE";
				string name = "UNICODE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 13;
				string typeName = "FLOAT";
				string name = "FLOAT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 14;
				string typeName = "DOUBLE";
				string name = "DOUBLE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PYTHON";
				string name = "PYTHON";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_DICT";
				string name = "PY_DICT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_TUPLE";
				string name = "PY_TUPLE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_LIST";
				string name = "PY_LIST";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 20;
				string typeName = "ENTITYCALL";
				string name = "ENTITYCALL";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 11;
				string typeName = "BLOB";
				string name = "BLOB";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 15;
				string typeName = "VECTOR2";
				string name = "VECTOR2";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 16;
				string typeName = "VECTOR3";
				string name = "VECTOR3";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 17;
				string typeName = "VECTOR4";
				string name = "VECTOR4";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			foreach(string datatypeStr in EntityDef.datatypes.Keys)
			{
				DATATYPE_BASE dataType = EntityDef.datatypes[datatypeStr];
				if(dataType != null)
				{
					dataType.bind();
				}
			}
		}

	}


}