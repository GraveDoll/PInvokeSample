#pragma once

#ifdef __cplusplus
extern "C"
{
#endif

#define DLL __declspec(dllexport)
	
	DLL int add(int a, int b);

#ifdef __cplusplus
}
#endif