#include "Utility.h"
#include "Obstacle.h"
#include <time.h>>



Obstacle::Obstacle()
{
}

Obstacle::Obstacle(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model)
{
	SetSpeed(_speed);
	SetColor(_color);
	SetModel(_model);

	srand(time(NULL));

	if (rand()%2)
	{
		SetX(rand() % Console::WindowWidth());
		vert = true;
		if (rand() % 2)
		{
			SetSpeed(1);
			SetY(0);
		}
		else
		{
			SetSpeed(-1);
			SetY(Console::WindowHeight() - 2);
		}
	}
	else
	{
		SetY(rand() % Console::WindowHeight());
		horz = true;
		if (rand() % 2)
		{
			SetSpeed(1);
			SetX(0);
		}
		else
		{
			SetSpeed(-1);
			SetX(Console::WindowHeight() - 1);
		}
	}
}

Obstacle::~Obstacle()
{
}


void  Obstacle::Update()
{



}


void Obstacle::Render()
{
	Console::ForegroundColor(Base::GetColor());
	Console::SetCursorPosition(Base::GetX(), Base::GetY());
	cout << Base::GetName();
	Console::ResetColor();
}
