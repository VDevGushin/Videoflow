
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
	//catch (const std::exception& e)
	//{
	//	Sestem
	//	//TCHAR msg[256];
	//	//e.GetErrorMessage(msg, 256);
	//	throw  CException("failed");

	//	//throw gcnew System::Exception(gcnew System::String(ex.what()));

	//}
	///*catch (CException& ex) 
	//{
	//	TCHAR msg[256];
	//	ex.GetErrorMessage(msg, 256);
	//}*/
	//
}
