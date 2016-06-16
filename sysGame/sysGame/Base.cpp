#include "Utility.h"
#include "Base.h"
#include <time.h>


Base::Base(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model)// : speed(_speed)  <-- Member Initializer List
{
	SetSpeed(_speed);
	SetColor(_color);
	SetModel(_model);
	SetX(_x);
	SetY(_y);
}
Base::Base()
{

}


Base::~Base()
{

}



void Base::SetModel(string _model)
{
	model = _model;
}

void Base::Render()
{

}

 void Base::Update()
{

}

void Base::WhoAmI()
{
	cout << "I am a vehicle.";
}






void Base::Rand()
{




	srand(time(false));

	if (rand() % 2)
	{
		SetX(rand() % Console::WindowWidth() + 1);
		if (rand() % 2)
		{
			SetSpeed(1);
			SetY(1);
		}
		else
		{
			SetSpeed(-1);
			SetY(Console::WindowHeight() - 2);
		}
	}
	else
	{
		SetY(rand() % Console::WindowHeight() + 1);
		if (rand() % 2)
		{
			SetSpeed((rand() % 3) + 1);
			SetX(1);
		}
		else
		{
			SetSpeed(((rand() % 3) + 1)*-1);
			SetX(Console::WindowWidth() - 8);
		}
	}
}