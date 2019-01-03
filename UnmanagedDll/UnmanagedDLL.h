#pragma once
#include<windows.h>
#include<string>

#ifdef __cplusplus
extern "C"
{
#endif

#define DLL __declspec(dllexport)

DLL int add(int a, int b);
DLL char *concat(char *c);

#ifdef __cplusplus
}
#endif