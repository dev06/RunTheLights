#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "il2cpp-class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"

template <typename T1>
struct VirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1>
struct GenericVirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct GenericInterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};

// AppResources
struct AppResources_t1237449672;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t3962482529;
// UnityEngine.Object
struct Object_t631007953;
// System.String
struct String_t;
// Car
struct Car_t2395504951;
// UnityEngine.Component
struct Component_t1923634451;
// UnityEngine.Transform
struct Transform_t3600365921;
// UnityEngine.Collider
struct Collider_t1773347010;
// UnityEngine.GameObject
struct GameObject_t1113636619;
// CarStream
struct CarStream_t2397564518;
// System.Collections.Generic.List`1<UnityEngine.Transform>
struct List_1_t777473367;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t257213610;
// EventManager/Section
struct Section_t1829303744;
// System.Delegate
struct Delegate_t1188392813;
// EventManager
struct EventManager_t1594656820;
// System.IAsyncResult
struct IAsyncResult_t767004451;
// System.AsyncCallback
struct AsyncCallback_t3962456242;
// GameController
struct GameController_t2330501625;
// GameInput
struct GameInput_t4178564210;
// UnityEngine.Camera
struct Camera_t4157153871;
// Section
struct Section_t3531603569;
// SectionContainer
struct SectionContainer_t1774584350;
// System.Collections.IEnumerator
struct IEnumerator_t1853284238;
// System.Collections.Generic.List`1<Section>
struct List_1_t708711015;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_t128053199;
// UnityEngine.Transform[]
struct TransformU5BU5D_t807237628;
// Section[]
struct SectionU5BU5D_t3906743468;
// System.Int32[]
struct Int32U5BU5D_t385246372;
// System.Char[]
struct CharU5BU5D_t3528271667;
// System.Void
struct Void_t1185182177;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.DelegateData
struct DelegateData_t1677132599;
// UnityEngine.Camera/CameraCallback
struct CameraCallback_t190067161;

extern RuntimeClass* GameObject_t1113636619_il2cpp_TypeInfo_var;
extern RuntimeClass* AppResources_t1237449672_il2cpp_TypeInfo_var;
extern String_t* _stringLiteral522958457;
extern String_t* _stringLiteral2519308568;
extern String_t* _stringLiteral2519308569;
extern String_t* _stringLiteral1302725867;
extern const uint32_t AppResources__cctor_m685958323_MetadataUsageId;
extern RuntimeClass* Vector3_t3722313464_il2cpp_TypeInfo_var;
extern const uint32_t Car_Update_m2271061216_MetadataUsageId;
extern const uint32_t Car_Move_m1860261471_MetadataUsageId;
extern RuntimeClass* String_t_il2cpp_TypeInfo_var;
extern String_t* _stringLiteral2271825249;
extern const uint32_t Car_OnTriggerEnter_m590296435_MetadataUsageId;
extern RuntimeClass* List_1_t777473367_il2cpp_TypeInfo_var;
extern const RuntimeMethod* List_1__ctor_m2885667311_RuntimeMethod_var;
extern const uint32_t CarStream__ctor_m2851473992_MetadataUsageId;
extern RuntimeClass* EventManager_t1594656820_il2cpp_TypeInfo_var;
extern RuntimeClass* Section_t1829303744_il2cpp_TypeInfo_var;
extern const RuntimeMethod* CarStream_OnSectionPool_m2835630221_RuntimeMethod_var;
extern const uint32_t CarStream_OnEnable_m3463323575_MetadataUsageId;
extern const uint32_t CarStream_OnDisable_m937339345_MetadataUsageId;
extern RuntimeClass* Object_t631007953_il2cpp_TypeInfo_var;
extern const RuntimeMethod* Object_Instantiate_TisGameObject_t1113636619_m587845175_RuntimeMethod_var;
extern const RuntimeMethod* List_1_Add_m4073477735_RuntimeMethod_var;
extern const uint32_t CarStream_CreateCars_m3242703007_MetadataUsageId;
extern const RuntimeMethod* List_1_get_Item_m3022113929_RuntimeMethod_var;
extern const RuntimeMethod* Component_GetComponent_TisCar_t2395504951_m2969401948_RuntimeMethod_var;
extern const RuntimeMethod* List_1_get_Count_m3787308655_RuntimeMethod_var;
extern const uint32_t CarStream_MoveNextCar_m3344396066_MetadataUsageId;
extern const uint32_t CarStream_PlaceCarsAtStopPoint_m850318687_MetadataUsageId;
extern const uint32_t CarStream_SetMove_m42520417_MetadataUsageId;
extern RuntimeClass* SectionType_t4049925526_il2cpp_TypeInfo_var;
extern const uint32_t Section_BeginInvoke_m2512574320_MetadataUsageId;
extern RuntimeClass* Input_t1431474628_il2cpp_TypeInfo_var;
extern RuntimeClass* Mathf_t3464937446_il2cpp_TypeInfo_var;
extern RuntimeClass* Section_t3531603569_il2cpp_TypeInfo_var;
extern const uint32_t GameInput_Update_m1810695037_MetadataUsageId;
extern RuntimeClass* Vector2_t2156229523_il2cpp_TypeInfo_var;
extern const uint32_t GameInput_Control_m1402073417_MetadataUsageId;
extern String_t* _stringLiteral3280678900;
extern const uint32_t GameInput_OnTriggerEnter_m2049317573_MetadataUsageId;
extern const RuntimeMethod* Object_FindObjectOfType_TisSectionContainer_t1774584350_m3490830121_RuntimeMethod_var;
extern const uint32_t Section_Init_m3325106713_MetadataUsageId;
extern const uint32_t Section_Update_m1020174184_MetadataUsageId;
extern const uint32_t Section_OutSide_m20284767_MetadataUsageId;
extern RuntimeClass* IEnumerator_t1853284238_il2cpp_TypeInfo_var;
extern RuntimeClass* Transform_t3600365921_il2cpp_TypeInfo_var;
extern RuntimeClass* IDisposable_t3640265483_il2cpp_TypeInfo_var;
extern const uint32_t Section_Toggle_m2292751507_MetadataUsageId;
extern const uint32_t Section__cctor_m837636648_MetadataUsageId;
extern RuntimeClass* SectionContainer_t1774584350_il2cpp_TypeInfo_var;
extern const RuntimeMethod* List_1_Clear_m3586392508_RuntimeMethod_var;
extern const uint32_t SectionContainer_Awake_m2337727487_MetadataUsageId;
extern RuntimeClass* List_1_t708711015_il2cpp_TypeInfo_var;
extern RuntimeClass* List_1_t128053199_il2cpp_TypeInfo_var;
extern const RuntimeMethod* List_1__ctor_m1340754610_RuntimeMethod_var;
extern const RuntimeMethod* List_1__ctor_m1628857705_RuntimeMethod_var;
extern const RuntimeMethod* Component_GetComponent_TisSection_t3531603569_m2204478105_RuntimeMethod_var;
extern const RuntimeMethod* List_1_Contains_m1186541113_RuntimeMethod_var;
extern const RuntimeMethod* List_1_Add_m2981936162_RuntimeMethod_var;
extern const RuntimeMethod* List_1_get_Count_m3805462939_RuntimeMethod_var;
extern const RuntimeMethod* List_1_get_Item_m1934819507_RuntimeMethod_var;
extern const uint32_t SectionContainer_RepositionSections_m2416598502_MetadataUsageId;
extern const RuntimeMethod* GameObject_GetComponent_TisSection_t3531603569_m434087264_RuntimeMethod_var;
extern const uint32_t SectionContainer_CreateSection_m4022469148_MetadataUsageId;
extern const uint32_t SectionContainer_DeterminePrefab_m2704913349_MetadataUsageId;
extern const uint32_t SectionContainer_PoolSection_m2424153165_MetadataUsageId;
extern const uint32_t SectionContainer_GetUnactiveSection_m2430424878_MetadataUsageId;
extern const uint32_t SectionContainer_GetSectionFromReservedByType_m496361358_MetadataUsageId;
extern const uint32_t SectionContainer__cctor_m4081164715_MetadataUsageId;



#ifndef U3CMODULEU3E_T692745540_H
#define U3CMODULEU3E_T692745540_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct  U3CModuleU3E_t692745540 
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // U3CMODULEU3E_T692745540_H
#ifndef RUNTIMEOBJECT_H
#define RUNTIMEOBJECT_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEOBJECT_H
struct Il2CppArrayBounds;
#ifndef RUNTIMEARRAY_H
#define RUNTIMEARRAY_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Array

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEARRAY_H
#ifndef LIST_1_T777473367_H
#define LIST_1_T777473367_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<UnityEngine.Transform>
struct  List_1_t777473367  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	TransformU5BU5D_t807237628* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t777473367, ____items_1)); }
	inline TransformU5BU5D_t807237628* get__items_1() const { return ____items_1; }
	inline TransformU5BU5D_t807237628** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(TransformU5BU5D_t807237628* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t777473367, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t777473367, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}
};

struct List_1_t777473367_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::EmptyArray
	TransformU5BU5D_t807237628* ___EmptyArray_4;

public:
	inline static int32_t get_offset_of_EmptyArray_4() { return static_cast<int32_t>(offsetof(List_1_t777473367_StaticFields, ___EmptyArray_4)); }
	inline TransformU5BU5D_t807237628* get_EmptyArray_4() const { return ___EmptyArray_4; }
	inline TransformU5BU5D_t807237628** get_address_of_EmptyArray_4() { return &___EmptyArray_4; }
	inline void set_EmptyArray_4(TransformU5BU5D_t807237628* value)
	{
		___EmptyArray_4 = value;
		Il2CppCodeGenWriteBarrier((&___EmptyArray_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_T777473367_H
#ifndef LIST_1_T708711015_H
#define LIST_1_T708711015_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<Section>
struct  List_1_t708711015  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	SectionU5BU5D_t3906743468* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t708711015, ____items_1)); }
	inline SectionU5BU5D_t3906743468* get__items_1() const { return ____items_1; }
	inline SectionU5BU5D_t3906743468** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(SectionU5BU5D_t3906743468* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t708711015, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t708711015, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}
};

struct List_1_t708711015_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::EmptyArray
	SectionU5BU5D_t3906743468* ___EmptyArray_4;

public:
	inline static int32_t get_offset_of_EmptyArray_4() { return static_cast<int32_t>(offsetof(List_1_t708711015_StaticFields, ___EmptyArray_4)); }
	inline SectionU5BU5D_t3906743468* get_EmptyArray_4() const { return ___EmptyArray_4; }
	inline SectionU5BU5D_t3906743468** get_address_of_EmptyArray_4() { return &___EmptyArray_4; }
	inline void set_EmptyArray_4(SectionU5BU5D_t3906743468* value)
	{
		___EmptyArray_4 = value;
		Il2CppCodeGenWriteBarrier((&___EmptyArray_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_T708711015_H
#ifndef LIST_1_T128053199_H
#define LIST_1_T128053199_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<System.Int32>
struct  List_1_t128053199  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	Int32U5BU5D_t385246372* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t128053199, ____items_1)); }
	inline Int32U5BU5D_t385246372* get__items_1() const { return ____items_1; }
	inline Int32U5BU5D_t385246372** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(Int32U5BU5D_t385246372* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t128053199, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t128053199, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}
};

struct List_1_t128053199_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::EmptyArray
	Int32U5BU5D_t385246372* ___EmptyArray_4;

public:
	inline static int32_t get_offset_of_EmptyArray_4() { return static_cast<int32_t>(offsetof(List_1_t128053199_StaticFields, ___EmptyArray_4)); }
	inline Int32U5BU5D_t385246372* get_EmptyArray_4() const { return ___EmptyArray_4; }
	inline Int32U5BU5D_t385246372** get_address_of_EmptyArray_4() { return &___EmptyArray_4; }
	inline void set_EmptyArray_4(Int32U5BU5D_t385246372* value)
	{
		___EmptyArray_4 = value;
		Il2CppCodeGenWriteBarrier((&___EmptyArray_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_T128053199_H
#ifndef VALUETYPE_T3640485471_H
#define VALUETYPE_T3640485471_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct  ValueType_t3640485471  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t3640485471_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t3640485471_marshaled_com
{
};
#endif // VALUETYPE_T3640485471_H
#ifndef STRING_T_H
#define STRING_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.String
struct  String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::length
	int32_t ___length_0;
	// System.Char System.String::start_char
	Il2CppChar ___start_char_1;

public:
	inline static int32_t get_offset_of_length_0() { return static_cast<int32_t>(offsetof(String_t, ___length_0)); }
	inline int32_t get_length_0() const { return ___length_0; }
	inline int32_t* get_address_of_length_0() { return &___length_0; }
	inline void set_length_0(int32_t value)
	{
		___length_0 = value;
	}

	inline static int32_t get_offset_of_start_char_1() { return static_cast<int32_t>(offsetof(String_t, ___start_char_1)); }
	inline Il2CppChar get_start_char_1() const { return ___start_char_1; }
	inline Il2CppChar* get_address_of_start_char_1() { return &___start_char_1; }
	inline void set_start_char_1(Il2CppChar value)
	{
		___start_char_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_2;
	// System.Char[] System.String::WhiteChars
	CharU5BU5D_t3528271667* ___WhiteChars_3;

public:
	inline static int32_t get_offset_of_Empty_2() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_2)); }
	inline String_t* get_Empty_2() const { return ___Empty_2; }
	inline String_t** get_address_of_Empty_2() { return &___Empty_2; }
	inline void set_Empty_2(String_t* value)
	{
		___Empty_2 = value;
		Il2CppCodeGenWriteBarrier((&___Empty_2), value);
	}

	inline static int32_t get_offset_of_WhiteChars_3() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___WhiteChars_3)); }
	inline CharU5BU5D_t3528271667* get_WhiteChars_3() const { return ___WhiteChars_3; }
	inline CharU5BU5D_t3528271667** get_address_of_WhiteChars_3() { return &___WhiteChars_3; }
	inline void set_WhiteChars_3(CharU5BU5D_t3528271667* value)
	{
		___WhiteChars_3 = value;
		Il2CppCodeGenWriteBarrier((&___WhiteChars_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STRING_T_H
#ifndef VECTOR2_T2156229523_H
#define VECTOR2_T2156229523_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Vector2
struct  Vector2_t2156229523 
{
public:
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Vector2_t2156229523, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Vector2_t2156229523, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}
};

struct Vector2_t2156229523_StaticFields
{
public:
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t2156229523  ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t2156229523  ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t2156229523  ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t2156229523  ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t2156229523  ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t2156229523  ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t2156229523  ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t2156229523  ___negativeInfinityVector_9;

public:
	inline static int32_t get_offset_of_zeroVector_2() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___zeroVector_2)); }
	inline Vector2_t2156229523  get_zeroVector_2() const { return ___zeroVector_2; }
	inline Vector2_t2156229523 * get_address_of_zeroVector_2() { return &___zeroVector_2; }
	inline void set_zeroVector_2(Vector2_t2156229523  value)
	{
		___zeroVector_2 = value;
	}

	inline static int32_t get_offset_of_oneVector_3() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___oneVector_3)); }
	inline Vector2_t2156229523  get_oneVector_3() const { return ___oneVector_3; }
	inline Vector2_t2156229523 * get_address_of_oneVector_3() { return &___oneVector_3; }
	inline void set_oneVector_3(Vector2_t2156229523  value)
	{
		___oneVector_3 = value;
	}

	inline static int32_t get_offset_of_upVector_4() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___upVector_4)); }
	inline Vector2_t2156229523  get_upVector_4() const { return ___upVector_4; }
	inline Vector2_t2156229523 * get_address_of_upVector_4() { return &___upVector_4; }
	inline void set_upVector_4(Vector2_t2156229523  value)
	{
		___upVector_4 = value;
	}

	inline static int32_t get_offset_of_downVector_5() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___downVector_5)); }
	inline Vector2_t2156229523  get_downVector_5() const { return ___downVector_5; }
	inline Vector2_t2156229523 * get_address_of_downVector_5() { return &___downVector_5; }
	inline void set_downVector_5(Vector2_t2156229523  value)
	{
		___downVector_5 = value;
	}

	inline static int32_t get_offset_of_leftVector_6() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___leftVector_6)); }
	inline Vector2_t2156229523  get_leftVector_6() const { return ___leftVector_6; }
	inline Vector2_t2156229523 * get_address_of_leftVector_6() { return &___leftVector_6; }
	inline void set_leftVector_6(Vector2_t2156229523  value)
	{
		___leftVector_6 = value;
	}

	inline static int32_t get_offset_of_rightVector_7() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___rightVector_7)); }
	inline Vector2_t2156229523  get_rightVector_7() const { return ___rightVector_7; }
	inline Vector2_t2156229523 * get_address_of_rightVector_7() { return &___rightVector_7; }
	inline void set_rightVector_7(Vector2_t2156229523  value)
	{
		___rightVector_7 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___positiveInfinityVector_8)); }
	inline Vector2_t2156229523  get_positiveInfinityVector_8() const { return ___positiveInfinityVector_8; }
	inline Vector2_t2156229523 * get_address_of_positiveInfinityVector_8() { return &___positiveInfinityVector_8; }
	inline void set_positiveInfinityVector_8(Vector2_t2156229523  value)
	{
		___positiveInfinityVector_8 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_9() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___negativeInfinityVector_9)); }
	inline Vector2_t2156229523  get_negativeInfinityVector_9() const { return ___negativeInfinityVector_9; }
	inline Vector2_t2156229523 * get_address_of_negativeInfinityVector_9() { return &___negativeInfinityVector_9; }
	inline void set_negativeInfinityVector_9(Vector2_t2156229523  value)
	{
		___negativeInfinityVector_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VECTOR2_T2156229523_H
#ifndef INT32_T2950945753_H
#define INT32_T2950945753_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Int32
struct  Int32_t2950945753 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_2;

public:
	inline static int32_t get_offset_of_m_value_2() { return static_cast<int32_t>(offsetof(Int32_t2950945753, ___m_value_2)); }
	inline int32_t get_m_value_2() const { return ___m_value_2; }
	inline int32_t* get_address_of_m_value_2() { return &___m_value_2; }
	inline void set_m_value_2(int32_t value)
	{
		___m_value_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INT32_T2950945753_H
#ifndef VOID_T1185182177_H
#define VOID_T1185182177_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Void
struct  Void_t1185182177 
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VOID_T1185182177_H
#ifndef BOOLEAN_T97287965_H
#define BOOLEAN_T97287965_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Boolean
struct  Boolean_t97287965 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_2;

public:
	inline static int32_t get_offset_of_m_value_2() { return static_cast<int32_t>(offsetof(Boolean_t97287965, ___m_value_2)); }
	inline bool get_m_value_2() const { return ___m_value_2; }
	inline bool* get_address_of_m_value_2() { return &___m_value_2; }
	inline void set_m_value_2(bool value)
	{
		___m_value_2 = value;
	}
};

struct Boolean_t97287965_StaticFields
{
public:
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_0;
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_1;

public:
	inline static int32_t get_offset_of_FalseString_0() { return static_cast<int32_t>(offsetof(Boolean_t97287965_StaticFields, ___FalseString_0)); }
	inline String_t* get_FalseString_0() const { return ___FalseString_0; }
	inline String_t** get_address_of_FalseString_0() { return &___FalseString_0; }
	inline void set_FalseString_0(String_t* value)
	{
		___FalseString_0 = value;
		Il2CppCodeGenWriteBarrier((&___FalseString_0), value);
	}

	inline static int32_t get_offset_of_TrueString_1() { return static_cast<int32_t>(offsetof(Boolean_t97287965_StaticFields, ___TrueString_1)); }
	inline String_t* get_TrueString_1() const { return ___TrueString_1; }
	inline String_t** get_address_of_TrueString_1() { return &___TrueString_1; }
	inline void set_TrueString_1(String_t* value)
	{
		___TrueString_1 = value;
		Il2CppCodeGenWriteBarrier((&___TrueString_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BOOLEAN_T97287965_H
#ifndef INTPTR_T_H
#define INTPTR_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INTPTR_T_H
#ifndef VECTOR3_T3722313464_H
#define VECTOR3_T3722313464_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Vector3
struct  Vector3_t3722313464 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_1;
	// System.Single UnityEngine.Vector3::y
	float ___y_2;
	// System.Single UnityEngine.Vector3::z
	float ___z_3;

public:
	inline static int32_t get_offset_of_x_1() { return static_cast<int32_t>(offsetof(Vector3_t3722313464, ___x_1)); }
	inline float get_x_1() const { return ___x_1; }
	inline float* get_address_of_x_1() { return &___x_1; }
	inline void set_x_1(float value)
	{
		___x_1 = value;
	}

	inline static int32_t get_offset_of_y_2() { return static_cast<int32_t>(offsetof(Vector3_t3722313464, ___y_2)); }
	inline float get_y_2() const { return ___y_2; }
	inline float* get_address_of_y_2() { return &___y_2; }
	inline void set_y_2(float value)
	{
		___y_2 = value;
	}

	inline static int32_t get_offset_of_z_3() { return static_cast<int32_t>(offsetof(Vector3_t3722313464, ___z_3)); }
	inline float get_z_3() const { return ___z_3; }
	inline float* get_address_of_z_3() { return &___z_3; }
	inline void set_z_3(float value)
	{
		___z_3 = value;
	}
};

struct Vector3_t3722313464_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t3722313464  ___zeroVector_4;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t3722313464  ___oneVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t3722313464  ___upVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t3722313464  ___downVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t3722313464  ___leftVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t3722313464  ___rightVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t3722313464  ___forwardVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t3722313464  ___backVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t3722313464  ___positiveInfinityVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t3722313464  ___negativeInfinityVector_13;

public:
	inline static int32_t get_offset_of_zeroVector_4() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___zeroVector_4)); }
	inline Vector3_t3722313464  get_zeroVector_4() const { return ___zeroVector_4; }
	inline Vector3_t3722313464 * get_address_of_zeroVector_4() { return &___zeroVector_4; }
	inline void set_zeroVector_4(Vector3_t3722313464  value)
	{
		___zeroVector_4 = value;
	}

	inline static int32_t get_offset_of_oneVector_5() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___oneVector_5)); }
	inline Vector3_t3722313464  get_oneVector_5() const { return ___oneVector_5; }
	inline Vector3_t3722313464 * get_address_of_oneVector_5() { return &___oneVector_5; }
	inline void set_oneVector_5(Vector3_t3722313464  value)
	{
		___oneVector_5 = value;
	}

	inline static int32_t get_offset_of_upVector_6() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___upVector_6)); }
	inline Vector3_t3722313464  get_upVector_6() const { return ___upVector_6; }
	inline Vector3_t3722313464 * get_address_of_upVector_6() { return &___upVector_6; }
	inline void set_upVector_6(Vector3_t3722313464  value)
	{
		___upVector_6 = value;
	}

	inline static int32_t get_offset_of_downVector_7() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___downVector_7)); }
	inline Vector3_t3722313464  get_downVector_7() const { return ___downVector_7; }
	inline Vector3_t3722313464 * get_address_of_downVector_7() { return &___downVector_7; }
	inline void set_downVector_7(Vector3_t3722313464  value)
	{
		___downVector_7 = value;
	}

	inline static int32_t get_offset_of_leftVector_8() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___leftVector_8)); }
	inline Vector3_t3722313464  get_leftVector_8() const { return ___leftVector_8; }
	inline Vector3_t3722313464 * get_address_of_leftVector_8() { return &___leftVector_8; }
	inline void set_leftVector_8(Vector3_t3722313464  value)
	{
		___leftVector_8 = value;
	}

	inline static int32_t get_offset_of_rightVector_9() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___rightVector_9)); }
	inline Vector3_t3722313464  get_rightVector_9() const { return ___rightVector_9; }
	inline Vector3_t3722313464 * get_address_of_rightVector_9() { return &___rightVector_9; }
	inline void set_rightVector_9(Vector3_t3722313464  value)
	{
		___rightVector_9 = value;
	}

	inline static int32_t get_offset_of_forwardVector_10() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___forwardVector_10)); }
	inline Vector3_t3722313464  get_forwardVector_10() const { return ___forwardVector_10; }
	inline Vector3_t3722313464 * get_address_of_forwardVector_10() { return &___forwardVector_10; }
	inline void set_forwardVector_10(Vector3_t3722313464  value)
	{
		___forwardVector_10 = value;
	}

	inline static int32_t get_offset_of_backVector_11() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___backVector_11)); }
	inline Vector3_t3722313464  get_backVector_11() const { return ___backVector_11; }
	inline Vector3_t3722313464 * get_address_of_backVector_11() { return &___backVector_11; }
	inline void set_backVector_11(Vector3_t3722313464  value)
	{
		___backVector_11 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_12() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___positiveInfinityVector_12)); }
	inline Vector3_t3722313464  get_positiveInfinityVector_12() const { return ___positiveInfinityVector_12; }
	inline Vector3_t3722313464 * get_address_of_positiveInfinityVector_12() { return &___positiveInfinityVector_12; }
	inline void set_positiveInfinityVector_12(Vector3_t3722313464  value)
	{
		___positiveInfinityVector_12 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___negativeInfinityVector_13)); }
	inline Vector3_t3722313464  get_negativeInfinityVector_13() const { return ___negativeInfinityVector_13; }
	inline Vector3_t3722313464 * get_address_of_negativeInfinityVector_13() { return &___negativeInfinityVector_13; }
	inline void set_negativeInfinityVector_13(Vector3_t3722313464  value)
	{
		___negativeInfinityVector_13 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VECTOR3_T3722313464_H
#ifndef SINGLE_T1397266774_H
#define SINGLE_T1397266774_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Single
struct  Single_t1397266774 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_7;

public:
	inline static int32_t get_offset_of_m_value_7() { return static_cast<int32_t>(offsetof(Single_t1397266774, ___m_value_7)); }
	inline float get_m_value_7() const { return ___m_value_7; }
	inline float* get_address_of_m_value_7() { return &___m_value_7; }
	inline void set_m_value_7(float value)
	{
		___m_value_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SINGLE_T1397266774_H
#ifndef ENUM_T4135868527_H
#define ENUM_T4135868527_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Enum
struct  Enum_t4135868527  : public ValueType_t3640485471
{
public:

public:
};

struct Enum_t4135868527_StaticFields
{
public:
	// System.Char[] System.Enum::split_char
	CharU5BU5D_t3528271667* ___split_char_0;

public:
	inline static int32_t get_offset_of_split_char_0() { return static_cast<int32_t>(offsetof(Enum_t4135868527_StaticFields, ___split_char_0)); }
	inline CharU5BU5D_t3528271667* get_split_char_0() const { return ___split_char_0; }
	inline CharU5BU5D_t3528271667** get_address_of_split_char_0() { return &___split_char_0; }
	inline void set_split_char_0(CharU5BU5D_t3528271667* value)
	{
		___split_char_0 = value;
		Il2CppCodeGenWriteBarrier((&___split_char_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t4135868527_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t4135868527_marshaled_com
{
};
#endif // ENUM_T4135868527_H
#ifndef OBJECT_T631007953_H
#define OBJECT_T631007953_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Object
struct  Object_t631007953  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_t631007953, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_t631007953_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_t631007953_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_t631007953_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_t631007953_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};
#endif // OBJECT_T631007953_H
#ifndef SECTIONTYPE_T4049925526_H
#define SECTIONTYPE_T4049925526_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SectionType
struct  SectionType_t4049925526 
{
public:
	// System.Int32 SectionType::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(SectionType_t4049925526, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SECTIONTYPE_T4049925526_H
#ifndef DELEGATE_T1188392813_H
#define DELEGATE_T1188392813_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Delegate
struct  Delegate_t1188392813  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_5;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_6;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_7;
	// System.DelegateData System.Delegate::data
	DelegateData_t1677132599 * ___data_8;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((&___m_target_2), value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_method_code_5() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_code_5)); }
	inline intptr_t get_method_code_5() const { return ___method_code_5; }
	inline intptr_t* get_address_of_method_code_5() { return &___method_code_5; }
	inline void set_method_code_5(intptr_t value)
	{
		___method_code_5 = value;
	}

	inline static int32_t get_offset_of_method_info_6() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_info_6)); }
	inline MethodInfo_t * get_method_info_6() const { return ___method_info_6; }
	inline MethodInfo_t ** get_address_of_method_info_6() { return &___method_info_6; }
	inline void set_method_info_6(MethodInfo_t * value)
	{
		___method_info_6 = value;
		Il2CppCodeGenWriteBarrier((&___method_info_6), value);
	}

	inline static int32_t get_offset_of_original_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___original_method_info_7)); }
	inline MethodInfo_t * get_original_method_info_7() const { return ___original_method_info_7; }
	inline MethodInfo_t ** get_address_of_original_method_info_7() { return &___original_method_info_7; }
	inline void set_original_method_info_7(MethodInfo_t * value)
	{
		___original_method_info_7 = value;
		Il2CppCodeGenWriteBarrier((&___original_method_info_7), value);
	}

	inline static int32_t get_offset_of_data_8() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___data_8)); }
	inline DelegateData_t1677132599 * get_data_8() const { return ___data_8; }
	inline DelegateData_t1677132599 ** get_address_of_data_8() { return &___data_8; }
	inline void set_data_8(DelegateData_t1677132599 * value)
	{
		___data_8 = value;
		Il2CppCodeGenWriteBarrier((&___data_8), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DELEGATE_T1188392813_H
#ifndef SPACE_T654135784_H
#define SPACE_T654135784_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Space
struct  Space_t654135784 
{
public:
	// System.Int32 UnityEngine.Space::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(Space_t654135784, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SPACE_T654135784_H
#ifndef MULTICASTDELEGATE_T_H
#define MULTICASTDELEGATE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.MulticastDelegate
struct  MulticastDelegate_t  : public Delegate_t1188392813
{
public:
	// System.MulticastDelegate System.MulticastDelegate::prev
	MulticastDelegate_t * ___prev_9;
	// System.MulticastDelegate System.MulticastDelegate::kpm_next
	MulticastDelegate_t * ___kpm_next_10;

public:
	inline static int32_t get_offset_of_prev_9() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___prev_9)); }
	inline MulticastDelegate_t * get_prev_9() const { return ___prev_9; }
	inline MulticastDelegate_t ** get_address_of_prev_9() { return &___prev_9; }
	inline void set_prev_9(MulticastDelegate_t * value)
	{
		___prev_9 = value;
		Il2CppCodeGenWriteBarrier((&___prev_9), value);
	}

	inline static int32_t get_offset_of_kpm_next_10() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___kpm_next_10)); }
	inline MulticastDelegate_t * get_kpm_next_10() const { return ___kpm_next_10; }
	inline MulticastDelegate_t ** get_address_of_kpm_next_10() { return &___kpm_next_10; }
	inline void set_kpm_next_10(MulticastDelegate_t * value)
	{
		___kpm_next_10 = value;
		Il2CppCodeGenWriteBarrier((&___kpm_next_10), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULTICASTDELEGATE_T_H
#ifndef GAMEOBJECT_T1113636619_H
#define GAMEOBJECT_T1113636619_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.GameObject
struct  GameObject_t1113636619  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // GAMEOBJECT_T1113636619_H
#ifndef COMPONENT_T1923634451_H
#define COMPONENT_T1923634451_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Component
struct  Component_t1923634451  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COMPONENT_T1923634451_H
#ifndef SECTION_T1829303744_H
#define SECTION_T1829303744_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// EventManager/Section
struct  Section_t1829303744  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SECTION_T1829303744_H
#ifndef COLLIDER_T1773347010_H
#define COLLIDER_T1773347010_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Collider
struct  Collider_t1773347010  : public Component_t1923634451
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COLLIDER_T1773347010_H
#ifndef ASYNCCALLBACK_T3962456242_H
#define ASYNCCALLBACK_T3962456242_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.AsyncCallback
struct  AsyncCallback_t3962456242  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ASYNCCALLBACK_T3962456242_H
#ifndef BEHAVIOUR_T1437897464_H
#define BEHAVIOUR_T1437897464_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Behaviour
struct  Behaviour_t1437897464  : public Component_t1923634451
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BEHAVIOUR_T1437897464_H
#ifndef TRANSFORM_T3600365921_H
#define TRANSFORM_T3600365921_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Transform
struct  Transform_t3600365921  : public Component_t1923634451
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TRANSFORM_T3600365921_H
#ifndef MONOBEHAVIOUR_T3962482529_H
#define MONOBEHAVIOUR_T3962482529_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.MonoBehaviour
struct  MonoBehaviour_t3962482529  : public Behaviour_t1437897464
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MONOBEHAVIOUR_T3962482529_H
#ifndef CAMERA_T4157153871_H
#define CAMERA_T4157153871_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Camera
struct  Camera_t4157153871  : public Behaviour_t1437897464
{
public:

public:
};

struct Camera_t4157153871_StaticFields
{
public:
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreCull
	CameraCallback_t190067161 * ___onPreCull_2;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreRender
	CameraCallback_t190067161 * ___onPreRender_3;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPostRender
	CameraCallback_t190067161 * ___onPostRender_4;

public:
	inline static int32_t get_offset_of_onPreCull_2() { return static_cast<int32_t>(offsetof(Camera_t4157153871_StaticFields, ___onPreCull_2)); }
	inline CameraCallback_t190067161 * get_onPreCull_2() const { return ___onPreCull_2; }
	inline CameraCallback_t190067161 ** get_address_of_onPreCull_2() { return &___onPreCull_2; }
	inline void set_onPreCull_2(CameraCallback_t190067161 * value)
	{
		___onPreCull_2 = value;
		Il2CppCodeGenWriteBarrier((&___onPreCull_2), value);
	}

	inline static int32_t get_offset_of_onPreRender_3() { return static_cast<int32_t>(offsetof(Camera_t4157153871_StaticFields, ___onPreRender_3)); }
	inline CameraCallback_t190067161 * get_onPreRender_3() const { return ___onPreRender_3; }
	inline CameraCallback_t190067161 ** get_address_of_onPreRender_3() { return &___onPreRender_3; }
	inline void set_onPreRender_3(CameraCallback_t190067161 * value)
	{
		___onPreRender_3 = value;
		Il2CppCodeGenWriteBarrier((&___onPreRender_3), value);
	}

	inline static int32_t get_offset_of_onPostRender_4() { return static_cast<int32_t>(offsetof(Camera_t4157153871_StaticFields, ___onPostRender_4)); }
	inline CameraCallback_t190067161 * get_onPostRender_4() const { return ___onPostRender_4; }
	inline CameraCallback_t190067161 ** get_address_of_onPostRender_4() { return &___onPostRender_4; }
	inline void set_onPostRender_4(CameraCallback_t190067161 * value)
	{
		___onPostRender_4 = value;
		Il2CppCodeGenWriteBarrier((&___onPostRender_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CAMERA_T4157153871_H
#ifndef CAR_T2395504951_H
#define CAR_T2395504951_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Car
struct  Car_t2395504951  : public MonoBehaviour_t3962482529
{
public:
	// UnityEngine.Vector3 Car::targetPosition
	Vector3_t3722313464  ___targetPosition_2;
	// System.Boolean Car::move
	bool ___move_3;
	// System.Int32 Car::direction
	int32_t ___direction_4;
	// System.Single Car::CarSpeed
	float ___CarSpeed_5;

public:
	inline static int32_t get_offset_of_targetPosition_2() { return static_cast<int32_t>(offsetof(Car_t2395504951, ___targetPosition_2)); }
	inline Vector3_t3722313464  get_targetPosition_2() const { return ___targetPosition_2; }
	inline Vector3_t3722313464 * get_address_of_targetPosition_2() { return &___targetPosition_2; }
	inline void set_targetPosition_2(Vector3_t3722313464  value)
	{
		___targetPosition_2 = value;
	}

	inline static int32_t get_offset_of_move_3() { return static_cast<int32_t>(offsetof(Car_t2395504951, ___move_3)); }
	inline bool get_move_3() const { return ___move_3; }
	inline bool* get_address_of_move_3() { return &___move_3; }
	inline void set_move_3(bool value)
	{
		___move_3 = value;
	}

	inline static int32_t get_offset_of_direction_4() { return static_cast<int32_t>(offsetof(Car_t2395504951, ___direction_4)); }
	inline int32_t get_direction_4() const { return ___direction_4; }
	inline int32_t* get_address_of_direction_4() { return &___direction_4; }
	inline void set_direction_4(int32_t value)
	{
		___direction_4 = value;
	}

	inline static int32_t get_offset_of_CarSpeed_5() { return static_cast<int32_t>(offsetof(Car_t2395504951, ___CarSpeed_5)); }
	inline float get_CarSpeed_5() const { return ___CarSpeed_5; }
	inline float* get_address_of_CarSpeed_5() { return &___CarSpeed_5; }
	inline void set_CarSpeed_5(float value)
	{
		___CarSpeed_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CAR_T2395504951_H
#ifndef GAMECONTROLLER_T2330501625_H
#define GAMECONTROLLER_T2330501625_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameController
struct  GameController_t2330501625  : public MonoBehaviour_t3962482529
{
public:
	// UnityEngine.GameObject GameController::Dummy
	GameObject_t1113636619 * ___Dummy_2;

public:
	inline static int32_t get_offset_of_Dummy_2() { return static_cast<int32_t>(offsetof(GameController_t2330501625, ___Dummy_2)); }
	inline GameObject_t1113636619 * get_Dummy_2() const { return ___Dummy_2; }
	inline GameObject_t1113636619 ** get_address_of_Dummy_2() { return &___Dummy_2; }
	inline void set_Dummy_2(GameObject_t1113636619 * value)
	{
		___Dummy_2 = value;
		Il2CppCodeGenWriteBarrier((&___Dummy_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // GAMECONTROLLER_T2330501625_H
#ifndef APPRESOURCES_T1237449672_H
#define APPRESOURCES_T1237449672_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// AppResources
struct  AppResources_t1237449672  : public MonoBehaviour_t3962482529
{
public:

public:
};

struct AppResources_t1237449672_StaticFields
{
public:
	// UnityEngine.GameObject AppResources::Section_1
	GameObject_t1113636619 * ___Section_1_2;
	// UnityEngine.GameObject AppResources::Section_2
	GameObject_t1113636619 * ___Section_2_3;
	// UnityEngine.GameObject AppResources::Section_3
	GameObject_t1113636619 * ___Section_3_4;
	// UnityEngine.GameObject AppResources::Car
	GameObject_t1113636619 * ___Car_5;

public:
	inline static int32_t get_offset_of_Section_1_2() { return static_cast<int32_t>(offsetof(AppResources_t1237449672_StaticFields, ___Section_1_2)); }
	inline GameObject_t1113636619 * get_Section_1_2() const { return ___Section_1_2; }
	inline GameObject_t1113636619 ** get_address_of_Section_1_2() { return &___Section_1_2; }
	inline void set_Section_1_2(GameObject_t1113636619 * value)
	{
		___Section_1_2 = value;
		Il2CppCodeGenWriteBarrier((&___Section_1_2), value);
	}

	inline static int32_t get_offset_of_Section_2_3() { return static_cast<int32_t>(offsetof(AppResources_t1237449672_StaticFields, ___Section_2_3)); }
	inline GameObject_t1113636619 * get_Section_2_3() const { return ___Section_2_3; }
	inline GameObject_t1113636619 ** get_address_of_Section_2_3() { return &___Section_2_3; }
	inline void set_Section_2_3(GameObject_t1113636619 * value)
	{
		___Section_2_3 = value;
		Il2CppCodeGenWriteBarrier((&___Section_2_3), value);
	}

	inline static int32_t get_offset_of_Section_3_4() { return static_cast<int32_t>(offsetof(AppResources_t1237449672_StaticFields, ___Section_3_4)); }
	inline GameObject_t1113636619 * get_Section_3_4() const { return ___Section_3_4; }
	inline GameObject_t1113636619 ** get_address_of_Section_3_4() { return &___Section_3_4; }
	inline void set_Section_3_4(GameObject_t1113636619 * value)
	{
		___Section_3_4 = value;
		Il2CppCodeGenWriteBarrier((&___Section_3_4), value);
	}

	inline static int32_t get_offset_of_Car_5() { return static_cast<int32_t>(offsetof(AppResources_t1237449672_StaticFields, ___Car_5)); }
	inline GameObject_t1113636619 * get_Car_5() const { return ___Car_5; }
	inline GameObject_t1113636619 ** get_address_of_Car_5() { return &___Car_5; }
	inline void set_Car_5(GameObject_t1113636619 * value)
	{
		___Car_5 = value;
		Il2CppCodeGenWriteBarrier((&___Car_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // APPRESOURCES_T1237449672_H
#ifndef GAMEINPUT_T4178564210_H
#define GAMEINPUT_T4178564210_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameInput
struct  GameInput_t4178564210  : public MonoBehaviour_t3962482529
{
public:
	// System.Single GameInput::targetVelocity
	float ___targetVelocity_2;
	// System.Single GameInput::vel
	float ___vel_3;
	// System.Single GameInput::rate
	float ___rate_4;
	// System.Single GameInput::velocity
	float ___velocity_5;
	// System.Single GameInput::acc
	float ___acc_6;
	// System.Boolean GameInput::pressed
	bool ___pressed_7;
	// UnityEngine.Vector2 GameInput::currentPosition
	Vector2_t2156229523  ___currentPosition_8;
	// UnityEngine.Vector2 GameInput::lastPosition
	Vector2_t2156229523  ___lastPosition_9;
	// System.Single GameInput::rot
	float ___rot_10;
	// System.Single GameInput::senstivity
	float ___senstivity_11;

public:
	inline static int32_t get_offset_of_targetVelocity_2() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___targetVelocity_2)); }
	inline float get_targetVelocity_2() const { return ___targetVelocity_2; }
	inline float* get_address_of_targetVelocity_2() { return &___targetVelocity_2; }
	inline void set_targetVelocity_2(float value)
	{
		___targetVelocity_2 = value;
	}

	inline static int32_t get_offset_of_vel_3() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___vel_3)); }
	inline float get_vel_3() const { return ___vel_3; }
	inline float* get_address_of_vel_3() { return &___vel_3; }
	inline void set_vel_3(float value)
	{
		___vel_3 = value;
	}

	inline static int32_t get_offset_of_rate_4() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___rate_4)); }
	inline float get_rate_4() const { return ___rate_4; }
	inline float* get_address_of_rate_4() { return &___rate_4; }
	inline void set_rate_4(float value)
	{
		___rate_4 = value;
	}

	inline static int32_t get_offset_of_velocity_5() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___velocity_5)); }
	inline float get_velocity_5() const { return ___velocity_5; }
	inline float* get_address_of_velocity_5() { return &___velocity_5; }
	inline void set_velocity_5(float value)
	{
		___velocity_5 = value;
	}

	inline static int32_t get_offset_of_acc_6() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___acc_6)); }
	inline float get_acc_6() const { return ___acc_6; }
	inline float* get_address_of_acc_6() { return &___acc_6; }
	inline void set_acc_6(float value)
	{
		___acc_6 = value;
	}

	inline static int32_t get_offset_of_pressed_7() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___pressed_7)); }
	inline bool get_pressed_7() const { return ___pressed_7; }
	inline bool* get_address_of_pressed_7() { return &___pressed_7; }
	inline void set_pressed_7(bool value)
	{
		___pressed_7 = value;
	}

	inline static int32_t get_offset_of_currentPosition_8() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___currentPosition_8)); }
	inline Vector2_t2156229523  get_currentPosition_8() const { return ___currentPosition_8; }
	inline Vector2_t2156229523 * get_address_of_currentPosition_8() { return &___currentPosition_8; }
	inline void set_currentPosition_8(Vector2_t2156229523  value)
	{
		___currentPosition_8 = value;
	}

	inline static int32_t get_offset_of_lastPosition_9() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___lastPosition_9)); }
	inline Vector2_t2156229523  get_lastPosition_9() const { return ___lastPosition_9; }
	inline Vector2_t2156229523 * get_address_of_lastPosition_9() { return &___lastPosition_9; }
	inline void set_lastPosition_9(Vector2_t2156229523  value)
	{
		___lastPosition_9 = value;
	}

	inline static int32_t get_offset_of_rot_10() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___rot_10)); }
	inline float get_rot_10() const { return ___rot_10; }
	inline float* get_address_of_rot_10() { return &___rot_10; }
	inline void set_rot_10(float value)
	{
		___rot_10 = value;
	}

	inline static int32_t get_offset_of_senstivity_11() { return static_cast<int32_t>(offsetof(GameInput_t4178564210, ___senstivity_11)); }
	inline float get_senstivity_11() const { return ___senstivity_11; }
	inline float* get_address_of_senstivity_11() { return &___senstivity_11; }
	inline void set_senstivity_11(float value)
	{
		___senstivity_11 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // GAMEINPUT_T4178564210_H
#ifndef SECTION_T3531603569_H
#define SECTION_T3531603569_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Section
struct  Section_t3531603569  : public MonoBehaviour_t3962482529
{
public:
	// UnityEngine.Transform Section::StartConnector
	Transform_t3600365921 * ___StartConnector_3;
	// UnityEngine.Transform Section::EndConnector
	Transform_t3600365921 * ___EndConnector_4;
	// SectionType Section::type
	int32_t ___type_5;
	// System.Boolean Section::move
	bool ___move_6;
	// SectionContainer Section::sectionContainer
	SectionContainer_t1774584350 * ___sectionContainer_8;
	// Section Section::attachedSection
	Section_t3531603569 * ___attachedSection_9;
	// Section Section::connectedSection
	Section_t3531603569 * ___connectedSection_10;
	// UnityEngine.GameObject Section::Buildings
	GameObject_t1113636619 * ___Buildings_11;

public:
	inline static int32_t get_offset_of_StartConnector_3() { return static_cast<int32_t>(offsetof(Section_t3531603569, ___StartConnector_3)); }
	inline Transform_t3600365921 * get_StartConnector_3() const { return ___StartConnector_3; }
	inline Transform_t3600365921 ** get_address_of_StartConnector_3() { return &___StartConnector_3; }
	inline void set_StartConnector_3(Transform_t3600365921 * value)
	{
		___StartConnector_3 = value;
		Il2CppCodeGenWriteBarrier((&___StartConnector_3), value);
	}

	inline static int32_t get_offset_of_EndConnector_4() { return static_cast<int32_t>(offsetof(Section_t3531603569, ___EndConnector_4)); }
	inline Transform_t3600365921 * get_EndConnector_4() const { return ___EndConnector_4; }
	inline Transform_t3600365921 ** get_address_of_EndConnector_4() { return &___EndConnector_4; }
	inline void set_EndConnector_4(Transform_t3600365921 * value)
	{
		___EndConnector_4 = value;
		Il2CppCodeGenWriteBarrier((&___EndConnector_4), value);
	}

	inline static int32_t get_offset_of_type_5() { return static_cast<int32_t>(offsetof(Section_t3531603569, ___type_5)); }
	inline int32_t get_type_5() const { return ___type_5; }
	inline int32_t* get_address_of_type_5() { return &___type_5; }
	inline void set_type_5(int32_t value)
	{
		___type_5 = value;
	}

	inline static int32_t get_offset_of_move_6() { return static_cast<int32_t>(offsetof(Section_t3531603569, ___move_6)); }
	inline bool get_move_6() const { return ___move_6; }
	inline bool* get_address_of_move_6() { return &___move_6; }
	inline void set_move_6(bool value)
	{
		___move_6 = value;
	}

	inline static int32_t get_offset_of_sectionContainer_8() { return static_cast<int32_t>(offsetof(Section_t3531603569, ___sectionContainer_8)); }
	inline SectionContainer_t1774584350 * get_sectionContainer_8() const { return ___sectionContainer_8; }
	inline SectionContainer_t1774584350 ** get_address_of_sectionContainer_8() { return &___sectionContainer_8; }
	inline void set_sectionContainer_8(SectionContainer_t1774584350 * value)
	{
		___sectionContainer_8 = value;
		Il2CppCodeGenWriteBarrier((&___sectionContainer_8), value);
	}

	inline static int32_t get_offset_of_attachedSection_9() { return static_cast<int32_t>(offsetof(Section_t3531603569, ___attachedSection_9)); }
	inline Section_t3531603569 * get_attachedSection_9() const { return ___attachedSection_9; }
	inline Section_t3531603569 ** get_address_of_attachedSection_9() { return &___attachedSection_9; }
	inline void set_attachedSection_9(Section_t3531603569 * value)
	{
		___attachedSection_9 = value;
		Il2CppCodeGenWriteBarrier((&___attachedSection_9), value);
	}

	inline static int32_t get_offset_of_connectedSection_10() { return static_cast<int32_t>(offsetof(Section_t3531603569, ___connectedSection_10)); }
	inline Section_t3531603569 * get_connectedSection_10() const { return ___connectedSection_10; }
	inline Section_t3531603569 ** get_address_of_connectedSection_10() { return &___connectedSection_10; }
	inline void set_connectedSection_10(Section_t3531603569 * value)
	{
		___connectedSection_10 = value;
		Il2CppCodeGenWriteBarrier((&___connectedSection_10), value);
	}

	inline static int32_t get_offset_of_Buildings_11() { return static_cast<int32_t>(offsetof(Section_t3531603569, ___Buildings_11)); }
	inline GameObject_t1113636619 * get_Buildings_11() const { return ___Buildings_11; }
	inline GameObject_t1113636619 ** get_address_of_Buildings_11() { return &___Buildings_11; }
	inline void set_Buildings_11(GameObject_t1113636619 * value)
	{
		___Buildings_11 = value;
		Il2CppCodeGenWriteBarrier((&___Buildings_11), value);
	}
};

struct Section_t3531603569_StaticFields
{
public:
	// System.Single Section::VELOCITY
	float ___VELOCITY_2;
	// System.Boolean Section::EnalbedProps
	bool ___EnalbedProps_7;

public:
	inline static int32_t get_offset_of_VELOCITY_2() { return static_cast<int32_t>(offsetof(Section_t3531603569_StaticFields, ___VELOCITY_2)); }
	inline float get_VELOCITY_2() const { return ___VELOCITY_2; }
	inline float* get_address_of_VELOCITY_2() { return &___VELOCITY_2; }
	inline void set_VELOCITY_2(float value)
	{
		___VELOCITY_2 = value;
	}

	inline static int32_t get_offset_of_EnalbedProps_7() { return static_cast<int32_t>(offsetof(Section_t3531603569_StaticFields, ___EnalbedProps_7)); }
	inline bool get_EnalbedProps_7() const { return ___EnalbedProps_7; }
	inline bool* get_address_of_EnalbedProps_7() { return &___EnalbedProps_7; }
	inline void set_EnalbedProps_7(bool value)
	{
		___EnalbedProps_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SECTION_T3531603569_H
#ifndef SECTIONCONTAINER_T1774584350_H
#define SECTIONCONTAINER_T1774584350_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SectionContainer
struct  SectionContainer_t1774584350  : public MonoBehaviour_t3962482529
{
public:
	// UnityEngine.Transform SectionContainer::reservedTransform
	Transform_t3600365921 * ___reservedTransform_4;
	// Section SectionContainer::lastReservedSection
	Section_t3531603569 * ___lastReservedSection_5;
	// System.Int32 SectionContainer::defaultActive
	int32_t ___defaultActive_6;
	// System.Int32 SectionContainer::sectionCount
	int32_t ___sectionCount_7;

public:
	inline static int32_t get_offset_of_reservedTransform_4() { return static_cast<int32_t>(offsetof(SectionContainer_t1774584350, ___reservedTransform_4)); }
	inline Transform_t3600365921 * get_reservedTransform_4() const { return ___reservedTransform_4; }
	inline Transform_t3600365921 ** get_address_of_reservedTransform_4() { return &___reservedTransform_4; }
	inline void set_reservedTransform_4(Transform_t3600365921 * value)
	{
		___reservedTransform_4 = value;
		Il2CppCodeGenWriteBarrier((&___reservedTransform_4), value);
	}

	inline static int32_t get_offset_of_lastReservedSection_5() { return static_cast<int32_t>(offsetof(SectionContainer_t1774584350, ___lastReservedSection_5)); }
	inline Section_t3531603569 * get_lastReservedSection_5() const { return ___lastReservedSection_5; }
	inline Section_t3531603569 ** get_address_of_lastReservedSection_5() { return &___lastReservedSection_5; }
	inline void set_lastReservedSection_5(Section_t3531603569 * value)
	{
		___lastReservedSection_5 = value;
		Il2CppCodeGenWriteBarrier((&___lastReservedSection_5), value);
	}

	inline static int32_t get_offset_of_defaultActive_6() { return static_cast<int32_t>(offsetof(SectionContainer_t1774584350, ___defaultActive_6)); }
	inline int32_t get_defaultActive_6() const { return ___defaultActive_6; }
	inline int32_t* get_address_of_defaultActive_6() { return &___defaultActive_6; }
	inline void set_defaultActive_6(int32_t value)
	{
		___defaultActive_6 = value;
	}

	inline static int32_t get_offset_of_sectionCount_7() { return static_cast<int32_t>(offsetof(SectionContainer_t1774584350, ___sectionCount_7)); }
	inline int32_t get_sectionCount_7() const { return ___sectionCount_7; }
	inline int32_t* get_address_of_sectionCount_7() { return &___sectionCount_7; }
	inline void set_sectionCount_7(int32_t value)
	{
		___sectionCount_7 = value;
	}
};

struct SectionContainer_t1774584350_StaticFields
{
public:
	// System.Collections.Generic.List`1<Section> SectionContainer::sections
	List_1_t708711015 * ___sections_2;
	// System.Collections.Generic.List`1<Section> SectionContainer::generated
	List_1_t708711015 * ___generated_3;

public:
	inline static int32_t get_offset_of_sections_2() { return static_cast<int32_t>(offsetof(SectionContainer_t1774584350_StaticFields, ___sections_2)); }
	inline List_1_t708711015 * get_sections_2() const { return ___sections_2; }
	inline List_1_t708711015 ** get_address_of_sections_2() { return &___sections_2; }
	inline void set_sections_2(List_1_t708711015 * value)
	{
		___sections_2 = value;
		Il2CppCodeGenWriteBarrier((&___sections_2), value);
	}

	inline static int32_t get_offset_of_generated_3() { return static_cast<int32_t>(offsetof(SectionContainer_t1774584350_StaticFields, ___generated_3)); }
	inline List_1_t708711015 * get_generated_3() const { return ___generated_3; }
	inline List_1_t708711015 ** get_address_of_generated_3() { return &___generated_3; }
	inline void set_generated_3(List_1_t708711015 * value)
	{
		___generated_3 = value;
		Il2CppCodeGenWriteBarrier((&___generated_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SECTIONCONTAINER_T1774584350_H
#ifndef CARSTREAM_T2397564518_H
#define CARSTREAM_T2397564518_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CarStream
struct  CarStream_t2397564518  : public MonoBehaviour_t3962482529
{
public:
	// System.Collections.Generic.List`1<UnityEngine.Transform> CarStream::cars
	List_1_t777473367 * ___cars_2;
	// System.Single CarStream::timer
	float ___timer_3;
	// System.Int32 CarStream::currentCarIndex
	int32_t ___currentCarIndex_4;
	// System.Int32 CarStream::direction
	int32_t ___direction_5;
	// System.Single CarStream::delay
	float ___delay_6;
	// UnityEngine.Transform CarStream::stoppoint
	Transform_t3600365921 * ___stoppoint_7;
	// System.Boolean CarStream::moveCars
	bool ___moveCars_8;

public:
	inline static int32_t get_offset_of_cars_2() { return static_cast<int32_t>(offsetof(CarStream_t2397564518, ___cars_2)); }
	inline List_1_t777473367 * get_cars_2() const { return ___cars_2; }
	inline List_1_t777473367 ** get_address_of_cars_2() { return &___cars_2; }
	inline void set_cars_2(List_1_t777473367 * value)
	{
		___cars_2 = value;
		Il2CppCodeGenWriteBarrier((&___cars_2), value);
	}

	inline static int32_t get_offset_of_timer_3() { return static_cast<int32_t>(offsetof(CarStream_t2397564518, ___timer_3)); }
	inline float get_timer_3() const { return ___timer_3; }
	inline float* get_address_of_timer_3() { return &___timer_3; }
	inline void set_timer_3(float value)
	{
		___timer_3 = value;
	}

	inline static int32_t get_offset_of_currentCarIndex_4() { return static_cast<int32_t>(offsetof(CarStream_t2397564518, ___currentCarIndex_4)); }
	inline int32_t get_currentCarIndex_4() const { return ___currentCarIndex_4; }
	inline int32_t* get_address_of_currentCarIndex_4() { return &___currentCarIndex_4; }
	inline void set_currentCarIndex_4(int32_t value)
	{
		___currentCarIndex_4 = value;
	}

	inline static int32_t get_offset_of_direction_5() { return static_cast<int32_t>(offsetof(CarStream_t2397564518, ___direction_5)); }
	inline int32_t get_direction_5() const { return ___direction_5; }
	inline int32_t* get_address_of_direction_5() { return &___direction_5; }
	inline void set_direction_5(int32_t value)
	{
		___direction_5 = value;
	}

	inline static int32_t get_offset_of_delay_6() { return static_cast<int32_t>(offsetof(CarStream_t2397564518, ___delay_6)); }
	inline float get_delay_6() const { return ___delay_6; }
	inline float* get_address_of_delay_6() { return &___delay_6; }
	inline void set_delay_6(float value)
	{
		___delay_6 = value;
	}

	inline static int32_t get_offset_of_stoppoint_7() { return static_cast<int32_t>(offsetof(CarStream_t2397564518, ___stoppoint_7)); }
	inline Transform_t3600365921 * get_stoppoint_7() const { return ___stoppoint_7; }
	inline Transform_t3600365921 ** get_address_of_stoppoint_7() { return &___stoppoint_7; }
	inline void set_stoppoint_7(Transform_t3600365921 * value)
	{
		___stoppoint_7 = value;
		Il2CppCodeGenWriteBarrier((&___stoppoint_7), value);
	}

	inline static int32_t get_offset_of_moveCars_8() { return static_cast<int32_t>(offsetof(CarStream_t2397564518, ___moveCars_8)); }
	inline bool get_moveCars_8() const { return ___moveCars_8; }
	inline bool* get_address_of_moveCars_8() { return &___moveCars_8; }
	inline void set_moveCars_8(bool value)
	{
		___moveCars_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CARSTREAM_T2397564518_H
#ifndef EVENTMANAGER_T1594656820_H
#define EVENTMANAGER_T1594656820_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// EventManager
struct  EventManager_t1594656820  : public MonoBehaviour_t3962482529
{
public:

public:
};

struct EventManager_t1594656820_StaticFields
{
public:
	// EventManager/Section EventManager::OnSectionPool
	Section_t1829303744 * ___OnSectionPool_2;

public:
	inline static int32_t get_offset_of_OnSectionPool_2() { return static_cast<int32_t>(offsetof(EventManager_t1594656820_StaticFields, ___OnSectionPool_2)); }
	inline Section_t1829303744 * get_OnSectionPool_2() const { return ___OnSectionPool_2; }
	inline Section_t1829303744 ** get_address_of_OnSectionPool_2() { return &___OnSectionPool_2; }
	inline void set_OnSectionPool_2(Section_t1829303744 * value)
	{
		___OnSectionPool_2 = value;
		Il2CppCodeGenWriteBarrier((&___OnSectionPool_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EVENTMANAGER_T1594656820_H


// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
extern "C"  void List_1__ctor_m2321703786_gshared (List_1_t257213610 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Object::Instantiate<System.Object>(!!0)
extern "C"  RuntimeObject * Object_Instantiate_TisRuntimeObject_m3060171005_gshared (RuntimeObject * __this /* static, unused */, RuntimeObject * p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
extern "C"  void List_1_Add_m3338814081_gshared (List_1_t257213610 * __this, RuntimeObject * p0, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1<System.Object>::get_Item(System.Int32)
extern "C"  RuntimeObject * List_1_get_Item_m2287542950_gshared (List_1_t257213610 * __this, int32_t p0, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<System.Object>()
extern "C"  RuntimeObject * Component_GetComponent_TisRuntimeObject_m2906321015_gshared (Component_t1923634451 * __this, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.List`1<System.Object>::get_Count()
extern "C"  int32_t List_1_get_Count_m2934127733_gshared (List_1_t257213610 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Object::FindObjectOfType<System.Object>()
extern "C"  RuntimeObject * Object_FindObjectOfType_TisRuntimeObject_m2612646359_gshared (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Clear()
extern "C"  void List_1_Clear_m3697625829_gshared (List_1_t257213610 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor()
extern "C"  void List_1__ctor_m1628857705_gshared (List_1_t128053199 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1<System.Object>::Contains(!0)
extern "C"  bool List_1_Contains_m2654125393_gshared (List_1_t257213610 * __this, RuntimeObject * p0, const RuntimeMethod* method);
// !!0 UnityEngine.GameObject::GetComponent<System.Object>()
extern "C"  RuntimeObject * GameObject_GetComponent_TisRuntimeObject_m3920941149_gshared (GameObject_t1113636619 * __this, const RuntimeMethod* method);

// System.Void UnityEngine.MonoBehaviour::.ctor()
extern "C"  void MonoBehaviour__ctor_m1579109191 (MonoBehaviour_t3962482529 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Object UnityEngine.Resources::Load(System.String)
extern "C"  Object_t631007953 * Resources_Load_m3880010804 (RuntimeObject * __this /* static, unused */, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Transform UnityEngine.Component::get_transform()
extern "C"  Transform_t3600365921 * Component_get_transform_m3162698980 (Component_t1923634451 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_right()
extern "C"  Vector3_t3722313464  Vector3_get_right_m1913784872 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(System.Single,UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_op_Multiply_m2104357790 (RuntimeObject * __this /* static, unused */, float p0, Vector3_t3722313464  p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Time::get_deltaTime()
extern "C"  float Time_get_deltaTime_m372706562 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
extern "C"  Vector3_t3722313464  Vector3_op_Multiply_m3376773913 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  p0, float p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::Translate(UnityEngine.Vector3,UnityEngine.Space)
extern "C"  void Transform_Translate_m1990195114 (Transform_t3600365921 * __this, Vector3_t3722313464  p0, int32_t p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Random::Range(System.Single,System.Single)
extern "C"  float Random_Range_m2202990745 (RuntimeObject * __this /* static, unused */, float p0, float p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
extern "C"  void Vector3__ctor_m3353183577 (Vector3_t3722313464 * __this, float p0, float p1, float p2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_op_Addition_m779775034 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  p0, Vector3_t3722313464  p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
extern "C"  void Transform_set_position_m3387557959 (Transform_t3600365921 * __this, Vector3_t3722313464  p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
extern "C"  GameObject_t1113636619 * Component_get_gameObject_m442555142 (Component_t1923634451 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.GameObject::get_tag()
extern "C"  String_t* GameObject_get_tag_m3951609671 (GameObject_t1113636619 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.String::op_Equality(System.String,System.String)
extern "C"  bool String_op_Equality_m920492651 (RuntimeObject * __this /* static, unused */, String_t* p0, String_t* p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.List`1<UnityEngine.Transform>::.ctor()
#define List_1__ctor_m2885667311(__this, method) ((  void (*) (List_1_t777473367 *, const RuntimeMethod*))List_1__ctor_m2321703786_gshared)(__this, method)
// System.Void EventManager/Section::.ctor(System.Object,System.IntPtr)
extern "C"  void Section__ctor_m1197859341 (Section_t1829303744 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Delegate System.Delegate::Combine(System.Delegate,System.Delegate)
extern "C"  Delegate_t1188392813 * Delegate_Combine_m1859655160 (RuntimeObject * __this /* static, unused */, Delegate_t1188392813 * p0, Delegate_t1188392813 * p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Delegate System.Delegate::Remove(System.Delegate,System.Delegate)
extern "C"  Delegate_t1188392813 * Delegate_Remove_m334097152 (RuntimeObject * __this /* static, unused */, Delegate_t1188392813 * p0, Delegate_t1188392813 * p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void CarStream::Init()
extern "C"  void CarStream_Init_m131485731 (CarStream_t2397564518 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// !!0 UnityEngine.Object::Instantiate<UnityEngine.GameObject>(!!0)
#define Object_Instantiate_TisGameObject_t1113636619_m587845175(__this /* static, unused */, p0, method) ((  GameObject_t1113636619 * (*) (RuntimeObject * /* static, unused */, GameObject_t1113636619 *, const RuntimeMethod*))Object_Instantiate_TisRuntimeObject_m3060171005_gshared)(__this /* static, unused */, p0, method)
// UnityEngine.Transform UnityEngine.GameObject::get_transform()
extern "C"  Transform_t3600365921 * GameObject_get_transform_m1369836730 (GameObject_t1113636619 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::SetParent(UnityEngine.Transform)
extern "C"  void Transform_SetParent_m381167889 (Transform_t3600365921 * __this, Transform_t3600365921 * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
extern "C"  Vector3_t3722313464  Vector3_get_zero_m1409827619 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.GameObject::SetActive(System.Boolean)
extern "C"  void GameObject_SetActive_m796801857 (GameObject_t1113636619 * __this, bool p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.List`1<UnityEngine.Transform>::Add(!0)
#define List_1_Add_m4073477735(__this, p0, method) ((  void (*) (List_1_t777473367 *, Transform_t3600365921 *, const RuntimeMethod*))List_1_Add_m3338814081_gshared)(__this, p0, method)
// UnityEngine.Transform UnityEngine.Transform::GetChild(System.Int32)
extern "C"  Transform_t3600365921 * Transform_GetChild_m1092972975 (Transform_t3600365921 * __this, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void CarStream::CreateCars()
extern "C"  void CarStream_CreateCars_m3242703007 (CarStream_t2397564518 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void CarStream::MoveNextCar()
extern "C"  void CarStream_MoveNextCar_m3344396066 (CarStream_t2397564518 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// !0 System.Collections.Generic.List`1<UnityEngine.Transform>::get_Item(System.Int32)
#define List_1_get_Item_m3022113929(__this, p0, method) ((  Transform_t3600365921 * (*) (List_1_t777473367 *, int32_t, const RuntimeMethod*))List_1_get_Item_m2287542950_gshared)(__this, p0, method)
// !!0 UnityEngine.Component::GetComponent<Car>()
#define Component_GetComponent_TisCar_t2395504951_m2969401948(__this, method) ((  Car_t2395504951 * (*) (Component_t1923634451 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m2906321015_gshared)(__this, method)
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
extern "C"  Vector3_t3722313464  Transform_get_position_m36019626 (Transform_t3600365921 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void Car::Move(UnityEngine.Vector3,UnityEngine.Vector3,System.Int32)
extern "C"  void Car_Move_m1860261471 (Car_t2395504951 * __this, Vector3_t3722313464  ___startingPos0, Vector3_t3722313464  ___target1, int32_t ___direction2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Collections.Generic.List`1<UnityEngine.Transform>::get_Count()
#define List_1_get_Count_m3787308655(__this, method) ((  int32_t (*) (List_1_t777473367 *, const RuntimeMethod*))List_1_get_Count_m2934127733_gshared)(__this, method)
// System.Void Car::SetMove(System.Boolean)
extern "C"  void Car_SetMove_m2155209944 (Car_t2395504951 * __this, bool ___b0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void EventManager/Section::Invoke(SectionType)
extern "C"  void Section_Invoke_m2372666227 (Section_t1829303744 * __this, int32_t ___type0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Application::set_targetFrameRate(System.Int32)
extern "C"  void Application_set_targetFrameRate_m3682352535 (RuntimeObject * __this /* static, unused */, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Input::GetMouseButtonDown(System.Int32)
extern "C"  bool Input_GetMouseButtonDown_m2081676745 (RuntimeObject * __this /* static, unused */, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Input::GetMouseButton(System.Int32)
extern "C"  bool Input_GetMouseButton_m513753021 (RuntimeObject * __this /* static, unused */, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void GameInput::Control()
extern "C"  void GameInput_Control_m1402073417 (GameInput_t4178564210 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Mathf::Clamp(System.Single,System.Single,System.Single)
extern "C"  float Mathf_Clamp_m3350697880 (RuntimeObject * __this /* static, unused */, float p0, float p1, float p2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Camera UnityEngine.Camera::get_main()
extern "C"  Camera_t4157153871 * Camera_get_main_m3643453163 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Input::get_mousePosition()
extern "C"  Vector3_t3722313464  Input_get_mousePosition_m1616496925 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Camera::ScreenToViewportPoint(UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Camera_ScreenToViewportPoint_m3569032523 (Camera_t4157153871 * __this, Vector3_t3722313464  p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector2 UnityEngine.Vector2::op_Implicit(UnityEngine.Vector3)
extern "C"  Vector2_t2156229523  Vector2_op_Implicit_m4260192859 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.SceneManagement.SceneManager::LoadScene(System.Int32)
extern "C"  void SceneManager_LoadScene_m3463216446 (RuntimeObject * __this /* static, unused */, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// !!0 UnityEngine.Object::FindObjectOfType<SectionContainer>()
#define Object_FindObjectOfType_TisSectionContainer_t1774584350_m3490830121(__this /* static, unused */, method) ((  SectionContainer_t1774584350 * (*) (RuntimeObject * /* static, unused */, const RuntimeMethod*))Object_FindObjectOfType_TisRuntimeObject_m2612646359_gshared)(__this /* static, unused */, method)
// UnityEngine.Vector3 UnityEngine.Vector3::get_forward()
extern "C"  Vector3_t3722313464  Vector3_get_forward_m3100859705 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_UnaryNegation(UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_op_UnaryNegation_m1951478815 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
extern "C"  bool Object_op_Inequality_m4071470834 (RuntimeObject * __this /* static, unused */, Object_t631007953 * p0, Object_t631007953 * p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void Section::OutSide()
extern "C"  void Section_OutSide_m20284767 (Section_t3531603569 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void SectionContainer::PoolSection(Section)
extern "C"  void SectionContainer_PoolSection_m2424153165 (SectionContainer_t1774584350 * __this, Section_t3531603569 * ___section0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator UnityEngine.Transform::GetEnumerator()
extern "C"  RuntimeObject* Transform_GetEnumerator_m2717073726 (Transform_t3600365921 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.List`1<Section>::Clear()
#define List_1_Clear_m3586392508(__this, method) ((  void (*) (List_1_t708711015 *, const RuntimeMethod*))List_1_Clear_m3697625829_gshared)(__this, method)
// System.Void SectionContainer::SpawnSection()
extern "C"  void SectionContainer_SpawnSection_m3228762525 (SectionContainer_t1774584350 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void SectionContainer::CreateSection(SectionType)
extern "C"  void SectionContainer_CreateSection_m4022469148 (SectionContainer_t1774584350 * __this, int32_t ___type0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void SectionContainer::RepositionSections()
extern "C"  void SectionContainer_RepositionSections_m2416598502 (SectionContainer_t1774584350 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.List`1<Section>::.ctor()
#define List_1__ctor_m1340754610(__this, method) ((  void (*) (List_1_t708711015 *, const RuntimeMethod*))List_1__ctor_m2321703786_gshared)(__this, method)
// System.Int32 UnityEngine.Transform::get_childCount()
extern "C"  int32_t Transform_get_childCount_m3145433196 (Transform_t3600365921 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Random::Range(System.Int32,System.Int32)
extern "C"  int32_t Random_Range_m4054026115 (RuntimeObject * __this /* static, unused */, int32_t p0, int32_t p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor()
#define List_1__ctor_m1628857705(__this, method) ((  void (*) (List_1_t128053199 *, const RuntimeMethod*))List_1__ctor_m1628857705_gshared)(__this, method)
// Section SectionContainer::GetSectionFromReservedByType(SectionType)
extern "C"  Section_t3531603569 * SectionContainer_GetSectionFromReservedByType_m496361358 (SectionContainer_t1774584350 * __this, int32_t ___type0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// !!0 UnityEngine.Component::GetComponent<Section>()
#define Component_GetComponent_TisSection_t3531603569_m2204478105(__this, method) ((  Section_t3531603569 * (*) (Component_t1923634451 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m2906321015_gshared)(__this, method)
// System.Boolean System.Collections.Generic.List`1<Section>::Contains(!0)
#define List_1_Contains_m1186541113(__this, p0, method) ((  bool (*) (List_1_t708711015 *, Section_t3531603569 *, const RuntimeMethod*))List_1_Contains_m2654125393_gshared)(__this, p0, method)
// System.Void System.Collections.Generic.List`1<Section>::Add(!0)
#define List_1_Add_m2981936162(__this, p0, method) ((  void (*) (List_1_t708711015 *, Section_t3531603569 *, const RuntimeMethod*))List_1_Add_m3338814081_gshared)(__this, p0, method)
// System.Int32 System.Collections.Generic.List`1<Section>::get_Count()
#define List_1_get_Count_m3805462939(__this, method) ((  int32_t (*) (List_1_t708711015 *, const RuntimeMethod*))List_1_get_Count_m2934127733_gshared)(__this, method)
// !0 System.Collections.Generic.List`1<Section>::get_Item(System.Int32)
#define List_1_get_Item_m1934819507(__this, p0, method) ((  Section_t3531603569 * (*) (List_1_t708711015 *, int32_t, const RuntimeMethod*))List_1_get_Item_m2287542950_gshared)(__this, p0, method)
// UnityEngine.GameObject SectionContainer::DeterminePrefab(SectionType)
extern "C"  GameObject_t1113636619 * SectionContainer_DeterminePrefab_m2704913349 (SectionContainer_t1774584350 * __this, int32_t ___type0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// !!0 UnityEngine.GameObject::GetComponent<Section>()
#define GameObject_GetComponent_TisSection_t3531603569_m434087264(__this, method) ((  Section_t3531603569 * (*) (GameObject_t1113636619 *, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m3920941149_gshared)(__this, method)
// System.Void Section::SetType(SectionType)
extern "C"  void Section_SetType_m1141735059 (Section_t3531603569 * __this, int32_t ___type0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void Section::Init()
extern "C"  void Section_Init_m3325106713 (Section_t3531603569 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
extern "C"  bool Object_op_Equality_m1810815630 (RuntimeObject * __this /* static, unused */, Object_t631007953 * p0, Object_t631007953 * p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void Section::Move(Section)
extern "C"  void Section_Move_m3056575733 (Section_t3531603569 * __this, Section_t3531603569 * ___s0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.GameObject::get_activeSelf()
extern "C"  bool GameObject_get_activeSelf_m1767405923 (GameObject_t1113636619 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AppResources::.ctor()
extern "C"  void AppResources__ctor_m2308344322 (AppResources_t1237449672 * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_m1579109191(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void AppResources::.cctor()
extern "C"  void AppResources__cctor_m685958323 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AppResources__cctor_m685958323_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object_t631007953 * L_0 = Resources_Load_m3880010804(NULL /*static, unused*/, _stringLiteral522958457, /*hidden argument*/NULL);
		((AppResources_t1237449672_StaticFields*)il2cpp_codegen_static_fields_for(AppResources_t1237449672_il2cpp_TypeInfo_var))->set_Section_1_2(((GameObject_t1113636619 *)IsInstSealed((RuntimeObject*)L_0, GameObject_t1113636619_il2cpp_TypeInfo_var)));
		Object_t631007953 * L_1 = Resources_Load_m3880010804(NULL /*static, unused*/, _stringLiteral2519308568, /*hidden argument*/NULL);
		((AppResources_t1237449672_StaticFields*)il2cpp_codegen_static_fields_for(AppResources_t1237449672_il2cpp_TypeInfo_var))->set_Section_2_3(((GameObject_t1113636619 *)IsInstSealed((RuntimeObject*)L_1, GameObject_t1113636619_il2cpp_TypeInfo_var)));
		Object_t631007953 * L_2 = Resources_Load_m3880010804(NULL /*static, unused*/, _stringLiteral2519308569, /*hidden argument*/NULL);
		((AppResources_t1237449672_StaticFields*)il2cpp_codegen_static_fields_for(AppResources_t1237449672_il2cpp_TypeInfo_var))->set_Section_3_4(((GameObject_t1113636619 *)IsInstSealed((RuntimeObject*)L_2, GameObject_t1113636619_il2cpp_TypeInfo_var)));
		Object_t631007953 * L_3 = Resources_Load_m3880010804(NULL /*static, unused*/, _stringLiteral1302725867, /*hidden argument*/NULL);
		((AppResources_t1237449672_StaticFields*)il2cpp_codegen_static_fields_for(AppResources_t1237449672_il2cpp_TypeInfo_var))->set_Car_5(((GameObject_t1113636619 *)IsInstSealed((RuntimeObject*)L_3, GameObject_t1113636619_il2cpp_TypeInfo_var)));
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Car::.ctor()
extern "C"  void Car__ctor_m241345750 (Car_t2395504951 * __this, const RuntimeMethod* method)
{
	{
		__this->set_CarSpeed_5((100.0f));
		MonoBehaviour__ctor_m1579109191(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void Car::Start()
extern "C"  void Car_Start_m2705937358 (Car_t2395504951 * __this, const RuntimeMethod* method)
{
	{
		__this->set_CarSpeed_5((100.0f));
		return;
	}
}
// System.Void Car::Update()
extern "C"  void Car_Update_m2271061216 (Car_t2395504951 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Car_Update_m2271061216_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0 = __this->get_move_3();
		if (L_0)
		{
			goto IL_000c;
		}
	}
	{
		return;
	}

IL_000c:
	{
		Transform_t3600365921 * L_1 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		int32_t L_2 = __this->get_direction_4();
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_3 = Vector3_get_right_m1913784872(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t3722313464  L_4 = Vector3_op_Multiply_m2104357790(NULL /*static, unused*/, (((float)((float)L_2))), L_3, /*hidden argument*/NULL);
		float L_5 = Time_get_deltaTime_m372706562(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t3722313464  L_6 = Vector3_op_Multiply_m3376773913(NULL /*static, unused*/, L_4, L_5, /*hidden argument*/NULL);
		float L_7 = __this->get_CarSpeed_5();
		Vector3_t3722313464  L_8 = Vector3_op_Multiply_m3376773913(NULL /*static, unused*/, L_6, L_7, /*hidden argument*/NULL);
		NullCheck(L_1);
		Transform_Translate_m1990195114(L_1, L_8, 0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void Car::Move(UnityEngine.Vector3,UnityEngine.Vector3,System.Int32)
extern "C"  void Car_Move_m1860261471 (Car_t2395504951 * __this, Vector3_t3722313464  ___startingPos0, Vector3_t3722313464  ___target1, int32_t ___direction2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Car_Move_m1860261471_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		__this->set_move_3((bool)1);
		Transform_t3600365921 * L_0 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		Vector3_t3722313464  L_1 = ___startingPos0;
		float L_2 = Random_Range_m2202990745(NULL /*static, unused*/, (-10.0f), (10.0f), /*hidden argument*/NULL);
		Vector3_t3722313464  L_3;
		memset(&L_3, 0, sizeof(L_3));
		Vector3__ctor_m3353183577((&L_3), (0.0f), (0.0f), L_2, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_4 = Vector3_op_Addition_m779775034(NULL /*static, unused*/, L_1, L_3, /*hidden argument*/NULL);
		NullCheck(L_0);
		Transform_set_position_m3387557959(L_0, L_4, /*hidden argument*/NULL);
		int32_t L_5 = ___direction2;
		__this->set_direction_4(L_5);
		return;
	}
}
// System.Void Car::OnTriggerEnter(UnityEngine.Collider)
extern "C"  void Car_OnTriggerEnter_m590296435 (Car_t2395504951 * __this, Collider_t1773347010 * ___col0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Car_OnTriggerEnter_m590296435_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Collider_t1773347010 * L_0 = ___col0;
		NullCheck(L_0);
		GameObject_t1113636619 * L_1 = Component_get_gameObject_m442555142(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		String_t* L_2 = GameObject_get_tag_m3951609671(L_1, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_3 = String_op_Equality_m920492651(NULL /*static, unused*/, L_2, _stringLiteral2271825249, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0021;
		}
	}
	{
		__this->set_move_3((bool)0);
	}

IL_0021:
	{
		return;
	}
}
// System.Void Car::SetMove(System.Boolean)
extern "C"  void Car_SetMove_m2155209944 (Car_t2395504951 * __this, bool ___b0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___b0;
		__this->set_move_3(L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void CarStream::.ctor()
extern "C"  void CarStream__ctor_m2851473992 (CarStream_t2397564518 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (CarStream__ctor_m2851473992_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		List_1_t777473367 * L_0 = (List_1_t777473367 *)il2cpp_codegen_object_new(List_1_t777473367_il2cpp_TypeInfo_var);
		List_1__ctor_m2885667311(L_0, /*hidden argument*/List_1__ctor_m2885667311_RuntimeMethod_var);
		__this->set_cars_2(L_0);
		__this->set_direction_5(1);
		__this->set_delay_6((1.0f));
		__this->set_moveCars_8((bool)1);
		MonoBehaviour__ctor_m1579109191(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void CarStream::OnEnable()
extern "C"  void CarStream_OnEnable_m3463323575 (CarStream_t2397564518 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (CarStream_OnEnable_m3463323575_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Section_t1829303744 * L_0 = ((EventManager_t1594656820_StaticFields*)il2cpp_codegen_static_fields_for(EventManager_t1594656820_il2cpp_TypeInfo_var))->get_OnSectionPool_2();
		intptr_t L_1 = (intptr_t)CarStream_OnSectionPool_m2835630221_RuntimeMethod_var;
		Section_t1829303744 * L_2 = (Section_t1829303744 *)il2cpp_codegen_object_new(Section_t1829303744_il2cpp_TypeInfo_var);
		Section__ctor_m1197859341(L_2, __this, L_1, /*hidden argument*/NULL);
		Delegate_t1188392813 * L_3 = Delegate_Combine_m1859655160(NULL /*static, unused*/, L_0, L_2, /*hidden argument*/NULL);
		((EventManager_t1594656820_StaticFields*)il2cpp_codegen_static_fields_for(EventManager_t1594656820_il2cpp_TypeInfo_var))->set_OnSectionPool_2(((Section_t1829303744 *)CastclassSealed((RuntimeObject*)L_3, Section_t1829303744_il2cpp_TypeInfo_var)));
		return;
	}
}
// System.Void CarStream::OnDisable()
extern "C"  void CarStream_OnDisable_m937339345 (CarStream_t2397564518 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (CarStream_OnDisable_m937339345_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Section_t1829303744 * L_0 = ((EventManager_t1594656820_StaticFields*)il2cpp_codegen_static_fields_for(EventManager_t1594656820_il2cpp_TypeInfo_var))->get_OnSectionPool_2();
		intptr_t L_1 = (intptr_t)CarStream_OnSectionPool_m2835630221_RuntimeMethod_var;
		Section_t1829303744 * L_2 = (Section_t1829303744 *)il2cpp_codegen_object_new(Section_t1829303744_il2cpp_TypeInfo_var);
		Section__ctor_m1197859341(L_2, __this, L_1, /*hidden argument*/NULL);
		Delegate_t1188392813 * L_3 = Delegate_Remove_m334097152(NULL /*static, unused*/, L_0, L_2, /*hidden argument*/NULL);
		((EventManager_t1594656820_StaticFields*)il2cpp_codegen_static_fields_for(EventManager_t1594656820_il2cpp_TypeInfo_var))->set_OnSectionPool_2(((Section_t1829303744 *)CastclassSealed((RuntimeObject*)L_3, Section_t1829303744_il2cpp_TypeInfo_var)));
		return;
	}
}
// System.Void CarStream::OnSectionPool(SectionType)
extern "C"  void CarStream_OnSectionPool_m2835630221 (CarStream_t2397564518 * __this, int32_t ___type0, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void CarStream::Start()
extern "C"  void CarStream_Start_m471491924 (CarStream_t2397564518 * __this, const RuntimeMethod* method)
{
	{
		CarStream_Init_m131485731(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void CarStream::CreateCars()
extern "C"  void CarStream_CreateCars_m3242703007 (CarStream_t2397564518 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (CarStream_CreateCars_m3242703007_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	GameObject_t1113636619 * V_1 = NULL;
	{
		V_0 = 0;
		goto IL_004f;
	}

IL_0007:
	{
		IL2CPP_RUNTIME_CLASS_INIT(AppResources_t1237449672_il2cpp_TypeInfo_var);
		GameObject_t1113636619 * L_0 = ((AppResources_t1237449672_StaticFields*)il2cpp_codegen_static_fields_for(AppResources_t1237449672_il2cpp_TypeInfo_var))->get_Car_5();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		GameObject_t1113636619 * L_1 = Object_Instantiate_TisGameObject_t1113636619_m587845175(NULL /*static, unused*/, L_0, /*hidden argument*/Object_Instantiate_TisGameObject_t1113636619_m587845175_RuntimeMethod_var);
		V_1 = L_1;
		GameObject_t1113636619 * L_2 = V_1;
		NullCheck(L_2);
		Transform_t3600365921 * L_3 = GameObject_get_transform_m1369836730(L_2, /*hidden argument*/NULL);
		Transform_t3600365921 * L_4 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_3);
		Transform_SetParent_m381167889(L_3, L_4, /*hidden argument*/NULL);
		GameObject_t1113636619 * L_5 = V_1;
		NullCheck(L_5);
		Transform_t3600365921 * L_6 = GameObject_get_transform_m1369836730(L_5, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_7 = Vector3_get_zero_m1409827619(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_6);
		Transform_set_position_m3387557959(L_6, L_7, /*hidden argument*/NULL);
		GameObject_t1113636619 * L_8 = V_1;
		NullCheck(L_8);
		GameObject_SetActive_m796801857(L_8, (bool)0, /*hidden argument*/NULL);
		List_1_t777473367 * L_9 = __this->get_cars_2();
		GameObject_t1113636619 * L_10 = V_1;
		NullCheck(L_10);
		Transform_t3600365921 * L_11 = GameObject_get_transform_m1369836730(L_10, /*hidden argument*/NULL);
		NullCheck(L_9);
		List_1_Add_m4073477735(L_9, L_11, /*hidden argument*/List_1_Add_m4073477735_RuntimeMethod_var);
		int32_t L_12 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_004f:
	{
		int32_t L_13 = V_0;
		if ((((int32_t)L_13) < ((int32_t)((int32_t)15))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
// System.Void CarStream::Init()
extern "C"  void CarStream_Init_m131485731 (CarStream_t2397564518 * __this, const RuntimeMethod* method)
{
	{
		Transform_t3600365921 * L_0 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		Transform_t3600365921 * L_1 = Transform_GetChild_m1092972975(L_0, 1, /*hidden argument*/NULL);
		__this->set_stoppoint_7(L_1);
		CarStream_CreateCars_m3242703007(__this, /*hidden argument*/NULL);
		__this->set_timer_3((1.0f));
		return;
	}
}
// System.Void CarStream::Update()
extern "C"  void CarStream_Update_m1255341889 (CarStream_t2397564518 * __this, const RuntimeMethod* method)
{
	{
		bool L_0 = __this->get_moveCars_8();
		if (!L_0)
		{
			goto IL_003f;
		}
	}
	{
		float L_1 = __this->get_timer_3();
		float L_2 = Time_get_deltaTime_m372706562(NULL /*static, unused*/, /*hidden argument*/NULL);
		__this->set_timer_3(((float)il2cpp_codegen_add((float)L_1, (float)L_2)));
		float L_3 = __this->get_timer_3();
		float L_4 = __this->get_delay_6();
		if ((!(((float)L_3) > ((float)L_4))))
		{
			goto IL_003f;
		}
	}
	{
		CarStream_MoveNextCar_m3344396066(__this, /*hidden argument*/NULL);
		__this->set_timer_3((0.0f));
	}

IL_003f:
	{
		return;
	}
}
// System.Void CarStream::MoveNextCar()
extern "C"  void CarStream_MoveNextCar_m3344396066 (CarStream_t2397564518 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (CarStream_MoveNextCar_m3344396066_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Car_t2395504951 * V_0 = NULL;
	{
		List_1_t777473367 * L_0 = __this->get_cars_2();
		int32_t L_1 = __this->get_currentCarIndex_4();
		NullCheck(L_0);
		Transform_t3600365921 * L_2 = List_1_get_Item_m3022113929(L_0, L_1, /*hidden argument*/List_1_get_Item_m3022113929_RuntimeMethod_var);
		NullCheck(L_2);
		Car_t2395504951 * L_3 = Component_GetComponent_TisCar_t2395504951_m2969401948(L_2, /*hidden argument*/Component_GetComponent_TisCar_t2395504951_m2969401948_RuntimeMethod_var);
		V_0 = L_3;
		Car_t2395504951 * L_4 = V_0;
		NullCheck(L_4);
		bool L_5 = L_4->get_move_3();
		if (L_5)
		{
			goto IL_0070;
		}
	}
	{
		Car_t2395504951 * L_6 = V_0;
		NullCheck(L_6);
		Transform_t3600365921 * L_7 = Component_get_transform_m3162698980(L_6, /*hidden argument*/NULL);
		NullCheck(L_7);
		GameObject_t1113636619 * L_8 = Component_get_gameObject_m442555142(L_7, /*hidden argument*/NULL);
		NullCheck(L_8);
		GameObject_SetActive_m796801857(L_8, (bool)1, /*hidden argument*/NULL);
		Car_t2395504951 * L_9 = V_0;
		Transform_t3600365921 * L_10 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_10);
		Vector3_t3722313464  L_11 = Transform_get_position_m36019626(L_10, /*hidden argument*/NULL);
		Transform_t3600365921 * L_12 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_12);
		Transform_t3600365921 * L_13 = Transform_GetChild_m1092972975(L_12, 0, /*hidden argument*/NULL);
		NullCheck(L_13);
		Vector3_t3722313464  L_14 = Transform_get_position_m36019626(L_13, /*hidden argument*/NULL);
		int32_t L_15 = __this->get_direction_5();
		NullCheck(L_9);
		Car_Move_m1860261471(L_9, L_11, L_14, L_15, /*hidden argument*/NULL);
		float L_16 = Random_Range_m2202990745(NULL /*static, unused*/, (0.3f), (2.8f), /*hidden argument*/NULL);
		__this->set_delay_6(L_16);
	}

IL_0070:
	{
		int32_t L_17 = __this->get_currentCarIndex_4();
		__this->set_currentCarIndex_4(((int32_t)il2cpp_codegen_add((int32_t)L_17, (int32_t)1)));
		int32_t L_18 = __this->get_currentCarIndex_4();
		List_1_t777473367 * L_19 = __this->get_cars_2();
		NullCheck(L_19);
		int32_t L_20 = List_1_get_Count_m3787308655(L_19, /*hidden argument*/List_1_get_Count_m3787308655_RuntimeMethod_var);
		if ((((int32_t)L_18) <= ((int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_20, (int32_t)1)))))
		{
			goto IL_009d;
		}
	}
	{
		__this->set_currentCarIndex_4(0);
	}

IL_009d:
	{
		return;
	}
}
// System.Void CarStream::PlaceCarsAtStopPoint()
extern "C"  void CarStream_PlaceCarsAtStopPoint_m850318687 (CarStream_t2397564518 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (CarStream_PlaceCarsAtStopPoint_m850318687_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	Vector3_t3722313464  V_2;
	memset(&V_2, 0, sizeof(V_2));
	{
		bool L_0 = __this->get_moveCars_8();
		if (!L_0)
		{
			goto IL_000c;
		}
	}
	{
		return;
	}

IL_000c:
	{
		V_0 = 0;
		goto IL_00ad;
	}

IL_0013:
	{
		List_1_t777473367 * L_1 = __this->get_cars_2();
		int32_t L_2 = V_0;
		NullCheck(L_1);
		Transform_t3600365921 * L_3 = List_1_get_Item_m3022113929(L_1, L_2, /*hidden argument*/List_1_get_Item_m3022113929_RuntimeMethod_var);
		NullCheck(L_3);
		Car_t2395504951 * L_4 = Component_GetComponent_TisCar_t2395504951_m2969401948(L_3, /*hidden argument*/Component_GetComponent_TisCar_t2395504951_m2969401948_RuntimeMethod_var);
		NullCheck(L_4);
		Car_SetMove_m2155209944(L_4, (bool)0, /*hidden argument*/NULL);
		int32_t L_5 = V_0;
		List_1_t777473367 * L_6 = __this->get_cars_2();
		NullCheck(L_6);
		int32_t L_7 = List_1_get_Count_m3787308655(L_6, /*hidden argument*/List_1_get_Count_m3787308655_RuntimeMethod_var);
		if ((((int32_t)L_5) >= ((int32_t)((int32_t)((int32_t)L_7/(int32_t)3)))))
		{
			goto IL_00a9;
		}
	}
	{
		Transform_t3600365921 * L_8 = __this->get_stoppoint_7();
		NullCheck(L_8);
		Vector3_t3722313464  L_9 = Transform_get_position_m36019626(L_8, /*hidden argument*/NULL);
		V_1 = L_9;
		List_1_t777473367 * L_10 = __this->get_cars_2();
		int32_t L_11 = V_0;
		NullCheck(L_10);
		Transform_t3600365921 * L_12 = List_1_get_Item_m3022113929(L_10, L_11, /*hidden argument*/List_1_get_Item_m3022113929_RuntimeMethod_var);
		NullCheck(L_12);
		GameObject_t1113636619 * L_13 = Component_get_gameObject_m442555142(L_12, /*hidden argument*/NULL);
		NullCheck(L_13);
		GameObject_SetActive_m796801857(L_13, (bool)1, /*hidden argument*/NULL);
		List_1_t777473367 * L_14 = __this->get_cars_2();
		int32_t L_15 = V_0;
		NullCheck(L_14);
		Transform_t3600365921 * L_16 = List_1_get_Item_m3022113929(L_14, L_15, /*hidden argument*/List_1_get_Item_m3022113929_RuntimeMethod_var);
		NullCheck(L_16);
		Transform_t3600365921 * L_17 = Component_get_transform_m3162698980(L_16, /*hidden argument*/NULL);
		Vector3_t3722313464  L_18 = V_1;
		int32_t L_19 = __this->get_direction_5();
		int32_t L_20 = V_0;
		Transform_t3600365921 * L_21 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_21);
		Vector3_t3722313464  L_22 = Transform_get_position_m36019626(L_21, /*hidden argument*/NULL);
		V_2 = L_22;
		float L_23 = (&V_2)->get_y_2();
		Vector3_t3722313464  L_24;
		memset(&L_24, 0, sizeof(L_24));
		Vector3__ctor_m3353183577((&L_24), ((float)il2cpp_codegen_multiply((float)(((float)((float)((int32_t)il2cpp_codegen_multiply((int32_t)((-L_19)), (int32_t)L_20))))), (float)(40.0f))), L_23, (0.0f), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_25 = Vector3_op_Addition_m779775034(NULL /*static, unused*/, L_18, L_24, /*hidden argument*/NULL);
		NullCheck(L_17);
		Transform_set_position_m3387557959(L_17, L_25, /*hidden argument*/NULL);
	}

IL_00a9:
	{
		int32_t L_26 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_26, (int32_t)1));
	}

IL_00ad:
	{
		int32_t L_27 = V_0;
		List_1_t777473367 * L_28 = __this->get_cars_2();
		NullCheck(L_28);
		int32_t L_29 = List_1_get_Count_m3787308655(L_28, /*hidden argument*/List_1_get_Count_m3787308655_RuntimeMethod_var);
		if ((((int32_t)L_27) < ((int32_t)L_29)))
		{
			goto IL_0013;
		}
	}
	{
		return;
	}
}
// System.Void CarStream::SetMove(System.Boolean)
extern "C"  void CarStream_SetMove_m42520417 (CarStream_t2397564518 * __this, bool ___b0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (CarStream_SetMove_m42520417_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		bool L_0 = ___b0;
		__this->set_moveCars_8(L_0);
		V_0 = 0;
		goto IL_002e;
	}

IL_000e:
	{
		List_1_t777473367 * L_1 = __this->get_cars_2();
		int32_t L_2 = V_0;
		NullCheck(L_1);
		Transform_t3600365921 * L_3 = List_1_get_Item_m3022113929(L_1, L_2, /*hidden argument*/List_1_get_Item_m3022113929_RuntimeMethod_var);
		NullCheck(L_3);
		Car_t2395504951 * L_4 = Component_GetComponent_TisCar_t2395504951_m2969401948(L_3, /*hidden argument*/Component_GetComponent_TisCar_t2395504951_m2969401948_RuntimeMethod_var);
		bool L_5 = __this->get_moveCars_8();
		NullCheck(L_4);
		Car_SetMove_m2155209944(L_4, L_5, /*hidden argument*/NULL);
		int32_t L_6 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_6, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_7 = V_0;
		List_1_t777473367 * L_8 = __this->get_cars_2();
		NullCheck(L_8);
		int32_t L_9 = List_1_get_Count_m3787308655(L_8, /*hidden argument*/List_1_get_Count_m3787308655_RuntimeMethod_var);
		if ((((int32_t)L_7) < ((int32_t)L_9)))
		{
			goto IL_000e;
		}
	}
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void EventManager::.ctor()
extern "C"  void EventManager__ctor_m2252750981 (EventManager_t1594656820 * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_m1579109191(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
extern "C"  void DelegatePInvokeWrapper_Section_t1829303744 (Section_t1829303744 * __this, int32_t ___type0, const RuntimeMethod* method)
{
	typedef void (STDCALL *PInvokeFunc)(int32_t);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_method_pointer(((RuntimeDelegate*)__this)->method));

	// Native function invocation
	il2cppPInvokeFunc(___type0);

}
// System.Void EventManager/Section::.ctor(System.Object,System.IntPtr)
extern "C"  void Section__ctor_m1197859341 (Section_t1829303744 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void EventManager/Section::Invoke(SectionType)
extern "C"  void Section_Invoke_m2372666227 (Section_t1829303744 * __this, int32_t ___type0, const RuntimeMethod* method)
{
	if(__this->get_prev_9() != NULL)
	{
		Section_Invoke_m2372666227((Section_t1829303744 *)__this->get_prev_9(), ___type0, method);
	}
	Il2CppMethodPointer targetMethodPointer = __this->get_method_ptr_0();
	RuntimeMethod* targetMethod = (RuntimeMethod*)(__this->get_method_3());
	RuntimeObject* targetThis = __this->get_m_target_2();
	il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
	bool ___methodIsStatic = MethodIsStatic(targetMethod);
	if (___methodIsStatic)
	{
		if (il2cpp_codegen_method_parameter_count(targetMethod) == 1)
		{
			// open
			{
				typedef void (*FunctionPointerType) (RuntimeObject *, int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(NULL, ___type0, targetMethod);
			}
		}
		else
		{
			// closed
			{
				typedef void (*FunctionPointerType) (RuntimeObject *, void*, int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(NULL, targetThis, ___type0, targetMethod);
			}
		}
	}
	else
	{
		{
			// closed
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< int32_t >::Invoke(targetMethod, targetThis, ___type0);
					else
						GenericVirtActionInvoker1< int32_t >::Invoke(targetMethod, targetThis, ___type0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___type0);
					else
						VirtActionInvoker1< int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___type0);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___type0, targetMethod);
			}
		}
	}
}
// System.IAsyncResult EventManager/Section::BeginInvoke(SectionType,System.AsyncCallback,System.Object)
extern "C"  RuntimeObject* Section_BeginInvoke_m2512574320 (Section_t1829303744 * __this, int32_t ___type0, AsyncCallback_t3962456242 * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Section_BeginInvoke_m2512574320_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[2] = {0};
	__d_args[0] = Box(SectionType_t4049925526_il2cpp_TypeInfo_var, &___type0);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);
}
// System.Void EventManager/Section::EndInvoke(System.IAsyncResult)
extern "C"  void Section_EndInvoke_m1185580095 (Section_t1829303744 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void GameController::.ctor()
extern "C"  void GameController__ctor_m1587060996 (GameController_t2330501625 * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_m1579109191(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void GameController::Awake()
extern "C"  void GameController_Awake_m4256893697 (GameController_t2330501625 * __this, const RuntimeMethod* method)
{
	{
		Application_set_targetFrameRate_m3682352535(NULL /*static, unused*/, ((int32_t)60), /*hidden argument*/NULL);
		GameObject_t1113636619 * L_0 = __this->get_Dummy_2();
		NullCheck(L_0);
		GameObject_SetActive_m796801857(L_0, (bool)0, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void GameInput::.ctor()
extern "C"  void GameInput__ctor_m3276450851 (GameInput_t4178564210 * __this, const RuntimeMethod* method)
{
	{
		__this->set_senstivity_11((40.0f));
		MonoBehaviour__ctor_m1579109191(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void GameInput::Start()
extern "C"  void GameInput_Start_m1065088085 (GameInput_t4178564210 * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void GameInput::Update()
extern "C"  void GameInput_Update_m1810695037 (GameInput_t4178564210 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (GameInput_Update_m1810695037_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1431474628_il2cpp_TypeInfo_var);
		bool L_0 = Input_GetMouseButtonDown_m2081676745(NULL /*static, unused*/, 0, /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_0012;
		}
	}
	{
		__this->set_pressed_7((bool)1);
	}

IL_0012:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1431474628_il2cpp_TypeInfo_var);
		bool L_1 = Input_GetMouseButton_m513753021(NULL /*static, unused*/, 0, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0056;
		}
	}
	{
		float L_2 = __this->get_velocity_5();
		float L_3 = Time_get_deltaTime_m372706562(NULL /*static, unused*/, /*hidden argument*/NULL);
		__this->set_velocity_5(((float)il2cpp_codegen_add((float)L_2, (float)((float)il2cpp_codegen_multiply((float)L_3, (float)(150.0f))))));
		__this->set_targetVelocity_2((200.0f));
		GameInput_Control_m1402073417(__this, /*hidden argument*/NULL);
		__this->set_rate_4((100.0f));
		goto IL_0084;
	}

IL_0056:
	{
		__this->set_targetVelocity_2((0.0f));
		float L_4 = __this->get_velocity_5();
		float L_5 = Time_get_deltaTime_m372706562(NULL /*static, unused*/, /*hidden argument*/NULL);
		__this->set_velocity_5(((float)il2cpp_codegen_subtract((float)L_4, (float)((float)il2cpp_codegen_multiply((float)L_5, (float)(250.0f))))));
		__this->set_rate_4((80.0f));
	}

IL_0084:
	{
		float L_6 = __this->get_velocity_5();
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t3464937446_il2cpp_TypeInfo_var);
		float L_7 = Mathf_Clamp_m3350697880(NULL /*static, unused*/, L_6, (0.0f), (240.0f), /*hidden argument*/NULL);
		__this->set_velocity_5(L_7);
		float L_8 = __this->get_velocity_5();
		IL2CPP_RUNTIME_CLASS_INIT(Section_t3531603569_il2cpp_TypeInfo_var);
		((Section_t3531603569_StaticFields*)il2cpp_codegen_static_fields_for(Section_t3531603569_il2cpp_TypeInfo_var))->set_VELOCITY_2(L_8);
		return;
	}
}
// System.Void GameInput::Control()
extern "C"  void GameInput_Control_m1402073417 (GameInput_t4178564210 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (GameInput_Control_m1402073417_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	Vector3_t3722313464  V_2;
	memset(&V_2, 0, sizeof(V_2));
	{
		bool L_0 = __this->get_pressed_7();
		if (L_0)
		{
			goto IL_000c;
		}
	}
	{
		return;
	}

IL_000c:
	{
		Camera_t4157153871 * L_1 = Camera_get_main_m3643453163(NULL /*static, unused*/, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1431474628_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_2 = Input_get_mousePosition_m1616496925(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_1);
		Vector3_t3722313464  L_3 = Camera_ScreenToViewportPoint_m3569032523(L_1, L_2, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Vector2_t2156229523_il2cpp_TypeInfo_var);
		Vector2_t2156229523  L_4 = Vector2_op_Implicit_m4260192859(NULL /*static, unused*/, L_3, /*hidden argument*/NULL);
		__this->set_currentPosition_8(L_4);
		bool L_5 = Input_GetMouseButtonDown_m2081676745(NULL /*static, unused*/, 0, /*hidden argument*/NULL);
		if (!L_5)
		{
			goto IL_003d;
		}
	}
	{
		Vector2_t2156229523  L_6 = __this->get_currentPosition_8();
		__this->set_lastPosition_9(L_6);
	}

IL_003d:
	{
		Vector2_t2156229523 * L_7 = __this->get_address_of_currentPosition_8();
		float L_8 = L_7->get_x_0();
		Vector2_t2156229523 * L_9 = __this->get_address_of_lastPosition_9();
		float L_10 = L_9->get_x_0();
		V_0 = ((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_8, (float)L_10)), (float)(20.0f)));
		float L_11 = __this->get_rot_10();
		float L_12 = V_0;
		__this->set_rot_10(((float)il2cpp_codegen_add((float)L_11, (float)L_12)));
		float L_13 = __this->get_rot_10();
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t3464937446_il2cpp_TypeInfo_var);
		float L_14 = Mathf_Clamp_m3350697880(NULL /*static, unused*/, L_13, (-10.0f), (10.0f), /*hidden argument*/NULL);
		__this->set_rot_10(L_14);
		Transform_t3600365921 * L_15 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		float L_16 = __this->get_rot_10();
		Transform_t3600365921 * L_17 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_17);
		Vector3_t3722313464  L_18 = Transform_get_position_m36019626(L_17, /*hidden argument*/NULL);
		V_1 = L_18;
		float L_19 = (&V_1)->get_y_2();
		Transform_t3600365921 * L_20 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_20);
		Vector3_t3722313464  L_21 = Transform_get_position_m36019626(L_20, /*hidden argument*/NULL);
		V_2 = L_21;
		float L_22 = (&V_2)->get_z_3();
		Vector3_t3722313464  L_23;
		memset(&L_23, 0, sizeof(L_23));
		Vector3__ctor_m3353183577((&L_23), L_16, L_19, L_22, /*hidden argument*/NULL);
		NullCheck(L_15);
		Transform_set_position_m3387557959(L_15, L_23, /*hidden argument*/NULL);
		Vector2_t2156229523  L_24 = __this->get_currentPosition_8();
		__this->set_lastPosition_9(L_24);
		return;
	}
}
// System.Void GameInput::OnTriggerEnter(UnityEngine.Collider)
extern "C"  void GameInput_OnTriggerEnter_m2049317573 (GameInput_t4178564210 * __this, Collider_t1773347010 * ___col0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (GameInput_OnTriggerEnter_m2049317573_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Collider_t1773347010 * L_0 = ___col0;
		NullCheck(L_0);
		GameObject_t1113636619 * L_1 = Component_get_gameObject_m442555142(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		String_t* L_2 = GameObject_get_tag_m3951609671(L_1, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_3 = String_op_Equality_m920492651(NULL /*static, unused*/, L_2, _stringLiteral3280678900, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0020;
		}
	}
	{
		SceneManager_LoadScene_m3463216446(NULL /*static, unused*/, 0, /*hidden argument*/NULL);
	}

IL_0020:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Section::.ctor()
extern "C"  void Section__ctor_m3265140494 (Section_t3531603569 * __this, const RuntimeMethod* method)
{
	{
		__this->set_move_6((bool)1);
		MonoBehaviour__ctor_m1579109191(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void Section::Init()
extern "C"  void Section_Init_m3325106713 (Section_t3531603569 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Section_Init_m3325106713_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		SectionContainer_t1774584350 * L_0 = Object_FindObjectOfType_TisSectionContainer_t1774584350_m3490830121(NULL /*static, unused*/, /*hidden argument*/Object_FindObjectOfType_TisSectionContainer_t1774584350_m3490830121_RuntimeMethod_var);
		__this->set_sectionContainer_8(L_0);
		GameObject_t1113636619 * L_1 = __this->get_Buildings_11();
		IL2CPP_RUNTIME_CLASS_INIT(Section_t3531603569_il2cpp_TypeInfo_var);
		bool L_2 = ((Section_t3531603569_StaticFields*)il2cpp_codegen_static_fields_for(Section_t3531603569_il2cpp_TypeInfo_var))->get_EnalbedProps_7();
		NullCheck(L_1);
		GameObject_SetActive_m796801857(L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void Section::SetType(SectionType)
extern "C"  void Section_SetType_m1141735059 (Section_t3531603569 * __this, int32_t ___type0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___type0;
		__this->set_type_5(L_0);
		return;
	}
}
// System.Void Section::Update()
extern "C"  void Section_Update_m1020174184 (Section_t3531603569 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Section_Update_m1020174184_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0 = __this->get_move_6();
		if (L_0)
		{
			goto IL_000c;
		}
	}
	{
		return;
	}

IL_000c:
	{
		Transform_t3600365921 * L_1 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_2 = Vector3_get_forward_m3100859705(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t3722313464  L_3 = Vector3_op_UnaryNegation_m1951478815(NULL /*static, unused*/, L_2, /*hidden argument*/NULL);
		float L_4 = Time_get_deltaTime_m372706562(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t3722313464  L_5 = Vector3_op_Multiply_m3376773913(NULL /*static, unused*/, L_3, L_4, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Section_t3531603569_il2cpp_TypeInfo_var);
		float L_6 = ((Section_t3531603569_StaticFields*)il2cpp_codegen_static_fields_for(Section_t3531603569_il2cpp_TypeInfo_var))->get_VELOCITY_2();
		Vector3_t3722313464  L_7 = Vector3_op_Multiply_m3376773913(NULL /*static, unused*/, L_5, L_6, /*hidden argument*/NULL);
		NullCheck(L_1);
		Transform_Translate_m1990195114(L_1, L_7, 0, /*hidden argument*/NULL);
		Section_t3531603569 * L_8 = __this->get_attachedSection_9();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		bool L_9 = Object_op_Inequality_m4071470834(NULL /*static, unused*/, L_8, (Object_t631007953 *)NULL, /*hidden argument*/NULL);
		if (!L_9)
		{
			goto IL_0062;
		}
	}
	{
		Transform_t3600365921 * L_10 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		Section_t3531603569 * L_11 = __this->get_attachedSection_9();
		NullCheck(L_11);
		Transform_t3600365921 * L_12 = L_11->get_EndConnector_4();
		NullCheck(L_12);
		Vector3_t3722313464  L_13 = Transform_get_position_m36019626(L_12, /*hidden argument*/NULL);
		NullCheck(L_10);
		Transform_set_position_m3387557959(L_10, L_13, /*hidden argument*/NULL);
	}

IL_0062:
	{
		Section_OutSide_m20284767(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void Section::OutSide()
extern "C"  void Section_OutSide_m20284767 (Section_t3531603569 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Section_OutSide_m20284767_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		Transform_t3600365921 * L_0 = __this->get_EndConnector_4();
		NullCheck(L_0);
		Transform_t3600365921 * L_1 = Component_get_transform_m3162698980(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		Vector3_t3722313464  L_2 = Transform_get_position_m36019626(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		float L_3 = (&V_0)->get_z_3();
		if ((!(((float)L_3) < ((float)(-100.0f)))))
		{
			goto IL_0084;
		}
	}
	{
		__this->set_move_6((bool)0);
		Transform_t3600365921 * L_4 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_4);
		GameObject_t1113636619 * L_5 = Component_get_gameObject_m442555142(L_4, /*hidden argument*/NULL);
		NullCheck(L_5);
		GameObject_SetActive_m796801857(L_5, (bool)0, /*hidden argument*/NULL);
		SectionContainer_t1774584350 * L_6 = __this->get_sectionContainer_8();
		NullCheck(L_6);
		SectionContainer_PoolSection_m2424153165(L_6, __this, /*hidden argument*/NULL);
		Section_t1829303744 * L_7 = ((EventManager_t1594656820_StaticFields*)il2cpp_codegen_static_fields_for(EventManager_t1594656820_il2cpp_TypeInfo_var))->get_OnSectionPool_2();
		if (!L_7)
		{
			goto IL_0060;
		}
	}
	{
		Section_t1829303744 * L_8 = ((EventManager_t1594656820_StaticFields*)il2cpp_codegen_static_fields_for(EventManager_t1594656820_il2cpp_TypeInfo_var))->get_OnSectionPool_2();
		int32_t L_9 = __this->get_type_5();
		NullCheck(L_8);
		Section_Invoke_m2372666227(L_8, L_9, /*hidden argument*/NULL);
	}

IL_0060:
	{
		Section_t3531603569 * L_10 = __this->get_connectedSection_10();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		bool L_11 = Object_op_Inequality_m4071470834(NULL /*static, unused*/, L_10, (Object_t631007953 *)NULL, /*hidden argument*/NULL);
		if (!L_11)
		{
			goto IL_0084;
		}
	}
	{
		Section_t3531603569 * L_12 = __this->get_connectedSection_10();
		NullCheck(L_12);
		L_12->set_attachedSection_9((Section_t3531603569 *)NULL);
		__this->set_connectedSection_10((Section_t3531603569 *)NULL);
	}

IL_0084:
	{
		return;
	}
}
// System.Void Section::Move(Section)
extern "C"  void Section_Move_m3056575733 (Section_t3531603569 * __this, Section_t3531603569 * ___s0, const RuntimeMethod* method)
{
	{
		Section_t3531603569 * L_0 = ___s0;
		__this->set_attachedSection_9(L_0);
		Section_t3531603569 * L_1 = __this->get_attachedSection_9();
		NullCheck(L_1);
		L_1->set_connectedSection_10(__this);
		Transform_t3600365921 * L_2 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		Section_t3531603569 * L_3 = ___s0;
		NullCheck(L_3);
		Transform_t3600365921 * L_4 = L_3->get_EndConnector_4();
		NullCheck(L_4);
		Vector3_t3722313464  L_5 = Transform_get_position_m36019626(L_4, /*hidden argument*/NULL);
		NullCheck(L_2);
		Transform_set_position_m3387557959(L_2, L_5, /*hidden argument*/NULL);
		__this->set_move_6((bool)1);
		return;
	}
}
// System.Void Section::Toggle(System.Boolean)
extern "C"  void Section_Toggle_m2292751507 (Section_t3531603569 * __this, bool ___b0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Section_Toggle_m2292751507_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Transform_t3600365921 * V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	int32_t __leave_target = 0;
	NO_UNUSED_WARNING (__leave_target);
	{
		Transform_t3600365921 * L_0 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		RuntimeObject* L_1 = Transform_GetEnumerator_m2717073726(L_0, /*hidden argument*/NULL);
		V_1 = L_1;
	}

IL_000c:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0029;
		}

IL_0011:
		{
			RuntimeObject* L_2 = V_1;
			NullCheck(L_2);
			RuntimeObject * L_3 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(0 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t1853284238_il2cpp_TypeInfo_var, L_2);
			V_0 = ((Transform_t3600365921 *)CastclassClass((RuntimeObject*)L_3, Transform_t3600365921_il2cpp_TypeInfo_var));
			Transform_t3600365921 * L_4 = V_0;
			NullCheck(L_4);
			GameObject_t1113636619 * L_5 = Component_get_gameObject_m442555142(L_4, /*hidden argument*/NULL);
			bool L_6 = ___b0;
			NullCheck(L_5);
			GameObject_SetActive_m796801857(L_5, L_6, /*hidden argument*/NULL);
		}

IL_0029:
		{
			RuntimeObject* L_7 = V_1;
			NullCheck(L_7);
			bool L_8 = InterfaceFuncInvoker0< bool >::Invoke(1 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t1853284238_il2cpp_TypeInfo_var, L_7);
			if (L_8)
			{
				goto IL_0011;
			}
		}

IL_0034:
		{
			IL2CPP_LEAVE(0x4D, FINALLY_0039);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0039;
	}

FINALLY_0039:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_9 = V_1;
			RuntimeObject* L_10 = ((RuntimeObject*)IsInst((RuntimeObject*)L_9, IDisposable_t3640265483_il2cpp_TypeInfo_var));
			V_2 = L_10;
			if (!L_10)
			{
				goto IL_004c;
			}
		}

IL_0046:
		{
			RuntimeObject* L_11 = V_2;
			NullCheck(L_11);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t3640265483_il2cpp_TypeInfo_var, L_11);
		}

IL_004c:
		{
			IL2CPP_END_FINALLY(57)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(57)
	{
		IL2CPP_JUMP_TBL(0x4D, IL_004d)
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
	}

IL_004d:
	{
		return;
	}
}
// System.Void Section::.cctor()
extern "C"  void Section__cctor_m837636648 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Section__cctor_m837636648_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		((Section_t3531603569_StaticFields*)il2cpp_codegen_static_fields_for(Section_t3531603569_il2cpp_TypeInfo_var))->set_EnalbedProps_7((bool)1);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void SectionContainer::.ctor()
extern "C"  void SectionContainer__ctor_m1480435416 (SectionContainer_t1774584350 * __this, const RuntimeMethod* method)
{
	{
		__this->set_defaultActive_6(6);
		MonoBehaviour__ctor_m1579109191(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void SectionContainer::Awake()
extern "C"  void SectionContainer_Awake_m2337727487 (SectionContainer_t1774584350 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SectionContainer_Awake_m2337727487_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(SectionContainer_t1774584350_il2cpp_TypeInfo_var);
		List_1_t708711015 * L_0 = ((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->get_sections_2();
		NullCheck(L_0);
		List_1_Clear_m3586392508(L_0, /*hidden argument*/List_1_Clear_m3586392508_RuntimeMethod_var);
		return;
	}
}
// System.Void SectionContainer::Start()
extern "C"  void SectionContainer_Start_m3986811920 (SectionContainer_t1774584350 * __this, const RuntimeMethod* method)
{
	{
		SectionContainer_SpawnSection_m3228762525(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void SectionContainer::SpawnSection()
extern "C"  void SectionContainer_SpawnSection_m3228762525 (SectionContainer_t1774584350 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		V_0 = 0;
		goto IL_0012;
	}

IL_0007:
	{
		SectionContainer_CreateSection_m4022469148(__this, 0, /*hidden argument*/NULL);
		int32_t L_0 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_0, (int32_t)1));
	}

IL_0012:
	{
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) < ((int32_t)4)))
		{
			goto IL_0007;
		}
	}
	{
		V_1 = 0;
		goto IL_002b;
	}

IL_0020:
	{
		SectionContainer_CreateSection_m4022469148(__this, 1, /*hidden argument*/NULL);
		int32_t L_2 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_2, (int32_t)1));
	}

IL_002b:
	{
		int32_t L_3 = V_1;
		if ((((int32_t)L_3) < ((int32_t)4)))
		{
			goto IL_0020;
		}
	}
	{
		V_2 = 0;
		goto IL_0044;
	}

IL_0039:
	{
		SectionContainer_CreateSection_m4022469148(__this, 2, /*hidden argument*/NULL);
		int32_t L_4 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_4, (int32_t)1));
	}

IL_0044:
	{
		int32_t L_5 = V_2;
		if ((((int32_t)L_5) < ((int32_t)4)))
		{
			goto IL_0039;
		}
	}
	{
		SectionContainer_RepositionSections_m2416598502(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void SectionContainer::RepositionSections()
extern "C"  void SectionContainer_RepositionSections_m2416598502 (SectionContainer_t1774584350 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SectionContainer_RepositionSections_m2416598502_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	List_1_t708711015 * V_0 = NULL;
	int32_t V_1 = 0;
	List_1_t128053199 * V_2 = NULL;
	int32_t V_3 = 0;
	Section_t3531603569 * V_4 = NULL;
	int32_t V_5 = 0;
	Vector3_t3722313464  V_6;
	memset(&V_6, 0, sizeof(V_6));
	{
		List_1_t708711015 * L_0 = (List_1_t708711015 *)il2cpp_codegen_object_new(List_1_t708711015_il2cpp_TypeInfo_var);
		List_1__ctor_m1340754610(L_0, /*hidden argument*/List_1__ctor_m1340754610_RuntimeMethod_var);
		V_0 = L_0;
		Transform_t3600365921 * L_1 = __this->get_reservedTransform_4();
		NullCheck(L_1);
		int32_t L_2 = Transform_get_childCount_m3145433196(L_1, /*hidden argument*/NULL);
		int32_t L_3 = Random_Range_m4054026115(NULL /*static, unused*/, 0, L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		List_1_t128053199 * L_4 = (List_1_t128053199 *)il2cpp_codegen_object_new(List_1_t128053199_il2cpp_TypeInfo_var);
		List_1__ctor_m1628857705(L_4, /*hidden argument*/List_1__ctor_m1628857705_RuntimeMethod_var);
		V_2 = L_4;
		V_3 = 0;
		V_4 = (Section_t3531603569 *)NULL;
	}

IL_0023:
	{
		int32_t L_5 = V_3;
		if ((((int32_t)L_5) >= ((int32_t)2)))
		{
			goto IL_0038;
		}
	}
	{
		Section_t3531603569 * L_6 = SectionContainer_GetSectionFromReservedByType_m496361358(__this, 0, /*hidden argument*/NULL);
		V_4 = L_6;
		goto IL_005d;
	}

IL_0038:
	{
		Transform_t3600365921 * L_7 = __this->get_reservedTransform_4();
		NullCheck(L_7);
		int32_t L_8 = Transform_get_childCount_m3145433196(L_7, /*hidden argument*/NULL);
		int32_t L_9 = Random_Range_m4054026115(NULL /*static, unused*/, 0, L_8, /*hidden argument*/NULL);
		V_1 = L_9;
		Transform_t3600365921 * L_10 = __this->get_reservedTransform_4();
		int32_t L_11 = V_1;
		NullCheck(L_10);
		Transform_t3600365921 * L_12 = Transform_GetChild_m1092972975(L_10, L_11, /*hidden argument*/NULL);
		NullCheck(L_12);
		Section_t3531603569 * L_13 = Component_GetComponent_TisSection_t3531603569_m2204478105(L_12, /*hidden argument*/Component_GetComponent_TisSection_t3531603569_m2204478105_RuntimeMethod_var);
		V_4 = L_13;
	}

IL_005d:
	{
		List_1_t708711015 * L_14 = V_0;
		Section_t3531603569 * L_15 = V_4;
		NullCheck(L_14);
		bool L_16 = List_1_Contains_m1186541113(L_14, L_15, /*hidden argument*/List_1_Contains_m1186541113_RuntimeMethod_var);
		if (L_16)
		{
			goto IL_0076;
		}
	}
	{
		List_1_t708711015 * L_17 = V_0;
		Section_t3531603569 * L_18 = V_4;
		NullCheck(L_17);
		List_1_Add_m2981936162(L_17, L_18, /*hidden argument*/List_1_Add_m2981936162_RuntimeMethod_var);
		int32_t L_19 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_19, (int32_t)1));
	}

IL_0076:
	{
		List_1_t708711015 * L_20 = V_0;
		NullCheck(L_20);
		int32_t L_21 = List_1_get_Count_m3805462939(L_20, /*hidden argument*/List_1_get_Count_m3805462939_RuntimeMethod_var);
		if ((((int32_t)L_21) < ((int32_t)4)))
		{
			goto IL_0023;
		}
	}
	{
		V_5 = 0;
		goto IL_011a;
	}

IL_008a:
	{
		List_1_t708711015 * L_22 = V_0;
		int32_t L_23 = V_5;
		NullCheck(L_22);
		Section_t3531603569 * L_24 = List_1_get_Item_m1934819507(L_22, L_23, /*hidden argument*/List_1_get_Item_m1934819507_RuntimeMethod_var);
		NullCheck(L_24);
		Transform_t3600365921 * L_25 = Component_get_transform_m3162698980(L_24, /*hidden argument*/NULL);
		Transform_t3600365921 * L_26 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_25);
		Transform_SetParent_m381167889(L_25, L_26, /*hidden argument*/NULL);
		List_1_t708711015 * L_27 = V_0;
		int32_t L_28 = V_5;
		NullCheck(L_27);
		Section_t3531603569 * L_29 = List_1_get_Item_m1934819507(L_27, L_28, /*hidden argument*/List_1_get_Item_m1934819507_RuntimeMethod_var);
		NullCheck(L_29);
		Transform_t3600365921 * L_30 = Component_get_transform_m3162698980(L_29, /*hidden argument*/NULL);
		NullCheck(L_30);
		GameObject_t1113636619 * L_31 = Component_get_gameObject_m442555142(L_30, /*hidden argument*/NULL);
		NullCheck(L_31);
		GameObject_SetActive_m796801857(L_31, (bool)1, /*hidden argument*/NULL);
		Vector3__ctor_m3353183577((&V_6), (0.0f), (0.0f), (-100.0f), /*hidden argument*/NULL);
		int32_t L_32 = V_5;
		if ((((int32_t)L_32) <= ((int32_t)0)))
		{
			goto IL_00ee;
		}
	}
	{
		List_1_t708711015 * L_33 = V_0;
		int32_t L_34 = V_5;
		NullCheck(L_33);
		Section_t3531603569 * L_35 = List_1_get_Item_m1934819507(L_33, ((int32_t)il2cpp_codegen_subtract((int32_t)L_34, (int32_t)1)), /*hidden argument*/List_1_get_Item_m1934819507_RuntimeMethod_var);
		NullCheck(L_35);
		Transform_t3600365921 * L_36 = L_35->get_EndConnector_4();
		NullCheck(L_36);
		Vector3_t3722313464  L_37 = Transform_get_position_m36019626(L_36, /*hidden argument*/NULL);
		V_6 = L_37;
	}

IL_00ee:
	{
		List_1_t708711015 * L_38 = V_0;
		int32_t L_39 = V_5;
		NullCheck(L_38);
		Section_t3531603569 * L_40 = List_1_get_Item_m1934819507(L_38, L_39, /*hidden argument*/List_1_get_Item_m1934819507_RuntimeMethod_var);
		NullCheck(L_40);
		Transform_t3600365921 * L_41 = Component_get_transform_m3162698980(L_40, /*hidden argument*/NULL);
		Vector3_t3722313464  L_42 = V_6;
		NullCheck(L_41);
		Transform_set_position_m3387557959(L_41, L_42, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(SectionContainer_t1774584350_il2cpp_TypeInfo_var);
		List_1_t708711015 * L_43 = ((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->get_sections_2();
		List_1_t708711015 * L_44 = V_0;
		int32_t L_45 = V_5;
		NullCheck(L_44);
		Section_t3531603569 * L_46 = List_1_get_Item_m1934819507(L_44, L_45, /*hidden argument*/List_1_get_Item_m1934819507_RuntimeMethod_var);
		NullCheck(L_43);
		List_1_Add_m2981936162(L_43, L_46, /*hidden argument*/List_1_Add_m2981936162_RuntimeMethod_var);
		int32_t L_47 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add((int32_t)L_47, (int32_t)1));
	}

IL_011a:
	{
		int32_t L_48 = V_5;
		List_1_t708711015 * L_49 = V_0;
		NullCheck(L_49);
		int32_t L_50 = List_1_get_Count_m3805462939(L_49, /*hidden argument*/List_1_get_Count_m3805462939_RuntimeMethod_var);
		if ((((int32_t)L_48) < ((int32_t)L_50)))
		{
			goto IL_008a;
		}
	}
	{
		return;
	}
}
// System.Void SectionContainer::CreateSection(SectionType)
extern "C"  void SectionContainer_CreateSection_m4022469148 (SectionContainer_t1774584350 * __this, int32_t ___type0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SectionContainer_CreateSection_m4022469148_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	GameObject_t1113636619 * V_0 = NULL;
	GameObject_t1113636619 * V_1 = NULL;
	Section_t3531603569 * V_2 = NULL;
	{
		int32_t L_0 = ___type0;
		GameObject_t1113636619 * L_1 = SectionContainer_DeterminePrefab_m2704913349(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		GameObject_t1113636619 * L_2 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		GameObject_t1113636619 * L_3 = Object_Instantiate_TisGameObject_t1113636619_m587845175(NULL /*static, unused*/, L_2, /*hidden argument*/Object_Instantiate_TisGameObject_t1113636619_m587845175_RuntimeMethod_var);
		V_1 = L_3;
		GameObject_t1113636619 * L_4 = V_1;
		NullCheck(L_4);
		Transform_t3600365921 * L_5 = GameObject_get_transform_m1369836730(L_4, /*hidden argument*/NULL);
		Transform_t3600365921 * L_6 = __this->get_reservedTransform_4();
		NullCheck(L_5);
		Transform_SetParent_m381167889(L_5, L_6, /*hidden argument*/NULL);
		GameObject_t1113636619 * L_7 = V_1;
		NullCheck(L_7);
		GameObject_SetActive_m796801857(L_7, (bool)0, /*hidden argument*/NULL);
		GameObject_t1113636619 * L_8 = V_1;
		NullCheck(L_8);
		Section_t3531603569 * L_9 = GameObject_GetComponent_TisSection_t3531603569_m434087264(L_8, /*hidden argument*/GameObject_GetComponent_TisSection_t3531603569_m434087264_RuntimeMethod_var);
		V_2 = L_9;
		IL2CPP_RUNTIME_CLASS_INIT(SectionContainer_t1774584350_il2cpp_TypeInfo_var);
		List_1_t708711015 * L_10 = ((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->get_generated_3();
		GameObject_t1113636619 * L_11 = V_1;
		NullCheck(L_11);
		Section_t3531603569 * L_12 = GameObject_GetComponent_TisSection_t3531603569_m434087264(L_11, /*hidden argument*/GameObject_GetComponent_TisSection_t3531603569_m434087264_RuntimeMethod_var);
		NullCheck(L_10);
		List_1_Add_m2981936162(L_10, L_12, /*hidden argument*/List_1_Add_m2981936162_RuntimeMethod_var);
		Section_t3531603569 * L_13 = V_2;
		int32_t L_14 = ___type0;
		NullCheck(L_13);
		Section_SetType_m1141735059(L_13, L_14, /*hidden argument*/NULL);
		Section_t3531603569 * L_15 = V_2;
		NullCheck(L_15);
		Section_Init_m3325106713(L_15, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.GameObject SectionContainer::DeterminePrefab(SectionType)
extern "C"  GameObject_t1113636619 * SectionContainer_DeterminePrefab_m2704913349 (SectionContainer_t1774584350 * __this, int32_t ___type0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SectionContainer_DeterminePrefab_m2704913349_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___type0;
		switch (L_0)
		{
			case 0:
			{
				goto IL_0017;
			}
			case 1:
			{
				goto IL_001d;
			}
			case 2:
			{
				goto IL_0023;
			}
		}
	}
	{
		goto IL_0029;
	}

IL_0017:
	{
		IL2CPP_RUNTIME_CLASS_INIT(AppResources_t1237449672_il2cpp_TypeInfo_var);
		GameObject_t1113636619 * L_1 = ((AppResources_t1237449672_StaticFields*)il2cpp_codegen_static_fields_for(AppResources_t1237449672_il2cpp_TypeInfo_var))->get_Section_1_2();
		return L_1;
	}

IL_001d:
	{
		IL2CPP_RUNTIME_CLASS_INIT(AppResources_t1237449672_il2cpp_TypeInfo_var);
		GameObject_t1113636619 * L_2 = ((AppResources_t1237449672_StaticFields*)il2cpp_codegen_static_fields_for(AppResources_t1237449672_il2cpp_TypeInfo_var))->get_Section_2_3();
		return L_2;
	}

IL_0023:
	{
		IL2CPP_RUNTIME_CLASS_INIT(AppResources_t1237449672_il2cpp_TypeInfo_var);
		GameObject_t1113636619 * L_3 = ((AppResources_t1237449672_StaticFields*)il2cpp_codegen_static_fields_for(AppResources_t1237449672_il2cpp_TypeInfo_var))->get_Section_3_4();
		return L_3;
	}

IL_0029:
	{
		IL2CPP_RUNTIME_CLASS_INIT(AppResources_t1237449672_il2cpp_TypeInfo_var);
		GameObject_t1113636619 * L_4 = ((AppResources_t1237449672_StaticFields*)il2cpp_codegen_static_fields_for(AppResources_t1237449672_il2cpp_TypeInfo_var))->get_Section_1_2();
		return L_4;
	}
}
// System.Void SectionContainer::PoolSection(Section)
extern "C"  void SectionContainer_PoolSection_m2424153165 (SectionContainer_t1774584350 * __this, Section_t3531603569 * ___section0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SectionContainer_PoolSection_m2424153165_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Section_t3531603569 * V_1 = NULL;
	SectionContainer_t1774584350 * G_B6_0 = NULL;
	SectionContainer_t1774584350 * G_B5_0 = NULL;
	Section_t3531603569 * G_B7_0 = NULL;
	SectionContainer_t1774584350 * G_B7_1 = NULL;
	{
		Section_t3531603569 * L_0 = ___section0;
		NullCheck(L_0);
		Transform_t3600365921 * L_1 = Component_get_transform_m3162698980(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		GameObject_t1113636619 * L_2 = Component_get_gameObject_m442555142(L_1, /*hidden argument*/NULL);
		NullCheck(L_2);
		GameObject_SetActive_m796801857(L_2, (bool)0, /*hidden argument*/NULL);
		Section_t3531603569 * L_3 = ___section0;
		NullCheck(L_3);
		Transform_t3600365921 * L_4 = Component_get_transform_m3162698980(L_3, /*hidden argument*/NULL);
		Transform_t3600365921 * L_5 = __this->get_reservedTransform_4();
		NullCheck(L_4);
		Transform_SetParent_m381167889(L_4, L_5, /*hidden argument*/NULL);
		Transform_t3600365921 * L_6 = __this->get_reservedTransform_4();
		NullCheck(L_6);
		int32_t L_7 = Transform_get_childCount_m3145433196(L_6, /*hidden argument*/NULL);
		int32_t L_8 = Random_Range_m4054026115(NULL /*static, unused*/, 0, L_7, /*hidden argument*/NULL);
		V_0 = L_8;
		Transform_t3600365921 * L_9 = __this->get_reservedTransform_4();
		int32_t L_10 = V_0;
		NullCheck(L_9);
		Transform_t3600365921 * L_11 = Transform_GetChild_m1092972975(L_9, L_10, /*hidden argument*/NULL);
		NullCheck(L_11);
		Section_t3531603569 * L_12 = Component_GetComponent_TisSection_t3531603569_m2204478105(L_11, /*hidden argument*/Component_GetComponent_TisSection_t3531603569_m2204478105_RuntimeMethod_var);
		V_1 = L_12;
		Section_t3531603569 * L_13 = V_1;
		NullCheck(L_13);
		int32_t L_14 = L_13->get_type_5();
		if (L_14)
		{
			goto IL_005f;
		}
	}
	{
		int32_t L_15 = __this->get_sectionCount_7();
		__this->set_sectionCount_7(((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1)));
	}

IL_005f:
	{
		int32_t L_16 = __this->get_sectionCount_7();
		if ((((int32_t)L_16) <= ((int32_t)1)))
		{
			goto IL_007a;
		}
	}
	{
		Section_t3531603569 * L_17 = SectionContainer_GetSectionFromReservedByType_m496361358(__this, 1, /*hidden argument*/NULL);
		V_1 = L_17;
		__this->set_sectionCount_7(0);
	}

IL_007a:
	{
		Section_t3531603569 * L_18 = V_1;
		NullCheck(L_18);
		Transform_t3600365921 * L_19 = Component_get_transform_m3162698980(L_18, /*hidden argument*/NULL);
		Transform_t3600365921 * L_20 = Component_get_transform_m3162698980(__this, /*hidden argument*/NULL);
		NullCheck(L_19);
		Transform_SetParent_m381167889(L_19, L_20, /*hidden argument*/NULL);
		Section_t3531603569 * L_21 = V_1;
		NullCheck(L_21);
		Transform_t3600365921 * L_22 = Component_get_transform_m3162698980(L_21, /*hidden argument*/NULL);
		NullCheck(L_22);
		GameObject_t1113636619 * L_23 = Component_get_gameObject_m442555142(L_22, /*hidden argument*/NULL);
		NullCheck(L_23);
		GameObject_SetActive_m796801857(L_23, (bool)1, /*hidden argument*/NULL);
		Section_t3531603569 * L_24 = __this->get_lastReservedSection_5();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		bool L_25 = Object_op_Equality_m1810815630(NULL /*static, unused*/, L_24, (Object_t631007953 *)NULL, /*hidden argument*/NULL);
		G_B5_0 = __this;
		if (!L_25)
		{
			G_B6_0 = __this;
			goto IL_00c9;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(SectionContainer_t1774584350_il2cpp_TypeInfo_var);
		List_1_t708711015 * L_26 = ((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->get_sections_2();
		List_1_t708711015 * L_27 = ((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->get_sections_2();
		NullCheck(L_27);
		int32_t L_28 = List_1_get_Count_m3805462939(L_27, /*hidden argument*/List_1_get_Count_m3805462939_RuntimeMethod_var);
		NullCheck(L_26);
		Section_t3531603569 * L_29 = List_1_get_Item_m1934819507(L_26, ((int32_t)il2cpp_codegen_subtract((int32_t)L_28, (int32_t)1)), /*hidden argument*/List_1_get_Item_m1934819507_RuntimeMethod_var);
		G_B7_0 = L_29;
		G_B7_1 = G_B5_0;
		goto IL_00cf;
	}

IL_00c9:
	{
		Section_t3531603569 * L_30 = __this->get_lastReservedSection_5();
		G_B7_0 = L_30;
		G_B7_1 = G_B6_0;
	}

IL_00cf:
	{
		NullCheck(G_B7_1);
		G_B7_1->set_lastReservedSection_5(G_B7_0);
		Section_t3531603569 * L_31 = V_1;
		Section_t3531603569 * L_32 = __this->get_lastReservedSection_5();
		NullCheck(L_31);
		Section_Move_m3056575733(L_31, L_32, /*hidden argument*/NULL);
		Section_t3531603569 * L_33 = V_1;
		__this->set_lastReservedSection_5(L_33);
		return;
	}
}
// Section SectionContainer::GetUnactiveSection()
extern "C"  Section_t3531603569 * SectionContainer_GetUnactiveSection_m2430424878 (SectionContainer_t1774584350 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SectionContainer_GetUnactiveSection_m2430424878_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Section_t3531603569 * V_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(SectionContainer_t1774584350_il2cpp_TypeInfo_var);
		List_1_t708711015 * L_0 = ((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->get_sections_2();
		List_1_t708711015 * L_1 = ((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->get_sections_2();
		NullCheck(L_1);
		int32_t L_2 = List_1_get_Count_m3805462939(L_1, /*hidden argument*/List_1_get_Count_m3805462939_RuntimeMethod_var);
		int32_t L_3 = Random_Range_m4054026115(NULL /*static, unused*/, 0, L_2, /*hidden argument*/NULL);
		NullCheck(L_0);
		Section_t3531603569 * L_4 = List_1_get_Item_m1934819507(L_0, L_3, /*hidden argument*/List_1_get_Item_m1934819507_RuntimeMethod_var);
		V_0 = L_4;
	}

IL_001b:
	{
		IL2CPP_RUNTIME_CLASS_INIT(SectionContainer_t1774584350_il2cpp_TypeInfo_var);
		List_1_t708711015 * L_5 = ((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->get_sections_2();
		List_1_t708711015 * L_6 = ((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->get_sections_2();
		NullCheck(L_6);
		int32_t L_7 = List_1_get_Count_m3805462939(L_6, /*hidden argument*/List_1_get_Count_m3805462939_RuntimeMethod_var);
		int32_t L_8 = Random_Range_m4054026115(NULL /*static, unused*/, 0, L_7, /*hidden argument*/NULL);
		NullCheck(L_5);
		Section_t3531603569 * L_9 = List_1_get_Item_m1934819507(L_5, L_8, /*hidden argument*/List_1_get_Item_m1934819507_RuntimeMethod_var);
		V_0 = L_9;
		Section_t3531603569 * L_10 = V_0;
		NullCheck(L_10);
		Transform_t3600365921 * L_11 = Component_get_transform_m3162698980(L_10, /*hidden argument*/NULL);
		NullCheck(L_11);
		GameObject_t1113636619 * L_12 = Component_get_gameObject_m442555142(L_11, /*hidden argument*/NULL);
		NullCheck(L_12);
		bool L_13 = GameObject_get_activeSelf_m1767405923(L_12, /*hidden argument*/NULL);
		if (L_13)
		{
			goto IL_001b;
		}
	}
	{
		Section_t3531603569 * L_14 = V_0;
		return L_14;
	}
}
// Section SectionContainer::GetSectionFromReservedByType(SectionType)
extern "C"  Section_t3531603569 * SectionContainer_GetSectionFromReservedByType_m496361358 (SectionContainer_t1774584350 * __this, int32_t ___type0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SectionContainer_GetSectionFromReservedByType_m496361358_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Section_t3531603569 * V_1 = NULL;
	int32_t V_2 = 0;
	{
		Transform_t3600365921 * L_0 = __this->get_reservedTransform_4();
		NullCheck(L_0);
		int32_t L_1 = Transform_get_childCount_m3145433196(L_0, /*hidden argument*/NULL);
		int32_t L_2 = Random_Range_m4054026115(NULL /*static, unused*/, 0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		Transform_t3600365921 * L_3 = __this->get_reservedTransform_4();
		int32_t L_4 = V_0;
		NullCheck(L_3);
		Transform_t3600365921 * L_5 = Transform_GetChild_m1092972975(L_3, L_4, /*hidden argument*/NULL);
		NullCheck(L_5);
		Section_t3531603569 * L_6 = Component_GetComponent_TisSection_t3531603569_m2204478105(L_5, /*hidden argument*/Component_GetComponent_TisSection_t3531603569_m2204478105_RuntimeMethod_var);
		V_1 = L_6;
		V_2 = 0;
	}

IL_0026:
	{
		Transform_t3600365921 * L_7 = __this->get_reservedTransform_4();
		NullCheck(L_7);
		int32_t L_8 = Transform_get_childCount_m3145433196(L_7, /*hidden argument*/NULL);
		int32_t L_9 = Random_Range_m4054026115(NULL /*static, unused*/, 0, L_8, /*hidden argument*/NULL);
		V_0 = L_9;
		Transform_t3600365921 * L_10 = __this->get_reservedTransform_4();
		int32_t L_11 = V_0;
		NullCheck(L_10);
		Transform_t3600365921 * L_12 = Transform_GetChild_m1092972975(L_10, L_11, /*hidden argument*/NULL);
		NullCheck(L_12);
		Section_t3531603569 * L_13 = Component_GetComponent_TisSection_t3531603569_m2204478105(L_12, /*hidden argument*/Component_GetComponent_TisSection_t3531603569_m2204478105_RuntimeMethod_var);
		V_1 = L_13;
		int32_t L_14 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_14, (int32_t)1));
		int32_t L_15 = V_2;
		if ((((int32_t)L_15) <= ((int32_t)((int32_t)1000))))
		{
			goto IL_005e;
		}
	}
	{
		goto IL_006a;
	}

IL_005e:
	{
		Section_t3531603569 * L_16 = V_1;
		NullCheck(L_16);
		int32_t L_17 = L_16->get_type_5();
		int32_t L_18 = ___type0;
		if ((!(((uint32_t)L_17) == ((uint32_t)L_18))))
		{
			goto IL_0026;
		}
	}

IL_006a:
	{
		Section_t3531603569 * L_19 = V_1;
		return L_19;
	}
}
// System.Void SectionContainer::.cctor()
extern "C"  void SectionContainer__cctor_m4081164715 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SectionContainer__cctor_m4081164715_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		List_1_t708711015 * L_0 = (List_1_t708711015 *)il2cpp_codegen_object_new(List_1_t708711015_il2cpp_TypeInfo_var);
		List_1__ctor_m1340754610(L_0, /*hidden argument*/List_1__ctor_m1340754610_RuntimeMethod_var);
		((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->set_sections_2(L_0);
		List_1_t708711015 * L_1 = (List_1_t708711015 *)il2cpp_codegen_object_new(List_1_t708711015_il2cpp_TypeInfo_var);
		List_1__ctor_m1340754610(L_1, /*hidden argument*/List_1__ctor_m1340754610_RuntimeMethod_var);
		((SectionContainer_t1774584350_StaticFields*)il2cpp_codegen_static_fields_for(SectionContainer_t1774584350_il2cpp_TypeInfo_var))->set_generated_3(L_1);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
