#include "pch.h"
#include "MathFuncs.h"


double MathFuncs::Add(double a, double b)
{
	return a + b;
}

double MathFuncs::Subtract(double a, double b)
{
	return a - b;
}

double MathFuncs::Multiply(double a, double b)
{
	return a*b;
}

double MathFuncs::Divide(double a, double b)
{
	if (b == 0)
		throw   invalid_argument("b cannot be zero!");
	return 0;
}
