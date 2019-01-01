// UnmanagedDll.cpp : DLL アプリケーション用にエクスポートされる関数を定義します。
//

#include "stdafx.h"
#include "UnmanagedDll.h"

DLL int add(int a, int b)
{
	return a + b;
}