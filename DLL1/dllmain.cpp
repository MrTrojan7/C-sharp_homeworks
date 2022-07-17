// dllmain.cpp : Определяет точку входа для приложения DLL.
#include "pch.h"

BOOL APIENTRY DllMain(HMODULE hModule,
    DWORD  ul_reason_for_call,
    LPVOID lpReserved
)
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

#define EXTERN_DLL_EXPORT extern "C" __declspec(dllexport)

#include <iostream>
using namespace std;

EXTERN_DLL_EXPORT void CppFunction()
{
    cout << "Hello from Cpp Dll!\n";
}