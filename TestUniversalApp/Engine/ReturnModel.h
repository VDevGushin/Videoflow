pragma once
#include <string>

using namespace std;



	struct Employee
	{
		char* name;
		short id;
		int age;
		double wage;
	};

    class ReturnModel 
	{
	public:
		char *char_p;
		Employee joe;

		ReturnModel();
	};

