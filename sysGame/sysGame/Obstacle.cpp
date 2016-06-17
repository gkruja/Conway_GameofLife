#include "Utility.h"
#include "Obstacle.h"
#include <time.h>



Obstacle::Obstacle()
{
}

Obstacle::Obstacle(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model)
{
	vert = false;
	horz = false;
	SetColor(_color);
	SetModel(_model);
	if (_speed == 1)
		Base::enemy = false;

	srand(time(NULL));
	if (rand()%2)
	{
		srand(time(NULL));
		SetX(rand() % Console::WindowWidth()+1);
		vert = true;
		srand(time(NULL));
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
		srand(time(NULL));

		SetY((rand() % Console::WindowHeight()-5)+2);
		horz = true;
		srand(time(NULL));

		if (rand() % 2)
		{
			SetSpeed((rand() % 2)+1);
			SetX(1);
		}
		else
		{	
			SetSpeed(((rand() % 2)+1)*-1);
			SetX(Console::WindowWidth() - 1);
		}
	}
}

Obstacle::~Obstacle()
{
}


void  Obstacle::Update()
{
	if (vert)
		SetY(GetY() + GetSpeed());
	if (horz)
		SetX(GetX() + GetSpeed());
	if (GetX() == Console::WindowWidth() || GetX() == 0)
		SetSpeed(0);
	if (GetY() == Console::WindowHeight() || GetY() == 0)
		SetSpeed(0);

	



}


void Obstacle::Render()
{
	Console::ForegroundColor(Base::GetColor());
	Console::SetCursorPosition(Base::GetX(), Base::GetY());
	cout << Base::GetName();
	Console::ResetColor();

}


