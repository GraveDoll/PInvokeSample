#include "stdafx.h"
#include "UnmanagedDLL.h"

char str[256] = "Hello ";

DLL int add(int a, int b) {
	return a + b;
}

DLL char *concat(char *c) {
	strcat_s(str, 256, c);
	return str;
}