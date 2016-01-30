#pragma once
#include "MathFuncs.h"
#include "EmployeeWrapper.h"

namespace Engine {


	public ref class managedDllWrapper sealed
	{
	public:
		managedDllWrapper();
		double AddWrapper(double a, double b);
		double SubtractWrapper(double a, double b);
		double MultiplyWrapper(double a, double b);
		double DivideWrapper(double a, double b);
		void GetModel(double wage);
	
	private:
		MathFuncs *myCppClass;
	};
}

