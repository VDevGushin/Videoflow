#pragma once

#include <stdexcept>
#include "ReturnModel.h"
using namespace std;

class MathFuncs 
{
public:
	double Add(double a, double b);
	double Subtract(double a, double b);
	double Multiply(double a, double b);
	double Divide(double a, double b);
	ReturnModel* GetModel(double age);
private :
	ReturnModel modet2Return;
};

