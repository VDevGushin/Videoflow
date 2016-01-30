
#define _AFXDLL
#include <afx.h>
#include <string.h>
#include <tchar.h>
#include "pch.h"
#include "managedDllWrapper.h"
#include <exception>
#include <stdexcept>


using namespace Engine;

managedDllWrapper::managedDllWrapper()
{

	myCppClass = new MathFuncs(); //initiate C++ class's instance
}

double managedDllWrapper::AddWrapper(double a, double b)
{
	return myCppClass->Add(a, b);
}

double Engine::managedDllWrapper::SubtractWrapper(double a, double b)
{
	return myCppClass->Subtract(a, b);
}

double Engine::managedDllWrapper::MultiplyWrapper(double a, double b)
{
	return myCppClass->Multiply(a, b);
}



double Engine::managedDllWrapper::DivideWrapper(double a, double b)
{
	try
	{
		return myCppClass->Divide(a, b);
	}
	catch (const std::exception& e)
	{
		char const* me = e.what();	

		throw  Platform::Exception::CreateException(-1,"RrrRrRR sdfsdf");
	}
	catch (...)
	{
		throw  Platform::Exception::CreateException(-1);
	}
}

void Engine::managedDllWrapper::GetModel(double wage)
{
	ReturnModel* model =  myCppClass->GetModel(12.0);
	throw ref new Platform::NotImplementedException();
}



