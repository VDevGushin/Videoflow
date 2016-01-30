#pragma once
#include <string.h>

using namespace std;


namespace Engine
{
	class  Student
	{
	public:
		Student(char *name, double gpa)
		{
			_fullname = new char[strlen(name + 1)];
			(_fullname, name);
			_gpa = gpa;
		}

		~Student()
		{
			delete[] _fullname;
		}

		double getGpa()
		{			return _gpa;
		}
		char *getName()
		{
			return _fullname;
		}

	private:
		char *_fullname;
		double _gpa;

	};
}